// Version : 2.0.0.0 dt : 16-10-2018
// Auto Generated
// last update : 22-10-2018 09:00:08 AM

using CXCORE;
using CXLIB;

namespace CXBILL
{
    public class CTex_Invoice
    {

        #region[Get New]

        public static Tex_Invoice GetNew
        {
            get
            {
                Tex_Invoice obj = new Tex_Invoice()
                {
                    Tex_invoice_id = string.Empty,
                    Uniqueno = string.Empty,
                    Company_id = Current.Company_id,
                    Acy_id = Current.Acy_id,
                    Order_id = string.Empty,
                    Invoice_no = CSeq_exten.GetNextNo(SEQ.INV_NO,new DAL()),
                    Invoice_date = string.Empty,
                    Taxtype_id = Core.SGST,
                    Salestype_id = Core.TAX_INVOICE,
                    Party_id = string.Empty,
                    Transport_id = string.Empty,
                    Deliveredto_id = string.Empty,
                    Bundel = string.Empty,
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

        private static string AttachParams(string q, Tex_Invoice v)
        {
            q = q.Replace("@" + TEX_INVOICE.TEX_INVOICE_ID + "@", "" + ConvertTO.SqlString(v.Tex_invoice_id) + "");
            q = q.Replace("@" + TEX_INVOICE.UNIQUENO + "@", "" + ConvertTO.SqlString(v.Uniqueno) + "");
            q = q.Replace("@" + TEX_INVOICE.COMPANY_ID + "@", "" + ConvertTO.SqlString(v.Company_id) + "");
            q = q.Replace("@" + TEX_INVOICE.ACY_ID + "@", "" + ConvertTO.SqlString(v.Acy_id) + "");
            q = q.Replace("@" + TEX_INVOICE.ORDER_ID + "@", "" + ConvertTO.SqlString(v.Order_id) + "");
            q = q.Replace("@" + TEX_INVOICE.INVOICE_NO + "@", "" + ConvertTO.SqlString(v.Invoice_no) + "");
            q = q.Replace("@" + TEX_INVOICE.INVOICE_DATE + "@", "" + ConvertTO.SqlDate(v.Invoice_date) + "");
            q = q.Replace("@" + TEX_INVOICE.TAXTYPE_ID + "@", "" + ConvertTO.SqlString(v.Taxtype_id) + "");
            q = q.Replace("@" + TEX_INVOICE.SALESTYPE_ID + "@", "" + ConvertTO.SqlString(v.Salestype_id) + "");
            q = q.Replace("@" + TEX_INVOICE.PARTY_ID + "@", "" + ConvertTO.SqlString(v.Party_id) + "");
            q = q.Replace("@" + TEX_INVOICE.TRANSPORT_ID + "@", "" + ConvertTO.SqlString(v.Transport_id) + "");
            q = q.Replace("@" + TEX_INVOICE.DELIVEREDTO_ID + "@", "" + ConvertTO.SqlString(v.Deliveredto_id) + "");
            q = q.Replace("@" + TEX_INVOICE.BUNDEL + "@", "" + ConvertTO.SqlString(v.Bundel) + "");
            q = q.Replace("@" + TEX_INVOICE.TOTAL_QTY + "@", "" + ConvertTO.SqlDecimal(v.Total_qty) + "");
            q = q.Replace("@" + TEX_INVOICE.TOTAL_TAXABLE_AMOUNT + "@", "" + ConvertTO.SqlDecimal(v.Total_taxable_amount) + "");
            q = q.Replace("@" + TEX_INVOICE.TOTAL_CGST + "@", "" + ConvertTO.SqlDecimal(v.Total_cgst) + "");
            q = q.Replace("@" + TEX_INVOICE.TOTAL_SGST + "@", "" + ConvertTO.SqlDecimal(v.Total_sgst) + "");
            q = q.Replace("@" + TEX_INVOICE.TOTAL_IGST + "@", "" + ConvertTO.SqlDecimal(v.Total_igst) + "");
            q = q.Replace("@" + TEX_INVOICE.GSTTOTAL + "@", "" + ConvertTO.SqlDecimal(v.Gsttotal) + "");
            q = q.Replace("@" + TEX_INVOICE.LEDGER_ID + "@", "" + ConvertTO.SqlString(v.Ledger_id) + "");
            q = q.Replace("@" + TEX_INVOICE.ADDITIONAL + "@", "" + ConvertTO.SqlDecimal(v.Additional) + "");
            q = q.Replace("@" + TEX_INVOICE.ROUNDS + "@", "" + ConvertTO.SqlDecimal(v.Rounds) + "");
            q = q.Replace("@" + TEX_INVOICE.GRANDTOTAL + "@", "" + ConvertTO.SqlDecimal(v.Grandtotal) + "");
            q = q.Replace("@" + TEX_INVOICE.REFERED_AMT + "@", "" + ConvertTO.SqlDecimal(v.Refered_amt) + "");
            q = q.Replace("@" + TEX_INVOICE.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            q = q.Replace("@" + TEX_INVOICE.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + TEX_INVOICE.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + TEX_INVOICE.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Tex_Invoice v, DAL dalsession)
        {
            string q = " INSERT INTO " + TEX_INVOICE.TEX_INVOICE_TBL + " ( ";
            q += " " + TEX_INVOICE.UNIQUENO + " \r\n ";
            q += "," + TEX_INVOICE.COMPANY_ID + " \r\n ";
            q += "," + TEX_INVOICE.ACY_ID + " \r\n ";
            q += "," + TEX_INVOICE.ORDER_ID + " \r\n ";
            q += "," + TEX_INVOICE.INVOICE_NO + " \r\n ";
            q += "," + TEX_INVOICE.INVOICE_DATE + " \r\n ";
            q += "," + TEX_INVOICE.TAXTYPE_ID + " \r\n ";
            q += "," + TEX_INVOICE.SALESTYPE_ID + " \r\n ";
            q += "," + TEX_INVOICE.PARTY_ID + " \r\n ";
            q += "," + TEX_INVOICE.TRANSPORT_ID + " \r\n ";
            q += "," + TEX_INVOICE.DELIVEREDTO_ID + " \r\n ";
            q += "," + TEX_INVOICE.BUNDEL + " \r\n ";
            q += "," + TEX_INVOICE.TOTAL_QTY + " \r\n ";
            q += "," + TEX_INVOICE.TOTAL_TAXABLE_AMOUNT + " \r\n ";
            q += "," + TEX_INVOICE.TOTAL_CGST + " \r\n ";
            q += "," + TEX_INVOICE.TOTAL_SGST + " \r\n ";
            q += "," + TEX_INVOICE.TOTAL_IGST + " \r\n ";
            q += "," + TEX_INVOICE.GSTTOTAL + " \r\n ";
            q += "," + TEX_INVOICE.LEDGER_ID + " \r\n ";
            q += "," + TEX_INVOICE.ADDITIONAL + " \r\n ";
            q += "," + TEX_INVOICE.ROUNDS + " \r\n ";
            q += "," + TEX_INVOICE.GRANDTOTAL + " \r\n ";
            q += "," + TEX_INVOICE.REFERED_AMT + " \r\n ";
            q += "," + TEX_INVOICE.LOCKED + " \r\n ";
            q += "," + TEX_INVOICE.NOTES + " \r\n ";
            q += "," + TEX_INVOICE.ACTIVE_ID + " \r\n ";
            q += "," + TEX_INVOICE.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + TEX_INVOICE.UNIQUENO + "@ \r\n ";
            q += ", @" + TEX_INVOICE.COMPANY_ID + "@ \r\n ";
            q += ", @" + TEX_INVOICE.ACY_ID + "@ \r\n ";
            q += ", @" + TEX_INVOICE.ORDER_ID + "@ \r\n ";
            q += ", @" + TEX_INVOICE.INVOICE_NO + "@ \r\n ";
            q += ", @" + TEX_INVOICE.INVOICE_DATE + "@ \r\n ";
            q += ", @" + TEX_INVOICE.TAXTYPE_ID + "@ \r\n ";
            q += ", @" + TEX_INVOICE.SALESTYPE_ID + "@ \r\n ";
            q += ", @" + TEX_INVOICE.PARTY_ID + "@ \r\n ";
            q += ", @" + TEX_INVOICE.TRANSPORT_ID + "@ \r\n ";
            q += ", @" + TEX_INVOICE.DELIVEREDTO_ID + "@ \r\n ";
            q += ", @" + TEX_INVOICE.BUNDEL + "@ \r\n ";
            q += ", @" + TEX_INVOICE.TOTAL_QTY + "@ \r\n ";
            q += ", @" + TEX_INVOICE.TOTAL_TAXABLE_AMOUNT + "@ \r\n ";
            q += ", @" + TEX_INVOICE.TOTAL_CGST + "@ \r\n ";
            q += ", @" + TEX_INVOICE.TOTAL_SGST + "@ \r\n ";
            q += ", @" + TEX_INVOICE.TOTAL_IGST + "@ \r\n ";
            q += ", @" + TEX_INVOICE.GSTTOTAL + "@ \r\n ";
            q += ", @" + TEX_INVOICE.LEDGER_ID + "@ \r\n ";
            q += ", @" + TEX_INVOICE.ADDITIONAL + "@ \r\n ";
            q += ", @" + TEX_INVOICE.ROUNDS + "@ \r\n ";
            q += ", @" + TEX_INVOICE.GRANDTOTAL + "@ \r\n ";
            q += ", @" + TEX_INVOICE.REFERED_AMT + "@ \r\n ";
            q += ", @" + TEX_INVOICE.LOCKED + "@ \r\n ";
            q += ", @" + TEX_INVOICE.NOTES + "@ \r\n ";
            q += ", @" + TEX_INVOICE.ACTIVE_ID + "@ \r\n ";
            q += ", @" + TEX_INVOICE.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Tex_Invoice v, DAL dalsession)
        {
            string q = "UPDATE " + TEX_INVOICE.TEX_INVOICE_TBL + " SET";
            q += " " + TEX_INVOICE.UNIQUENO + " = @" + TEX_INVOICE.UNIQUENO + "@ \r\n ";
            q += "," + TEX_INVOICE.COMPANY_ID + " = @" + TEX_INVOICE.COMPANY_ID + "@ \r\n ";
            q += "," + TEX_INVOICE.ACY_ID + " = @" + TEX_INVOICE.ACY_ID + "@ \r\n ";
            q += "," + TEX_INVOICE.ORDER_ID + " = @" + TEX_INVOICE.ORDER_ID + "@ \r\n ";
            q += "," + TEX_INVOICE.INVOICE_NO + " = @" + TEX_INVOICE.INVOICE_NO + "@ \r\n ";
            q += "," + TEX_INVOICE.INVOICE_DATE + " = @" + TEX_INVOICE.INVOICE_DATE + "@ \r\n ";
            q += "," + TEX_INVOICE.TAXTYPE_ID + " = @" + TEX_INVOICE.TAXTYPE_ID + "@ \r\n ";
            q += "," + TEX_INVOICE.SALESTYPE_ID + " = @" + TEX_INVOICE.SALESTYPE_ID + "@ \r\n ";
            q += "," + TEX_INVOICE.PARTY_ID + " = @" + TEX_INVOICE.PARTY_ID + "@ \r\n ";
            q += "," + TEX_INVOICE.TRANSPORT_ID + " = @" + TEX_INVOICE.TRANSPORT_ID + "@ \r\n ";
            q += "," + TEX_INVOICE.DELIVEREDTO_ID + " = @" + TEX_INVOICE.DELIVEREDTO_ID + "@ \r\n ";
            q += "," + TEX_INVOICE.BUNDEL + " = @" + TEX_INVOICE.BUNDEL + "@ \r\n ";
            q += "," + TEX_INVOICE.TOTAL_QTY + " = @" + TEX_INVOICE.TOTAL_QTY + "@ \r\n ";
            q += "," + TEX_INVOICE.TOTAL_TAXABLE_AMOUNT + " = @" + TEX_INVOICE.TOTAL_TAXABLE_AMOUNT + "@ \r\n ";
            q += "," + TEX_INVOICE.TOTAL_CGST + " = @" + TEX_INVOICE.TOTAL_CGST + "@ \r\n ";
            q += "," + TEX_INVOICE.TOTAL_SGST + " = @" + TEX_INVOICE.TOTAL_SGST + "@ \r\n ";
            q += "," + TEX_INVOICE.TOTAL_IGST + " = @" + TEX_INVOICE.TOTAL_IGST + "@ \r\n ";
            q += "," + TEX_INVOICE.GSTTOTAL + " = @" + TEX_INVOICE.GSTTOTAL + "@ \r\n ";
            q += "," + TEX_INVOICE.LEDGER_ID + " = @" + TEX_INVOICE.LEDGER_ID + "@ \r\n ";
            q += "," + TEX_INVOICE.ADDITIONAL + " = @" + TEX_INVOICE.ADDITIONAL + "@ \r\n ";
            q += "," + TEX_INVOICE.ROUNDS + " = @" + TEX_INVOICE.ROUNDS + "@ \r\n ";
            q += "," + TEX_INVOICE.GRANDTOTAL + " = @" + TEX_INVOICE.GRANDTOTAL + "@ \r\n ";
            q += "," + TEX_INVOICE.REFERED_AMT + " = @" + TEX_INVOICE.REFERED_AMT + "@ \r\n ";
            q += "," + TEX_INVOICE.LOCKED + " = @" + TEX_INVOICE.LOCKED + "@ \r\n ";
            q += "," + TEX_INVOICE.NOTES + " = @" + TEX_INVOICE.NOTES + "@ \r\n ";
            q += "," + TEX_INVOICE.ACTIVE_ID + " = @" + TEX_INVOICE.ACTIVE_ID + "@ \r\n ";
            q += "," + TEX_INVOICE.USER_ID + " = @" + TEX_INVOICE.USER_ID + "@ \r\n ";
            q += "  WHERE " + TEX_INVOICE.TEX_INVOICE_ID + " = @" + TEX_INVOICE.TEX_INVOICE_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + TEX_INVOICE.TEX_INVOICE_TBL + " WHERE " + TEX_INVOICE.TEX_INVOICE_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
