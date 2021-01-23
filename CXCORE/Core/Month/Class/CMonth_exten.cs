// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 15-10-2019 10:05:59 AM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXCORE
{
    public class CMonth_exten
    {
         #region[Entity Data]

        private static Month EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                 while (redr.Read() == true)
                 {
                    Month obj = new Month()
                    {
                        Month_id = redr[MONTH.MONTH_ID].ToString(),
                        Month_name = redr[MONTH.MONTH_NAME].ToString(),
                        Month_starts = redr[MONTH.MONTH_STARTS].ToString(),
                        Month_ends = redr[MONTH.MONTH_ENDS].ToString(),
                        Notes = redr[MONTH.NOTES].ToString(),
                        Active_id = redr[MONTH.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                        };
                    return obj;
                 }
            redr.Close();
            return new Month();
            }
        }

        #endregion[Entity Data]

         #region[Entity List]

         private static List<Month> EntityList(string q)
         {
             List<Month> list = new List<Month>();

             using (IDataReader redr = new DAL().Listreader(q))
             {
                 while (redr.Read() == true)
                 {
                      Month obj = new Month()
                     {
                        Month_id = redr[MONTH.MONTH_ID].ToString(),
                        Month_name = redr[MONTH.MONTH_NAME].ToString(),
                        Month_starts = redr[MONTH.MONTH_STARTS].ToString(),
                        Month_ends = redr[MONTH.MONTH_ENDS].ToString(),
                        Notes = redr[MONTH.NOTES].ToString(),
                        Active_id = redr[MONTH.ACTIVE_ID].ToString(),
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

         public static List<Month> Active(DAL DAL)
         {
            string q = " SELECT " + MONTH.MONTH_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + MONTH.MONTH_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + MONTH.MONTH_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + MONTH.MONTH_TBL + "." + MONTH.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + MONTH.MONTH_TBL + "." + MONTH.MONTH_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + MONTH.MONTH_TBL + "." + MONTH.MONTH_ID + ";\r\n";

             return EntityList(q);
         }

         #endregion[Active]

         #region[NotActive]

         public static List<Month> NotActive(DAL DAL)
         {
            string q = " SELECT " + MONTH.MONTH_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + MONTH.MONTH_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + MONTH.MONTH_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + MONTH.MONTH_TBL + "." + MONTH.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + MONTH.MONTH_TBL + "." + MONTH.MONTH_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + MONTH.MONTH_TBL + "." + MONTH.MONTH_ID + ";\r\n";

             return EntityList(q);
         }

         #endregion[NotActive]

         #region[Primary Key]

         public static Month PKId(string v, DAL DAL)
         {
            string q = " SELECT " + MONTH.MONTH_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + MONTH.MONTH_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + MONTH.MONTH_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + MONTH.MONTH_TBL + "." + MONTH.MONTH_ID + "  = '" + v + "' \r\n";

             return EntityData(q);
         }

         #endregion[Primary Key]

         #region[Search by name]

         public static Month SearchName(string v, DAL DAL)
         {
            string q = " SELECT " + MONTH.MONTH_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + MONTH.MONTH_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + MONTH.MONTH_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + MONTH.MONTH_TBL + "." + MONTH.MONTH_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + MONTH.MONTH_TBL + "." + MONTH.MONTH_ID + ";\r\n";

             return EntityData(q);
         }

         #endregion[Search by name]

         #region[Look up]

         public static DataTable GetforLookup(DAL DAL)
         {
            string q = " SELECT " + MONTH.MONTH_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + MONTH.MONTH_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + MONTH.MONTH_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + MONTH.MONTH_TBL + "." + MONTH.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + MONTH.MONTH_TBL + "." + MONTH.MONTH_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + MONTH.MONTH_TBL + "." + MONTH.MONTH_ID + ";\r\n";

             return DAL.Listdata(q);
         }

         #endregion[Look up]

        #region[Get id - Name]

         public static string GetName_Id(string _pId)
        {
            Month obj = PKId(_pId, new DAL());

             if (obj != null)
            {
                return obj.Month_name;
            }
            return "";
        }

         public static string GetId_Name(string _pName)
        {
            Month obj = SearchName(_pName, new DAL());

             if (obj != null)
            {
                return obj.Month_id;
            }
            return "";
        }

         #endregion[Get id - Name]

    }//cls
}//ns
