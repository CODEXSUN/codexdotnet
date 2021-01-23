using CXCORE;
using CXLIB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CXBILL
{
    class PrintInvoiceExchange
    {

        public static Print_InvoiceList GetData(string Id, List<PrintCopies> printcopies)
        {


            Print_InvoiceList list = new Print_InvoiceList();

            switch (Current.SoftwareType)
            {
                case "c":
                    list = ReturnInvoice(Id, printcopies);
                    break;


                default:
                    list = ReturnInvoice(Id, printcopies);
                    break;

            }

            return list;
        }



        private static Print_InvoiceList ReturnInvoice(string Id, List<PrintCopies> printcopies)
        {

            Invoice invoice = CInvoice_exten.PKId(Id);
            List<Invoiceitems> invoiceitems = CInvoiceitems_exten.FKId(Id);

            Company company = CCompany_exten.PKId(Current.Company_id);

            Party party = CParty_exten.SearchName(invoice.Party_id, new DAL());

            Print_InvoiceList list = new Print_InvoiceList();

            for (int i = 0; i < printcopies.Count; i++)
            {
                Print_Invoice row = new Print_Invoice();

                row.COPY_NAME = printcopies[i].Copies;
                row.SALES_TYPE = invoice.Salestype_id;
                row.TAX_TYPE = invoice.Taxtype_id;

                    row.COMPANY_NAME = company.Display_name;
                
                row.COMPANY_ADDRESS_1 = company.Street1 + ", " + company.Street2;
                row.COMPANY_ADDRESS_2 = company.City_id + "- " + company.Pincode_id + ", " + company.State_id + " - (" + Ccoreplus.GetStateCode(company.State_id) + ") . Email :- " + company.Email;
                row.COMPANY_PHONE = company.Phone;
                row.COMPANY_CELL1 = company.Cell1;
                row.COMPANY_CELL2 = company.Cell2;

                row.COMPANY_EMAIL = company.Email;
                row.COMPANY_WEBSITE = company.Website;


                if (company.Gstin.Trim().Length != 0)
                {

                    row.COMPANY_GSTIN = "GSTIN : " + company.Gstin;

                    if (company.Cell1.Trim().Length != 0)
                    {
                        row.COMPANY_GSTIN = "GSTIN : " + company.Gstin + " , Mobile : " + company.Cell1;

                        if (company.Cell2.Trim().Length != 0)
                        {
                            row.COMPANY_GSTIN = "GSTIN : " + company.Gstin + " , Mobile : " + company.Cell1 + ", " + company.Cell2;
                        }

                    }

                }
                else
                {
                    row.COMPANY_GSTIN = "";
                }




                row.INVOICE_ID = invoice.Invoice_id;
                row.INVOICE_NO = ":. "+ invoice.Invoice_no;
                row.INVOICE_DATE = ":  " + ConvertTO.Date2S(invoice.Invoice_date);

                row.TRANSPORT = ":  " + invoice.Transport_id;
                row.DELIVERYTO = ":  " + invoice.Deliveredto_id;
                row.BUNDEL = ":  " + invoice.Bundel;

                row.PARTY_NAME = party.Party_name;
                row.PARTY_STREET_1 = party.Street_1 + ",";

                if (party.Street_2.Trim().Length != 0)
                {
                    row.PARTY_STREET_2 = party.Street_2 + ",";
                }

                if (party.Pincode_id.Trim().Length == 6)
                {
                    row.PARTY_CITY = party.City_id + " - :" + party.Pincode_id + ",";
                }
                else
                {
                    row.PARTY_CITY = party.City_id + ",";
                }


                row.PARTY_STATE = party.State_id + " - (" + Ccoreplus.GetStateCode(party.State_id) + ").";

                row.PARTY_STATE_CODE = "";
                row.PARTY_COUNTRY = party.Country_id;
                row.PARTY_PINCODE = party.Pincode_id;

                if (party.Gstin.Trim().Length != 0)
                {
                    row.PARTY_GSTIN = "GSTIN :" + party.Gstin;
                }

                row.TOTAL_QTY = invoice.Total_qty.ToString();
                row.TAXABLE_VALUE = invoice.Total_taxable_amount.ToString();


                if (PrintConfig.TaxType == Core.SGST)
                {
                    row.CGST_PERCENT = "  Add CGST " + (invoiceitems[0].Cgst_percent.ToString()) + " %";
                    row.SGST_PERCENT = "  Add SGST " + (invoiceitems[0].Sgst_percent.ToString()) + " %";

                    row.TOTAL_CGST = invoice.Total_cgst.ToString();
                    row.TOTAL_SGST = invoice.Total_sgst.ToString();
                }
                else if (PrintConfig.TaxType == Core.IGST)
                {


                    row.CGST_PERCENT = "";
                    row.SGST_PERCENT = "  Add IGST " + (invoiceitems[0].Igst_percent.ToString()) + " %";

                    row.TOTAL_CGST = "";
                    row.TOTAL_SGST = invoice.Total_igst.ToString();

                }


                row.TOTAL_SUB = invoice.Grandtotal.ToString();

                row.LEDGER = CLedger_exten.GetName_Id(invoice.Ledger_id);

                if (invoice.Additional != 0)
                {
                    row.ADDITIONAL = invoice.Additional.ToString();
                }
                else
                {
                    row.ADDITIONAL = "";
                }

                row.ROUNDS = invoice.Rounds.ToString();
                row.GSTTOTAL = invoice.Gsttotal.ToString();

                row.GRANDTOTAL = invoice.Grandtotal.ToString();
                row.AMOUNT_IN_WORDS = "Rupees : " + Global.AmountInWords(invoice.Grandtotal);
                row.NOTES = invoice.Notes;
                row.ENTRY_BY = invoice.User_id;

                row.FORSIGN = company.Display_name;

                row.ACCOUNT_NO = PrintConfig.Account_no;
                row.IFSC_CODE = PrintConfig.IFSC;
                row.BANK_NAME = PrintConfig.BankName;
                row.BRANCH = PrintConfig.BankBranch;

                row.TERMS_1 = Message.TERMS_1;
                row.TERMS_2 = Message.TERMS_2;
                row.TERMS_3 = Message.TERMS_3;
                row.TERMS_4 = PrintConfig.Terms_4;


                list.Add(row);
            }

            return list;
        }








    }


    public static class Message
    {

        //public const string Account_nO = "A/C NO          : 1238261000297";
        //public const string IFSC_CODE = "IFSC CODE    : CNRB0001238";
        //public const string BANK_NAME = "BANK NAME  : CANARA BANK";
        //public const string BRANCH = "BRANCH        : ONDIPUDUR BRANCH - COIMBATORE";

        //public const string TERMS_1 = "We hereby certify that our registration under the GST Act 2017 is inforceon the date on which sale of the goods specified in this invoice is made by us and the transcation of sale is covered by this invoice has been effected by us in the regular course of our business. All the Disputes are subject to Tirupur Jurisdiction Only.";
        //public const string TERMS_2 = "* Goods once sold cannot be return back or exchanged";
        //public const string TERMS_3 = "* Seller cannot be responsible for any damage/mistakes.";

        //public const string TERMS_4 = "Raja Annamalai Tex - Vendor Code : 222911";




        //public const string Account_nO = "A/C NO          : 253805500216";
        //public const string IFSC_CODE = "IFSC CODE    : ICIC0002538";
        //public const string BANK_NAME = "BANK NAME  : ICICI BANK";
        //public const string BRANCH = "BRANCH        : P.N.ROAD BRANCH - TIRUPUR";

        public const string TERMS_1 = "We hereby certify that our registration under the GST Act 2017 is inforceon the date on which sale of the goods specified in this invoice is made by us and the transcation of sale is covered by this invoice has been effected by us in the regular course of our business. All the Disputes are subject to Tirupur Jurisdiction Only.";
        public const string TERMS_2 = "* Goods once sold cannot be return back or exchanged";
        public const string TERMS_3 = "* Seller cannot be responsible for any damage/mistakes.";

        public const string TERMS_4 = "";




        public const string Account_nO = "A/C NO          : 2344201000991";
        public const string IFSC_CODE = "IFSC CODE    : CNRB0002344";
        public const string BANK_NAME = "BANK NAME  : CANARA BANK";
        public const string BRANCH = "BRANCH        : OVERSEAS BRANCH 60 FEET ROAD - TIRUPUR";

    }

}