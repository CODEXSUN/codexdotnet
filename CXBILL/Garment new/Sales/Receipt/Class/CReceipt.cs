// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 14-07-2020 10:01:13 PM

using CXCORE;
using CXLIB;

namespace CXBILL
{
    public static class CReceipt
    {

        #region[Get New]

        public static Receipt GetNew
        {
            get
            {
                Receipt obj = new Receipt()
                {
                    Receipt_id = string.Empty,
                    Uniqueno = string.Empty,
                    Company_id = Current.Company_id,
                    Acy_id = Current.Acy_id,
                    Receipt_no = CReceipt_exten.GetNext_No,
                    Receipt_date = string.Empty,
                    Party_id = string.Empty,
                    Receipttype_id = string.Empty,
                    Cheq_no = string.Empty,
                    Receipt_amount = decimal.Zero,
                    Cheq_date = string.Empty,
                    Bank_id = string.Empty,
                    Total_amount = decimal.Zero,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Receipt v)
        {
            q = q.Replace("@" + RECEIPT.RECEIPT_ID + "@", "" + ConvertTO.SqlString(v.Receipt_id) + "");
            q = q.Replace("@" + RECEIPT.UNIQUENO + "@", "" + ConvertTO.SqlString(v.Uniqueno) + "");
            q = q.Replace("@" + RECEIPT.COMPANY_ID + "@", "" + ConvertTO.SqlString(v.Company_id) + "");
            q = q.Replace("@" + RECEIPT.ACY_ID + "@", "" + ConvertTO.SqlString(v.Acy_id) + "");
            q = q.Replace("@" + RECEIPT.RECEIPT_NO + "@", "" + ConvertTO.SqlString(v.Receipt_no) + "");
            q = q.Replace("@" + RECEIPT.RECEIPT_DATE + "@", "" + ConvertTO.SqlDate(v.Receipt_date) + "");
            q = q.Replace("@" + RECEIPT.PARTY_ID + "@", "" + ConvertTO.SqlString(v.Party_id) + "");
            q = q.Replace("@" + RECEIPT.RECEIPTTYPE_ID + "@", "" + ConvertTO.SqlString(v.Receipttype_id) + "");
            q = q.Replace("@" + RECEIPT.CHEQ_NO + "@", "" + ConvertTO.SqlString(v.Cheq_no) + "");
            q = q.Replace("@" + RECEIPT.RECEIPT_AMOUNT + "@", "" + ConvertTO.SqlDecimal(v.Receipt_amount) + "");
            q = q.Replace("@" + RECEIPT.CHEQ_DATE + "@", "" + ConvertTO.SqlString(v.Cheq_date) + "");
            q = q.Replace("@" + RECEIPT.BANK_ID + "@", "" + ConvertTO.SqlString(v.Bank_id) + "");
            q = q.Replace("@" + RECEIPT.TOTAL_AMOUNT + "@", "" + ConvertTO.SqlDecimal(v.Total_amount) + "");
            q = q.Replace("@" + RECEIPT.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + RECEIPT.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + RECEIPT.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Receipt v, DAL dalsession)
        {
            string q = " INSERT INTO " + RECEIPT.RECEIPT_TBL + " ( ";
            q += " " + RECEIPT.UNIQUENO + "\r\n";
            q += "," + RECEIPT.COMPANY_ID + "\r\n";
            q += "," + RECEIPT.ACY_ID + "\r\n";
            q += "," + RECEIPT.RECEIPT_NO + " \r\n";
            q += "," + RECEIPT.RECEIPT_DATE + " \r\n";
            q += "," + RECEIPT.PARTY_ID + " \r\n";
            q += "," + RECEIPT.RECEIPTTYPE_ID + " \r\n";
            q += "," + RECEIPT.CHEQ_NO + " \r\n";
            q += "," + RECEIPT.RECEIPT_AMOUNT + " \r\n";
            q += "," + RECEIPT.CHEQ_DATE + " \r\n";
            q += "," + RECEIPT.BANK_ID + " \r\n";
            q += "," + RECEIPT.TOTAL_AMOUNT + " \r\n";
            q += "," + RECEIPT.NOTES + " \r\n";
            q += "," + RECEIPT.ACTIVE_ID + " \r\n";
            q += "," + RECEIPT.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + RECEIPT.UNIQUENO + "@ \r\n";
            q += ", @" + RECEIPT.COMPANY_ID + "@ \r\n";
            q += ", @" + RECEIPT.ACY_ID + "@ \r\n";
            q += ", @" + RECEIPT.RECEIPT_NO + "@ \r\n";
            q += ", @" + RECEIPT.RECEIPT_DATE + "@ \r\n";
            q += ", @" + RECEIPT.PARTY_ID + "@ \r\n";
            q += ", @" + RECEIPT.RECEIPTTYPE_ID + "@ \r\n";
            q += ", @" + RECEIPT.CHEQ_NO + "@ \r\n";
            q += ", @" + RECEIPT.RECEIPT_AMOUNT + "@ \r\n";
            q += ", @" + RECEIPT.CHEQ_DATE + "@ \r\n";
            q += ", @" + RECEIPT.BANK_ID + "@ \r\n";
            q += ", @" + RECEIPT.TOTAL_AMOUNT + "@ \r\n";
            q += ", @" + RECEIPT.NOTES + "@ \r\n";
            q += ", @" + RECEIPT.ACTIVE_ID + "@ \r\n";
            q += ", @" + RECEIPT.USER_ID + "@ \r\n";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Receipt v, DAL dalsession)
        {
            string q = "UPDATE " + RECEIPT.RECEIPT_TBL + " SET";
            q += " " + RECEIPT.UNIQUENO + " = @" + RECEIPT.UNIQUENO + "@ \r\n";
            q += "," + RECEIPT.COMPANY_ID + " = @" + RECEIPT.COMPANY_ID + "@ \r\n";
            q += "," + RECEIPT.ACY_ID + " = @" + RECEIPT.ACY_ID + "@ \r\n";
            q += "," + RECEIPT.RECEIPT_NO + " = @" + RECEIPT.RECEIPT_NO + "@ \r\n ";
            q += "," + RECEIPT.RECEIPT_DATE + " = @" + RECEIPT.RECEIPT_DATE + "@ \r\n ";
            q += "," + RECEIPT.PARTY_ID + " = @" + RECEIPT.PARTY_ID + "@ \r\n ";
            q += "," + RECEIPT.RECEIPTTYPE_ID + " = @" + RECEIPT.RECEIPTTYPE_ID + "@ \r\n ";
            q += "," + RECEIPT.CHEQ_NO + " = @" + RECEIPT.CHEQ_NO + "@ \r\n ";
            q += "," + RECEIPT.RECEIPT_AMOUNT + " = @" + RECEIPT.RECEIPT_AMOUNT + "@ \r\n ";
            q += "," + RECEIPT.CHEQ_DATE + " = @" + RECEIPT.CHEQ_DATE + "@ \r\n ";
            q += "," + RECEIPT.BANK_ID + " = @" + RECEIPT.BANK_ID + "@ \r\n ";
            q += "," + RECEIPT.TOTAL_AMOUNT + " = @" + RECEIPT.TOTAL_AMOUNT + "@ \r\n ";
            q += "," + RECEIPT.NOTES + " = @" + RECEIPT.NOTES + "@ \r\n ";
            q += "," + RECEIPT.ACTIVE_ID + " = @" + RECEIPT.ACTIVE_ID + "@ \r\n ";
            q += "," + RECEIPT.USER_ID + " = @" + RECEIPT.USER_ID + "@ \r\n ";
            q += "  WHERE " + RECEIPT.RECEIPT_ID + " = @" + RECEIPT.RECEIPT_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + RECEIPT.RECEIPT_TBL + " WHERE " + RECEIPT.RECEIPT_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
