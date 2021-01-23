// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 21-06-2019 10:08:18 AM

using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using CXLIB;

namespace CXBILL
{
    public partial class LGarment_invoice
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
                        LoadData(CGarment_invoice_exten.Refer());
                    }
                    else
                    {
                        LoadData(CGarment_invoice_exten.Unrefer());
                    }

                    break;

                case ListOption.showall:

                    if (rdo_showall.Checked == true)
                    {
                        LoadData(CGarment_invoice_exten.Showall());
                    }
                    else
                    {
                        LoadData(CGarment_invoice_exten.Unrefer());
                    }

                    break;

                case ListOption.notactive:

                    if (rdo_notactive.Checked == true)
                    {
                        LoadData(CGarment_invoice_exten.Notactive());
                    }
                    else
                    {
                        LoadData(CGarment_invoice_exten.Unrefer());
                    }

                    break;

                case ListOption.Search:
                    LoadData(CGarment_invoice_exten.Searchby(txt_no.Text, txt_date.Text, txt_Todate.Text, txt_party.Text));
                    break;

                default:
                    LoadData(CGarment_invoice_exten.Unrefer());
                    break;
            }
        }

        #endregion[list Option]

        #region[Load Data]

        public void LoadData(List<Garment_invoice> list)
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

                row.Cells[GARMENT_INVOICE.GARMENT_INVOICE_ID].Value = list[r].Garment_invoice_id;
                row.Cells[GARMENT_INVOICE.ORDER_ID].Value = list[r].Order_id;
                //row.Cells[GARMENT_INVOICE.SALESTYPE_ID].Value = list[r].Salestype_id;
                //row.Cells[GARMENT_INVOICE.TAXTYPE_ID].Value = list[r].Taxtype_id;
                row.Cells[GARMENT_INVOICE.GARMENT_INVOICE_NO].Value = list[r].Garment_invoice_no;
                row.Cells[GARMENT_INVOICE.GARMENT_INVOICE_DATE].Value = ConvertTO.Date2S(list[r].Garment_invoice_date);
                row.Cells[GARMENT_INVOICE.PARTY_ID].Value = list[r].Party_id;
                row.Cells[GARMENT_INVOICE.TOTAL_QTY].Value = list[r].Total_qty;
                row.Cells[GARMENT_INVOICE.TOTAL_TAXABLE_AMOUNT].Value = list[r].Total_taxable_amount;
                //row.Cells[GARMENT_INVOICE.TOTAL_CGST].Value = list[r].Total_cgst;
                //row.Cells[GARMENT_INVOICE.TOTAL_SGST].Value = list[r].Total_sgst;
                //row.Cells[GARMENT_INVOICE.TOTAL_IGST].Value = list[r].Total_igst;
                row.Cells[GARMENT_INVOICE.GSTTOTAL].Value = list[r].Gsttotal;
                //row.Cells[GARMENT_INVOICE.LEDGER_ID].Value = list[r].Ledger_id;
                //row.Cells[GARMENT_INVOICE.ADDITIONAL].Value = list[r].Additional;
                //row.Cells[GARMENT_INVOICE.ROUNDS].Value = list[r].Rounds;
                row.Cells[GARMENT_INVOICE.GRANDTOTAL].Value = list[r].Grandtotal;
                //row.Cells[GARMENT_INVOICE.REFERED_AMT].Value = list[r].Refered_amt;
                //row.Cells[GARMENT_INVOICE.LOCKED].Value = list[r].Locked;
                row.Cells[GARMENT_INVOICE.USER_ID].Value = list[r].User_id;

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
                listgrid.CurrentCell = listgrid[GARMENT_INVOICE.PARTY_ID, listgrid.RowCount - 1];
            }
            listgrid.ResumeLayout(true);
        }

        #endregion[Load Data]


    }//cls
}//ns
