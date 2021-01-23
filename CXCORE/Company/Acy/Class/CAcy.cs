// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 11:02:33 PM

using CXLIB;

namespace CXCORE
{
    public class CAcy
    {

        #region[Get New]

        public static Acy GetNew
        {
            get
            {
                Acy obj = new Acy()
                {
                    Acy_id = string.Empty,
                    Acy_name = string.Empty,
                    Acy_desc = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Acy v)
        {
            q = q.Replace("@" + ACY.ACY_ID + "@", "" + ConvertTO.SqlString(v.Acy_id) + "");
            q = q.Replace("@" + ACY.ACY_NAME + "@", "" + ConvertTO.SqlString(v.Acy_name) + "");
            q = q.Replace("@" + ACY.ACY_DESC + "@", "" + ConvertTO.SqlString(v.Acy_desc) + "");
            q = q.Replace("@" + ACY.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + ACY.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + ACY.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Acy v, DAL dalsession)
        {
            string q = " INSERT INTO " + ACY.ACY_TBL + " ( ";
            q += " " + ACY.ACY_NAME + " \r\n ";
            q += "," + ACY.ACY_DESC + " \r\n ";
            q += "," + ACY.NOTES + " \r\n ";
            q += "," + ACY.ACTIVE_ID + " \r\n ";
            q += "," + ACY.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + ACY.ACY_NAME + "@ \r\n ";
            q += ", @" + ACY.ACY_DESC + "@ \r\n ";
            q += ", @" + ACY.NOTES + "@ \r\n ";
            q += ", @" + ACY.ACTIVE_ID + "@ \r\n ";
            q += ", @" + ACY.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Acy v, DAL dalsession)
        {
            string q = "UPDATE " + ACY.ACY_TBL + " SET";
            q += " " + ACY.ACY_NAME + " = @" + ACY.ACY_NAME + "@ \r\n ";
            q += "," + ACY.ACY_DESC + " = @" + ACY.ACY_DESC + "@ \r\n ";
            q += "," + ACY.NOTES + " = @" + ACY.NOTES + "@ \r\n ";
            q += "," + ACY.ACTIVE_ID + " = @" + ACY.ACTIVE_ID + "@ \r\n ";
            q += "," + ACY.USER_ID + " = @" + ACY.USER_ID + "@ \r\n ";
            q += "  WHERE " + ACY.ACY_ID + " = @" + ACY.ACY_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + ACY.ACY_TBL + " WHERE " + ACY.ACY_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
