// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 07-08-2020 01:34:46 PM

using System;
using System.Data;
using CXLIB;
using CXCORE;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CXBILL_EXTEN
{
    public static class U_Tex_invoice
    {
        #region[]

        public static void GetUpdated(string OldDB)
        {

            string tablename = INVOICE.INVOICE_TBL;

            int count = GetCount(tablename, OldDB);

            for (int i = 1; i <= count; i++)
            {
                Invoice obj = GetOldData(i, OldDB);

                if (obj != null)
                {
                    List<Invoiceitems> list = GetOldItemsData(i, OldDB);
                    InsertData(obj, list);
                }

            }
        }

        #endregion[]

        #region[Get Count]

        private static int GetCount(string tablename, string OldDB)
        {
            string ID = (tablename.Remove((tablename).Length - 4).ToUpper()) + "_ID";

            string q = "USE " + OldDB + "; ";
            q += "SELECT * FROM " + tablename + " ORDER BY " + ID + " DESC LIMIT 1 ; ";

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    int lastId = Convert.ToInt32(redr[ID]);

                    return lastId;
                }
                return 0;
            }
        }

        #endregion[Get Count]

        #region[Get Old data]

        private static Invoice GetOldData(int id, string OldDB)
        {
            string q = "USE " + OldDB + "; ";
            q += " SELECT " + INVOICE.INVOICE_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_NAME + " \r\n";
            q += ", deliveryto_tbl.DELIVERYTO_NAME \r\n";
            q += " FROM  " + INVOICE.INVOICE_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + INVOICE.INVOICE_TBL + "." + INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + INVOICE.INVOICE_TBL + "." + INVOICE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + INVOICE.INVOICE_TBL + "." + INVOICE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + TRANSPORT.TRANSPORT_TBL + "\r\n";
            q += " ON(" + INVOICE.INVOICE_TBL + "." + INVOICE.TRANSPORT_ID + " = " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_ID + " )\r\n";
            q += " INNER JOIN  deliveryto_tbl\r\n";
            q += " ON(" + INVOICE.INVOICE_TBL + ".DELIVERYTO_ID = deliveryto_tbl.DELIVERYTO_ID )\r\n";
            q += " WHERE " + INVOICE.INVOICE_TBL + "." + INVOICE.INVOICE_ID + " = '" + id + "'; \r\n";

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Invoice obj = new Invoice
                    {
                        Uniqueno = redr[INVOICE.UNIQUENO].ToString(),
                        Company_id = redr[INVOICE.COMPANY_ID].ToString(),
                        Acy_id = redr[INVOICE.ACY_ID].ToString(),
                        Order_id = "1",
                        Invoice_no = redr[INVOICE.INVOICE_NO].ToString(),
                        Invoice_date = redr[INVOICE.INVOICE_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Taxtype_id = redr[TAXTYPE.TAXTYPE_NAME].ToString(),
                        Salestype_id = redr[SALESTYPE.SALESTYPE_NAME].ToString(),
                        Transport_id = redr[TRANSPORT.TRANSPORT_NAME].ToString(),
                        Deliveredto_id = redr["DELIVERYTO_NAME"].ToString(),
                        Bundel = redr[INVOICE.BUNDEL].ToString(),
                        Total_qty = redr[INVOICE.TOTAL_QTY].ToString(),
                        Total_taxable_amount = ConvertTO.Decimal(redr[INVOICE.TOTAL_TAXABLE_AMOUNT].ToString()),
                        Total_cgst = ConvertTO.Decimal(redr[INVOICE.TOTAL_CGST].ToString()),
                        Total_sgst = ConvertTO.Decimal(redr[INVOICE.TOTAL_SGST].ToString()),
                        Total_igst = ConvertTO.Decimal(redr[INVOICE.TOTAL_IGST].ToString()),
                        Gsttotal = ConvertTO.Decimal(redr[INVOICE.GSTTOTAL].ToString()),
                        Ledger_id = redr[INVOICE.LEDGER_ID].ToString(),
                        Additional = ConvertTO.Decimal(redr[INVOICE.ADDITIONAL].ToString()),
                        Rounds = ConvertTO.Decimal(redr[INVOICE.ROUNDS].ToString()),
                        Grandtotal = ConvertTO.Decimal(redr[INVOICE.GRANDTOTAL].ToString()),
                        Refered_amt = ConvertTO.Decimal(redr[INVOICE.REFERED_AMT].ToString()),
                        Locked = redr[INVOICE.LOCKED].ToString(),
                        Notes = redr[INVOICE.NOTES].ToString(),
                        Active_id = redr[INVOICE.ACTIVE_ID].ToString(),
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
            q += " SELECT " + INVOICEITEMS.INVOICEITEMS_TBL + ".* \r\n";
            q += ", " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + " \r\n";
            q += ", " + SIZES.SIZES_TBL + "." + SIZES.SIZES_NAME + " \r\n";
            q += " FROM  " + INVOICEITEMS.INVOICEITEMS_TBL + " \r\n";
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";
            q += " ON(" + INVOICEITEMS.INVOICEITEMS_TBL + "." + INVOICEITEMS.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + " )\r\n";
            q += " INNER JOIN  " + SIZES.SIZES_TBL + "\r\n";
            q += " ON(" + INVOICEITEMS.INVOICEITEMS_TBL + "." + INVOICEITEMS.SIZES_ID + " = " + SIZES.SIZES_TBL + "." + SIZES.SIZES_ID + " )\r\n";
            q += " WHERE " + INVOICEITEMS.INVOICEITEMS_TBL + "." + INVOICE.INVOICE_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + INVOICEITEMS.INVOICEITEMS_TBL + "." + INVOICEITEMS.INVOICEITEMS_ID + ";\r\n";

            List<Invoiceitems> list = new List<Invoiceitems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Invoiceitems obj = new Invoiceitems()
                    {
                        Invoiceitems_id = "",
                        Invoice_id = "",
                        Product_id = (redr[PRODUCT.PRODUCT_NAME].ToString()),
                        Sizes_id = (redr[SIZES.SIZES_NAME].ToString()),
                        Qty = redr[INVOICEITEMS.QTY].ToString(),
                        Price = ConvertTO.Decimal(redr[INVOICEITEMS.PRICE].ToString()),
                        Cgst_percent = ConvertTO.Decimal(redr[INVOICEITEMS.CGST_PERCENT].ToString()),
                        Sgst_percent = ConvertTO.Decimal(redr[INVOICEITEMS.SGST_PERCENT].ToString()),
                        Igst_percent = ConvertTO.Decimal(redr[INVOICEITEMS.IGST_PERCENT].ToString()),
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

        private static bool CheckData(Invoice obj)
        {
            string q = "USE CODEXSUN_DB; ";
            q += "SELECT * FROM " + INVOICE.INVOICE_TBL + " WHERE " + INVOICE.UNIQUENO + " = '" + obj.Uniqueno + "'; ";

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    obj.Invoice_id = redr[INVOICE.INVOICE_ID].ToString();

                    // CTex_Invoice.Update(obj, new DAL());

                    return true;
                }
                return false;
            }
        }
        #endregion[Check data]

        #region[Insert data]

        private static void InsertData(Invoice obj, List<Invoiceitems> items)
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

                        Invoice obj_new = new Invoice
                        {
                            Uniqueno = obj.Uniqueno,
                            Company_id = obj.Company_id,
                            Acy_id = obj.Acy_id,
                            Order_id = "1",
                            Invoice_no = obj.Invoice_no,
                            Invoice_date = obj.Invoice_date,
                            Party_id = CParty_exten.GetId_Name(obj.Party_id),
                            Taxtype_id = CTaxtype_exten.GetId_Name(obj.Taxtype_id),
                            Salestype_id = CSalestype_exten.GetId_Name(obj.Salestype_id),
                            Transport_id = CTransport_exten.GetId_Name(obj.Transport_id),
                            Deliveredto_id = CDeliveredto_exten.GetId_Name(obj.Deliveredto_id),
                            Bundel = obj.Bundel,
                            Total_qty = obj.Total_qty,
                            Total_taxable_amount = obj.Total_taxable_amount,
                            Total_cgst = obj.Total_cgst,
                            Total_sgst = obj.Total_sgst,
                            Total_igst = obj.Total_igst,
                            Gsttotal = obj.Gsttotal,
                            Ledger_id = CLedger_exten.GetName_Id(obj.Ledger_id),
                            Additional = obj.Additional,
                            Rounds = obj.Rounds,
                            Grandtotal = obj.Grandtotal,
                            Refered_amt = obj.Refered_amt,
                            Locked = obj.Locked,
                            Notes = obj.Notes,
                            Active_id = obj.Active_id,
                            User_id = "1"
                        };

                        switch (obj.Company_id)
                        {
                            case "1":
                                obj_new.Company_id = "1";
                                obj_new.Acy_id = "2";
                                break;

                            case "2":
                                obj_new.Company_id = "1";
                                obj_new.Acy_id = "3";
                                break;

                            case "3":
                                obj_new.Company_id = "1";
                                obj_new.Acy_id = "4";
                                break;

                        }

                        obj_new.Uniqueno = obj_new.Acy_id + "~" + obj_new.Company_id + "~" + obj_new.Invoice_no ;


                        CInvoice.Insert(obj_new, dalsession);
                        var vId = DAL.GetIdentity(dalsession);

                        for (int k = 0; k < items.Count; k++)
                        {
                            Invoiceitems v = new Invoiceitems()
                            {
                                Invoice_id = vId,
                                Product_id = CProduct_exten.GetId_Name(items[k].Product_id),
                                Sizes_id = CSizes_exten.GetId_Name(items[k].Sizes_id),
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
