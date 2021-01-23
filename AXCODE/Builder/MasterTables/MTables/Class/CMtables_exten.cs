// Version : 2.1.0.0 dt : 04-12-2018
// Auto Generated
// last update : 05-12-2018 11:04:43 AM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace AXCODE
{
    public class CMtables_exten
    {
        #region[Entity Data]

        private static MasterTables EntityData(string q)
        {
            using (IDataReader redr = new SQLITE_DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    MasterTables obj = new MasterTables()
                    {
                        Mastertables_id = redr[MASTERTABLES.MASTERTABLES_ID].ToString(),
                        Databases_id = redr[DATABASES.DATABASES_NAME].ToString(),
                        Mastertables_name = redr[MASTERTABLES.MASTERTABLES_NAME].ToString(),
                        Alias = redr[MASTERTABLES.ALIAS].ToString(),
                        Namespaces_id = redr[NAMESPACES.NAMESPACES_NAME].ToString(),
                        Active_id = redr[MASTERTABLES.ACTIVE_ID].ToString(),
                    };
                    return obj;
                }
                redr.Close();
                return new MasterTables();
            }
        }

        internal static List<MasterTables> Searchby(string db, string tbl)
        {
            string q = " SELECT " + MASTERTABLES.MASTERTABLES_TBL + ".* \r\n";
            q += ", " + DATABASES.DATABASES_TBL + "." + DATABASES.DATABASES_NAME + " \r\n";
            q += ", " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_NAME + " \r\n";
            q += " FROM  " + MASTERTABLES.MASTERTABLES_TBL + " \r\n";
            q += " INNER JOIN  " + DATABASES.DATABASES_TBL + " \r\n";
            q += " ON( " + MASTERTABLES.MASTERTABLES_TBL + "." + DATABASES.DATABASES_ID + " = " + DATABASES.DATABASES_TBL + "." + DATABASES.DATABASES_ID + ")\r\n";
            q += " INNER JOIN  " + NAMESPACES.NAMESPACES_TBL + " \r\n";
            q += " ON( " + MASTERTABLES.MASTERTABLES_TBL + "." + NAMESPACES.NAMESPACES_ID + " = " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_ID + ")\r\n";

            q += " WHERE " + MASTERTABLES.MASTERTABLES_TBL + "." + MASTERTABLES.MASTERTABLES_NAME + "  = '" + tbl + "' \r\n";
            q += " AND " + DATABASES.DATABASES_TBL + "." + DATABASES.DATABASES_NAME+ "  = '" + db + "' \r\n";

            q += " ORDER BY  " + MASTERTABLES.MASTERTABLES_TBL + "." + MASTERTABLES.MASTERTABLES_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<MasterTables> EntityList(string q)
        {
            List<MasterTables> list = new List<MasterTables>();

            using (IDataReader redr = new SQLITE_DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    MasterTables obj = new MasterTables()
                    {
                        Mastertables_id = redr[MASTERTABLES.MASTERTABLES_ID].ToString(),
                        Databases_id = redr[DATABASES.DATABASES_NAME].ToString(),
                        Mastertables_name = redr[MASTERTABLES.MASTERTABLES_NAME].ToString(),
                        Alias = redr[MASTERTABLES.ALIAS].ToString(),
                        Namespaces_id = redr[NAMESPACES.NAMESPACES_NAME].ToString(),
                        Active_id = redr[MASTERTABLES.ACTIVE_ID].ToString(),
                    };

                    list.Add(obj);
                }

                redr.Close();
            }
            return list;
        }

        #endregion[Entity List]

        #region[Active]

        public static List<MasterTables> Active(SQLITE_DAL SQLITE_DAL)
        {
            string q = " SELECT " + MASTERTABLES.MASTERTABLES_TBL + ".* \r\n";
            q += ", " + DATABASES.DATABASES_TBL + "." + DATABASES.DATABASES_NAME + " \r\n";
            q += ", " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_NAME + " \r\n";
            q += " FROM  " + MASTERTABLES.MASTERTABLES_TBL + " \r\n";
            q += " INNER JOIN  " + DATABASES.DATABASES_TBL + " \r\n";
            q += " ON( " + MASTERTABLES.MASTERTABLES_TBL + "." + DATABASES.DATABASES_ID + " = " + DATABASES.DATABASES_TBL + "." + DATABASES.DATABASES_ID + ")\r\n";
            q += " INNER JOIN  " + NAMESPACES.NAMESPACES_TBL + " \r\n";
            q += " ON( " + MASTERTABLES.MASTERTABLES_TBL + "." + NAMESPACES.NAMESPACES_ID + " = " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_ID + ")\r\n";
            q += " WHERE " + MASTERTABLES.MASTERTABLES_TBL + "." + MASTERTABLES.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " ORDER BY  " + MASTERTABLES.MASTERTABLES_TBL + "." + MASTERTABLES.MASTERTABLES_ID + ";\r\n";

            return EntityList(q);
        }

        #endregion[Active]

        #region[NotActive]

        public static List<MasterTables> NotActive(SQLITE_DAL SQLITE_DAL)
        {
            string q = " SELECT " + MASTERTABLES.MASTERTABLES_TBL + ".* \r\n";
            q += ", " + DATABASES.DATABASES_TBL + "." + DATABASES.DATABASES_NAME + " \r\n";
            q += ", " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_NAME + " \r\n";
            q += " FROM  " + MASTERTABLES.MASTERTABLES_TBL + " \r\n";
            q += " INNER JOIN  " + DATABASES.DATABASES_TBL + " \r\n";
            q += " ON( " + MASTERTABLES.MASTERTABLES_TBL + "." + DATABASES.DATABASES_ID + " = " + DATABASES.DATABASES_TBL + "." + DATABASES.DATABASES_ID + ")\r\n";
            q += " INNER JOIN  " + NAMESPACES.NAMESPACES_TBL + " \r\n";
            q += " ON( " + MASTERTABLES.MASTERTABLES_TBL + "." + NAMESPACES.NAMESPACES_ID + " = " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_ID + ")\r\n";
            q += " WHERE " + MASTERTABLES.MASTERTABLES_TBL + "." + MASTERTABLES.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            q += " ORDER BY  " + MASTERTABLES.MASTERTABLES_TBL + "." + MASTERTABLES.MASTERTABLES_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[NotActive]

        #region[Primary Key]

        public static MasterTables PKId(string v)
        {
            string q = " SELECT " + MASTERTABLES.MASTERTABLES_TBL + ".* \r\n";
            q += ", " + DATABASES.DATABASES_TBL + "." + DATABASES.DATABASES_NAME + " \r\n";
            q += ", " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_NAME + " \r\n";
            q += " FROM  " + MASTERTABLES.MASTERTABLES_TBL + " \r\n";
            q += " INNER JOIN  " + DATABASES.DATABASES_TBL + " \r\n";
            q += " ON( " + MASTERTABLES.MASTERTABLES_TBL + "." + DATABASES.DATABASES_ID + " = " + DATABASES.DATABASES_TBL + "." + DATABASES.DATABASES_ID + ")\r\n";
            q += " INNER JOIN  " + NAMESPACES.NAMESPACES_TBL + " \r\n";
            q += " ON( " + MASTERTABLES.MASTERTABLES_TBL + "." + NAMESPACES.NAMESPACES_ID + " = " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_ID + ")\r\n";
            q += " WHERE " + MASTERTABLES.MASTERTABLES_TBL + "." + MASTERTABLES.MASTERTABLES_ID + "  = '" + v + "' \r\n";

            return EntityData(q);
        }

        #endregion[Primary Key]

        #region[Search by name]

        public static MasterTables SearchName(string v)
        {
            string q = " SELECT " + MASTERTABLES.MASTERTABLES_TBL + ".* \r\n";
            q += ", " + DATABASES.DATABASES_TBL + "." + DATABASES.DATABASES_NAME + " \r\n";
            q += ", " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_NAME + " \r\n";
            q += " FROM  " + MASTERTABLES.MASTERTABLES_TBL + " \r\n";
            q += " INNER JOIN  " + DATABASES.DATABASES_TBL + " \r\n";
            q += " ON( " + MASTERTABLES.MASTERTABLES_TBL + "." + DATABASES.DATABASES_ID + " = " + DATABASES.DATABASES_TBL + "." + DATABASES.DATABASES_ID + ")\r\n";
            q += " INNER JOIN  " + NAMESPACES.NAMESPACES_TBL + " \r\n";
            q += " ON( " + MASTERTABLES.MASTERTABLES_TBL + "." + NAMESPACES.NAMESPACES_ID + " = " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_ID + ")\r\n";
            q += " WHERE " + MASTERTABLES.MASTERTABLES_TBL + "." + MASTERTABLES.MASTERTABLES_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + MASTERTABLES.MASTERTABLES_TBL + "." + MASTERTABLES.MASTERTABLES_NAME + ";\r\n";

            return EntityData(q);
        }

        #endregion[Search by name]

        #region[Look up]

        public static DataTable GetforLookup(SQLITE_DAL SQLITE_DAL)
        {
            string q = " SELECT " + MASTERTABLES.MASTERTABLES_TBL + ".* \r\n";
            q += ", " + DATABASES.DATABASES_TBL + "." + DATABASES.DATABASES_NAME + " \r\n";
            q += ", " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_NAME + " \r\n";
            q += " FROM  " + MASTERTABLES.MASTERTABLES_TBL + " \r\n";
            q += " INNER JOIN  " + DATABASES.DATABASES_TBL + " \r\n";
            q += " ON( " + MASTERTABLES.MASTERTABLES_TBL + "." + DATABASES.DATABASES_ID + " = " + DATABASES.DATABASES_TBL + "." + DATABASES.DATABASES_ID + ")\r\n";
            q += " INNER JOIN  " + NAMESPACES.NAMESPACES_TBL + " \r\n";
            q += " ON( " + MASTERTABLES.MASTERTABLES_TBL + "." + NAMESPACES.NAMESPACES_ID + " = " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_ID + ")\r\n";
            q += " WHERE " + MASTERTABLES.MASTERTABLES_TBL + "." + MASTERTABLES.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " ORDER BY  " + MASTERTABLES.MASTERTABLES_TBL + "." + MASTERTABLES.MASTERTABLES_NAME + ";\r\n";

            return SQLITE_DAL.Listdata(q);
        }

        #endregion[Look up]

        #region[Get id - FieldsName]

        public static string GetName_Id(string _pId)
        {
            MasterTables obj = PKId(_pId);

            if (obj != null)
            {
                return obj.Mastertables_name;
            }
            return "";
        }

        public static string GetId_Name(string _pName)
        {
            MasterTables obj = SearchName(_pName);

            if (obj != null)
            {
                return obj.Mastertables_id;
            }
            return "";
        }

        #endregion[Get id - FieldsName]

    }//cls
}//ns
