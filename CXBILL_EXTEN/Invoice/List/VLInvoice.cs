// Version : 3 dt : 01-08-2017
// Auto Generated
// 17-08-2017 02:11:58 PM
// last update : 17-08-2017

using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CXBILL_EXTEN.Invoice.Class;
using CXBILL_EXTEN.Invoice.Const;
using CXLIB;

namespace CXBILL_EXTEN.Invoice.List
{
    public partial class LInvoice 
    {
        #region[list Option]

        public void ListRefresh()
        {
            List_Option(fAction);
        }

        private ListOption fAction = ListOption.showall;
        public void List_Option(ListOption pAction)
        {
            fAction = pAction;

            switch (fAction)
            {
                case ListOption.refer:

                    if (rdo_refer.Checked == true)
                    {
                        LoadData(CInvoice_exten.Refer());
                    }
                    else
                    {
                        LoadData(CInvoice_exten.Unrefer());
                    }

                    break;

                case ListOption.showall:

                    if (rdo_showall.Checked == true)
                    {
                        LoadData(CInvoice_exten.Showall());
                    }
                    else
                    {
                        LoadData(CInvoice_exten.Unrefer());
                    }

                    break;

                case ListOption.notactive:

                    if (rdo_notactive.Checked == true)
                    {
                        LoadData(CInvoice_exten.Notactive());
                    }
                    else
                    {
                        LoadData(CInvoice_exten.Unrefer());
                    }

                    break;

                case ListOption.Search:
                    LoadData(CInvoice_exten.Searchby(txt_no.Text, txt_date.Text, txt_Todate.Text, txt_party.Text));
                    break;

                default:
                    LoadData(CInvoice_exten.Showall());
                    break;
            }
        }

        #endregion[list Option]

        #region[Load Data]

        public void LoadData(List<Const.Invoice> list)
        {
            if (constructed_flag == false)
            {
                return;
            }

            listgrid.SuspendLayout();

            listgrid.RowCount = 0;
            listgrid.RowCount = list.Count;
            for (int r = 0; r < list.Count; r++)
            {
                DataGridViewRow row = listgrid.Rows[r];

                row.Cells[INVOICE.INVOICE_ID].Value = list[r].Invoice_id;
                row.Cells[INVOICE.INVOICE_NO].Value = list[r].Invoice_no;
                row.Cells[INVOICE.INVOICE_DATE].Value = ConvertTO.Date2S(list[r].Invoice_date);
                row.Cells[INVOICE.PARTY_ID].Value = list[r].Party_id;
                row.Cells[INVOICE.TOTAL_QTY].Value = list[r].Total_qty;
                row.Cells[INVOICE.TOTAL_TAXABLE_AMOUNT].Value = list[r].Total_taxable_amount;
                row.Cells[INVOICE.GSTTOTAL].Value = list[r].Gsttotal;
                row.Cells[INVOICE.LEDGER_ID].Value = list[r].Ledger_id;
                row.Cells[INVOICE.ADDITIONAL].Value = list[r].Additional;
                row.Cells[INVOICE.GRANDTOTAL].Value = list[r].Grandtotal;
                row.Cells[INVOICE.USER_ID].Value = list[r].User_id;

                switch (list[r].Locked)
                {
                    case Core.Locked:
                        row.Cells[GRID.CELL].Style.BackColor = Color.FromArgb(0, 152, 70);
                        row.Cells[GRID.CELL].Style.ForeColor = Color.White;
                        row.Cells[GRID.CELL].Value = Core.Txt_Locked;
                        break;
                    case Core.Partial:
                        row.Cells[GRID.CELL].Style.BackColor = Color.FromArgb(255, 237, 0);
                        row.Cells[GRID.CELL].Style.ForeColor = Color.FromArgb(0, 141, 210);
                        row.Cells[GRID.CELL].Value = Core.Txt_Partial;

                        break;
                    default:
                        row.Cells[GRID.CELL].Style.BackColor = Color.FromArgb(227, 30, 36);
                        row.Cells[GRID.CELL].Style.ForeColor = Color.White;
                        row.Cells[GRID.CELL].Value = Core.Txt_Unlocked;
                        break;
                }

            }

            if (listgrid.RowCount != 0)
            {
                listgrid.CurrentCell = listgrid[INVOICE.PARTY_ID, listgrid.RowCount - 1];
            }
            listgrid.ResumeLayout(true);
        }

        #endregion[Load Data]


    }//cls
}//ns
