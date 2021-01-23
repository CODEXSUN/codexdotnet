// Version : 2.0.0.0 dt : 16-10-2018
// Auto Generated
// last update : 22-10-2018 09:00:08 AM

using CXBILL_EXTEN.Invoice.Const;
using CXLIB;

namespace CXBILL_EXTEN.Invoice.Class
{
    public class CInvoice
    {

        #region[Get New]

        public static Const.Invoice GetNew
        {
            get
            {
                Const.Invoice obj = new Const.Invoice()
                {
                    Invoice_id = string.Empty,
                    Uniqueno = string.Empty,
                    Company_id = Current.Company_id,
                    Acy_id = Current.Acy_id,
                    Order_id = string.Empty,
                    Invoice_no = CInvoice_exten.GetNext_No.ToString(),
                    Invoice_date = string.Empty,
                    Taxtype_id = Core.SGST,
                    Salestype_id = Core.TAX_INVOICE,
                    Party_id = string.Empty,
                    Transport_id = string.Empty,
                    Deliveredto_id = string.Empty,
                    Bundel = string.Empty,
                    Total_qty = string.Empty,
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

        private static string AttachParams(string q, Const.Invoice v)
        {
            q = q.Replace("@" + INVOICE.INVOICE_ID + "@", "" + ConvertTO.SqlString(v.Invoice_id) + "");
            q = q.Replace("@" + INVOICE.UNIQUENO + "@", "" + ConvertTO.SqlString(v.Uniqueno) + "");
            q = q.Replace("@" + INVOICE.COMPANY_ID + "@", "" + ConvertTO.SqlString(v.Company_id) + "");
            q = q.Replace("@" + INVOICE.ACY_ID + "@", "" + ConvertTO.SqlString(v.Acy_id) + "");
            q = q.Replace("@" + INVOICE.ORDER_ID + "@", "" + ConvertTO.SqlString(v.Order_id) + "");
            q = q.Replace("@" + INVOICE.INVOICE_NO + "@", "" + ConvertTO.SqlString(v.Invoice_no) + "");
            q = q.Replace("@" + INVOICE.INVOICE_DATE + "@", "" + ConvertTO.SqlDate(v.Invoice_date) + "");
            q = q.Replace("@" + INVOICE.TAXTYPE_ID + "@", "" + ConvertTO.SqlString(v.Taxtype_id) + "");
            q = q.Replace("@" + INVOICE.SALESTYPE_ID + "@", "" + ConvertTO.SqlString(v.Salestype_id) + "");
            q = q.Replace("@" + INVOICE.PARTY_ID + "@", "" + ConvertTO.SqlString(v.Party_id) + "");
            q = q.Replace("@" + INVOICE.TRANSPORT_ID + "@", "" + ConvertTO.SqlString(v.Transport_id) + "");
            q = q.Replace("@" + INVOICE.DELIVEREDTO_ID + "@", "" + ConvertTO.SqlString(v.Deliveredto_id) + "");
            q = q.Replace("@" + INVOICE.BUNDEL + "@", "" + ConvertTO.SqlString(v.Bundel) + "");
            q = q.Replace("@" + INVOICE.TOTAL_QTY + "@", "" + ConvertTO.SqlString(v.Total_qty) + "");
            q = q.Replace("@" + INVOICE.TOTAL_TAXABLE_AMOUNT + "@", "" + ConvertTO.SqlDecimal(v.Total_taxable_amount) + "");
            q = q.Replace("@" + INVOICE.TOTAL_CGST + "@", "" + ConvertTO.SqlDecimal(v.Total_cgst) + "");
            q = q.Replace("@" + INVOICE.TOTAL_SGST + "@", "" + ConvertTO.SqlDecimal(v.Total_sgst) + "");
            q = q.Replace("@" + INVOICE.TOTAL_IGST + "@", "" + ConvertTO.SqlDecimal(v.Total_igst) + "");
            q = q.Replace("@" + INVOICE.GSTTOTAL + "@", "" + ConvertTO.SqlDecimal(v.Gsttotal) + "");
            q = q.Replace("@" + INVOICE.LEDGER_ID + "@", "" + ConvertTO.SqlString(v.Ledger_id) + "");
            q = q.Replace("@" + INVOICE.ADDITIONAL + "@", "" + ConvertTO.SqlDecimal(v.Additional) + "");
            q = q.Replace("@" + INVOICE.ROUNDS + "@", "" + ConvertTO.SqlDecimal(v.Rounds) + "");
            q = q.Replace("@" + INVOICE.GRANDTOTAL + "@", "" + ConvertTO.SqlDecimal(v.Grandtotal) + "");
            q = q.Replace("@" + INVOICE.REFERED_AMT + "@", "" + ConvertTO.SqlDecimal(v.Refered_amt) + "");
            q = q.Replace("@" + INVOICE.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            q = q.Replace("@" + INVOICE.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + INVOICE.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + INVOICE.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Const.Invoice v, DAL dalsession)
        {
            string q = " INSERT INTO " + INVOICE.INVOICE_TBL + " ( ";
            q += " " + INVOICE.UNIQUENO + " \r\n ";
            q += "," + INVOICE.COMPANY_ID + " \r\n ";
            q += "," + INVOICE.ACY_ID + " \r\n ";
            q += "," + INVOICE.ORDER_ID + " \r\n ";
            q += "," + INVOICE.INVOICE_NO + " \r\n ";
            q += "," + INVOICE.INVOICE_DATE + " \r\n ";
            q += "," + INVOICE.TAXTYPE_ID + " \r\n ";
            q += "," + INVOICE.SALESTYPE_ID + " \r\n ";
            q += "," + INVOICE.PARTY_ID + " \r\n ";
            q += "," + INVOICE.TRANSPORT_ID + " \r\n ";
            q += "," + INVOICE.DELIVEREDTO_ID + " \r\n ";
            q += "," + INVOICE.BUNDEL + " \r\n ";
            q += "," + INVOICE.TOTAL_QTY + " \r\n ";
            q += "," + INVOICE.TOTAL_TAXABLE_AMOUNT + " \r\n ";
            q += "," + INVOICE.TOTAL_CGST + " \r\n ";
            q += "," + INVOICE.TOTAL_SGST + " \r\n ";
            q += "," + INVOICE.TOTAL_IGST + " \r\n ";
            q += "," + INVOICE.GSTTOTAL + " \r\n ";
            q += "," + INVOICE.LEDGER_ID + " \r\n ";
            q += "," + INVOICE.ADDITIONAL + " \r\n ";
            q += "," + INVOICE.ROUNDS + " \r\n ";
            q += "," + INVOICE.GRANDTOTAL + " \r\n ";
            q += "," + INVOICE.REFERED_AMT + " \r\n ";
            q += "," + INVOICE.LOCKED + " \r\n ";
            q += "," + INVOICE.NOTES + " \r\n ";
            q += "," + INVOICE.ACTIVE_ID + " \r\n ";
            q += "," + INVOICE.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + INVOICE.UNIQUENO + "@ \r\n ";
            q += ", @" + INVOICE.COMPANY_ID + "@ \r\n ";
            q += ", @" + INVOICE.ACY_ID + "@ \r\n ";
            q += ", @" + INVOICE.ORDER_ID + "@ \r\n ";
            q += ", @" + INVOICE.INVOICE_NO + "@ \r\n ";
            q += ", @" + INVOICE.INVOICE_DATE + "@ \r\n ";
            q += ", @" + INVOICE.TAXTYPE_ID + "@ \r\n ";
            q += ", @" + INVOICE.SALESTYPE_ID + "@ \r\n ";
            q += ", @" + INVOICE.PARTY_ID + "@ \r\n ";
            q += ", @" + INVOICE.TRANSPORT_ID + "@ \r\n ";
            q += ", @" + INVOICE.DELIVEREDTO_ID + "@ \r\n ";
            q += ", @" + INVOICE.BUNDEL + "@ \r\n ";
            q += ", @" + INVOICE.TOTAL_QTY + "@ \r\n ";
            q += ", @" + INVOICE.TOTAL_TAXABLE_AMOUNT + "@ \r\n ";
            q += ", @" + INVOICE.TOTAL_CGST + "@ \r\n ";
            q += ", @" + INVOICE.TOTAL_SGST + "@ \r\n ";
            q += ", @" + INVOICE.TOTAL_IGST + "@ \r\n ";
            q += ", @" + INVOICE.GSTTOTAL + "@ \r\n ";
            q += ", @" + INVOICE.LEDGER_ID + "@ \r\n ";
            q += ", @" + INVOICE.ADDITIONAL + "@ \r\n ";
            q += ", @" + INVOICE.ROUNDS + "@ \r\n ";
            q += ", @" + INVOICE.GRANDTOTAL + "@ \r\n ";
            q += ", @" + INVOICE.REFERED_AMT + "@ \r\n ";
            q += ", @" + INVOICE.LOCKED + "@ \r\n ";
            q += ", @" + INVOICE.NOTES + "@ \r\n ";
            q += ", @" + INVOICE.ACTIVE_ID + "@ \r\n ";
            q += ", @" + INVOICE.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Const.Invoice v, DAL dalsession)
        {
            string q = "UPDATE " + INVOICE.INVOICE_TBL + " SET";
            q += " " + INVOICE.UNIQUENO + " = @" + INVOICE.UNIQUENO + "@ \r\n ";
            q += "," + INVOICE.COMPANY_ID + " = @" + INVOICE.COMPANY_ID + "@ \r\n ";
            q += "," + INVOICE.ACY_ID + " = @" + INVOICE.ACY_ID + "@ \r\n ";
            q += "," + INVOICE.ORDER_ID + " = @" + INVOICE.ORDER_ID + "@ \r\n ";
            q += "," + INVOICE.INVOICE_NO + " = @" + INVOICE.INVOICE_NO + "@ \r\n ";
            q += "," + INVOICE.INVOICE_DATE + " = @" + INVOICE.INVOICE_DATE + "@ \r\n ";
            q += "," + INVOICE.TAXTYPE_ID + " = @" + INVOICE.TAXTYPE_ID + "@ \r\n ";
            q += "," + INVOICE.SALESTYPE_ID + " = @" + INVOICE.SALESTYPE_ID + "@ \r\n ";
            q += "," + INVOICE.PARTY_ID + " = @" + INVOICE.PARTY_ID + "@ \r\n ";
            q += "," + INVOICE.TRANSPORT_ID + " = @" + INVOICE.TRANSPORT_ID + "@ \r\n ";
            q += "," + INVOICE.DELIVEREDTO_ID + " = @" + INVOICE.DELIVEREDTO_ID + "@ \r\n ";
            q += "," + INVOICE.BUNDEL + " = @" + INVOICE.BUNDEL + "@ \r\n ";
            q += "," + INVOICE.TOTAL_QTY + " = @" + INVOICE.TOTAL_QTY + "@ \r\n ";
            q += "," + INVOICE.TOTAL_TAXABLE_AMOUNT + " = @" + INVOICE.TOTAL_TAXABLE_AMOUNT + "@ \r\n ";
            q += "," + INVOICE.TOTAL_CGST + " = @" + INVOICE.TOTAL_CGST + "@ \r\n ";
            q += "," + INVOICE.TOTAL_SGST + " = @" + INVOICE.TOTAL_SGST + "@ \r\n ";
            q += "," + INVOICE.TOTAL_IGST + " = @" + INVOICE.TOTAL_IGST + "@ \r\n ";
            q += "," + INVOICE.GSTTOTAL + " = @" + INVOICE.GSTTOTAL + "@ \r\n ";
            q += "," + INVOICE.LEDGER_ID + " = @" + INVOICE.LEDGER_ID + "@ \r\n ";
            q += "," + INVOICE.ADDITIONAL + " = @" + INVOICE.ADDITIONAL + "@ \r\n ";
            q += "," + INVOICE.ROUNDS + " = @" + INVOICE.ROUNDS + "@ \r\n ";
            q += "," + INVOICE.GRANDTOTAL + " = @" + INVOICE.GRANDTOTAL + "@ \r\n ";
            q += "," + INVOICE.REFERED_AMT + " = @" + INVOICE.REFERED_AMT + "@ \r\n ";
            q += "," + INVOICE.LOCKED + " = @" + INVOICE.LOCKED + "@ \r\n ";
            q += "," + INVOICE.NOTES + " = @" + INVOICE.NOTES + "@ \r\n ";
            q += "," + INVOICE.ACTIVE_ID + " = @" + INVOICE.ACTIVE_ID + "@ \r\n ";
            q += "," + INVOICE.USER_ID + " = @" + INVOICE.USER_ID + "@ \r\n ";
            q += "  WHERE " + INVOICE.INVOICE_ID + " = @" + INVOICE.INVOICE_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + INVOICE.INVOICE_TBL + " WHERE " + INVOICE.INVOICE_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
