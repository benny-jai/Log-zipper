using System.Collections.Generic;
using Zipper.Model;
using Zipper.Sql;

namespace Zipper.Helpers
{
    public class FormVersionWithLogsAndDecisions
    {
        public int VersionNumber;
        public PROJECT_TASK_FORM_VERSION Version;
        public List<DYN_EVENTLOG> EventLogs;
        public List<PROJECT_TASK_FORM_USER> Decisions;
        public List<DecisionLog_Form> DecisionLogs;
        public List<PROJECT_TASK_FEEDBACK> Feedback;

        public FormVersionWithLogsAndDecisions()
        {
            DecisionLogs = new List<DecisionLog_Form>();
        }
    }
}
