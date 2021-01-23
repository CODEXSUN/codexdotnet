// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 14-07-2020 08:21:36 AM

using CXLIB;

namespace CXCORE
{
    public static class CCompany
    {
        #region[Attach params]

        private static string AttachParams(string q, Company v)
        {
            q = q.Replace("@" + COMPANY.COMPANY_ID + "@", "" + ConvertTO.SqlString(v.Company_id) + "");
            q = q.Replace("@" + COMPANY.COMPANY_NAME + "@", "" + ConvertTO.SqlString(v.Company_name) + "");
            q = q.Replace("@" + COMPANY.DISPLAY_NAME + "@", "" + ConvertTO.SqlString(v.Display_name) + "");
            q = q.Replace("@" + COMPANY.STREET1 + "@", "" + ConvertTO.SqlString(v.Street1) + "");
            q = q.Replace("@" + COMPANY.STREET2 + "@", "" + ConvertTO.SqlString(v.Street2) + "");
            q = q.Replace("@" + COMPANY.CITY_ID + "@", "" + ConvertTO.SqlString(v.City_id) + "");
            q = q.Replace("@" + COMPANY.STATE_ID + "@", "" + ConvertTO.SqlString(v.State_id) + "");
            q = q.Replace("@" + COMPANY.COUNTRY_ID + "@", "" + ConvertTO.SqlString(v.Country_id) + "");
            q = q.Replace("@" + COMPANY.PINCODE_ID + "@", "" + ConvertTO.SqlString(v.Pincode_id) + "");
            q = q.Replace("@" + COMPANY.CELL1 + "@", "" + ConvertTO.SqlString(v.Cell1) + "");
            q = q.Replace("@" + COMPANY.CELL2 + "@", "" + ConvertTO.SqlString(v.Cell2) + "");
            q = q.Replace("@" + COMPANY.PHONE + "@", "" + ConvertTO.SqlString(v.Phone) + "");
            q = q.Replace("@" + COMPANY.EMAIL + "@", "" + ConvertTO.SqlString(v.Email) + "");
            q = q.Replace("@" + COMPANY.WEBSITE + "@", "" + ConvertTO.SqlString(v.Website) + "");
            q = q.Replace("@" + COMPANY.GST + "@", "" + ConvertTO.SqlString(v.Gst) + "");
            q = q.Replace("@" + COMPANY.PAN + "@", "" + ConvertTO.SqlString(v.Pan) + "");
            q = q.Replace("@" + COMPANY.COMP_CODE + "@", "" + ConvertTO.SqlString(v.Comp_code) + "");
            q = q.Replace("@" + COMPANY.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + COMPANY.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + COMPANY.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Update]

        public static void Update(Company v, DAL dalsession)
        {
            string q = "UPDATE " + COMPANY.COMPANY_TBL + " SET";
            q += " " + COMPANY.COMPANY_NAME + " = @" + COMPANY.COMPANY_NAME + "@ \r\n ";
            q += "," + COMPANY.DISPLAY_NAME + " = @" + COMPANY.DISPLAY_NAME + "@ \r\n ";
            q += "," + COMPANY.STREET1 + " = @" + COMPANY.STREET1 + "@ \r\n ";
            q += "," + COMPANY.STREET2 + " = @" + COMPANY.STREET2 + "@ \r\n ";
            q += "," + COMPANY.CITY_ID + " = @" + COMPANY.CITY_ID + "@ \r\n ";
            q += "," + COMPANY.STATE_ID + " = @" + COMPANY.STATE_ID + "@ \r\n ";
            q += "," + COMPANY.COUNTRY_ID + " = @" + COMPANY.COUNTRY_ID + "@ \r\n ";
            q += "," + COMPANY.PINCODE_ID + " = @" + COMPANY.PINCODE_ID + "@ \r\n ";
            q += "," + COMPANY.CELL1 + " = @" + COMPANY.CELL1 + "@ \r\n ";
            q += "," + COMPANY.CELL2 + " = @" + COMPANY.CELL2 + "@ \r\n ";
            q += "," + COMPANY.PHONE + " = @" + COMPANY.PHONE + "@ \r\n ";
            q += "," + COMPANY.EMAIL + " = @" + COMPANY.EMAIL + "@ \r\n ";
            q += "," + COMPANY.WEBSITE + " = @" + COMPANY.WEBSITE + "@ \r\n ";
            q += "," + COMPANY.GST + " = @" + COMPANY.GST + "@ \r\n ";
            q += "," + COMPANY.PAN + " = @" + COMPANY.PAN + "@ \r\n ";
            q += "," + COMPANY.COMP_CODE + " = @" + COMPANY.COMP_CODE + "@ \r\n ";
            q += "," + COMPANY.NOTES + " = @" + COMPANY.NOTES + "@ \r\n ";
            q += "," + COMPANY.ACTIVE_ID + " = @" + COMPANY.ACTIVE_ID + "@ \r\n ";
            q += "," + COMPANY.USER_ID + " = @" + COMPANY.USER_ID + "@ \r\n ";
            q += "  WHERE " + COMPANY.COMPANY_ID + " = @" + COMPANY.COMPANY_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

    }//cls
}//ns
