using System.Collections.Generic;
using System.Data;

namespace AXCODE
{
    public class MTX
    {
        public static MasterDetails Logics(int table_id)
        {
            MasterDetails mt = new MasterDetails()
            {
                Mastertable = GetTables(table_id),
                Mastertablesitems = GetFields(table_id),
                Mastertablepath = GetPath(table_id),
            };
            return mt;
        }

        private static MasterTables GetTables(int table_id)
        {
            string q = "SELECT " + MASTERTABLES.MASTERTABLES_TBL + ".* \r\n";
            q += ", " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_NAME + " \r\n";
            q += ", " + DATABASES.DATABASES_TBL + "." + DATABASES.DATABASES_NAME + " \r\n";
            q += " FROM " + MASTERTABLES.MASTERTABLES_TBL + " \r\n";

            q += " INNER JOIN  " + NAMESPACES.NAMESPACES_TBL + "\r\n";
            q += " ON(" + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_ID + " = " + MASTERTABLES.MASTERTABLES_TBL + "." + MASTERTABLES.NAMESPACES_ID + " )\r\n";

            q += " INNER JOIN  " + DATABASES.DATABASES_TBL + "\r\n";
            q += " ON(" + DATABASES.DATABASES_TBL + "." + DATABASES.DATABASES_ID + " = " + MASTERTABLES.MASTERTABLES_TBL + "." + MASTERTABLES.DATABASES_ID + " )\r\n";

            q += " WHERE  " + MASTERTABLES.MASTERTABLES_ID + " =" + table_id;

            using (IDataReader redr = new SQLITE_DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    MasterTables obj = new MasterTables()
                    {
                        Mastertables_id = redr[MASTERTABLES.MASTERTABLES_ID].ToString(),
                        Mastertables_name = redr[MASTERTABLES.MASTERTABLES_NAME].ToString(),
                        Alias = redr[MASTERTABLES.ALIAS].ToString(),
                        Namespaces_id = redr[NAMESPACES.NAMESPACES_NAME].ToString(),
                        Databases_id = redr[DATABASES.DATABASES_NAME].ToString()
                    };
                    return obj;
                }
                return new MasterTables();
            }
        }

        private static List<MasterTablesItems> GetFields(int table_id)
        {
            string q = "SELECT * FROM " + MASTERTABLESITEMS.MASTERTABLESITEMS_TBL + " WHERE  " + MASTERTABLES.MASTERTABLES_ID + " =" + table_id;

            List<MasterTablesItems> list = new List<MasterTablesItems>();

            using (IDataReader redr = new SQLITE_DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    MasterTablesItems obj = new MasterTablesItems()
                    {
                        Mtablesitems_id = redr[MASTERTABLESITEMS.MASTERTABLESITEMS_ID].ToString(),
                        Mtables_id = redr[MASTERTABLESITEMS.MASTERTABLES_ID].ToString(),
                        Fieldsname = redr[MASTERTABLESITEMS.FIELDSNAME].ToString(),
                        Displayname = redr[MASTERTABLESITEMS.DISPLAYNAME].ToString(),
                        Datatype = redr[MASTERTABLESITEMS.DATATYPE].ToString(),
                        Inputtype = redr[MASTERTABLESITEMS.INPUTTYPE].ToString(),
                        Width = redr[MASTERTABLESITEMS.WIDTH].ToString(),
                        Height = redr[MASTERTABLESITEMS.HEIGHT].ToString(),
                        Cposition = redr[MASTERTABLESITEMS.CPOSITION].ToString(),
                        Rposition = redr[MASTERTABLESITEMS.RPOSITION].ToString(),
                        Validate = redr[MASTERTABLESITEMS.VALIDATE].ToString(),
                        Isdefault = redr[MASTERTABLESITEMS.ISDEFAULT].ToString(),
                        Placement = redr[MASTERTABLESITEMS.PLACEMENT].ToString(),
                        Alignto = redr[MASTERTABLESITEMS.ALIGNTO].ToString(),


                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        private static MasterTablePath GetPath(int table_id)
        {
            string q = "SELECT * FROM " + MASTERPATH.MASTERPATH_TBL + " WHERE  " + MASTERTABLES.MASTERTABLES_ID + " =" + table_id;

            using (IDataReader redr = new SQLITE_DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    MasterTablePath obj = new MasterTablePath()
                    {
                        Contfolder = redr[MASTERPATH.CONTFOLDER].ToString(),
                        Classfolder = redr[MASTERPATH.CLASSFOLDER].ToString(),
                        Formfolder = redr[MASTERPATH.FORMFOLDER].ToString(),
                        Listfolder = redr[MASTERPATH.LISTFOLDER].ToString(),
                        Setupfolder = redr[MASTERPATH.SETUPFOLDER].ToString(),
                        Testfolder = redr[MASTERPATH.TESTFOLDER].ToString()
                    };
                    return obj;
                }
                return new MasterTablePath();
            }

        }
    }
}
