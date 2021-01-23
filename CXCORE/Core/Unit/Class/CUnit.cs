// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:23:08 AM

using CXLIB;

namespace CXCORE
{
    public class CUnit
    {

        #region[Get New]

        public static Unit GetNew
        {
            get
            {
                Unit obj = new Unit()
                {
                    Unit_id = string.Empty,
                    Unit_name = string.Empty,
                    Unit_desc = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Unit v)
        {
            q = q.Replace("@" + UNIT.UNIT_ID + "@", "" + ConvertTO.SqlString(v.Unit_id) + "");
            q = q.Replace("@" + UNIT.UNIT_NAME + "@", "" + ConvertTO.SqlString(v.Unit_name) + "");
            q = q.Replace("@" + UNIT.UNIT_DESC + "@", "" + ConvertTO.SqlString(v.Unit_desc) + "");
            q = q.Replace("@" + UNIT.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + UNIT.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + UNIT.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Unit v, DAL dalsession)
        {
            string q = " INSERT INTO " + UNIT.UNIT_TBL + " ( ";
            q += " " + UNIT.UNIT_NAME + " \r\n ";
            q += "," + UNIT.UNIT_DESC + " \r\n ";
            q += "," + UNIT.NOTES + " \r\n ";
            q += "," + UNIT.ACTIVE_ID + " \r\n ";
            q += "," + UNIT.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + UNIT.UNIT_NAME + "@ \r\n ";
            q += ", @" + UNIT.UNIT_DESC + "@ \r\n ";
            q += ", @" + UNIT.NOTES + "@ \r\n ";
            q += ", @" + UNIT.ACTIVE_ID + "@ \r\n ";
            q += ", @" + UNIT.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Unit v, DAL dalsession)
        {
            string q = "UPDATE " + UNIT.UNIT_TBL + " SET";
            q += " " + UNIT.UNIT_NAME + " = @" + UNIT.UNIT_NAME + "@ \r\n ";
            q += "," + UNIT.UNIT_DESC + " = @" + UNIT.UNIT_DESC + "@ \r\n ";
            q += "," + UNIT.NOTES + " = @" + UNIT.NOTES + "@ \r\n ";
            q += "," + UNIT.ACTIVE_ID + " = @" + UNIT.ACTIVE_ID + "@ \r\n ";
            q += "," + UNIT.USER_ID + " = @" + UNIT.USER_ID + "@ \r\n ";
            q += "  WHERE " + UNIT.UNIT_ID + " = @" + UNIT.UNIT_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + UNIT.UNIT_TBL + " WHERE " + UNIT.UNIT_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
