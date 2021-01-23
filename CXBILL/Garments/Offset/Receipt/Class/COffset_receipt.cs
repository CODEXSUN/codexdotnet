// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 13-03-2018 10:59:14 AM

using CXLIB;

namespace CXBILL
{
    public class COffset_receipt
    {

        #region[Get New]

        public static Offset_receipt GetNew
        {
            get
            {
                Offset_receipt obj = new Offset_receipt()
                {
                    Offset_receipt_id = string.Empty,
                    Uniqueno = string.Empty,
                    Company_id = Current.Company_id,
                    Acy_id = Current.Acy_id,
                    Offset_receipt_no = COffset_receipt_exten.GetNext_No,
                    Offset_receipt_date = string.Empty,
                    Party_id = string.Empty,
                    Receipttype_id = string.Empty,
                    Cheq_no = string.Empty,
                    Receipt_amount = string.Empty,
                    Cheq_date = string.Empty,
                    Bank_id = string.Empty,
                    Total_amount = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Offset_receipt v)
        {
            q = q.Replace("@" + OFFSET_RECEIPT.OFFSET_RECEIPT_ID + "@", "" + ConvertTO.SqlString(v.Offset_receipt_id) + "");
            q = q.Replace("@" + OFFSET_RECEIPT.UNIQUENO + "@", "" + ConvertTO.SqlString(v.Uniqueno) + "");
            q = q.Replace("@" + OFFSET_RECEIPT.COMPANY_ID + "@", "" + ConvertTO.SqlString(v.Company_id) + "");
            q = q.Replace("@" + OFFSET_RECEIPT.ACY_ID + "@", "" + ConvertTO.SqlString(v.Acy_id) + "");
            q = q.Replace("@" + OFFSET_RECEIPT.OFFSET_RECEIPT_NO + "@", "" + ConvertTO.SqlString(v.Offset_receipt_no) + "");
            q = q.Replace("@" + OFFSET_RECEIPT.OFFSET_RECEIPT_DATE + "@", "" + ConvertTO.SqlDate(v.Offset_receipt_date) + "");
            q = q.Replace("@" + OFFSET_RECEIPT.PARTY_ID + "@", "" + ConvertTO.SqlString(v.Party_id) + "");
            q = q.Replace("@" + OFFSET_RECEIPT.RECEIPTTYPE_ID + "@", "" + ConvertTO.SqlString(v.Receipttype_id) + "");
            q = q.Replace("@" + OFFSET_RECEIPT.CHEQ_NO + "@", "" + ConvertTO.SqlString(v.Cheq_no) + "");
            q = q.Replace("@" + OFFSET_RECEIPT.OFFSET_RECEIPT_AMOUNT + "@", "" + ConvertTO.SqlString(v.Receipt_amount) + "");
            q = q.Replace("@" + OFFSET_RECEIPT.CHEQ_DATE + "@", "" + ConvertTO.SqlString(v.Cheq_date) + "");
            q = q.Replace("@" + OFFSET_RECEIPT.BANK_ID + "@", "" + ConvertTO.SqlString(v.Bank_id) + "");
            q = q.Replace("@" + OFFSET_RECEIPT.TOTAL_AMOUNT + "@", "" + ConvertTO.SqlString(v.Total_amount) + "");
            q = q.Replace("@" + OFFSET_RECEIPT.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + OFFSET_RECEIPT.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + OFFSET_RECEIPT.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Offset_receipt v, DAL dalsession)
        {
            string q = " INSERT INTO " + OFFSET_RECEIPT.OFFSET_RECEIPT_TBL + " ( ";
            q += " " + OFFSET_RECEIPT.UNIQUENO + " \r\n ";
            q += "," + OFFSET_RECEIPT.COMPANY_ID + " \r\n ";
            q += "," + OFFSET_RECEIPT.ACY_ID + " \r\n ";
            q += "," + OFFSET_RECEIPT.OFFSET_RECEIPT_NO + " \r\n ";
            q += "," + OFFSET_RECEIPT.OFFSET_RECEIPT_DATE + " \r\n ";
            q += "," + OFFSET_RECEIPT.PARTY_ID + " \r\n ";
            q += "," + OFFSET_RECEIPT.RECEIPTTYPE_ID + " \r\n ";
            q += "," + OFFSET_RECEIPT.CHEQ_NO + " \r\n ";
            q += "," + OFFSET_RECEIPT.OFFSET_RECEIPT_AMOUNT + " \r\n ";
            q += "," + OFFSET_RECEIPT.CHEQ_DATE + " \r\n ";
            q += "," + OFFSET_RECEIPT.BANK_ID + " \r\n ";
            q += "," + OFFSET_RECEIPT.TOTAL_AMOUNT + " \r\n ";
            q += "," + OFFSET_RECEIPT.NOTES + " \r\n ";
            q += "," + OFFSET_RECEIPT.ACTIVE_ID + " \r\n ";
            q += "," + OFFSET_RECEIPT.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + OFFSET_RECEIPT.UNIQUENO + "@ \r\n ";
            q += ", @" + OFFSET_RECEIPT.COMPANY_ID + "@ \r\n ";
            q += ", @" + OFFSET_RECEIPT.ACY_ID + "@ \r\n ";
            q += ", @" + OFFSET_RECEIPT.OFFSET_RECEIPT_NO + "@ \r\n ";
            q += ", @" + OFFSET_RECEIPT.OFFSET_RECEIPT_DATE + "@ \r\n ";
            q += ", @" + OFFSET_RECEIPT.PARTY_ID + "@ \r\n ";
            q += ", @" + OFFSET_RECEIPT.RECEIPTTYPE_ID + "@ \r\n ";
            q += ", @" + OFFSET_RECEIPT.CHEQ_NO + "@ \r\n ";
            q += ", @" + OFFSET_RECEIPT.OFFSET_RECEIPT_AMOUNT + "@ \r\n ";
            q += ", @" + OFFSET_RECEIPT.CHEQ_DATE + "@ \r\n ";
            q += ", @" + OFFSET_RECEIPT.BANK_ID + "@ \r\n ";
            q += ", @" + OFFSET_RECEIPT.TOTAL_AMOUNT + "@ \r\n ";
            q += ", @" + OFFSET_RECEIPT.NOTES + "@ \r\n ";
            q += ", @" + OFFSET_RECEIPT.ACTIVE_ID + "@ \r\n ";
            q += ", @" + OFFSET_RECEIPT.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Offset_receipt v, DAL dalsession)
        {
            string q = "UPDATE " + OFFSET_RECEIPT.OFFSET_RECEIPT_TBL + " SET";
            q += " " + OFFSET_RECEIPT.UNIQUENO + " = @" + OFFSET_RECEIPT.UNIQUENO + "@ \r\n ";
            q += "," + OFFSET_RECEIPT.COMPANY_ID + " = @" + OFFSET_RECEIPT.COMPANY_ID + "@ \r\n ";
            q += "," + OFFSET_RECEIPT.ACY_ID + " = @" + OFFSET_RECEIPT.ACY_ID + "@ \r\n ";
            q += "," + OFFSET_RECEIPT.OFFSET_RECEIPT_NO + " = @" + OFFSET_RECEIPT.OFFSET_RECEIPT_NO + "@ \r\n ";
            q += "," + OFFSET_RECEIPT.OFFSET_RECEIPT_DATE + " = @" + OFFSET_RECEIPT.OFFSET_RECEIPT_DATE + "@ \r\n ";
            q += "," + OFFSET_RECEIPT.PARTY_ID + " = @" + OFFSET_RECEIPT.PARTY_ID + "@ \r\n ";
            q += "," + OFFSET_RECEIPT.RECEIPTTYPE_ID + " = @" + OFFSET_RECEIPT.RECEIPTTYPE_ID + "@ \r\n ";
            q += "," + OFFSET_RECEIPT.CHEQ_NO + " = @" + OFFSET_RECEIPT.CHEQ_NO + "@ \r\n ";
            q += "," + OFFSET_RECEIPT.OFFSET_RECEIPT_AMOUNT + " = @" + OFFSET_RECEIPT.OFFSET_RECEIPT_AMOUNT + "@ \r\n ";
            q += "," + OFFSET_RECEIPT.CHEQ_DATE + " = @" + OFFSET_RECEIPT.CHEQ_DATE + "@ \r\n ";
            q += "," + OFFSET_RECEIPT.BANK_ID + " = @" + OFFSET_RECEIPT.BANK_ID + "@ \r\n ";
            q += "," + OFFSET_RECEIPT.TOTAL_AMOUNT + " = @" + OFFSET_RECEIPT.TOTAL_AMOUNT + "@ \r\n ";
            q += "," + OFFSET_RECEIPT.NOTES + " = @" + OFFSET_RECEIPT.NOTES + "@ \r\n ";
            q += "," + OFFSET_RECEIPT.ACTIVE_ID + " = @" + OFFSET_RECEIPT.ACTIVE_ID + "@ \r\n ";
            q += "," + OFFSET_RECEIPT.USER_ID + " = @" + OFFSET_RECEIPT.USER_ID + "@ \r\n ";
            q += "  WHERE " + OFFSET_RECEIPT.OFFSET_RECEIPT_ID + " = @" + OFFSET_RECEIPT.OFFSET_RECEIPT_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + OFFSET_RECEIPT.OFFSET_RECEIPT_TBL + " WHERE " + OFFSET_RECEIPT.OFFSET_RECEIPT_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
