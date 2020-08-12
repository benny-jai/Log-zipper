using System;
using System.Collections.Generic;
using System.Linq;
using Zipper.Enums;
using Zipper.Model;
using Zipper.Sql;

namespace Zipper.Helpers
{
    public static class Extensions
    {
        public static List<DYN_EVENTLOG> GetDecisionLogs(this List<DYN_EVENTLOG> logs)
        {
            return logs.Where(l => l.EntryId == (int)EntryEnum.ApprovedBy
                || l.EntryId == (int)EntryEnum.ApprovedSubjectToChange
                || l.EntryId == (int)EntryEnum.RejectedBy)
                .OrderBy(l => l.CreatedDate)
                .ToList();
        }

        public static int GetVersionNumber(this PROJECT_TASK_ASSET_VERSION version)
        {
            return int.Parse(version.VERSION.Replace("V ", ""));
        }
        public static int GetVersionNumber(this PROJECT_TASK_FORM_VERSION version)
        {
            return int.Parse(version.VERSION.Replace("V ", ""));
        }

        public static List<ProjectTaskAssetUserWithAccount> GetCompletedDecisions(this PROJECT_TASK_ASSET asset)
        {
            return asset.Decisions
                .Where(d => d.STATUS > 0)
                .OrderBy(d => d.MODIFIED_DATE)
                .ToList();
        }
        public static List<PROJECT_TASK_FORM_USER> GetCompletedDecisions(this PROJECT_TASK_ATTRIBUTE_FORM form)
        {
            return form.Decision
                .Where(d => d.STATUS > 0)
                .OrderBy(d => d.MODIFIED_DATE)
                .ToList();
        }
        public static DecisionTypeEnum GetDecisionType(this DYN_EVENTLOG evnt)
        {
            switch (evnt.EntryId)
            {
                case (int)EntryEnum.ApprovedSubjectToChange:
                    return DecisionTypeEnum.ApprovedWithChanges;
                case (int)EntryEnum.RejectedBy:
                    return DecisionTypeEnum.Rejected;
                case (int)EntryEnum.ApprovedBy:
                    return DecisionTypeEnum.Approved;
                default:
                    throw new Exception($"Unhandled type: {evnt.EntryId}");
            }
        }

        public static string GetAction(this PROJECT_TASK_FEEDBACK feedback)
        {
            switch (feedback.ACTION_STATUS)
            {
                case 0:
                    return "NoActionRequired";
                case 2:
                    return "ApprovalFeedback";
                case 3:
                    return "RejectionFeedback";
            }
            return "";
        }
    }
}
