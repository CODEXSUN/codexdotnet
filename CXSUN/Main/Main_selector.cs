// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 11:17:05 PM

using CXCORE;
using CXLIB;
using System;
using System.Windows.Forms;
using CXBILL;
using CXACCOUNTS;

namespace CXSUN
{
    public partial class Main
    {

        void Menu_Selector(object sender, EventArgs e)
        {

            switch (sender.ToString())
            {
                #region[Master]

                case DropMenuCore.Company:
                    Mymenu_Click(sender, e, new FCompany());

                    break;
                case DropMenuCore.Party:
                    Mymenu_Click(sender, e, new LParty());
                    break;
                case DropMenuCore.Product:
                    Mymenu_Click(sender, e, new LProduct());
                    break;

                #endregion[Master]

                #region[Core]

                case DropMenuCore.Bank:
                    Mymenu_Click(sender, e, new LBank());
                    break;
                case DropMenuCore.City:
                    Mymenu_Click(sender, e, new LCity());
                    break;
                case DropMenuCore.State:
                    Mymenu_Click(sender, e, new LState());
                    break;
                case DropMenuCore.Country:
                    Mymenu_Click(sender, e, new LCountry());
                    break;
                case DropMenuCore.Pincode:
                    Mymenu_Click(sender, e, new LPincode());
                    break;
                case DropMenuCore.ContactType:
                    Mymenu_Click(sender, e, new LContacttype());
                    break;
                case DropMenuCore.Units:
                    Mymenu_Click(sender, e, new LUnit());
                    break;
                case DropMenuCore.Ledger:
                    Mymenu_Click(sender, e, new LLedger());
                    break;
                case DropMenuCore.LedgerGroup:
                    Mymenu_Click(sender, e, new LLedgergroup());
                    break;
                case DropMenuCore.ProductType:
                    Mymenu_Click(sender, e, new LProducttype());
                    break;
                case DropMenuCore.Hsncode:
                    Mymenu_Click(sender, e, new LHsncode());
                    break;
                case DropMenuCore.TaxType:
                    Mymenu_Click(sender, e, new LTaxtype());
                    break;
                case DropMenuCore.SalesType:
                    Mymenu_Click(sender, e, new LSalestype());
                    break;
                case DropMenuCore.Month:
                    Mymenu_Click(sender, e, new LMonth());
                    break;

                #endregion[Core]

                #region[PO]

                case BillMenu.Po:
                    switch (Current.SoftwareType)
                    {
                        case SoftwareTypes.OFFSET:
                            //Mymenu_Click(sender, e, new Lpo());
                            break;
                    }
                    break;

                #endregion[PO]

                #region[Dc]

                case BillMenu.Dc:
                    switch (Current.SoftwareType)
                    {
                        case SoftwareTypes.OFFSET:
                            //Mymenu_Click(sender, e, new Lpo());
                            break;
                    }
                    break;

                #endregion[Dc]

                #region[Sales]

                case BillMenu.Sales:

                    switch (Current.SoftwareType)
                    {
                        case SoftwareTypes.GARMENT:
                        case SoftwareTypes.TEX:
                            Mymenu_Click(sender, e, new LInvoice());
                            break;

                        case SoftwareTypes.OFFSET:
                            Mymenu_Click(sender, e, new CXBILL_EXTEN.Invoice.List.LInvoice());
                            break;

                        case SoftwareTypes.UPVC:
                            //Mymenu_Click(sender, e, new LUpvc_invoice());
                            break;

                    }
                    break;

                #endregion[Sales]

                #region[Quotation]

                case BillMenu.Quotation:

                    switch (Current.SoftwareType)
                    {
                        case SoftwareTypes.GARMENT:
                        case SoftwareTypes.OFFSET:
                            break;
                        case SoftwareTypes.UPVC:
                            //Mymenu_Click(sender, e, new LUpvc_Quotation());
                            break;
                        case SoftwareTypes.TEX:
                            Mymenu_Click(sender, e, new LQuotation());
                            break;
                    }
                    break;


                #endregion[Quotation]

                #region[Labour bill]

                case BillMenu.LabourBill:
                    Mymenu_Click(sender, e, new CXBILL_EXTEN.Labour.List.LLabour());
                    break;

                #endregion[Labour bill]

                #region[Purchase]

                case BillMenu.Purchase:

                    switch (Current.SoftwareType)
                    {
                        case SoftwareTypes.GARMENT:
                        case SoftwareTypes.OFFSET:
                            case SoftwareTypes.TEX:
                            Mymenu_Click(sender, e, new LPurchase());
                            break;
                    }

                    break;

                #endregion[Purchase]

                #region[Payment]

                case BillMenu.Payment:

                    switch (Current.SoftwareType)
                    {
                        case SoftwareTypes.GARMENT:
                        case SoftwareTypes.OFFSET:
                        case SoftwareTypes.TEX:
                            Mymenu_Click(sender, e, new LPayment());
                            break;
                    }

                    break;

                #endregion[Payment]

                #region[Order]

                case BillMenu.Order:

                    switch (Current.SoftwareType)
                    {
                        case SoftwareTypes.GARMENT:
                        case SoftwareTypes.OFFSET:
                        case SoftwareTypes.TEX:
                            Mymenu_Click(sender, e, new LOrder());
                            break;

                    }

                    break;

                #endregion[Order]

                #region[Receipt]


                case BillMenu.Receipt:
                    switch (Current.SoftwareType)
                    {
                        case SoftwareTypes.GARMENT:
                        case SoftwareTypes.OFFSET:
                        case SoftwareTypes.TEX:
                            Mymenu_Click(sender, e, new LReceipt());
                            break;
                    }
                    break;


                case BillMenu.QReceipt:
                    switch (Current.SoftwareType)
                    {
                        case SoftwareTypes.TEX:
                            Mymenu_Click(sender, e, new LQreceipt());
                            break;
                    }
                    break;


                #endregion[Receipt]

                #region[Reports]

                case DropMenuReport.SalesRegister:
                    switch (Current.SoftwareType)
                    {
                        case SoftwareTypes.GARMENT:
                            //Mymenu_Click(sender, e, new RSalesRegister());
                            break;
                            //case SoftwareTypes.OFFSET:
                            //    //Mymenu_Click(sender, e, new ROffset_1_party());
                            //    break;
                            //case SoftwareTypes.OFFSET_1:
                            //    //Mymenu_Click(sender, e, new ROffset_1_party());
                            //    break;
                            //case SoftwareTypes.KNITTING:
                            //    //Mymenu_Click(sender, e, new LReceipt());
                            //    break;
                    }
                    break;

                case DropMenuReport.PurchaseRegister:
                    switch (Current.SoftwareType)
                    {
                        case SoftwareTypes.GARMENT:
                            //Mymenu_Click(sender, e, new LGarment_receipt());
                            break;
                            //case SoftwareTypes.OFFSET:
                            //    //Mymenu_Click(sender, e, new LOffset_receipt());
                            //    break;
                            //case SoftwareTypes.OFFSET_1:
                            //    //Mymenu_Click(sender, e, new ROffset_1_party());
                            //    break;
                            //case SoftwareTypes.KNITTING:
                            //    //Mymenu_Click(sender, e, new LReceipt());
                            //    break;
                    }
                    break;

                case DropMenuReport.PartyStatement:
                    switch (Current.SoftwareType)
                    {
                        case SoftwareTypes.GARMENT:
                            //Mymenu_Click(sender, e, new LGarment_receipt());
                            //break;
                            case SoftwareTypes.OFFSET:
                            //    //Mymenu_Click(sender, e, new ROffset_1_party());
                            //    break;
                            //case SoftwareTypes.OFFSET_1:
                            //    //Mymenu_Click(sender, e, new ROffset_1_party());
                            //    break;
                            //case SoftwareTypes.KNITTING:
                            //    //Mymenu_Click(sender, e, new LReceipt());
                            //    break;
                            case SoftwareTypes.TEX:
                                Mymenu_Click(sender, e, new FReportpartyStatement());
                                break;
                    }
                    break;

                case DropMenuReport.QuotatiomStatement:
                    switch (Current.SoftwareType)
                    {
                        case SoftwareTypes.TEX:
                            Mymenu_Click(sender, e, new ReportQuotationStatement());
                            break;
                    }
                    break;


                case DropMenuReport.Outstanding:
                    switch (Current.SoftwareType)
                    {
                        case SoftwareTypes.TEX:
                            Mymenu_Click(sender, e, new LOutstanding());
                            break;
                    }
                    break;

                case DropMenuReport.GSTRegister:
                    switch (Current.SoftwareType)
                    {
                        case SoftwareTypes.GARMENT:
                        case SoftwareTypes.OFFSET:
                            Mymenu_Click(sender, e, new RGSTRegister());
                            break;
                            //case SoftwareTypes.OFFSET:
                            //    //Mymenu_Click(sender, e, new LOffset_receipt());
                            //    break;
                            //case SoftwareTypes.OFFSET_1:
                            //    //Mymenu_Click(sender, e, new ROffset_1_party());
                            //    break;
                            //case SoftwareTypes.KNITTING:
                            //    //Mymenu_Click(sender, e, new LReceipt());
                            //    break;
                    }
                    break;

                #endregion[Reports]

                #region[Accounts]

                case DM_Accounts.CashPayment:
                    Mymenu_Click(sender, e, new LCash_payment());
                    break;
                case DM_Accounts.CashReceipt:
                    Mymenu_Click(sender, e, new LCash_receipt());
                    break;
                case DM_Accounts.CashInHand:
                    Mymenu_Click(sender, e, new LCash_in_hand());
                    break;

                #endregion[Accounts]

                #region[Admin]

                case DropMenuAdmin.User:
                    Mymenu_Click(sender, e, new LUser());
                    break;
                case DropMenuAdmin.SelectCompany:
                    //Mymenu_Click(sender, e, new SCompany());

                    LogoutallOpened();
                    if (scompany == null)
                    {
                        scompany = new SCompany();
                    }
                    scompany.SCompany_NeedToRefresh += SCompany_Refresh;
                    Controls.Add(scompany);
                    scompany.Show();
                    scompany.Dock = DockStyle.Fill;
                    scompany.BringToFront();

                    break;
                case DropMenuAdmin.Update:
                    Updater_menu_Click();

                    break;

                    #endregion[Admin]

            }
        }
    }//cls
}//ns