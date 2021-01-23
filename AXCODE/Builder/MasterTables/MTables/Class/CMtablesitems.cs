// Version : 2.1.0.0 dt : 04-12-2018
// Auto Generated
// last update : 05-12-2018 01:26:34 PM

using System.Collections.Generic;
using CXLIB;

namespace AXCODE
{
    public class CMtablesitems 
    {

        #region[Get New]

        public static List<MasterTablesItems> GetNew
        {
            get
            {
            List<MasterTablesItems> list = new List<MasterTablesItems>();

                MasterTablesItems obj = new MasterTablesItems()
                {
                    Mtablesitems_id = string.Empty,
                    Fieldsname = string.Empty,
                    Mtables_id = string.Empty,
                    Displayname = string.Empty,
                    Datatype = string.Empty,
                    Inputtype = string.Empty,
                    Width = string.Empty,
                    Height = string.Empty,
                    Cposition = string.Empty,
                    Rposition = string.Empty,
                    Validate = string.Empty,
                    Isdefault = string.Empty,
                    Placement = string.Empty,
                    Alignto = string.Empty,
                };
                list.Add(obj);
                return list;
            }
        }

        #endregion[Get New]

        #region[Attach params]
        
        private static string AttachParams(string q, MasterTablesItems v)
        {
            q = q.Replace("@" + MASTERTABLESITEMS.FIELDSNAME + "@", "" + ConvertTO.SqlString(v.Fieldsname) + "");
            q = q.Replace("@" + MASTERTABLESITEMS.MASTERTABLES_ID + "@", "" + ConvertTO.SqlString(v.Mtables_id) + "");
            q = q.Replace("@" + MASTERTABLESITEMS.DISPLAYNAME + "@", "" + ConvertTO.SqlString(v.Displayname) + "");
            q = q.Replace("@" + MASTERTABLESITEMS.DATATYPE + "@", "" + ConvertTO.SqlString(v.Datatype) + "");
            q = q.Replace("@" + MASTERTABLESITEMS.INPUTTYPE + "@", "" + ConvertTO.SqlString(v.Inputtype) + "");
            q = q.Replace("@" + MASTERTABLESITEMS.WIDTH + "@", "" + ConvertTO.SqlString(v.Width) + "");
            q = q.Replace("@" + MASTERTABLESITEMS.HEIGHT + "@", "" + ConvertTO.SqlString(v.Height) + "");
            q = q.Replace("@" + MASTERTABLESITEMS.CPOSITION + "@", "" + ConvertTO.SqlString(v.Cposition) + "");
            q = q.Replace("@" + MASTERTABLESITEMS.RPOSITION + "@", "" + ConvertTO.SqlString(v.Rposition) + "");
            q = q.Replace("@" + MASTERTABLESITEMS.VALIDATE + "@", "" + ConvertTO.SqlString(v.Validate) + "");
            q = q.Replace("@" + MASTERTABLESITEMS.ISDEFAULT + "@", "" + ConvertTO.SqlString(v.Isdefault) + "");
            q = q.Replace("@" + MASTERTABLESITEMS.PLACEMENT + "@", "" + ConvertTO.SqlString(v.Placement) + "");
            q = q.Replace("@" + MASTERTABLESITEMS.ALIGNTO + "@", "" + ConvertTO.SqlString(v.Alignto) + "");
            return q;
        }
        #endregion[Attach params]
        
        #region[Insert]
        
        public static void Insert(List<MasterTablesItems> list, SQLITE_DAL dalsession)
        {
            for (int i = 0; i < list.Count; i++)
            {
                MasterTablesItems obj = new MasterTablesItems()
                {
                    Fieldsname = list[i].Fieldsname,
                    Mtables_id = list[i].Mtables_id,
                    Displayname = list[i].Displayname,
                    Datatype = list[i].Datatype,
                    Inputtype = list[i].Inputtype,
                    Width = list[i].Width,
                    Height = list[i].Height,
                    Cposition = list[i].Cposition,
                    Rposition = list[i].Rposition,
                    Validate = list[i].Validate,
                    Isdefault = list[i].Isdefault,
                    Placement = list[i].Placement,
                    Alignto = list[i].Alignto
                };
                InsertSub(obj, dalsession);
            }
        }

        #endregion[Insert]

        #region[InsertSub]
        
        public static void InsertSub(MasterTablesItems v, SQLITE_DAL dalsession)
        {
                string q = " INSERT INTO " + MASTERTABLESITEMS.MASTERTABLESITEMS_TBL + " ( ";
                q += " " + MASTERTABLESITEMS.FIELDSNAME + " \r\n ";
                q += "," + MASTERTABLESITEMS.MASTERTABLES_ID + " \r\n ";
                q += "," + MASTERTABLESITEMS.DISPLAYNAME + " \r\n ";
                q += "," + MASTERTABLESITEMS.DATATYPE + " \r\n ";
                q += "," + MASTERTABLESITEMS.INPUTTYPE + " \r\n ";
                q += "," + MASTERTABLESITEMS.WIDTH + " \r\n ";
                q += "," + MASTERTABLESITEMS.HEIGHT + " \r\n ";
                q += "," + MASTERTABLESITEMS.CPOSITION + " \r\n ";
                q += "," + MASTERTABLESITEMS.RPOSITION + " \r\n ";
                q += "," + MASTERTABLESITEMS.VALIDATE + " \r\n ";
                q += "," + MASTERTABLESITEMS.ISDEFAULT + " \r\n ";
                q += "," + MASTERTABLESITEMS.PLACEMENT + " \r\n ";
                q += "," + MASTERTABLESITEMS.ALIGNTO + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @"+ MASTERTABLESITEMS.FIELDSNAME + "@ \r\n ";
                q += ", @"+ MASTERTABLESITEMS.MASTERTABLES_ID + "@ \r\n ";
                q += ", @"+ MASTERTABLESITEMS.DISPLAYNAME + "@ \r\n ";
                q += ", @"+ MASTERTABLESITEMS.DATATYPE + "@ \r\n ";
                q += ", @"+ MASTERTABLESITEMS.INPUTTYPE + "@ \r\n ";
                q += ", @"+ MASTERTABLESITEMS.WIDTH + "@ \r\n ";
                q += ", @"+ MASTERTABLESITEMS.HEIGHT + "@ \r\n ";
                q += ", @"+ MASTERTABLESITEMS.CPOSITION + "@ \r\n ";
                q += ", @"+ MASTERTABLESITEMS.RPOSITION + "@ \r\n ";
                q += ", @"+ MASTERTABLESITEMS.VALIDATE + "@ \r\n ";
                q += ", @"+ MASTERTABLESITEMS.ISDEFAULT + "@ \r\n ";
                q += ", @"+ MASTERTABLESITEMS.PLACEMENT + "@ \r\n ";
                q += ", @"+ MASTERTABLESITEMS.ALIGNTO + "@ \r\n ";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]
        
        #region[Delete]
        
        public static void Delete(string fkid , SQLITE_DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + MASTERTABLESITEMS.MASTERTABLESITEMS_TBL+ " WHERE " + MASTERTABLESITEMS.MASTERTABLES_ID + " =  " + fkid +";");
        }
        #endregion[Delete]
        
    }//cls
}//ns
