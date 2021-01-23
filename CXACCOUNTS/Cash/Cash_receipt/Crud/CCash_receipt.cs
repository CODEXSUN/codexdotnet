// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 09-08-2020 09:29:47 PM

using CXLIB;

namespace CXACCOUNTS
{
    public static class CCash_receipt
    {

        #region[Get New]

        public static Cash_receipt GetNew
        {
            get
            {
                Cash_receipt obj = new Cash_receipt()
                {
                    Cash_receipt_id = string.Empty,
                    Receipt_date = string.Empty,
                    Party_id = string.Empty,
                    Purpose = string.Empty,
                    Receipt_amount = decimal.Zero,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Cash_receipt v)
        {
            q = q.Replace("@" + CASH_RECEIPT.CASH_RECEIPT_ID + "@", "" + ConvertTO.SqlString(v.Cash_receipt_id) + "");
            q = q.Replace("@" + CASH_RECEIPT.RECEIPT_DATE + "@", "" + ConvertTO.SqlDate(v.Receipt_date) + "");
            q = q.Replace("@" + CASH_RECEIPT.PARTY_ID + "@", "" + ConvertTO.SqlString(v.Party_id) + "");
            q = q.Replace("@" + CASH_RECEIPT.PURPOSE + "@", "" + ConvertTO.SqlString(v.Purpose) + "");
            q = q.Replace("@" + CASH_RECEIPT.RECEIPT_AMOUNT + "@", "" + ConvertTO.SqlDecimal(v.Receipt_amount) + "");
            q = q.Replace("@" + CASH_RECEIPT.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + CASH_RECEIPT.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + CASH_RECEIPT.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Cash_receipt v, DAL dalsession)
        {
            string q = " INSERT INTO " + CASH_RECEIPT.CASH_RECEIPT_TBL + " ( ";
            q += " " + CASH_RECEIPT.RECEIPT_DATE + " \r\n ";
            q += "," + CASH_RECEIPT.PARTY_ID + " \r\n ";
            q += "," + CASH_RECEIPT.PURPOSE + " \r\n ";
            q += "," + CASH_RECEIPT.RECEIPT_AMOUNT + " \r\n ";
            q += "," + CASH_RECEIPT.NOTES + " \r\n ";
            q += "," + CASH_RECEIPT.ACTIVE_ID + " \r\n ";
            q += "," + CASH_RECEIPT.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + CASH_RECEIPT.RECEIPT_DATE + "@ \r\n ";
                q += ", @" + CASH_RECEIPT.PARTY_ID + "@ \r\n ";
                q += ", @" + CASH_RECEIPT.PURPOSE + "@ \r\n ";
                q += ", @" + CASH_RECEIPT.RECEIPT_AMOUNT + "@ \r\n ";
            q += ", @" + CASH_RECEIPT.NOTES + "@ \r\n ";
            q += ", @" + CASH_RECEIPT.ACTIVE_ID + "@ \r\n ";
            q += ", @" + CASH_RECEIPT.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Cash_receipt v, DAL dalsession)
        {
            string q = "UPDATE " + CASH_RECEIPT.CASH_RECEIPT_TBL + " SET";
            q += " " + CASH_RECEIPT.RECEIPT_DATE + " = @" + CASH_RECEIPT.RECEIPT_DATE + "@ \r\n ";
            q += "," + CASH_RECEIPT.PARTY_ID + " = @" + CASH_RECEIPT.PARTY_ID + "@ \r\n ";
            q += "," + CASH_RECEIPT.PURPOSE + " = @" + CASH_RECEIPT.PURPOSE + "@ \r\n ";
            q += "," + CASH_RECEIPT.RECEIPT_AMOUNT + " = @" + CASH_RECEIPT.RECEIPT_AMOUNT + "@ \r\n ";
            q += "," + CASH_RECEIPT.NOTES + " = @" + CASH_RECEIPT.NOTES + "@ \r\n ";
            q += "," + CASH_RECEIPT.ACTIVE_ID + " = @" + CASH_RECEIPT.ACTIVE_ID + "@ \r\n ";
            q += "," + CASH_RECEIPT.USER_ID + " = @" + CASH_RECEIPT.USER_ID + "@ \r\n ";
            q += "  WHERE " + CASH_RECEIPT.CASH_RECEIPT_ID + " = @" + CASH_RECEIPT.CASH_RECEIPT_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + CASH_RECEIPT.CASH_RECEIPT_TBL + " WHERE " + CASH_RECEIPT.CASH_RECEIPT_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
