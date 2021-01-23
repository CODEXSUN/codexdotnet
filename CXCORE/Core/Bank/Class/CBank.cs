// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 11:17:05 PM

using CXLIB;

namespace CXCORE
{
    public class CBank
    {

        #region[Get New]

        public static Bank GetNew
        {
            get
            {
                Bank obj = new Bank()
                {
                    Bank_id = string.Empty,
                    Bank_name = string.Empty,
                    Account_number = string.Empty,
                    Ifsc_code = string.Empty,
                    Opening_balance = decimal.Zero,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Bank v)
        {
            q = q.Replace("@" + BANK.BANK_ID + "@", "" + ConvertTO.SqlString(v.Bank_id) + "");
            q = q.Replace("@" + BANK.BANK_NAME + "@", "" + ConvertTO.SqlString(v.Bank_name) + "");
            q = q.Replace("@" + BANK.ACCOUNT_NUMBER + "@", "" + ConvertTO.SqlString(v.Account_number) + "");
            q = q.Replace("@" + BANK.IFSC_CODE + "@", "" + ConvertTO.SqlString(v.Ifsc_code) + "");
            q = q.Replace("@" + BANK.OPENING_BALANCE + "@", "" + ConvertTO.SqlDecimal(v.Opening_balance) + "");
            q = q.Replace("@" + BANK.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + BANK.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + BANK.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Bank v, DAL dalsession)
        {
            string q = " INSERT INTO " + BANK.BANK_TBL + " ( ";
            q += " " + BANK.BANK_NAME + " \r\n ";
            q += "," + BANK.ACCOUNT_NUMBER + " \r\n ";
            q += "," + BANK.IFSC_CODE + " \r\n ";
            q += "," + BANK.OPENING_BALANCE + " \r\n ";
            q += "," + BANK.NOTES + " \r\n ";
            q += "," + BANK.ACTIVE_ID + " \r\n ";
            q += "," + BANK.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + BANK.BANK_NAME + "@ \r\n ";
            q += ", @" + BANK.ACCOUNT_NUMBER + "@ \r\n ";
            q += ", @" + BANK.IFSC_CODE + "@ \r\n ";
            q += ", @" + BANK.OPENING_BALANCE + "@ \r\n ";
            q += ", @" + BANK.NOTES + "@ \r\n ";
            q += ", @" + BANK.ACTIVE_ID + "@ \r\n ";
            q += ", @" + BANK.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Bank v, DAL dalsession)
        {
            string q = "UPDATE " + BANK.BANK_TBL + " SET";
            q += " " + BANK.BANK_NAME + " = @" + BANK.BANK_NAME + "@ \r\n ";
            q += "," + BANK.ACCOUNT_NUMBER + " = @" + BANK.ACCOUNT_NUMBER + "@ \r\n ";
            q += "," + BANK.IFSC_CODE + " = @" + BANK.IFSC_CODE + "@ \r\n ";
            q += "," + BANK.OPENING_BALANCE + " = @" + BANK.OPENING_BALANCE + "@ \r\n ";
            q += "," + BANK.NOTES + " = @" + BANK.NOTES + "@ \r\n ";
            q += "," + BANK.ACTIVE_ID + " = @" + BANK.ACTIVE_ID + "@ \r\n ";
            q += "," + BANK.USER_ID + " = @" + BANK.USER_ID + "@ \r\n ";
            q += "  WHERE " + BANK.BANK_ID + " = @" + BANK.BANK_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + BANK.BANK_TBL + " WHERE " + BANK.BANK_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
