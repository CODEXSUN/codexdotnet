// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 13-03-2018 10:59:14 AM

using CXLIB;

namespace CXBILL
{
    public class CTex_receipt
    {

        #region[Get New]

        public static Tex_receipt GetNew
        {
            get
            {
                Tex_receipt obj = new Tex_receipt()
                {
                    Tex_receipt_id = string.Empty,
                    Uniqueno = string.Empty,
                    Company_id = Current.Company_id,
                    Acy_id = Current.Acy_id,
                    Tex_receipt_no = CTex_receipt_exten.GetNext_No,
                    Tex_receipt_date = string.Empty,
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

        private static string AttachParams(string q, Tex_receipt v)
        {
            q = q.Replace("@" + TEX_RECEIPT.TEX_RECEIPT_ID + "@", "" + ConvertTO.SqlString(v.Tex_receipt_id) + "");
            q = q.Replace("@" + TEX_RECEIPT.UNIQUENO + "@", "" + ConvertTO.SqlString(v.Uniqueno) + "");
            q = q.Replace("@" + TEX_RECEIPT.COMPANY_ID + "@", "" + ConvertTO.SqlString(v.Company_id) + "");
            q = q.Replace("@" + TEX_RECEIPT.ACY_ID + "@", "" + ConvertTO.SqlString(v.Acy_id) + "");
            q = q.Replace("@" + TEX_RECEIPT.TEX_RECEIPT_NO + "@", "" + ConvertTO.SqlString(v.Tex_receipt_no) + "");
            q = q.Replace("@" + TEX_RECEIPT.TEX_RECEIPT_DATE + "@", "" + ConvertTO.SqlDate(v.Tex_receipt_date) + "");
            q = q.Replace("@" + TEX_RECEIPT.PARTY_ID + "@", "" + ConvertTO.SqlString(v.Party_id) + "");
            q = q.Replace("@" + TEX_RECEIPT.RECEIPTTYPE_ID + "@", "" + ConvertTO.SqlString(v.Receipttype_id) + "");
            q = q.Replace("@" + TEX_RECEIPT.CHEQ_NO + "@", "" + ConvertTO.SqlString(v.Cheq_no) + "");
            q = q.Replace("@" + TEX_RECEIPT.TEX_RECEIPT_AMOUNT + "@", "" + ConvertTO.SqlString(v.Receipt_amount) + "");
            q = q.Replace("@" + TEX_RECEIPT.CHEQ_DATE + "@", "" + ConvertTO.SqlString(v.Cheq_date) + "");
            q = q.Replace("@" + TEX_RECEIPT.BANK_ID + "@", "" + ConvertTO.SqlString(v.Bank_id) + "");
            q = q.Replace("@" + TEX_RECEIPT.TOTAL_AMOUNT + "@", "" + ConvertTO.SqlString(v.Total_amount) + "");
            q = q.Replace("@" + TEX_RECEIPT.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + TEX_RECEIPT.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + TEX_RECEIPT.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Tex_receipt v, DAL dalsession)
        {
            string q = " INSERT INTO " + TEX_RECEIPT.TEX_RECEIPT_TBL + " ( ";
            q += " " + TEX_RECEIPT.UNIQUENO + " \r\n ";
            q += "," + TEX_RECEIPT.COMPANY_ID + " \r\n ";
            q += "," + TEX_RECEIPT.ACY_ID + " \r\n ";
            q += "," + TEX_RECEIPT.TEX_RECEIPT_NO + " \r\n ";
            q += "," + TEX_RECEIPT.TEX_RECEIPT_DATE + " \r\n ";
            q += "," + TEX_RECEIPT.PARTY_ID + " \r\n ";
            q += "," + TEX_RECEIPT.RECEIPTTYPE_ID + " \r\n ";
            q += "," + TEX_RECEIPT.CHEQ_NO + " \r\n ";
            q += "," + TEX_RECEIPT.TEX_RECEIPT_AMOUNT + " \r\n ";
            q += "," + TEX_RECEIPT.CHEQ_DATE + " \r\n ";
            q += "," + TEX_RECEIPT.BANK_ID + " \r\n ";
            q += "," + TEX_RECEIPT.TOTAL_AMOUNT + " \r\n ";
            q += "," + TEX_RECEIPT.NOTES + " \r\n ";
            q += "," + TEX_RECEIPT.ACTIVE_ID + " \r\n ";
            q += "," + TEX_RECEIPT.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + TEX_RECEIPT.UNIQUENO + "@ \r\n ";
            q += ", @" + TEX_RECEIPT.COMPANY_ID + "@ \r\n ";
            q += ", @" + TEX_RECEIPT.ACY_ID + "@ \r\n ";
            q += ", @" + TEX_RECEIPT.TEX_RECEIPT_NO + "@ \r\n ";
            q += ", @" + TEX_RECEIPT.TEX_RECEIPT_DATE + "@ \r\n ";
            q += ", @" + TEX_RECEIPT.PARTY_ID + "@ \r\n ";
            q += ", @" + TEX_RECEIPT.RECEIPTTYPE_ID + "@ \r\n ";
            q += ", @" + TEX_RECEIPT.CHEQ_NO + "@ \r\n ";
            q += ", @" + TEX_RECEIPT.TEX_RECEIPT_AMOUNT + "@ \r\n ";
            q += ", @" + TEX_RECEIPT.CHEQ_DATE + "@ \r\n ";
            q += ", @" + TEX_RECEIPT.BANK_ID + "@ \r\n ";
            q += ", @" + TEX_RECEIPT.TOTAL_AMOUNT + "@ \r\n ";
            q += ", @" + TEX_RECEIPT.NOTES + "@ \r\n ";
            q += ", @" + TEX_RECEIPT.ACTIVE_ID + "@ \r\n ";
            q += ", @" + TEX_RECEIPT.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Tex_receipt v, DAL dalsession)
        {
            string q = "UPDATE " + TEX_RECEIPT.TEX_RECEIPT_TBL + " SET";
            q += " " + TEX_RECEIPT.UNIQUENO + " = @" + TEX_RECEIPT.UNIQUENO + "@ \r\n ";
            q += "," + TEX_RECEIPT.COMPANY_ID + " = @" + TEX_RECEIPT.COMPANY_ID + "@ \r\n ";
            q += "," + TEX_RECEIPT.ACY_ID + " = @" + TEX_RECEIPT.ACY_ID + "@ \r\n ";
            q += "," + TEX_RECEIPT.TEX_RECEIPT_NO + " = @" + TEX_RECEIPT.TEX_RECEIPT_NO + "@ \r\n ";
            q += "," + TEX_RECEIPT.TEX_RECEIPT_DATE + " = @" + TEX_RECEIPT.TEX_RECEIPT_DATE + "@ \r\n ";
            q += "," + TEX_RECEIPT.PARTY_ID + " = @" + TEX_RECEIPT.PARTY_ID + "@ \r\n ";
            q += "," + TEX_RECEIPT.RECEIPTTYPE_ID + " = @" + TEX_RECEIPT.RECEIPTTYPE_ID + "@ \r\n ";
            q += "," + TEX_RECEIPT.CHEQ_NO + " = @" + TEX_RECEIPT.CHEQ_NO + "@ \r\n ";
            q += "," + TEX_RECEIPT.TEX_RECEIPT_AMOUNT + " = @" + TEX_RECEIPT.TEX_RECEIPT_AMOUNT + "@ \r\n ";
            q += "," + TEX_RECEIPT.CHEQ_DATE + " = @" + TEX_RECEIPT.CHEQ_DATE + "@ \r\n ";
            q += "," + TEX_RECEIPT.BANK_ID + " = @" + TEX_RECEIPT.BANK_ID + "@ \r\n ";
            q += "," + TEX_RECEIPT.TOTAL_AMOUNT + " = @" + TEX_RECEIPT.TOTAL_AMOUNT + "@ \r\n ";
            q += "," + TEX_RECEIPT.NOTES + " = @" + TEX_RECEIPT.NOTES + "@ \r\n ";
            q += "," + TEX_RECEIPT.ACTIVE_ID + " = @" + TEX_RECEIPT.ACTIVE_ID + "@ \r\n ";
            q += "," + TEX_RECEIPT.USER_ID + " = @" + TEX_RECEIPT.USER_ID + "@ \r\n ";
            q += "  WHERE " + TEX_RECEIPT.TEX_RECEIPT_ID + " = @" + TEX_RECEIPT.TEX_RECEIPT_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + TEX_RECEIPT.TEX_RECEIPT_TBL + " WHERE " + TEX_RECEIPT.TEX_RECEIPT_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
