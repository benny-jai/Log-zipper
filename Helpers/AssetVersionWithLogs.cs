using System.Collections.Generic;
using Zipper.Model;
using Zipper.Sql;

namespace Zipper.Helpers
{
    public class AssetVersionWithLogs
    {
        public int VersionNumber;
        public PROJECT_TASK_ASSET_VERSION Version;
        public List<DYN_EVENTLOG> Logs;
        public List<ProjectTaskAssetUserWithAccount> Decisions;
    }
}
