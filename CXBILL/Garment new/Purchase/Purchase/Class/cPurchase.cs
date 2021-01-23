// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 20-05-2019 09:52:02 PM

using CXLIB;

namespace CXBILL
{
    public class CPurchase
    {

        #region[Get New]

        public static Purchase GetNew
        {
            get
            {
                Purchase obj = new Purchase()
                {
                    Purchase_id = string.Empty,
                    Uniqueno = string.Empty,
                    Company_id = Current.Company_id,
                    Acy_id = Current.Acy_id,
                    Order_id = string.Empty,
                    Taxtype_id = Core.SGST,
                    Salestype_id = Core.TAX_INVOICE,
                    Entry_no = CPurchase_exten.GetNext_No,
                    Purchase_no = string.Empty,
                    Purchase_date = string.Empty,
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

        private static string AttachParams(string q, Purchase v)
        {
            q = q.Replace("@" + PURCHASE.PURCHASE_ID + "@", "" + ConvertTO.SqlString(v.Purchase_id) + "");
            q = q.Replace("@" + PURCHASE.UNIQUENO + "@", "" + ConvertTO.SqlString(v.Uniqueno) + "");
            q = q.Replace("@" + PURCHASE.COMPANY_ID + "@", "" + ConvertTO.SqlString(v.Company_id) + "");
            q = q.Replace("@" + PURCHASE.ACY_ID + "@", "" + ConvertTO.SqlString(v.Acy_id) + "");
            q = q.Replace("@" + PURCHASE.ORDER_ID + "@", "" + ConvertTO.SqlString(v.Order_id) + "");
            q = q.Replace("@" + PURCHASE.TAXTYPE_ID + "@", "" + ConvertTO.SqlString(v.Taxtype_id) + "");
            q = q.Replace("@" + PURCHASE.SALESTYPE_ID + "@", "" + ConvertTO.SqlString(v.Salestype_id) + "");
            q = q.Replace("@" + PURCHASE.ENTRY_NO + "@", "" + ConvertTO.SqlString(v.Entry_no) + "");
            q = q.Replace("@" + PURCHASE.PURCHASE_NO + "@", "" + ConvertTO.SqlString(v.Purchase_no) + "");
            q = q.Replace("@" + PURCHASE.PURCHASE_DATE + "@", "" + ConvertTO.SqlDate(v.Purchase_date) + "");
            q = q.Replace("@" + PURCHASE.PARTY_ID + "@", "" + ConvertTO.SqlString(v.Party_id) + "");
            q = q.Replace("@" + PURCHASE.TOTAL_QTY + "@", "" + ConvertTO.SqlString(v.Total_qty + ""));
            q = q.Replace("@" + PURCHASE.TOTAL_TAXABLE_AMOUNT + "@", "" + ConvertTO.SqlString(v.Total_taxable_amount + ""));
            q = q.Replace("@" + PURCHASE.TOTAL_CGST + "@", "" + ConvertTO.SqlString(v.Total_cgst + ""));
            q = q.Replace("@" + PURCHASE.TOTAL_SGST + "@", "" + ConvertTO.SqlString(v.Total_sgst + ""));
            q = q.Replace("@" + PURCHASE.TOTAL_IGST + "@", "" + ConvertTO.SqlString(v.Total_igst + ""));
            q = q.Replace("@" + PURCHASE.GSTTOTAL + "@", "" + ConvertTO.SqlString(v.Gsttotal + ""));
            q = q.Replace("@" + PURCHASE.LEDGER_ID + "@", "" + ConvertTO.SqlString(v.Ledger_id + ""));
            q = q.Replace("@" + PURCHASE.ADDITIONAL + "@", "" + ConvertTO.SqlString(v.Additional + ""));
            q = q.Replace("@" + PURCHASE.ROUNDS + "@", "" + ConvertTO.SqlString(v.Rounds + ""));
            q = q.Replace("@" + PURCHASE.GRANDTOTAL + "@", "" + ConvertTO.SqlString(v.Grandtotal + ""));
            q = q.Replace("@" + PURCHASE.REFERED_AMT + "@", "" + ConvertTO.SqlString(v.Refered_amt + ""));
            q = q.Replace("@" + PURCHASE.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            q = q.Replace("@" + PURCHASE.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + PURCHASE.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + PURCHASE.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Purchase v, DAL dalsession)
        {
            string q = " INSERT INTO " + PURCHASE.PURCHASE_TBL + " ( ";
            q += " " + PURCHASE.UNIQUENO + "\r\n";
            q += "," + PURCHASE.COMPANY_ID + "\r\n";
            q += "," + PURCHASE.ACY_ID + "\r\n";
            q += "," + PURCHASE.ORDER_ID + " \r\n";
            q += "," + PURCHASE.TAXTYPE_ID + " \r\n";
            q += "," + PURCHASE.SALESTYPE_ID + " \r\n";
            q += "," + PURCHASE.ENTRY_NO + " \r\n";
            q += "," + PURCHASE.PURCHASE_NO + " \r\n";
            q += "," + PURCHASE.PURCHASE_DATE + " \r\n";
            q += "," + PURCHASE.PARTY_ID + " \r\n";
            q += "," + PURCHASE.TOTAL_QTY + " \r\n";
            q += "," + PURCHASE.TOTAL_TAXABLE_AMOUNT + " \r\n";
            q += "," + PURCHASE.TOTAL_CGST + " \r\n";
            q += "," + PURCHASE.TOTAL_SGST + " \r\n";
            q += "," + PURCHASE.TOTAL_IGST + " \r\n";
            q += "," + PURCHASE.GSTTOTAL + " \r\n";
            q += "," + PURCHASE.LEDGER_ID + " \r\n";
            q += "," + PURCHASE.ADDITIONAL + " \r\n";
            q += "," + PURCHASE.ROUNDS + " \r\n";
            q += "," + PURCHASE.GRANDTOTAL + " \r\n";
            q += "," + PURCHASE.REFERED_AMT + " \r\n";
            q += "," + PURCHASE.LOCKED + " \r\n";
            q += "," + PURCHASE.NOTES + " \r\n";
            q += "," + PURCHASE.ACTIVE_ID + " \r\n";
            q += "," + PURCHASE.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + PURCHASE.UNIQUENO + "@ \r\n";
            q += ", @" + PURCHASE.COMPANY_ID + "@ \r\n";
            q += ", @" + PURCHASE.ACY_ID + "@ \r\n";
            q += ", @" + PURCHASE.ORDER_ID + "@ \r\n";
            q += ", @" + PURCHASE.TAXTYPE_ID + "@ \r\n";
            q += ", @" + PURCHASE.SALESTYPE_ID + "@ \r\n";
            q += ", @" + PURCHASE.ENTRY_NO + "@ \r\n";
            q += ", @" + PURCHASE.PURCHASE_NO + "@ \r\n";
            q += ", @" + PURCHASE.PURCHASE_DATE + "@ \r\n";
            q += ", @" + PURCHASE.PARTY_ID + "@ \r\n";
            q += ", @" + PURCHASE.TOTAL_QTY + "@ \r\n";
            q += ", @" + PURCHASE.TOTAL_TAXABLE_AMOUNT + "@ \r\n";
            q += ", @" + PURCHASE.TOTAL_CGST + "@ \r\n";
            q += ", @" + PURCHASE.TOTAL_SGST + "@ \r\n";
            q += ", @" + PURCHASE.TOTAL_IGST + "@ \r\n";
            q += ", @" + PURCHASE.GSTTOTAL + "@ \r\n";
            q += ", @" + PURCHASE.LEDGER_ID + "@ \r\n";
            q += ", @" + PURCHASE.ADDITIONAL + "@ \r\n";
            q += ", @" + PURCHASE.ROUNDS + "@ \r\n";
            q += ", @" + PURCHASE.GRANDTOTAL + "@ \r\n";
            q += ", @" + PURCHASE.REFERED_AMT + "@ \r\n";
            q += ", @" + PURCHASE.LOCKED + "@ \r\n";
            q += ", @" + PURCHASE.NOTES + "@ \r\n";
            q += ", @" + PURCHASE.ACTIVE_ID + "@ \r\n";
            q += ", @" + PURCHASE.USER_ID + "@ \r\n";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Purchase v, DAL dalsession)
        {
            string q = "UPDATE " + PURCHASE.PURCHASE_TBL + " SET";
            q += " " + PURCHASE.UNIQUENO + " = @" + PURCHASE.UNIQUENO + "@ \r\n";
            q += "," + PURCHASE.COMPANY_ID + " = @" + PURCHASE.COMPANY_ID + "@ \r\n";
            q += "," + PURCHASE.ACY_ID + " = @" + PURCHASE.ACY_ID + "@ \r\n";
            q += "," + PURCHASE.ORDER_ID + " = @" + PURCHASE.ORDER_ID + "@ \r\n ";
            q += "," + PURCHASE.TAXTYPE_ID + " = @" + PURCHASE.TAXTYPE_ID + "@ \r\n ";
            q += "," + PURCHASE.SALESTYPE_ID + " = @" + PURCHASE.SALESTYPE_ID + "@ \r\n ";
            q += "," + PURCHASE.ENTRY_NO + " = @" + PURCHASE.ENTRY_NO + "@ \r\n ";
            q += "," + PURCHASE.PURCHASE_NO + " = @" + PURCHASE.PURCHASE_NO + "@ \r\n ";
            q += "," + PURCHASE.PURCHASE_DATE + " = @" + PURCHASE.PURCHASE_DATE + "@ \r\n ";
            q += "," + PURCHASE.PARTY_ID + " = @" + PURCHASE.PARTY_ID + "@ \r\n ";
            q += "," + PURCHASE.TOTAL_QTY + " = @" + PURCHASE.TOTAL_QTY + "@ \r\n ";
            q += "," + PURCHASE.TOTAL_TAXABLE_AMOUNT + " = @" + PURCHASE.TOTAL_TAXABLE_AMOUNT + "@ \r\n ";
            q += "," + PURCHASE.TOTAL_CGST + " = @" + PURCHASE.TOTAL_CGST + "@ \r\n ";
            q += "," + PURCHASE.TOTAL_SGST + " = @" + PURCHASE.TOTAL_SGST + "@ \r\n ";
            q += "," + PURCHASE.TOTAL_IGST + " = @" + PURCHASE.TOTAL_IGST + "@ \r\n ";
            q += "," + PURCHASE.GSTTOTAL + " = @" + PURCHASE.GSTTOTAL + "@ \r\n ";
            q += "," + PURCHASE.LEDGER_ID + " = @" + PURCHASE.LEDGER_ID + "@ \r\n ";
            q += "," + PURCHASE.ADDITIONAL + " = @" + PURCHASE.ADDITIONAL + "@ \r\n ";
            q += "," + PURCHASE.ROUNDS + " = @" + PURCHASE.ROUNDS + "@ \r\n ";
            q += "," + PURCHASE.GRANDTOTAL + " = @" + PURCHASE.GRANDTOTAL + "@ \r\n ";
            q += "," + PURCHASE.REFERED_AMT + " = @" + PURCHASE.REFERED_AMT + "@ \r\n ";
            q += "," + PURCHASE.LOCKED + " = @" + PURCHASE.LOCKED + "@ \r\n ";
            q += "," + PURCHASE.NOTES + " = @" + PURCHASE.NOTES + "@ \r\n ";
            q += "," + PURCHASE.ACTIVE_ID + " = @" + PURCHASE.ACTIVE_ID + "@ \r\n ";
            q += "," + PURCHASE.USER_ID + " = @" + PURCHASE.USER_ID + "@ \r\n ";
            q += "  WHERE " + PURCHASE.PURCHASE_ID + " = @" + PURCHASE.PURCHASE_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + PURCHASE.PURCHASE_TBL + " WHERE " + PURCHASE.PURCHASE_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
