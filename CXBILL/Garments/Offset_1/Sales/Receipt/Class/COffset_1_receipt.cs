// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 13-03-2018 10:59:14 AM

using CXLIB;

namespace CXBILL
{
    public class COffset_1_receipt
    {

        #region[Get New]

        public static Offset_1_receipt GetNew
        {
            get
            {
                Offset_1_receipt obj = new Offset_1_receipt()
                {
                    Offset_1_receipt_id = string.Empty,
                    Uniqueno = string.Empty,
                    Company_id = Current.Company_id,
                    Acy_id = Current.Acy_id,
                    Offset_1_receipt_no = COffset_1_receipt_exten.GetNext_No,
                    Offset_1_receipt_date = string.Empty,
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

        private static string AttachParams(string q, Offset_1_receipt v)
        {
            q = q.Replace("@" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_ID + "@", "" + ConvertTO.SqlString(v.Offset_1_receipt_id) + "");
            q = q.Replace("@" + OFFSET_1_RECEIPT.UNIQUENO + "@", "" + ConvertTO.SqlString(v.Uniqueno) + "");
            q = q.Replace("@" + OFFSET_1_RECEIPT.COMPANY_ID + "@", "" + ConvertTO.SqlString(v.Company_id) + "");
            q = q.Replace("@" + OFFSET_1_RECEIPT.ACY_ID + "@", "" + ConvertTO.SqlString(v.Acy_id) + "");
            q = q.Replace("@" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_NO + "@", "" + ConvertTO.SqlString(v.Offset_1_receipt_no) + "");
            q = q.Replace("@" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_DATE + "@", "" + ConvertTO.SqlDate(v.Offset_1_receipt_date) + "");
            q = q.Replace("@" + OFFSET_1_RECEIPT.PARTY_ID + "@", "" + ConvertTO.SqlString(v.Party_id) + "");
            q = q.Replace("@" + OFFSET_1_RECEIPT.RECEIPTTYPE_ID + "@", "" + ConvertTO.SqlString(v.Receipttype_id) + "");
            q = q.Replace("@" + OFFSET_1_RECEIPT.CHEQ_NO + "@", "" + ConvertTO.SqlString(v.Cheq_no) + "");
            q = q.Replace("@" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_AMOUNT + "@", "" + ConvertTO.SqlString(v.Receipt_amount) + "");
            q = q.Replace("@" + OFFSET_1_RECEIPT.CHEQ_DATE + "@", "" + ConvertTO.SqlString(v.Cheq_date) + "");
            q = q.Replace("@" + OFFSET_1_RECEIPT.BANK_ID + "@", "" + ConvertTO.SqlString(v.Bank_id) + "");
            q = q.Replace("@" + OFFSET_1_RECEIPT.TOTAL_AMOUNT + "@", "" + ConvertTO.SqlString(v.Total_amount) + "");
            q = q.Replace("@" + OFFSET_1_RECEIPT.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + OFFSET_1_RECEIPT.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + OFFSET_1_RECEIPT.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Offset_1_receipt v, DAL dalsession)
        {
            string q = " INSERT INTO " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + " ( ";
            q += " " + OFFSET_1_RECEIPT.UNIQUENO + " \r\n ";
            q += "," + OFFSET_1_RECEIPT.COMPANY_ID + " \r\n ";
            q += "," + OFFSET_1_RECEIPT.ACY_ID + " \r\n ";
            q += "," + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_NO + " \r\n ";
            q += "," + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_DATE + " \r\n ";
            q += "," + OFFSET_1_RECEIPT.PARTY_ID + " \r\n ";
            q += "," + OFFSET_1_RECEIPT.RECEIPTTYPE_ID + " \r\n ";
            q += "," + OFFSET_1_RECEIPT.CHEQ_NO + " \r\n ";
            q += "," + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_AMOUNT + " \r\n ";
            q += "," + OFFSET_1_RECEIPT.CHEQ_DATE + " \r\n ";
            q += "," + OFFSET_1_RECEIPT.BANK_ID + " \r\n ";
            q += "," + OFFSET_1_RECEIPT.TOTAL_AMOUNT + " \r\n ";
            q += "," + OFFSET_1_RECEIPT.NOTES + " \r\n ";
            q += "," + OFFSET_1_RECEIPT.ACTIVE_ID + " \r\n ";
            q += "," + OFFSET_1_RECEIPT.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + OFFSET_1_RECEIPT.UNIQUENO + "@ \r\n ";
            q += ", @" + OFFSET_1_RECEIPT.COMPANY_ID + "@ \r\n ";
            q += ", @" + OFFSET_1_RECEIPT.ACY_ID + "@ \r\n ";
            q += ", @" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_NO + "@ \r\n ";
            q += ", @" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_DATE + "@ \r\n ";
            q += ", @" + OFFSET_1_RECEIPT.PARTY_ID + "@ \r\n ";
            q += ", @" + OFFSET_1_RECEIPT.RECEIPTTYPE_ID + "@ \r\n ";
            q += ", @" + OFFSET_1_RECEIPT.CHEQ_NO + "@ \r\n ";
            q += ", @" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_AMOUNT + "@ \r\n ";
            q += ", @" + OFFSET_1_RECEIPT.CHEQ_DATE + "@ \r\n ";
            q += ", @" + OFFSET_1_RECEIPT.BANK_ID + "@ \r\n ";
            q += ", @" + OFFSET_1_RECEIPT.TOTAL_AMOUNT + "@ \r\n ";
            q += ", @" + OFFSET_1_RECEIPT.NOTES + "@ \r\n ";
            q += ", @" + OFFSET_1_RECEIPT.ACTIVE_ID + "@ \r\n ";
            q += ", @" + OFFSET_1_RECEIPT.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Offset_1_receipt v, DAL dalsession)
        {
            string q = "UPDATE " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + " SET";
            q += " " + OFFSET_1_RECEIPT.UNIQUENO + " = @" + OFFSET_1_RECEIPT.UNIQUENO + "@ \r\n ";
            q += "," + OFFSET_1_RECEIPT.COMPANY_ID + " = @" + OFFSET_1_RECEIPT.COMPANY_ID + "@ \r\n ";
            q += "," + OFFSET_1_RECEIPT.ACY_ID + " = @" + OFFSET_1_RECEIPT.ACY_ID + "@ \r\n ";
            q += "," + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_NO + " = @" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_NO + "@ \r\n ";
            q += "," + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_DATE + " = @" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_DATE + "@ \r\n ";
            q += "," + OFFSET_1_RECEIPT.PARTY_ID + " = @" + OFFSET_1_RECEIPT.PARTY_ID + "@ \r\n ";
            q += "," + OFFSET_1_RECEIPT.RECEIPTTYPE_ID + " = @" + OFFSET_1_RECEIPT.RECEIPTTYPE_ID + "@ \r\n ";
            q += "," + OFFSET_1_RECEIPT.CHEQ_NO + " = @" + OFFSET_1_RECEIPT.CHEQ_NO + "@ \r\n ";
            q += "," + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_AMOUNT + " = @" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_AMOUNT + "@ \r\n ";
            q += "," + OFFSET_1_RECEIPT.CHEQ_DATE + " = @" + OFFSET_1_RECEIPT.CHEQ_DATE + "@ \r\n ";
            q += "," + OFFSET_1_RECEIPT.BANK_ID + " = @" + OFFSET_1_RECEIPT.BANK_ID + "@ \r\n ";
            q += "," + OFFSET_1_RECEIPT.TOTAL_AMOUNT + " = @" + OFFSET_1_RECEIPT.TOTAL_AMOUNT + "@ \r\n ";
            q += "," + OFFSET_1_RECEIPT.NOTES + " = @" + OFFSET_1_RECEIPT.NOTES + "@ \r\n ";
            q += "," + OFFSET_1_RECEIPT.ACTIVE_ID + " = @" + OFFSET_1_RECEIPT.ACTIVE_ID + "@ \r\n ";
            q += "," + OFFSET_1_RECEIPT.USER_ID + " = @" + OFFSET_1_RECEIPT.USER_ID + "@ \r\n ";
            q += "  WHERE " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_ID + " = @" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + " WHERE " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
