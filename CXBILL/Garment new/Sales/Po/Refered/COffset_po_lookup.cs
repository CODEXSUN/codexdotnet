// Version : 3 dt : 01-08-2017
// Auto Generated
// 17-08-2017 02:11:56 PM
// last update : 17-08-2017

using CXCORE;
using CXLIB;
using System;
using System.Collections.Generic;
using System.Data;

namespace CXBILL
{
    public class CPo_lookup
    {
        
        public static DataTable DCLookup(string _party)
        {
            string q = " SELECT " + OFFSET_POITEMS.OFFSET_POITEMS_TBL + ".* \r\n";
            q += ", " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_NO + " \r\n";
            q += ", " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += " FROM  " + OFFSET_POITEMS.OFFSET_POITEMS_TBL + " \r\n";

            q += " INNER JOIN " + OFFSET_PO.OFFSET_PO_TBL + "\r\n";
            q += " ON(" + OFFSET_POITEMS.OFFSET_POITEMS_TBL + "." + OFFSET_POITEMS.OFFSET_PO_ID + " = " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_ID + ") \r\n";

            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";
            q += " ON(" + OFFSET_POITEMS.OFFSET_POITEMS_TBL + "." + OFFSET_POITEMS.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";


            q += " WHERE " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.COMPANY_ID + " = " + Current.Company_id + "  \r\n";
            if (_party != "")
            {
                q += " AND  " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " = '" + _party + "'  \r\n";
            }
            q += " AND " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.ACTIVE_ID + " =  " + Core.Active + "  \r\n";
            q += " AND NOT " + OFFSET_POITEMS.OFFSET_POITEMS_TBL + "." + OFFSET_POITEMS.LOCKED + "  =  " + Core.Locked + "  \r\n";
            q += " ORDER BY " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_ID + " \r\n";
            ///  
            DataTable xPO = new DAL().Listdata(q);

            DataTable xList = new DataTable();

            xList.Columns.Add(OFFSET_PO.OFFSET_PO_ID, typeof(string));
            xList.Columns.Add(OFFSET_PO.OFFSET_PO_NO, typeof(string));
            xList.Columns.Add(OFFSET_POITEMS.OFFSET_POITEMS_ID, typeof(string));
            xList.Columns.Add(OFFSET_POITEMS.PRODUCT_ID, typeof(string));
            xList.Columns.Add(OFFSET_POITEMS.QTY, typeof(string));
            xList.Columns.Add(OFFSET_POITEMS.REFERED_QTY, typeof(string));
            xList.Columns.Add(OFFSET_POITEMS.PRICE, typeof(string));

            xList.Rows.Add("Po id", Core.Without_Po, " POITEMS_id  ", "  Particulars  ", "Po Qty", " Balance Qty  ", "  Price  ");
            if (xPO.Rows.Count != 0)
            {
                for (int i = 0; i < xPO.Rows.Count; i++)
                {

                    xList.Rows.Add(
                        (xPO.Rows[i][OFFSET_PO.OFFSET_PO_ID]),
                        (xPO.Rows[i][OFFSET_PO.OFFSET_PO_NO]),
                        (xPO.Rows[i][OFFSET_POITEMS.OFFSET_POITEMS_ID]),
                        xPO.Rows[i][PRODUCT.PRODUCT_NAME],
                        (xPO.Rows[i][OFFSET_POITEMS.QTY]),
                        (xPO.Rows[i][OFFSET_POITEMS.REFERED_QTY]),
                        (xPO.Rows[i][OFFSET_POITEMS.PRICE])

                        );
                }
            }
            return xList;
        }

