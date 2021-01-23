// Version : 3 dt : 01-08-2017
// Auto Generated
// 02-10-2017 07:16:41 PM
// last update : 02-10-2017

using System.Data;
using CXLIB;
using CXCORE;
using System.Collections.Generic;

namespace CXBILL
{
    public class CPurchaseitems_exten
    {
         #region[Entity List] 
  
         private static List<Purchaseitems> EntityList(string q) 
         { 
             List<Purchaseitems> list = new List<Purchaseitems>(); 
  
             using (IDataReader redr = new DAL().Listreader(q)) 
             { 
                 while (redr.Read() == true) 
                 { 
                      Purchaseitems  obj = new  Purchaseitems () 
                     { 
                        Purchaseitems_id = redr[PURCHASEITEMS.PURCHASEITEMS_ID].ToString(), 
                        Purchase_id = redr[PURCHASEITEMS.PURCHASE_ID].ToString(),
                        Purchase_no = redr[PURCHASEITEMS.PURCHASE_NO].ToString(),
                        //Po_id = redr[PO.PO_NO].ToString(),
                        //Dc_id = redr[DC.DC_NO].ToString(),
                        //Dcitems_id = redr[PURCHASEITEMS.DCITEMS_ID].ToString(),
                        Product_id = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Qty = ConvertTO.Decimal(redr[PURCHASEITEMS.QTY].ToString()),
                        Price = ConvertTO.Decimal(redr[PURCHASEITEMS.PRICE].ToString()),
                        Cgst_percent = ConvertTO.Decimal(redr[PURCHASEITEMS.CGST_PERCENT].ToString()),
                        Sgst_percent = ConvertTO.Decimal(redr[PURCHASEITEMS.SGST_PERCENT].ToString()),
                        Igst_percent = ConvertTO.Decimal(redr[PURCHASEITEMS.IGST_PERCENT].ToString()),
                        Refered_id = redr[PURCHASEITEMS.REFERED_ID].ToString(),
                        Locked = redr[PURCHASEITEMS.LOCKED].ToString(),
                     }; 
  
                     list.Add(obj); 
                 } 
  
             } 
             return list; 
         } 
  
         #endregion[Entity List] 
  
         #region[FKId] 
  
         public static List<Purchaseitems> FKId(string id , DAL DAL) 
         { 
            string q = " SELECT " + PURCHASEITEMS.PURCHASEITEMS_TBL +".* \r\n"; 
            q += ", "+ PURCHASE.PURCHASE_TBL + "."+ PURCHASE.PURCHASE_NO + " \r\n";
            //q += ", " + PO.PO_TBL + "." + PO.PO_NO + " \r\n";
            //q += ", " + DC.DC_TBL + "." + DC.DC_NO + " \r\n";
            q += ", " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + " \r\n";
            q += " FROM  " + PURCHASEITEMS.PURCHASEITEMS_TBL + " \r\n";
            q += " INNER JOIN  " + PURCHASE.PURCHASE_TBL + "\r\n";
            q += " ON(" + PURCHASEITEMS.PURCHASEITEMS_TBL + "." + PURCHASEITEMS.PURCHASE_ID + " = " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.PURCHASE_ID + " )\r\n";
            //q += " INNER JOIN  " + OFFSET_PO.OFFSET_PO_TBL + "\r\n";
            ////q += " ON(" + PURCHASEITEMS.PURCHASEITEMS_TBL + "." + PURCHASEITEMS.PO_ID + " = " + PO.PO_TBL + "." + PO.PO_ID + " )\r\n";
            //q += " INNER JOIN  " + DC.DC_TBL + "\r\n";
            //q += " ON(" + PURCHASEITEMS.PURCHASEITEMS_TBL + "." + PURCHASEITEMS.DC_ID + " = " + DC.DC_TBL + "." + DC.DC_ID + " )\r\n";
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";
            q += " ON(" + PURCHASEITEMS.PURCHASEITEMS_TBL + "." + PURCHASEITEMS.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID+" )\r\n";  
            q += " WHERE " + PURCHASEITEMS.PURCHASEITEMS_TBL + "." + PURCHASE.PURCHASE_ID + "  = '" + id + "' \r\n"; 
            q += " ORDER BY  " + PURCHASEITEMS.PURCHASEITEMS_TBL + "." + PURCHASEITEMS.PURCHASEITEMS_ID + ";\r\n"; 
  
             return EntityList(q); 
         }

        #endregion[FKId] 

        #region[FK withoutJoin] 

