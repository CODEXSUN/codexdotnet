// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2020 07.29.30 PM

using System.Data;
using CXLIB;
using System.Collections.Generic;
using CXCORE;

namespace AXCODE
{
    public static class CNamespaces_exten
    {
         #region[Entity Data]

        private static Namespaces EntityData(string q)
        {
            using (IDataReader redr = new SQLITE_DAL().Listreader(q))
            {
                 while (redr.Read() == true)
                 {
                    Namespaces obj = new Namespaces()
                    {
                        Namespaces_id = redr[NAMESPACES.NAMESPACES_ID].ToString(),
                        Namespaces_name = redr[NAMESPACES.NAMESPACES_NAME].ToString(),
                        Notes = redr[NAMESPACES.NOTES].ToString(),
                        Active_id = redr[NAMESPACES.ACTIVE_ID].ToString()
                        };
                    return obj;
                 }
            redr.Close();
            return new Namespaces();
            }
        }

        #endregion[Entity Data]

         #region[Entity List]

         private static List<Namespaces> EntityList(string q)
         {
             List<Namespaces> list = new List<Namespaces>();

             using (IDataReader redr = new SQLITE_DAL().Listreader(q))
             {
                 while (redr.Read() == true)
                 {
                      Namespaces obj = new Namespaces()
                     {
                        Namespaces_id = redr[NAMESPACES.NAMESPACES_ID].ToString(),
                        Namespaces_name = redr[NAMESPACES.NAMESPACES_NAME].ToString(),
                        Notes = redr[NAMESPACES.NOTES].ToString(),
                        Active_id = redr[NAMESPACES.ACTIVE_ID].ToString()
                     };

                     list.Add(obj);
                 }

             redr.Close();
             }
             return list;
         }

         #endregion[Entity List]

         #region[Active]

         public static List<Namespaces> Active()
         {
            string q = " SELECT " + NAMESPACES.NAMESPACES_TBL + ".* \r\n";
            q += " FROM  " + NAMESPACES.NAMESPACES_TBL + " \r\n";
            q += " WHERE " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_NAME + ";\r\n";

             return EntityList(q);
         }

         #endregion[Active]

         #region[NotActive]

         public static List<Namespaces> NotActive()
         {
            string q = " SELECT " + NAMESPACES.NAMESPACES_TBL + ".* \r\n";
            q += " FROM  " + NAMESPACES.NAMESPACES_TBL + " \r\n";
            q += " WHERE " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_NAME + ";\r\n";

             return EntityList(q);
         }

         #endregion[NotActive]

         #region[Primary Key]

         public static Namespaces PKId(string v)
         {
            string q = " SELECT " + NAMESPACES.NAMESPACES_TBL + ".* \r\n";
            q += " FROM  " + NAMESPACES.NAMESPACES_TBL + " \r\n";
            q += " WHERE " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_ID + "  = '" + v + "' \r\n";

             return EntityData(q);
         }

         #endregion[Primary Key]

         #region[Search by name]

         public static Namespaces SearchName(string v)
         {
            string q = " SELECT " + NAMESPACES.NAMESPACES_TBL + ".* \r\n";
            q += " FROM  " + NAMESPACES.NAMESPACES_TBL + " \r\n";
            q += " WHERE " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_NAME + ";\r\n";

             return EntityData(q);
         }

         #endregion[Search by name]

         #region[Look up]

         public static DataTable GetforLookup()
         {
            string q = " SELECT " + NAMESPACES.NAMESPACES_TBL + ".* \r\n";
            q += " FROM  " + NAMESPACES.NAMESPACES_TBL + " \r\n";
            q += " WHERE " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_NAME + ";\r\n";

             return new SQLITE_DAL().Listdata(q);
         }

         #endregion[Look up]

        #region[Get id - Name]

         public static string GetName_Id(string _pId)
        {
            Namespaces obj = PKId(_pId);

             if (obj != null)
            {
                return obj.Namespaces_name;
            }
            return "";
        }

         public static string GetId_Name(string _pName)
        {
            Namespaces obj = SearchName(_pName);

             if (obj != null)
            {
                return obj.Namespaces_id;
            }
            return "";
        }

         #endregion[Get id - Name]

    }//cls
}//ns
