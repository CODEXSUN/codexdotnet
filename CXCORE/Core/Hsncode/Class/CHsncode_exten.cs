// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 10:41:08 PM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXCORE
{
    public class CHsncode_exten
    {
         #region[Entity Data]

        private static Hsncode EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                 while (redr.Read() == true)
                 {
                    Hsncode obj = new Hsncode()
                    {
                        Hsncode_id = redr[HSNCODE.HSNCODE_ID].ToString(),
                        Hsncode_name = redr[HSNCODE.HSNCODE_NAME].ToString(),
                        Description = redr[HSNCODE.DESCRIPTION].ToString(),
                        Notes = redr[HSNCODE.NOTES].ToString(),
                        Active_id = redr[HSNCODE.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                        };
                    return obj;
                 }
            redr.Close();
            return new Hsncode();
            }
        }

        #endregion[Entity Data]

         #region[Entity List]

         private static List<Hsncode> EntityList(string q)
         {
             List<Hsncode> list = new List<Hsncode>();

             using (IDataReader redr = new DAL().Listreader(q))
             {
                 while (redr.Read() == true)
                 {
                      Hsncode obj = new Hsncode()
                     {
                        Hsncode_id = redr[HSNCODE.HSNCODE_ID].ToString(),
                        Hsncode_name = redr[HSNCODE.HSNCODE_NAME].ToString(),
                        Description = redr[HSNCODE.DESCRIPTION].ToString(),
                        Notes = redr[HSNCODE.NOTES].ToString(),
                        Active_id = redr[HSNCODE.ACTIVE_ID].ToString(),
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

         public static List<Hsncode> Active(DAL DAL)
         {
            string q = " SELECT " + HSNCODE.HSNCODE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + HSNCODE.HSNCODE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + HSNCODE.HSNCODE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.HSNCODE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.HSNCODE_NAME + ";\r\n";

             return EntityList(q);
         }

         #endregion[Active]

         #region[NotActive]

         public static List<Hsncode> NotActive(DAL DAL)
         {
            string q = " SELECT " + HSNCODE.HSNCODE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + HSNCODE.HSNCODE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + HSNCODE.HSNCODE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.HSNCODE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.HSNCODE_NAME + ";\r\n";

             return EntityList(q);
         }

         #endregion[NotActive]

         #region[Primary Key]

         public static Hsncode PKId(string v, DAL DAL)
         {
            string q = " SELECT " + HSNCODE.HSNCODE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + HSNCODE.HSNCODE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + HSNCODE.HSNCODE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.HSNCODE_ID + "  = '" + v + "' \r\n";

             return EntityData(q);
         }

         #endregion[Primary Key]

         #region[Search by name]

         public static Hsncode SearchName(string v, DAL DAL)
         {
            string q = " SELECT " + HSNCODE.HSNCODE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + HSNCODE.HSNCODE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + HSNCODE.HSNCODE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.HSNCODE_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.HSNCODE_NAME + ";\r\n";

             return EntityData(q);
         }

         #endregion[Search by name]

         #region[Look up]

         public static DataTable GetforLookup(DAL DAL)
         {
            string q = " SELECT " + HSNCODE.HSNCODE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + HSNCODE.HSNCODE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + HSNCODE.HSNCODE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.HSNCODE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.HSNCODE_NAME + ";\r\n";

             return DAL.Listdata(q);
         }

        #endregion[Look up]

        #region[Get id - Name]

        public static string GetName_Id(string _pId)
        {
            Hsncode obj = PKId(_pId, new DAL());

             if (obj != null)
            {
                return obj.Hsncode_name;
            }
            return "";
        }

         public static string GetId_Name(string _pName)
        {
            Hsncode obj = SearchName(_pName, new DAL());

             if (obj != null)
            {
                return obj.Hsncode_id;
            }
            return "";
        }

        #endregion[Get id - Name]

    }//cls
}//ns
