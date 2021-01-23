// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 11:17:33 PM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXCORE
{
    public class CCity_exten
    {
         #region[Entity Data]

        private static City EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                 while (redr.Read() == true)
                 {
                    City obj = new City()
                    {
                        City_id = redr[CITY.CITY_ID].ToString(),
                        City_name = redr[CITY.CITY_NAME].ToString(),
                        Notes = redr[CITY.NOTES].ToString(),
                        Active_id = redr[CITY.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                        };
                    return obj;
                 }
            redr.Close();
            return new City();
            }
        }

        #endregion[Entity Data]

         #region[Entity List]

         private static List<City> EntityList(string q)
         {
             List<City> list = new List<City>();

             using (IDataReader redr = new DAL().Listreader(q))
             {
                 while (redr.Read() == true)
                 {
                      City obj = new City()
                     {
                        City_id = redr[CITY.CITY_ID].ToString(),
                        City_name = redr[CITY.CITY_NAME].ToString(),
                        Notes = redr[CITY.NOTES].ToString(),
                        Active_id = redr[CITY.ACTIVE_ID].ToString(),
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

         public static List<City> Active(DAL DAL)
         {
            string q = " SELECT " + CITY.CITY_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + CITY.CITY_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + CITY.CITY_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + CITY.CITY_TBL + "." + CITY.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + CITY.CITY_TBL + "." + CITY.CITY_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + CITY.CITY_TBL + "." + CITY.CITY_NAME + ";\r\n";

             return EntityList(q);
         }

         #endregion[Active]

         #region[NotActive]

         public static List<City> NotActive(DAL DAL)
         {
            string q = " SELECT " + CITY.CITY_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + CITY.CITY_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + CITY.CITY_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + CITY.CITY_TBL + "." + CITY.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + CITY.CITY_TBL + "." + CITY.CITY_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + CITY.CITY_TBL + "." + CITY.CITY_NAME + ";\r\n";

             return EntityList(q);
         }

         #endregion[NotActive]

         #region[Primary Key]

         public static City PKId(string v, DAL DAL)
         {
            string q = " SELECT " + CITY.CITY_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + CITY.CITY_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + CITY.CITY_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + CITY.CITY_TBL + "." + CITY.CITY_ID + "  = '" + v + "' \r\n";

             return EntityData(q);
         }

         #endregion[Primary Key]

         #region[Search by name]

         public static City SearchName(string v, DAL DAL)
         {
            string q = " SELECT " + CITY.CITY_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + CITY.CITY_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + CITY.CITY_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + CITY.CITY_TBL + "." + CITY.CITY_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + CITY.CITY_TBL + "." + CITY.CITY_NAME + ";\r\n";

             return EntityData(q);
         }

         #endregion[Search by name]

         #region[Look up]

         public static DataTable GetforLookup(DAL DAL)
         {
            string q = " SELECT " + CITY.CITY_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + CITY.CITY_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + CITY.CITY_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + CITY.CITY_TBL + "." + CITY.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + CITY.CITY_TBL + "." + CITY.CITY_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + CITY.CITY_TBL + "." + CITY.CITY_NAME + ";\r\n";

             return DAL.Listdata(q);
         }

         #endregion[Look up]

        #region[Get id - Name]

         public static string GetName_Id(string _pId)
        {
            City obj = PKId(_pId, new DAL());

             if (obj != null)
            {
                return obj.City_name;
            }
            return "";
        }

         public static string GetId_Name(string _pName)
        {
            City obj = SearchName(_pName, new DAL());

             if (obj != null)
            {
                return obj.City_id;
            }
            return "";
        }

         #endregion[Get id - Name]

    }//cls
}//ns
