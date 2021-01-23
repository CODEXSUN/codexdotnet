// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 10-08-2020 10:29:15 AM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXCORE
{
    public class CVersion_exten
    {
         #region[Entity Data]

        private static Version EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                 while (redr.Read() == true)
                 {
                    Version obj = new Version()
                    {
                        Version_id = redr[VERSION.VERSION_ID].ToString(),
                        Version_name = redr[VERSION.VERSION_NAME].ToString(),
                        Created_on = redr[VERSION.CREATED_ON].ToString(),
                        Changes = redr[VERSION.CHANGES].ToString(),
                        Notes = redr[VERSION.NOTES].ToString(),
                        Active_id = redr[VERSION.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                        };
                    return obj;
                 }
            redr.Close();
            return new Version();
            }
        }

        #endregion[Entity Data]

         #region[Entity List]

         private static List<Version> EntityList(string q)
         {
             List<Version> list = new List<Version>();

             using (IDataReader redr = new DAL().Listreader(q))
             {
                 while (redr.Read() == true)
                 {
                      Version obj = new Version()
                     {
                        Version_id = redr[VERSION.VERSION_ID].ToString(),
                        Version_name = redr[VERSION.VERSION_NAME].ToString(),
                        Created_on = redr[VERSION.CREATED_ON].ToString(),
                        Changes = redr[VERSION.CHANGES].ToString(),
                        Notes = redr[VERSION.NOTES].ToString(),
                        Active_id = redr[VERSION.ACTIVE_ID].ToString(),
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

         public static List<Version> Active()
         {
            string q = " SELECT " + VERSION.VERSION_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + VERSION.VERSION_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + VERSION.VERSION_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + VERSION.VERSION_TBL + "." + VERSION.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + VERSION.VERSION_TBL + "." + VERSION.VERSION_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + VERSION.VERSION_TBL + "." + VERSION.VERSION_NAME + ";\r\n";

             return EntityList(q);
         }

         #endregion[Active]

         #region[NotActive]

         public static List<Version> NotActive()
         {
            string q = " SELECT " + VERSION.VERSION_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + VERSION.VERSION_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + VERSION.VERSION_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + VERSION.VERSION_TBL + "." + VERSION.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + VERSION.VERSION_TBL + "." + VERSION.VERSION_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + VERSION.VERSION_TBL + "." + VERSION.VERSION_NAME + ";\r\n";

             return EntityList(q);
         }

         #endregion[NotActive]

         #region[Primary Key]

         public static Version PKId(string v)
         {
            string q = " SELECT " + VERSION.VERSION_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + VERSION.VERSION_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + VERSION.VERSION_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + VERSION.VERSION_TBL + "." + VERSION.VERSION_ID + "  = '" + v + "' \r\n";

             return EntityData(q);
         }

         #endregion[Primary Key]

         #region[Search by name]

         public static Version SearchName(string v)
         {
            string q = " SELECT " + VERSION.VERSION_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + VERSION.VERSION_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + VERSION.VERSION_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + VERSION.VERSION_TBL + "." + VERSION.VERSION_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + VERSION.VERSION_TBL + "." + VERSION.VERSION_NAME + ";\r\n";

             return EntityData(q);
         }

         #endregion[Search by name]

         #region[Look up]

         public static DataTable GetforLookup()
         {
            string q = " SELECT " + VERSION.VERSION_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + VERSION.VERSION_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + VERSION.VERSION_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + VERSION.VERSION_TBL + "." + VERSION.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + VERSION.VERSION_TBL + "." + VERSION.VERSION_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + VERSION.VERSION_TBL + "." + VERSION.VERSION_NAME + ";\r\n";

             return new DAL().Listdata(q);
         }

         #endregion[Look up]

        #region[Get id - Name]

         public static string GetName_Id(string v)
        {
            Version obj = PKId(v);

             if (obj != null)
            {
                return obj.Version_name;
            }
            return "";
        }

         public static string GetId_Name(string v)
        {
            Version obj = SearchName(v);

             if (obj != null)
            {
                return obj.Version_id;
            }
            return "";
        }

         #endregion[Get id - Name]

    }//cls
}//ns
