// Version : 5.0.0.0 Date : 27-01-2021
// Auto Generated
// last update : 28-01-2021 10:30:12 PM

using CXLIB;

namespace CXERP
{
    public static class CInward
    {

        #region[Get New]

        public static Inward GetNew
        {
            get
            {
                Inward obj = new Inward()
                {
                    Inward_id = string.Empty,
                    Uniqueno = string.Empty,
                    Company_id = Current.Company_id,
                    Acy_id = Current.Acy_id,
                    Order_id = string.Empty,
                    Inward_no = string.Empty,
                    Inward_date = string.Empty,
                    Party_dcno = string.Empty,
                    Party_id = string.Empty,
                    Total_bundel = string.Empty,
                    Total_qty = string.Empty,
                    Refered_qty = string.Empty,
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

        private static string AttachParams(string q, Inward v)
        {
            q = q.Replace("@" + INWARD.INWARD_ID + "@", "" + ConvertTO.SqlString(v.Inward_id) + "");
            q = q.Replace("@" + INWARD.UNIQUENO + "@", "" + ConvertTO.SqlString(v.Uniqueno) + "");
            q = q.Replace("@" + INWARD.COMPANY_ID + "@", "" + ConvertTO.SqlString(v.Company_id) + "");
            q = q.Replace("@" + INWARD.ACY_ID + "@", "" + ConvertTO.SqlString(v.Acy_id) + "");
            q = q.Replace("@" + INWARD.ORDER_ID + "@", "" + ConvertTO.SqlString(v.Order_id) + "");
            q = q.Replace("@" + INWARD.INWARD_NO + "@", "" + ConvertTO.SqlString(v.Inward_no) + "");
            q = q.Replace("@" + INWARD.INWARD_DATE + "@", "" + ConvertTO.SqlDate(v.Inward_date) + "");
            q = q.Replace("@" + INWARD.PARTY_DCNO + "@", "" + ConvertTO.SqlString(v.Party_dcno) + "");
            q = q.Replace("@" + INWARD.PARTY_ID + "@", "" + ConvertTO.SqlString(v.Party_id) + "");
            q = q.Replace("@" + INWARD.TOTAL_BUNDEL + "@", "" + ConvertTO.SqlString(v.Total_bundel) + "");
            q = q.Replace("@" + INWARD.TOTAL_QTY + "@", "" + ConvertTO.SqlString(v.Total_qty) + "");
            q = q.Replace("@" + INWARD.REFERED_QTY + "@", "" + ConvertTO.SqlString(v.Refered_qty) + "");
            q = q.Replace("@" + INWARD.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            q = q.Replace("@" + INWARD.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + INWARD.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + INWARD.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Inward v, DAL dalsession)
        {
                string q = " INSERT INTO " + INWARD.INWARD_TBL + " ( ";
                q += " " + INWARD.UNIQUENO + "\r\n";
                q += "," + INWARD.COMPANY_ID + "\r\n";
                q += "," + INWARD.ACY_ID + "\r\n";
                q += "," + INWARD.ORDER_ID + " \r\n";
                q += "," + INWARD.INWARD_NO + " \r\n";
                q += "," + INWARD.INWARD_DATE + " \r\n";
                q += "," + INWARD.PARTY_DCNO + " \r\n";
                q += "," + INWARD.PARTY_ID + " \r\n";
                q += "," + INWARD.TOTAL_BUNDEL + " \r\n";
                q += "," + INWARD.TOTAL_QTY + " \r\n";
                q += "," + INWARD.REFERED_QTY + " \r\n";
                q += "," + INWARD.LOCKED + " \r\n";
                q += "," + INWARD.NOTES + " \r\n";
                q += "," + INWARD.ACTIVE_ID + " \r\n";
                q += "," + INWARD.USER_ID + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @" + INWARD.UNIQUENO + "@ \r\n";
                q += ", @" + INWARD.COMPANY_ID + "@ \r\n";
                q += ", @" + INWARD.ACY_ID + "@ \r\n";
                q += ", @"+ INWARD.ORDER_ID + "@ \r\n";
                q += ", @"+ INWARD.INWARD_NO + "@ \r\n";
                q += ", @"+ INWARD.INWARD_DATE + "@ \r\n";
                q += ", @"+ INWARD.PARTY_DCNO + "@ \r\n";
                q += ", @"+ INWARD.PARTY_ID + "@ \r\n";
                q += ", @"+ INWARD.TOTAL_BUNDEL + "@ \r\n";
                q += ", @"+ INWARD.TOTAL_QTY + "@ \r\n";
                q += ", @"+ INWARD.REFERED_QTY + "@ \r\n";
                q += ", @"+ INWARD.LOCKED + "@ \r\n";
                q += ", @"+ INWARD.NOTES + "@ \r\n";
                q += ", @"+ INWARD.ACTIVE_ID + "@ \r\n";
                q += ", @"+ INWARD.USER_ID + "@ \r\n";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Inward v, DAL dalsession)
        {
                string q = "UPDATE " + INWARD.INWARD_TBL + " SET";
                q += " " + INWARD.UNIQUENO + " = @" + INWARD.UNIQUENO + "@ \r\n";
                q += "," + INWARD.COMPANY_ID + " = @" + INWARD.COMPANY_ID + "@ \r\n";
                q += "," + INWARD.ACY_ID + " = @" + INWARD.ACY_ID + "@ \r\n";
                q += "," + INWARD.ORDER_ID + " = @" + INWARD.ORDER_ID + "@ \r\n ";
                q += "," + INWARD.INWARD_NO + " = @" + INWARD.INWARD_NO + "@ \r\n ";
                q += "," + INWARD.INWARD_DATE + " = @" + INWARD.INWARD_DATE + "@ \r\n ";
                q += "," + INWARD.PARTY_DCNO + " = @" + INWARD.PARTY_DCNO + "@ \r\n ";
                q += "," + INWARD.PARTY_ID + " = @" + INWARD.PARTY_ID + "@ \r\n ";
                q += "," + INWARD.TOTAL_BUNDEL + " = @" + INWARD.TOTAL_BUNDEL + "@ \r\n ";
                q += "," + INWARD.TOTAL_QTY + " = @" + INWARD.TOTAL_QTY + "@ \r\n ";
                q += "," + INWARD.REFERED_QTY + " = @" + INWARD.REFERED_QTY + "@ \r\n ";
                q += "," + INWARD.LOCKED + " = @" + INWARD.LOCKED + "@ \r\n ";
                q += "," + INWARD.NOTES + " = @" + INWARD.NOTES + "@ \r\n ";
                q += "," + INWARD.ACTIVE_ID + " = @" + INWARD.ACTIVE_ID + "@ \r\n ";
                q += "," + INWARD.USER_ID + " = @" + INWARD.USER_ID + "@ \r\n ";
                q += "  WHERE " + INWARD.INWARD_ID + " = @" + INWARD.INWARD_ID + "@ ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + INWARD.INWARD_TBL+ " WHERE " + INWARD.INWARD_ID + " =  " + pkid +";");
        }
        #endregion[Delete]

    }//cls
}//ns
