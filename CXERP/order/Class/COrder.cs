// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 14-06-2019 09:02:20 PM

using CXLIB;

namespace CXERP
{
    public static class COrder
    {

        #region[Get New]

        public static Order GetNew
        {
            get
            {
                Order obj = new Order()
                {
                    Order_id = string.Empty,
                    Uniqueno = string.Empty,
                    Company_id = Current.Company_id,
                    Acy_id = Current.Acy_id,
                    Order_no = string.Empty,
                    Order_date = string.Empty,
                    Ordertype_id = string.Empty,
                    Party_id = string.Empty,
                    Party_ref = string.Empty,
                    Style_ref = string.Empty,
                    Refered_no = string.Empty,
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

        private static string AttachParams(string q, Order v)
        {
            q = q.Replace("@" + ORDER.ORDER_ID + "@", "" + ConvertTO.SqlString(v.Order_id) + "");
            q = q.Replace("@" + ORDER.UNIQUENO + "@", "" + ConvertTO.SqlString(v.Uniqueno) + "");
            q = q.Replace("@" + ORDER.COMPANY_ID + "@", "" + ConvertTO.SqlString(v.Company_id) + "");
            q = q.Replace("@" + ORDER.ACY_ID + "@", "" + ConvertTO.SqlString(v.Acy_id) + "");
            q = q.Replace("@" + ORDER.ORDER_NO + "@", "" + ConvertTO.SqlString(v.Order_no) + "");
            q = q.Replace("@" + ORDER.ORDER_DATE + "@", "" + ConvertTO.SqlDate(v.Order_date) + "");
            q = q.Replace("@" + ORDER.ORDERTYPE_ID + "@", "" + ConvertTO.SqlString(v.Ordertype_id) + "");
            q = q.Replace("@" + ORDER.PARTY_ID + "@", "" + ConvertTO.SqlString(v.Party_id) + "");
            q = q.Replace("@" + ORDER.PARTY_REF + "@", "" + ConvertTO.SqlString(v.Party_ref) + "");
            q = q.Replace("@" + ORDER.STYLE_REF + "@", "" + ConvertTO.SqlString(v.Style_ref) + "");
            q = q.Replace("@" + ORDER.REFERED_NO + "@", "" + ConvertTO.SqlString(v.Refered_no) + "");
            q = q.Replace("@" + ORDER.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            q = q.Replace("@" + ORDER.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + ORDER.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + ORDER.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Order v, DAL dalsession)
        {
                string q = " INSERT INTO " + ORDER.ORDER_TBL + " ( ";
                q += " " + ORDER.UNIQUENO + "\r\n";
                q += "," + ORDER.COMPANY_ID + "\r\n";
                q += "," + ORDER.ACY_ID + "\r\n";
                q += "," + ORDER.ORDER_NO + " \r\n";
                q += "," + ORDER.ORDER_DATE + " \r\n";
                q += "," + ORDER.ORDERTYPE_ID + " \r\n";
                q += "," + ORDER.PARTY_ID + " \r\n";
                q += "," + ORDER.PARTY_REF + " \r\n";
                q += "," + ORDER.STYLE_REF + " \r\n";
                q += "," + ORDER.REFERED_NO + " \r\n";
                q += "," + ORDER.LOCKED + " \r\n";
                q += "," + ORDER.NOTES + " \r\n";
                q += "," + ORDER.ACTIVE_ID + " \r\n";
                q += "," + ORDER.USER_ID + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @" + ORDER.UNIQUENO + "@ \r\n";
                q += ", @" + ORDER.COMPANY_ID + "@ \r\n";
                q += ", @" + ORDER.ACY_ID + "@ \r\n";
                q += ", @"+ ORDER.ORDER_NO + "@ \r\n";
                q += ", @"+ ORDER.ORDER_DATE + "@ \r\n";
                q += ", @"+ ORDER.ORDERTYPE_ID + "@ \r\n";
                q += ", @"+ ORDER.PARTY_ID + "@ \r\n";
                q += ", @"+ ORDER.PARTY_REF + "@ \r\n";
                q += ", @"+ ORDER.STYLE_REF + "@ \r\n";
                q += ", @"+ ORDER.REFERED_NO + "@ \r\n";
                q += ", @"+ ORDER.LOCKED + "@ \r\n";
                q += ", @"+ ORDER.NOTES + "@ \r\n";
                q += ", @"+ ORDER.ACTIVE_ID + "@ \r\n";
                q += ", @"+ ORDER.USER_ID + "@ \r\n";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Order v, DAL dalsession)
        {
                string q = "UPDATE " + ORDER.ORDER_TBL + " SET";
                q += " " + ORDER.UNIQUENO + " = @" + ORDER.UNIQUENO + "@ \r\n";
                q += "," + ORDER.COMPANY_ID + " = @" + ORDER.COMPANY_ID + "@ \r\n";
                q += "," + ORDER.ACY_ID + " = @" + ORDER.ACY_ID + "@ \r\n";
                q += "," + ORDER.ORDER_NO + " = @" + ORDER.ORDER_NO + "@ \r\n ";
                q += "," + ORDER.ORDER_DATE + " = @" + ORDER.ORDER_DATE + "@ \r\n ";
                q += "," + ORDER.ORDERTYPE_ID + " = @" + ORDER.ORDERTYPE_ID + "@ \r\n ";
                q += "," + ORDER.PARTY_ID + " = @" + ORDER.PARTY_ID + "@ \r\n ";
                q += "," + ORDER.PARTY_REF + " = @" + ORDER.PARTY_REF + "@ \r\n ";
                q += "," + ORDER.STYLE_REF + " = @" + ORDER.STYLE_REF + "@ \r\n ";
                q += "," + ORDER.REFERED_NO + " = @" + ORDER.REFERED_NO + "@ \r\n ";
                q += "," + ORDER.LOCKED + " = @" + ORDER.LOCKED + "@ \r\n ";
                q += "," + ORDER.NOTES + " = @" + ORDER.NOTES + "@ \r\n ";
                q += "," + ORDER.ACTIVE_ID + " = @" + ORDER.ACTIVE_ID + "@ \r\n ";
                q += "," + ORDER.USER_ID + " = @" + ORDER.USER_ID + "@ \r\n ";
                q += "  WHERE " + ORDER.ORDER_ID + " = @" + ORDER.ORDER_ID + "@ ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + ORDER.ORDER_TBL+ " WHERE " + ORDER.ORDER_ID + " =  " + pkid +";");
        }
        #endregion[Delete]

    }//cls
}//ns
