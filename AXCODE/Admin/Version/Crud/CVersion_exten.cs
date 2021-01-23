// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 10-08-2020 10:29:15 AM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace AXCODE
{
    public static class CVersion_exten
    {
         #region[Entity Data]

        private static Version EntityData(string q)
        {
            using (IDataReader redr = new SQLITE_DAL().Listreader(q))
            {
                 while (redr.Read() == true)
                 {
                    Version obj = new Version()
                    {
                        Version_id = redr[VERSION.VERSION_ID].ToString(),
                        Version_name = redr[VERSION.VERSION_NAME].ToString(),
                        Created_on = redr[VERSION.CREATED_ON].ToString(),
                        Changes = redr[VERSION.CHANGES].ToString()
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

             using (IDataReader redr = new SQLITE_DAL().Listreader(q))
             {
                 while (redr.Read() == true)
                 {
                      Version obj = new Version()
                     {
                        Version_id = redr[VERSION.VERSION_ID].ToString(),
                        Version_name = redr[VERSION.VERSION_NAME].ToString(),
                        Created_on = redr[VERSION.CREATED_ON].ToString(),
                        Changes = redr[VERSION.CHANGES].ToString()
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
            string q = " SELECT * FROM " + VERSION.VERSION_TBL + " \r\n";
            q += " ORDER BY  " + VERSION.VERSION_TBL + "." + VERSION.VERSION_NAME + ";\r\n";

             return EntityList(q);
         }

         #endregion[Active]

         #region[NotActive]

         public static List<Version> NotActive()
         {
            string q = " SELECT * FROM " + VERSION.VERSION_TBL + " \r\n";
            q += " ORDER BY  " + VERSION.VERSION_TBL + "." + VERSION.VERSION_NAME + ";\r\n";

            return EntityList(q);
         }

         #endregion[NotActive]

         #region[Primary Key]

         public static Version PKId(string v)
         {
            string q = " SELECT * FROM " + VERSION.VERSION_TBL + " \r\n";
            q += " WHERE " + VERSION.VERSION_TBL + "." + VERSION.VERSION_ID + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + VERSION.VERSION_TBL + "." + VERSION.VERSION_NAME + ";\r\n";

            return EntityData(q);
         }

        #endregion[Primary Key]


        #region[Current Version]

        public static string  Get_Current_Version()
        {
                string q = " SELECT * FROM " + VERSION.VERSION_TBL + " \r\n";
                q += " ORDER BY  " + VERSION.VERSION_TBL + "." + VERSION.VERSION_ID + " DESC LIMIT 1;\r\n";


                Version obj = EntityData(q);

                if (obj != null)
                {
                    return "Version : " + obj.Version_name + " Date : " + obj.Created_on ;
                }

                return "Error in version"; 
        }

        #endregion[Primary Key]


        #region[Search by name]

        public static Version SearchName(string v)
         {

            string q = " SELECT * FROM " + VERSION.VERSION_TBL + " \r\n";
            q += " WHERE " + VERSION.VERSION_TBL + "." + VERSION.VERSION_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + VERSION.VERSION_TBL + "." + VERSION.VERSION_NAME + ";\r\n";

             return EntityData(q);
         }

         #endregion[Search by name]

         #region[Look up]

         public static DataTable GetforLookup()
         {

            string q = " SELECT * FROM " + VERSION.VERSION_TBL + " \r\n";
            q += " ORDER BY  " + VERSION.VERSION_TBL + "." + VERSION.VERSION_ID + ";\r\n";

            return new SQLITE_DAL().Listdata(q);
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
