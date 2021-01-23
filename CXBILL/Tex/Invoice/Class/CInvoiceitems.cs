// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 22-11-2017 12:32:15 PM

using System.Collections.Generic;
using CXLIB;

namespace CXBILL
{
    public class CTex_Invoiceitems
    {

        #region[Get New]

        public static List<Tex_invoiceitems> GetNew
        {
            get
            {
                List<Tex_invoiceitems> list = new List<Tex_invoiceitems>();

                Tex_invoiceitems obj = new Tex_invoiceitems()
                {
                    Tex_invoiceitems_id = string.Empty,
                    Tex_invoice_id = string.Empty,
                    //Tex_invoice_no = string.Empty,
                    //Po_id = string.Empty,
                    //Poitems_id = string.Empty,
                    //Dc_id = string.Empty,
                    //Dcitems_id = string.Empty,
                    Product_id = string.Empty,
                    Sizes_id = string.Empty,
                    Qty = string.Empty,
                    Price = decimal.Zero,
                    Cgst_percent = decimal.Zero,
                    Sgst_percent = decimal.Zero,
                    Igst_percent = decimal.Zero,
                    Refered_id = string.Empty,
                    Locked = string.Empty,
                };
                list.Add(obj);
                return list;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Tex_invoiceitems v)
        {
            q = q.Replace("@" + TEX_INVOICEITEMS.TEX_INVOICE_ID + "@", "" + ConvertTO.SqlString(v.Tex_invoice_id) + "");
            //q = q.Replace("@" + TEX_INVOICEITEMS.INVOICE_NO + "@", "" + ConvertTO.SqlString(v.Tex_invoice_no) + "");
            //q = q.Replace("@" + INVOICEITEMS.PO_ID + "@", "" + ConvertTO.SqlString(v.Po_id) + "");
            //q = q.Replace("@" + INVOICEITEMS.POITEMS_ID + "@", "" + ConvertTO.SqlString(v.Poitems_id) + "");
            //q = q.Replace("@" + INVOICEITEMS.DC_ID + "@", "" + ConvertTO.SqlString(v.Dc_id) + "");
            //q = q.Replace("@" + INVOICEITEMS.DCITEMS_ID + "@", "" + ConvertTO.SqlString(v.Dcitems_id) + "");
            q = q.Replace("@" + TEX_INVOICEITEMS.PRODUCT_ID + "@", "" + ConvertTO.SqlString(v.Product_id) + "");
            q = q.Replace("@" + TEX_INVOICEITEMS.SIZES_ID + "@", "" + ConvertTO.SqlString(v.Sizes_id) + "");
            q = q.Replace("@" + TEX_INVOICEITEMS.QTY + "@", "" + ConvertTO.SqlString(v.Qty) + "");
            q = q.Replace("@" + TEX_INVOICEITEMS.PRICE + "@", "" + ConvertTO.SqlString((v.Price) + ""));
            q = q.Replace("@" + TEX_INVOICEITEMS.CGST_PERCENT + "@", "" + ConvertTO.SqlString((v.Cgst_percent) + ""));
            q = q.Replace("@" + TEX_INVOICEITEMS.SGST_PERCENT + "@", "" + ConvertTO.SqlString((v.Sgst_percent) + ""));
            q = q.Replace("@" + TEX_INVOICEITEMS.IGST_PERCENT + "@", "" + ConvertTO.SqlString((v.Igst_percent) + ""));
            q = q.Replace("@" + TEX_INVOICEITEMS.REFERED_ID + "@", "" + ConvertTO.SqlString(v.Refered_id) + "");
            q = q.Replace("@" + TEX_INVOICEITEMS.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(List<Tex_invoiceitems> list, DAL dalsession)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Tex_invoiceitems obj = new Tex_invoiceitems()
                {
                    Tex_invoice_id = list[i].Tex_invoice_id,
                    //Tex_invoice_no = list[i].Tex_invoice_no,
                    //Po_id = list[i].Po_id,
                    //Poitems_id = list[i].Poitems_id,
                    //Dc_id = list[i].Dc_id,
                    //Dcitems_id = list[i].Dcitems_id,
                    Product_id = list[i].Product_id,
                    Sizes_id = list[i].Sizes_id,
                    Qty = list[i].Qty,
                    Price = list[i].Price,
                    Cgst_percent = list[i].Cgst_percent,
                    Sgst_percent = list[i].Sgst_percent,
                    Igst_percent = list[i].Igst_percent,
                    Refered_id = list[i].Refered_id,
                    Locked = list[i].Locked
                };
                InsertSub(obj, dalsession);
            }
        }

        #endregion[Insert]

        #region[InsertSub]

        public static void InsertSub(Tex_invoiceitems v, DAL dalsession)
        {
            string q = " INSERT INTO " + TEX_INVOICEITEMS.TEX_INVOICEITEMS_TBL + " ( ";
            q += " " + TEX_INVOICEITEMS.TEX_INVOICE_ID + " \r\n ";
            //q += "," + TEX_INVOICEITEMS.INVOICE_NO + " \r\n ";
            //q += "," + INVOICEITEMS.PO_ID + " \r\n ";
            //q += "," + INVOICEITEMS.POITEMS_ID + " \r\n ";
            //q += "," + INVOICEITEMS.DC_ID + " \r\n ";
            //q += "," + INVOICEITEMS.DCITEMS_ID + " \r\n ";
            q += "," + TEX_INVOICEITEMS.PRODUCT_ID + " \r\n ";
            q += "," + TEX_INVOICEITEMS.SIZES_ID + " \r\n ";
            q += "," + TEX_INVOICEITEMS.QTY + " \r\n ";
            q += "," + TEX_INVOICEITEMS.PRICE + " \r\n ";
            q += "," + TEX_INVOICEITEMS.CGST_PERCENT + " \r\n ";
            q += "," + TEX_INVOICEITEMS.SGST_PERCENT + " \r\n ";
            q += "," + TEX_INVOICEITEMS.IGST_PERCENT + " \r\n ";
            q += "," + TEX_INVOICEITEMS.REFERED_ID + " \r\n ";
            q += "," + TEX_INVOICEITEMS.LOCKED + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + TEX_INVOICEITEMS.TEX_INVOICE_ID + "@ \r\n ";
            //q += ", @" + TEX_INVOICEITEMS.INVOICE_NO + "@ \r\n ";
            //q += ", @" + INVOICEITEMS.PO_ID + "@ \r\n ";
            //q += ", @" + INVOICEITEMS.POITEMS_ID + "@ \r\n ";
            //q += ", @" + INVOICEITEMS.DC_ID + "@ \r\n ";
            //q += ", @" + INVOICEITEMS.DCITEMS_ID + "@ \r\n ";
            q += ", @" + TEX_INVOICEITEMS.PRODUCT_ID + "@ \r\n ";
            q += ", @" + TEX_INVOICEITEMS.SIZES_ID + "@ \r\n ";
            q += ", @" + TEX_INVOICEITEMS.QTY + "@ \r\n ";
            q += ", @" + TEX_INVOICEITEMS.PRICE + "@ \r\n ";
            q += ", @" + TEX_INVOICEITEMS.CGST_PERCENT + "@ \r\n ";
            q += ", @" + TEX_INVOICEITEMS.SGST_PERCENT + "@ \r\n ";
            q += ", @" + TEX_INVOICEITEMS.IGST_PERCENT + "@ \r\n ";
            q += ", @" + TEX_INVOICEITEMS.REFERED_ID + "@ \r\n ";
            q += ", @" + TEX_INVOICEITEMS.LOCKED + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Delete]

        public static void Delete(string fkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + TEX_INVOICEITEMS.TEX_INVOICEITEMS_TBL + " WHERE " + TEX_INVOICEITEMS.TEX_INVOICE_ID + " =  " + fkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
