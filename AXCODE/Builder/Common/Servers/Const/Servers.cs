// Version : 1 dt : 11-07-2017
// Auto Generated
// 13-07-2017 10:30:24 PM
// last update : 13-07-2017

using CXLIB;

namespace AXCODE
{
    #region[Properties]

    public class Servers
    {
        public string Servers_id { get; set; } = string.Empty;
        public string Servers_name { get; set; } = string.Empty;
        public string Servers_version { get; set; } = string.Empty;
        public string Servers_path { get; set; } = string.Empty;
        public string Servers_backup_path { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public string Active_id { get; set; } = Core.Active;
        public string User_id { get; set; } = Current.User;
    }

    #endregion[Properties]

    #region[string Const class]

    public class SERVERS
    {
        public const string SERVERS_ID  = "SERVERS_ID";
        public const string SERVERS_NAME = "SERVERS_NAME";
        public const string SERVERS_VERSION = "SERVERS_VERSION";
        public const string SERVERS_PATH = "SERVERS_PATH";
        public const string SERVERS_BACKUP_PATH = "SERVERS_BACKUP_PATH";
        public const string NOTES = "NOTES";
        public const string ACTIVE_ID = "ACTIVE_ID";
        public const string USER_ID = "USER_ID";
        // 
        public const string SERVERS_TBL = "SERVERS_TBL";
    }

    #endregion[string Const class]

    }