        static decimal qty; static decimal todelivered;
        public static DataTable LookupbyPono(string _party)
        {
            string q = " SELECT DISTINCT " + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + ".* \r\n";
            q += ", " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.OFFSET_DC_NO + " \r\n";
            q += ", " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_NO + " \r\n";
            q += ", " + OFFSET_POITEMS.OFFSET_POITEMS_TBL + "." + OFFSET_POITEMS.PRICE + " \r\n";
            q += ", " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += " FROM  " + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + " \r\n";
            q += " INNER JOIN  " + OFFSET_DC.OFFSET_DC_TBL + "\r\n";
            q += " ON(" + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + "." + OFFSET_DCITEMS.OFFSET_DC_ID + " = " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.OFFSET_DC_ID + " )\r\n";
            q += " INNER JOIN  " + OFFSET_POITEMS.OFFSET_POITEMS_TBL + "\r\n";
            q += " ON(" + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + "." + OFFSET_DCITEMS.OFFSET_PO_ID + " = " + OFFSET_POITEMS.OFFSET_POITEMS_TBL + "." + OFFSET_POITEMS.OFFSET_PO_ID + " \r\n";
            q += " AND " + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + "." + OFFSET_DCITEMS.PRODUCT_ID + " = " + OFFSET_POITEMS.OFFSET_POITEMS_TBL + "." + OFFSET_POITEMS.PRODUCT_ID + " )\r\n";
            q += " INNER JOIN  " + OFFSET_PO.OFFSET_PO_TBL + "\r\n";
            q += " ON(" + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + "." + OFFSET_DCITEMS.OFFSET_PO_ID + " = " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_ID + " )\r\n";
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";
            q += " ON(" + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + "." + OFFSET_DCITEMS.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " WHERE " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.COMPANY_ID + " = " + Current.Company_id + "  \r\n";
            q += " AND  " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " = '" + _party + "'  \r\n";
            q += " AND  " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.ACTIVE_ID + " = " + Core.Active + " \r\n";
            q += " AND NOT " + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + "." + OFFSET_DCITEMS.LOCKED + "  =  " + Core.Locked + "  \r\n";
            q += " ORDER BY  " + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + "." + OFFSET_DCITEMS.OFFSET_DC_ID + " ASC;  \r\n";

            DataTable xPO = new DAL().Listdata(q);
            //
            DataTable xList = new DataTable();
            //
            xList.Columns.Add("SLNO", typeof(string));
            xList.Columns.Add(OFFSET_DCITEMS.OFFSET_PO_ID, typeof(string));
            xList.Columns.Add(OFFSET_PO.OFFSET_PO_NO, typeof(string));
            xList.Columns.Add(OFFSET_DC.OFFSET_DC_NO, typeof(string));
            xList.Columns.Add(OFFSET_DCITEMS.OFFSET_DCITEMS_ID, typeof(string));
            xList.Columns.Add(OFFSET_DCITEMS.PRODUCT_ID, typeof(string));
            xList.Columns.Add(OFFSET_DCITEMS.QTY, typeof(string));
            xList.Columns.Add(OFFSET_DCITEMS.REFERED_QTY, typeof(string));
            xList.Columns.Add(OFFSET_POITEMS.PRICE, typeof(string));

            xList.Rows.Add("SLNO","PO Id ", Core.Without_Po, " DC NO  ", " DC_item_id", "  Particulars  ", "DC Qty", "  To Bill  ", "  Price  ");

            if (xPO.Rows.Count != 0)
            {
                for (int i = 0; i < xPO.Rows.Count; i++)
                {
                    xList.Rows.Add(
                        i+1,
                        xPO.Rows[i][OFFSET_DCITEMS.OFFSET_PO_ID],
                        xPO.Rows[i][OFFSET_PO.OFFSET_PO_NO],
                        xPO.Rows[i][OFFSET_DC.OFFSET_DC_NO],
                        xPO.Rows[i][OFFSET_DCITEMS.OFFSET_DCITEMS_ID],
                        xPO.Rows[i][PRODUCT.PRODUCT_NAME],
                        xPO.Rows[i][OFFSET_DCITEMS.QTY],
                        xPO.Rows[i][OFFSET_DCITEMS.REFERED_QTY],
                        xPO.Rows[i][OFFSET_POITEMS.PRICE]
                        );
                }
            }

            //
            // adding pending from PO
            //

            //DataTable yList = new DataTable();
            
            //yList.Columns.Add(DCITEMS.PO_ID, typeof(string));
            //yList.Columns.Add(PO.PO_NO, typeof(string));
            //yList.Columns.Add(DC.DC_NO, typeof(string));
            //yList.Columns.Add(DCITEMS.DCITEMS_ID, typeof(string));
            //yList.Columns.Add(DCITEMS.PRODUCT_ID, typeof(string));
            //yList.Columns.Add(DCITEMS.QTY, typeof(string));
            //yList.Columns.Add(DCITEMS.REFERED_QTY, typeof(string));
            //yList.Columns.Add(POITEMS.PRICE, typeof(string));

            //DataTable podata = DCLookup(_party);



            //for (int r = 0; r < podata.Rows.Count; r++)
            //{
            //    DataRow[] found_poid = xList.Select(DCITEMS.PO_ID + " = '" + podata.Rows[r][DCITEMS.PO_ID] + "'");

            //    if (found_poid.Length == 0)
            //    {
            //        yList.Rows.Add(
            //                       (podata.Rows[r][DCITEMS.PO_ID]),
            //                       (podata.Rows[r][PO.PO_NO]),
            //                        (Core.Without_Dc),
            //                        (""),
            //                        ((podata.Rows[r][PRODUCT.PRODUCT_ID]) + ""),
            //                        (podata.Rows[r][DCITEMS.QTY]),
            //                        (podata.Rows[r][POITEMS.REFERED_QTY]),
            //                        (xPO.Rows[r][POITEMS.PRICE])
            //                        );
            //    }
            //    else
            //    {
            //        decimal newDecimal;
            //        if (decimal.TryParse((podata.Rows[r][DCITEMS.QTY]).ToString(), out newDecimal) != false || newDecimal > 0)
            //        {
            //            qty = Convert.ToDecimal((podata.Rows[r][POITEMS.QTY]).ToString());
            //        }
            //        if (decimal.TryParse((podata.Rows[r][POITEMS.REFERED_QTY]).ToString(), out newDecimal) != false || newDecimal > 0)
            //        {
            //            todelivered = Convert.ToDecimal((podata.Rows[r][POITEMS.REFERED_QTY]).ToString());
            //        }

            //        if (r != 0)
            //        {
            //            if (qty != 0 || todelivered != 0)
            //            {
            //                if (qty >= todelivered)
            //                {
            //                    yList.Rows.Add(
            //                             (podata.Rows[r][DCITEMS.PO_ID]),
            //                             (podata.Rows[r][PO.PO_NO]),
            //                              (Core.Without_Dc),
            //                              (""),
            //                               ((podata.Rows[r][PRODUCT.PRODUCT_ID]) + ""),
            //                              (podata.Rows[r][DCITEMS.QTY]),
            //                              (podata.Rows[r][POITEMS.REFERED_QTY]),
            //                               (xPO.Rows[r][POITEMS.PRICE])
            //                              );
            //                }
            //            }
            //        }
            //    }
            //}

            //xList.Merge(yList);


            return xList;
        }

