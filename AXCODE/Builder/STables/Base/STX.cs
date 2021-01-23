using System.Collections.Generic;
using System.Data;

namespace AXCODE
{
    public class STX
    {
        public static BillTable Logics(int stable_id)
        {
            BillTable st = new BillTable()
            {
                STables = GetSTables(stable_id),
                SFields = GetSFields(stable_id),
                SFieldsItems = GetSFieldsItems(stable_id),
                SPath = GetSPath(stable_id),
            };
            return st;
        }

        private static Stables GetSTables(int stable_id)
        {
            string q = "SELECT " + STABLES.STABLES_TBL + ".* \r\n";
            q += ", " + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_NAME + " \r\n";
            q += ", " + DATABASES.DATABASES_TBL + "." + DATABASES.DATABASES_NAME + " \r\n";
            q += " FROM " + STABLES.STABLES_TBL + " \r\n";

            q += " INNER JOIN  " + NAMESPACES.NAMESPACES_TBL + "\r\n";
            q += " ON(" + NAMESPACES.NAMESPACES_TBL + "." + NAMESPACES.NAMESPACES_ID + " = " + STABLES.STABLES_TBL + "." + STABLES.NAMESPACES_ID + " )\r\n";

            q += " INNER JOIN  " + DATABASES.DATABASES_TBL + "\r\n";
            q += " ON(" + DATABASES.DATABASES_TBL + "." + DATABASES.DATABASES_ID + " = " + STABLES.STABLES_TBL + "." + STABLES.DATABASES_ID + " )\r\n";

            q += " WHERE  " + STABLES.STABLES_ID + " =" + stable_id;

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
                        Databases_id = redr[DATABASES.DATABASES_NAME].ToString()
                    };
                    return obj;
                }
                return new Stables();
            }
        }

        private static List<SFields> GetSFields(int stable_id)
        {
            string q = "SELECT * FROM " + SFIELDS.SFIELDS_TBL + " WHERE  " + STABLES.STABLES_ID + " =" + stable_id;

            List<SFields> list = new List<SFields>();

            using (IDataReader redr = new SQLITE_DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    SFields obj = new SFields()
                    {
                        Sfields_id = redr[SFIELDS.SFIELDS_ID].ToString(),
                        Stables_id = redr[SFIELDS.STABLES_ID].ToString(),
                        Fieldsname = redr[SFIELDS.FIELDSNAME].ToString(),
                        Displayname = redr[SFIELDS.DISPLAY_NAME].ToString(),
                        Datatype = redr[SFIELDS.DATATYPE].ToString(),
                        //Lengths = redr[SFIELDS.LENGTHS].ToString(),
                        //Pkeys = redr[SFIELDS.PKEYS].ToString(),
                        //Ifnull = redr[SFIELDS.IFNULL].ToString(),
                        //Refered_tbl = redr[SFIELDS.REFEREDTBL].ToString(),
                        Inputtype = redr[SFIELDS.INPUTTYPE].ToString(),
                        Width = redr[SFIELDS.WIDTH].ToString(),
                        Height = redr[SFIELDS.HEIGHT].ToString(),
                        Cposition = redr[SFIELDS.CPOSITION].ToString(),
                        Rposition = redr[SFIELDS.RPOSITION].ToString(),
                        Validate = redr[SFIELDS.VALIDATE].ToString(),
                        Isdefault = redr[SFIELDS.ISDEFAULT].ToString(),
                        Placement = redr[SFIELDS.PLACEMENT].ToString()

                    };

                    list.Add(obj);
                }

            }
            return list;
        }


        private static List<SFieldsItems> GetSFieldsItems(int stable_id)
        {
            string q = "SELECT * FROM " + SFIELDSITEMS.SFIELDSITEMS_TBL + " WHERE  " + STABLES.STABLES_ID + " =" + stable_id;

            List<SFieldsItems> list = new List<SFieldsItems>();

            using (IDataReader redr = new SQLITE_DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    SFieldsItems obj = new SFieldsItems()
                    {
                        Sfields_id = redr[SFIELDSITEMS.SFIELDSITEMS_ID].ToString(),
                        Stables_id = redr[SFIELDSITEMS.STABLES_ID].ToString(),
                        Fieldsname = redr[SFIELDSITEMS.FIELDSNAME].ToString(),
                        Displayname = redr[SFIELDSITEMS.DISPLAY_NAME].ToString(),
                        Datatype = redr[SFIELDSITEMS.DATATYPE].ToString(),
                        //Lengths = redr[SFIELDSITEMS.LENGTHS].ToString(),
                        //Pkeys = redr[SFIELDSITEMS.PKEYS].ToString(),
                        //Ifnull = redr[SFIELDSITEMS.IFNULL].ToString(),
                        //Refered_tbl = redr[SFIELDSITEMS.REFEREDTBL].ToString(),
                        Inputtype = redr[SFIELDSITEMS.INPUTTYPE].ToString(),
                        Width = redr[SFIELDSITEMS.WIDTH].ToString(),

                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        private static Spath GetSPath(int stable_id)
        {
            string q = "SELECT * FROM " + SPATH.SPATH_TBL + " WHERE  " + STABLES.STABLES_ID + " =" + stable_id;

            using (IDataReader redr = new SQLITE_DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Spath obj = new Spath()
                    {
                        Contfolder = redr[SPATH.CONTFOLDER].ToString(),
                        Classfolder = redr[SPATH.CLASSFOLDER].ToString(),
                        Formfolder = redr[SPATH.FORMFOLDER].ToString(),
                        Listfolder = redr[SPATH.LISTFOLDER].ToString(),
                        Setupfolder = redr[SPATH.SETUPFOLDER].ToString(),
                        Testfolder = redr[SPATH.TESTFOLDER].ToString()
                    };
                    return obj;
                }
                return new Spath();
            }

        }
    }
}
