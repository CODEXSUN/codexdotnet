// Version : 2.1.0.0 dt : 04-12-2018
// Auto Generated
// last update : 06-12-2018 10:53:54 PM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace AXCODE
{
    public class CMpath_exten
    {
        #region[Entity Data]

        private static MasterTablePath EntityData(string q)
        {
            using (IDataReader redr = new SQLITE_DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    MasterTablePath obj = new MasterTablePath()
                    {
                        Masterpath_id = redr[MASTERPATH.MASTERPATH_ID].ToString(),
                        Mastertables_id = redr[MASTERTABLES.MASTERTABLES_NAME].ToString(),
                        Root_folder = redr[MASTERPATH.ROOT_FOLDER].ToString(),
                        Contfolder = redr[MASTERPATH.CONTFOLDER].ToString(),
                        Classfolder = redr[MASTERPATH.CLASSFOLDER].ToString(),
                        Formfolder = redr[MASTERPATH.FORMFOLDER].ToString(),
                        Listfolder = redr[MASTERPATH.LISTFOLDER].ToString(),
                        Setupfolder = redr[MASTERPATH.SETUPFOLDER].ToString(),
                        Testfolder = redr[MASTERPATH.TESTFOLDER].ToString(),
                        Active_id = redr[MASTERPATH.ACTIVE_ID].ToString(),
                    };
                    return obj;
                }
                redr.Close();
                return new MasterTablePath();
            }
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<MasterTablePath> EntityList(string q)
        {
            List<MasterTablePath> list = new List<MasterTablePath>();

            using (IDataReader redr = new SQLITE_DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    MasterTablePath obj = new MasterTablePath()
                    {
                        Masterpath_id = redr[MASTERPATH.MASTERPATH_ID].ToString(),
                        Mastertables_id = redr[MASTERTABLES.MASTERTABLES_NAME].ToString(),
                        Root_folder = redr[MASTERPATH.ROOT_FOLDER].ToString(),
                        Contfolder = redr[MASTERPATH.CONTFOLDER].ToString(),
                        Classfolder = redr[MASTERPATH.CLASSFOLDER].ToString(),
                        Formfolder = redr[MASTERPATH.FORMFOLDER].ToString(),
                        Listfolder = redr[MASTERPATH.LISTFOLDER].ToString(),
                        Setupfolder = redr[MASTERPATH.SETUPFOLDER].ToString(),
                        Testfolder = redr[MASTERPATH.TESTFOLDER].ToString(),
                        Active_id = redr[MASTERPATH.ACTIVE_ID].ToString(),
                    };

                    list.Add(obj);
                }

                redr.Close();
            }
            return list;
        }

        #endregion[Entity List]

        #region[Active]

        public static List<MasterTablePath> Active(SQLITE_DAL SQLITE_DAL)
        {
            string q = " SELECT " + MASTERPATH.MASTERPATH_TBL + ".* \r\n";
            q += ", " + MASTERTABLES.MASTERTABLES_TBL + "." + MASTERTABLES.MASTERTABLES_NAME + " \r\n";
            q += " FROM  " + MASTERPATH.MASTERPATH_TBL + " \r\n";
            q += " INNER JOIN  " + MASTERTABLES.MASTERTABLES_TBL + " \r\n";
            q += " ON( " + MASTERPATH.MASTERPATH_TBL + "." + MASTERTABLES.MASTERTABLES_ID + " = " + MASTERTABLES.MASTERTABLES_TBL + "." + MASTERTABLES.MASTERTABLES_ID + ")\r\n";
            q += " WHERE " + MASTERPATH.MASTERPATH_TBL + "." + MASTERPATH.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " ORDER BY  " + MASTERPATH.MASTERPATH_TBL + "." + MASTERPATH.MASTERPATH_ID + ";\r\n";

            return EntityList(q);
        }

        #endregion[Active]

        #region[NotActive]

        public static List<MasterTablePath> NotActive(SQLITE_DAL SQLITE_DAL)
        {
            string q = " SELECT " + MASTERPATH.MASTERPATH_TBL + ".* \r\n";
            q += ", " + MASTERTABLES.MASTERTABLES_TBL + "." + MASTERTABLES.MASTERTABLES_NAME + " \r\n";
            q += " FROM  " + MASTERPATH.MASTERPATH_TBL + " \r\n";
            q += " INNER JOIN  " + MASTERTABLES.MASTERTABLES_TBL + " \r\n";
            q += " ON( " + MASTERPATH.MASTERPATH_TBL + "." + MASTERTABLES.MASTERTABLES_ID + " = " + MASTERTABLES.MASTERTABLES_TBL + "." + MASTERTABLES.MASTERTABLES_ID + ")\r\n";
            q += " WHERE " + MASTERPATH.MASTERPATH_TBL + "." + MASTERPATH.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            q += " ORDER BY  " + MASTERPATH.MASTERPATH_TBL + "." + MASTERPATH.MASTERPATH_ID + ";\r\n";

            return EntityList(q);
        }

        #endregion[NotActive]

        #region[Primary Key]

        public static MasterTablePath PKId(string v, SQLITE_DAL SQLITE_DAL)
        {
            string q = " SELECT " + MASTERPATH.MASTERPATH_TBL + ".* \r\n";
            q += ", " + MASTERTABLES.MASTERTABLES_TBL + "." + MASTERTABLES.MASTERTABLES_NAME + " \r\n";
            q += " FROM  " + MASTERPATH.MASTERPATH_TBL + " \r\n";
            q += " INNER JOIN  " + MASTERTABLES.MASTERTABLES_TBL + " \r\n";
            q += " ON( " + MASTERPATH.MASTERPATH_TBL + "." + MASTERTABLES.MASTERTABLES_ID + " = " + MASTERTABLES.MASTERTABLES_TBL + "." + MASTERTABLES.MASTERTABLES_ID + ")\r\n";
            q += " WHERE " + MASTERPATH.MASTERPATH_TBL + "." + MASTERPATH.MASTERPATH_ID + "  = '" + v + "' \r\n";

            return EntityData(q);
        }

        #endregion[Primary Key]

        #region[Search by name]

        public static MasterTablePath SearchName(string v, SQLITE_DAL SQLITE_DAL)
        {
            string q = " SELECT " + MASTERPATH.MASTERPATH_TBL + ".* \r\n";
            q += ", " + MASTERTABLES.MASTERTABLES_TBL + "." + MASTERTABLES.MASTERTABLES_NAME + " \r\n";
            q += " FROM  " + MASTERPATH.MASTERPATH_TBL + " \r\n";
            q += " INNER JOIN  " + MASTERTABLES.MASTERTABLES_TBL + " \r\n";
            q += " ON( " + MASTERPATH.MASTERPATH_TBL + "." + MASTERTABLES.MASTERTABLES_ID + " = " + MASTERTABLES.MASTERTABLES_TBL + "." + MASTERTABLES.MASTERTABLES_ID + ")\r\n";
            q += " WHERE " + MASTERPATH.MASTERPATH_TBL + "." + MASTERPATH.MASTERTABLES_ID + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + MASTERPATH.MASTERPATH_TBL + "." + MASTERPATH.MASTERPATH_ID + ";\r\n";

            return EntityData(q);
        }

        #endregion[Search by name]

        #region[Look up]

        public static DataTable GetforLookup(SQLITE_DAL SQLITE_DAL)
        {
            string q = " SELECT " + MASTERPATH.MASTERPATH_TBL + ".* \r\n";
            q += ", " + MASTERTABLES.MASTERTABLES_TBL + "." + MASTERTABLES.MASTERTABLES_NAME + " \r\n";
            q += " FROM  " + MASTERPATH.MASTERPATH_TBL + " \r\n";
            q += " INNER JOIN  " + MASTERTABLES.MASTERTABLES_TBL + " \r\n";
            q += " ON( " + MASTERPATH.MASTERPATH_TBL + "." + MASTERTABLES.MASTERTABLES_ID + " = " + MASTERTABLES.MASTERTABLES_TBL + "." + MASTERTABLES.MASTERTABLES_ID + ")\r\n";
            q += " WHERE " + MASTERPATH.MASTERPATH_TBL + "." + MASTERPATH.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " ORDER BY  " + MASTERPATH.MASTERPATH_TBL + "." + MASTERPATH.MASTERPATH_ID + ";\r\n";

            return SQLITE_DAL.Listdata(q);
        }

        #endregion[Look up]

        #region[Get id - Fieldsname]

        public static string GetName_Id(string _pId)
        {
            MasterTablePath obj = PKId(_pId, new SQLITE_DAL());

            if (obj != null)
            {
                return obj.Mastertables_id;
            }
            return "";
        }

        public static string GetId_Name(string _pName)
        {
            MasterTablePath obj = SearchName(_pName, new SQLITE_DAL());

            if (obj != null)
            {
                return obj.Masterpath_id;
            }
            return "";
        }

        #endregion[Get id - Fieldsname]

    }//cls
}//ns
