// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 07:41:20 PM

using CXLIB;

namespace CXCORE
{
    public class CParty
    {

        #region[Get New]

        public static Party GetNew
        {
            get
            {
                Party obj = new Party()
                {
                    Party_id = string.Empty,
                    Party_name = string.Empty,
                    Contacttype_id = string.Empty,
                    Contact_person = string.Empty,
                    Street_1 = string.Empty,
                    Street_2 = string.Empty,
                    City_id = string.Empty,
                    State_id = string.Empty,
                    Country_id = string.Empty,
                    Pincode_id = string.Empty,
                    Phone = string.Empty,
                    Cell = string.Empty,
                    Email = string.Empty,
                    Website = string.Empty,
                    Gstin = string.Empty,
                    Pan = string.Empty,
                    Opening_balance = decimal.Zero,
                    Credit_days = decimal.Zero,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Party v)
        {
            q = q.Replace("@" + PARTY.PARTY_ID + "@", "" + ConvertTO.SqlString(v.Party_id) + "");
            q = q.Replace("@" + PARTY.PARTY_NAME + "@", "" + ConvertTO.SqlString(v.Party_name) + "");
            q = q.Replace("@" + PARTY.CONTACTTYPE_ID + "@", "" + ConvertTO.SqlString(v.Contacttype_id) + "");
            q = q.Replace("@" + PARTY.CONTACT_PERSON + "@", "" + ConvertTO.SqlString(v.Contact_person) + "");
            q = q.Replace("@" + PARTY.STREET_1 + "@", "" + ConvertTO.SqlString(v.Street_1) + "");
            q = q.Replace("@" + PARTY.STREET_2 + "@", "" + ConvertTO.SqlString(v.Street_2) + "");
            q = q.Replace("@" + PARTY.CITY_ID + "@", "" + ConvertTO.SqlString(v.City_id) + "");
            q = q.Replace("@" + PARTY.STATE_ID + "@", "" + ConvertTO.SqlString(v.State_id) + "");
            q = q.Replace("@" + PARTY.COUNTRY_ID + "@", "" + ConvertTO.SqlString(v.Country_id) + "");
            q = q.Replace("@" + PARTY.PINCODE_ID + "@", "" + ConvertTO.SqlString(v.Pincode_id) + "");
            q = q.Replace("@" + PARTY.PHONE + "@", "" + ConvertTO.SqlString(v.Phone) + "");
            q = q.Replace("@" + PARTY.CELL + "@", "" + ConvertTO.SqlString(v.Cell) + "");
            q = q.Replace("@" + PARTY.EMAIL + "@", "" + ConvertTO.SqlString(v.Email) + "");
            q = q.Replace("@" + PARTY.WEBSITE + "@", "" + ConvertTO.SqlString(v.Website) + "");
            q = q.Replace("@" + PARTY.GSTIN + "@", "" + ConvertTO.SqlString(v.Gstin) + "");
            q = q.Replace("@" + PARTY.PAN + "@", "" + ConvertTO.SqlString(v.Pan) + "");
            q = q.Replace("@" + PARTY.OPENING_BALANCE + "@", "" + ConvertTO.SqlDecimal(v.Opening_balance) + "");
            q = q.Replace("@" + PARTY.CREDIT_DAYS + "@", "" + ConvertTO.SqlDecimal(v.Credit_days) + "");
            q = q.Replace("@" + PARTY.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + PARTY.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + PARTY.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Party v, DAL dalsession)
        {
            string q = " INSERT INTO " + PARTY.PARTY_TBL + " ( ";
            q += " " + PARTY.PARTY_NAME + " \r\n ";
            q += "," + PARTY.CONTACTTYPE_ID + " \r\n ";
            q += "," + PARTY.CONTACT_PERSON + " \r\n ";
            q += "," + PARTY.STREET_1 + " \r\n ";
            q += "," + PARTY.STREET_2 + " \r\n ";
            q += "," + PARTY.CITY_ID + " \r\n ";
            q += "," + PARTY.STATE_ID + " \r\n ";
            q += "," + PARTY.COUNTRY_ID + " \r\n ";
            q += "," + PARTY.PINCODE_ID + " \r\n ";
            q += "," + PARTY.PHONE + " \r\n ";
            q += "," + PARTY.CELL + " \r\n ";
            q += "," + PARTY.EMAIL + " \r\n ";
            q += "," + PARTY.WEBSITE + " \r\n ";
            q += "," + PARTY.GSTIN + " \r\n ";
            q += "," + PARTY.PAN + " \r\n ";
            q += "," + PARTY.OPENING_BALANCE + " \r\n ";
            q += "," + PARTY.CREDIT_DAYS + " \r\n ";
            q += "," + PARTY.NOTES + " \r\n ";
            q += "," + PARTY.ACTIVE_ID + " \r\n ";
            q += "," + PARTY.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + PARTY.PARTY_NAME + "@ \r\n ";
            q += ", @" + PARTY.CONTACTTYPE_ID + "@ \r\n ";
            q += ", @" + PARTY.CONTACT_PERSON + "@ \r\n ";
            q += ", @" + PARTY.STREET_1 + "@ \r\n ";
            q += ", @" + PARTY.STREET_2 + "@ \r\n ";
            q += ", @" + PARTY.CITY_ID + "@ \r\n ";
            q += ", @" + PARTY.STATE_ID + "@ \r\n ";
            q += ", @" + PARTY.COUNTRY_ID + "@ \r\n ";
            q += ", @" + PARTY.PINCODE_ID + "@ \r\n ";
            q += ", @" + PARTY.PHONE + "@ \r\n ";
            q += ", @" + PARTY.CELL + "@ \r\n ";
            q += ", @" + PARTY.EMAIL + "@ \r\n ";
            q += ", @" + PARTY.WEBSITE + "@ \r\n ";
            q += ", @" + PARTY.GSTIN + "@ \r\n ";
            q += ", @" + PARTY.PAN + "@ \r\n ";
            q += ", @" + PARTY.OPENING_BALANCE + "@ \r\n ";
            q += ", @" + PARTY.CREDIT_DAYS + "@ \r\n ";
            q += ", @" + PARTY.NOTES + "@ \r\n ";
            q += ", @" + PARTY.ACTIVE_ID + "@ \r\n ";
            q += ", @" + PARTY.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Party v, DAL dalsession)
        {
            string q = "UPDATE " + PARTY.PARTY_TBL + " SET";
            q += " " + PARTY.PARTY_NAME + " = @" + PARTY.PARTY_NAME + "@ \r\n ";
            q += "," + PARTY.CONTACTTYPE_ID + " = @" + PARTY.CONTACTTYPE_ID + "@ \r\n ";
            q += "," + PARTY.CONTACT_PERSON + " = @" + PARTY.CONTACT_PERSON + "@ \r\n ";
            q += "," + PARTY.STREET_1 + " = @" + PARTY.STREET_1 + "@ \r\n ";
            q += "," + PARTY.STREET_2 + " = @" + PARTY.STREET_2 + "@ \r\n ";
            q += "," + PARTY.CITY_ID + " = @" + PARTY.CITY_ID + "@ \r\n ";
            q += "," + PARTY.STATE_ID + " = @" + PARTY.STATE_ID + "@ \r\n ";
            q += "," + PARTY.COUNTRY_ID + " = @" + PARTY.COUNTRY_ID + "@ \r\n ";
            q += "," + PARTY.PINCODE_ID + " = @" + PARTY.PINCODE_ID + "@ \r\n ";
            q += "," + PARTY.PHONE + " = @" + PARTY.PHONE + "@ \r\n ";
            q += "," + PARTY.CELL + " = @" + PARTY.CELL + "@ \r\n ";
            q += "," + PARTY.EMAIL + " = @" + PARTY.EMAIL + "@ \r\n ";
            q += "," + PARTY.WEBSITE + " = @" + PARTY.WEBSITE + "@ \r\n ";
            q += "," + PARTY.GSTIN + " = @" + PARTY.GSTIN + "@ \r\n ";
            q += "," + PARTY.PAN + " = @" + PARTY.PAN + "@ \r\n ";
            q += "," + PARTY.OPENING_BALANCE + " = @" + PARTY.OPENING_BALANCE + "@ \r\n ";
            q += "," + PARTY.CREDIT_DAYS + " = @" + PARTY.CREDIT_DAYS + "@ \r\n ";
            q += "," + PARTY.NOTES + " = @" + PARTY.NOTES + "@ \r\n ";
            q += "," + PARTY.ACTIVE_ID + " = @" + PARTY.ACTIVE_ID + "@ \r\n ";
            q += "," + PARTY.USER_ID + " = @" + PARTY.USER_ID + "@ \r\n ";
            q += "  WHERE " + PARTY.PARTY_ID + " = @" + PARTY.PARTY_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + PARTY.PARTY_TBL + " WHERE " + PARTY.PARTY_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
