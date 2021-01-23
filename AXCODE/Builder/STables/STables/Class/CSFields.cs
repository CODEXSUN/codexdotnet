// Version : 2.0.0.0 dt : 16-10-2018
// Auto Generated
// last update : 18-11-2018 09:30:51 PM

using System.Collections.Generic;
using CXLIB;

namespace AXCODE
{
    public class CSFields
    {

        #region[Get New]

        public static List<SFields> GetNew
        {
            get
            {
                List<SFields> list = new List<SFields>();

                SFields obj = new SFields()
                {
                    Sfields_id = string.Empty,
                    Stables_id = string.Empty,
                    Fieldsname = string.Empty,
                    Displayname = string.Empty,
                    Datatype = string.Empty,
                    Inputtype = string.Empty,
                    Width = string.Empty,
                    Height = string.Empty,
                    Cposition = string.Empty,
                    Rposition = string.Empty,
                    Alignto = string.Empty,
                    Validate = string.Empty,
                    Isdefault = string.Empty,
                    Placement = string.Empty,
                    Readonly = string.Empty,
                     
                };
                list.Add(obj);
                return list;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, SFields v)
        {
            //q = q.Replace("@" + SFIELDS.SFIELDS_ID + "@", "" + ConvertTO.SqlString(v.Sfields_id) + "");
            q = q.Replace("@" + SFIELDS.STABLES_ID + "@", "" + ConvertTO.SqlString(v.Stables_id) + "");
            q = q.Replace("@" + SFIELDS.FIELDSNAME + "@", "" + ConvertTO.SqlString(v.Fieldsname) + "");
            q = q.Replace("@" + SFIELDS.DISPLAY_NAME + "@", "" + ConvertTO.SqlString(v.Displayname) + "");
            q = q.Replace("@" + SFIELDS.DATATYPE + "@", "" + ConvertTO.SqlString(v.Datatype + "") + "");
            q = q.Replace("@" + SFIELDS.INPUTTYPE + "@", "" + ConvertTO.SqlString(v.Inputtype) + "");
            q = q.Replace("@" + SFIELDS.WIDTH + "@", "" + ConvertTO.SqlString(v.Width) + "");
            q = q.Replace("@" + SFIELDS.HEIGHT + "@", "" + ConvertTO.SqlString(v.Height) + "");
            q = q.Replace("@" + SFIELDS.CPOSITION + "@", "" + ConvertTO.SqlString(v.Cposition) + "");
            q = q.Replace("@" + SFIELDS.RPOSITION + "@", "" + ConvertTO.SqlString(v.Rposition) + "");
            q = q.Replace("@" + SFIELDS.ALIGNTO + "@", "" + ConvertTO.SqlString(v.Alignto) + "");
            q = q.Replace("@" + SFIELDS.VALIDATE + "@", "" + ConvertTO.SqlString(v.Validate) + "");
            q = q.Replace("@" + SFIELDS.ISDEFAULT + "@", "" + ConvertTO.SqlString(v.Isdefault) + "");
            q = q.Replace("@" + SFIELDS.PLACEMENT + "@", "" + ConvertTO.SqlString(v.Placement) + "");
            q = q.Replace("@" + SFIELDS.READONLY + "@", "" + ConvertTO.SqlString(v.Readonly) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(List<SFields> list, SQLITE_DAL dalsession)
        {
            for (int i = 0; i < list.Count; i++)
            {
                SFields obj = new SFields()
                {
                    //Sfields_id = list[i].Sfields_id,
                    Stables_id = list[i].Stables_id,
                    Fieldsname = list[i].Fieldsname,
                    Displayname = list[i].Displayname,
                    Datatype = list[i].Datatype,
                    Inputtype = list[i].Inputtype,
                    Width = list[i].Width,
                    Height = list[i].Height,
                    Cposition = list[i].Cposition,
                    Rposition = list[i].Rposition,
                    Alignto = list[i].Alignto,
                    Validate = list[i].Validate,
                    Isdefault = list[i].Isdefault,
                    Placement = list[i].Placement,
                    Readonly = list[i].Readonly
                };
                InsertSub(obj, dalsession);
            }
        }

        #endregion[Insert]

        #region[InsertSub]

        public static void InsertSub(SFields v, SQLITE_DAL dalsession)
        {
            string q = " INSERT INTO " + SFIELDS.SFIELDS_TBL + " ( ";
            //q += " " + SFIELDS.SFIELDS_ID + " \r\n ";
            q += "" + SFIELDS.STABLES_ID + " \r\n ";
            q += "," + SFIELDS.FIELDSNAME + " \r\n ";
            q += "," + SFIELDS.DISPLAY_NAME + " \r\n ";
            q += "," + SFIELDS.DATATYPE + " \r\n ";
            q += "," + SFIELDS.INPUTTYPE + " \r\n ";
            q += "," + SFIELDS.WIDTH + " \r\n ";
            q += "," + SFIELDS.HEIGHT + " \r\n ";
            q += "," + SFIELDS.CPOSITION + " \r\n ";
            q += "," + SFIELDS.RPOSITION + " \r\n ";
            q += "," + SFIELDS.ALIGNTO + " \r\n ";
            q += "," + SFIELDS.VALIDATE + " \r\n ";
            q += "," + SFIELDS.ISDEFAULT + " \r\n ";
            q += "," + SFIELDS.PLACEMENT + " \r\n ";
            q += "," + SFIELDS.READONLY + " \r\n ";
            q += " ) VALUES ( ";
            //q += "  @" + SFIELDS.SFIELDS_ID + "@ \r\n ";
            q += " @" + SFIELDS.STABLES_ID + "@ \r\n ";
            q += ", @" + SFIELDS.FIELDSNAME + "@ \r\n ";
            q += ", @" + SFIELDS.DISPLAY_NAME + "@ \r\n ";
            q += ", @" + SFIELDS.DATATYPE + "@ \r\n ";
            q += ", @" + SFIELDS.INPUTTYPE + "@ \r\n ";
            q += ", @" + SFIELDS.WIDTH + "@ \r\n ";
            q += ", @" + SFIELDS.HEIGHT + "@ \r\n ";
            q += ", @" + SFIELDS.CPOSITION + "@ \r\n ";
            q += ", @" + SFIELDS.RPOSITION + "@ \r\n ";
            q += ", @" + SFIELDS.ALIGNTO + "@ \r\n ";
            q += ", @" + SFIELDS.VALIDATE + "@ \r\n ";
            q += ", @" + SFIELDS.ISDEFAULT + "@ \r\n ";
            q += ", @" + SFIELDS.PLACEMENT + "@ \r\n ";
            q += ", @" + SFIELDS.READONLY + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Delete]

        public static void Delete(string fkid, SQLITE_DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + SFIELDS.SFIELDS_TBL + " WHERE " + SFIELDS.STABLES_ID + " =  " + fkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
