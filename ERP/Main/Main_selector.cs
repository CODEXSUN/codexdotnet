// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 11:17:05 PM

using CXCORE;
using CXERP;
using System;

namespace ERP
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


                #region[Erp]


                case DropMenuERP.Orderinfo:
                    Mymenu_Click(sender, e, new LOrder());
                    break;

                case DropMenuERP.Article:
                    Mymenu_Click(sender, e, new LArticle());
                    break;

                    #endregion[Erp]

            }
        }
    }//cls
}//ns