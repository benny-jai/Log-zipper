using System.Collections.Generic;
using Zipper.Model;
using Zipper.Sql;

namespace Zipper.Helpers
{
    public class AssetVersionWithLogsAndDecisions
    {
        public int VersionNumber;
        public PROJECT_TASK_ASSET_VERSION Version;
        public List<DYN_EVENTLOG> EventLogs;
        public List<ProjectTaskAssetUserWithAccount> Decisions;
        public List<DecisionLog_Asset> DecisionLogs;
        public List<PROJECT_TASK_FEEDBACK> Feedback;

        public AssetVersionWithLogsAndDecisions()
        {
            DecisionLogs = new List<DecisionLog_Asset>();
        }
    }
}
