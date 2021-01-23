// Version : 4.0.0.2 Date : 10-08-2020
// Auto Generated
// last update : 10-08-2020 07:17:10 PM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXCORE
{
    public class CCompany_exten
    {
         #region[Entity Data]

        private static Company EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                 while (redr.Read() == true)
                 {
                    Company obj = new Company()
                    {
                        Company_id = redr[COMPANY.COMPANY_ID].ToString(),
                        Company_name = redr[COMPANY.COMPANY_NAME].ToString(),
                        Display_name = redr[COMPANY.DISPLAY_NAME].ToString(),
                        Street1 = redr[COMPANY.STREET1].ToString(),
                        Street2 = redr[COMPANY.STREET2].ToString(),
                        City_id = redr[CITY.CITY_NAME].ToString(),
                        State_id = redr[STATE.STATE_NAME].ToString(),
                        Country_id = redr[COUNTRY.COUNTRY_NAME].ToString(),
                        Pincode_id = redr[PINCODE.PINCODE_NAME].ToString(),
                        Cell1 = redr[COMPANY.CELL1].ToString(),
                        Cell2 = redr[COMPANY.CELL2].ToString(),
                        Phone = redr[COMPANY.PHONE].ToString(),
                        Email = redr[COMPANY.EMAIL].ToString(),
                        Website = redr[COMPANY.WEBSITE].ToString(),
                        Gstin = redr[COMPANY.GST].ToString(),
                        Pan = redr[COMPANY.PAN].ToString(),
                        Comp_code = redr[COMPANY.COMP_CODE].ToString(),
                        Notes = redr[COMPANY.NOTES].ToString(),
                        Active_id = redr[COMPANY.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                        };
                    return obj;
                 }
            redr.Close();
            return new Company();
            }
        }

        #endregion[Entity Data]

         #region[Entity List]

         private static List<Company> EntityList(string q)
         {
             List<Company> list = new List<Company>();

             using (IDataReader redr = new DAL().Listreader(q))
             {
                 while (redr.Read() == true)
                 {
                      Company obj = new Company()
                     {
                        Company_id = redr[COMPANY.COMPANY_ID].ToString(),
                        Company_name = redr[COMPANY.COMPANY_NAME].ToString(),
                        Display_name = redr[COMPANY.DISPLAY_NAME].ToString(),
                        Street1 = redr[COMPANY.STREET1].ToString(),
                        Street2 = redr[COMPANY.STREET2].ToString(),
                        City_id = redr[CITY.CITY_NAME].ToString(),
                        State_id = redr[STATE.STATE_NAME].ToString(),
                        Country_id = redr[COUNTRY.COUNTRY_NAME].ToString(),
                        Pincode_id = redr[PINCODE.PINCODE_NAME].ToString(),
                        Cell1 = redr[COMPANY.CELL1].ToString(),
                        Cell2 = redr[COMPANY.CELL2].ToString(),
                        Phone = redr[COMPANY.PHONE].ToString(),
                        Email = redr[COMPANY.EMAIL].ToString(),
                        Website = redr[COMPANY.WEBSITE].ToString(),
                        Gstin = redr[COMPANY.GST].ToString(),
                        Pan = redr[COMPANY.PAN].ToString(),
                        Comp_code = redr[COMPANY.COMP_CODE].ToString(),
                        Notes = redr[COMPANY.NOTES].ToString(),
                        Active_id = redr[COMPANY.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                     };

                     list.Add(obj);
                 }

             redr.Close();
             }
             return list;
         }

         #endregion[Entity List]

         #region[Active]

         public static List<Company> Active()
         {
            string q = " SELECT " + COMPANY.COMPANY_TBL + ".* \r\n";
            q += ", " + CITY.CITY_TBL + "." + CITY.CITY_NAME + " \r\n";
            q += ", " + STATE.STATE_TBL + "." + STATE.STATE_NAME + " \r\n";
            q += ", " + COUNTRY.COUNTRY_TBL + "." + COUNTRY.COUNTRY_NAME + " \r\n";
            q += ", " + PINCODE.PINCODE_TBL + "." + PINCODE.PINCODE_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + COMPANY.COMPANY_TBL + " \r\n";
            q += " INNER JOIN  " + CITY.CITY_TBL + " \r\n";
            q += " ON( " + COMPANY.COMPANY_TBL + "." + CITY.CITY_ID + " = " + CITY.CITY_TBL+ "." +CITY.CITY_ID + ")\r\n";
            q += " INNER JOIN  " + STATE.STATE_TBL + " \r\n";
            q += " ON( " + COMPANY.COMPANY_TBL + "." + STATE.STATE_ID + " = " + STATE.STATE_TBL+ "." +STATE.STATE_ID + ")\r\n";
            q += " INNER JOIN  " + COUNTRY.COUNTRY_TBL + " \r\n";
            q += " ON( " + COMPANY.COMPANY_TBL + "." + COUNTRY.COUNTRY_ID + " = " + COUNTRY.COUNTRY_TBL+ "." +COUNTRY.COUNTRY_ID + ")\r\n";
            q += " INNER JOIN  " + PINCODE.PINCODE_TBL + " \r\n";
            q += " ON( " + COMPANY.COMPANY_TBL + "." + PINCODE.PINCODE_ID + " = " + PINCODE.PINCODE_TBL+ "." +PINCODE.PINCODE_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + COMPANY.COMPANY_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + COMPANY.COMPANY_TBL + "." + COMPANY.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + COMPANY.COMPANY_TBL + "." + COMPANY.COMPANY_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + COMPANY.COMPANY_TBL + "." + COMPANY.COMPANY_NAME + ";\r\n";

             return EntityList(q);
         }

         #endregion[Active]

         #region[NotActive]

         public static List<Company> NotActive()
         {
            string q = " SELECT " + COMPANY.COMPANY_TBL + ".* \r\n";
            q += ", " + CITY.CITY_TBL + "." + CITY.CITY_NAME + " \r\n";
            q += ", " + STATE.STATE_TBL + "." + STATE.STATE_NAME + " \r\n";
            q += ", " + COUNTRY.COUNTRY_TBL + "." + COUNTRY.COUNTRY_NAME + " \r\n";
            q += ", " + PINCODE.PINCODE_TBL + "." + PINCODE.PINCODE_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + COMPANY.COMPANY_TBL + " \r\n";
            q += " INNER JOIN  " + CITY.CITY_TBL + " \r\n";
            q += " ON( " + COMPANY.COMPANY_TBL + "." + CITY.CITY_ID + " = " + CITY.CITY_TBL+ "." +CITY.CITY_ID + ")\r\n";
            q += " INNER JOIN  " + STATE.STATE_TBL + " \r\n";
            q += " ON( " + COMPANY.COMPANY_TBL + "." + STATE.STATE_ID + " = " + STATE.STATE_TBL+ "." +STATE.STATE_ID + ")\r\n";
            q += " INNER JOIN  " + COUNTRY.COUNTRY_TBL + " \r\n";
            q += " ON( " + COMPANY.COMPANY_TBL + "." + COUNTRY.COUNTRY_ID + " = " + COUNTRY.COUNTRY_TBL+ "." +COUNTRY.COUNTRY_ID + ")\r\n";
            q += " INNER JOIN  " + PINCODE.PINCODE_TBL + " \r\n";
            q += " ON( " + COMPANY.COMPANY_TBL + "." + PINCODE.PINCODE_ID + " = " + PINCODE.PINCODE_TBL+ "." +PINCODE.PINCODE_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + COMPANY.COMPANY_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + COMPANY.COMPANY_TBL + "." + COMPANY.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + COMPANY.COMPANY_TBL + "." + COMPANY.COMPANY_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + COMPANY.COMPANY_TBL + "." + COMPANY.COMPANY_NAME + ";\r\n";

             return EntityList(q);
         }

         #endregion[NotActive]

         #region[Primary Key]

         public static Company PKId(string v)
         {
            string q = " SELECT " + COMPANY.COMPANY_TBL + ".* \r\n";
            q += ", " + CITY.CITY_TBL + "." + CITY.CITY_NAME + " \r\n";
            q += ", " + STATE.STATE_TBL + "." + STATE.STATE_NAME + " \r\n";
            q += ", " + COUNTRY.COUNTRY_TBL + "." + COUNTRY.COUNTRY_NAME + " \r\n";
            q += ", " + PINCODE.PINCODE_TBL + "." + PINCODE.PINCODE_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + COMPANY.COMPANY_TBL + " \r\n";
            q += " INNER JOIN  " + CITY.CITY_TBL + " \r\n";
            q += " ON( " + COMPANY.COMPANY_TBL + "." + CITY.CITY_ID + " = " + CITY.CITY_TBL+ "." +CITY.CITY_ID + ")\r\n";
            q += " INNER JOIN  " + STATE.STATE_TBL + " \r\n";
            q += " ON( " + COMPANY.COMPANY_TBL + "." + STATE.STATE_ID + " = " + STATE.STATE_TBL+ "." +STATE.STATE_ID + ")\r\n";
            q += " INNER JOIN  " + COUNTRY.COUNTRY_TBL + " \r\n";
            q += " ON( " + COMPANY.COMPANY_TBL + "." + COUNTRY.COUNTRY_ID + " = " + COUNTRY.COUNTRY_TBL+ "." +COUNTRY.COUNTRY_ID + ")\r\n";
            q += " INNER JOIN  " + PINCODE.PINCODE_TBL + " \r\n";
            q += " ON( " + COMPANY.COMPANY_TBL + "." + PINCODE.PINCODE_ID + " = " + PINCODE.PINCODE_TBL+ "." +PINCODE.PINCODE_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + COMPANY.COMPANY_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + COMPANY.COMPANY_TBL + "." + COMPANY.COMPANY_ID + "  = '" + v + "' \r\n";

             return EntityData(q);
         }

         #endregion[Primary Key]

         #region[Search by name]

         public static Company SearchName(string v)
         {
            string q = " SELECT " + COMPANY.COMPANY_TBL + ".* \r\n";
            q += ", " + CITY.CITY_TBL + "." + CITY.CITY_NAME + " \r\n";
            q += ", " + STATE.STATE_TBL + "." + STATE.STATE_NAME + " \r\n";
            q += ", " + COUNTRY.COUNTRY_TBL + "." + COUNTRY.COUNTRY_NAME + " \r\n";
            q += ", " + PINCODE.PINCODE_TBL + "." + PINCODE.PINCODE_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + COMPANY.COMPANY_TBL + " \r\n";
            q += " INNER JOIN  " + CITY.CITY_TBL + " \r\n";
            q += " ON( " + COMPANY.COMPANY_TBL + "." + CITY.CITY_ID + " = " + CITY.CITY_TBL+ "." +CITY.CITY_ID + ")\r\n";
            q += " INNER JOIN  " + STATE.STATE_TBL + " \r\n";
            q += " ON( " + COMPANY.COMPANY_TBL + "." + STATE.STATE_ID + " = " + STATE.STATE_TBL+ "." +STATE.STATE_ID + ")\r\n";
            q += " INNER JOIN  " + COUNTRY.COUNTRY_TBL + " \r\n";
            q += " ON( " + COMPANY.COMPANY_TBL + "." + COUNTRY.COUNTRY_ID + " = " + COUNTRY.COUNTRY_TBL+ "." +COUNTRY.COUNTRY_ID + ")\r\n";
            q += " INNER JOIN  " + PINCODE.PINCODE_TBL + " \r\n";
            q += " ON( " + COMPANY.COMPANY_TBL + "." + PINCODE.PINCODE_ID + " = " + PINCODE.PINCODE_TBL+ "." +PINCODE.PINCODE_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + COMPANY.COMPANY_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + COMPANY.COMPANY_TBL + "." + COMPANY.COMPANY_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + COMPANY.COMPANY_TBL + "." + COMPANY.COMPANY_NAME + ";\r\n";

             return EntityData(q);
         }

         #endregion[Search by name]

         #region[Look up]

         public static DataTable GetforLookup()
         {
            string q = " SELECT " + COMPANY.COMPANY_TBL + ".* \r\n";
            q += ", " + CITY.CITY_TBL + "." + CITY.CITY_NAME + " \r\n";
            q += ", " + STATE.STATE_TBL + "." + STATE.STATE_NAME + " \r\n";
            q += ", " + COUNTRY.COUNTRY_TBL + "." + COUNTRY.COUNTRY_NAME + " \r\n";
            q += ", " + PINCODE.PINCODE_TBL + "." + PINCODE.PINCODE_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + COMPANY.COMPANY_TBL + " \r\n";
            q += " INNER JOIN  " + CITY.CITY_TBL + " \r\n";
            q += " ON( " + COMPANY.COMPANY_TBL + "." + CITY.CITY_ID + " = " + CITY.CITY_TBL+ "." +CITY.CITY_ID + ")\r\n";
            q += " INNER JOIN  " + STATE.STATE_TBL + " \r\n";
            q += " ON( " + COMPANY.COMPANY_TBL + "." + STATE.STATE_ID + " = " + STATE.STATE_TBL+ "." +STATE.STATE_ID + ")\r\n";
            q += " INNER JOIN  " + COUNTRY.COUNTRY_TBL + " \r\n";
            q += " ON( " + COMPANY.COMPANY_TBL + "." + COUNTRY.COUNTRY_ID + " = " + COUNTRY.COUNTRY_TBL+ "." +COUNTRY.COUNTRY_ID + ")\r\n";
            q += " INNER JOIN  " + PINCODE.PINCODE_TBL + " \r\n";
            q += " ON( " + COMPANY.COMPANY_TBL + "." + PINCODE.PINCODE_ID + " = " + PINCODE.PINCODE_TBL+ "." +PINCODE.PINCODE_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + COMPANY.COMPANY_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + COMPANY.COMPANY_TBL + "." + COMPANY.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + COMPANY.COMPANY_TBL + "." + COMPANY.COMPANY_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + COMPANY.COMPANY_TBL + "." + COMPANY.COMPANY_NAME + ";\r\n";

             return new DAL().Listdata(q);
         }

         #endregion[Look up]

        #region[Get id - Name]

         public static string GetName_Id(string v)
        {
            Company obj = PKId(v);

             if (obj != null)
            {
                return obj.Company_name;
            }
            return "";
        }

         public static string GetId_Name(string v)
        {
            Company obj = SearchName(v);

             if (obj != null)
            {
                return obj.Company_id;
            }
            return "";
        }

        public static string GetCode_id(string v)
        {
            Company obj = PKId(v);

            if (obj != null)
            {
                return obj.Comp_code;
            }
            return "";
        }

        #endregion[Get id - Name]

    }//cls
}//ns
