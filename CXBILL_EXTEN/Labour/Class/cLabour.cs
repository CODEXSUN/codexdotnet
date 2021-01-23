// Version : 2.0.0.0 dt : 16-10-2018
// Auto Generated
// last update : 22-10-2018 09:00:08 AM

using CXBILL_EXTEN.Labour.Const;
using CXLIB;

namespace CXBILL_EXTEN.Labour.Class
{
    public class CLabour
    {

        #region[Get New]

        public static Const.Labour GetNew
        {
            get
            {
                Const.Labour obj = new Const.Labour()
                {
                    Labour_id = string.Empty,
                    Uniqueno = string.Empty,
                    Company_id = Current.Company_id,
                    Acy_id = Current.Acy_id,
                    Order_id = string.Empty,
                    Labour_no = CLabour_exten.GetNext_No.ToString(),
                    Labour_date = string.Empty,
                    Taxtype_id = Core.SGST,
                    Salestype_id = Core.LABOUR_BILL,
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

        private static string AttachParams(string q, Const.Labour v)
        {
            q = q.Replace("@" + LABOUR.LABOUR_ID + "@", "" + ConvertTO.SqlString(v.Labour_id) + "");
            q = q.Replace("@" + LABOUR.UNIQUENO + "@", "" + ConvertTO.SqlString(v.Uniqueno) + "");
            q = q.Replace("@" + LABOUR.COMPANY_ID + "@", "" + ConvertTO.SqlString(v.Company_id) + "");
            q = q.Replace("@" + LABOUR.ACY_ID + "@", "" + ConvertTO.SqlString(v.Acy_id) + "");
            q = q.Replace("@" + LABOUR.ORDER_ID + "@", "" + ConvertTO.SqlString(v.Order_id) + "");
            q = q.Replace("@" + LABOUR.LABOUR_NO + "@", "" + ConvertTO.SqlString(v.Labour_no) + "");
            q = q.Replace("@" + LABOUR.LABOUR_DATE + "@", "" + ConvertTO.SqlDate(v.Labour_date) + "");
            q = q.Replace("@" + LABOUR.TAXTYPE_ID + "@", "" + ConvertTO.SqlString(v.Taxtype_id) + "");
            q = q.Replace("@" + LABOUR.SALESTYPE_ID + "@", "" + ConvertTO.SqlString(v.Salestype_id) + "");
            q = q.Replace("@" + LABOUR.PARTY_ID + "@", "" + ConvertTO.SqlString(v.Party_id) + "");
            q = q.Replace("@" + LABOUR.TRANSPORT_ID + "@", "" + ConvertTO.SqlString(v.Transport_id) + "");
            q = q.Replace("@" + LABOUR.DELIVEREDTO_ID + "@", "" + ConvertTO.SqlString(v.Deliveredto_id) + "");
            q = q.Replace("@" + LABOUR.BUNDEL + "@", "" + ConvertTO.SqlString(v.Bundel) + "");
            q = q.Replace("@" + LABOUR.TOTAL_QTY + "@", "" + ConvertTO.SqlString(v.Total_qty) + "");
            q = q.Replace("@" + LABOUR.TOTAL_TAXABLE_AMOUNT + "@", "" + ConvertTO.SqlDecimal(v.Total_taxable_amount) + "");
            q = q.Replace("@" + LABOUR.TOTAL_CGST + "@", "" + ConvertTO.SqlDecimal(v.Total_cgst) + "");
            q = q.Replace("@" + LABOUR.TOTAL_SGST + "@", "" + ConvertTO.SqlDecimal(v.Total_sgst) + "");
            q = q.Replace("@" + LABOUR.TOTAL_IGST + "@", "" + ConvertTO.SqlDecimal(v.Total_igst) + "");
            q = q.Replace("@" + LABOUR.GSTTOTAL + "@", "" + ConvertTO.SqlDecimal(v.Gsttotal) + "");
            q = q.Replace("@" + LABOUR.LEDGER_ID + "@", "" + ConvertTO.SqlString(v.Ledger_id) + "");
            q = q.Replace("@" + LABOUR.ADDITIONAL + "@", "" + ConvertTO.SqlDecimal(v.Additional) + "");
            q = q.Replace("@" + LABOUR.ROUNDS + "@", "" + ConvertTO.SqlDecimal(v.Rounds) + "");
            q = q.Replace("@" + LABOUR.GRANDTOTAL + "@", "" + ConvertTO.SqlDecimal(v.Grandtotal) + "");
            q = q.Replace("@" + LABOUR.REFERED_AMT + "@", "" + ConvertTO.SqlDecimal(v.Refered_amt) + "");
            q = q.Replace("@" + LABOUR.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            q = q.Replace("@" + LABOUR.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + LABOUR.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + LABOUR.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Const.Labour v, DAL dalsession)
        {
            string q = " INSERT INTO " + LABOUR.LABOUR_TBL + " ( ";
            q += " " + LABOUR.UNIQUENO + " \r\n ";
            q += "," + LABOUR.COMPANY_ID + " \r\n ";
            q += "," + LABOUR.ACY_ID + " \r\n ";
            q += "," + LABOUR.ORDER_ID + " \r\n ";
            q += "," + LABOUR.LABOUR_NO + " \r\n ";
            q += "," + LABOUR.LABOUR_DATE + " \r\n ";
            q += "," + LABOUR.TAXTYPE_ID + " \r\n ";
            q += "," + LABOUR.SALESTYPE_ID + " \r\n ";
            q += "," + LABOUR.PARTY_ID + " \r\n ";
            q += "," + LABOUR.TRANSPORT_ID + " \r\n ";
            q += "," + LABOUR.DELIVEREDTO_ID + " \r\n ";
            q += "," + LABOUR.BUNDEL + " \r\n ";
            q += "," + LABOUR.TOTAL_QTY + " \r\n ";
            q += "," + LABOUR.TOTAL_TAXABLE_AMOUNT + " \r\n ";
            q += "," + LABOUR.TOTAL_CGST + " \r\n ";
            q += "," + LABOUR.TOTAL_SGST + " \r\n ";
            q += "," + LABOUR.TOTAL_IGST + " \r\n ";
            q += "," + LABOUR.GSTTOTAL + " \r\n ";
            q += "," + LABOUR.LEDGER_ID + " \r\n ";
            q += "," + LABOUR.ADDITIONAL + " \r\n ";
            q += "," + LABOUR.ROUNDS + " \r\n ";
            q += "," + LABOUR.GRANDTOTAL + " \r\n ";
            q += "," + LABOUR.REFERED_AMT + " \r\n ";
            q += "," + LABOUR.LOCKED + " \r\n ";
            q += "," + LABOUR.NOTES + " \r\n ";
            q += "," + LABOUR.ACTIVE_ID + " \r\n ";
            q += "," + LABOUR.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + LABOUR.UNIQUENO + "@ \r\n ";
            q += ", @" + LABOUR.COMPANY_ID + "@ \r\n ";
            q += ", @" + LABOUR.ACY_ID + "@ \r\n ";
            q += ", @" + LABOUR.ORDER_ID + "@ \r\n ";
            q += ", @" + LABOUR.LABOUR_NO + "@ \r\n ";
            q += ", @" + LABOUR.LABOUR_DATE + "@ \r\n ";
            q += ", @" + LABOUR.TAXTYPE_ID + "@ \r\n ";
            q += ", @" + LABOUR.SALESTYPE_ID + "@ \r\n ";
            q += ", @" + LABOUR.PARTY_ID + "@ \r\n ";
            q += ", @" + LABOUR.TRANSPORT_ID + "@ \r\n ";
            q += ", @" + LABOUR.DELIVEREDTO_ID + "@ \r\n ";
            q += ", @" + LABOUR.BUNDEL + "@ \r\n ";
            q += ", @" + LABOUR.TOTAL_QTY + "@ \r\n ";
            q += ", @" + LABOUR.TOTAL_TAXABLE_AMOUNT + "@ \r\n ";
            q += ", @" + LABOUR.TOTAL_CGST + "@ \r\n ";
            q += ", @" + LABOUR.TOTAL_SGST + "@ \r\n ";
            q += ", @" + LABOUR.TOTAL_IGST + "@ \r\n ";
            q += ", @" + LABOUR.GSTTOTAL + "@ \r\n ";
            q += ", @" + LABOUR.LEDGER_ID + "@ \r\n ";
            q += ", @" + LABOUR.ADDITIONAL + "@ \r\n ";
            q += ", @" + LABOUR.ROUNDS + "@ \r\n ";
            q += ", @" + LABOUR.GRANDTOTAL + "@ \r\n ";
            q += ", @" + LABOUR.REFERED_AMT + "@ \r\n ";
            q += ", @" + LABOUR.LOCKED + "@ \r\n ";
            q += ", @" + LABOUR.NOTES + "@ \r\n ";
            q += ", @" + LABOUR.ACTIVE_ID + "@ \r\n ";
            q += ", @" + LABOUR.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Const.Labour v, DAL dalsession)
        {
            string q = "UPDATE " + LABOUR.LABOUR_TBL + " SET";
            q += " " + LABOUR.UNIQUENO + " = @" + LABOUR.UNIQUENO + "@ \r\n ";
            q += "," + LABOUR.COMPANY_ID + " = @" + LABOUR.COMPANY_ID + "@ \r\n ";
            q += "," + LABOUR.ACY_ID + " = @" + LABOUR.ACY_ID + "@ \r\n ";
            q += "," + LABOUR.ORDER_ID + " = @" + LABOUR.ORDER_ID + "@ \r\n ";
            q += "," + LABOUR.LABOUR_NO + " = @" + LABOUR.LABOUR_NO + "@ \r\n ";
            q += "," + LABOUR.LABOUR_DATE + " = @" + LABOUR.LABOUR_DATE + "@ \r\n ";
            q += "," + LABOUR.TAXTYPE_ID + " = @" + LABOUR.TAXTYPE_ID + "@ \r\n ";
            q += "," + LABOUR.SALESTYPE_ID + " = @" + LABOUR.SALESTYPE_ID + "@ \r\n ";
            q += "," + LABOUR.PARTY_ID + " = @" + LABOUR.PARTY_ID + "@ \r\n ";
            q += "," + LABOUR.TRANSPORT_ID + " = @" + LABOUR.TRANSPORT_ID + "@ \r\n ";
            q += "," + LABOUR.DELIVEREDTO_ID + " = @" + LABOUR.DELIVEREDTO_ID + "@ \r\n ";
            q += "," + LABOUR.BUNDEL + " = @" + LABOUR.BUNDEL + "@ \r\n ";
            q += "," + LABOUR.TOTAL_QTY + " = @" + LABOUR.TOTAL_QTY + "@ \r\n ";
            q += "," + LABOUR.TOTAL_TAXABLE_AMOUNT + " = @" + LABOUR.TOTAL_TAXABLE_AMOUNT + "@ \r\n ";
            q += "," + LABOUR.TOTAL_CGST + " = @" + LABOUR.TOTAL_CGST + "@ \r\n ";
            q += "," + LABOUR.TOTAL_SGST + " = @" + LABOUR.TOTAL_SGST + "@ \r\n ";
            q += "," + LABOUR.TOTAL_IGST + " = @" + LABOUR.TOTAL_IGST + "@ \r\n ";
            q += "," + LABOUR.GSTTOTAL + " = @" + LABOUR.GSTTOTAL + "@ \r\n ";
            q += "," + LABOUR.LEDGER_ID + " = @" + LABOUR.LEDGER_ID + "@ \r\n ";
            q += "," + LABOUR.ADDITIONAL + " = @" + LABOUR.ADDITIONAL + "@ \r\n ";
            q += "," + LABOUR.ROUNDS + " = @" + LABOUR.ROUNDS + "@ \r\n ";
            q += "," + LABOUR.GRANDTOTAL + " = @" + LABOUR.GRANDTOTAL + "@ \r\n ";
            q += "," + LABOUR.REFERED_AMT + " = @" + LABOUR.REFERED_AMT + "@ \r\n ";
            q += "," + LABOUR.LOCKED + " = @" + LABOUR.LOCKED + "@ \r\n ";
            q += "," + LABOUR.NOTES + " = @" + LABOUR.NOTES + "@ \r\n ";
            q += "," + LABOUR.ACTIVE_ID + " = @" + LABOUR.ACTIVE_ID + "@ \r\n ";
            q += "," + LABOUR.USER_ID + " = @" + LABOUR.USER_ID + "@ \r\n ";
            q += "  WHERE " + LABOUR.LABOUR_ID + " = @" + LABOUR.LABOUR_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + LABOUR.LABOUR_TBL + " WHERE " + LABOUR.LABOUR_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
