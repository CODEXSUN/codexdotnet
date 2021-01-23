// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 07-08-2020 07:48:01 AM

using System.Data;
using CXLIB;
using System.Collections.Generic;
using System;

namespace CXCORE
{
    public class CAcy_exten
    {
         #region[Entity Data]

        private static Acy EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                 while (redr.Read() == true)
                 {
                    Acy obj = new Acy()
                    {
                        Acy_id = redr[ACY.ACY_ID].ToString(),
                        Acy_name = redr[ACY.ACY_NAME].ToString(),
                        From_date = redr[ACY.FROM_DATE].ToString(),
                        To_date = redr[ACY.TO_DATE].ToString(),
                        Notes = redr[ACY.NOTES].ToString(),
                        Active_id = redr[ACY.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                        };
                    return obj;
                 }
            redr.Close();
            return new Acy();
            }
        }

        #endregion[Entity Data]

         #region[Entity List]

         private static List<Acy> EntityList(string q)
         {
             List<Acy> list = new List<Acy>();

             using (IDataReader redr = new DAL().Listreader(q))
             {
                 while (redr.Read() == true)
                 {
                      Acy obj = new Acy()
                     {
                        Acy_id = redr[ACY.ACY_ID].ToString(),
                        Acy_name = redr[ACY.ACY_NAME].ToString(),
                        From_date = redr[ACY.FROM_DATE].ToString(),
                        To_date = redr[ACY.TO_DATE].ToString(),
                        Notes = redr[ACY.NOTES].ToString(),
                        Active_id = redr[ACY.ACTIVE_ID].ToString(),
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

         public static List<Acy> Active()
         {
            string q = " SELECT " + ACY.ACY_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ACY.ACY_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ACY.ACY_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ACY.ACY_TBL + "." + ACY.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + ACY.ACY_TBL + "." + ACY.ACY_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + ACY.ACY_TBL + "." + ACY.ACY_NAME + ";\r\n";

             return EntityList(q);
         }

         #endregion[Active]

         #region[NotActive]

         public static List<Acy> NotActive()
         {
            string q = " SELECT " + ACY.ACY_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ACY.ACY_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ACY.ACY_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ACY.ACY_TBL + "." + ACY.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + ACY.ACY_TBL + "." + ACY.ACY_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + ACY.ACY_TBL + "." + ACY.ACY_NAME + ";\r\n";

             return EntityList(q);
         }

         #endregion[NotActive]

         #region[Primary Key]

         public static Acy PKId(string v)
         {
            string q = " SELECT " + ACY.ACY_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ACY.ACY_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ACY.ACY_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ACY.ACY_TBL + "." + ACY.ACY_ID + "  = '" + v + "' \r\n";

             return EntityData(q);
         }

         #endregion[Primary Key]

         #region[Search by name]

         public static Acy SearchName(string v)
         {
            string q = " SELECT " + ACY.ACY_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ACY.ACY_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ACY.ACY_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ACY.ACY_TBL + "." + ACY.ACY_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + ACY.ACY_TBL + "." + ACY.ACY_NAME + ";\r\n";

             return EntityData(q);
         }

         #endregion[Search by name]

         #region[Look up]

         public static DataTable GetforLookup()
         {
            string q = " SELECT " + ACY.ACY_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ACY.ACY_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ACY.ACY_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ACY.ACY_TBL + "." + ACY.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + ACY.ACY_TBL + "." + ACY.ACY_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + ACY.ACY_TBL + "." + ACY.ACY_NAME + ";\r\n";

             return new DAL().Listdata(q);
         }

         #endregion[Look up]

        #region[Get id - Name]

         public static string GetName_Id(string v)
        {
            Acy obj = PKId(v);

             if (obj != null)
            {
                return obj.Acy_name;
            }
            return "";
        }

         public static string GetId_Name(string v)
        {
            Acy obj = SearchName(v);

             if (obj != null)
            {
                return obj.Acy_id;
            }
            return "";
        }


        public static DateTime AcyFrom_Id(string v)
        {
            Acy obj = PKId(v);

            if (obj != null)
            {
                return ConvertTO.DDate(obj.From_date);
            }
            return DateTime.Now;
        }


        public static DateTime AcyTo_Id(string v)
        {
            Acy obj = PKId(v);

            if (obj != null)
            {
                return ConvertTO.DDate(obj.To_date);
            }
            return DateTime.Now;
        }

        #endregion[Get id - Name]

    }//cls
}//ns
