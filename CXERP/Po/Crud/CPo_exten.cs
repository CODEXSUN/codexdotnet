// Version : 4.0.0.2 Date : 10-08-2020
// Auto Generated
// last update : 23-01-2021 08:39:04 PM

using System.Data;
using CXLIB;
using System.Collections.Generic;
using CXCORE;

namespace CXERP
{
    public class CPo_exten
    {
         #region[Entity Data]

        private static Po EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                 while (redr.Read() == true)
                 {
                    Po obj = new Po()
                    {
                        Po_id = redr[PO.PO_ID].ToString(),
                        Po_no = redr[PO.PO_NO].ToString(),
                        Po_date = redr[PO.PO_DATE].ToString(),
                        Notes = redr[PO.NOTES].ToString(),
                        Active_id = redr[PO.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                        };
                    return obj;
                 }
            redr.Close();
            return new Po();
            }
        }

        #endregion[Entity Data]

         #region[Entity List]

         private static List<Po> EntityList(string q)
         {
             List<Po> list = new List<Po>();

             using (IDataReader redr = new DAL().Listreader(q))
             {
                 while (redr.Read() == true)
                 {
                      Po obj = new Po()
                     {
                        Po_id = redr[PO.PO_ID].ToString(),
                        Po_no = redr[PO.PO_NO].ToString(),
                        Po_date = redr[PO.PO_DATE].ToString(),
                        Notes = redr[PO.NOTES].ToString(),
                        Active_id = redr[PO.ACTIVE_ID].ToString(),
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

         public static List<Po> Active()
         {
            string q = " SELECT " + PO.PO_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + PO.PO_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + PO.PO_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + PO.PO_TBL + "." + PO.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + PO.PO_TBL + "." + PO.PO_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + PO.PO_TBL + "." + PO.PO_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[Active]

         #region[NotActive]

         public static List<Po> NotActive()
         {
            string q = " SELECT " + PO.PO_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + PO.PO_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + PO.PO_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + PO.PO_TBL + "." + PO.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + PO.PO_TBL + "." + PO.PO_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + PO.PO_TBL + "." + PO.PO_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[NotActive]

         #region[Primary Key]

         public static Po PKId(string v)
         {
            string q = " SELECT " + PO.PO_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + PO.PO_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + PO.PO_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + PO.PO_TBL + "." + PO.PO_ID + "  = '" + v + "' \r\n";

             return EntityData(q);
         }

         #endregion[Primary Key]

         #region[Search by name]

         public static Po SearchName(string v)
         {
            string q = " SELECT " + PO.PO_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + PO.PO_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + PO.PO_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + PO.PO_TBL + "." + PO.PO_NO + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + PO.PO_TBL + "." + PO.PO_NO + ";\r\n";

             return EntityData(q);
         }

         #endregion[Search by name]

         #region[Look up]

         public static DataTable GetforLookup()
         {
            string q = " SELECT " + PO.PO_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + PO.PO_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + PO.PO_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + PO.PO_TBL + "." + PO.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + PO.PO_TBL + "." + PO.PO_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + PO.PO_TBL + "." + PO.PO_NO + ";\r\n";

             return new DAL().Listdata(q);
         }

         #endregion[Look up]

        #region[Get id - Name]

         public static string GetName_Id(string v)
        {
            Po obj = PKId(v);

             if (obj != null)
            {
                return obj.Po_no;
            }
            return "";
        }

         public static string GetId_Name(string v)
        {
            Po obj = SearchName(v);

             if (obj != null)
            {
                return obj.Po_id;
            }
            return "";
        }

         #endregion[Get id - Name]

    }//cls
}//ns
