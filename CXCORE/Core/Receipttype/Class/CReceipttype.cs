// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:07:41 AM

using CXLIB;

namespace CXCORE
{
    public class CReceipttype
    {

        #region[Get New]

        public static Receipttype GetNew
        {
            get
            {
                Receipttype obj = new Receipttype()
                {
                    Receipttype_id = string.Empty,
                    Receipttype_name = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Receipttype v)
        {
            q = q.Replace("@" + RECEIPTTYPE.RECEIPTTYPE_ID + "@", "" + ConvertTO.SqlString(v.Receipttype_id) + "");
            q = q.Replace("@" + RECEIPTTYPE.RECEIPTTYPE_NAME + "@", "" + ConvertTO.SqlString(v.Receipttype_name) + "");
            q = q.Replace("@" + RECEIPTTYPE.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + RECEIPTTYPE.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + RECEIPTTYPE.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Receipttype v, DAL dalsession)
        {
            string q = " INSERT INTO " + RECEIPTTYPE.RECEIPTTYPE_TBL + " ( ";
            q += " " + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n ";
            q += "," + RECEIPTTYPE.NOTES + " \r\n ";
            q += "," + RECEIPTTYPE.ACTIVE_ID + " \r\n ";
            q += "," + RECEIPTTYPE.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + RECEIPTTYPE.RECEIPTTYPE_NAME + "@ \r\n ";
            q += ", @" + RECEIPTTYPE.NOTES + "@ \r\n ";
            q += ", @" + RECEIPTTYPE.ACTIVE_ID + "@ \r\n ";
            q += ", @" + RECEIPTTYPE.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Receipttype v, DAL dalsession)
        {
            string q = "UPDATE " + RECEIPTTYPE.RECEIPTTYPE_TBL + " SET";
            q += " " + RECEIPTTYPE.RECEIPTTYPE_NAME + " = @" + RECEIPTTYPE.RECEIPTTYPE_NAME + "@ \r\n ";
            q += "," + RECEIPTTYPE.NOTES + " = @" + RECEIPTTYPE.NOTES + "@ \r\n ";
            q += "," + RECEIPTTYPE.ACTIVE_ID + " = @" + RECEIPTTYPE.ACTIVE_ID + "@ \r\n ";
            q += "," + RECEIPTTYPE.USER_ID + " = @" + RECEIPTTYPE.USER_ID + "@ \r\n ";
            q += "  WHERE " + RECEIPTTYPE.RECEIPTTYPE_ID + " = @" + RECEIPTTYPE.RECEIPTTYPE_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + RECEIPTTYPE.RECEIPTTYPE_TBL + " WHERE " + RECEIPTTYPE.RECEIPTTYPE_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
