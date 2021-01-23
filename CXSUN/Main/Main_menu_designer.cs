// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 26-03-2019 08:29:42 PM

using CXLIB;
using System.Drawing;
using System.Windows.Forms;

namespace CXSUN
{
    public partial class Main
    {
        private ToolStripMenuItem MenuItems;

        private void IntiMainMenu()
        {

            string[] _Master = new string[] { DropMenuCore.Company, DropMenuCore.Party, DropMenuCore.Product, DropMenuCore.Common };

            string[] _MasterCommon = new string[]
            {
                DropMenuCore.Bank,
                DropMenuCore.City,
                DropMenuCore.State,
                DropMenuCore.Country,
                DropMenuCore.Pincode,
                DropMenuCore.ContactType,
                DropMenuCore.Units,
                DropMenuCore.Ledger,
                DropMenuCore.LedgerGroup,
                DropMenuCore.ProductType,
                DropMenuCore.Hsncode,
                DropMenuCore.TaxType,
                DropMenuCore.SalesType,
                DropMenuCore.Colours,
                DropMenuCore.Sizes,
                DropMenuCore.Transport,
                DropMenuCore.Deliveredto,
                DropMenuCore.Month,

            };


            Add_menu(_Master, MainMenuHeader.Master, _MasterCommon);

            string[] _Admin = new string[] { DropMenuAdmin.User, DropMenuAdmin.SelectCompany, DropMenuAdmin.Update, DropMenuAdmin.Logout };


            string[] _Accounts;

            string[] _Sales;

            string[] _Purchase;

            string[] _Report;


            switch (Current.SoftwareType)
            {
                case SoftwareTypes.GARMENT:
                    _Sales = new string[] { BillMenu.Order, BillMenu.Sales, BillMenu.Receipt };
                    _Purchase = new string[] { BillMenu.Purchase, BillMenu.Payment };
                    _Report = new string[] {  DropMenuReport.PartyStatement, DropMenuReport.GSTRegister };
                    _Accounts = new string[] { DM_Accounts.CashPayment, DM_Accounts.CashReceipt , DM_Accounts.CashInHand };

                    Add_menu(_Sales, MainMenuHeader.Sales, null);
                    Add_menu(_Purchase, MainMenuHeader.Purchase, null);
                    Add_menu(_Report, MainMenuHeader.Report, null);
                    Add_menu(_Accounts, MainMenuHeader.Accounts, null);

                    break;

                case SoftwareTypes.OFFSET:
                    _Sales = new string[] { BillMenu.Order, BillMenu.Sales, BillMenu.Receipt, BillMenu.LabourBill, BillMenu.QReceipt };
                    _Purchase = new string[] { BillMenu.Purchase, BillMenu.Payment };
                    _Report = new string[] { DropMenuReport.PartyStatement, DropMenuReport.GSTRegister };
                    //_Accounts = new string[] { DM_Accounts.CashPayment, DM_Accounts.CashReceipt, DM_Accounts.CashInHand };


                    Add_menu(_Sales, MainMenuHeader.Sales, null);
                    Add_menu(_Purchase, MainMenuHeader.Purchase, null);
                    Add_menu(_Report, MainMenuHeader.Report, null);
                    //Add_menu(_Accounts, MainMenuHeader.Accounts, null);
                    break;

                case SoftwareTypes.TEX:
                    _Sales = new string[] { BillMenu.Order, BillMenu.Sales, BillMenu.Receipt, BillMenu.Quotation, BillMenu.QReceipt};
                    _Purchase = new string[] { BillMenu.Purchase, BillMenu.Payment };
                    _Report = new string[] { DropMenuReport.PartyStatement, DropMenuReport.QuotatiomStatement, DropMenuReport.Outstanding, DropMenuReport.GSTRegister };

                    Add_menu(_Sales, MainMenuHeader.Sales, null);
                    Add_menu(_Purchase, MainMenuHeader.Purchase, null);
                    Add_menu(_Report, MainMenuHeader.Report, null);
                    break;
               // case SoftwareTypes.KNITTING:
                 //   break;

                case SoftwareTypes.UPVC:

                    _Sales = new string[] { BillMenu.Sales, BillMenu.Receipt, BillMenu.Quotation };
                    _Purchase = new string[] { BillMenu.Purchase, BillMenu.Payment };
                    _Report = new string[] { DropMenuReport.PartyStatement, DropMenuReport.GSTRegister };

                    Add_menu(_Sales, MainMenuHeader.Sales, null);
                    Add_menu(_Purchase, MainMenuHeader.Purchase, null);
                    Add_menu(_Report, MainMenuHeader.Report, null);
                    break;
            }
            

            Add_menu(_Admin, MainMenuHeader.Admin, null);

        }

