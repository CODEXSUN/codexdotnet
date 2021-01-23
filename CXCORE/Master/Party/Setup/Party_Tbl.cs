// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-05-2019 04:10:38 PM

using CXLIB; 

namespace CXCORE
{
    public class Party_Tbl
    {
        #region[Create Table]

        public Party_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(PARTY.PARTY_TBL);
            q += AddFields.Primary(PARTY.PARTY_ID);
            q += AddFields.Unique_500(PARTY.PARTY_NAME); 
            q += AddFields.Foreign(PARTY.PARTY_TBL, PARTY.CONTACTTYPE_ID); 
            q += AddFields.VARCHAR_500(PARTY.CONTACT_PERSON); 
            q += AddFields.VARCHAR_500(PARTY.STREET_1); 
            q += AddFields.VARCHAR_500(PARTY.STREET_2); 
            q += AddFields.Foreign(PARTY.PARTY_TBL, PARTY.CITY_ID); 
            q += AddFields.Foreign(PARTY.PARTY_TBL, PARTY.STATE_ID); 
            q += AddFields.Foreign(PARTY.PARTY_TBL, PARTY.COUNTRY_ID); 
            q += AddFields.Foreign(PARTY.PARTY_TBL, PARTY.PINCODE_ID); 
            q += AddFields.VARCHAR_500(PARTY.PHONE); 
            q += AddFields.VARCHAR_500(PARTY.CELL); 
            q += AddFields.VARCHAR_500(PARTY.EMAIL); 
            q += AddFields.VARCHAR_500(PARTY.WEBSITE); 
            q += AddFields.VARCHAR_200(PARTY.GSTIN); 
            q += AddFields.VARCHAR_200(PARTY.PAN); 
            q += AddFields.Decimal_2(PARTY.OPENING_BALANCE); 
            q += AddFields.Decimal_2(PARTY.CREDIT_DAYS); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(PARTY.PARTY_TBL);
            q += AddFields.EOF;

           new SYS_DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_Party(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(PARTY.PARTY_TBL);
            q += DB.FIELD_1ST(PARTY.PARTY_ID);
            q += DB.FIELD(PARTY.PARTY_NAME);
            q += DB.FIELD(PARTY.CONTACTTYPE_ID);
            q += DB.FIELD(PARTY.CONTACT_PERSON);
            q += DB.FIELD(PARTY.STREET_1);
            q += DB.FIELD(PARTY.STREET_2);
            q += DB.FIELD(PARTY.CITY_ID);
            q += DB.FIELD(PARTY.STATE_ID);
            q += DB.FIELD(PARTY.COUNTRY_ID);
            q += DB.FIELD(PARTY.PINCODE_ID);
            q += DB.FIELD(PARTY.PHONE);
            q += DB.FIELD(PARTY.CELL);
            q += DB.FIELD(PARTY.EMAIL);
            q += DB.FIELD(PARTY.WEBSITE);
            q += DB.FIELD(PARTY.GSTIN);
            q += DB.FIELD(PARTY.PAN);
            q += DB.FIELD(PARTY.OPENING_BALANCE);
            q += DB.FIELD(PARTY.CREDIT_DAYS);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("1");
            q += DB.VALUE("-");
            q += DB.VALUE("1");
            q += DB.VALUE("-");
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
            q += DB.VALUE("0");
            q += DB.VALUE("0");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

           new SYS_DAL().Execute(q);

        }

        #endregion[Default Values]

    }//cls
}//ns
