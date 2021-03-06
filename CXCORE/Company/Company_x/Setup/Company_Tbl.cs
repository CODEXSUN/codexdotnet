// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 14-07-2020 08:21:36 AM

using CXLIB; 

namespace CXCORE
{
    public class Company_Tbl
    {
        #region[Create Table]

        public Company_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(COMPANY.COMPANY_TBL);
            q += AddFields.Primary(COMPANY.COMPANY_ID);
            q += AddFields.Unique_500(COMPANY.COMPANY_NAME); 
            q += AddFields.VARCHAR_500(COMPANY.DISPLAY_NAME); 
            q += AddFields.VARCHAR_500(COMPANY.STREET1); 
            q += AddFields.VARCHAR_500(COMPANY.STREET2); 
            q += AddFields.Foreign(COMPANY.COMPANY_TBL, COMPANY.CITY_ID); 
            q += AddFields.Foreign(COMPANY.COMPANY_TBL, COMPANY.STATE_ID); 
            q += AddFields.Foreign(COMPANY.COMPANY_TBL, COMPANY.COUNTRY_ID); 
            q += AddFields.Foreign(COMPANY.COMPANY_TBL, COMPANY.PINCODE_ID); 
            q += AddFields.VARCHAR_200(COMPANY.CELL1); 
            q += AddFields.VARCHAR_200(COMPANY.CELL2); 
            q += AddFields.VARCHAR_200(COMPANY.PHONE); 
            q += AddFields.VARCHAR_200(COMPANY.EMAIL); 
            q += AddFields.VARCHAR_500(COMPANY.WEBSITE); 
            q += AddFields.VARCHAR_100(COMPANY.GST); 
            q += AddFields.VARCHAR_100(COMPANY.PAN); 
            q += AddFields.VARCHAR_500(COMPANY.COMP_CODE); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(COMPANY.COMPANY_TBL);
            q += AddFields.EOF;

            new SYS_DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_Company(string db, string company, string display_name)
        {
            string q = USE.DB(db);

            q += DB.INSERT(COMPANY.COMPANY_TBL);
            q += DB.FIELD_1ST(COMPANY.COMPANY_ID);
            q += DB.FIELD(COMPANY.COMPANY_NAME);
            q += DB.FIELD(COMPANY.DISPLAY_NAME);
            q += DB.FIELD(COMPANY.STREET1);
            q += DB.FIELD(COMPANY.STREET2);
            q += DB.FIELD(COMPANY.CITY_ID);
            q += DB.FIELD(COMPANY.STATE_ID);
            q += DB.FIELD(COMPANY.COUNTRY_ID);
            q += DB.FIELD(COMPANY.PINCODE_ID);
            q += DB.FIELD(COMPANY.CELL1);
            q += DB.FIELD(COMPANY.CELL2);
            q += DB.FIELD(COMPANY.PHONE);
            q += DB.FIELD(COMPANY.EMAIL);
            q += DB.FIELD(COMPANY.WEBSITE);
            q += DB.FIELD(COMPANY.GST);
            q += DB.FIELD(COMPANY.PAN);
            q += DB.FIELD(COMPANY.COMP_CODE);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("1");
            q += DB.VALUE(company);
            q += DB.VALUE(display_name);
            q += DB.VALUE("-");
            q += DB.VALUE("-");
            q += DB.VALUE("1");
            q += DB.VALUE("1");
            q += DB.VALUE("1");
            q += DB.VALUE("1");
            q += DB.VALUE("-");
            q += DB.VALUE("-");
            q += DB.VALUE("-");
            q += DB.VALUE("-");
            q += DB.VALUE("-");
            q += DB.VALUE("-");
            q += DB.VALUE("-");
            q += DB.VALUE("0000");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

            new SYS_DAL().Execute(q);

        }

        #endregion[Default Values]

    }//cls
}//ns
