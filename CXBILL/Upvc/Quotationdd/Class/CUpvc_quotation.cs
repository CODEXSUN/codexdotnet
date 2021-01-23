// Version : 3 dt : 01-08-2017
// Auto Generated
// 24-08-2017 08:41:49 PM
// last update : 24-08-2017

using CXLIB;

namespace CXUPVC
{
    public class CUpvc_quotation 
    {
        #region[Attach params]
        
        private static string AttachParams(string q, Upvc_quotation v)
        {
            q = q.Replace("@" + UPVC_QUOTATION.UPVC_QUOTATION_ID + "@", "" + ConvertTO.SqlString(v.Upvc_quotation_id) + "");
            q = q.Replace("@" + UPVC_QUOTATION.YEAR_NO + "@", "" + ConvertTO.SqlString(v.Uniqueno) + "");
            q = q.Replace("@" + UPVC_QUOTATION.COMPANY_ID + "@", "" + ConvertTO.SqlString(v.Company_id) + "");
            q = q.Replace("@" + UPVC_QUOTATION.SALESTYPE + "@", "" + ConvertTO.SqlString(v.Salestype) + "");
            q = q.Replace("@" + UPVC_QUOTATION.UPVC_SALESMODE_ID + "@", "" + ConvertTO.SqlString(v.Upvc_salesmode_id) + "");
            q = q.Replace("@" + UPVC_QUOTATION.UPVC_QUOTATION_NO + "@", "" + ConvertTO.SqlString(v.Upvc_quotation_no) + "");
            q = q.Replace("@" + UPVC_QUOTATION.UPVC_QUOTATION_DATE + "@", "" + ConvertTO.SqlDate(v.Upvc_quotation_date) + "");
            q = q.Replace("@" + UPVC_QUOTATION.PARTY_ID + "@", "" + ConvertTO.SqlString(v.Party_id) + "");
            q = q.Replace("@" + UPVC_QUOTATION.SHIPPING_ID + "@", "" + ConvertTO.SqlString(v.Shipping_id) + "");
            //q = q.Replace("@" + UPVC_QUOTATION.TRANSPORT_ID + "@", "" + ConvertTO.SqlString(v.Transport_mode_id) + "");
            //q = q.Replace("@" + UPVC_QUOTATION.VEHICLE_NO + "@", "" + ConvertTO.SqlString(v.Vehicle_no) + "");
            q = q.Replace("@" + UPVC_QUOTATION.TOTAL_QTY + "@", "" + ConvertTO.SqlString(v.Total_qty) + "");
            q = q.Replace("@" + UPVC_QUOTATION.TOTAL_AREASQ + "@", "" + ConvertTO.SqlString(v.Total_areasq) + "");
            q = q.Replace("@" + UPVC_QUOTATION.TOTAL_TAXABLE_AMOUNT + "@", "" + ConvertTO.SqlString(v.Total_taxable_amount) + "");
            q = q.Replace("@" + UPVC_QUOTATION.TOTAL_CGST + "@", "" + ConvertTO.SqlString(v.Total_cgst) + "");
            q = q.Replace("@" + UPVC_QUOTATION.TOTAL_SGST + "@", "" + ConvertTO.SqlString(v.Total_sgst) + "");
            q = q.Replace("@" + UPVC_QUOTATION.TOTAL_IGST + "@", "" + ConvertTO.SqlString(v.Total_igst) + "");
            q = q.Replace("@" + UPVC_QUOTATION.GSTTOTAL + "@", "" + ConvertTO.SqlString(v.Gsttotal) + "");
            q = q.Replace("@" + UPVC_QUOTATION.LEDGER_ID + "@", "" + ConvertTO.SqlString(v.Ledger_id) + "");
            q = q.Replace("@" + UPVC_QUOTATION.ADDITIONAL + "@", "" + ConvertTO.SqlString(v.Additional) + "");
            q = q.Replace("@" + UPVC_QUOTATION.ROUNDS + "@", "" + ConvertTO.SqlString(v.Rounds) + "");
            q = q.Replace("@" + UPVC_QUOTATION.GRANDTOTAL + "@", "" + ConvertTO.SqlString(v.Grandtotal) + "");
            q = q.Replace("@" + UPVC_QUOTATION.REFERED_NO + "@", "" + ConvertTO.SqlString(v.Refered_no) + "");
            q = q.Replace("@" + UPVC_QUOTATION.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            q = q.Replace("@" + UPVC_QUOTATION.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + UPVC_QUOTATION.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + UPVC_QUOTATION.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]
        
        #region[Insert]
        
        public static void Insert(Upvc_quotation v, DAL dalsession)
        {
                string q = " INSERT INTO " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + " ( ";
                q += " " + UPVC_QUOTATION.YEAR_NO + " \r\n ";
                q += "," + UPVC_QUOTATION.COMPANY_ID + " \r\n ";
                q += "," + UPVC_QUOTATION.SALESTYPE + " \r\n ";
                q += "," + UPVC_QUOTATION.UPVC_SALESMODE_ID + " \r\n ";
                q += "," + UPVC_QUOTATION.UPVC_QUOTATION_NO + " \r\n ";
                q += "," + UPVC_QUOTATION.UPVC_QUOTATION_DATE + " \r\n ";
                q += "," + UPVC_QUOTATION.PARTY_ID + " \r\n ";
                q += "," + UPVC_QUOTATION.SHIPPING_ID + " \r\n ";
                //q += "," + UPVC_QUOTATION.TRANSPORT_ID + " \r\n ";
                //q += "," + UPVC_QUOTATION.VEHICLE_NO + " \r\n ";
                q += "," + UPVC_QUOTATION.TOTAL_QTY + " \r\n ";
                q += "," + UPVC_QUOTATION.TOTAL_AREASQ + " \r\n ";
                q += "," + UPVC_QUOTATION.TOTAL_TAXABLE_AMOUNT + " \r\n ";
                q += "," + UPVC_QUOTATION.TOTAL_CGST + " \r\n ";
                q += "," + UPVC_QUOTATION.TOTAL_SGST + " \r\n ";
                q += "," + UPVC_QUOTATION.TOTAL_IGST + " \r\n ";
                q += "," + UPVC_QUOTATION.GSTTOTAL + " \r\n ";
                q += "," + UPVC_QUOTATION.LEDGER_ID + " \r\n ";
                q += "," + UPVC_QUOTATION.ADDITIONAL + " \r\n ";
                q += "," + UPVC_QUOTATION.ROUNDS + " \r\n ";
                q += "," + UPVC_QUOTATION.GRANDTOTAL + " \r\n ";
                q += "," + UPVC_QUOTATION.REFERED_NO + " \r\n ";
                q += "," + UPVC_QUOTATION.LOCKED + " \r\n ";
                q += "," + UPVC_QUOTATION.NOTES + " \r\n ";
                q += "," + UPVC_QUOTATION.ACTIVE_ID + " \r\n ";
                q += "," + UPVC_QUOTATION.USER_ID + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @"+ UPVC_QUOTATION.YEAR_NO + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATION.COMPANY_ID + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATION.SALESTYPE + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATION.UPVC_SALESMODE_ID + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATION.UPVC_QUOTATION_NO + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATION.UPVC_QUOTATION_DATE + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATION.PARTY_ID + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATION.SHIPPING_ID + "@ \r\n ";
                //q += ", @"+ UPVC_QUOTATION.TRANSPORT_ID + "@ \r\n ";
                //q += ", @"+ UPVC_QUOTATION.VEHICLE_NO + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATION.TOTAL_QTY + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATION.TOTAL_AREASQ + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATION.TOTAL_TAXABLE_AMOUNT + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATION.TOTAL_CGST + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATION.TOTAL_SGST + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATION.TOTAL_IGST + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATION.GSTTOTAL + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATION.LEDGER_ID + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATION.ADDITIONAL + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATION.ROUNDS + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATION.GRANDTOTAL + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATION.REFERED_NO + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATION.LOCKED + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATION.NOTES + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATION.ACTIVE_ID + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATION.USER_ID + "@ \r\n ";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]
        
        #region[Update]
        
        public static void Update(Upvc_quotation v, DAL dalsession)
        {
                string q = "UPDATE " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + " SET";
                q += " " + UPVC_QUOTATION.YEAR_NO + " = @" + UPVC_QUOTATION.YEAR_NO + "@ \r\n ";
                q += "," + UPVC_QUOTATION.COMPANY_ID + " = @" + UPVC_QUOTATION.COMPANY_ID + "@ \r\n ";
                q += "," + UPVC_QUOTATION.SALESTYPE + " = @" + UPVC_QUOTATION.SALESTYPE + "@ \r\n ";
                q += "," + UPVC_QUOTATION.UPVC_SALESMODE_ID + " = @" + UPVC_QUOTATION.UPVC_SALESMODE_ID + "@ \r\n ";
                q += "," + UPVC_QUOTATION.UPVC_QUOTATION_NO + " = @" + UPVC_QUOTATION.UPVC_QUOTATION_NO + "@ \r\n ";
                q += "," + UPVC_QUOTATION.UPVC_QUOTATION_DATE + " = @" + UPVC_QUOTATION.UPVC_QUOTATION_DATE + "@ \r\n ";
                q += "," + UPVC_QUOTATION.PARTY_ID + " = @" + UPVC_QUOTATION.PARTY_ID + "@ \r\n ";
                q += "," + UPVC_QUOTATION.SHIPPING_ID + " = @" + UPVC_QUOTATION.SHIPPING_ID + "@ \r\n ";
                //q += "," + UPVC_QUOTATION.TRANSPORT_ID + " = @" + UPVC_QUOTATION.TRANSPORT_ID + "@ \r\n ";
                //q += "," + UPVC_QUOTATION.VEHICLE_NO + " = @" + UPVC_QUOTATION.VEHICLE_NO + "@ \r\n ";
                q += "," + UPVC_QUOTATION.TOTAL_QTY + " = @" + UPVC_QUOTATION.TOTAL_QTY + "@ \r\n ";
                q += "," + UPVC_QUOTATION.TOTAL_AREASQ + " = @" + UPVC_QUOTATION.TOTAL_AREASQ + "@ \r\n ";
                q += "," + UPVC_QUOTATION.TOTAL_TAXABLE_AMOUNT + " = @" + UPVC_QUOTATION.TOTAL_TAXABLE_AMOUNT + "@ \r\n ";
                q += "," + UPVC_QUOTATION.TOTAL_CGST + " = @" + UPVC_QUOTATION.TOTAL_CGST + "@ \r\n ";
                q += "," + UPVC_QUOTATION.TOTAL_SGST + " = @" + UPVC_QUOTATION.TOTAL_SGST + "@ \r\n ";
                q += "," + UPVC_QUOTATION.TOTAL_IGST + " = @" + UPVC_QUOTATION.TOTAL_IGST + "@ \r\n ";
                q += "," + UPVC_QUOTATION.GSTTOTAL + " = @" + UPVC_QUOTATION.GSTTOTAL + "@ \r\n ";
                q += "," + UPVC_QUOTATION.LEDGER_ID + " = @" + UPVC_QUOTATION.LEDGER_ID + "@ \r\n ";
                q += "," + UPVC_QUOTATION.ADDITIONAL + " = @" + UPVC_QUOTATION.ADDITIONAL + "@ \r\n ";
                q += "," + UPVC_QUOTATION.ROUNDS + " = @" + UPVC_QUOTATION.ROUNDS + "@ \r\n ";
                q += "," + UPVC_QUOTATION.GRANDTOTAL + " = @" + UPVC_QUOTATION.GRANDTOTAL + "@ \r\n ";
                q += "," + UPVC_QUOTATION.REFERED_NO + " = @" + UPVC_QUOTATION.REFERED_NO + "@ \r\n ";
                q += "," + UPVC_QUOTATION.LOCKED + " = @" + UPVC_QUOTATION.LOCKED + "@ \r\n ";
                q += "," + UPVC_QUOTATION.NOTES + " = @" + UPVC_QUOTATION.NOTES + "@ \r\n ";
                q += "," + UPVC_QUOTATION.ACTIVE_ID + " = @" + UPVC_QUOTATION.ACTIVE_ID + "@ \r\n ";
                q += "," + UPVC_QUOTATION.USER_ID + " = @" + UPVC_QUOTATION.USER_ID + "@ \r\n ";
                q += "  WHERE " + UPVC_QUOTATION.UPVC_QUOTATION_ID + " = @" + UPVC_QUOTATION.UPVC_QUOTATION_ID + "@ ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Update]
        
        #region[Delete]
        
        public static void Delete(string pkid , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + UPVC_QUOTATION.UPVC_QUOTATION_TBL+ " WHERE " + UPVC_QUOTATION.UPVC_QUOTATION_ID + " =  " + pkid +";");
        }
        #endregion[Delete]
        
    }//cls
}//ns
