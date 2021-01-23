// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 14-06-2019 09:02:20 PM

using CXLIB;

namespace CXERP
{
    public static class CStyle
    {

        #region[Get New]

        public static Style GetNew
        {
            get
            {
                Style obj = new Style()
                {
                    Style_id = string.Empty,
                    Uniqueno = string.Empty,
                    Company_id = Current.Company_id,
                    Acy_id = Current.Acy_id,
                    Style_no = string.Empty,
                    Style_date = string.Empty,
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

        private static string AttachParams(string q, Style v)
        {
            q = q.Replace("@" + STYLE.STYLE_ID + "@", "" + ConvertTO.SqlString(v.Style_id) + "");
            q = q.Replace("@" + STYLE.UNIQUENO + "@", "" + ConvertTO.SqlString(v.Uniqueno) + "");
            q = q.Replace("@" + STYLE.COMPANY_ID + "@", "" + ConvertTO.SqlString(v.Company_id) + "");
            q = q.Replace("@" + STYLE.ACY_ID + "@", "" + ConvertTO.SqlString(v.Acy_id) + "");
            q = q.Replace("@" + STYLE.STYLE_NO + "@", "" + ConvertTO.SqlString(v.Style_no) + "");
            q = q.Replace("@" + STYLE.STYLE_DATE + "@", "" + ConvertTO.SqlDate(v.Style_date) + "");
            q = q.Replace("@" + STYLE.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            q = q.Replace("@" + STYLE.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + STYLE.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + STYLE.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Style v, DAL dalsession)
        {
                string q = " INSERT INTO " + STYLE.STYLE_TBL + " ( ";
                q += " " + STYLE.UNIQUENO + "\r\n";
                q += "," + STYLE.COMPANY_ID + "\r\n";
                q += "," + STYLE.ACY_ID + "\r\n";
                q += "," + STYLE.STYLE_NO + " \r\n";
                q += "," + STYLE.STYLE_DATE + " \r\n";
                q += "," + STYLE.LOCKED + " \r\n";
                q += "," + STYLE.NOTES + " \r\n";
                q += "," + STYLE.ACTIVE_ID + " \r\n";
                q += "," + STYLE.USER_ID + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @" + STYLE.UNIQUENO + "@ \r\n";
                q += ", @" + STYLE.COMPANY_ID + "@ \r\n";
                q += ", @" + STYLE.ACY_ID + "@ \r\n";
                q += ", @"+ STYLE.STYLE_NO + "@ \r\n";
                q += ", @"+ STYLE.STYLE_DATE + "@ \r\n";
                q += ", @"+ STYLE.LOCKED + "@ \r\n";
                q += ", @"+ STYLE.NOTES + "@ \r\n";
                q += ", @"+ STYLE.ACTIVE_ID + "@ \r\n";
                q += ", @"+ STYLE.USER_ID + "@ \r\n";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Style v, DAL dalsession)
        {
                string q = "UPDATE " + STYLE.STYLE_TBL + " SET";
                q += " " + STYLE.UNIQUENO + " = @" + STYLE.UNIQUENO + "@ \r\n";
                q += "," + STYLE.COMPANY_ID + " = @" + STYLE.COMPANY_ID + "@ \r\n";
                q += "," + STYLE.ACY_ID + " = @" + STYLE.ACY_ID + "@ \r\n";
                q += "," + STYLE.STYLE_NO + " = @" + STYLE.STYLE_NO + "@ \r\n ";
                q += "," + STYLE.STYLE_DATE + " = @" + STYLE.STYLE_DATE + "@ \r\n ";
                q += "," + STYLE.LOCKED + " = @" + STYLE.LOCKED + "@ \r\n ";
                q += "," + STYLE.NOTES + " = @" + STYLE.NOTES + "@ \r\n ";
                q += "," + STYLE.ACTIVE_ID + " = @" + STYLE.ACTIVE_ID + "@ \r\n ";
                q += "," + STYLE.USER_ID + " = @" + STYLE.USER_ID + "@ \r\n ";
                q += "  WHERE " + STYLE.STYLE_ID + " = @" + STYLE.STYLE_ID + "@ ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + STYLE.STYLE_TBL+ " WHERE " + STYLE.STYLE_ID + " =  " + pkid +";");
        }
        #endregion[Delete]

    }//cls
}//ns
