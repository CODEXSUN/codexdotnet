// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 07-08-2020 01:34:46 PM

using System; 
using System.Data; 
using CXLIB; 
using CXCORE; 

namespace CXCORE
{
    public static class U_Company
    {
        #region[]

            public static void GetUpdated(string OldDB)
            {

                string tablename = COMPANY.COMPANY_TBL;

                int count = GetCount(tablename, OldDB);

                for (int i = 1; i <= count; i++)
                {
                    var obj = GetOldData(i, OldDB);

                if (obj != null)
                {
                    InsertData(obj);
                }
                }
            }

        #endregion[]

        #region[Get Count]

            private static int GetCount(string tablename, string OldDB)
            {
                string ID = (tablename.Remove((tablename).Length - 4).ToUpper()) + "_ID";

                string q = "USE " + OldDB + "; ";
                q += "SELECT * FROM " + tablename + " ORDER BY " + ID + " DESC LIMIT 1 ; ";

                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        int lastId = Convert.ToInt32(redr[ID]);

                        return lastId;
                    }
                    return 0;
                }
            }

        #endregion[Get Count]

        #region[Get Old data]

            private static Company GetOldData(int id, string OldDB)
            {
                string q = "USE " + OldDB + "; ";
                q += "SELECT * FROM " + COMPANY.COMPANY_TBL + " WHERE " + COMPANY.COMPANY_ID + " = '" + id + "'; ";

                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        Company obj = new Company
                        {
                        Company_name = redr[COMPANY.COMPANY_NAME].ToString(),
                        Display_name = redr[COMPANY.DISPLAY_NAME].ToString(),
                        Street1 = redr[COMPANY.STREET1].ToString(),
                        Street2 = redr[COMPANY.STREET2].ToString(),
                        City_id = redr[COMPANY.CITY_ID].ToString(),
                        State_id = redr[COMPANY.STATE_ID].ToString(),
                        Country_id = redr[COMPANY.COUNTRY_ID].ToString(),
                        Pincode_id = redr[COMPANY.PINCODE_ID].ToString(),
                        Cell1 = redr[COMPANY.CELL1].ToString(),
                        Cell2 = redr[COMPANY.CELL2].ToString(),
                        Phone = redr[COMPANY.PHONE].ToString(),
                        Email = redr[COMPANY.EMAIL].ToString(),
                        Website = redr[COMPANY.WEBSITE].ToString(),
                        Gst = redr[COMPANY.GST].ToString(),
                        Pan = redr[COMPANY.PAN].ToString(),
                        Comp_code = "110",
                        Notes = redr[COMPANY.NOTES].ToString(),
                        Active_id = redr[COMPANY.ACTIVE_ID].ToString(),
                        User_id = "1"
                        };

                        return obj;
                    }
                    return null;
                }
            }

        #endregion[Get Old data]

#region[Check data]

            private static bool CheckData(Company obj)
            {
                string q = "USE CODEXSUN_DB; ";
                q += "SELECT * FROM " + COMPANY.COMPANY_TBL + " WHERE " + COMPANY.COMPANY_NAME + " = '" + obj.Company_name + "'; ";

                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        obj.Company_id = redr[COMPANY.COMPANY_ID].ToString();

                        CCompany.Update(obj, new DAL());

                        return true;
                    }
                    return false;
                }
            }
            #endregion[Check data]

        #region[Insert data]

            private static void InsertData(Company obj)
            {
                if (CheckData(obj) == false)
                {
                    //CCompany.Insert(obj, new DAL());
                };

            }
        #endregion[Insert data]

    }//cls
}//ns
