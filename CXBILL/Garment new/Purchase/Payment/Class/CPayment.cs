// Version : 2.1.0.0 dt : 04-12-2018
// Auto Generated
// last update : 16-12-2018 01:30:02 PM

using CXLIB;

namespace CXBILL
{
    public class CPayment
    {

        #region[Get New]

        public static Payment GetNew
        {
            get
            {
                Payment obj = new Payment()
                {
                    Payment_id = string.Empty,
                    Uniqueno = string.Empty,
                    Company_id = Current.Company_id,
                    Acy_id = Current.Acy_id,
                    Payment_no = CPayment_exten.GetNext_No,
                    Payment_date = string.Empty,
                    Party_id = string.Empty,
                    Payment_amount = string.Empty,
                    Receipttype_id = string.Empty,
                    Cheque_no = string.Empty,
                    Cheque_date = string.Empty,
                    Bank_id = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User,
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Payment v)
        {
            q = q.Replace("@" + PAYMENT.PAYMENT_ID + "@", "" + ConvertTO.SqlString(v.Payment_id) + "");
            q = q.Replace("@" + PAYMENT.UNIQUENO + "@", "" + ConvertTO.SqlString(v.Uniqueno) + "");
            q = q.Replace("@" + PAYMENT.COMPANY_ID + "@", "" + ConvertTO.SqlString(v.Company_id) + "");
            q = q.Replace("@" + PAYMENT.ACY_ID + "@", "" + ConvertTO.SqlString(v.Acy_id) + "");
            q = q.Replace("@" + PAYMENT.PAYMENT_NO + "@", "" + ConvertTO.SqlString(v.Payment_no) + "");
            q = q.Replace("@" + PAYMENT.PAYMENT_DATE + "@", "" + ConvertTO.SqlDate(v.Payment_date) + "");
            q = q.Replace("@" + PAYMENT.PARTY_ID + "@", "" + ConvertTO.SqlString(v.Party_id) + "");
            q = q.Replace("@" + PAYMENT.PAYMENT_AMOUNT + "@", "" + ConvertTO.SqlString(v.Payment_amount) + "");
            q = q.Replace("@" + PAYMENT.RECEIPTTYPE_ID + "@", "" + ConvertTO.SqlString(v.Receipttype_id) + "");
            q = q.Replace("@" + PAYMENT.CHEQUE_NO + "@", "" + ConvertTO.SqlString(v.Cheque_no) + "");
            q = q.Replace("@" + PAYMENT.CHEQUE_DATE + "@", "" + ConvertTO.SqlString(v.Cheque_date) + "");
            q = q.Replace("@" + PAYMENT.BANK_ID + "@", "" + ConvertTO.SqlString(v.Bank_id) + "");
            q = q.Replace("@" + PAYMENT.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + PAYMENT.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + PAYMENT.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Payment v, DAL dalsession)
        {
            string q = " INSERT INTO " + PAYMENT.PAYMENT_TBL + " ( ";
            q += " " + PAYMENT.UNIQUENO + "\r\n";
            q += "," + PAYMENT.COMPANY_ID + "\r\n";
            q += "," + PAYMENT.ACY_ID + "\r\n";
            q += "," + PAYMENT.PAYMENT_NO + "\r\n";
            q += "," + PAYMENT.PAYMENT_DATE + " \r\n";
            q += "," + PAYMENT.PARTY_ID + " \r\n";
            q += "," + PAYMENT.PAYMENT_AMOUNT + " \r\n";
            q += "," + PAYMENT.RECEIPTTYPE_ID + " \r\n";
            q += "," + PAYMENT.CHEQUE_NO + " \r\n";
            q += "," + PAYMENT.CHEQUE_DATE + " \r\n";
            q += "," + PAYMENT.BANK_ID + " \r\n";
            q += "," + PAYMENT.NOTES + " \r\n";
            q += "," + PAYMENT.ACTIVE_ID + " \r\n";
            q += "," + PAYMENT.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + PAYMENT.UNIQUENO + "@ \r\n";
            q += ", @" + PAYMENT.COMPANY_ID + "@ \r\n";
            q += ", @" + PAYMENT.ACY_ID + "@ \r\n";
            q += ", @" + PAYMENT.PAYMENT_NO + "@ \r\n";
            q += ", @" + PAYMENT.PAYMENT_DATE + "@ \r\n";
            q += ", @" + PAYMENT.PARTY_ID + "@ \r\n";
            q += ", @" + PAYMENT.PAYMENT_AMOUNT + "@ \r\n";
            q += ", @" + PAYMENT.RECEIPTTYPE_ID + "@ \r\n";
            q += ", @" + PAYMENT.CHEQUE_NO + "@ \r\n";
            q += ", @" + PAYMENT.CHEQUE_DATE + "@ \r\n";
            q += ", @" + PAYMENT.BANK_ID + "@ \r\n";
            q += ", @" + PAYMENT.NOTES + "@ \r\n";
            q += ", @" + PAYMENT.ACTIVE_ID + "@ \r\n";
            q += ", @" + PAYMENT.USER_ID + "@ \r\n";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Payment v, DAL dalsession)
        {
            string q = "UPDATE " + PAYMENT.PAYMENT_TBL + " SET";
            q += " " + PAYMENT.UNIQUENO + " = @" + PAYMENT.UNIQUENO + "@ \r\n";
            q += "," + PAYMENT.COMPANY_ID + " = @" + PAYMENT.COMPANY_ID + "@ \r\n";
            q += "," + PAYMENT.ACY_ID + " = @" + PAYMENT.ACY_ID + "@ \r\n";
            q += "," + PAYMENT.PAYMENT_NO + " = @" + PAYMENT.PAYMENT_NO + "@ \r\n ";
            q += "," + PAYMENT.PAYMENT_DATE + " = @" + PAYMENT.PAYMENT_DATE + "@ \r\n ";
            q += "," + PAYMENT.PARTY_ID + " = @" + PAYMENT.PARTY_ID + "@ \r\n ";
            q += "," + PAYMENT.PAYMENT_AMOUNT + " = @" + PAYMENT.PAYMENT_AMOUNT + "@ \r\n ";
            q += "," + PAYMENT.RECEIPTTYPE_ID + " = @" + PAYMENT.RECEIPTTYPE_ID + "@ \r\n ";
            q += "," + PAYMENT.CHEQUE_NO + " = @" + PAYMENT.CHEQUE_NO + "@ \r\n ";
            q += "," + PAYMENT.CHEQUE_DATE + " = @" + PAYMENT.CHEQUE_DATE + "@ \r\n ";
            q += "," + PAYMENT.BANK_ID + " = @" + PAYMENT.BANK_ID + "@ \r\n ";
            q += "," + PAYMENT.NOTES + " = @" + PAYMENT.NOTES + "@ \r\n ";
            q += "," + PAYMENT.ACTIVE_ID + " = @" + PAYMENT.ACTIVE_ID + "@ \r\n ";
            q += "," + PAYMENT.USER_ID + " = @" + PAYMENT.USER_ID + "@ \r\n ";
            q += "  WHERE " + PAYMENT.PAYMENT_ID + " = @" + PAYMENT.PAYMENT_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + PAYMENT.PAYMENT_TBL + " WHERE " + PAYMENT.PAYMENT_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