        #region[Add menu]

        ToolStripSeparator s;
        ToolStripMenuItem SSMenu;

        private void Add_menu(string[] items, string header, string[] sub)
        {

            MenuItems = new ToolStripMenuItem();
            menu_main.Items.Add(MenuItems);

            MenuItems.Text = header;
            MenuItems.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuItems.ForeColor = Color.FromArgb(62, 69, 77);
            MenuItems.Size = new Size(200, 26);

            foreach (string rw in items)
            {
                SSMenu = new ToolStripMenuItem(rw, null, Menu_Selector)
                {
                    ForeColor = Color.FromArgb(40, 96, 144),
                    Size = new Size(204, 22)
                };

                MenuItems.DropDownItems.Add(SSMenu);

                MenuItems.DropDownItems.Add(new ToolStripSeparator());
            }

            s = new ToolStripSeparator
            {
                Text = "|",
            };

            menu_main.Items.Add(s);

            if (sub != null)
                foreach (string rw in sub)
                {
                    ToolStripMenuItem vs = new ToolStripMenuItem(rw, null, Menu_Selector)
                    {
                        ForeColor = Color.FromArgb(40, 96, 144),
                        Size = new Size(204, 22)
                    };

                    SSMenu.DropDownItems.Add(vs);

                    SSMenu.DropDownItems.Add(new ToolStripSeparator());
                }
        }

        #endregion[Add menu]

    }//cls

    #region[Main Menu]

    internal class MainMenuHeader
    {
        public const string Master = "MASTER";
        public const string Sales = "SALES ENTRIES";
        public const string Purchase = "PURCHASE ENTRIES";
        public const string Report = "REPORT";
        public const string Accounts = "ACCOUNTS";
        internal const string Admin = "ADMIN";

    }

    #endregion[Main Menu]

    #region[Core]

    internal class DropMenuCore
    {
        public const string Common = "Common Task";

        public const string Company = "Company";
        public const string Party = "Party";
        public const string Product = "Product";

        public const string City = "City";
        public const string State = "State";
        public const string Country = "Country";
        public const string Pincode = "Pincode";


        public const string ContactType = "Contact Type";
        public const string Units = "UNit of Measure";
        public const string LedgerGroup = "Ledger Group";
        public const string Ledger = "Ledger";
        public const string Bank = "Bank";
        public const string ReceiptType = "Receipt Type";
        public const string SalesType = "Sales Type";
        public const string TaxType = "Tax Type";
        public const string ProductType = "Product Type";
        public const string Hsncode = "Hsncode";

        public const string Colours = "Colours";
        public const string Sizes = "Sizes";
        public const string Ordertype = "Order Type";

        public const string Transport = "Transport";
        public const string Deliveredto = "Delivered TO";

        public const string Month = "Month";
    }

    #endregion[Core]

    #region[Bill]

    internal class BillMenu
    {
        public const string Po = "Po";
        public const string Dc = "Dc";
        public const string Sales = "Sales";
        public const string LabourBill = "LabourBill";
        public const string Receipt = "Receipt";
        public const string QReceipt = "QReceipt";
        public const string Quotation = "Quotation";

        public const string Pi = "Pi";
        public const string Inward = "Inward";
        public const string Purchase = "PurchaseInvoice";
        public const string Payment = "Payment";

        public const string Order = "Order";

    }

    #endregion[Bill]


    #region[Report]
    //DM stants for Dropdown Menu
    internal class DM_Accounts
    {
        public const string CashPayment = "CASH PAYMENT";
        public const string CashReceipt = "CASH RECEIPT";
        public const string CashInHand = "CASH IN HAND";
    }

    #endregion[Drop Menu Report]

    #region[Report]

    internal class DropMenuReport
    {

        public const string PartyStatement = "PARTY STATEMENT";
        public const string QuotatiomStatement = "QUOTATION STATEMENT";

        public const string SalesRegister = "SALES REGISTER";
        public const string PurchaseRegister = "PURCHASE REGISTER";
        //public const string PartyLedger = "PARTY LEDGER";

        public const string GSTRegister = "GST REGISTER";
        public const string Outstanding = "Outstanding";
    }

    #endregion[Drop Menu Report]

    #region[admin]

    internal class DropMenuAdmin
    {

        public const string User = "USER";
        public const string SelectCompany = "SELECT COMPANY";
        public const string Update = "UPDATE";
        public const string Logout = "LOGOUT";
    }

    #endregion[Drop menu admin]

}//ns