        public static List<Purchaseitems> FK_withoutJoin(string id, DAL DAL)
        {
            string q = " SELECT * FROM " + PURCHASEITEMS.PURCHASEITEMS_TBL + " \r\n";
            q += " WHERE " + PURCHASEITEMS.PURCHASEITEMS_TBL + "." + PURCHASE.PURCHASE_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + PURCHASEITEMS.PURCHASEITEMS_TBL + "." + PURCHASEITEMS.PURCHASEITEMS_ID + ";\r\n";

            List<Purchaseitems> list = new List<Purchaseitems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Purchaseitems obj = new Purchaseitems()
                    {
                        Purchaseitems_id = redr[PURCHASEITEMS.PURCHASEITEMS_ID].ToString(),
                        Purchase_id = redr[PURCHASEITEMS.PURCHASE_ID].ToString(),
                        Purchase_no = redr[PURCHASEITEMS.PURCHASE_NO].ToString(),
                        //Po_id = redr[PO.PO_ID].ToString(),
                        //Dc_id = redr[DC.DC_ID].ToString(),
                        //Dcitems_id = redr[PURCHASEITEMS.DCITEMS_ID].ToString(),
                        Product_id = redr[PRODUCT.PRODUCT_ID].ToString(),
                        Qty = ConvertTO.Decimal(redr[PURCHASEITEMS.QTY].ToString()),
                        Price = ConvertTO.Decimal(redr[PURCHASEITEMS.PRICE].ToString()),
                        Cgst_percent = ConvertTO.Decimal(redr[PURCHASEITEMS.CGST_PERCENT].ToString()),
                        Sgst_percent = ConvertTO.Decimal(redr[PURCHASEITEMS.SGST_PERCENT].ToString()),
                        Igst_percent = ConvertTO.Decimal(redr[PURCHASEITEMS.IGST_PERCENT].ToString()),
                        Refered_id = redr[PURCHASEITEMS.REFERED_ID].ToString(),
                        Locked = redr[PURCHASEITEMS.LOCKED].ToString(),
                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        #endregion[FK withoutJoin] 

        #region[FK withoutJoin] 

        public static List<Purchaseitems> FKNo(string id, DAL DAL)
        {

            string q = " SELECT " + PURCHASEITEMS.PURCHASEITEMS_TBL + ".* \r\n";
            q += ", " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + " \r\n";
            q += " FROM  " + PURCHASEITEMS.PURCHASEITEMS_TBL + " \r\n";
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";
            q += " ON(" + PURCHASEITEMS.PURCHASEITEMS_TBL + "." + PURCHASEITEMS.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + " )\r\n";
            q += " WHERE " + PURCHASEITEMS.PURCHASEITEMS_TBL + "." + PURCHASE.PURCHASE_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + PURCHASEITEMS.PURCHASEITEMS_TBL + "." + PURCHASEITEMS.PURCHASEITEMS_ID + ";\r\n";


            //string q = " SELECT * FROM " + PURCHASEITEMS.PURCHASEITEMS_TBL + " \r\n";
            //q += " WHERE " + PURCHASEITEMS.PURCHASEITEMS_TBL + "." + PURCHASE.PURCHASE_ID + "  = '" + id + "' \r\n";
            //q += " ORDER BY  " + PURCHASEITEMS.PURCHASEITEMS_TBL + "." + PURCHASEITEMS.PURCHASEITEMS_ID + ";\r\n";

            List<Purchaseitems> list = new List<Purchaseitems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Purchaseitems obj = new Purchaseitems()
                    {
                        Purchaseitems_id = redr[PURCHASEITEMS.PURCHASEITEMS_ID].ToString(),
                        Purchase_id = redr[PURCHASEITEMS.PURCHASE_ID].ToString(),
                        Purchase_no = redr[PURCHASEITEMS.PURCHASE_NO].ToString(),
                        //Po_id = redr[PURCHASEITEMS.PO_ID].ToString(),
                        //Dc_id = redr[PURCHASEITEMS.DC_ID].ToString(),
                        //Dcitems_id = redr[PURCHASEITEMS.DCITEMS_ID].ToString(),
                        Product_id = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Qty = ConvertTO.Decimal(redr[PURCHASEITEMS.QTY].ToString()),
                        Price = ConvertTO.Decimal(redr[PURCHASEITEMS.PRICE].ToString()),
                        Cgst_percent = ConvertTO.Decimal(redr[PURCHASEITEMS.CGST_PERCENT].ToString()),
                        Sgst_percent = ConvertTO.Decimal(redr[PURCHASEITEMS.SGST_PERCENT].ToString()),
                        Igst_percent = ConvertTO.Decimal(redr[PURCHASEITEMS.IGST_PERCENT].ToString()),
                        Refered_id = redr[PURCHASEITEMS.REFERED_ID].ToString(),
                        Locked = redr[PURCHASEITEMS.LOCKED].ToString(),
                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        #endregion[FK withoutJoin] 

    }//cls
}//ns
