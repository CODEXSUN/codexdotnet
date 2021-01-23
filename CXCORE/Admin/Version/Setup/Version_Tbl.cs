// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 10-08-2020 10:29:15 AM

using CXLIB; 

namespace CXCORE
{
    public class Version_Tbl
    {
        #region[Create Table]

        public Version_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(VERSION.VERSION_TBL);
            q += AddFields.Primary(VERSION.VERSION_ID);
            q += AddFields.Unique_500(VERSION.VERSION_NAME); 
            q += AddFields.Date(VERSION.CREATED_ON); 
            q += AddFields.VARCHAR_500(VERSION.CHANGES); 
            q += AddFields.EOF;

            new DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_Version(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(VERSION.VERSION_TBL);
            q += DB.FIELD_1ST(VERSION.VERSION_ID);
            q += DB.FIELD(VERSION.VERSION_NAME);
            q += DB.FIELD(VERSION.CREATED_ON);
            q += DB.FIELD(VERSION.CHANGES);
            q += DB.MID;
            q += DB.VALUE_1ST("1");
            q += DB.VALUE("4.0.0.2");
            q += DB.VALUE("2020-08-10");
            q += DB.VALUE("Adding Cash Book");
            q += DB.EOF;

            new DAL().Execute(q);

        }

        #endregion[Default Values]

    }//cls
}//ns
