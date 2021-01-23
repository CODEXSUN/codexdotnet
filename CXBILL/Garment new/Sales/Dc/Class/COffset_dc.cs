// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 22-11-2017 11:59:45 AM

using CXLIB;

namespace CXBILL
{
    public class COffset_dc
    {

        #region[Get New]

        public static Offset_dc GetNew
        {
            get
            {
                Offset_dc obj = new Offset_dc()
                {
                    Offset_dc_id = string.Empty,
                    Unqiueno = string.Empty,
                    Company_id = Current.Company_id,
                    Acy_id = Current.Acy_id,
                    Offset_dc_no = COffset_dc_exten.GetNext_No,
                    Offset_dc_date = string.Empty,
                    Party_id = string.Empty,
                    Total_qty = string.Empty,
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

        private static string AttachParams(string q, Offset_dc v)
        {
            q = q.Replace("@" + OFFSET_DC.OFFSET_DC_ID + "@", "" + ConvertTO.SqlString(v.Offset_dc_id) + "");
            q = q.Replace("@" + OFFSET_DC.UNIQUENO + "@", "" + ConvertTO.SqlString(v.Unqiueno) + "");
            q = q.Replace("@" + OFFSET_DC.COMPANY_ID + "@", "" + ConvertTO.SqlString(v.Company_id) + "");
            q = q.Replace("@" + OFFSET_DC.ACY_ID + "@", "" + ConvertTO.SqlString(v.Acy_id) + "");
            q = q.Replace("@" + OFFSET_DC.OFFSET_DC_NO + "@", "" + ConvertTO.SqlString(v.Offset_dc_no) + "");
            q = q.Replace("@" + OFFSET_DC.OFFSET_DC_DATE + "@", "" + ConvertTO.SqlDate(v.Offset_dc_date) + "");
            q = q.Replace("@" + OFFSET_DC.PARTY_ID + "@", "" + ConvertTO.SqlString(v.Party_id) + "");
            q = q.Replace("@" + OFFSET_DC.TOTAL_QTY + "@", "" + ConvertTO.SqlString(v.Total_qty) + "");
            q = q.Replace("@" + OFFSET_DC.REFERED_NO + "@", "" + ConvertTO.SqlString(v.Refered_no) + "");
            q = q.Replace("@" + OFFSET_DC.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            q = q.Replace("@" + OFFSET_DC.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + OFFSET_DC.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + OFFSET_DC.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Offset_dc v, DAL dalsession)
        {
            string q = " INSERT INTO " + OFFSET_DC.OFFSET_DC_TBL + " ( ";
            q += " " + OFFSET_DC.UNIQUENO + " \r\n ";
            q += "," + OFFSET_DC.COMPANY_ID + " \r\n ";
            q += "," + OFFSET_DC.ACY_ID + " \r\n ";
            q += "," + OFFSET_DC.OFFSET_DC_NO + " \r\n ";
            q += "," + OFFSET_DC.OFFSET_DC_DATE + " \r\n ";
            q += "," + OFFSET_DC.PARTY_ID + " \r\n ";
            q += "," + OFFSET_DC.TOTAL_QTY + " \r\n ";
            q += "," + OFFSET_DC.REFERED_NO + " \r\n ";
            q += "," + OFFSET_DC.LOCKED + " \r\n ";
            q += "," + OFFSET_DC.NOTES + " \r\n ";
            q += "," + OFFSET_DC.ACTIVE_ID + " \r\n ";
            q += "," + OFFSET_DC.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + OFFSET_DC.UNIQUENO + "@ \r\n ";
            q += ", @" + OFFSET_DC.COMPANY_ID + "@ \r\n ";
            q += ", @" + OFFSET_DC.ACY_ID + "@ \r\n ";
            q += ", @" + OFFSET_DC.OFFSET_DC_NO + "@ \r\n ";
            q += ", @" + OFFSET_DC.OFFSET_DC_DATE + "@ \r\n ";
            q += ", @" + OFFSET_DC.PARTY_ID + "@ \r\n ";
            q += ", @" + OFFSET_DC.TOTAL_QTY + "@ \r\n ";
            q += ", @" + OFFSET_DC.REFERED_NO + "@ \r\n ";
            q += ", @" + OFFSET_DC.LOCKED + "@ \r\n ";
            q += ", @" + OFFSET_DC.NOTES + "@ \r\n ";
            q += ", @" + OFFSET_DC.ACTIVE_ID + "@ \r\n ";
            q += ", @" + OFFSET_DC.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Offset_dc v, DAL dalsession)
        {
            string q = "UPDATE " + OFFSET_DC.OFFSET_DC_TBL + " SET";
            q += " " + OFFSET_DC.UNIQUENO + " = @" + OFFSET_DC.UNIQUENO + "@ \r\n ";
            q += "," + OFFSET_DC.COMPANY_ID + " = @" + OFFSET_DC.COMPANY_ID + "@ \r\n ";
            q += "," + OFFSET_DC.ACY_ID + " = @" + OFFSET_DC.ACY_ID + "@ \r\n ";
            q += "," + OFFSET_DC.OFFSET_DC_NO + " = @" + OFFSET_DC.OFFSET_DC_NO + "@ \r\n ";
            q += "," + OFFSET_DC.OFFSET_DC_DATE + " = @" + OFFSET_DC.OFFSET_DC_DATE + "@ \r\n ";
            q += "," + OFFSET_DC.PARTY_ID + " = @" + OFFSET_DC.PARTY_ID + "@ \r\n ";
            q += "," + OFFSET_DC.TOTAL_QTY + " = @" + OFFSET_DC.TOTAL_QTY + "@ \r\n ";
            q += "," + OFFSET_DC.REFERED_NO + " = @" + OFFSET_DC.REFERED_NO + "@ \r\n ";
            q += "," + OFFSET_DC.LOCKED + " = @" + OFFSET_DC.LOCKED + "@ \r\n ";
            q += "," + OFFSET_DC.NOTES + " = @" + OFFSET_DC.NOTES + "@ \r\n ";
            q += "," + OFFSET_DC.ACTIVE_ID + " = @" + OFFSET_DC.ACTIVE_ID + "@ \r\n ";
            q += "," + OFFSET_DC.USER_ID + " = @" + OFFSET_DC.USER_ID + "@ \r\n ";
            q += "  WHERE " + OFFSET_DC.OFFSET_DC_ID + " = @" + OFFSET_DC.OFFSET_DC_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + OFFSET_DC.OFFSET_DC_TBL + " WHERE " + OFFSET_DC.OFFSET_DC_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
