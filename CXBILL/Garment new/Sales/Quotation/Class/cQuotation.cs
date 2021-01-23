// Version : 2.0.0.0 dt : 16-10-2018
// Auto Generated
// last update : 22-10-2018 09:00:08 AM

using CXCORE;
using CXLIB;

namespace CXBILL
{
    public class CQuotation
    {

        #region[Get New]

        public static Quotation GetNew
        {
            get
            {
                Quotation obj = new Quotation()
                {
                    Quotation_id = string.Empty,
                    Uniqueno = string.Empty,
                    Company_id = Current.Company_id,
                    Acy_id = Current.Acy_id,
                    Order_id = string.Empty,
                    Quotation_no = CQuotation_exten.GetNext_No.ToString(),
                    Quotation_date = string.Empty,
                    Party_id = string.Empty,
                    Total_qty = decimal.Zero,
                    Total_taxable_amount = decimal.Zero,
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

        private static string AttachParams(string q, Quotation v)
        {
            q = q.Replace("@" + QUOTATION.QUOTATION_ID + "@", "" + ConvertTO.SqlString(v.Quotation_id) + "");
            q = q.Replace("@" + QUOTATION.UNIQUENO + "@", "" + ConvertTO.SqlString(v.Uniqueno) + "");
            q = q.Replace("@" + QUOTATION.COMPANY_ID + "@", "" + ConvertTO.SqlString(v.Company_id) + "");
            q = q.Replace("@" + QUOTATION.ACY_ID + "@", "" + ConvertTO.SqlString(v.Acy_id) + "");
            q = q.Replace("@" + QUOTATION.ORDER_ID + "@", "" + ConvertTO.SqlString(v.Order_id) + "");
            q = q.Replace("@" + QUOTATION.QUOTATION_NO + "@", "" + ConvertTO.SqlString(v.Quotation_no) + "");
            q = q.Replace("@" + QUOTATION.QUOTATION_DATE + "@", "" + ConvertTO.SqlDate(v.Quotation_date) + "");
            q = q.Replace("@" + QUOTATION.PARTY_ID + "@", "" + ConvertTO.SqlString(v.Party_id) + "");
            q = q.Replace("@" + QUOTATION.TOTAL_QTY + "@", "" + ConvertTO.SqlDecimal(v.Total_qty) + "");
            q = q.Replace("@" + QUOTATION.TOTAL_TAXABLE_AMOUNT + "@", "" + ConvertTO.SqlDecimal(v.Total_taxable_amount) + "");
            q = q.Replace("@" + QUOTATION.LEDGER_ID + "@", "" + ConvertTO.SqlString(v.Ledger_id) + "");
            q = q.Replace("@" + QUOTATION.ADDITIONAL + "@", "" + ConvertTO.SqlDecimal(v.Additional) + "");
            q = q.Replace("@" + QUOTATION.ROUNDS + "@", "" + ConvertTO.SqlDecimal(v.Rounds) + "");
            q = q.Replace("@" + QUOTATION.GRANDTOTAL + "@", "" + ConvertTO.SqlDecimal(v.Grandtotal) + "");
            q = q.Replace("@" + QUOTATION.REFERED_AMT + "@", "" + ConvertTO.SqlDecimal(v.Refered_amt) + "");
            q = q.Replace("@" + QUOTATION.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            q = q.Replace("@" + QUOTATION.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + QUOTATION.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + QUOTATION.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Quotation v, DAL dalsession)
        {
            string q = " INSERT INTO " + QUOTATION.QUOTATION_TBL + " ( ";
            q += " " + QUOTATION.UNIQUENO + " \r\n ";
            q += "," + QUOTATION.COMPANY_ID + " \r\n ";
            q += "," + QUOTATION.ACY_ID + " \r\n ";
            q += "," + QUOTATION.ORDER_ID + " \r\n ";
            q += "," + QUOTATION.QUOTATION_NO + " \r\n ";
            q += "," + QUOTATION.QUOTATION_DATE + " \r\n ";
            q += "," + QUOTATION.PARTY_ID + " \r\n ";
            q += "," + QUOTATION.TOTAL_QTY + " \r\n ";
            q += "," + QUOTATION.TOTAL_TAXABLE_AMOUNT + " \r\n ";
            q += "," + QUOTATION.LEDGER_ID + " \r\n ";
            q += "," + QUOTATION.ADDITIONAL + " \r\n ";
            q += "," + QUOTATION.ROUNDS + " \r\n ";
            q += "," + QUOTATION.GRANDTOTAL + " \r\n ";
            q += "," + QUOTATION.REFERED_AMT + " \r\n ";
            q += "," + QUOTATION.LOCKED + " \r\n ";
            q += "," + QUOTATION.NOTES + " \r\n ";
            q += "," + QUOTATION.ACTIVE_ID + " \r\n ";
            q += "," + QUOTATION.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + QUOTATION.UNIQUENO + "@ \r\n ";
            q += ", @" + QUOTATION.COMPANY_ID + "@ \r\n ";
            q += ", @" + QUOTATION.ACY_ID + "@ \r\n ";
            q += ", @" + QUOTATION.ORDER_ID + "@ \r\n ";
            q += ", @" + QUOTATION.QUOTATION_NO + "@ \r\n ";
            q += ", @" + QUOTATION.QUOTATION_DATE + "@ \r\n ";
            q += ", @" + QUOTATION.PARTY_ID + "@ \r\n ";
            q += ", @" + QUOTATION.TOTAL_QTY + "@ \r\n ";
            q += ", @" + QUOTATION.TOTAL_TAXABLE_AMOUNT + "@ \r\n ";
            q += ", @" + QUOTATION.LEDGER_ID + "@ \r\n ";
            q += ", @" + QUOTATION.ADDITIONAL + "@ \r\n ";
            q += ", @" + QUOTATION.ROUNDS + "@ \r\n ";
            q += ", @" + QUOTATION.GRANDTOTAL + "@ \r\n ";
            q += ", @" + QUOTATION.REFERED_AMT + "@ \r\n ";
            q += ", @" + QUOTATION.LOCKED + "@ \r\n ";
            q += ", @" + QUOTATION.NOTES + "@ \r\n ";
            q += ", @" + QUOTATION.ACTIVE_ID + "@ \r\n ";
            q += ", @" + QUOTATION.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Quotation v, DAL dalsession)
        {
            string q = "UPDATE " + QUOTATION.QUOTATION_TBL + " SET";
            q += " " + QUOTATION.UNIQUENO + " = @" + QUOTATION.UNIQUENO + "@ \r\n ";
            q += "," + QUOTATION.COMPANY_ID + " = @" + QUOTATION.COMPANY_ID + "@ \r\n ";
            q += "," + QUOTATION.ACY_ID + " = @" + QUOTATION.ACY_ID + "@ \r\n ";
            q += "," + QUOTATION.ORDER_ID + " = @" + QUOTATION.ORDER_ID + "@ \r\n ";
            q += "," + QUOTATION.QUOTATION_NO + " = @" + QUOTATION.QUOTATION_NO + "@ \r\n ";
            q += "," + QUOTATION.QUOTATION_DATE + " = @" + QUOTATION.QUOTATION_DATE + "@ \r\n ";
            q += "," + QUOTATION.PARTY_ID + " = @" + QUOTATION.PARTY_ID + "@ \r\n ";
            q += "," + QUOTATION.TOTAL_QTY + " = @" + QUOTATION.TOTAL_QTY + "@ \r\n ";
            q += "," + QUOTATION.TOTAL_TAXABLE_AMOUNT + " = @" + QUOTATION.TOTAL_TAXABLE_AMOUNT + "@ \r\n ";
            q += "," + QUOTATION.LEDGER_ID + " = @" + QUOTATION.LEDGER_ID + "@ \r\n ";
            q += "," + QUOTATION.ADDITIONAL + " = @" + QUOTATION.ADDITIONAL + "@ \r\n ";
            q += "," + QUOTATION.ROUNDS + " = @" + QUOTATION.ROUNDS + "@ \r\n ";
            q += "," + QUOTATION.GRANDTOTAL + " = @" + QUOTATION.GRANDTOTAL + "@ \r\n ";
            q += "," + QUOTATION.REFERED_AMT + " = @" + QUOTATION.REFERED_AMT + "@ \r\n ";
            q += "," + QUOTATION.LOCKED + " = @" + QUOTATION.LOCKED + "@ \r\n ";
            q += "," + QUOTATION.NOTES + " = @" + QUOTATION.NOTES + "@ \r\n ";
            q += "," + QUOTATION.ACTIVE_ID + " = @" + QUOTATION.ACTIVE_ID + "@ \r\n ";
            q += "," + QUOTATION.USER_ID + " = @" + QUOTATION.USER_ID + "@ \r\n ";
            q += "  WHERE " + QUOTATION.QUOTATION_ID + " = @" + QUOTATION.QUOTATION_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + QUOTATION.QUOTATION_TBL + " WHERE " + QUOTATION.QUOTATION_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
