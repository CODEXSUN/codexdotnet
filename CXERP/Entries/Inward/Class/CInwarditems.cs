// Version : 5.0.0.0 Date : 27-01-2021
// Auto Generated
// last update : 28-01-2021 10:30:12 PM

using System.Collections.Generic;
using CXLIB;

namespace CXERP
{
    public static class CInwarditems 
    {

        #region[Get New]

        public static List<Inwarditems> GetNew
        {
            get
            {
            List<Inwarditems> list = new List<Inwarditems>();

                Inwarditems obj = new Inwarditems()
                {
                    Inwarditems_id = string.Empty,
                    Inward_id = string.Empty,
                    Product_id = string.Empty,
                    Colours_id = string.Empty,
                    Sizes_id = string.Empty,
                    Bundle = string.Empty,
                    Qty = string.Empty,
                    Refered_id = string.Empty,
                    Locked = string.Empty,
                };
                list.Add(obj);
                return list;
            }
        }

        #endregion[Get New]

        #region[Attach params]
        
        private static string AttachParams(string q, Inwarditems v)
        {
            q = q.Replace("@" + INWARDITEMS.INWARD_ID + "@", "" + ConvertTO.SqlString(v.Inward_id) + "");
            q = q.Replace("@" + INWARDITEMS.PRODUCT_ID + "@", "" + ConvertTO.SqlString(v.Product_id) + "");
            q = q.Replace("@" + INWARDITEMS.COLOURS_ID + "@", "" + ConvertTO.SqlString(v.Colours_id) + "");
            q = q.Replace("@" + INWARDITEMS.SIZES_ID + "@", "" + ConvertTO.SqlString(v.Sizes_id) + "");
            q = q.Replace("@" + INWARDITEMS.BUNDLE + "@", "" + ConvertTO.SqlString(v.Bundle) + "");
            q = q.Replace("@" + INWARDITEMS.QTY + "@", "" + ConvertTO.SqlString(v.Qty) + "");
            q = q.Replace("@" + INWARDITEMS.REFERED_ID + "@", "" + ConvertTO.SqlString(v.Refered_id) + "");
            q = q.Replace("@" + INWARDITEMS.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            return q;
        }
        #endregion[Attach params]
        
        #region[Insert]
        
        public static void Insert(List<Inwarditems> list, DAL dalsession)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Inwarditems obj = new Inwarditems()
                {
                    Inward_id = list[i].Inward_id,
                    Product_id = list[i].Product_id,
                    Colours_id = list[i].Colours_id,
                    Sizes_id = list[i].Sizes_id,
                    Bundle = list[i].Bundle,
                    Qty = list[i].Qty,
                    Refered_id = list[i].Refered_id,
                    Locked = list[i].Locked
                };
                InsertSub(obj, dalsession);
            }
        }

        #endregion[Insert]

        #region[InsertSub]
        
        public static void InsertSub(Inwarditems v, DAL dalsession)
        {
                string q = " INSERT INTO " + INWARDITEMS.INWARDITEMS_TBL + " ( ";
                q += " " + INWARDITEMS.INWARD_ID + " \r\n ";
                q += "," + INWARDITEMS.PRODUCT_ID + " \r\n ";
                q += "," + INWARDITEMS.COLOURS_ID + " \r\n ";
                q += "," + INWARDITEMS.SIZES_ID + " \r\n ";
                q += "," + INWARDITEMS.BUNDLE + " \r\n ";
                q += "," + INWARDITEMS.QTY + " \r\n ";
                q += "," + INWARDITEMS.REFERED_ID + " \r\n ";
                q += "," + INWARDITEMS.LOCKED + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @"+ INWARDITEMS.INWARD_ID + "@ \r\n ";
                q += ", @"+ INWARDITEMS.PRODUCT_ID + "@ \r\n ";
                q += ", @"+ INWARDITEMS.COLOURS_ID + "@ \r\n ";
                q += ", @"+ INWARDITEMS.SIZES_ID + "@ \r\n ";
                q += ", @"+ INWARDITEMS.BUNDLE + "@ \r\n ";
                q += ", @"+ INWARDITEMS.QTY + "@ \r\n ";
                q += ", @"+ INWARDITEMS.REFERED_ID + "@ \r\n ";
                q += ", @"+ INWARDITEMS.LOCKED + "@ \r\n ";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]
        
        #region[Delete]
        
        public static void Delete(string fkid , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + INWARDITEMS.INWARDITEMS_TBL+ " WHERE " + INWARDITEMS.INWARD_ID + " =  " + fkid +";");
        }
        #endregion[Delete]
        
    }//cls
}//ns
