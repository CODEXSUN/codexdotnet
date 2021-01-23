// Version : 2.0.0.0 dt : 16-10-2018
// Auto Generated
// last update : 22-10-2018 09:00:08 AM

using CXLIB;

namespace CXBILL
{
    public class CLabour_invoice
    {

        #region[Get New]

        public static Offset_labour GetNew
        {
            get
            {
                Offset_labour obj = new Offset_labour()
                {
                    Offset_labour_id = string.Empty,
                    Uniqueno = string.Empty,
                    Company_id = Current.Company_id,
                    Acy_id = Current.Acy_id,
                    Offset_labour_no = COffset_labour_exten.GetNext_No,
                    Offset_labour_date =string.Empty,
                    Salestype_id= Core.LABOUR_BILL,
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

        private static string AttachParams(string q, Offset_labour v)
        {
            q = q.Replace("@" + OFFSET_LABOUR.OFFSET_LABOUR_ID + "@", "" + ConvertTO.SqlString(v.Offset_labour_id) + "");
            q = q.Replace("@" + OFFSET_LABOUR.UNIQUENO + "@", "" + ConvertTO.SqlString(v.Uniqueno) + "");
            q = q.Replace("@" + OFFSET_LABOUR.COMPANY_ID + "@", "" + ConvertTO.SqlString(v.Company_id) + "");
            q = q.Replace("@" + OFFSET_LABOUR.ACY_ID + "@", "" + ConvertTO.SqlString(v.Acy_id) + "");
            q = q.Replace("@" + OFFSET_LABOUR.OFFSET_LABOUR_NO + "@", "" + ConvertTO.SqlInt(v.Offset_labour_no) + "");
            q = q.Replace("@" + OFFSET_LABOUR.OFFSET_LABOUR_DATE + "@", "" + ConvertTO.SqlDate(v.Offset_labour_date) + "");
            q = q.Replace("@" + OFFSET_LABOUR.SALESTYPE_ID + "@", "" + ConvertTO.SqlString(v.Salestype_id) + "");
            q = q.Replace("@" + OFFSET_LABOUR.TAXTYPE_ID + "@", "" + ConvertTO.SqlString(v.Taxtype_id) + "");
            q = q.Replace("@" + OFFSET_LABOUR.PARTY_ID + "@", "" + ConvertTO.SqlString(v.Party_id) + "");
            q = q.Replace("@" + OFFSET_LABOUR.TOTAL_QTY + "@", "" + ConvertTO.SqlDecimal(v.Total_qty) + "");
            q = q.Replace("@" + OFFSET_LABOUR.TOTAL_TAXABLE_AMOUNT + "@", "" + ConvertTO.SqlDecimal(v.Total_taxable_amount) + "");
            q = q.Replace("@" + OFFSET_LABOUR.TOTAL_CGST + "@", "" + ConvertTO.SqlDecimal(v.Total_cgst) + "");
            q = q.Replace("@" + OFFSET_LABOUR.TOTAL_SGST + "@", "" + ConvertTO.SqlDecimal(v.Total_sgst) + "");
            q = q.Replace("@" + OFFSET_LABOUR.TOTAL_IGST + "@", "" + ConvertTO.SqlDecimal(v.Total_igst) + "");
            q = q.Replace("@" + OFFSET_LABOUR.GSTTOTAL + "@", "" + ConvertTO.SqlDecimal(v.Gsttotal) + "");
            q = q.Replace("@" + OFFSET_LABOUR.LEDGER_ID + "@", "" + ConvertTO.SqlString(v.Ledger_id) + "");
            q = q.Replace("@" + OFFSET_LABOUR.ADDITIONAL + "@", "" + ConvertTO.SqlDecimal(v.Additional) + "");
            q = q.Replace("@" + OFFSET_LABOUR.ROUNDS + "@", "" + ConvertTO.SqlDecimal(v.Rounds) + "");
            q = q.Replace("@" + OFFSET_LABOUR.GRANDTOTAL + "@", "" + ConvertTO.SqlDecimal(v.Grandtotal) + "");
            q = q.Replace("@" + OFFSET_LABOUR.REFERED_AMT + "@", "" + ConvertTO.SqlDecimal(v.Refered_amt) + "");
            q = q.Replace("@" + OFFSET_LABOUR.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            q = q.Replace("@" + OFFSET_LABOUR.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + OFFSET_LABOUR.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + OFFSET_LABOUR.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Offset_labour v, DAL dalsession)
        {
            string q = " INSERT INTO " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + " ( ";
            q += " " + OFFSET_LABOUR.UNIQUENO + " \r\n ";
            q += "," + OFFSET_LABOUR.COMPANY_ID + " \r\n ";
            q += "," + OFFSET_LABOUR.ACY_ID + " \r\n ";
            q += "," + OFFSET_LABOUR.OFFSET_LABOUR_NO + " \r\n ";
            q += "," + OFFSET_LABOUR.OFFSET_LABOUR_DATE + " \r\n ";
            q += "," + OFFSET_LABOUR.SALESTYPE_ID + " \r\n ";
            q += "," + OFFSET_LABOUR.TAXTYPE_ID + " \r\n ";
            q += "," + OFFSET_LABOUR.PARTY_ID + " \r\n ";
            q += "," + OFFSET_LABOUR.TOTAL_QTY + " \r\n ";
            q += "," + OFFSET_LABOUR.TOTAL_TAXABLE_AMOUNT + " \r\n ";
            q += "," + OFFSET_LABOUR.TOTAL_CGST + " \r\n ";
            q += "," + OFFSET_LABOUR.TOTAL_SGST + " \r\n ";
            q += "," + OFFSET_LABOUR.TOTAL_IGST + " \r\n ";
            q += "," + OFFSET_LABOUR.GSTTOTAL + " \r\n ";
            q += "," + OFFSET_LABOUR.LEDGER_ID + " \r\n ";
            q += "," + OFFSET_LABOUR.ADDITIONAL + " \r\n ";
            q += "," + OFFSET_LABOUR.ROUNDS + " \r\n ";
            q += "," + OFFSET_LABOUR.GRANDTOTAL + " \r\n ";
            q += "," + OFFSET_LABOUR.REFERED_AMT + " \r\n ";
            q += "," + OFFSET_LABOUR.LOCKED + " \r\n ";
            q += "," + OFFSET_LABOUR.NOTES + " \r\n ";
            q += "," + OFFSET_LABOUR.ACTIVE_ID + " \r\n ";
            q += "," + OFFSET_LABOUR.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + OFFSET_LABOUR.UNIQUENO + "@ \r\n ";
            q += ", @" + OFFSET_LABOUR.COMPANY_ID + "@ \r\n ";
            q += ", @" + OFFSET_LABOUR.ACY_ID + "@ \r\n ";
            q += ", @" + OFFSET_LABOUR.OFFSET_LABOUR_NO + "@ \r\n ";
            q += ", @" + OFFSET_LABOUR.OFFSET_LABOUR_DATE + "@ \r\n ";
            q += ", @" + OFFSET_LABOUR.SALESTYPE_ID + "@ \r\n ";
            q += ", @" + OFFSET_LABOUR.TAXTYPE_ID + "@ \r\n ";
            q += ", @" + OFFSET_LABOUR.PARTY_ID + "@ \r\n ";
            q += ", @" + OFFSET_LABOUR.TOTAL_QTY + "@ \r\n ";
            q += ", @" + OFFSET_LABOUR.TOTAL_TAXABLE_AMOUNT + "@ \r\n ";
            q += ", @" + OFFSET_LABOUR.TOTAL_CGST + "@ \r\n ";
            q += ", @" + OFFSET_LABOUR.TOTAL_SGST + "@ \r\n ";
            q += ", @" + OFFSET_LABOUR.TOTAL_IGST + "@ \r\n ";
            q += ", @" + OFFSET_LABOUR.GSTTOTAL + "@ \r\n ";
            q += ", @" + OFFSET_LABOUR.LEDGER_ID + "@ \r\n ";
            q += ", @" + OFFSET_LABOUR.ADDITIONAL + "@ \r\n ";
            q += ", @" + OFFSET_LABOUR.ROUNDS + "@ \r\n ";
            q += ", @" + OFFSET_LABOUR.GRANDTOTAL + "@ \r\n ";
            q += ", @" + OFFSET_LABOUR.REFERED_AMT + "@ \r\n ";
            q += ", @" + OFFSET_LABOUR.LOCKED + "@ \r\n ";
            q += ", @" + OFFSET_LABOUR.NOTES + "@ \r\n ";
            q += ", @" + OFFSET_LABOUR.ACTIVE_ID + "@ \r\n ";
            q += ", @" + OFFSET_LABOUR.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Offset_labour v, DAL dalsession)
        {
            string q = "UPDATE " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + " SET";
            q += " " + OFFSET_LABOUR.UNIQUENO + " = @" + OFFSET_LABOUR.UNIQUENO + "@ \r\n ";
            q += "," + OFFSET_LABOUR.COMPANY_ID + " = @" + OFFSET_LABOUR.COMPANY_ID + "@ \r\n ";
            q += "," + OFFSET_LABOUR.ACY_ID + " = @" + OFFSET_LABOUR.ACY_ID + "@ \r\n ";
            q += "," + OFFSET_LABOUR.OFFSET_LABOUR_NO + " = @" + OFFSET_LABOUR.OFFSET_LABOUR_NO + "@ \r\n ";
            q += "," + OFFSET_LABOUR.OFFSET_LABOUR_DATE + " = @" + OFFSET_LABOUR.OFFSET_LABOUR_DATE + "@ \r\n ";
            q += "," + OFFSET_LABOUR.SALESTYPE_ID + " = @" + OFFSET_LABOUR.SALESTYPE_ID + "@ \r\n ";
            q += "," + OFFSET_LABOUR.TAXTYPE_ID + " = @" + OFFSET_LABOUR.TAXTYPE_ID + "@ \r\n ";
            q += "," + OFFSET_LABOUR.PARTY_ID + " = @" + OFFSET_LABOUR.PARTY_ID + "@ \r\n ";
            q += "," + OFFSET_LABOUR.TOTAL_QTY + " = @" + OFFSET_LABOUR.TOTAL_QTY + "@ \r\n ";
            q += "," + OFFSET_LABOUR.TOTAL_TAXABLE_AMOUNT + " = @" + OFFSET_LABOUR.TOTAL_TAXABLE_AMOUNT + "@ \r\n ";
            q += "," + OFFSET_LABOUR.TOTAL_CGST + " = @" + OFFSET_LABOUR.TOTAL_CGST + "@ \r\n ";
            q += "," + OFFSET_LABOUR.TOTAL_SGST + " = @" + OFFSET_LABOUR.TOTAL_SGST + "@ \r\n ";
            q += "," + OFFSET_LABOUR.TOTAL_IGST + " = @" + OFFSET_LABOUR.TOTAL_IGST + "@ \r\n ";
            q += "," + OFFSET_LABOUR.GSTTOTAL + " = @" + OFFSET_LABOUR.GSTTOTAL + "@ \r\n ";
            q += "," + OFFSET_LABOUR.LEDGER_ID + " = @" + OFFSET_LABOUR.LEDGER_ID + "@ \r\n ";
            q += "," + OFFSET_LABOUR.ADDITIONAL + " = @" + OFFSET_LABOUR.ADDITIONAL + "@ \r\n ";
            q += "," + OFFSET_LABOUR.ROUNDS + " = @" + OFFSET_LABOUR.ROUNDS + "@ \r\n ";
            q += "," + OFFSET_LABOUR.GRANDTOTAL + " = @" + OFFSET_LABOUR.GRANDTOTAL + "@ \r\n ";
            q += "," + OFFSET_LABOUR.REFERED_AMT + " = @" + OFFSET_LABOUR.REFERED_AMT + "@ \r\n ";
            q += "," + OFFSET_LABOUR.LOCKED + " = @" + OFFSET_LABOUR.LOCKED + "@ \r\n ";
            q += "," + OFFSET_LABOUR.NOTES + " = @" + OFFSET_LABOUR.NOTES + "@ \r\n ";
            q += "," + OFFSET_LABOUR.ACTIVE_ID + " = @" + OFFSET_LABOUR.ACTIVE_ID + "@ \r\n ";
            q += "," + OFFSET_LABOUR.USER_ID + " = @" + OFFSET_LABOUR.USER_ID + "@ \r\n ";
            q += "  WHERE " + OFFSET_LABOUR.OFFSET_LABOUR_ID + " = @" + OFFSET_LABOUR.OFFSET_LABOUR_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + " WHERE " + OFFSET_LABOUR.OFFSET_LABOUR_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
