// Version : 3 dt : 01-08-2017
// Auto Generated
// 17-08-2017 02:11:58 PM
// last update : 17-08-2017

using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using CXLIB;

namespace CXBILL
{
    public partial class LQuotation 
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

                case ListOption.notactive:

                    if (rdo_notactive.Checked == true)
                    {
                        LoadData(CQuotation_exten.Notactive(new DAL()));
                    }
                    else
                    {
                        LoadData(CQuotation_exten.Showall(new DAL()));
                    }

                    break;

                case ListOption.Search:
                    LoadData(CQuotation_exten.Searchby(txt_no.Text, txt_date.Text, txt_Todate.Text, txt_party.Text, new DAL()));
                    break;

                default:
                    LoadData(CQuotation_exten.Showall(new DAL()));
                    break;
            }
        }

        #endregion[list Option]

        #region[Load Data]

        public void LoadData(List<Quotation> list)
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

                row.Cells[QUOTATION.QUOTATION_ID].Value = list[r].Quotation_id;
                row.Cells[QUOTATION.QUOTATION_NO].Value = list[r].Quotation_no;
                row.Cells[QUOTATION.QUOTATION_DATE].Value = ConvertTO.Date2S(list[r].Quotation_date);
                row.Cells[QUOTATION.PARTY_ID].Value = list[r].Party_id;
                row.Cells[QUOTATION.TOTAL_QTY].Value = list[r].Total_qty;
                row.Cells[QUOTATION.TOTAL_TAXABLE_AMOUNT].Value = list[r].Total_taxable_amount;
                row.Cells[QUOTATION.LEDGER_ID].Value = list[r].Ledger_id;
                row.Cells[QUOTATION.ADDITIONAL].Value = list[r].Additional;
                row.Cells[QUOTATION.GRANDTOTAL].Value = list[r].Grandtotal;
                row.Cells[QUOTATION.USER_ID].Value = list[r].User_id;

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
                listgrid.CurrentCell = listgrid[QUOTATION.PARTY_ID, listgrid.RowCount - 1];
            }
            listgrid.ResumeLayout(true);
        }

        #endregion[Load Data]


    }//cls
}//ns
