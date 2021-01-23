// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 10-08-2020 06:41:06 AM

using CXLIB;

namespace CXACCOUNTS
{
    public static class CCash_payment
    {

        #region[Get New]

        public static Cash_payment GetNew
        {
            get
            {
                Cash_payment obj = new Cash_payment()
                {
                    Cash_payment_id = string.Empty,
                    Order_id = string.Empty,
                    Payment_date = string.Empty,
                    Ledger_id = string.Empty,
                    Purpose = string.Empty,
                    Party_id = string.Empty,
                    Payment_amount = decimal.Zero,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Cash_payment v)
        {
            q = q.Replace("@" + CASH_PAYMENT.CASH_PAYMENT_ID + "@", "" + ConvertTO.SqlString(v.Cash_payment_id) + "");
            q = q.Replace("@" + CASH_PAYMENT.ORDER_ID + "@", "" + ConvertTO.SqlString(v.Order_id) + "");
            q = q.Replace("@" + CASH_PAYMENT.PAYMENT_DATE + "@", "" + ConvertTO.SqlDate(v.Payment_date) + "");
            q = q.Replace("@" + CASH_PAYMENT.LEDGER_ID + "@", "" + ConvertTO.SqlString(v.Ledger_id) + "");
            q = q.Replace("@" + CASH_PAYMENT.PURPOSE + "@", "" + ConvertTO.SqlString(v.Purpose) + "");
            q = q.Replace("@" + CASH_PAYMENT.PARTY_ID + "@", "" + ConvertTO.SqlString(v.Party_id) + "");
            q = q.Replace("@" + CASH_PAYMENT.PAYMENT_AMOUNT + "@", "" + ConvertTO.SqlDecimal(v.Payment_amount) + "");
            q = q.Replace("@" + CASH_PAYMENT.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + CASH_PAYMENT.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + CASH_PAYMENT.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Cash_payment v, DAL dalsession)
        {
            string q = " INSERT INTO " + CASH_PAYMENT.CASH_PAYMENT_TBL + " ( ";
            q += " " + CASH_PAYMENT.ORDER_ID + " \r\n ";
            q += "," + CASH_PAYMENT.PAYMENT_DATE + " \r\n ";
            q += "," + CASH_PAYMENT.LEDGER_ID + " \r\n ";
            q += "," + CASH_PAYMENT.PURPOSE + " \r\n ";
            q += "," + CASH_PAYMENT.PARTY_ID + " \r\n ";
            q += "," + CASH_PAYMENT.PAYMENT_AMOUNT + " \r\n ";
            q += "," + CASH_PAYMENT.NOTES + " \r\n ";
            q += "," + CASH_PAYMENT.ACTIVE_ID + " \r\n ";
            q += "," + CASH_PAYMENT.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + CASH_PAYMENT.ORDER_ID + "@ \r\n ";
                q += ", @" + CASH_PAYMENT.PAYMENT_DATE + "@ \r\n ";
                q += ", @" + CASH_PAYMENT.LEDGER_ID + "@ \r\n ";
                q += ", @" + CASH_PAYMENT.PURPOSE + "@ \r\n ";
                q += ", @" + CASH_PAYMENT.PARTY_ID + "@ \r\n ";
                q += ", @" + CASH_PAYMENT.PAYMENT_AMOUNT + "@ \r\n ";
            q += ", @" + CASH_PAYMENT.NOTES + "@ \r\n ";
            q += ", @" + CASH_PAYMENT.ACTIVE_ID + "@ \r\n ";
            q += ", @" + CASH_PAYMENT.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Cash_payment v, DAL dalsession)
        {
            string q = "UPDATE " + CASH_PAYMENT.CASH_PAYMENT_TBL + " SET";
            q += " " + CASH_PAYMENT.ORDER_ID + " = @" + CASH_PAYMENT.ORDER_ID + "@ \r\n ";
            q += "," + CASH_PAYMENT.PAYMENT_DATE + " = @" + CASH_PAYMENT.PAYMENT_DATE + "@ \r\n ";
            q += "," + CASH_PAYMENT.LEDGER_ID + " = @" + CASH_PAYMENT.LEDGER_ID + "@ \r\n ";
            q += "," + CASH_PAYMENT.PURPOSE + " = @" + CASH_PAYMENT.PURPOSE + "@ \r\n ";
            q += "," + CASH_PAYMENT.PARTY_ID + " = @" + CASH_PAYMENT.PARTY_ID + "@ \r\n ";
            q += "," + CASH_PAYMENT.PAYMENT_AMOUNT + " = @" + CASH_PAYMENT.PAYMENT_AMOUNT + "@ \r\n ";
            q += "," + CASH_PAYMENT.NOTES + " = @" + CASH_PAYMENT.NOTES + "@ \r\n ";
            q += "," + CASH_PAYMENT.ACTIVE_ID + " = @" + CASH_PAYMENT.ACTIVE_ID + "@ \r\n ";
            q += "," + CASH_PAYMENT.USER_ID + " = @" + CASH_PAYMENT.USER_ID + "@ \r\n ";
            q += "  WHERE " + CASH_PAYMENT.CASH_PAYMENT_ID + " = @" + CASH_PAYMENT.CASH_PAYMENT_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + CASH_PAYMENT.CASH_PAYMENT_TBL + " WHERE " + CASH_PAYMENT.CASH_PAYMENT_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
