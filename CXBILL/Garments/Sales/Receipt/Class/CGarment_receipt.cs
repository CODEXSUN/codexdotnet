// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 13-03-2018 10:59:14 AM

using CXLIB;

namespace CXBILL
{
    public class CGarment_receipt
    {

        #region[Get New]

        public static Garment_receipt GetNew
        {
            get
            {
                Garment_receipt obj = new Garment_receipt()
                {
                    Garment_receipt_id = string.Empty,
                    Uniqueno = string.Empty,
                    Company_id = Current.Company_id,
                    Acy_id = Current.Acy_id,
                    Garment_receipt_no = CGarment_receipt_exten.GetNext_No,
                    Garment_receipt_date = string.Empty,
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

        private static string AttachParams(string q, Garment_receipt v)
        {
            q = q.Replace("@" + GARMENT_RECEIPT.GARMENT_RECEIPT_ID + "@", "" + ConvertTO.SqlString(v.Garment_receipt_id) + "");
            q = q.Replace("@" + GARMENT_RECEIPT.UNIQUENO + "@", "" + ConvertTO.SqlString(v.Uniqueno) + "");
            q = q.Replace("@" + GARMENT_RECEIPT.COMPANY_ID + "@", "" + ConvertTO.SqlString(v.Company_id) + "");
            q = q.Replace("@" + GARMENT_RECEIPT.ACY_ID + "@", "" + ConvertTO.SqlString(v.Acy_id) + "");
            q = q.Replace("@" + GARMENT_RECEIPT.GARMENT_RECEIPT_NO + "@", "" + ConvertTO.SqlString(v.Garment_receipt_no) + "");
            q = q.Replace("@" + GARMENT_RECEIPT.GARMENT_RECEIPT_DATE + "@", "" + ConvertTO.SqlDate(v.Garment_receipt_date) + "");
            q = q.Replace("@" + GARMENT_RECEIPT.PARTY_ID + "@", "" + ConvertTO.SqlString(v.Party_id) + "");
            q = q.Replace("@" + GARMENT_RECEIPT.RECEIPTTYPE_ID + "@", "" + ConvertTO.SqlString(v.Receipttype_id) + "");
            q = q.Replace("@" + GARMENT_RECEIPT.CHEQ_NO + "@", "" + ConvertTO.SqlString(v.Cheq_no) + "");
            q = q.Replace("@" + GARMENT_RECEIPT.GARMENT_RECEIPT_AMOUNT + "@", "" + ConvertTO.SqlString(v.Receipt_amount) + "");
            q = q.Replace("@" + GARMENT_RECEIPT.CHEQ_DATE + "@", "" + ConvertTO.SqlString(v.Cheq_date) + "");
            q = q.Replace("@" + GARMENT_RECEIPT.BANK_ID + "@", "" + ConvertTO.SqlString(v.Bank_id) + "");
            q = q.Replace("@" + GARMENT_RECEIPT.TOTAL_AMOUNT + "@", "" + ConvertTO.SqlString(v.Total_amount) + "");
            q = q.Replace("@" + GARMENT_RECEIPT.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + GARMENT_RECEIPT.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + GARMENT_RECEIPT.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Garment_receipt v, DAL dalsession)
        {
            string q = " INSERT INTO " + GARMENT_RECEIPT.GARMENT_RECEIPT_TBL + " ( ";
            q += " " + GARMENT_RECEIPT.UNIQUENO + " \r\n ";
            q += "," + GARMENT_RECEIPT.COMPANY_ID + " \r\n ";
            q += "," + GARMENT_RECEIPT.ACY_ID + " \r\n ";
            q += "," + GARMENT_RECEIPT.GARMENT_RECEIPT_NO + " \r\n ";
            q += "," + GARMENT_RECEIPT.GARMENT_RECEIPT_DATE + " \r\n ";
            q += "," + GARMENT_RECEIPT.PARTY_ID + " \r\n ";
            q += "," + GARMENT_RECEIPT.RECEIPTTYPE_ID + " \r\n ";
            q += "," + GARMENT_RECEIPT.CHEQ_NO + " \r\n ";
            q += "," + GARMENT_RECEIPT.GARMENT_RECEIPT_AMOUNT + " \r\n ";
            q += "," + GARMENT_RECEIPT.CHEQ_DATE + " \r\n ";
            q += "," + GARMENT_RECEIPT.BANK_ID + " \r\n ";
            q += "," + GARMENT_RECEIPT.TOTAL_AMOUNT + " \r\n ";
            q += "," + GARMENT_RECEIPT.NOTES + " \r\n ";
            q += "," + GARMENT_RECEIPT.ACTIVE_ID + " \r\n ";
            q += "," + GARMENT_RECEIPT.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + GARMENT_RECEIPT.UNIQUENO + "@ \r\n ";
            q += ", @" + GARMENT_RECEIPT.COMPANY_ID + "@ \r\n ";
            q += ", @" + GARMENT_RECEIPT.ACY_ID + "@ \r\n ";
            q += ", @" + GARMENT_RECEIPT.GARMENT_RECEIPT_NO + "@ \r\n ";
            q += ", @" + GARMENT_RECEIPT.GARMENT_RECEIPT_DATE + "@ \r\n ";
            q += ", @" + GARMENT_RECEIPT.PARTY_ID + "@ \r\n ";
            q += ", @" + GARMENT_RECEIPT.RECEIPTTYPE_ID + "@ \r\n ";
            q += ", @" + GARMENT_RECEIPT.CHEQ_NO + "@ \r\n ";
            q += ", @" + GARMENT_RECEIPT.GARMENT_RECEIPT_AMOUNT + "@ \r\n ";
            q += ", @" + GARMENT_RECEIPT.CHEQ_DATE + "@ \r\n ";
            q += ", @" + GARMENT_RECEIPT.BANK_ID + "@ \r\n ";
            q += ", @" + GARMENT_RECEIPT.TOTAL_AMOUNT + "@ \r\n ";
            q += ", @" + GARMENT_RECEIPT.NOTES + "@ \r\n ";
            q += ", @" + GARMENT_RECEIPT.ACTIVE_ID + "@ \r\n ";
            q += ", @" + GARMENT_RECEIPT.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Garment_receipt v, DAL dalsession)
        {
            string q = "UPDATE " + GARMENT_RECEIPT.GARMENT_RECEIPT_TBL + " SET";
            q += " " + GARMENT_RECEIPT.UNIQUENO + " = @" + GARMENT_RECEIPT.UNIQUENO + "@ \r\n ";
            q += "," + GARMENT_RECEIPT.COMPANY_ID + " = @" + GARMENT_RECEIPT.COMPANY_ID + "@ \r\n ";
            q += "," + GARMENT_RECEIPT.ACY_ID + " = @" + GARMENT_RECEIPT.ACY_ID + "@ \r\n ";
            q += "," + GARMENT_RECEIPT.GARMENT_RECEIPT_NO + " = @" + GARMENT_RECEIPT.GARMENT_RECEIPT_NO + "@ \r\n ";
            q += "," + GARMENT_RECEIPT.GARMENT_RECEIPT_DATE + " = @" + GARMENT_RECEIPT.GARMENT_RECEIPT_DATE + "@ \r\n ";
            q += "," + GARMENT_RECEIPT.PARTY_ID + " = @" + GARMENT_RECEIPT.PARTY_ID + "@ \r\n ";
            q += "," + GARMENT_RECEIPT.RECEIPTTYPE_ID + " = @" + GARMENT_RECEIPT.RECEIPTTYPE_ID + "@ \r\n ";
            q += "," + GARMENT_RECEIPT.CHEQ_NO + " = @" + GARMENT_RECEIPT.CHEQ_NO + "@ \r\n ";
            q += "," + GARMENT_RECEIPT.GARMENT_RECEIPT_AMOUNT + " = @" + GARMENT_RECEIPT.GARMENT_RECEIPT_AMOUNT + "@ \r\n ";
            q += "," + GARMENT_RECEIPT.CHEQ_DATE + " = @" + GARMENT_RECEIPT.CHEQ_DATE + "@ \r\n ";
            q += "," + GARMENT_RECEIPT.BANK_ID + " = @" + GARMENT_RECEIPT.BANK_ID + "@ \r\n ";
            q += "," + GARMENT_RECEIPT.TOTAL_AMOUNT + " = @" + GARMENT_RECEIPT.TOTAL_AMOUNT + "@ \r\n ";
            q += "," + GARMENT_RECEIPT.NOTES + " = @" + GARMENT_RECEIPT.NOTES + "@ \r\n ";
            q += "," + GARMENT_RECEIPT.ACTIVE_ID + " = @" + GARMENT_RECEIPT.ACTIVE_ID + "@ \r\n ";
            q += "," + GARMENT_RECEIPT.USER_ID + " = @" + GARMENT_RECEIPT.USER_ID + "@ \r\n ";
            q += "  WHERE " + GARMENT_RECEIPT.GARMENT_RECEIPT_ID + " = @" + GARMENT_RECEIPT.GARMENT_RECEIPT_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + GARMENT_RECEIPT.GARMENT_RECEIPT_TBL + " WHERE " + GARMENT_RECEIPT.GARMENT_RECEIPT_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
