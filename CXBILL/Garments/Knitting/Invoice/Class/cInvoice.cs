// Version : 2.0.0.0 dt : 16-10-2018
// Auto Generated
// last update : 22-10-2018 09:00:08 AM

using CXLIB;

namespace CXKNITTING
{
    public class CInvoice
    {

        #region[Get New]

        public static Knitting_Invoice GetNew
        {
            get
            {
                Knitting_Invoice obj = new Knitting_Invoice()
                {
                    Knitting_Invoice_id = string.Empty,
                    Uniqueno = string.Empty,
                    Company_id = Current.Company_id,
                    Acy_id = Current.Acy_id,
                    Knitting_Invoice_no = CInvoice_exten.GetNext_No,
                    Knitting_Invoice_date = string.Empty,
                    Taxtype_id = Core.SGST,
                    Salestype_id = Core.TAX_INVOICE,
                    Party_id = string.Empty,
                    Jobno = string.Empty,
                    Total_rolls = decimal.Zero,
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

        private static string AttachParams(string q, Knitting_Invoice v)
        {
            q = q.Replace("@" + KNITTING_INVOICE.KNITTING_INVOICE_ID + "@", "" + ConvertTO.SqlString(v.Knitting_Invoice_id) + "");
            q = q.Replace("@" + KNITTING_INVOICE.UNIQUENO + "@", "" + ConvertTO.SqlString(v.Uniqueno) + "");
            q = q.Replace("@" + KNITTING_INVOICE.COMPANY_ID + "@", "" + ConvertTO.SqlString(v.Company_id) + "");
            q = q.Replace("@" + KNITTING_INVOICE.ACY_ID + "@", "" + ConvertTO.SqlString(v.Acy_id) + "");
            q = q.Replace("@" + KNITTING_INVOICE.KNITTING_INVOICE_NO + "@", "" + ConvertTO.SqlInt(v.Knitting_Invoice_no) + "");
            q = q.Replace("@" + KNITTING_INVOICE.KNITTING_INVOICE_DATE + "@", "" + ConvertTO.SqlDate(v.Knitting_Invoice_date) + "");
            q = q.Replace("@" + KNITTING_INVOICE.TAXTYPE_ID + "@", "" + ConvertTO.SqlString(v.Taxtype_id) + "");
            q = q.Replace("@" + KNITTING_INVOICE.SALESTYPE_ID + "@", "" + ConvertTO.SqlString(v.Salestype_id) + "");
            q = q.Replace("@" + KNITTING_INVOICE.PARTY_ID + "@", "" + ConvertTO.SqlString(v.Party_id) + "");
            q = q.Replace("@" + KNITTING_INVOICE.JOBNO + "@", "" + ConvertTO.SqlString(v.Jobno) + "");
            q = q.Replace("@" + KNITTING_INVOICE.TOTAL_ROLLS + "@", "" + ConvertTO.SqlDecimal(v.Total_rolls) + "");
            q = q.Replace("@" + KNITTING_INVOICE.TOTAL_QTY + "@", "" + ConvertTO.SqlDecimal(v.Total_qty) + "");
            q = q.Replace("@" + KNITTING_INVOICE.TOTAL_TAXABLE_AMOUNT + "@", "" + ConvertTO.SqlDecimal(v.Total_taxable_amount) + "");
            q = q.Replace("@" + KNITTING_INVOICE.TOTAL_CGST + "@", "" + ConvertTO.SqlDecimal(v.Total_cgst) + "");
            q = q.Replace("@" + KNITTING_INVOICE.TOTAL_SGST + "@", "" + ConvertTO.SqlDecimal(v.Total_sgst) + "");
            q = q.Replace("@" + KNITTING_INVOICE.TOTAL_IGST + "@", "" + ConvertTO.SqlDecimal(v.Total_igst) + "");
            q = q.Replace("@" + KNITTING_INVOICE.GSTTOTAL + "@", "" + ConvertTO.SqlDecimal(v.Gsttotal) + "");
            q = q.Replace("@" + KNITTING_INVOICE.LEDGER_ID + "@", "" + ConvertTO.SqlString(v.Ledger_id) + "");
            q = q.Replace("@" + KNITTING_INVOICE.ADDITIONAL + "@", "" + ConvertTO.SqlDecimal(v.Additional) + "");
            q = q.Replace("@" + KNITTING_INVOICE.ROUNDS + "@", "" + ConvertTO.SqlDecimal(v.Rounds) + "");
            q = q.Replace("@" + KNITTING_INVOICE.GRANDTOTAL + "@", "" + ConvertTO.SqlDecimal(v.Grandtotal) + "");
            q = q.Replace("@" + KNITTING_INVOICE.REFERED_AMT + "@", "" + ConvertTO.SqlDecimal(v.Refered_amt) + "");
            q = q.Replace("@" + KNITTING_INVOICE.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            q = q.Replace("@" + KNITTING_INVOICE.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + KNITTING_INVOICE.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + KNITTING_INVOICE.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Knitting_Invoice v, DAL dalsession)
        {
            string q = " INSERT INTO " + KNITTING_INVOICE.KNITTING_INVOICE_TBL + " ( ";
            q += " " + KNITTING_INVOICE.UNIQUENO + " \r\n ";
            q += "," + KNITTING_INVOICE.COMPANY_ID + " \r\n ";
            q += "," + KNITTING_INVOICE.ACY_ID + " \r\n ";
            q += "," + KNITTING_INVOICE.KNITTING_INVOICE_NO + " \r\n ";
            q += "," + KNITTING_INVOICE.KNITTING_INVOICE_DATE + " \r\n ";
            q += "," + KNITTING_INVOICE.TAXTYPE_ID + " \r\n ";
            q += "," + KNITTING_INVOICE.SALESTYPE_ID + " \r\n ";
            q += "," + KNITTING_INVOICE.PARTY_ID + " \r\n ";
            q += "," + KNITTING_INVOICE.JOBNO + " \r\n ";
            q += "," + KNITTING_INVOICE.TOTAL_ROLLS + " \r\n ";
            q += "," + KNITTING_INVOICE.TOTAL_QTY + " \r\n ";
            q += "," + KNITTING_INVOICE.TOTAL_TAXABLE_AMOUNT + " \r\n ";
            q += "," + KNITTING_INVOICE.TOTAL_CGST + " \r\n ";
            q += "," + KNITTING_INVOICE.TOTAL_SGST + " \r\n ";
            q += "," + KNITTING_INVOICE.TOTAL_IGST + " \r\n ";
            q += "," + KNITTING_INVOICE.GSTTOTAL + " \r\n ";
            q += "," + KNITTING_INVOICE.LEDGER_ID + " \r\n ";
            q += "," + KNITTING_INVOICE.ADDITIONAL + " \r\n ";
            q += "," + KNITTING_INVOICE.ROUNDS + " \r\n ";
            q += "," + KNITTING_INVOICE.GRANDTOTAL + " \r\n ";
            q += "," + KNITTING_INVOICE.REFERED_AMT + " \r\n ";
            q += "," + KNITTING_INVOICE.LOCKED + " \r\n ";
            q += "," + KNITTING_INVOICE.NOTES + " \r\n ";
            q += "," + KNITTING_INVOICE.ACTIVE_ID + " \r\n ";
            q += "," + KNITTING_INVOICE.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + KNITTING_INVOICE.UNIQUENO + "@ \r\n ";
            q += ", @" + KNITTING_INVOICE.COMPANY_ID + "@ \r\n ";
            q += ", @" + KNITTING_INVOICE.ACY_ID + "@ \r\n ";
            q += ", @" + KNITTING_INVOICE.KNITTING_INVOICE_NO + "@ \r\n ";
            q += ", @" + KNITTING_INVOICE.KNITTING_INVOICE_DATE + "@ \r\n ";
            q += ", @" + KNITTING_INVOICE.TAXTYPE_ID + "@ \r\n ";
            q += ", @" + KNITTING_INVOICE.SALESTYPE_ID + "@ \r\n ";
            q += ", @" + KNITTING_INVOICE.PARTY_ID + "@ \r\n ";
            q += ", @" + KNITTING_INVOICE.JOBNO + "@ \r\n ";
            q += ", @" + KNITTING_INVOICE.TOTAL_QTY + "@ \r\n ";
            q += ", @" + KNITTING_INVOICE.TOTAL_ROLLS + "@ \r\n ";
            q += ", @" + KNITTING_INVOICE.TOTAL_TAXABLE_AMOUNT + "@ \r\n ";
            q += ", @" + KNITTING_INVOICE.TOTAL_CGST + "@ \r\n ";
            q += ", @" + KNITTING_INVOICE.TOTAL_SGST + "@ \r\n ";
            q += ", @" + KNITTING_INVOICE.TOTAL_IGST + "@ \r\n ";
            q += ", @" + KNITTING_INVOICE.GSTTOTAL + "@ \r\n ";
            q += ", @" + KNITTING_INVOICE.LEDGER_ID + "@ \r\n ";
            q += ", @" + KNITTING_INVOICE.ADDITIONAL + "@ \r\n ";
            q += ", @" + KNITTING_INVOICE.ROUNDS + "@ \r\n ";
            q += ", @" + KNITTING_INVOICE.GRANDTOTAL + "@ \r\n ";
            q += ", @" + KNITTING_INVOICE.REFERED_AMT + "@ \r\n ";
            q += ", @" + KNITTING_INVOICE.LOCKED + "@ \r\n ";
            q += ", @" + KNITTING_INVOICE.NOTES + "@ \r\n ";
            q += ", @" + KNITTING_INVOICE.ACTIVE_ID + "@ \r\n ";
            q += ", @" + KNITTING_INVOICE.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Knitting_Invoice v, DAL dalsession)
        {
            string q = "UPDATE " + KNITTING_INVOICE.KNITTING_INVOICE_TBL + " SET";
            q += " " + KNITTING_INVOICE.UNIQUENO + " = @" + KNITTING_INVOICE.UNIQUENO + "@ \r\n ";
            q += "," + KNITTING_INVOICE.COMPANY_ID + " = @" + KNITTING_INVOICE.COMPANY_ID + "@ \r\n ";
            q += "," + KNITTING_INVOICE.ACY_ID + " = @" + KNITTING_INVOICE.ACY_ID + "@ \r\n ";
            q += "," + KNITTING_INVOICE.KNITTING_INVOICE_NO + " = @" + KNITTING_INVOICE.KNITTING_INVOICE_NO + "@ \r\n ";
            q += "," + KNITTING_INVOICE.KNITTING_INVOICE_DATE + " = @" + KNITTING_INVOICE.KNITTING_INVOICE_DATE + "@ \r\n ";
            q += "," + KNITTING_INVOICE.TAXTYPE_ID + " = @" + KNITTING_INVOICE.TAXTYPE_ID + "@ \r\n ";
            q += "," + KNITTING_INVOICE.SALESTYPE_ID + " = @" + KNITTING_INVOICE.SALESTYPE_ID + "@ \r\n ";
            q += "," + KNITTING_INVOICE.PARTY_ID + " = @" + KNITTING_INVOICE.PARTY_ID + "@ \r\n ";
            q += "," + KNITTING_INVOICE.JOBNO + " = @" + KNITTING_INVOICE.JOBNO + "@ \r\n ";
            q += "," + KNITTING_INVOICE.TOTAL_ROLLS + " = @" + KNITTING_INVOICE.TOTAL_ROLLS + "@ \r\n ";
            q += "," + KNITTING_INVOICE.TOTAL_QTY + " = @" + KNITTING_INVOICE.TOTAL_QTY + "@ \r\n ";
            q += "," + KNITTING_INVOICE.TOTAL_TAXABLE_AMOUNT + " = @" + KNITTING_INVOICE.TOTAL_TAXABLE_AMOUNT + "@ \r\n ";
            q += "," + KNITTING_INVOICE.TOTAL_CGST + " = @" + KNITTING_INVOICE.TOTAL_CGST + "@ \r\n ";
            q += "," + KNITTING_INVOICE.TOTAL_SGST + " = @" + KNITTING_INVOICE.TOTAL_SGST + "@ \r\n ";
            q += "," + KNITTING_INVOICE.TOTAL_IGST + " = @" + KNITTING_INVOICE.TOTAL_IGST + "@ \r\n ";
            q += "," + KNITTING_INVOICE.GSTTOTAL + " = @" + KNITTING_INVOICE.GSTTOTAL + "@ \r\n ";
            q += "," + KNITTING_INVOICE.LEDGER_ID + " = @" + KNITTING_INVOICE.LEDGER_ID + "@ \r\n ";
            q += "," + KNITTING_INVOICE.ADDITIONAL + " = @" + KNITTING_INVOICE.ADDITIONAL + "@ \r\n ";
            q += "," + KNITTING_INVOICE.ROUNDS + " = @" + KNITTING_INVOICE.ROUNDS + "@ \r\n ";
            q += "," + KNITTING_INVOICE.GRANDTOTAL + " = @" + KNITTING_INVOICE.GRANDTOTAL + "@ \r\n ";
            q += "," + KNITTING_INVOICE.REFERED_AMT + " = @" + KNITTING_INVOICE.REFERED_AMT + "@ \r\n ";
            q += "," + KNITTING_INVOICE.LOCKED + " = @" + KNITTING_INVOICE.LOCKED + "@ \r\n ";
            q += "," + KNITTING_INVOICE.NOTES + " = @" + KNITTING_INVOICE.NOTES + "@ \r\n ";
            q += "," + KNITTING_INVOICE.ACTIVE_ID + " = @" + KNITTING_INVOICE.ACTIVE_ID + "@ \r\n ";
            q += "," + KNITTING_INVOICE.USER_ID + " = @" + KNITTING_INVOICE.USER_ID + "@ \r\n ";
            q += "  WHERE " + KNITTING_INVOICE.KNITTING_INVOICE_ID + " = @" + KNITTING_INVOICE.KNITTING_INVOICE_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + KNITTING_INVOICE.KNITTING_INVOICE_TBL + " WHERE " + KNITTING_INVOICE.KNITTING_INVOICE_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
