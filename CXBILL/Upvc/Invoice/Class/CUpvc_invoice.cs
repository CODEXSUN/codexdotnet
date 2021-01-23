// Version : 3 dt : 01-08-2017
// Auto Generated
// 24-08-2017 08:41:49 PM
// last update : 24-08-2017

using CXLIB;

namespace CXBILL
{
    public class CUpvc_invoice
    {

        public static Upvc_invoice GetNew()
        {
            Upvc_invoice obj = new Upvc_invoice
            {
                Upvc_invoice_id = string.Empty,
                Uniqueno = string.Empty,
                Company_id = Current.Company_id,
                Acy_id = Current.Acy_id,
                Taxtype_id = Core.SGST,
                Salestype_id = Core.B2B,
                Invoice_no = CUpvc_invoice_exten.GetNext_No,
                Invoice_date = string.Empty,
                Party_id = string.Empty,
                Delivered_id = string.Empty,
                Transport_id = Core.ByRoad,
                Vehicle_no = string.Empty,
                Total_qty = 0,
                Total_areasq = 0,
                Total_taxable_amount = 0,
                Total_cgst = 0,
                Total_sgst = 0,
                Total_igst = 0,
                Gsttotal = 0,
                Ledger_id = string.Empty,
                Additional = 0,
                Rounds = 0,
                Grandtotal = 0,
                Refered_no = 0,
                Locked = string.Empty,
                Notes = string.Empty,
                Active_id = Core.Active,
                User_id = Current.User
            };
            return obj;
        }

        #region[Attach params]

