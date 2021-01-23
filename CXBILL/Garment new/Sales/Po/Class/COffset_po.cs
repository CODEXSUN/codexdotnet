// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 22-11-2017 11:59:45 AM

using CXLIB;

namespace CXBILL
{
    public class COffset_po
    {

        #region[Get New]

        public static Offset_po GetNew
        {
            get
            {
                Offset_po obj = new Offset_po()
                {
                    Offset_po_id = string.Empty,
                    Uniqueno = string.Empty,
                    Company_id = Current.Company_id,
                    Acy_id = Current.Acy_id,
                    Offset_po_no = string.Empty,
                    Offset_po_date = string.Empty,
                    Party_id = string.Empty,
                    Party_po_ref = string.Empty,
                    Delivery_date = string.Empty,
                    Total_qty = string.Empty,
                    Total_amount = string.Empty,
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

        private static string AttachParams(string q, Offset_po v)
        {
            q = q.Replace("@" + OFFSET_PO.OFFSET_PO_ID + "@", "" + ConvertTO.SqlString(v.Offset_po_id) + "");
            q = q.Replace("@" + OFFSET_PO.UNIQUENO + "@", "" + ConvertTO.SqlString(v.Uniqueno) + "");
            q = q.Replace("@" + OFFSET_PO.COMPANY_ID + "@", "" + ConvertTO.SqlString(v.Company_id) + "");
            q = q.Replace("@" + OFFSET_PO.ACY_ID + "@", "" + ConvertTO.SqlString(v.Acy_id) + "");
            q = q.Replace("@" + OFFSET_PO.OFFSET_PO_NO + "@", "" + ConvertTO.SqlString(v.Offset_po_no) + "");
            q = q.Replace("@" + OFFSET_PO.OFFSET_PO_DATE + "@", "" + ConvertTO.SqlDate(v.Offset_po_date) + "");
            q = q.Replace("@" + OFFSET_PO.PARTY_ID + "@", "" + ConvertTO.SqlString(v.Party_id) + "");
            q = q.Replace("@" + OFFSET_PO.PARTY_PO_REF + "@", "" + ConvertTO.SqlString(v.Party_po_ref) + "");
            q = q.Replace("@" + OFFSET_PO.DELIVERY_DATE + "@", "" + ConvertTO.SqlDate(v.Delivery_date) + "");
            q = q.Replace("@" + OFFSET_PO.TOTAL_QTY + "@", "" + ConvertTO.SqlString(v.Total_qty) + "");
            q = q.Replace("@" + OFFSET_PO.TOTAL_AMOUNT + "@", "" + ConvertTO.SqlString(v.Total_amount) + "");
            q = q.Replace("@" + OFFSET_PO.REFERED_NO + "@", "" + ConvertTO.SqlString(v.Refered_no) + "");
            q = q.Replace("@" + OFFSET_PO.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            q = q.Replace("@" + OFFSET_PO.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + OFFSET_PO.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + OFFSET_PO.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Offset_po v, DAL dalsession)
        {
            string q = " INSERT INTO " + OFFSET_PO.OFFSET_PO_TBL + " ( ";
            q += " " + OFFSET_PO.UNIQUENO + " \r\n ";
            q += "," + OFFSET_PO.COMPANY_ID + " \r\n ";
            q += "," + OFFSET_PO.ACY_ID + " \r\n ";
            q += "," + OFFSET_PO.OFFSET_PO_NO + " \r\n ";
            q += "," + OFFSET_PO.OFFSET_PO_DATE + " \r\n ";
            q += "," + OFFSET_PO.PARTY_ID + " \r\n ";
            q += "," + OFFSET_PO.PARTY_PO_REF + " \r\n ";
            q += "," + OFFSET_PO.DELIVERY_DATE + " \r\n ";
            q += "," + OFFSET_PO.TOTAL_QTY + " \r\n ";
            q += "," + OFFSET_PO.TOTAL_AMOUNT + " \r\n ";
            q += "," + OFFSET_PO.REFERED_NO + " \r\n ";
            q += "," + OFFSET_PO.LOCKED + " \r\n ";
            q += "," + OFFSET_PO.NOTES + " \r\n ";
            q += "," + OFFSET_PO.ACTIVE_ID + " \r\n ";
            q += "," + OFFSET_PO.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + OFFSET_PO.UNIQUENO + "@ \r\n ";
            q += ", @" + OFFSET_PO.COMPANY_ID + "@ \r\n ";
            q += ", @" + OFFSET_PO.ACY_ID + "@ \r\n ";
            q += ", @" + OFFSET_PO.OFFSET_PO_NO + "@ \r\n ";
            q += ", @" + OFFSET_PO.OFFSET_PO_DATE + "@ \r\n ";
            q += ", @" + OFFSET_PO.PARTY_ID + "@ \r\n ";
            q += ", @" + OFFSET_PO.PARTY_PO_REF + "@ \r\n ";
            q += ", @" + OFFSET_PO.DELIVERY_DATE + "@ \r\n ";
            q += ", @" + OFFSET_PO.TOTAL_QTY + "@ \r\n ";
            q += ", @" + OFFSET_PO.TOTAL_AMOUNT + "@ \r\n ";
            q += ", @" + OFFSET_PO.REFERED_NO + "@ \r\n ";
            q += ", @" + OFFSET_PO.LOCKED + "@ \r\n ";
            q += ", @" + OFFSET_PO.NOTES + "@ \r\n ";
            q += ", @" + OFFSET_PO.ACTIVE_ID + "@ \r\n ";
            q += ", @" + OFFSET_PO.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Offset_po v, DAL dalsession)
        {
            string q = "UPDATE " + OFFSET_PO.OFFSET_PO_TBL + " SET";
            q += " " + OFFSET_PO.UNIQUENO + " = @" + OFFSET_PO.UNIQUENO + "@ \r\n ";
            q += "," + OFFSET_PO.COMPANY_ID + " = @" + OFFSET_PO.COMPANY_ID + "@ \r\n ";
            q += "," + OFFSET_PO.ACY_ID + " = @" + OFFSET_PO.ACY_ID + "@ \r\n ";
            q += "," + OFFSET_PO.OFFSET_PO_NO + " = @" + OFFSET_PO.OFFSET_PO_NO + "@ \r\n ";
            q += "," + OFFSET_PO.OFFSET_PO_DATE + " = @" + OFFSET_PO.OFFSET_PO_DATE + "@ \r\n ";
            q += "," + OFFSET_PO.PARTY_ID + " = @" + OFFSET_PO.PARTY_ID + "@ \r\n ";
            q += "," + OFFSET_PO.PARTY_PO_REF + " = @" + OFFSET_PO.PARTY_PO_REF + "@ \r\n ";
            q += "," + OFFSET_PO.DELIVERY_DATE + " = @" + OFFSET_PO.DELIVERY_DATE + "@ \r\n ";
            q += "," + OFFSET_PO.TOTAL_QTY + " = @" + OFFSET_PO.TOTAL_QTY + "@ \r\n ";
            q += "," + OFFSET_PO.TOTAL_AMOUNT + " = @" + OFFSET_PO.TOTAL_AMOUNT + "@ \r\n ";
            q += "," + OFFSET_PO.REFERED_NO + " = @" + OFFSET_PO.REFERED_NO + "@ \r\n ";
            q += "," + OFFSET_PO.LOCKED + " = @" + OFFSET_PO.LOCKED + "@ \r\n ";
            q += "," + OFFSET_PO.NOTES + " = @" + OFFSET_PO.NOTES + "@ \r\n ";
            q += "," + OFFSET_PO.ACTIVE_ID + " = @" + OFFSET_PO.ACTIVE_ID + "@ \r\n ";
            q += "," + OFFSET_PO.USER_ID + " = @" + OFFSET_PO.USER_ID + "@ \r\n ";
            q += "  WHERE " + OFFSET_PO.OFFSET_PO_ID + " = @" + OFFSET_PO.OFFSET_PO_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + OFFSET_PO.OFFSET_PO_TBL + " WHERE " + OFFSET_PO.OFFSET_PO_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
