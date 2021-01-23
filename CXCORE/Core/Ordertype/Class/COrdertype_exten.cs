// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 15-05-2019 06:44:13 PM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXCORE
{
    public class COrdertype_exten
    {
         #region[Entity Data]

        private static Ordertype EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                 while (redr.Read() == true)
                 {
                    Ordertype obj = new Ordertype()
                    {
                        Ordertype_id = redr[ORDERTYPE.ORDERTYPE_ID].ToString(),
                        Ordertype_name = redr[ORDERTYPE.ORDERTYPE_NAME].ToString(),
                        Notes = redr[ORDERTYPE.NOTES].ToString(),
                        Active_id = redr[ORDERTYPE.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                        };
                    return obj;
                 }
            redr.Close();
            return new Ordertype();
            }
        }

        #endregion[Entity Data]

         #region[Entity List]

         private static List<Ordertype> EntityList(string q)
         {
             List<Ordertype> list = new List<Ordertype>();

             using (IDataReader redr = new DAL().Listreader(q))
             {
                 while (redr.Read() == true)
                 {
                      Ordertype obj = new Ordertype()
                     {
                        Ordertype_id = redr[ORDERTYPE.ORDERTYPE_ID].ToString(),
                        Ordertype_name = redr[ORDERTYPE.ORDERTYPE_NAME].ToString(),
                        Notes = redr[ORDERTYPE.NOTES].ToString(),
                        Active_id = redr[ORDERTYPE.ACTIVE_ID].ToString(),
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

         public static List<Ordertype> Active(DAL DAL)
         {
            string q = " SELECT " + ORDERTYPE.ORDERTYPE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ORDERTYPE.ORDERTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ORDERTYPE.ORDERTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ORDERTYPE.ORDERTYPE_TBL + "." + ORDERTYPE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + ORDERTYPE.ORDERTYPE_TBL + "." + ORDERTYPE.ORDERTYPE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + ORDERTYPE.ORDERTYPE_TBL + "." + ORDERTYPE.ORDERTYPE_NAME + ";\r\n";

             return EntityList(q);
         }

         #endregion[Active]

         #region[NotActive]

         public static List<Ordertype> NotActive(DAL DAL)
         {
            string q = " SELECT " + ORDERTYPE.ORDERTYPE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ORDERTYPE.ORDERTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ORDERTYPE.ORDERTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ORDERTYPE.ORDERTYPE_TBL + "." + ORDERTYPE.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + ORDERTYPE.ORDERTYPE_TBL + "." + ORDERTYPE.ORDERTYPE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + ORDERTYPE.ORDERTYPE_TBL + "." + ORDERTYPE.ORDERTYPE_NAME + ";\r\n";

             return EntityList(q);
         }

         #endregion[NotActive]

         #region[Primary Key]

         public static Ordertype PKId(string v, DAL DAL)
         {
            string q = " SELECT " + ORDERTYPE.ORDERTYPE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ORDERTYPE.ORDERTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ORDERTYPE.ORDERTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ORDERTYPE.ORDERTYPE_TBL + "." + ORDERTYPE.ORDERTYPE_ID + "  = '" + v + "' \r\n";

             return EntityData(q);
         }

         #endregion[Primary Key]

         #region[Search by name]

         public static Ordertype SearchName(string v, DAL DAL)
         {
            string q = " SELECT " + ORDERTYPE.ORDERTYPE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ORDERTYPE.ORDERTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ORDERTYPE.ORDERTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ORDERTYPE.ORDERTYPE_TBL + "." + ORDERTYPE.ORDERTYPE_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + ORDERTYPE.ORDERTYPE_TBL + "." + ORDERTYPE.ORDERTYPE_NAME + ";\r\n";

             return EntityData(q);
         }

         #endregion[Search by name]

         #region[Look up]

         public static DataTable GetforLookup(DAL DAL)
         {
            string q = " SELECT " + ORDERTYPE.ORDERTYPE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ORDERTYPE.ORDERTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ORDERTYPE.ORDERTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ORDERTYPE.ORDERTYPE_TBL + "." + ORDERTYPE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + ORDERTYPE.ORDERTYPE_TBL + "." + ORDERTYPE.ORDERTYPE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + ORDERTYPE.ORDERTYPE_TBL + "." + ORDERTYPE.ORDERTYPE_NAME + ";\r\n";

             return DAL.Listdata(q);
         }

         #endregion[Look up]

        #region[Get id - Name]

         public static string GetName_Id(string _pId)
        {
            Ordertype obj = PKId(_pId, new DAL());

             if (obj != null)
            {
                return obj.Ordertype_name;
            }
            return "";
        }

         public static string GetId_Name(string _pName)
        {
            Ordertype obj = SearchName(_pName, new DAL());

             if (obj != null)
            {
                return obj.Ordertype_id;
            }
            return "";
        }

         #endregion[Get id - Name]

    }//cls
}//ns