        private static string AttachParams(string q, Upvc_invoice v)
        {
            q = q.Replace("@" + UPVC_INVOICE.UPVC_INVOICE_ID + "@", "" + ConvertTO.SqlString(v.Upvc_invoice_id) + "");
            q = q.Replace("@" + UPVC_INVOICE.UNIQUENO + "@", "" + ConvertTO.SqlString(v.Uniqueno) + "");
            q = q.Replace("@" + UPVC_INVOICE.COMPANY_ID + "@", "" + ConvertTO.SqlString(v.Company_id) + "");
            q = q.Replace("@" + UPVC_INVOICE.ACY_ID + "@", "" + ConvertTO.SqlString(v.Acy_id) + "");
            q = q.Replace("@" + UPVC_INVOICE.TAXTYPE_ID + "@", "" + ConvertTO.SqlString(v.Taxtype_id) + "");
            q = q.Replace("@" + UPVC_INVOICE.SALESTYPE_ID + "@", "" + ConvertTO.SqlString(v.Salestype_id) + "");
            q = q.Replace("@" + UPVC_INVOICE.INVOICE_NO + "@", "" + ConvertTO.SqlString(v.Invoice_no) + "");
            q = q.Replace("@" + UPVC_INVOICE.INVOICE_DATE + "@", "" + ConvertTO.SqlDate(v.Invoice_date) + "");
            q = q.Replace("@" + UPVC_INVOICE.PARTY_ID + "@", "" + ConvertTO.SqlString(v.Party_id) + "");
            q = q.Replace("@" + UPVC_INVOICE.DELIVEREDTO_ID + "@", "" + ConvertTO.SqlString(v.Delivered_id) + "");
            q = q.Replace("@" + UPVC_INVOICE.TRANSPORT_ID + "@", "" + ConvertTO.SqlString(v.Transport_id) + "");
            q = q.Replace("@" + UPVC_INVOICE.VEHICLE_NO + "@", "" + ConvertTO.SqlString(v.Vehicle_no) + "");
            q = q.Replace("@" + UPVC_INVOICE.TOTAL_QTY + "@", "" + ConvertTO.SqlString(v.Total_qty + ""));
            q = q.Replace("@" + UPVC_INVOICE.TOTAL_AREASQ + "@", "" + ConvertTO.SqlString(v.Total_areasq + ""));
            q = q.Replace("@" + UPVC_INVOICE.TOTAL_TAXABLE_AMOUNT + "@", "" + ConvertTO.SqlString(v.Total_taxable_amount + ""));
            q = q.Replace("@" + UPVC_INVOICE.TOTAL_CGST + "@", "" + ConvertTO.SqlString(v.Total_cgst + ""));
            q = q.Replace("@" + UPVC_INVOICE.TOTAL_SGST + "@", "" + ConvertTO.SqlString(v.Total_sgst + ""));
            q = q.Replace("@" + UPVC_INVOICE.TOTAL_IGST + "@", "" + ConvertTO.SqlString(v.Total_igst + ""));
            q = q.Replace("@" + UPVC_INVOICE.GSTTOTAL + "@", "" + ConvertTO.SqlString(v.Gsttotal + ""));
            q = q.Replace("@" + UPVC_INVOICE.LEDGER_ID + "@", "" + ConvertTO.SqlString(v.Ledger_id) + "");
            q = q.Replace("@" + UPVC_INVOICE.ADDITIONAL + "@", "" + ConvertTO.SqlString(v.Additional + ""));
            q = q.Replace("@" + UPVC_INVOICE.ROUNDS + "@", "" + ConvertTO.SqlString(v.Rounds + ""));
            q = q.Replace("@" + UPVC_INVOICE.GRANDTOTAL + "@", "" + ConvertTO.SqlString(v.Grandtotal + ""));
            q = q.Replace("@" + UPVC_INVOICE.REFERED_NO + "@", "" + ConvertTO.SqlString(v.Refered_no + ""));
            q = q.Replace("@" + UPVC_INVOICE.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            q = q.Replace("@" + UPVC_INVOICE.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + UPVC_INVOICE.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + UPVC_INVOICE.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Upvc_invoice v, DAL dalsession)
        {
            string q = " INSERT INTO " + UPVC_INVOICE.UPVC_INVOICE_TBL + " ( ";
            q += " " + UPVC_INVOICE.UNIQUENO + " \r\n ";
            q += "," + UPVC_INVOICE.COMPANY_ID + " \r\n ";
            q += "," + UPVC_INVOICE.ACY_ID + "\r\n";
            q += "," + UPVC_INVOICE.TAXTYPE_ID + " \r\n ";
            q += "," + UPVC_INVOICE.SALESTYPE_ID + " \r\n ";
            q += "," + UPVC_INVOICE.INVOICE_NO + " \r\n ";
            q += "," + UPVC_INVOICE.INVOICE_DATE + " \r\n ";
            q += "," + UPVC_INVOICE.PARTY_ID + " \r\n ";
            q += "," + UPVC_INVOICE.DELIVEREDTO_ID + " \r\n ";
            q += "," + UPVC_INVOICE.TRANSPORT_ID + " \r\n ";
            q += "," + UPVC_INVOICE.VEHICLE_NO + " \r\n ";
            q += "," + UPVC_INVOICE.TOTAL_QTY + " \r\n ";
            q += "," + UPVC_INVOICE.TOTAL_AREASQ + " \r\n ";
            q += "," + UPVC_INVOICE.TOTAL_TAXABLE_AMOUNT + " \r\n ";
            q += "," + UPVC_INVOICE.TOTAL_CGST + " \r\n ";
            q += "," + UPVC_INVOICE.TOTAL_SGST + " \r\n ";
            q += "," + UPVC_INVOICE.TOTAL_IGST + " \r\n ";
            q += "," + UPVC_INVOICE.GSTTOTAL + " \r\n ";
            q += "," + UPVC_INVOICE.LEDGER_ID + " \r\n ";
            q += "," + UPVC_INVOICE.ADDITIONAL + " \r\n ";
            q += "," + UPVC_INVOICE.ROUNDS + " \r\n ";
            q += "," + UPVC_INVOICE.GRANDTOTAL + " \r\n ";
            q += "," + UPVC_INVOICE.REFERED_NO + " \r\n ";
            q += "," + UPVC_INVOICE.LOCKED + " \r\n ";
            q += "," + UPVC_INVOICE.NOTES + " \r\n ";
            q += "," + UPVC_INVOICE.ACTIVE_ID + " \r\n ";
            q += "," + UPVC_INVOICE.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + UPVC_INVOICE.UNIQUENO + "@ \r\n ";
            q += ", @" + UPVC_INVOICE.COMPANY_ID + "@ \r\n ";
            q += ", @" + UPVC_INVOICE.COMPANY_ID + "@ \r\n";
            q += ", @" + UPVC_INVOICE.TAXTYPE_ID + "@ \r\n ";
            q += ", @" + UPVC_INVOICE.SALESTYPE_ID + "@ \r\n ";
            q += ", @" + UPVC_INVOICE.INVOICE_NO + "@ \r\n ";
            q += ", @" + UPVC_INVOICE.INVOICE_DATE + "@ \r\n ";
            q += ", @" + UPVC_INVOICE.PARTY_ID + "@ \r\n ";
            q += ", @" + UPVC_INVOICE.DELIVEREDTO_ID + "@ \r\n ";
            q += ", @" + UPVC_INVOICE.TRANSPORT_ID + "@ \r\n ";
            q += ", @" + UPVC_INVOICE.VEHICLE_NO + "@ \r\n ";
            q += ", @" + UPVC_INVOICE.TOTAL_QTY + "@ \r\n ";
            q += ", @" + UPVC_INVOICE.TOTAL_AREASQ + "@ \r\n ";
            q += ", @" + UPVC_INVOICE.TOTAL_TAXABLE_AMOUNT + "@ \r\n ";
            q += ", @" + UPVC_INVOICE.TOTAL_CGST + "@ \r\n ";
            q += ", @" + UPVC_INVOICE.TOTAL_SGST + "@ \r\n ";
            q += ", @" + UPVC_INVOICE.TOTAL_IGST + "@ \r\n ";
            q += ", @" + UPVC_INVOICE.GSTTOTAL + "@ \r\n ";
            q += ", @" + UPVC_INVOICE.LEDGER_ID + "@ \r\n ";
            q += ", @" + UPVC_INVOICE.ADDITIONAL + "@ \r\n ";
            q += ", @" + UPVC_INVOICE.ROUNDS + "@ \r\n ";
            q += ", @" + UPVC_INVOICE.GRANDTOTAL + "@ \r\n ";
            q += ", @" + UPVC_INVOICE.REFERED_NO + "@ \r\n ";
            q += ", @" + UPVC_INVOICE.LOCKED + "@ \r\n ";
            q += ", @" + UPVC_INVOICE.NOTES + "@ \r\n ";
            q += ", @" + UPVC_INVOICE.ACTIVE_ID + "@ \r\n ";
            q += ", @" + UPVC_INVOICE.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Upvc_invoice v, DAL dalsession)
        {
            string q = "UPDATE " + UPVC_INVOICE.UPVC_INVOICE_TBL + " SET";
            q += " " + UPVC_INVOICE.UNIQUENO + " = @" + UPVC_INVOICE.UNIQUENO + "@ \r\n ";
            q += "," + UPVC_INVOICE.COMPANY_ID + " = @" + UPVC_INVOICE.COMPANY_ID + "@ \r\n ";
            q += "," + UPVC_INVOICE.ACY_ID + " = @" + UPVC_INVOICE.ACY_ID + "@ \r\n";
            q += "," + UPVC_INVOICE.TAXTYPE_ID + " = @" + UPVC_INVOICE.TAXTYPE_ID + "@ \r\n ";
            q += "," + UPVC_INVOICE.SALESTYPE_ID + " = @" + UPVC_INVOICE.SALESTYPE_ID + "@ \r\n ";
            q += "," + UPVC_INVOICE.INVOICE_NO + " = @" + UPVC_INVOICE.INVOICE_NO + "@ \r\n ";
            q += "," + UPVC_INVOICE.INVOICE_DATE + " = @" + UPVC_INVOICE.INVOICE_DATE + "@ \r\n ";
            q += "," + UPVC_INVOICE.PARTY_ID + " = @" + UPVC_INVOICE.PARTY_ID + "@ \r\n ";
            q += "," + UPVC_INVOICE.DELIVEREDTO_ID + " = @" + UPVC_INVOICE.DELIVEREDTO_ID + "@ \r\n ";
            q += "," + UPVC_INVOICE.TRANSPORT_ID + " = @" + UPVC_INVOICE.TRANSPORT_ID + "@ \r\n ";
            q += "," + UPVC_INVOICE.VEHICLE_NO + " = @" + UPVC_INVOICE.VEHICLE_NO + "@ \r\n ";
            q += "," + UPVC_INVOICE.TOTAL_QTY + " = @" + UPVC_INVOICE.TOTAL_QTY + "@ \r\n ";
            q += "," + UPVC_INVOICE.TOTAL_AREASQ + " = @" + UPVC_INVOICE.TOTAL_AREASQ + "@ \r\n ";
            q += "," + UPVC_INVOICE.TOTAL_TAXABLE_AMOUNT + " = @" + UPVC_INVOICE.TOTAL_TAXABLE_AMOUNT + "@ \r\n ";
            q += "," + UPVC_INVOICE.TOTAL_CGST + " = @" + UPVC_INVOICE.TOTAL_CGST + "@ \r\n ";
            q += "," + UPVC_INVOICE.TOTAL_SGST + " = @" + UPVC_INVOICE.TOTAL_SGST + "@ \r\n ";
            q += "," + UPVC_INVOICE.TOTAL_IGST + " = @" + UPVC_INVOICE.TOTAL_IGST + "@ \r\n ";
            q += "," + UPVC_INVOICE.GSTTOTAL + " = @" + UPVC_INVOICE.GSTTOTAL + "@ \r\n ";
            q += "," + UPVC_INVOICE.LEDGER_ID + " = @" + UPVC_INVOICE.LEDGER_ID + "@ \r\n ";
            q += "," + UPVC_INVOICE.ADDITIONAL + " = @" + UPVC_INVOICE.ADDITIONAL + "@ \r\n ";
            q += "," + UPVC_INVOICE.ROUNDS + " = @" + UPVC_INVOICE.ROUNDS + "@ \r\n ";
            q += "," + UPVC_INVOICE.GRANDTOTAL + " = @" + UPVC_INVOICE.GRANDTOTAL + "@ \r\n ";
            q += "," + UPVC_INVOICE.REFERED_NO + " = @" + UPVC_INVOICE.REFERED_NO + "@ \r\n ";
            q += "," + UPVC_INVOICE.LOCKED + " = @" + UPVC_INVOICE.LOCKED + "@ \r\n ";
            q += "," + UPVC_INVOICE.NOTES + " = @" + UPVC_INVOICE.NOTES + "@ \r\n ";
            q += "," + UPVC_INVOICE.ACTIVE_ID + " = @" + UPVC_INVOICE.ACTIVE_ID + "@ \r\n ";
            q += "," + UPVC_INVOICE.USER_ID + " = @" + UPVC_INVOICE.USER_ID + "@ \r\n ";
            q += "  WHERE " + UPVC_INVOICE.UPVC_INVOICE_ID + " = @" + UPVC_INVOICE.UPVC_INVOICE_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + UPVC_INVOICE.UPVC_INVOICE_TBL + " WHERE " + UPVC_INVOICE.UPVC_INVOICE_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
