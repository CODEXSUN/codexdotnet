// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 11:17:05 PM

using CXLIB;

namespace CXKNITTING
{
    public class CReceipt
    {

        #region[Get New]

        public static Knitting_Receipt GetNew
        {
            get
            {
                Knitting_Receipt obj = new Knitting_Receipt()
                {
                    Knitting_Receipt_id = string.Empty,
                    Uniqueno = string.Empty,
                    Company_id = string.Empty,
                    Acy_id = string.Empty,
                    Knitting_Receipt_no = CReceipt_exten.GetNext_No,
                    Knitting_Receipt_date = string.Empty,
                    Party_id = string.Empty,
                    Receipttype_id = string.Empty,
                    Cheq_no = string.Empty,
                    Receipt_amount = string.Empty,
                    Cheq_date = string.Empty,
                    Bank_id = string.Empty,
                    Total_amount = string.Empty,
                    Refered_no = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Knitting_Receipt v)
        {
            q = q.Replace("@" + KNITTING_RECEIPT.KNITTING_RECEIPT_ID + "@", "" + ConvertTO.SqlString(v.Knitting_Receipt_id) + "");
            q = q.Replace("@" + KNITTING_RECEIPT.UNIQUENO + "@", "" + ConvertTO.SqlString(v.Uniqueno) + "");
            q = q.Replace("@" + KNITTING_RECEIPT.COMPANY_ID + "@", "" + ConvertTO.SqlString(v.Company_id) + "");
            q = q.Replace("@" + KNITTING_RECEIPT.ACY_ID + "@", "" + ConvertTO.SqlString(v.Acy_id) + "");
            q = q.Replace("@" + KNITTING_RECEIPT.KNITTING_RECEIPT_NO + "@", "" + ConvertTO.SqlString(v.Knitting_Receipt_no) + "");
            q = q.Replace("@" + KNITTING_RECEIPT.KNITTING_RECEIPT_DATE + "@", "" + ConvertTO.SqlDate(v.Knitting_Receipt_date) + "");
            q = q.Replace("@" + KNITTING_RECEIPT.PARTY_ID + "@", "" + ConvertTO.SqlString(v.Party_id) + "");
            q = q.Replace("@" + KNITTING_RECEIPT.RECEIPTTYPE_ID + "@", "" + ConvertTO.SqlString(v.Receipttype_id) + "");
            q = q.Replace("@" + KNITTING_RECEIPT.CHEQ_NO + "@", "" + ConvertTO.SqlString(v.Cheq_no) + "");
            q = q.Replace("@" + KNITTING_RECEIPT.KNITTING_RECEIPT_AMOUNT + "@", "" + ConvertTO.SqlString(v.Receipt_amount) + "");
            q = q.Replace("@" + KNITTING_RECEIPT.CHEQ_DATE + "@", "" + ConvertTO.SqlString(v.Cheq_date) + "");
            q = q.Replace("@" + KNITTING_RECEIPT.BANK_ID + "@", "" + ConvertTO.SqlString(v.Bank_id) + "");
            q = q.Replace("@" + KNITTING_RECEIPT.TOTAL_AMOUNT + "@", "" + ConvertTO.SqlString(v.Total_amount) + "");
            q = q.Replace("@" + KNITTING_RECEIPT.REFERED_NO + "@", "" + ConvertTO.SqlString(v.Refered_no) + "");
            q = q.Replace("@" + KNITTING_RECEIPT.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + KNITTING_RECEIPT.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + KNITTING_RECEIPT.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Knitting_Receipt v, DAL dalsession)
        {
            string q = " INSERT INTO " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + " ( ";
            q += " " + KNITTING_RECEIPT.UNIQUENO + " \r\n ";
            q += "," + KNITTING_RECEIPT.COMPANY_ID + " \r\n ";
            q += "," + KNITTING_RECEIPT.ACY_ID + " \r\n ";
            q += "," + KNITTING_RECEIPT.KNITTING_RECEIPT_NO + " \r\n ";
            q += "," + KNITTING_RECEIPT.KNITTING_RECEIPT_DATE + " \r\n ";
            q += "," + KNITTING_RECEIPT.PARTY_ID + " \r\n ";
            q += "," + KNITTING_RECEIPT.RECEIPTTYPE_ID + " \r\n ";
            q += "," + KNITTING_RECEIPT.CHEQ_NO + " \r\n ";
            q += "," + KNITTING_RECEIPT.KNITTING_RECEIPT_AMOUNT + " \r\n ";
            q += "," + KNITTING_RECEIPT.CHEQ_DATE + " \r\n ";
            q += "," + KNITTING_RECEIPT.BANK_ID + " \r\n ";
            q += "," + KNITTING_RECEIPT.TOTAL_AMOUNT + " \r\n ";
            q += "," + KNITTING_RECEIPT.REFERED_NO + " \r\n ";
            q += "," + KNITTING_RECEIPT.NOTES + " \r\n ";
            q += "," + KNITTING_RECEIPT.ACTIVE_ID + " \r\n ";
            q += "," + KNITTING_RECEIPT.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + KNITTING_RECEIPT.UNIQUENO + "@ \r\n ";
            q += ", @" + KNITTING_RECEIPT.COMPANY_ID + "@ \r\n ";
            q += ", @" + KNITTING_RECEIPT.ACY_ID + "@ \r\n ";
            q += ", @" + KNITTING_RECEIPT.KNITTING_RECEIPT_NO + "@ \r\n ";
            q += ", @" + KNITTING_RECEIPT.KNITTING_RECEIPT_DATE + "@ \r\n ";
            q += ", @" + KNITTING_RECEIPT.PARTY_ID + "@ \r\n ";
            q += ", @" + KNITTING_RECEIPT.RECEIPTTYPE_ID + "@ \r\n ";
            q += ", @" + KNITTING_RECEIPT.CHEQ_NO + "@ \r\n ";
            q += ", @" + KNITTING_RECEIPT.KNITTING_RECEIPT_AMOUNT + "@ \r\n ";
            q += ", @" + KNITTING_RECEIPT.CHEQ_DATE + "@ \r\n ";
            q += ", @" + KNITTING_RECEIPT.BANK_ID + "@ \r\n ";
            q += ", @" + KNITTING_RECEIPT.TOTAL_AMOUNT + "@ \r\n ";
            q += ", @" + KNITTING_RECEIPT.REFERED_NO + "@ \r\n ";
            q += ", @" + KNITTING_RECEIPT.NOTES + "@ \r\n ";
            q += ", @" + KNITTING_RECEIPT.ACTIVE_ID + "@ \r\n ";
            q += ", @" + KNITTING_RECEIPT.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Knitting_Receipt v, DAL dalsession)
        {
            string q = "UPDATE " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + " SET";
            q += " " + KNITTING_RECEIPT.UNIQUENO + " = @" + KNITTING_RECEIPT.UNIQUENO + "@ \r\n ";
            q += "," + KNITTING_RECEIPT.COMPANY_ID + " = @" + KNITTING_RECEIPT.COMPANY_ID + "@ \r\n ";
            q += "," + KNITTING_RECEIPT.ACY_ID + " = @" + KNITTING_RECEIPT.ACY_ID + "@ \r\n ";
            q += "," + KNITTING_RECEIPT.KNITTING_RECEIPT_NO + " = @" + KNITTING_RECEIPT.KNITTING_RECEIPT_NO + "@ \r\n ";
            q += "," + KNITTING_RECEIPT.KNITTING_RECEIPT_DATE + " = @" + KNITTING_RECEIPT.KNITTING_RECEIPT_DATE + "@ \r\n ";
            q += "," + KNITTING_RECEIPT.PARTY_ID + " = @" + KNITTING_RECEIPT.PARTY_ID + "@ \r\n ";
            q += "," + KNITTING_RECEIPT.RECEIPTTYPE_ID + " = @" + KNITTING_RECEIPT.RECEIPTTYPE_ID + "@ \r\n ";
            q += "," + KNITTING_RECEIPT.CHEQ_NO + " = @" + KNITTING_RECEIPT.CHEQ_NO + "@ \r\n ";
            q += "," + KNITTING_RECEIPT.KNITTING_RECEIPT_AMOUNT + " = @" + KNITTING_RECEIPT.KNITTING_RECEIPT_AMOUNT + "@ \r\n ";
            q += "," + KNITTING_RECEIPT.CHEQ_DATE + " = @" + KNITTING_RECEIPT.CHEQ_DATE + "@ \r\n ";
            q += "," + KNITTING_RECEIPT.BANK_ID + " = @" + KNITTING_RECEIPT.BANK_ID + "@ \r\n ";
            q += "," + KNITTING_RECEIPT.TOTAL_AMOUNT + " = @" + KNITTING_RECEIPT.TOTAL_AMOUNT + "@ \r\n ";
            q += "," + KNITTING_RECEIPT.REFERED_NO + " = @" + KNITTING_RECEIPT.REFERED_NO + "@ \r\n ";
            q += "," + KNITTING_RECEIPT.NOTES + " = @" + KNITTING_RECEIPT.NOTES + "@ \r\n ";
            q += "," + KNITTING_RECEIPT.ACTIVE_ID + " = @" + KNITTING_RECEIPT.ACTIVE_ID + "@ \r\n ";
            q += "," + KNITTING_RECEIPT.USER_ID + " = @" + KNITTING_RECEIPT.USER_ID + "@ \r\n ";
            q += "  WHERE " + KNITTING_RECEIPT.KNITTING_RECEIPT_ID + " = @" + KNITTING_RECEIPT.KNITTING_RECEIPT_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + " WHERE " + KNITTING_RECEIPT.KNITTING_RECEIPT_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