        public static DataTable LookupPObyPartyforInvoice(string _party)
        {
            string q = "  SELECT * \r\n";
            q += " FROM " + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + " \r\n";
            q += " INNER JOIN  DC_TBL ON (" + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + "." + OFFSET_DCITEMS.OFFSET_DC_ID + " =" + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.OFFSET_DC_ID + ") \r\n";
            q += " WHERE " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.COMPANY_ID + " = " + Current.Company_id + "  \r\n";
            q += " AND  " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.PARTY_ID + " = " + _party + "  \r\n";
            q += " AND  " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.ACTIVE_ID + " = " + Core.Active + " \r\n";
            q += " AND NOT " + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + "." + OFFSET_DCITEMS.LOCKED + "  =  " + Core.Locked + "  \r\n";
            q += " ORDER BY  " + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + "." + OFFSET_DCITEMS.OFFSET_DC_ID + " ASC;  \r\n";

            DataTable xPO = new DAL().Listdata(q);
            //
            DataTable xList = new DataTable();
            //
            xList.Columns.Add("SLNO", typeof(string));
            xList.Columns.Add(OFFSET_DCITEMS.OFFSET_PO_ID, typeof(string));
            xList.Columns.Add(OFFSET_PO.OFFSET_PO_NO, typeof(string));
            xList.Columns.Add(OFFSET_DC.OFFSET_DC_NO, typeof(string));
            xList.Columns.Add(OFFSET_DCITEMS.OFFSET_DCITEMS_ID, typeof(string));
            xList.Columns.Add(OFFSET_DCITEMS.PRODUCT_ID, typeof(string));
            xList.Columns.Add(OFFSET_DCITEMS.QTY, typeof(string));
            xList.Columns.Add(OFFSET_DCITEMS.REFERED_QTY, typeof(string));
            xList.Columns.Add(OFFSET_POITEMS.PRICE, typeof(string));
            xList.Rows.Add("SLNO","PO Id ", Core.Without_Po, " DC NO  ", " DC_item_id", "  Particulars  ", "DC Qty", "  To Bill  ", "  Price  ");
            if (xPO.Rows.Count != 0)
            {
                for (int i = 0; i < xPO.Rows.Count; i++)
                {
                    string _poid = string.Empty;

                    if (xPO.Rows[i][OFFSET_DCITEMS.OFFSET_PO_ID] + "" == "1")
                    {
                        _poid = Core._Without_po_;
                    }
                    else
                    {
                        _poid = COffset_po_exten.GetName_Id((xPO.Rows[i][OFFSET_DCITEMS.OFFSET_PO_ID]) + "");
                    }

                    xList.Rows.Add(
                        i+1,
                        (xPO.Rows[i][OFFSET_DCITEMS.OFFSET_PO_ID]),
                        _poid,
                        (xPO.Rows[i][OFFSET_DC.OFFSET_DC_NO]),
                        (xPO.Rows[i][OFFSET_DCITEMS.OFFSET_DCITEMS_ID]),
                        CProduct_exten.GetName_Id((xPO.Rows[i][OFFSET_DCITEMS.PRODUCT_ID]) + ""),
                        (xPO.Rows[i][OFFSET_DCITEMS.QTY]),
                        (xPO.Rows[i][OFFSET_DCITEMS.REFERED_QTY]),
                        COffset_Poitems_exten.GetPrice_po((xPO.Rows[i][OFFSET_DCITEMS.OFFSET_PO_ID]) + "", (xPO.Rows[i][OFFSET_DCITEMS.PRODUCT_ID]) + "")
                        );
                }
            }
            //
            DataTable yList = new DataTable();
            //
            yList.Columns.Add(OFFSET_DCITEMS.OFFSET_PO_ID, typeof(string));
            yList.Columns.Add(OFFSET_PO.OFFSET_PO_NO, typeof(string));
            yList.Columns.Add(OFFSET_DC.OFFSET_DC_NO, typeof(string));
            yList.Columns.Add(OFFSET_DCITEMS.OFFSET_DCITEMS_ID, typeof(string));
            yList.Columns.Add(OFFSET_DCITEMS.PRODUCT_ID, typeof(string));
            yList.Columns.Add(OFFSET_DCITEMS.QTY, typeof(string));
            yList.Columns.Add(OFFSET_DCITEMS.REFERED_QTY, typeof(string));
            yList.Columns.Add(OFFSET_POITEMS.PRICE, typeof(string));

            DataTable podata = DCLookup(_party);



            for (int r = 0; r < podata.Rows.Count; r++)
            {
                DataRow[] found_poid = xList.Select(OFFSET_DCITEMS.OFFSET_PO_ID + " = '" + podata.Rows[r][OFFSET_DCITEMS.OFFSET_PO_ID] + "'");
                if (found_poid.Length == 0)
                {
                    yList.Rows.Add(
                                   (podata.Rows[r][OFFSET_DCITEMS.OFFSET_PO_ID]),
                                   (podata.Rows[r][OFFSET_PO.OFFSET_PO_NO]),
                                    (Core.Without_Dc),
                                    (""),
                                    ((podata.Rows[r][OFFSET_DCITEMS.PRODUCT_ID]) + ""),
                                    (podata.Rows[r][OFFSET_DCITEMS.QTY]),
                                    (podata.Rows[r][OFFSET_DCITEMS.QTY]),
                                    COffset_Poitems_exten.GetPrice_po((podata.Rows[r][OFFSET_DCITEMS.OFFSET_PO_ID]) + "",
                                    CProduct_exten.GetId_Name((podata.Rows[r][OFFSET_DCITEMS.PRODUCT_ID]) + ""))
                                    );
                }
                else
                {
                    decimal newDecimal;
                    if (decimal.TryParse((podata.Rows[r][OFFSET_DCITEMS.QTY]).ToString(), out newDecimal) != false || newDecimal > 0)
                    {
                        qty = Convert.ToDecimal((podata.Rows[r][OFFSET_POITEMS.QTY]).ToString());
                    }
                    if (decimal.TryParse((podata.Rows[r][OFFSET_POITEMS.REFERED_QTY]).ToString(), out newDecimal) != false || newDecimal > 0)
                    {
                        todelivered = Convert.ToDecimal((podata.Rows[r][OFFSET_POITEMS.REFERED_QTY]).ToString());
                    }

                    if (r != 0)
                    {
                        if (qty != 0 || todelivered != 0)
                        {
                            if (qty >= todelivered)
                            {
                                yList.Rows.Add(
                                         (podata.Rows[r][OFFSET_DCITEMS.OFFSET_PO_ID]),
                                         (podata.Rows[r][OFFSET_PO.OFFSET_PO_NO]),
                                          (Core.Without_Dc),
                                          (""),
                                          ((podata.Rows[r][OFFSET_DCITEMS.PRODUCT_ID]) + ""),
                                          (podata.Rows[r][OFFSET_DCITEMS.QTY]),
                                          (podata.Rows[r][OFFSET_POITEMS.REFERED_QTY]),
                                          COffset_Poitems_exten.GetPrice_po((podata.Rows[r][OFFSET_DCITEMS.OFFSET_PO_ID]) + "", CProduct_exten.GetId_Name((podata.Rows[r][OFFSET_DCITEMS.PRODUCT_ID]) + ""))
                                          );
                            }
                        }
                    }
                }
            }

            xList.Merge(yList);

            return xList;
        }
        public static DataTable LookupPOwithoutPoforDC
        {
            get
            {
                DataTable xList = new DataTable();
                xList.Columns.Add(OFFSET_PO.OFFSET_PO_NO, typeof(string));
                xList.Columns.Add(OFFSET_POITEMS.OFFSET_POITEMS_ID, typeof(string));
                xList.Columns.Add(OFFSET_POITEMS.PRODUCT_ID, typeof(string));
                xList.Columns.Add(OFFSET_POITEMS.QTY, typeof(string));
                xList.Columns.Add(OFFSET_POITEMS.REFERED_QTY, typeof(string));
                xList.Rows.Add(Core.Without_Po, " Po_item_id  ", "  Particulars  ", "Po Qty", "  Delivered  ");
                return xList;
            }
        }


    }//cls
}//ns
