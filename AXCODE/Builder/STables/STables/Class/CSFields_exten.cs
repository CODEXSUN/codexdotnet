// Version : 2.0.0.0 dt : 16-10-2018
// Auto Generated
// 18-11-2018 10:03:03 PM
// last update : 18-11-2018

using System.Data;
using System.Collections.Generic;

namespace AXCODE
{
    public class CSFields_exten
    {
        #region[Entity List] 

        private static List<SFields> EntityList(string q)
        {
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
                        Alignto = redr[SFIELDS.ALIGNTO].ToString(),
                        Validate = redr[SFIELDS.VALIDATE].ToString(),
                        Isdefault = redr[SFIELDS.ISDEFAULT].ToString(),
                        Placement = redr[SFIELDS.PLACEMENT].ToString(),
                        Readonly = redr[SFIELDS.READONLY].ToString(),

                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        #endregion[Entity List] 

        #region[FKId] 

        public static List<SFields> FKId(string id, SQLITE_DAL SQLITE_DAL)
        {
            string q = " SELECT " + SFIELDS.SFIELDS_TBL + ".* \r\n";
            q += " FROM  " + SFIELDS.SFIELDS_TBL + " \r\n";
            q += " WHERE " + SFIELDS.SFIELDS_TBL + "." + STABLES.STABLES_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + SFIELDS.SFIELDS_TBL + "." + SFIELDS.SFIELDS_ID + ";\r\n";

            return EntityList(q);
        }

        #endregion[FKId] 

    }//cls
}//ns
