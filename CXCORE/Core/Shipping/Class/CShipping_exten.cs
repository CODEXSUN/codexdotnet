// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 13-07-2020 08:01:31 AM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXCORE
{
    public class CShipping_exten
    {
         #region[Entity Data]

        private static Shipping EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                 while (redr.Read() == true)
                 {
                    Shipping obj = new Shipping()
                    {
                        Shipping_id = redr[SHIPPING.SHIPPING_ID].ToString(),
                        Shipping_name = redr[SHIPPING.SHIPPING_NAME].ToString(),
                        Notes = redr[SHIPPING.NOTES].ToString(),
                        Active_id = redr[SHIPPING.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                        };
                    return obj;
                 }
            redr.Close();
            return new Shipping();
            }
        }

        #endregion[Entity Data]

         #region[Entity List]

         private static List<Shipping> EntityList(string q)
         {
             List<Shipping> list = new List<Shipping>();

             using (IDataReader redr = new DAL().Listreader(q))
             {
                 while (redr.Read() == true)
                 {
                      Shipping obj = new Shipping()
                     {
                        Shipping_id = redr[SHIPPING.SHIPPING_ID].ToString(),
                        Shipping_name = redr[SHIPPING.SHIPPING_NAME].ToString(),
                        Notes = redr[SHIPPING.NOTES].ToString(),
                        Active_id = redr[SHIPPING.ACTIVE_ID].ToString(),
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

         public static List<Shipping> Active()
         {
            string q = " SELECT " + SHIPPING.SHIPPING_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + SHIPPING.SHIPPING_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + SHIPPING.SHIPPING_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + SHIPPING.SHIPPING_TBL + "." + SHIPPING.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + SHIPPING.SHIPPING_TBL + "." + SHIPPING.SHIPPING_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + SHIPPING.SHIPPING_TBL + "." + SHIPPING.SHIPPING_NAME + ";\r\n";

             return EntityList(q);
         }

         #endregion[Active]

         #region[NotActive]

         public static List<Shipping> NotActive()
         {
            string q = " SELECT " + SHIPPING.SHIPPING_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + SHIPPING.SHIPPING_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + SHIPPING.SHIPPING_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + SHIPPING.SHIPPING_TBL + "." + SHIPPING.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + SHIPPING.SHIPPING_TBL + "." + SHIPPING.SHIPPING_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + SHIPPING.SHIPPING_TBL + "." + SHIPPING.SHIPPING_NAME + ";\r\n";

             return EntityList(q);
         }

         #endregion[NotActive]

         #region[Primary Key]

         public static Shipping PKId(string v)
         {
            string q = " SELECT " + SHIPPING.SHIPPING_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + SHIPPING.SHIPPING_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + SHIPPING.SHIPPING_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + SHIPPING.SHIPPING_TBL + "." + SHIPPING.SHIPPING_ID + "  = '" + v + "' \r\n";

             return EntityData(q);
         }

         #endregion[Primary Key]

         #region[Search by name]

         public static Shipping SearchName(string v)
         {
            string q = " SELECT " + SHIPPING.SHIPPING_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + SHIPPING.SHIPPING_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + SHIPPING.SHIPPING_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + SHIPPING.SHIPPING_TBL + "." + SHIPPING.SHIPPING_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + SHIPPING.SHIPPING_TBL + "." + SHIPPING.SHIPPING_NAME + ";\r\n";

             return EntityData(q);
         }

         #endregion[Search by name]

         #region[Look up]

         public static DataTable GetforLookup()
         {
            string q = " SELECT " + SHIPPING.SHIPPING_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + SHIPPING.SHIPPING_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + SHIPPING.SHIPPING_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + SHIPPING.SHIPPING_TBL + "." + SHIPPING.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + SHIPPING.SHIPPING_TBL + "." + SHIPPING.SHIPPING_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + SHIPPING.SHIPPING_TBL + "." + SHIPPING.SHIPPING_NAME + ";\r\n";

             return new DAL().Listdata(q);
         }

         #endregion[Look up]

        #region[Get id - Name]

         public static string GetName_Id(string v)
        {
            Shipping obj = PKId(v);

             if (obj != null)
            {
                return obj.Shipping_name;
            }
            return "";
        }

         public static string GetId_Name(string v)
        {
            Shipping obj = SearchName(v);

             if (obj != null)
            {
                return obj.Shipping_id;
            }
            return "";
        }

         #endregion[Get id - Name]

    }//cls
}//ns
