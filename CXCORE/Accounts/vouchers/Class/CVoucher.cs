// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 25-12-2017 07:21:18 PM

using CodexsunLib;

namespace CodexsunCore
{
    public class CVoucher
    {

        #region[Get New]

        public static Voucher GetNew
        {
            get
            {
                Voucher obj = new Voucher()
                {
                    Voucher_id = string.Empty,
                    Company_id = string.Empty,
                    Voucher_no = CVoucher_exten.GetNext_No,
                    Voucher_date = string.Empty,
                    Vouchertype_id = string.Empty,
                    Order_id = string.Empty,
                    Ledger_id = string.Empty,
                    Party_id = string.Empty,
                    Purpose = string.Empty,
                    Credit = string.Empty,
                    Debit = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Voucher v)
        {
            q = q.Replace("@" + VOUCHER.VOUCHER_ID + "@", "" + ConvertTO.SqlString(v.Voucher_id) + "");
            q = q.Replace("@" + VOUCHER.COMPANY_ID + "@", "" + ConvertTO.SqlString(v.Company_id) + "");
            q = q.Replace("@" + VOUCHER.VOUCHER_NO + "@", "" + ConvertTO.SqlString(v.Voucher_no) + "");
            q = q.Replace("@" + VOUCHER.VOUCHER_DATE + "@", "" + ConvertTO.SqlDate(v.Voucher_date) + "");
            q = q.Replace("@" + VOUCHER.VOUCHERTYPE_ID + "@", "" + ConvertTO.SqlString(v.Vouchertype_id) + "");
            q = q.Replace("@" + VOUCHER.ORDER_ID + "@", "" + ConvertTO.SqlString(v.Order_id) + "");
            q = q.Replace("@" + VOUCHER.LEDGER_ID + "@", "" + ConvertTO.SqlString(v.Ledger_id) + "");
            q = q.Replace("@" + VOUCHER.PARTY_ID + "@", "" + ConvertTO.SqlString(v.Party_id) + "");
            q = q.Replace("@" + VOUCHER.PURPOSE + "@", "" + ConvertTO.SqlString(v.Purpose) + "");
            q = q.Replace("@" + VOUCHER.CREDIT + "@", "" + ConvertTO.SqlString(v.Credit) + "");
            q = q.Replace("@" + VOUCHER.DEBIT + "@", "" + ConvertTO.SqlString(v.Debit) + "");
            q = q.Replace("@" + VOUCHER.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + VOUCHER.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + VOUCHER.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Voucher v, DAL dalsession)
        {
                string q = " INSERT INTO " + VOUCHER.VOUCHER_TBL + " ( ";
                q += " " + VOUCHER.COMPANY_ID + " \r\n ";
                q += "," + VOUCHER.VOUCHER_NO + " \r\n ";
                q += "," + VOUCHER.VOUCHER_DATE + " \r\n ";
                q += "," + VOUCHER.VOUCHERTYPE_ID + " \r\n ";
                q += "," + VOUCHER.ORDER_ID + " \r\n ";
                q += "," + VOUCHER.LEDGER_ID + " \r\n ";
                q += "," + VOUCHER.PARTY_ID + " \r\n ";
                q += "," + VOUCHER.PURPOSE + " \r\n ";
                q += "," + VOUCHER.CREDIT + " \r\n ";
                q += "," + VOUCHER.DEBIT + " \r\n ";
                q += "," + VOUCHER.NOTES + " \r\n ";
                q += "," + VOUCHER.ACTIVE_ID + " \r\n ";
                q += "," + VOUCHER.USER_ID + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @"+ VOUCHER.COMPANY_ID + "@ \r\n ";
                q += ", @"+ VOUCHER.VOUCHER_NO + "@ \r\n ";
                q += ", @"+ VOUCHER.VOUCHER_DATE + "@ \r\n ";
                q += ", @"+ VOUCHER.VOUCHERTYPE_ID + "@ \r\n ";
                q += ", @"+ VOUCHER.ORDER_ID + "@ \r\n ";
                q += ", @"+ VOUCHER.LEDGER_ID + "@ \r\n ";
                q += ", @"+ VOUCHER.PARTY_ID + "@ \r\n ";
                q += ", @"+ VOUCHER.PURPOSE + "@ \r\n ";
                q += ", @"+ VOUCHER.CREDIT + "@ \r\n ";
                q += ", @"+ VOUCHER.DEBIT + "@ \r\n ";
                q += ", @"+ VOUCHER.NOTES + "@ \r\n ";
                q += ", @"+ VOUCHER.ACTIVE_ID + "@ \r\n ";
                q += ", @"+ VOUCHER.USER_ID + "@ \r\n ";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Voucher v, DAL dalsession)
        {
                string q = "UPDATE " + VOUCHER.VOUCHER_TBL + " SET";
                q += " " + VOUCHER.COMPANY_ID + " = @" + VOUCHER.COMPANY_ID + "@ \r\n ";
                q += "," + VOUCHER.VOUCHER_NO + " = @" + VOUCHER.VOUCHER_NO + "@ \r\n ";
                q += "," + VOUCHER.VOUCHER_DATE + " = @" + VOUCHER.VOUCHER_DATE + "@ \r\n ";
                q += "," + VOUCHER.VOUCHERTYPE_ID + " = @" + VOUCHER.VOUCHERTYPE_ID + "@ \r\n ";
                q += "," + VOUCHER.ORDER_ID + " = @" + VOUCHER.ORDER_ID + "@ \r\n ";
                q += "," + VOUCHER.LEDGER_ID + " = @" + VOUCHER.LEDGER_ID + "@ \r\n ";
                q += "," + VOUCHER.PARTY_ID + " = @" + VOUCHER.PARTY_ID + "@ \r\n ";
                q += "," + VOUCHER.PURPOSE + " = @" + VOUCHER.PURPOSE + "@ \r\n ";
                q += "," + VOUCHER.CREDIT + " = @" + VOUCHER.CREDIT + "@ \r\n ";
                q += "," + VOUCHER.DEBIT + " = @" + VOUCHER.DEBIT + "@ \r\n ";
                q += "," + VOUCHER.NOTES + " = @" + VOUCHER.NOTES + "@ \r\n ";
                q += "," + VOUCHER.ACTIVE_ID + " = @" + VOUCHER.ACTIVE_ID + "@ \r\n ";
                q += "," + VOUCHER.USER_ID + " = @" + VOUCHER.USER_ID + "@ \r\n ";
                q += "  WHERE " + VOUCHER.VOUCHER_ID + " = @" + VOUCHER.VOUCHER_ID + "@ ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + VOUCHER.VOUCHER_TBL+ " WHERE " + VOUCHER.VOUCHER_ID + " =  " + pkid +";");
        }
        #endregion[Delete]

    }//cls
}//ns
