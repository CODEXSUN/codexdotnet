// Version : 2.1.0.0 dt : 04-12-2018
// Auto Generated
// last update : 06-12-2018 10:53:54 PM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace AXCODE
{
    public class CSpath_exten
    {
        #region[Entity Data]

        private static Spath EntityData(string q)
        {
            using (IDataReader redr = new SQLITE_DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Spath obj = new Spath()
                    {
                        Spath_id = redr[SPATH.SPATH_ID].ToString(),
                        Stables_id = redr[STABLES.STABLES_NAME].ToString(),
                        Root_folder = redr[SPATH.ROOT_FOLDER].ToString(),
                        Contfolder = redr[SPATH.CONTFOLDER].ToString(),
                        Classfolder = redr[SPATH.CLASSFOLDER].ToString(),
                        Formfolder = redr[SPATH.FORMFOLDER].ToString(),
                        Listfolder = redr[SPATH.LISTFOLDER].ToString(),
                        Setupfolder = redr[SPATH.SETUPFOLDER].ToString(),
                        Testfolder = redr[SPATH.TESTFOLDER].ToString(),
                        Active_id = redr[SPATH.ACTIVE_ID].ToString(),
                    };
                    return obj;
                }
                redr.Close();
                return new Spath();
            }
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<Spath> EntityList(string q)
        {
            List<Spath> list = new List<Spath>();

            using (IDataReader redr = new SQLITE_DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Spath obj = new Spath()
                    {
                        Spath_id = redr[SPATH.SPATH_ID].ToString(),
                        Stables_id = redr[STABLES.STABLES_NAME].ToString(),
                        Root_folder = redr[SPATH.ROOT_FOLDER].ToString(),
                        Contfolder = redr[SPATH.CONTFOLDER].ToString(),
                        Classfolder = redr[SPATH.CLASSFOLDER].ToString(),
                        Formfolder = redr[SPATH.FORMFOLDER].ToString(),
                        Listfolder = redr[SPATH.LISTFOLDER].ToString(),
                        Setupfolder = redr[SPATH.SETUPFOLDER].ToString(),
                        Testfolder = redr[SPATH.TESTFOLDER].ToString(),
                        Active_id = redr[SPATH.ACTIVE_ID].ToString(),
                    };

                    list.Add(obj);
                }

                redr.Close();
            }
            return list;
        }

        #endregion[Entity List]

        #region[Active]

        public static List<Spath> Active(SQLITE_DAL SQLITE_DAL)
        {
            string q = " SELECT " + SPATH.SPATH_TBL + ".* \r\n";
            q += ", " + STABLES.STABLES_TBL + "." + STABLES.STABLES_NAME + " \r\n";
            q += " FROM  " + SPATH.SPATH_TBL + " \r\n";
            q += " INNER JOIN  " + STABLES.STABLES_TBL + " \r\n";
            q += " ON( " + SPATH.SPATH_TBL + "." + STABLES.STABLES_ID + " = " + STABLES.STABLES_TBL + "." + STABLES.STABLES_ID + ")\r\n";
            q += " WHERE " + SPATH.SPATH_TBL + "." + SPATH.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " ORDER BY  " + SPATH.SPATH_TBL + "." + SPATH.SPATH_ID + ";\r\n";

            return EntityList(q);
        }

        #endregion[Active]

        #region[NotActive]

        public static List<Spath> NotActive(SQLITE_DAL SQLITE_DAL)
        {
            string q = " SELECT " + SPATH.SPATH_TBL + ".* \r\n";
            q += ", " + STABLES.STABLES_TBL + "." + STABLES.STABLES_NAME + " \r\n";
            q += " FROM  " + SPATH.SPATH_TBL + " \r\n";
            q += " INNER JOIN  " + STABLES.STABLES_TBL + " \r\n";
            q += " ON( " + SPATH.SPATH_TBL + "." + STABLES.STABLES_ID + " = " + STABLES.STABLES_TBL + "." + STABLES.STABLES_ID + ")\r\n";
            q += " WHERE " + SPATH.SPATH_TBL + "." + SPATH.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            q += " ORDER BY  " + SPATH.SPATH_TBL + "." + SPATH.SPATH_ID + ";\r\n";

            return EntityList(q);
        }

        #endregion[NotActive]

        #region[Primary Key]

        public static Spath PKId(string v, SQLITE_DAL SQLITE_DAL)
        {
            string q = " SELECT " + SPATH.SPATH_TBL + ".* \r\n";
            q += ", " + STABLES.STABLES_TBL + "." + STABLES.STABLES_NAME + " \r\n";
            q += " FROM  " + SPATH.SPATH_TBL + " \r\n";
            q += " INNER JOIN  " + STABLES.STABLES_TBL + " \r\n";
            q += " ON( " + SPATH.SPATH_TBL + "." + STABLES.STABLES_ID + " = " + STABLES.STABLES_TBL + "." + STABLES.STABLES_ID + ")\r\n";
            q += " WHERE " + SPATH.SPATH_TBL + "." + SPATH.SPATH_ID + "  = '" + v + "' \r\n";

            return EntityData(q);
        }

        #endregion[Primary Key]

        #region[Search by name]

        public static Spath SearchName(string v, SQLITE_DAL SQLITE_DAL)
        {
            string q = " SELECT " + SPATH.SPATH_TBL + ".* \r\n";
            q += ", " + STABLES.STABLES_TBL + "." + STABLES.STABLES_NAME + " \r\n";
            q += " FROM  " + SPATH.SPATH_TBL + " \r\n";
            q += " INNER JOIN  " + STABLES.STABLES_TBL + " \r\n";
            q += " ON( " + SPATH.SPATH_TBL + "." + STABLES.STABLES_ID + " = " + STABLES.STABLES_TBL + "." + STABLES.STABLES_ID + ")\r\n";
            q += " WHERE " + SPATH.SPATH_TBL + "." + SPATH.STABLES_ID + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + SPATH.SPATH_TBL + "." + SPATH.SPATH_ID + ";\r\n";

            return EntityData(q);
        }

        #endregion[Search by name]

        #region[Look up]

        public static DataTable GetforLookup(SQLITE_DAL SQLITE_DAL)
        {
            string q = " SELECT " + SPATH.SPATH_TBL + ".* \r\n";
            q += ", " + STABLES.STABLES_TBL + "." + STABLES.STABLES_NAME + " \r\n";
            q += " FROM  " + SPATH.SPATH_TBL + " \r\n";
            q += " INNER JOIN  " + STABLES.STABLES_TBL + " \r\n";
            q += " ON( " + SPATH.SPATH_TBL + "." + STABLES.STABLES_ID + " = " + STABLES.STABLES_TBL + "." + STABLES.STABLES_ID + ")\r\n";
            q += " WHERE " + SPATH.SPATH_TBL + "." + SPATH.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " ORDER BY  " + SPATH.SPATH_TBL + "." + SPATH.SPATH_ID + ";\r\n";

            return SQLITE_DAL.Listdata(q);
        }

        #endregion[Look up]

        #region[Get id - Fieldsname]

        public static string GetName_Id(string _pId)
        {
            Spath obj = PKId(_pId, new SQLITE_DAL());

            if (obj != null)
            {
                return obj.Stables_id;
            }
            return "";
        }

        public static string GetId_Name(string _pName)
        {
            Spath obj = SearchName(_pName, new SQLITE_DAL());

            if (obj != null)
            {
                return obj.Spath_id;
            }
            return "";
        }

        #endregion[Get id - Fieldsname]

    }//cls
}//ns
