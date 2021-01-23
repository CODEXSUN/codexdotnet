// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 09-08-2020 09:29:37 PM

using CXLIB;

namespace CXACCOUNTS
{
    public static class CCash_in_hand
    {

        #region[Get New]

        public static Cash_in_hand GetNew
        {
            get
            {
                Cash_in_hand obj = new Cash_in_hand()
                {
                    Cash_in_hand_id = string.Empty,
                    Entry_date = string.Empty,
                    Cash_receipt_id = string.Empty,
                    Cash_payment_id = string.Empty,
                    Receipt_amount = decimal.Zero,
                    Payment_amount = decimal.Zero,
                    Balance_amount = decimal.Zero,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Cash_in_hand v)
        {
            q = q.Replace("@" + CASH_IN_HAND.CASH_IN_HAND_ID + "@", "" + ConvertTO.SqlString(v.Cash_in_hand_id) + "");
            q = q.Replace("@" + CASH_IN_HAND.ENTRY_DATE + "@", "" + ConvertTO.SqlDate(v.Entry_date) + "");
            q = q.Replace("@" + CASH_IN_HAND.CASH_RECEIPT_ID + "@", "" + ConvertTO.SqlString(v.Cash_receipt_id) + "");
            q = q.Replace("@" + CASH_IN_HAND.CASH_PAYMENT_ID + "@", "" + ConvertTO.SqlString(v.Cash_payment_id) + "");
            q = q.Replace("@" + CASH_IN_HAND.RECEIPT_AMOUNT + "@", "" + ConvertTO.SqlDecimal(v.Receipt_amount) + "");
            q = q.Replace("@" + CASH_IN_HAND.PAYMENT_AMOUNT + "@", "" + ConvertTO.SqlDecimal(v.Payment_amount) + "");
            q = q.Replace("@" + CASH_IN_HAND.BALANCE_AMOUNT + "@", "" + ConvertTO.SqlDecimal(v.Balance_amount) + "");
            q = q.Replace("@" + CASH_IN_HAND.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + CASH_IN_HAND.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + CASH_IN_HAND.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Cash_in_hand v, DAL dalsession)
        {
            string q = " INSERT INTO " + CASH_IN_HAND.CASH_IN_HAND_TBL + " ( ";
            q += " " + CASH_IN_HAND.ENTRY_DATE + " \r\n ";
            q += "," + CASH_IN_HAND.CASH_RECEIPT_ID + " \r\n ";
            q += "," + CASH_IN_HAND.CASH_PAYMENT_ID + " \r\n ";
            q += "," + CASH_IN_HAND.RECEIPT_AMOUNT + " \r\n ";
            q += "," + CASH_IN_HAND.PAYMENT_AMOUNT + " \r\n ";
            q += "," + CASH_IN_HAND.BALANCE_AMOUNT + " \r\n ";
            q += "," + CASH_IN_HAND.NOTES + " \r\n ";
            q += "," + CASH_IN_HAND.ACTIVE_ID + " \r\n ";
            q += "," + CASH_IN_HAND.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + CASH_IN_HAND.ENTRY_DATE + "@ \r\n ";
                q += ", @" + CASH_IN_HAND.CASH_RECEIPT_ID + "@ \r\n ";
                q += ", @" + CASH_IN_HAND.CASH_PAYMENT_ID + "@ \r\n ";
                q += ", @" + CASH_IN_HAND.RECEIPT_AMOUNT + "@ \r\n ";
                q += ", @" + CASH_IN_HAND.PAYMENT_AMOUNT + "@ \r\n ";
                q += ", @" + CASH_IN_HAND.BALANCE_AMOUNT + "@ \r\n ";
            q += ", @" + CASH_IN_HAND.NOTES + "@ \r\n ";
            q += ", @" + CASH_IN_HAND.ACTIVE_ID + "@ \r\n ";
            q += ", @" + CASH_IN_HAND.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Cash_in_hand v, DAL dalsession)
        {
            string q = "UPDATE " + CASH_IN_HAND.CASH_IN_HAND_TBL + " SET";
            q += " " + CASH_IN_HAND.ENTRY_DATE + " = @" + CASH_IN_HAND.ENTRY_DATE + "@ \r\n ";
            q += "," + CASH_IN_HAND.CASH_RECEIPT_ID + " = @" + CASH_IN_HAND.CASH_RECEIPT_ID + "@ \r\n ";
            q += "," + CASH_IN_HAND.CASH_PAYMENT_ID + " = @" + CASH_IN_HAND.CASH_PAYMENT_ID + "@ \r\n ";
            q += "," + CASH_IN_HAND.RECEIPT_AMOUNT + " = @" + CASH_IN_HAND.RECEIPT_AMOUNT + "@ \r\n ";
            q += "," + CASH_IN_HAND.PAYMENT_AMOUNT + " = @" + CASH_IN_HAND.PAYMENT_AMOUNT + "@ \r\n ";
            q += "," + CASH_IN_HAND.BALANCE_AMOUNT + " = @" + CASH_IN_HAND.BALANCE_AMOUNT + "@ \r\n ";
            q += "," + CASH_IN_HAND.NOTES + " = @" + CASH_IN_HAND.NOTES + "@ \r\n ";
            q += "," + CASH_IN_HAND.ACTIVE_ID + " = @" + CASH_IN_HAND.ACTIVE_ID + "@ \r\n ";
            q += "," + CASH_IN_HAND.USER_ID + " = @" + CASH_IN_HAND.USER_ID + "@ \r\n ";
            q += "  WHERE " + CASH_IN_HAND.CASH_IN_HAND_ID + " = @" + CASH_IN_HAND.CASH_IN_HAND_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + CASH_IN_HAND.CASH_IN_HAND_TBL + " WHERE " + CASH_IN_HAND.CASH_IN_HAND_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
