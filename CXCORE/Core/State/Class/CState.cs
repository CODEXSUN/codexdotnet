// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:15:52 AM

using CXLIB;

namespace CXCORE
{
    public class CState
    {

        #region[Get New]

        public static State GetNew
        {
            get
            {
                State obj = new State()
                {
                    State_id = string.Empty,
                    State_name = string.Empty,
                    State_code = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, State v)
        {
            q = q.Replace("@" + STATE.STATE_ID + "@", "" + ConvertTO.SqlString(v.State_id) + "");
            q = q.Replace("@" + STATE.STATE_NAME + "@", "" + ConvertTO.SqlString(v.State_name) + "");
            q = q.Replace("@" + STATE.STATE_CODE + "@", "" + ConvertTO.SqlString(v.State_code) + "");
            q = q.Replace("@" + STATE.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + STATE.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + STATE.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(State v, DAL dalsession)
        {
            string q = " INSERT INTO " + STATE.STATE_TBL + " ( ";
            q += " " + STATE.STATE_NAME + " \r\n ";
            q += "," + STATE.STATE_CODE + " \r\n ";
            q += "," + STATE.NOTES + " \r\n ";
            q += "," + STATE.ACTIVE_ID + " \r\n ";
            q += "," + STATE.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + STATE.STATE_NAME + "@ \r\n ";
            q += ", @" + STATE.STATE_CODE + "@ \r\n ";
            q += ", @" + STATE.NOTES + "@ \r\n ";
            q += ", @" + STATE.ACTIVE_ID + "@ \r\n ";
            q += ", @" + STATE.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(State v, DAL dalsession)
        {
            string q = "UPDATE " + STATE.STATE_TBL + " SET";
            q += " " + STATE.STATE_NAME + " = @" + STATE.STATE_NAME + "@ \r\n ";
            q += "," + STATE.STATE_CODE + " = @" + STATE.STATE_CODE + "@ \r\n ";
            q += "," + STATE.NOTES + " = @" + STATE.NOTES + "@ \r\n ";
            q += "," + STATE.ACTIVE_ID + " = @" + STATE.ACTIVE_ID + "@ \r\n ";
            q += "," + STATE.USER_ID + " = @" + STATE.USER_ID + "@ \r\n ";
            q += "  WHERE " + STATE.STATE_ID + " = @" + STATE.STATE_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + STATE.STATE_TBL + " WHERE " + STATE.STATE_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
