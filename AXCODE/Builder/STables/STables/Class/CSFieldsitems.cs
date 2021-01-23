// Version : 2.0.0.0 dt : 16-10-2018
// Auto Generated
// last update : 18-11-2018 09:30:51 PM

using System.Collections.Generic;
using CXLIB;

namespace AXCODE
{
    public class CSFieldsitem
    {

        #region[Get New]

        public static List<SFieldsItems> GetNew
        {
            get
            {
                List<SFieldsItems> list = new List<SFieldsItems>();

                SFieldsItems obj = new SFieldsItems()
                {
                    Sfields_id = string.Empty,
                    Stables_id = string.Empty,
                    Fieldsname = string.Empty,
                    Displayname = string.Empty,
                    //Datatype = string.Empty,
                    //Lengths = string.Empty,
                    //Pkeys = string.Empty,
                    //Ifnull = string.Empty,
                    //Refered_tbl = string.Empty,
                    Inputtype = string.Empty,
                    Width = string.Empty,

                };
                list.Add(obj);
                return list;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, SFieldsItems v)
        {
            //q = q.Replace("@" + SFIELDSITEMS.SFIELDS_ID + "@", "" + ConvertTO.SqlString(v.Sfields_id) + "");
            q = q.Replace("@" + SFIELDSITEMS.STABLES_ID + "@", "" + ConvertTO.SqlString(v.Stables_id) + "");
            q = q.Replace("@" + SFIELDSITEMS.FIELDSNAME + "@", "" + ConvertTO.SqlString(v.Fieldsname) + "");
            q = q.Replace("@" + SFIELDSITEMS.DISPLAY_NAME + "@", "" + ConvertTO.SqlString(v.Displayname) + "");
            q = q.Replace("@" + SFIELDSITEMS.DATATYPE + "@", "" + ConvertTO.SqlString(v.Datatype + "") + "");
            //q = q.Replace("@" + SFIELDSITEMS.LENGTHS + "@", "" + ConvertTO.SqlString(v.Lengths) + "");
            //q = q.Replace("@" + SFIELDSITEMS.PKEYS + "@", "" + ConvertTO.SqlString(v.Pkeys) + "");
            //q = q.Replace("@" + SFIELDSITEMS.IFNULL + "@", "" + ConvertTO.SqlString(v.Ifnull) + "");
            //q = q.Replace("@" + SFIELDSITEMS.REFEREDTBL + "@", "" + ConvertTO.SqlString(v.Refered_tbl) + "");
            q = q.Replace("@" + SFIELDSITEMS.INPUTTYPE + "@", "" + ConvertTO.SqlString(v.Inputtype) + "");
            q = q.Replace("@" + SFIELDSITEMS.WIDTH + "@", "" + ConvertTO.SqlString(v.Width) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(List<SFieldsItems> list, SQLITE_DAL dalsession)
        {
            for (int i = 0; i < list.Count; i++)
            {
                SFieldsItems obj = new SFieldsItems()
                {
                    //Sfields_id = list[i].Sfields_id,
                    Stables_id = list[i].Stables_id,
                    Fieldsname = list[i].Fieldsname,
                    Displayname = list[i].Displayname,
                    Datatype = list[i].Datatype,
                    //Lengths = list[i].Lengths,
                    //Pkeys = list[i].Pkeys,
                    //Ifnull = list[i].Ifnull,
                    //Refered_tbl = list[i].Refered_tbl,
                    Inputtype = list[i].Inputtype,
                    Width = list[i].Width,
                };
                InsertSub(obj, dalsession);
            }
        }

        #endregion[Insert]

        #region[InsertSub]

        public static void InsertSub(SFieldsItems v, SQLITE_DAL dalsession)
        {
            string q = " INSERT INTO " + SFIELDSITEMS.SFIELDSITEMS_TBL + " ( ";
            //q += " " + SFIELDSITEMS.SFIELDS_ID + " \r\n ";
            q += "" + SFIELDSITEMS.STABLES_ID + " \r\n ";
            q += "," + SFIELDSITEMS.FIELDSNAME + " \r\n ";
            q += "," + SFIELDSITEMS.DISPLAY_NAME + " \r\n ";
            q += "," + SFIELDSITEMS.DATATYPE + " \r\n ";
            //q += "," + SFIELDSITEMS.LENGTHS + " \r\n ";
            //q += "," + SFIELDSITEMS.PKEYS + " \r\n ";
            //q += "," + SFIELDSITEMS.IFNULL + " \r\n ";
            //q += "," + SFIELDSITEMS.REFEREDTBL + " \r\n ";
            q += "," + SFIELDSITEMS.INPUTTYPE + " \r\n ";
            q += "," + SFIELDSITEMS.WIDTH + " \r\n ";
            q += " ) VALUES ( ";
            //q += "  @" + SFIELDSITEMS.SFIELDS_ID + "@ \r\n ";
            q += " @" + SFIELDSITEMS.STABLES_ID + "@ \r\n ";
            q += ", @" + SFIELDSITEMS.FIELDSNAME + "@ \r\n ";
            q += ", @" + SFIELDSITEMS.DISPLAY_NAME + "@ \r\n ";
            q += ", @" + SFIELDSITEMS.DATATYPE + "@ \r\n ";
            //q += ", @" + SFIELDSITEMS.LENGTHS + "@ \r\n ";
            //q += ", @" + SFIELDSITEMS.PKEYS + "@ \r\n ";
            //q += ", @" + SFIELDSITEMS.IFNULL + "@ \r\n ";
            //q += ", @" + SFIELDSITEMS.REFEREDTBL + "@ \r\n ";
            q += ", @" + SFIELDSITEMS.INPUTTYPE + "@ \r\n ";
            q += ", @" + SFIELDSITEMS.WIDTH + "@ \r\n ";

            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Delete]

        public static void Delete(string fkid, SQLITE_DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + SFIELDSITEMS.SFIELDSITEMS_TBL + " WHERE " + SFIELDSITEMS.STABLES_ID + " =  " + fkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
