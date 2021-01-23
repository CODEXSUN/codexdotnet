// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 07-08-2020 01:34:46 PM

using System;
using System.Data;
using CXLIB;
using CXCORE;
using System.Collections.Generic;
using System.Windows.Forms;
using CXBILL_EXTEN.Invoice.Class;
using CXBILL_EXTEN.Invoice.Const;

namespace CXBILL_EXTEN
{
    public static class U_Invoice_from_sara
    {
        #region[]

        public static void GetUpdated(string OldDB)
        {
            int count = GetCount(OldDB);

            for (int i = 1; i <= count; i++)
            {
                Invoice.Const.Invoice obj = GetOldData(i, OldDB);
                List<Invoiceitems> list = GetOldItemsData(i, OldDB);

                if (obj != null)
                {
                    InsertData(obj, list);
                }

            }
        }

        #endregion[]

        #region[Get Count]

        private static int GetCount(string OldDB)
        {
            string q = "USE " + OldDB + "; ";
            q += "SELECT * FROM " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + " ORDER BY " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_ID + " DESC LIMIT 1 ; ";

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    int lastId = Convert.ToInt32(redr[OFFSET_1_INVOICE.OFFSET_1_INVOICE_ID]);

                    return lastId;
                }
                return 0;
            }
        }

        #endregion[Get Count]

        #region[Get Old data]

        private static Invoice.Const.Invoice GetOldData(int id, string OldDB)
        {
            string q = "USE " + OldDB + "; ";
            q += " SELECT " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + ".* \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += " FROM  " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + " \r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " WHERE " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_ID + " = '" + id + "' \r\n";
            //q += " ORDER BY  " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_NO + ";\r\n";

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Invoice.Const.Invoice obj = new Invoice.Const.Invoice
                    {
                        Uniqueno = "",
                        Company_id = redr[OFFSET_1_INVOICE.COMPANY_ID].ToString(),
                        Acy_id = "",
                        Order_id = "1",
                        Invoice_no = redr[OFFSET_1_INVOICE.OFFSET_1_INVOICE_NO].ToString(),
                        Invoice_date = redr[OFFSET_1_INVOICE.OFFSET_1_INVOICE_DATE].ToString(),
                        Party_id = CParty_exten.GetId_Name(redr[PARTY.PARTY_NAME].ToString()),
                        Taxtype_id = CTaxtype_exten.GetId_Name(redr[TAXTYPE.TAXTYPE_NAME].ToString()),
                        Salestype_id = CSalestype_exten.GetId_Name(redr[SALESTYPE.SALESTYPE_NAME].ToString()),
                        Transport_id = "1",
                        Deliveredto_id = "1",
                        Bundel = "0",
                        Total_qty = redr[OFFSET_1_INVOICE.TOTAL_QTY].ToString(),
                        Total_taxable_amount = ConvertTO.Decimal(redr[OFFSET_1_INVOICE.TOTAL_TAXABLE_AMOUNT].ToString()),
                        Total_cgst = ConvertTO.Decimal(redr[OFFSET_1_INVOICE.TOTAL_CGST].ToString()),
                        Total_sgst = ConvertTO.Decimal(redr[OFFSET_1_INVOICE.TOTAL_SGST].ToString()),
                        Total_igst = ConvertTO.Decimal(redr[OFFSET_1_INVOICE.TOTAL_IGST].ToString()),
                        Gsttotal = ConvertTO.Decimal(redr[OFFSET_1_INVOICE.GSTTOTAL].ToString()),
                        Ledger_id = redr[OFFSET_1_INVOICE.LEDGER_ID].ToString(),
                        Additional = ConvertTO.Decimal(redr[OFFSET_1_INVOICE.ADDITIONAL].ToString()),
                        Rounds = ConvertTO.Decimal(redr[OFFSET_1_INVOICE.ROUNDS].ToString()),
                        Grandtotal = ConvertTO.Decimal(redr[OFFSET_1_INVOICE.GRANDTOTAL].ToString()),
                        Refered_amt = ConvertTO.Decimal(redr[OFFSET_1_INVOICE.REFERED_AMT].ToString()),
                        Locked = redr[OFFSET_1_INVOICE.LOCKED].ToString(),
                        Notes = redr[OFFSET_1_INVOICE.NOTES].ToString(),
                        Active_id = redr[OFFSET_1_INVOICE.ACTIVE_ID].ToString(),
                        User_id = "1"
                    };

                    obj.Uniqueno = obj.Acy_id + "~" + obj.Company_id + "~" + obj.Invoice_no;

                    return obj;
                }
                return null;
            }
        }

        #endregion[Get Old data]

        #region[Get Old items data]

        private static List<Invoiceitems> GetOldItemsData(int id, string OldDB)
        {
            string q = "USE " + OldDB + "; ";
            q += " SELECT " + OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICEITEMS_TBL + ".* \r\n";
            q += ", " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_NO + " \r\n";
            q += ", " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + " \r\n";
            q += " FROM  " + OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICEITEMS_TBL + " \r\n";
            q += " INNER JOIN  " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICEITEMS_TBL + "." + OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICE_ID + " = " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_ID + " )\r\n";
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICEITEMS_TBL + "." + OFFSET_1_INVOICEITEMS.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + " )\r\n";
            q += " WHERE " + OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICEITEMS_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICEITEMS_TBL + "." + OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICEITEMS_ID + ";\r\n";

            List<Invoiceitems> list = new List<Invoiceitems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Invoiceitems obj = new Invoiceitems()
                    {
                        Invoiceitems_id = "",
                        Invoice_id = "",
                        Po_no = redr[OFFSET_1_INVOICEITEMS.OFFSET_1_PO_NO].ToString(),
                        Dc_no = redr[OFFSET_1_INVOICEITEMS.OFFSET_1_DC_NO].ToString(),
                        Product_id = CProduct_exten.GetId_Name(redr[PRODUCT.PRODUCT_NAME].ToString()),
                        Sizes_id = "1",
                        Qty = redr[OFFSET_1_INVOICEITEMS.QTY].ToString(),
                        Price = ConvertTO.Decimal(redr[OFFSET_1_INVOICEITEMS.PRICE].ToString()),
                        Cgst_percent = ConvertTO.Decimal(redr[OFFSET_1_INVOICEITEMS.CGST_PERCENT].ToString()),
                        Sgst_percent = ConvertTO.Decimal(redr[OFFSET_1_INVOICEITEMS.SGST_PERCENT].ToString()),
                        Igst_percent = ConvertTO.Decimal(redr[OFFSET_1_INVOICEITEMS.IGST_PERCENT].ToString()),
                        Refered_id = "0",
                        Locked = "0",
                    };

                    list.Add(obj);
                }

                return list;
            }
        }

        #endregion[Get Old data]

        #region[Check data]

        private static bool CheckData(Invoice.Const.Invoice obj)
        {
            string q = "USE CODEXSUN_DB; ";
            q += "SELECT * FROM " + INVOICE.INVOICE_TBL + " WHERE " + INVOICE.UNIQUENO + " = '" + obj.Uniqueno + "'; ";

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    obj.Invoice_id = redr[INVOICE.INVOICE_ID].ToString();

                    CInvoice.Update(obj, new DAL());

                    return true;
                }
                return false;
            }
        }
        #endregion[Check data]

        #region[Insert data]

        private static void InsertData(Invoice.Const.Invoice obj, List<Invoiceitems> items)
        {
            DAL dalsession;

            try
            {
                dalsession = new DAL();
                dalsession.BeginTransaction();

                List<Invoiceitems> list_new = new List<Invoiceitems>();
                if (obj != null)
                {
                    if (CheckData(obj) != true)
                    {

                        Invoice.Const.Invoice obj_new = obj;



                        switch (obj.Company_id)
                        {
                            case "1":
                                obj_new.Company_id = "1";
                                obj_new.Acy_id = "1";
                                break;

                            case "2":
                                obj_new.Company_id = "1";
                                obj_new.Acy_id = "2";
                                break;

                            case "4":
                                obj_new.Company_id = "1";
                                obj_new.Acy_id = "3";
                                break;

                            case "5":
                                obj_new.Company_id = "1";
                                obj_new.Acy_id = "4";
                                break;


                        }

                        obj.Uniqueno = obj.Acy_id + "~" + obj.Company_id + "~" + obj.Invoice_no;


                        CInvoice.Insert(obj_new, dalsession);
                        var vId = DAL.GetIdentity(dalsession);

                        for (int k = 0; k < items.Count; k++)
                        {
                            Invoiceitems v = new Invoiceitems()
                            {
                                Invoice_id = vId,
                                Po_no = items[k].Po_no,
                                Dc_no = items[k].Dc_no,
                                Product_id = items[k].Product_id,
                                Sizes_id = items[k].Sizes_id,
                                Qty = items[k].Qty,
                                Price = items[k].Price,
                                Cgst_percent = items[k].Cgst_percent,
                                Sgst_percent = items[k].Sgst_percent,
                                Igst_percent = items[k].Igst_percent,
                                Refered_id = items[k].Refered_id,
                                Locked = items[k].Locked
                            };
                            list_new.Add(v);
                        }

                        CInvoiceitems.Insert(list_new, dalsession);
                        dalsession.Commit();
                    }
                }
            }
            catch (Exception ex)

            {
                MessageBox.Show("error : " + ex);
            }

        }

        #endregion[Insert data]

    }//cls
}//ns
