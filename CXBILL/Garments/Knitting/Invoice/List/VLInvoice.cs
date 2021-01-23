// Version : 3 dt : 01-08-2017
// Auto Generated
// 17-08-2017 02:11:58 PM
// last update : 17-08-2017

using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using CXLIB;

namespace CXKNITTING
{
    public partial class LInvoice 
    {
        #region[list Option]

        public void ListRefresh()
        {
            List_Option(fAction);
        }

        private ListOption fAction = ListOption.active;
        public void List_Option(ListOption pAction)
        {
            fAction = pAction;

            switch (fAction)
            {
                case ListOption.refer:

                    if (rdo_refer.Checked == true)
                    {
                        LoadData(CInvoice_exten.Refer(new DAL()));
                    }
                    else
                    {
                        LoadData(CInvoice_exten.Unrefer(new DAL()));
                    }

                    break;

                case ListOption.showall:

                    if (rdo_showall.Checked == true)
                    {
                        LoadData(CInvoice_exten.Showall(new DAL()));
                    }
                    else
                    {
                        LoadData(CInvoice_exten.Unrefer(new DAL()));
                    }

                    break;

                case ListOption.notactive:

                    if (rdo_notactive.Checked == true)
                    {
                        LoadData(CInvoice_exten.Notactive(new DAL()));
                    }
                    else
                    {
                        LoadData(CInvoice_exten.Unrefer(new DAL()));
                    }

                    break;

                case ListOption.Search:
                    LoadData(CInvoice_exten.Searchby(txt_no.Text, txt_date.Text, txt_Todate.Text, txt_party.Text, new DAL()));
                    break;

                default:
                    LoadData(CInvoice_exten.Unrefer(new DAL()));
                    break;
            }
        }

        #endregion[list Option]

        #region[Load Data]

        public void LoadData(List<Knitting_Invoice> list)
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

                row.Cells[KNITTING_INVOICE.KNITTING_INVOICE_ID].Value = list[r].Knitting_Invoice_id;
                row.Cells[KNITTING_INVOICE.KNITTING_INVOICE_NO].Value = list[r].Knitting_Invoice_no;
                row.Cells[KNITTING_INVOICE.KNITTING_INVOICE_DATE].Value = ConvertTO.Date2S(list[r].Knitting_Invoice_date);
                row.Cells[KNITTING_INVOICE.PARTY_ID].Value = list[r].Party_id;
                row.Cells[KNITTING_INVOICE.TOTAL_QTY].Value = list[r].Total_qty;
                row.Cells[KNITTING_INVOICE.TOTAL_TAXABLE_AMOUNT].Value = list[r].Total_taxable_amount;
                row.Cells[KNITTING_INVOICE.GSTTOTAL].Value = list[r].Gsttotal;
                row.Cells[KNITTING_INVOICE.LEDGER_ID].Value = list[r].Ledger_id;
                row.Cells[KNITTING_INVOICE.ADDITIONAL].Value = list[r].Additional;
                row.Cells[KNITTING_INVOICE.GRANDTOTAL].Value = list[r].Grandtotal;
                row.Cells[KNITTING_INVOICE.USER_ID].Value = list[r].User_id;

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
                listgrid.CurrentCell = listgrid[KNITTING_INVOICE.PARTY_ID, listgrid.RowCount - 1];
            }
            listgrid.ResumeLayout(true);
        }

        #endregion[Load Data]


    }//cls
}//ns
