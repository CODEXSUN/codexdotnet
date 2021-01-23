// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 13-03-2018 10:59:14 AM

using CXCORE;
using CXLIB;

namespace CXBILL
{
    public class CQreceipt
    {

        #region[Get New]

        public static QReceipt GetNew
        {
            get
            {
                QReceipt obj = new QReceipt()
                {
                    Qreceipt_id = string.Empty,
                    Uniqueno = string.Empty,
                    Company_id = Current.Company_id,
                    Acy_id = Current.Acy_id,
                    Qreceipt_no = CQreceipt_exten.GetNext_No,
                    Qreceipt_date = string.Empty,
                    Party_id = string.Empty,
                    Receipttype_id = string.Empty,
                    Cheq_no = string.Empty,
                    Qreceipt_amount = string.Empty,
                    Cheq_date = string.Empty,
                    Bank_id = string.Empty,
                    Total_amount = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, QReceipt v)
        {
            q = q.Replace("@" + QRECEIPT.QRECEIPT_ID + "@", "" + ConvertTO.SqlString(v.Qreceipt_id) + "");
            q = q.Replace("@" + QRECEIPT.UNIQUENO + "@", "" + ConvertTO.SqlString(v.Uniqueno) + "");
            q = q.Replace("@" + QRECEIPT.COMPANY_ID + "@", "" + ConvertTO.SqlString(v.Company_id) + "");
            q = q.Replace("@" + QRECEIPT.ACY_ID + "@", "" + ConvertTO.SqlString(v.Acy_id) + "");
            q = q.Replace("@" + QRECEIPT.QRECEIPT_NO + "@", "" + ConvertTO.SqlString(v.Qreceipt_no) + "");
            q = q.Replace("@" + QRECEIPT.QRECEIPT_DATE + "@", "" + ConvertTO.SqlDate(v.Qreceipt_date) + "");
            q = q.Replace("@" + QRECEIPT.PARTY_ID + "@", "" + ConvertTO.SqlString(v.Party_id) + "");
            q = q.Replace("@" + QRECEIPT.RECEIPTTYPE_ID + "@", "" + ConvertTO.SqlString(v.Receipttype_id) + "");
            q = q.Replace("@" + QRECEIPT.CHEQ_NO + "@", "" + ConvertTO.SqlString(v.Cheq_no) + "");
            q = q.Replace("@" + QRECEIPT.QRECEIPT_AMOUNT + "@", "" + ConvertTO.SqlString(v.Qreceipt_amount) + "");
            q = q.Replace("@" + QRECEIPT.CHEQ_DATE + "@", "" + ConvertTO.SqlString(v.Cheq_date) + "");
            q = q.Replace("@" + QRECEIPT.BANK_ID + "@", "" + ConvertTO.SqlString(v.Bank_id) + "");
            q = q.Replace("@" + QRECEIPT.TOTAL_AMOUNT + "@", "" + ConvertTO.SqlString(v.Total_amount) + "");
            q = q.Replace("@" + QRECEIPT.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + QRECEIPT.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + QRECEIPT.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(QReceipt v, DAL dalsession)
        {
            string q = " INSERT INTO " + QRECEIPT.QRECEIPT_TBL + " ( ";
            q += " " + QRECEIPT.UNIQUENO + " \r\n ";
            q += "," + QRECEIPT.COMPANY_ID + " \r\n ";
            q += "," + QRECEIPT.ACY_ID + " \r\n ";
            q += "," + QRECEIPT.QRECEIPT_NO + " \r\n ";
            q += "," + QRECEIPT.QRECEIPT_DATE + " \r\n ";
            q += "," + QRECEIPT.PARTY_ID + " \r\n ";
            q += "," + QRECEIPT.RECEIPTTYPE_ID + " \r\n ";
            q += "," + QRECEIPT.CHEQ_NO + " \r\n ";
            q += "," + QRECEIPT.QRECEIPT_AMOUNT + " \r\n ";
            q += "," + QRECEIPT.CHEQ_DATE + " \r\n ";
            q += "," + QRECEIPT.BANK_ID + " \r\n ";
            q += "," + QRECEIPT.TOTAL_AMOUNT + " \r\n ";
            q += "," + QRECEIPT.NOTES + " \r\n ";
            q += "," + QRECEIPT.ACTIVE_ID + " \r\n ";
            q += "," + QRECEIPT.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + QRECEIPT.UNIQUENO + "@ \r\n ";
            q += ", @" + QRECEIPT.COMPANY_ID + "@ \r\n ";
            q += ", @" + QRECEIPT.ACY_ID + "@ \r\n ";
            q += ", @" + QRECEIPT.QRECEIPT_NO + "@ \r\n ";
            q += ", @" + QRECEIPT.QRECEIPT_DATE + "@ \r\n ";
            q += ", @" + QRECEIPT.PARTY_ID + "@ \r\n ";
            q += ", @" + QRECEIPT.RECEIPTTYPE_ID + "@ \r\n ";
            q += ", @" + QRECEIPT.CHEQ_NO + "@ \r\n ";
            q += ", @" + QRECEIPT.QRECEIPT_AMOUNT + "@ \r\n ";
            q += ", @" + QRECEIPT.CHEQ_DATE + "@ \r\n ";
            q += ", @" + QRECEIPT.BANK_ID + "@ \r\n ";
            q += ", @" + QRECEIPT.TOTAL_AMOUNT + "@ \r\n ";
            q += ", @" + QRECEIPT.NOTES + "@ \r\n ";
            q += ", @" + QRECEIPT.ACTIVE_ID + "@ \r\n ";
            q += ", @" + QRECEIPT.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(QReceipt v, DAL dalsession)
        {
            string q = "UPDATE " + QRECEIPT.QRECEIPT_TBL + " SET";
            q += " " + QRECEIPT.UNIQUENO + " = @" + QRECEIPT.UNIQUENO + "@ \r\n ";
            q += "," + QRECEIPT.COMPANY_ID + " = @" + QRECEIPT.COMPANY_ID + "@ \r\n ";
            q += "," + QRECEIPT.ACY_ID + " = @" + QRECEIPT.ACY_ID + "@ \r\n ";
            q += "," + QRECEIPT.QRECEIPT_NO + " = @" + QRECEIPT.QRECEIPT_NO + "@ \r\n ";
            q += "," + QRECEIPT.QRECEIPT_DATE + " = @" + QRECEIPT.QRECEIPT_DATE + "@ \r\n ";
            q += "," + QRECEIPT.PARTY_ID + " = @" + QRECEIPT.PARTY_ID + "@ \r\n ";
            q += "," + QRECEIPT.RECEIPTTYPE_ID + " = @" + QRECEIPT.RECEIPTTYPE_ID + "@ \r\n ";
            q += "," + QRECEIPT.CHEQ_NO + " = @" + QRECEIPT.CHEQ_NO + "@ \r\n ";
            q += "," + QRECEIPT.QRECEIPT_AMOUNT + " = @" + QRECEIPT.QRECEIPT_AMOUNT + "@ \r\n ";
            q += "," + QRECEIPT.CHEQ_DATE + " = @" + QRECEIPT.CHEQ_DATE + "@ \r\n ";
            q += "," + QRECEIPT.BANK_ID + " = @" + QRECEIPT.BANK_ID + "@ \r\n ";
            q += "," + QRECEIPT.TOTAL_AMOUNT + " = @" + QRECEIPT.TOTAL_AMOUNT + "@ \r\n ";
            q += "," + QRECEIPT.NOTES + " = @" + QRECEIPT.NOTES + "@ \r\n ";
            q += "," + QRECEIPT.ACTIVE_ID + " = @" + QRECEIPT.ACTIVE_ID + "@ \r\n ";
            q += "," + QRECEIPT.USER_ID + " = @" + QRECEIPT.USER_ID + "@ \r\n ";
            q += "  WHERE " + QRECEIPT.QRECEIPT_ID + " = @" + QRECEIPT.QRECEIPT_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + QRECEIPT.QRECEIPT_TBL + " WHERE " + QRECEIPT.QRECEIPT_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
