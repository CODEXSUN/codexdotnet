// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 10:55:36 PM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXCORE
{
    public class CLedger_exten
    {
         #region[Entity Data]

        private static Ledger EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                 while (redr.Read() == true)
                 {
                    Ledger obj = new Ledger()
                    {
                        Ledger_id = redr[LEDGER.LEDGER_ID].ToString(),
                        Ledger_name = redr[LEDGER.LEDGER_NAME].ToString(),
                        Ledgergroup_id = redr[LEDGERGROUP.LEDGERGROUP_NAME].ToString(),
                        Notes = redr[LEDGER.NOTES].ToString(),
                        Active_id = redr[LEDGER.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                        };
                    return obj;
                 }
            redr.Close();
            return new Ledger();
            }
        }

        #endregion[Entity Data]

         #region[Entity List]

         private static List<Ledger> EntityList(string q)
         {
             List<Ledger> list = new List<Ledger>();

             using (IDataReader redr = new DAL().Listreader(q))
             {
                 while (redr.Read() == true)
                 {
                      Ledger obj = new Ledger()
                     {
                        Ledger_id = redr[LEDGER.LEDGER_ID].ToString(),
                        Ledger_name = redr[LEDGER.LEDGER_NAME].ToString(),
                        Ledgergroup_id = redr[LEDGERGROUP.LEDGERGROUP_NAME].ToString(),
                        Notes = redr[LEDGER.NOTES].ToString(),
                        Active_id = redr[LEDGER.ACTIVE_ID].ToString(),
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

         public static List<Ledger> Active(DAL DAL)
         {
            string q = " SELECT " + LEDGER.LEDGER_TBL + ".* \r\n";
            q += ", " + LEDGERGROUP.LEDGERGROUP_TBL + "." + LEDGERGROUP.LEDGERGROUP_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + LEDGER.LEDGER_TBL + " \r\n";
            q += " INNER JOIN  " + LEDGERGROUP.LEDGERGROUP_TBL + " \r\n";
            q += " ON( " + LEDGER.LEDGER_TBL + "." + LEDGERGROUP.LEDGERGROUP_ID + " = " + LEDGERGROUP.LEDGERGROUP_TBL+ "." +LEDGERGROUP.LEDGERGROUP_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + LEDGER.LEDGER_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + LEDGER.LEDGER_TBL + "." + LEDGER.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + LEDGER.LEDGER_TBL + "." + LEDGER.LEDGER_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + LEDGER.LEDGER_TBL + "." + LEDGER.LEDGER_NAME + ";\r\n";

             return EntityList(q);
         }

         #endregion[Active]

         #region[NotActive]

         public static List<Ledger> NotActive(DAL DAL)
         {
            string q = " SELECT " + LEDGER.LEDGER_TBL + ".* \r\n";
            q += ", " + LEDGERGROUP.LEDGERGROUP_TBL + "." + LEDGERGROUP.LEDGERGROUP_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + LEDGER.LEDGER_TBL + " \r\n";
            q += " INNER JOIN  " + LEDGERGROUP.LEDGERGROUP_TBL + " \r\n";
            q += " ON( " + LEDGER.LEDGER_TBL + "." + LEDGERGROUP.LEDGERGROUP_ID + " = " + LEDGERGROUP.LEDGERGROUP_TBL+ "." +LEDGERGROUP.LEDGERGROUP_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + LEDGER.LEDGER_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + LEDGER.LEDGER_TBL + "." + LEDGER.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + LEDGER.LEDGER_TBL + "." + LEDGER.LEDGER_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + LEDGER.LEDGER_TBL + "." + LEDGER.LEDGER_NAME + ";\r\n";

             return EntityList(q);
         }

         #endregion[NotActive]

         #region[Primary Key]

         public static Ledger PKId(string v, DAL DAL)
         {
            string q = " SELECT " + LEDGER.LEDGER_TBL + ".* \r\n";
            q += ", " + LEDGERGROUP.LEDGERGROUP_TBL + "." + LEDGERGROUP.LEDGERGROUP_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + LEDGER.LEDGER_TBL + " \r\n";
            q += " INNER JOIN  " + LEDGERGROUP.LEDGERGROUP_TBL + " \r\n";
            q += " ON( " + LEDGER.LEDGER_TBL + "." + LEDGERGROUP.LEDGERGROUP_ID + " = " + LEDGERGROUP.LEDGERGROUP_TBL+ "." +LEDGERGROUP.LEDGERGROUP_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + LEDGER.LEDGER_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + LEDGER.LEDGER_TBL + "." + LEDGER.LEDGER_ID + "  = '" + v + "' \r\n";

             return EntityData(q);
         }

         #endregion[Primary Key]

         #region[Search by name]

         public static Ledger SearchName(string v, DAL DAL)
         {
            string q = " SELECT " + LEDGER.LEDGER_TBL + ".* \r\n";
            q += ", " + LEDGERGROUP.LEDGERGROUP_TBL + "." + LEDGERGROUP.LEDGERGROUP_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + LEDGER.LEDGER_TBL + " \r\n";
            q += " INNER JOIN  " + LEDGERGROUP.LEDGERGROUP_TBL + " \r\n";
            q += " ON( " + LEDGER.LEDGER_TBL + "." + LEDGERGROUP.LEDGERGROUP_ID + " = " + LEDGERGROUP.LEDGERGROUP_TBL+ "." +LEDGERGROUP.LEDGERGROUP_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + LEDGER.LEDGER_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + LEDGER.LEDGER_TBL + "." + LEDGER.LEDGER_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + LEDGER.LEDGER_TBL + "." + LEDGER.LEDGER_NAME + ";\r\n";

             return EntityData(q);
         }

         #endregion[Search by name]

         #region[Look up]

         public static DataTable GetforLookup()
         {
            string q = " SELECT " + LEDGER.LEDGER_TBL + ".* \r\n";
            q += ", " + LEDGERGROUP.LEDGERGROUP_TBL + "." + LEDGERGROUP.LEDGERGROUP_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + LEDGER.LEDGER_TBL + " \r\n";
            q += " INNER JOIN  " + LEDGERGROUP.LEDGERGROUP_TBL + " \r\n";
            q += " ON( " + LEDGER.LEDGER_TBL + "." + LEDGERGROUP.LEDGERGROUP_ID + " = " + LEDGERGROUP.LEDGERGROUP_TBL+ "." +LEDGERGROUP.LEDGERGROUP_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + LEDGER.LEDGER_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + LEDGER.LEDGER_TBL + "." + LEDGER.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + LEDGER.LEDGER_TBL + "." + LEDGER.LEDGER_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + LEDGER.LEDGER_TBL + "." + LEDGER.LEDGER_NAME + ";\r\n";

             return new DAL().Listdata(q);
         }

         #endregion[Look up]

        #region[Get id - Name]

         public static string GetName_Id(string _pId)
        {
            Ledger obj = PKId(_pId, new DAL());

             if (obj != null)
            {
                return obj.Ledger_name;
            }
            return "";
        }

         public static string GetId_Name(string _pName)
        {
            Ledger obj = SearchName(_pName, new DAL());

             if (obj != null)
            {
                return obj.Ledger_id;
            }
            return "";
        }

         #endregion[Get id - Name]

    }//cls
}//ns
