// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 21-06-2019 10:08:17 AM

using CXLIB;

namespace CXBILL
{
    public class CGarment_invoice
    {

        #region[Get New]

        public static Garment_invoice GetNew
        {
            get
            {
                Garment_invoice obj = new Garment_invoice()
                {
                    Garment_invoice_id = string.Empty,
                    Uniqueno = string.Empty,
                    Company_id = Current.Company_id,
                    Acy_id = Current.Acy_id,
                    Order_id = string.Empty,
                    Salestype_id = Core.TAX_INVOICE,
                    Taxtype_id = Core.SGST,
                    Garment_invoice_no = CGarment_invoice_exten.GetNext_No,
                    Garment_invoice_date = string.Empty,
                    Party_id = string.Empty,
                    Total_qty =  decimal.Zero,
                    Total_taxable_amount =  decimal.Zero,
                    Total_cgst =  decimal.Zero,
                    Total_sgst =  decimal.Zero,
                    Total_igst =  decimal.Zero,
                    Gsttotal =  decimal.Zero,
                    Ledger_id = string.Empty,
                    Additional =  decimal.Zero,
                    Rounds =  decimal.Zero,
                    Grandtotal =  decimal.Zero,
                    Refered_amt =  decimal.Zero,
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

        private static string AttachParams(string q, Garment_invoice v)
        {
            q = q.Replace("@" + GARMENT_INVOICE.GARMENT_INVOICE_ID + "@", "" + ConvertTO.SqlString(v.Garment_invoice_id) + "");
            q = q.Replace("@" + GARMENT_INVOICE.UNIQUENO + "@", "" + ConvertTO.SqlString(v.Uniqueno) + "");
            q = q.Replace("@" + GARMENT_INVOICE.COMPANY_ID + "@", "" + ConvertTO.SqlString(v.Company_id) + "");
            q = q.Replace("@" + GARMENT_INVOICE.ACY_ID + "@", "" + ConvertTO.SqlString(v.Acy_id) + "");
            q = q.Replace("@" + GARMENT_INVOICE.ORDER_ID + "@", "" + ConvertTO.SqlString(v.Order_id) + "");
            q = q.Replace("@" + GARMENT_INVOICE.SALESTYPE_ID + "@", "" + ConvertTO.SqlString(v.Salestype_id) + "");
            q = q.Replace("@" + GARMENT_INVOICE.TAXTYPE_ID + "@", "" + ConvertTO.SqlString(v.Taxtype_id) + "");
            q = q.Replace("@" + GARMENT_INVOICE.GARMENT_INVOICE_NO + "@", "" + ConvertTO.SqlString(v.Garment_invoice_no) + "");
            q = q.Replace("@" + GARMENT_INVOICE.GARMENT_INVOICE_DATE + "@", "" + ConvertTO.SqlDate(v.Garment_invoice_date) + "");
            q = q.Replace("@" + GARMENT_INVOICE.PARTY_ID + "@", "" + ConvertTO.SqlString(v.Party_id) + "");
            q = q.Replace("@" + GARMENT_INVOICE.TOTAL_QTY + "@", "" + ConvertTO.SqlDecimal(v.Total_qty) + "");
            q = q.Replace("@" + GARMENT_INVOICE.TOTAL_TAXABLE_AMOUNT + "@", "" + ConvertTO.SqlDecimal(v.Total_taxable_amount) + "");
            q = q.Replace("@" + GARMENT_INVOICE.TOTAL_CGST + "@", "" + ConvertTO.SqlDecimal(v.Total_cgst) + "");
            q = q.Replace("@" + GARMENT_INVOICE.TOTAL_SGST + "@", "" + ConvertTO.SqlDecimal(v.Total_sgst) + "");
            q = q.Replace("@" + GARMENT_INVOICE.TOTAL_IGST + "@", "" + ConvertTO.SqlDecimal(v.Total_igst) + "");
            q = q.Replace("@" + GARMENT_INVOICE.GSTTOTAL + "@", "" + ConvertTO.SqlDecimal(v.Gsttotal) + "");
            q = q.Replace("@" + GARMENT_INVOICE.LEDGER_ID + "@", "" + ConvertTO.SqlString(v.Ledger_id) + "");
            q = q.Replace("@" + GARMENT_INVOICE.ADDITIONAL + "@", "" + ConvertTO.SqlDecimal(v.Additional) + "");
            q = q.Replace("@" + GARMENT_INVOICE.ROUNDS + "@", "" + ConvertTO.SqlDecimal(v.Rounds) + "");
            q = q.Replace("@" + GARMENT_INVOICE.GRANDTOTAL + "@", "" + ConvertTO.SqlDecimal(v.Grandtotal) + "");
            q = q.Replace("@" + GARMENT_INVOICE.REFERED_AMT + "@", "" + ConvertTO.SqlDecimal(v.Refered_amt) + "");
            q = q.Replace("@" + GARMENT_INVOICE.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            q = q.Replace("@" + GARMENT_INVOICE.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + GARMENT_INVOICE.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + GARMENT_INVOICE.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Garment_invoice v, DAL dalsession)
        {
                string q = " INSERT INTO " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + " ( ";
                q += " " + GARMENT_INVOICE.UNIQUENO + "\r\n";
                q += "," + GARMENT_INVOICE.COMPANY_ID + "\r\n";
                q += "," + GARMENT_INVOICE.ACY_ID + "\r\n";
                q += "," + GARMENT_INVOICE.ORDER_ID + " \r\n";
                q += "," + GARMENT_INVOICE.SALESTYPE_ID + " \r\n";
                q += "," + GARMENT_INVOICE.TAXTYPE_ID + " \r\n";
                q += "," + GARMENT_INVOICE.GARMENT_INVOICE_NO + " \r\n";
                q += "," + GARMENT_INVOICE.GARMENT_INVOICE_DATE + " \r\n";
                q += "," + GARMENT_INVOICE.PARTY_ID + " \r\n";
                q += "," + GARMENT_INVOICE.TOTAL_QTY + " \r\n";
                q += "," + GARMENT_INVOICE.TOTAL_TAXABLE_AMOUNT + " \r\n";
                q += "," + GARMENT_INVOICE.TOTAL_CGST + " \r\n";
                q += "," + GARMENT_INVOICE.TOTAL_SGST + " \r\n";
                q += "," + GARMENT_INVOICE.TOTAL_IGST + " \r\n";
                q += "," + GARMENT_INVOICE.GSTTOTAL + " \r\n";
                q += "," + GARMENT_INVOICE.LEDGER_ID + " \r\n";
                q += "," + GARMENT_INVOICE.ADDITIONAL + " \r\n";
                q += "," + GARMENT_INVOICE.ROUNDS + " \r\n";
                q += "," + GARMENT_INVOICE.GRANDTOTAL + " \r\n";
                q += "," + GARMENT_INVOICE.REFERED_AMT + " \r\n";
                q += "," + GARMENT_INVOICE.LOCKED + " \r\n";
                q += "," + GARMENT_INVOICE.NOTES + " \r\n";
                q += "," + GARMENT_INVOICE.ACTIVE_ID + " \r\n";
                q += "," + GARMENT_INVOICE.USER_ID + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @" + GARMENT_INVOICE.UNIQUENO + "@ \r\n";
                q += ", @" + GARMENT_INVOICE.COMPANY_ID + "@ \r\n";
                q += ", @" + GARMENT_INVOICE.ACY_ID + "@ \r\n";
                q += ", @"+ GARMENT_INVOICE.ORDER_ID + "@ \r\n";
                q += ", @"+ GARMENT_INVOICE.SALESTYPE_ID + "@ \r\n";
                q += ", @"+ GARMENT_INVOICE.TAXTYPE_ID + "@ \r\n";
                q += ", @"+ GARMENT_INVOICE.GARMENT_INVOICE_NO + "@ \r\n";
                q += ", @"+ GARMENT_INVOICE.GARMENT_INVOICE_DATE + "@ \r\n";
                q += ", @"+ GARMENT_INVOICE.PARTY_ID + "@ \r\n";
                q += ", @"+ GARMENT_INVOICE.TOTAL_QTY + "@ \r\n";
                q += ", @"+ GARMENT_INVOICE.TOTAL_TAXABLE_AMOUNT + "@ \r\n";
                q += ", @"+ GARMENT_INVOICE.TOTAL_CGST + "@ \r\n";
                q += ", @"+ GARMENT_INVOICE.TOTAL_SGST + "@ \r\n";
                q += ", @"+ GARMENT_INVOICE.TOTAL_IGST + "@ \r\n";
                q += ", @"+ GARMENT_INVOICE.GSTTOTAL + "@ \r\n";
                q += ", @"+ GARMENT_INVOICE.LEDGER_ID + "@ \r\n";
                q += ", @"+ GARMENT_INVOICE.ADDITIONAL + "@ \r\n";
                q += ", @"+ GARMENT_INVOICE.ROUNDS + "@ \r\n";
                q += ", @"+ GARMENT_INVOICE.GRANDTOTAL + "@ \r\n";
                q += ", @"+ GARMENT_INVOICE.REFERED_AMT + "@ \r\n";
                q += ", @"+ GARMENT_INVOICE.LOCKED + "@ \r\n";
                q += ", @"+ GARMENT_INVOICE.NOTES + "@ \r\n";
                q += ", @"+ GARMENT_INVOICE.ACTIVE_ID + "@ \r\n";
                q += ", @"+ GARMENT_INVOICE.USER_ID + "@ \r\n";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Garment_invoice v, DAL dalsession)
        {
                string q = "UPDATE " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + " SET";
                q += " " + GARMENT_INVOICE.UNIQUENO + " = @" + GARMENT_INVOICE.UNIQUENO + "@ \r\n";
                q += "," + GARMENT_INVOICE.COMPANY_ID + " = @" + GARMENT_INVOICE.COMPANY_ID + "@ \r\n";
                q += "," + GARMENT_INVOICE.ACY_ID + " = @" + GARMENT_INVOICE.ACY_ID + "@ \r\n";
                q += "," + GARMENT_INVOICE.ORDER_ID + " = @" + GARMENT_INVOICE.ORDER_ID + "@ \r\n ";
                q += "," + GARMENT_INVOICE.SALESTYPE_ID + " = @" + GARMENT_INVOICE.SALESTYPE_ID + "@ \r\n ";
                q += "," + GARMENT_INVOICE.TAXTYPE_ID + " = @" + GARMENT_INVOICE.TAXTYPE_ID + "@ \r\n ";
                q += "," + GARMENT_INVOICE.GARMENT_INVOICE_NO + " = @" + GARMENT_INVOICE.GARMENT_INVOICE_NO + "@ \r\n ";
                q += "," + GARMENT_INVOICE.GARMENT_INVOICE_DATE + " = @" + GARMENT_INVOICE.GARMENT_INVOICE_DATE + "@ \r\n ";
                q += "," + GARMENT_INVOICE.PARTY_ID + " = @" + GARMENT_INVOICE.PARTY_ID + "@ \r\n ";
                q += "," + GARMENT_INVOICE.TOTAL_QTY + " = @" + GARMENT_INVOICE.TOTAL_QTY + "@ \r\n ";
                q += "," + GARMENT_INVOICE.TOTAL_TAXABLE_AMOUNT + " = @" + GARMENT_INVOICE.TOTAL_TAXABLE_AMOUNT + "@ \r\n ";
                q += "," + GARMENT_INVOICE.TOTAL_CGST + " = @" + GARMENT_INVOICE.TOTAL_CGST + "@ \r\n ";
                q += "," + GARMENT_INVOICE.TOTAL_SGST + " = @" + GARMENT_INVOICE.TOTAL_SGST + "@ \r\n ";
                q += "," + GARMENT_INVOICE.TOTAL_IGST + " = @" + GARMENT_INVOICE.TOTAL_IGST + "@ \r\n ";
                q += "," + GARMENT_INVOICE.GSTTOTAL + " = @" + GARMENT_INVOICE.GSTTOTAL + "@ \r\n ";
                q += "," + GARMENT_INVOICE.LEDGER_ID + " = @" + GARMENT_INVOICE.LEDGER_ID + "@ \r\n ";
                q += "," + GARMENT_INVOICE.ADDITIONAL + " = @" + GARMENT_INVOICE.ADDITIONAL + "@ \r\n ";
                q += "," + GARMENT_INVOICE.ROUNDS + " = @" + GARMENT_INVOICE.ROUNDS + "@ \r\n ";
                q += "," + GARMENT_INVOICE.GRANDTOTAL + " = @" + GARMENT_INVOICE.GRANDTOTAL + "@ \r\n ";
                q += "," + GARMENT_INVOICE.REFERED_AMT + " = @" + GARMENT_INVOICE.REFERED_AMT + "@ \r\n ";
                q += "," + GARMENT_INVOICE.LOCKED + " = @" + GARMENT_INVOICE.LOCKED + "@ \r\n ";
                q += "," + GARMENT_INVOICE.NOTES + " = @" + GARMENT_INVOICE.NOTES + "@ \r\n ";
                q += "," + GARMENT_INVOICE.ACTIVE_ID + " = @" + GARMENT_INVOICE.ACTIVE_ID + "@ \r\n ";
                q += "," + GARMENT_INVOICE.USER_ID + " = @" + GARMENT_INVOICE.USER_ID + "@ \r\n ";
                q += "  WHERE " + GARMENT_INVOICE.GARMENT_INVOICE_ID + " = @" + GARMENT_INVOICE.GARMENT_INVOICE_ID + "@ ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + GARMENT_INVOICE.GARMENT_INVOICE_TBL+ " WHERE " + GARMENT_INVOICE.GARMENT_INVOICE_ID + " =  " + pkid +";");
        }
        #endregion[Delete]

    }//cls
}//ns
