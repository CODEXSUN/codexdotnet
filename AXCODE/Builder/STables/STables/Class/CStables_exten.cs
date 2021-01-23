// Version : 2.0.0.0 dt : 16-10-2018
// Auto Generated
// last update : 18-11-2018 07:25:37 PM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace AXCODE
{
    public class CStables_exten
    {
        #region[Entity Data]

        private static Stables EntityData(string q)
        {
            using (IDataReader redr = new SQLITE_DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Stables obj = new Stables()
                    {
                        Stables_id = redr[STABLES.STABLES_ID].ToString(),
                        Stables_name = redr[STABLES.STABLES_NAME].ToString(),
                        Alias = redr[STABLES.ALIAS].ToString(),
                        Namespaces_id = redr[NAMESPACES.NAMESPACES_NAME].ToString(),
                        Databases_id = redr[DATABASES.DATABASES_NAME].ToString(),
                        Active_id = redr[STABLES.ACTIVE_ID].ToString(),
                    };
                    return obj;
                }
                redr.Close();
                return new Stables();
            }
        }

        internal static List<Stables> Searchby(string db, string tbl)
        {
            string q = " SELECT " + STABLES.STABLES_TBL + ".* \r\n";
            q += ", " + DATABASES.DATABASES_TBL + "." + DATABASES.DATABASES_NAME + " \r\n";
            q += ", " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_NAME + " \r\n";
            q += " FROM  " + STABLES.STABLES_TBL + " \r\n";
            q += " INNER JOIN  " + DATABASES.DATABASES_TBL + " \r\n";
            q += " ON( " + STABLES.STABLES_TBL + "." + DATABASES.DATABASES_ID + " = " + DATABASES.DATABASES_TBL + "." + DATABASES.DATABASES_ID + ")\r\n";
            q += " INNER JOIN  " + NAMESPACES.NAMESPACES_TBL + " \r\n";
            q += " ON( " + STABLES.STABLES_TBL + "." + NAMESPACES.NAMESPACES_ID + " = " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_ID + ")\r\n";

            q += " WHERE " + STABLES.STABLES_TBL + "." + STABLES.STABLES_NAME + "  = '" + tbl + "' \r\n";
            q += " AND " + DATABASES.DATABASES_TBL + "." + DATABASES.DATABASES_NAME + "  = '" + db + "' \r\n";

            q += " ORDER BY  " + STABLES.STABLES_TBL + "." + STABLES.STABLES_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<Stables> EntityList(string q)
        {
            List<Stables> list = new List<Stables>();

            using (IDataReader redr = new SQLITE_DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Stables obj = new Stables()
                    {
                        Stables_id = redr[STABLES.STABLES_ID].ToString(),
                        Stables_name = redr[STABLES.STABLES_NAME].ToString(),
                        Alias = redr[STABLES.ALIAS].ToString(),
                        Namespaces_id = redr[NAMESPACES.NAMESPACES_NAME].ToString(),
                        Databases_id = redr[DATABASES.DATABASES_NAME].ToString(),
                        Active_id = redr[STABLES.ACTIVE_ID].ToString(),
                    };

                    list.Add(obj);
                }

                redr.Close();
            }
            return list;
        }

        #endregion[Entity List]

        #region[Active]

        public static List<Stables> Active(SQLITE_DAL SQLITE_DAL)
        {
            string q = " SELECT " + STABLES.STABLES_TBL + ".*\r\n";
            q += " , " + DATABASES.DATABASES_TBL + "."+ DATABASES.DATABASES_NAME + " \r\n";
            q += " , " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_NAME + " \r\n";
            q += " FROM  " + STABLES.STABLES_TBL + " \r\n";
            q += " INNER JOIN  " + DATABASES.DATABASES_TBL + "\r\n";
            q += " ON(" + DATABASES.DATABASES_TBL + "." + DATABASES.DATABASES_ID + " = " + STABLES.STABLES_TBL + "." + STABLES.DATABASES_ID + " )\r\n";
            q += " INNER JOIN  " + NAMESPACES.NAMESPACES_TBL + "\r\n";
            q += " ON(" + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_ID + " = " + STABLES.STABLES_TBL + "." + STABLES.NAMESPACES_ID + " )\r\n";
            q += " WHERE " + STABLES.STABLES_TBL + "." + STABLES.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " ORDER BY  " + STABLES.STABLES_TBL + "." + STABLES.STABLES_ID + ";\r\n";

            return EntityList(q);
        }

        #endregion[Active]

        #region[NotActive]

        public static List<Stables> NotActive(SQLITE_DAL SQLITE_DAL)
        {
            string q = " SELECT " + STABLES.STABLES_TBL + ".* \r\n";
            q += " , " + DATABASES.DATABASES_TBL + "." + DATABASES.DATABASES_NAME + " \r\n";
            q += " , " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_NAME + " \r\n";
            q += " FROM  " + STABLES.STABLES_TBL + " \r\n";
            q += " INNER JOIN  " + DATABASES.DATABASES_TBL + "\r\n";
            q += " ON(" + DATABASES.DATABASES_TBL + "." + DATABASES.DATABASES_ID + " = " + STABLES.STABLES_TBL + "." + STABLES.DATABASES_ID + " )\r\n";
            q += " INNER JOIN  " + NAMESPACES.NAMESPACES_TBL + "\r\n";
            q += " ON(" + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_ID + " = " + STABLES.STABLES_TBL + "." + STABLES.NAMESPACES_ID + " )\r\n";
            q += " WHERE " + STABLES.STABLES_TBL + "." + STABLES.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            q += " ORDER BY  " + STABLES.STABLES_TBL + "." + STABLES.STABLES_ID + ";\r\n";

            return EntityList(q);
        }

        #endregion[NotActive]

        #region[Primary Key]

        public static Stables PKId(string v, SQLITE_DAL SQLITE_DAL)
        {
            string q = " SELECT " + STABLES.STABLES_TBL + ".* \r\n";
            q += " , " + DATABASES.DATABASES_TBL + "." + DATABASES.DATABASES_NAME + " \r\n";
            q += " , " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_NAME + " \r\n";
            q += " FROM  " + STABLES.STABLES_TBL + " \r\n";
            q += " INNER JOIN  " + DATABASES.DATABASES_TBL + "\r\n";
            q += " ON(" + DATABASES.DATABASES_TBL + "." + DATABASES.DATABASES_ID + " = " + STABLES.STABLES_TBL + "." + STABLES.DATABASES_ID + " )\r\n";
            q += " INNER JOIN  " + NAMESPACES.NAMESPACES_TBL + "\r\n";
            q += " ON(" + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_ID + " = " + STABLES.STABLES_TBL + "." + STABLES.NAMESPACES_ID + " )\r\n";
            q += " WHERE " + STABLES.STABLES_TBL + "." + STABLES.STABLES_ID + "  = '" + v + "' \r\n";

            return EntityData(q);
        }

        #endregion[Primary Key]

        #region[Search by name]

        public static Stables SearchName(string v, SQLITE_DAL SQLITE_DAL)
        {
            string q = " SELECT " + STABLES.STABLES_TBL + ".* \r\n";
            q += " , " + DATABASES.DATABASES_TBL + "." + DATABASES.DATABASES_NAME + " \r\n";
            q += " , " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_NAME + " \r\n";
            q += " FROM  " + STABLES.STABLES_TBL + " \r\n";
            q += " INNER JOIN  " + DATABASES.DATABASES_TBL + "\r\n";
            q += " ON(" + DATABASES.DATABASES_TBL + "." + DATABASES.DATABASES_ID + " = " + STABLES.STABLES_TBL + "." + STABLES.DATABASES_ID + " )\r\n";
            q += " INNER JOIN  " + NAMESPACES.NAMESPACES_TBL + "\r\n";
            q += " ON(" + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_ID + " = " + STABLES.STABLES_TBL + "." + STABLES.NAMESPACES_ID + " )\r\n";
            q += " WHERE " + STABLES.STABLES_TBL + "." + STABLES.STABLES_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + STABLES.STABLES_TBL + "." + STABLES.STABLES_ID + ";\r\n";

            return EntityData(q);
        }

        #endregion[Search by name]

        #region[Look up]

        public static DataTable GetforLookup(SQLITE_DAL SQLITE_DAL)
        {
            string q = " SELECT " + STABLES.STABLES_TBL + ".* \r\n";
            q += " , " + DATABASES.DATABASES_TBL + "." + DATABASES.DATABASES_NAME + " \r\n";
            q += " , " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_NAME + " \r\n";
            q += " FROM  " + STABLES.STABLES_TBL + " \r\n";
            q += " INNER JOIN  " + DATABASES.DATABASES_TBL + "\r\n";
            q += " ON(" + DATABASES.DATABASES_TBL + "." + DATABASES.DATABASES_ID + " = " + STABLES.STABLES_TBL + "." + STABLES.DATABASES_ID + " )\r\n";
            q += " INNER JOIN  " + NAMESPACES.NAMESPACES_TBL + "\r\n";
            q += " ON(" + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_ID + " = " + STABLES.STABLES_TBL + "." + STABLES.NAMESPACES_ID + " )\r\n";
            q += " WHERE " + STABLES.STABLES_TBL + "." + STABLES.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " ORDER BY  " + STABLES.STABLES_TBL + "." + STABLES.STABLES_ID + ";\r\n";

            return SQLITE_DAL.Listdata(q);
        }

        #endregion[Look up]

        #region[Get id - FieldsName]

        public static string GetName_Id(string _pId)
        {
            Stables obj = PKId(_pId, new SQLITE_DAL());

            if (obj != null)
            {
                return obj.Stables_name;
            }
            return "";
        }

        public static string GetId_Name(string _pName)
        {
            Stables obj = SearchName(_pName, new SQLITE_DAL());

            if (obj != null)
            {
                return obj.Stables_id;
            }
            return "";
        }

        #endregion[Get id - FieldsName]

    }//cls
}//ns
