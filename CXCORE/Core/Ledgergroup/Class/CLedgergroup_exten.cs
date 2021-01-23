// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 10:51:36 PM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXCORE
{
    public class CLedgergroup_exten
    {
        #region[Entity Data]

        private static Ledgergroup EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Ledgergroup obj = new Ledgergroup()
                    {
                        Ledgergroup_id = redr[LEDGERGROUP.LEDGERGROUP_ID].ToString(),
                        Ledgergroup_name = redr[LEDGERGROUP.LEDGERGROUP_NAME].ToString(),
                        Notes = redr[LEDGERGROUP.NOTES].ToString(),
                        Active_id = redr[LEDGERGROUP.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                    };
                    return obj;
                }
                redr.Close();
                return new Ledgergroup();
            }
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<Ledgergroup> EntityList(string q)
        {
            List<Ledgergroup> list = new List<Ledgergroup>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Ledgergroup obj = new Ledgergroup()
                    {
                        Ledgergroup_id = redr[LEDGERGROUP.LEDGERGROUP_ID].ToString(),
                        Ledgergroup_name = redr[LEDGERGROUP.LEDGERGROUP_NAME].ToString(),
                        Notes = redr[LEDGERGROUP.NOTES].ToString(),
                        Active_id = redr[LEDGERGROUP.ACTIVE_ID].ToString(),
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

        public static List<Ledgergroup> Active(DAL DAL)
        {
            string q = " SELECT " + LEDGERGROUP.LEDGERGROUP_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + LEDGERGROUP.LEDGERGROUP_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + LEDGERGROUP.LEDGERGROUP_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + LEDGERGROUP.LEDGERGROUP_TBL + "." + LEDGERGROUP.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + LEDGERGROUP.LEDGERGROUP_TBL + "." + LEDGERGROUP.LEDGERGROUP_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + LEDGERGROUP.LEDGERGROUP_TBL + "." + LEDGERGROUP.LEDGERGROUP_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[Active]

        #region[NotActive]

        public static List<Ledgergroup> NotActive(DAL DAL)
        {
            string q = " SELECT " + LEDGERGROUP.LEDGERGROUP_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + LEDGERGROUP.LEDGERGROUP_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + LEDGERGROUP.LEDGERGROUP_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + LEDGERGROUP.LEDGERGROUP_TBL + "." + LEDGERGROUP.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + LEDGERGROUP.LEDGERGROUP_TBL + "." + LEDGERGROUP.LEDGERGROUP_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + LEDGERGROUP.LEDGERGROUP_TBL + "." + LEDGERGROUP.LEDGERGROUP_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[NotActive]

        #region[Primary Key]

        public static Ledgergroup PKId(string v, DAL DAL)
        {
            string q = " SELECT " + LEDGERGROUP.LEDGERGROUP_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + LEDGERGROUP.LEDGERGROUP_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + LEDGERGROUP.LEDGERGROUP_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + LEDGERGROUP.LEDGERGROUP_TBL + "." + LEDGERGROUP.LEDGERGROUP_ID + "  = '" + v + "' \r\n";

            return EntityData(q);
        }

        #endregion[Primary Key]

        #region[Search by name]

        public static Ledgergroup SearchName(string v, DAL DAL)
        {
            string q = " SELECT " + LEDGERGROUP.LEDGERGROUP_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + LEDGERGROUP.LEDGERGROUP_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + LEDGERGROUP.LEDGERGROUP_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + LEDGERGROUP.LEDGERGROUP_TBL + "." + LEDGERGROUP.LEDGERGROUP_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + LEDGERGROUP.LEDGERGROUP_TBL + "." + LEDGERGROUP.LEDGERGROUP_NAME + ";\r\n";

            return EntityData(q);
        }

        #endregion[Search by name]

        #region[Look up]

        public static DataTable GetforLookup(DAL DAL)
        {
            string q = " SELECT " + LEDGERGROUP.LEDGERGROUP_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + LEDGERGROUP.LEDGERGROUP_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + LEDGERGROUP.LEDGERGROUP_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + LEDGERGROUP.LEDGERGROUP_TBL + "." + LEDGERGROUP.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + LEDGERGROUP.LEDGERGROUP_TBL + "." + LEDGERGROUP.LEDGERGROUP_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + LEDGERGROUP.LEDGERGROUP_TBL + "." + LEDGERGROUP.LEDGERGROUP_NAME + ";\r\n";

            return DAL.Listdata(q);
        }

        #endregion[Look up]

        #region[Get id - Name]

        public static string GetName_Id(string _pId)
        {
            Ledgergroup obj = PKId(_pId, new DAL());

            if (obj != null)
            {
                return obj.Ledgergroup_name;
            }
            return "";
        }

        public static string GetId_Name(string _pName)
        {
            Ledgergroup obj = SearchName(_pName, new DAL());

            if (obj != null)
            {
                return obj.Ledgergroup_id;
            }
            return "";
        }

        #endregion[Get id - Name]

    }//cls
}//ns
