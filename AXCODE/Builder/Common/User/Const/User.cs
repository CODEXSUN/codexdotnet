// Version : 1 dt : 11-07-2017
// Auto Generated
// 13-07-2017 10:42:25 PM
// last update : 13-07-2017

using CXLIB;

namespace AXCODE
{
    #region[Properties]

    public class User
    {
        public string User_id { get; set; } = string.Empty;
        public string User_name { get; set; } = string.Empty;
        public string User_password { get; set; } = string.Empty;
        public string Createon { get; set; } = string.Empty;
        public string Entryby { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public string Active_id { get; set; } = Core.Active;
    }

    #endregion[Properties]

    #region[string Const class]

    public class USER
    {
        public const string USER_ID  = "USER_ID";
        public const string USER_NAME = "USER_NAME";
        public const string USER_PASSWORD = "USER_PASSWORD";
        public const string CREATEON = "CREATEON";
        public const string ENTRYBY = "ENTRYBY";
        public const string NOTES = "NOTES";
        public const string ACTIVE_ID = "ACTIVE_ID";
        // 
        public const string USER_TBL = "USER_TBL";
    }

    #endregion[string Const class]

    }
