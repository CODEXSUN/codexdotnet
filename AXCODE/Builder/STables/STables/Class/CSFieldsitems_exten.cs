// Version : 2.0.0.0 dt : 16-10-2018
// Auto Generated
// 18-11-2018 10:03:03 PM
// last update : 18-11-2018

using System.Data;
using System.Collections.Generic;

namespace AXCODE
{
    public class CSFieldsitems_exten
    {
        #region[Entity List] 

        private static List<SFieldsItems> EntityList(string q)
        {
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
                        Width = redr[SFIELDSITEMS.WIDTH].ToString()
                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        #endregion[Entity List] 

        #region[FKId] 

        public static List<SFieldsItems> FKId(string id, SQLITE_DAL SQLITE_DAL)
        {
            string q = " SELECT " + SFIELDSITEMS.SFIELDSITEMS_TBL + ".* \r\n";
            q += " FROM  " + SFIELDSITEMS.SFIELDSITEMS_TBL + " \r\n";
            q += " WHERE " + SFIELDSITEMS.SFIELDSITEMS_TBL + "." + STABLES.STABLES_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + SFIELDSITEMS.SFIELDSITEMS_TBL + "." + SFIELDSITEMS.SFIELDSITEMS_ID + ";\r\n";

            return EntityList(q);
        }

        #endregion[FKId] 

    }//cls
}//ns
