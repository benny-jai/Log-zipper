using SimpleInjector;
using System;
using Zipper.IoC;
using Zipper.Workers;

namespace Zipper
{
    using System.Configuration;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using EntityFramework.DbContextScope.Interfaces;
    using log4net;
    using log4net.Config;
    using Repository;
    using Sql;

    class Program
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Program));

        static int Main(string[] args)
        {
            SetupLog();

            var container = new Container();

            Registrations.RegisterTypes(container);

            var scopeFactory = container.GetInstance<IDbContextScopeFactory>();
            var tenantsRepo = container.GetInstance<IReadOnlyRepository<REPORT_LOG_PARSER_TENANTS>>();
            var executionsRepo = container.GetInstance<IRepository<REPORT_LOG_PARSER_EXECUTION>>();
            var executionsRepoForm = container.GetInstance<IRepositoryForm<REPORT_LOG_PARSER_EXECUTION_FORM>>();
            //
            if (args != null && args.Length == 2)
            {
                var tenantId = Int32.Parse(ConfigurationManager.AppSettings["tenantId"]);
                var start = DateTime.ParseExact(args[0], "yyyy-MM-dd", CultureInfo.InvariantCulture);
                var end = DateTime.ParseExact(args[1], "yyyy-MM-dd", CultureInfo.InvariantCulture);

                //var tenantId = 94;
                //var start = DateTime.ParseExact("2018-10-01", "yyyy-MM-dd", CultureInfo.InvariantCulture);
                //var end = DateTime.ParseExact("2018-10-02", "yyyy-MM-dd", CultureInfo.InvariantCulture);

                Log.Info($"Processing tenant {tenantId} from '{start:dd-MM-yyyy}' to '{end:dd-MM-yyyy}'.");

                var worker = container.GetInstance<PopulateAssetDecisionLog>();
                
                var execution = new REPORT_LOG_PARSER_EXECUTION();
                
                execution.TenantId = tenantId;
                execution.RangeFrom = start;
                execution.RangeTo = end;
                execution.StartDate = DateTime.UtcNow;

                try
                {
                    using (var scope = scopeFactory.Create())
                    {
                        executionsRepo.Insert(execution);

                        scope.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    Log.Warn($"Unable to create execution record for tenant {tenantId}.", ex);

                    return -1;
                }

                var success = false;

                try
                {
                    worker.Process(execution);

                    success = true;
                }
                catch (Exception ex)
                {
                    Log.Warn($"Unable to process worker for tenant {tenantId}.", ex);
                }
                finally
                {
                    StoreExecution(scopeFactory, executionsRepo, execution, tenantId, success);
                }

                Log.Info("Done");

                //return 0;
            }

            if (args != null && args.Length == 2)
            {
               var executionForm = new REPORT_LOG_PARSER_EXECUTION_FORM();
                 executionsRepoForm = container.GetInstance<IRepositoryForm<REPORT_LOG_PARSER_EXECUTION_FORM>>();
                var worker_form = container.GetInstance<PopulateFormDecisionLog>();
                var tenantId = Int32.Parse(ConfigurationManager.AppSettings["tenantId"]);
                var start = DateTime.ParseExact(args[0], "yyyy-MM-dd", CultureInfo.InvariantCulture);
                var end = DateTime.ParseExact(args[1], "yyyy-MM-dd", CultureInfo.InvariantCulture);

                //var tenantId = 94;
                //var start = DateTime.ParseExact("2018-10-01", "yyyy-MM-dd", CultureInfo.InvariantCulture);
                //var end = DateTime.ParseExact("2018-10-02", "yyyy-MM-dd", CultureInfo.InvariantCulture);

                Log.Info($"Processing forms for tenant {tenantId} from '{start:dd-MM-yyyy}' to '{end:dd-MM-yyyy}'.");

               
                
                var execution = new REPORT_LOG_PARSER_EXECUTION_FORM();

                execution.TenantId = tenantId;
                execution.RangeFrom = start;
                execution.RangeTo = end;
                execution.StartDate = DateTime.UtcNow;

                try
                {
                    using (var scope = scopeFactory.Create())
                    {
                        executionsRepoForm.Insert(execution);

                        scope.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    Log.Warn($"Unable to create execution form record for tenant {tenantId}.", ex);

                    return -1;
                }

                var success = false;

                try
                {
                    worker_form.Process(execution);

                    success = true;
                }
                catch (Exception ex)
                {
                    Log.Warn($"Unable to process form  worker for tenant {tenantId}.", ex);
                }
                finally
                {
                   FORM_StoreExecution(scopeFactory, executionsRepoForm, execution, tenantId, success);
                }

                Log.Info("Done");

                return 0;
            }


            var tenants = tenantsRepo.Get();

            if (tenants.Any())
            {
                var monthsToProcess = GetMonthsToProcess();
                
                var worker = container.GetInstance<PopulateAssetDecisionLog>();

                var today = DateTime.UtcNow;

                foreach (var tenant in tenants)
                {
                    var baseRangeFrom = today.AddMonths(-monthsToProcess);
                    var rangeFrom = new DateTime(baseRangeFrom.Year, baseRangeFrom.Month, 1);
                    var baseRangeTo = today.AddMonths(1);
                    var rangeTo = new DateTime(baseRangeTo.Year, baseRangeTo.Month, 1).AddDays(-1);

                    Log.Info($"Processing tenant {tenant.TenantId} from '{rangeFrom:dd-MM-yyyy}' to '{rangeTo:dd-MM-yyyy}'.");

                    var execution = new REPORT_LOG_PARSER_EXECUTION();

                    execution.TenantId = tenant.TenantId;
                    execution.RangeFrom = rangeFrom;
                    execution.RangeTo = rangeTo;
                    execution.StartDate = DateTime.UtcNow;

                    try
                    {
                        using (var scope = scopeFactory.Create())
                        {
                            executionsRepo.Insert(execution);

                            scope.SaveChanges();
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.Warn($"Unable to create execution record for tenant {tenant.TenantId}.", ex);

                        continue;
                    }

                    var success = false;

                    try
                    {
                        worker.Process(execution);

                        success = true;
                    }
                    catch (Exception ex)
                    {
                        Log.Warn($"Unable to process worker for tenant {tenant.TenantId}.", ex);

                        continue;
                    }
                    finally
                    {
                        StoreExecution(scopeFactory, executionsRepo, execution, tenant.TenantId, success);
                    }

                    Log.Info($"Completed processing tenant {tenant.TenantId} from '{rangeFrom:dd-MM-yyyy}' to '{rangeTo:dd-MM-yyyy}'.");
                }

                Log.Info("Done");
            }
            if (tenants.Any())
            {

                var monthsToProcess = GetMonthsToProcess();

                var executionForm = new REPORT_LOG_PARSER_EXECUTION_FORM();
                executionsRepoForm = container.GetInstance<IRepositoryForm<REPORT_LOG_PARSER_EXECUTION_FORM>>(); 
              

                var worker_form = container.GetInstance<PopulateFormDecisionLog>();

                var today = DateTime.UtcNow;

                foreach (var tenant in tenants)
                {
                    //var executionForm = new REPORT_LOG_PARSER_EXECUTION_FORM();
                    executionsRepoForm = container.GetInstance<IRepositoryForm<REPORT_LOG_PARSER_EXECUTION_FORM>>();
                   
                    var baseRangeFrom = today.AddMonths(-monthsToProcess);
                    var rangeFrom = new DateTime(baseRangeFrom.Year, baseRangeFrom.Month, 1);
                    var baseRangeTo = today.AddMonths(1);
                    var rangeTo = new DateTime(baseRangeTo.Year, baseRangeTo.Month, 1).AddDays(-1);

                    Log.Info($"Processing tenant {tenant} from '{rangeFrom:dd-MM-yyyy}' to '{rangeTo:dd-MM-yyyy}'.");



                    var execution = new REPORT_LOG_PARSER_EXECUTION_FORM();

                    execution.TenantId = tenant.TenantId;
                    execution.RangeFrom = rangeFrom;
                    execution.RangeTo = rangeTo;
                    execution.StartDate = DateTime.UtcNow;

                    try
                    {
                        using (var scope = scopeFactory.Create())
                        {
                            executionsRepoForm.Insert(execution);

                            scope.SaveChanges();
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.Warn($"Unable to create execution form record for tenant {tenant.TenantId}.", ex);

                        continue;
                    }



                    var success = false;

                    try
                    {
                        worker_form.Process(execution);

                        success = true;
                    }
                    catch (Exception ex)
                    {
                        Log.Warn($"Unable to process form worker for tenant {tenant}.", ex);
                    }
                    finally
                    {
                        FORM_StoreExecution(scopeFactory, executionsRepoForm, execution, tenant.TenantId, success);
                    }

                    Log.Info("Done");

                    return 0;


                    
                }

                Log.Info("Done");
            }

            return 0;
        }

        private static void StoreExecution(IDbContextScopeFactory scopeFactory, IRepository<REPORT_LOG_PARSER_EXECUTION> executionsRepo, REPORT_LOG_PARSER_EXECUTION execution, int tenantId, bool success)
        {
            try
            {
                using (var scope = scopeFactory.Create())
                {
                    var assetsFound = execution.AssetsFound;
                    var assetsProcessed = execution.AssetsProcessed;

                    execution = executionsRepo.Get(execution.Id);

                    execution.AssetsFound = assetsFound;
                    execution.AssetsProcessed = assetsProcessed;
                    execution.AssetsErrors = assetsFound - assetsProcessed;
                    execution.EndDate = DateTime.UtcNow;
                    execution.Success = success;

                    scope.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Log.Warn($"Unable to complete forms execution record for tenant {tenantId}.", ex);
            }
        }

        private static void FORM_StoreExecution(IDbContextScopeFactory scopeFactory, IRepositoryForm<REPORT_LOG_PARSER_EXECUTION_FORM> executionsRepo, REPORT_LOG_PARSER_EXECUTION_FORM execution, int tenantId, bool success)
        {
            try
            {
                using (var scope = scopeFactory.Create())
                {
                    var formsFound = execution.FormssFound;
                    var formsProcessed = execution.FormsProcessed;

                    execution = executionsRepo.Get(execution.Id);

                    execution.FormssFound = formsFound;
                    execution.FormsProcessed = formsProcessed;
                    execution.FormsErrors = formsFound - formsProcessed;
                    execution.EndDate = DateTime.UtcNow;
                    execution.Success = success;

                    scope.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Log.Warn($"Unable to complete execution record for tenant {tenantId}.", ex);
            }
        }

        private static int GetMonthsToProcess()
        {
            var months = 3;

            int.TryParse(ConfigurationManager.AppSettings["MonthsToProcess"], out months);
            
            return months;
        }

        private static void SetupLog()
        {
            var logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log4Net.config");

            var fileInfo = new FileInfo(logFilePath);
            
            XmlConfigurator.ConfigureAndWatch(fileInfo);
        }

        private static void SetupLogForm()
        {
            var logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log4Net.config");

            var fileInfo = new FileInfo(logFilePath);

            XmlConfigurator.ConfigureAndWatch(fileInfo);
        }
    }
}
