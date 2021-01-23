// Version : 4.0.0.1 dt : 12-07-2020
// Created by : SUNDAR
// last update : 12-07-2020 09:57:15 AM

namespace AXCODE
{
    #region[Properties]

    public class MasterTables
    {
        public string Mastertables_id { get; set; }
        public string Databases_id { get; set; }
        public string Mastertables_name { get; set; }
        public string Alias { get; set; }
        public string Namespaces_id { get; set; }
        public string Active_id { get; set; }
    }

    #endregion[Properties]

    #region[string Const class]

    public class MASTERTABLES
    {
        public const string MASTERTABLES_ID = "MASTERTABLES_ID";
        public const string DATABASES_ID = "DATABASES_ID";
        public const string MASTERTABLES_NAME = "MASTERTABLES_NAME";
        public const string ALIAS = "ALIAS";
        public const string NAMESPACES_ID = "NAMESPACES_ID";
        public const string ACTIVE_ID = "ACTIVE_ID";

        public const string MASTERTABLES_TBL = "MASTERTABLES_TBL";
    }

    #endregion[string Const class]

}//ns
