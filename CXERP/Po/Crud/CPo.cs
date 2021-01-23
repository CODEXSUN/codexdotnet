// Version : 4.0.0.2 Date : 10-08-2020
// Auto Generated
// last update : 23-01-2021 08:39:04 PM

using CXLIB;

namespace CXERP
{
    public static class CPo
    {

        #region[Get New]

        public static Po GetNew
        {
            get
            {
                Po obj = new Po()
                {
                    Po_id = string.Empty,
                    Po_no = string.Empty,
                    Po_date = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Po v)
        {
            q = q.Replace("@" + PO.PO_ID + "@", "" + ConvertTO.SqlString(v.Po_id) + "");
            q = q.Replace("@" + PO.PO_NO + "@", "" + ConvertTO.SqlString(v.Po_no) + "");
            q = q.Replace("@" + PO.PO_DATE + "@", "" + ConvertTO.SqlDate(v.Po_date) + "");
            q = q.Replace("@" + PO.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + PO.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + PO.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Po v, DAL dalsession)
        {
            string q = " INSERT INTO " + PO.PO_TBL + " ( ";
            q += " " + PO.PO_NO + " \r\n ";
            q += "," + PO.PO_DATE + " \r\n ";
            q += "," + PO.NOTES + " \r\n ";
            q += "," + PO.ACTIVE_ID + " \r\n ";
            q += "," + PO.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + PO.PO_NO + "@ \r\n ";
                q += ", @" + PO.PO_DATE + "@ \r\n ";
            q += ", @" + PO.NOTES + "@ \r\n ";
            q += ", @" + PO.ACTIVE_ID + "@ \r\n ";
            q += ", @" + PO.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Po v, DAL dalsession)
        {
            string q = "UPDATE " + PO.PO_TBL + " SET";
            q += " " + PO.PO_NO + " = @" + PO.PO_NO + "@ \r\n ";
            q += "," + PO.PO_DATE + " = @" + PO.PO_DATE + "@ \r\n ";
            q += "," + PO.NOTES + " = @" + PO.NOTES + "@ \r\n ";
            q += "," + PO.ACTIVE_ID + " = @" + PO.ACTIVE_ID + "@ \r\n ";
            q += "," + PO.USER_ID + " = @" + PO.USER_ID + "@ \r\n ";
            q += "  WHERE " + PO.PO_ID + " = @" + PO.PO_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + PO.PO_TBL + " WHERE " + PO.PO_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
