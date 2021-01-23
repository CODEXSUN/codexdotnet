namespace CXLIB
{

    public static class USE
    {
        public static string DB(string database)
        {
            return "USE " + database + ";\r\n";
        }
    }
    public static class CREATE
    {
        public static string TABLE(string v)
        {
            return "CREATE TABLE IF NOT EXISTS " + v + "(\r\n";
        }
    }

    public static class DB
    {
        public static string INSERT(string v)
        {
            return "INSERT INTO " + v + "(\r\n";
        }

        public static string FIELD(string v)
        {
            return "," + v + "\r\n";
        }

        public static string FIELD_1ST(string v)
        {
            return " " + v + "\r\n";
        }

        public static string VALUE_1ST(string v)
        {
            return " '" + v + "'\r\n";
        }

        public static string VALUE(string v)
        {
            return " ,'" + v + "'\r\n";
        }


        public static string MID => " ) VALUES( \r\n";

        public static string ROW_NEXT_VALUE => " ), ( \r\n";


        public static string EOF => ");\r\n";

        public static string NOTES => " ,NOTES\r\n";
        public static string ACTIVE_ID => " ,ACTIVE_ID\r\n";
        public static string NotesValue => " ,''\r\n";
        public static string ActiveValue => " ,'1'\r\n";

        public static string USER_ID => " ,USER_ID\r\n";
        public static string UserValue => " ,'1'\r\n";
    }

    public static class AddFields
    {
        #region[PKeys]
        public static string Primary(string v)
        {
            return "" + v + " INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_" + v + " PRIMARY KEY(" + v + ")\r\n";
        }

        public static string Foreign(string v, string foreign)
        {
            return "," + foreign + " INT NOT NULL , CONSTRAINT FK_" + RemoveTbl(v) + "_" + foreign + " FOREIGN KEY(" + foreign + ")REFERENCES " + RemoveId(foreign) + "_TBL(" + foreign + ")\r\n";
        }



        #endregion[Pkeys]

        #region[Int]

        public static string Int(string v)
        {
            return "," + v + " INT NOT NULL\r\n";
        }

        #endregion[Int]

        #region[Unique]

        public static string Unique_500(string v)
        {
            return "," + v + " VARCHAR(500) NOT NULL UNIQUE\r\n";
        }



        #endregion[Unique]

        #region[varchar]
        public static string VARCHAR_500(string v)
        {
            return "," + v + " VARCHAR(500) NOT NULL\r\n";
        }

        public static string VARCHAR_300(string v)
        {
            return "," + v + " VARCHAR(300)NOT NULL \r\n";
        }
        public static string VARCHAR_200(string v)
        {
            return "," + v + " VARCHAR(200)NOT NULL \r\n";
        }

        public static string VARCHAR_100(string v)
        {
            return "," + v + " VARCHAR(100) NOT NULL \r\n";
        }



        #endregion[varchar]

        #region[SMALL INT]
        public static string Smallint(string v)
        {
            return "," + v + " SMALLINT(1) NOT NULL\r\n";
        }
        #endregion[Small Int]

        #region[DATE]
        public static string DateTime(string v)
        {
            return "," + v + " DATETIME NOT NULL\r\n";
        }
        public static string Date(string v)
        {
            return "," + v + " DATE NOT NULL\r\n";
        }

        #endregion[DATE]

        #region[Decimal]
        public static string Decimal_3(string v)
        {
            return "," + v + " DECIMAL(11,3) NOT NULL\r\n";
        }

        public static string Decimal_2(string v)
        {
            return "," + v + " DECIMAL(11,2) NOT NULL\r\n";
        }
        #endregion[Decimal]

        #region[Notes ,active]
        public static string Notes => ",NOTES VARCHAR(100) NOT NULL\r\n";
        public static string Active => ",ACTIVE_ID  SMALLINT(1) NOT NULL\r\n";
        //public static string Active => ",ACTIVE_ID enum('Y','N') NOT NULL default 'N'\r\n";

        public static string User_id(string v)
        {
            return ", USER_ID INT NOT NULL , CONSTRAINT FK_" + RemoveTbl(v) + "_USER_ID FOREIGN KEY(USER_ID)REFERENCES USER_TBL(USER_ID)\r\n";
        }

        public static string EOF => ");\r\n";

        #endregion[Notes ,active]

        #region[Remove]
        private static string RemoveTbl(string v)
        {
            return v.Remove(v.Length - 4);
        }

        private static string RemoveId(string v)
        {
            return v.Remove(v.Length - 3);
        }

        #endregion[Remove]

    }
}
