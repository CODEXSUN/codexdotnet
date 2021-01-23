// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 26-03-2019 08:29:42 PM

using CXLIB;
using System.Drawing;
using System.Windows.Forms;

namespace ERP
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

            string[] _erp;


            Add_menu(_Master, MainMenuHeader.Master, _MasterCommon);


            switch (Current.SoftwareType)
            {
                case SoftwareTypes.GARMENT:
                    _erp = new string[] { DropMenuERP.Orderinfo, DropMenuERP.Style, DropMenuERP.Article };

                    Add_menu(_erp, MainMenuHeader.Erp, null);

                    break;


            }
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
        internal const string Master = "MASTER";
        internal const string Sales = "SALES ENTRIES";
        internal const string Purchase = "PURCHASE ENTRIES";
        internal const string Report = "REPORT";
        internal const string Accounts = "ACCOUNTS";
        internal const string Admin = "ADMIN";
        internal const string Erp = "ERP";



    }

    #endregion[Main Menu]

    #region[Core]

    internal class DropMenuCore
    {
        internal const string Common = "Common Task";

        internal const string Company = "Company";
        internal const string Party = "Party";
        internal const string Product = "Product";

        internal const string City = "City";
        internal const string State = "State";
        internal const string Country = "Country";
        internal const string Pincode = "Pincode";


        internal const string ContactType = "Contact Type";
        internal const string Units = "UNit of Measure";
        internal const string LedgerGroup = "Ledger Group";
        internal const string Ledger = "Ledger";
        internal const string Bank = "Bank";
        internal const string ReceiptType = "Receipt Type";
        internal const string SalesType = "Sales Type";
        internal const string TaxType = "Tax Type";
        internal const string ProductType = "Product Type";
        internal const string Hsncode = "Hsncode";

        internal const string Colours = "Colours";
        internal const string Sizes = "Sizes";
        internal const string Ordertype = "Order Type";

        internal const string Transport = "Transport";
        internal const string Deliveredto = "Delivered TO";

        internal const string Month = "Month";
    }

    #endregion[Core]


    #region[Erp Menu]

    internal class DropMenuERP
    {

        internal const string Orderinfo = "Order info";
        internal const string Article = "Article";
        internal const string Job = "JOB";
        internal const string Inward = "Inward";
        internal const string Outward = "Outward";
        internal const string Style = "Style";
        

    }

    #endregion[Erp Menu]



}//ns
