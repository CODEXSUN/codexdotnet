// Version : 2.0.0.0 dt : 16-10-2018
// Auto Generated
// last update : 22-10-2018 09:00:08 AM

using CXLIB;

namespace CXBILL
{
    public class CSara_invoice
    {

        #region[Get New]

        public static Offset_1_invoice GetNew
        {
            get
            {
                Offset_1_invoice obj = new Offset_1_invoice()
                {
                    Offset_1_invoice_id = string.Empty,
                    Uniqueno = string.Empty,
                    Company_id = Current.Company_id,
                    Acy_id = Current.Acy_id,
                    Offset_1_invoice_no = COffset_1_invoice_exten.GetNext_No,
                    Offset_1_invoice_date =string.Empty,
                    Salestype_id= Core.TAX_INVOICE,
                    Taxtype_id = Core.SGST,
                    Party_id = string.Empty,
                    Total_qty = decimal.Zero,
                    Total_taxable_amount = decimal.Zero,
                    Total_cgst = decimal.Zero,
                    Total_sgst = decimal.Zero,
                    Total_igst = decimal.Zero,
                    Gsttotal = decimal.Zero,
                    Ledger_id = string.Empty,
                    Additional = decimal.Zero,
                    Rounds = decimal.Zero,
                    Grandtotal = decimal.Zero,
                    Refered_amt = decimal.Zero,
                    Locked = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Offset_1_invoice v)
        {
            q = q.Replace("@" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_ID + "@", "" + ConvertTO.SqlString(v.Offset_1_invoice_id) + "");
            q = q.Replace("@" + OFFSET_1_INVOICE.UNIQUENO + "@", "" + ConvertTO.SqlString(v.Uniqueno) + "");
            q = q.Replace("@" + OFFSET_1_INVOICE.COMPANY_ID + "@", "" + ConvertTO.SqlString(v.Company_id) + "");
            q = q.Replace("@" + OFFSET_1_INVOICE.ACY_ID + "@", "" + ConvertTO.SqlString(v.Acy_id) + "");
            q = q.Replace("@" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_NO + "@", "" + ConvertTO.SqlInt(v.Offset_1_invoice_no) + "");
            q = q.Replace("@" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_DATE + "@", "" + ConvertTO.SqlDate(v.Offset_1_invoice_date) + "");
            q = q.Replace("@" + OFFSET_1_INVOICE.SALESTYPE_ID + "@", "" + ConvertTO.SqlString(v.Salestype_id) + "");
            q = q.Replace("@" + OFFSET_1_INVOICE.TAXTYPE_ID + "@", "" + ConvertTO.SqlString(v.Taxtype_id) + "");
            q = q.Replace("@" + OFFSET_1_INVOICE.PARTY_ID + "@", "" + ConvertTO.SqlString(v.Party_id) + "");
            q = q.Replace("@" + OFFSET_1_INVOICE.TOTAL_QTY + "@", "" + ConvertTO.SqlDecimal(v.Total_qty) + "");
            q = q.Replace("@" + OFFSET_1_INVOICE.TOTAL_TAXABLE_AMOUNT + "@", "" + ConvertTO.SqlDecimal(v.Total_taxable_amount) + "");
            q = q.Replace("@" + OFFSET_1_INVOICE.TOTAL_CGST + "@", "" + ConvertTO.SqlDecimal(v.Total_cgst) + "");
            q = q.Replace("@" + OFFSET_1_INVOICE.TOTAL_SGST + "@", "" + ConvertTO.SqlDecimal(v.Total_sgst) + "");
            q = q.Replace("@" + OFFSET_1_INVOICE.TOTAL_IGST + "@", "" + ConvertTO.SqlDecimal(v.Total_igst) + "");
            q = q.Replace("@" + OFFSET_1_INVOICE.GSTTOTAL + "@", "" + ConvertTO.SqlDecimal(v.Gsttotal) + "");
            q = q.Replace("@" + OFFSET_1_INVOICE.LEDGER_ID + "@", "" + ConvertTO.SqlString(v.Ledger_id) + "");
            q = q.Replace("@" + OFFSET_1_INVOICE.ADDITIONAL + "@", "" + ConvertTO.SqlDecimal(v.Additional) + "");
            q = q.Replace("@" + OFFSET_1_INVOICE.ROUNDS + "@", "" + ConvertTO.SqlDecimal(v.Rounds) + "");
            q = q.Replace("@" + OFFSET_1_INVOICE.GRANDTOTAL + "@", "" + ConvertTO.SqlDecimal(v.Grandtotal) + "");
            q = q.Replace("@" + OFFSET_1_INVOICE.REFERED_AMT + "@", "" + ConvertTO.SqlDecimal(v.Refered_amt) + "");
            q = q.Replace("@" + OFFSET_1_INVOICE.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            q = q.Replace("@" + OFFSET_1_INVOICE.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + OFFSET_1_INVOICE.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + OFFSET_1_INVOICE.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Offset_1_invoice v, DAL dalsession)
        {
            string q = " INSERT INTO " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + " ( ";
            q += " " + OFFSET_1_INVOICE.UNIQUENO + " \r\n ";
            q += "," + OFFSET_1_INVOICE.COMPANY_ID + " \r\n ";
            q += "," + OFFSET_1_INVOICE.ACY_ID + " \r\n ";
            q += "," + OFFSET_1_INVOICE.OFFSET_1_INVOICE_NO + " \r\n ";
            q += "," + OFFSET_1_INVOICE.OFFSET_1_INVOICE_DATE + " \r\n ";
            q += "," + OFFSET_1_INVOICE.SALESTYPE_ID + " \r\n ";
            q += "," + OFFSET_1_INVOICE.TAXTYPE_ID + " \r\n ";
            q += "," + OFFSET_1_INVOICE.PARTY_ID + " \r\n ";
            q += "," + OFFSET_1_INVOICE.TOTAL_QTY + " \r\n ";
            q += "," + OFFSET_1_INVOICE.TOTAL_TAXABLE_AMOUNT + " \r\n ";
            q += "," + OFFSET_1_INVOICE.TOTAL_CGST + " \r\n ";
            q += "," + OFFSET_1_INVOICE.TOTAL_SGST + " \r\n ";
            q += "," + OFFSET_1_INVOICE.TOTAL_IGST + " \r\n ";
            q += "," + OFFSET_1_INVOICE.GSTTOTAL + " \r\n ";
            q += "," + OFFSET_1_INVOICE.LEDGER_ID + " \r\n ";
            q += "," + OFFSET_1_INVOICE.ADDITIONAL + " \r\n ";
            q += "," + OFFSET_1_INVOICE.ROUNDS + " \r\n ";
            q += "," + OFFSET_1_INVOICE.GRANDTOTAL + " \r\n ";
            q += "," + OFFSET_1_INVOICE.REFERED_AMT + " \r\n ";
            q += "," + OFFSET_1_INVOICE.LOCKED + " \r\n ";
            q += "," + OFFSET_1_INVOICE.NOTES + " \r\n ";
            q += "," + OFFSET_1_INVOICE.ACTIVE_ID + " \r\n ";
            q += "," + OFFSET_1_INVOICE.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + OFFSET_1_INVOICE.UNIQUENO + "@ \r\n ";
            q += ", @" + OFFSET_1_INVOICE.COMPANY_ID + "@ \r\n ";
            q += ", @" + OFFSET_1_INVOICE.ACY_ID + "@ \r\n ";
            q += ", @" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_NO + "@ \r\n ";
            q += ", @" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_DATE + "@ \r\n ";
            q += ", @" + OFFSET_1_INVOICE.SALESTYPE_ID + "@ \r\n ";
            q += ", @" + OFFSET_1_INVOICE.TAXTYPE_ID + "@ \r\n ";
            q += ", @" + OFFSET_1_INVOICE.PARTY_ID + "@ \r\n ";
            q += ", @" + OFFSET_1_INVOICE.TOTAL_QTY + "@ \r\n ";
            q += ", @" + OFFSET_1_INVOICE.TOTAL_TAXABLE_AMOUNT + "@ \r\n ";
            q += ", @" + OFFSET_1_INVOICE.TOTAL_CGST + "@ \r\n ";
            q += ", @" + OFFSET_1_INVOICE.TOTAL_SGST + "@ \r\n ";
            q += ", @" + OFFSET_1_INVOICE.TOTAL_IGST + "@ \r\n ";
            q += ", @" + OFFSET_1_INVOICE.GSTTOTAL + "@ \r\n ";
            q += ", @" + OFFSET_1_INVOICE.LEDGER_ID + "@ \r\n ";
            q += ", @" + OFFSET_1_INVOICE.ADDITIONAL + "@ \r\n ";
            q += ", @" + OFFSET_1_INVOICE.ROUNDS + "@ \r\n ";
            q += ", @" + OFFSET_1_INVOICE.GRANDTOTAL + "@ \r\n ";
            q += ", @" + OFFSET_1_INVOICE.REFERED_AMT + "@ \r\n ";
            q += ", @" + OFFSET_1_INVOICE.LOCKED + "@ \r\n ";
            q += ", @" + OFFSET_1_INVOICE.NOTES + "@ \r\n ";
            q += ", @" + OFFSET_1_INVOICE.ACTIVE_ID + "@ \r\n ";
            q += ", @" + OFFSET_1_INVOICE.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Offset_1_invoice v, DAL dalsession)
        {
            string q = "UPDATE " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + " SET";
            q += " " + OFFSET_1_INVOICE.UNIQUENO + " = @" + OFFSET_1_INVOICE.UNIQUENO + "@ \r\n ";
            q += "," + OFFSET_1_INVOICE.COMPANY_ID + " = @" + OFFSET_1_INVOICE.COMPANY_ID + "@ \r\n ";
            q += "," + OFFSET_1_INVOICE.ACY_ID + " = @" + OFFSET_1_INVOICE.ACY_ID + "@ \r\n ";
            q += "," + OFFSET_1_INVOICE.OFFSET_1_INVOICE_NO + " = @" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_NO + "@ \r\n ";
            q += "," + OFFSET_1_INVOICE.OFFSET_1_INVOICE_DATE + " = @" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_DATE + "@ \r\n ";
            q += "," + OFFSET_1_INVOICE.SALESTYPE_ID + " = @" + OFFSET_1_INVOICE.SALESTYPE_ID + "@ \r\n ";
            q += "," + OFFSET_1_INVOICE.TAXTYPE_ID + " = @" + OFFSET_1_INVOICE.TAXTYPE_ID + "@ \r\n ";
            q += "," + OFFSET_1_INVOICE.PARTY_ID + " = @" + OFFSET_1_INVOICE.PARTY_ID + "@ \r\n ";
            q += "," + OFFSET_1_INVOICE.TOTAL_QTY + " = @" + OFFSET_1_INVOICE.TOTAL_QTY + "@ \r\n ";
            q += "," + OFFSET_1_INVOICE.TOTAL_TAXABLE_AMOUNT + " = @" + OFFSET_1_INVOICE.TOTAL_TAXABLE_AMOUNT + "@ \r\n ";
            q += "," + OFFSET_1_INVOICE.TOTAL_CGST + " = @" + OFFSET_1_INVOICE.TOTAL_CGST + "@ \r\n ";
            q += "," + OFFSET_1_INVOICE.TOTAL_SGST + " = @" + OFFSET_1_INVOICE.TOTAL_SGST + "@ \r\n ";
            q += "," + OFFSET_1_INVOICE.TOTAL_IGST + " = @" + OFFSET_1_INVOICE.TOTAL_IGST + "@ \r\n ";
            q += "," + OFFSET_1_INVOICE.GSTTOTAL + " = @" + OFFSET_1_INVOICE.GSTTOTAL + "@ \r\n ";
            q += "," + OFFSET_1_INVOICE.LEDGER_ID + " = @" + OFFSET_1_INVOICE.LEDGER_ID + "@ \r\n ";
            q += "," + OFFSET_1_INVOICE.ADDITIONAL + " = @" + OFFSET_1_INVOICE.ADDITIONAL + "@ \r\n ";
            q += "," + OFFSET_1_INVOICE.ROUNDS + " = @" + OFFSET_1_INVOICE.ROUNDS + "@ \r\n ";
            q += "," + OFFSET_1_INVOICE.GRANDTOTAL + " = @" + OFFSET_1_INVOICE.GRANDTOTAL + "@ \r\n ";
            q += "," + OFFSET_1_INVOICE.REFERED_AMT + " = @" + OFFSET_1_INVOICE.REFERED_AMT + "@ \r\n ";
            q += "," + OFFSET_1_INVOICE.LOCKED + " = @" + OFFSET_1_INVOICE.LOCKED + "@ \r\n ";
            q += "," + OFFSET_1_INVOICE.NOTES + " = @" + OFFSET_1_INVOICE.NOTES + "@ \r\n ";
            q += "," + OFFSET_1_INVOICE.ACTIVE_ID + " = @" + OFFSET_1_INVOICE.ACTIVE_ID + "@ \r\n ";
            q += "," + OFFSET_1_INVOICE.USER_ID + " = @" + OFFSET_1_INVOICE.USER_ID + "@ \r\n ";
            q += "  WHERE " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_ID + " = @" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + " WHERE " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns