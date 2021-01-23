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
    public partial class LOffset_labour
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
                        LoadData(COffset_labour_exten.Refer(new DAL()));
                    }
                    else
                    {
                        LoadData(COffset_labour_exten.Unrefer(new DAL()));
                    }

                    break;

                case ListOption.showall:

                    if (rdo_showall.Checked == true)
                    {
                        LoadData(COffset_labour_exten.Showall(new DAL()));
                    }
                    else
                    {
                        LoadData(COffset_labour_exten.Unrefer(new DAL()));
                    }

                    break;

                case ListOption.notactive:

                    if (rdo_notactive.Checked == true)
                    {
                        LoadData(COffset_labour_exten.Notactive(new DAL()));
                    }
                    else
                    {
                        LoadData(COffset_labour_exten.Unrefer(new DAL()));
                    }

                    break;

                case ListOption.Search:
                    LoadData(COffset_labour_exten.Searchby(txt_no.Text, txt_date.Text, txt_Todate.Text, txt_party.Text, new DAL()));
                    break;

                default:
                    LoadData(COffset_labour_exten.Unrefer(new DAL()));
                    break;
            }
        }

        #endregion[list Option]

        #region[Load Data]

        public void LoadData(List<Offset_labour> list)
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

                row.Cells[OFFSET_LABOUR.OFFSET_LABOUR_ID].Value = list[r].Offset_labour_id;
                row.Cells[OFFSET_LABOUR.OFFSET_LABOUR_NO].Value = list[r].Offset_labour_no;
                row.Cells[OFFSET_LABOUR.OFFSET_LABOUR_DATE].Value = ConvertTO.Date2S(list[r].Offset_labour_date);
                row.Cells[OFFSET_LABOUR.PARTY_ID].Value = list[r].Party_id;
                row.Cells[OFFSET_LABOUR.TOTAL_QTY].Value = list[r].Total_qty;
                row.Cells[OFFSET_LABOUR.TOTAL_TAXABLE_AMOUNT].Value = list[r].Total_taxable_amount;
                row.Cells[OFFSET_LABOUR.GSTTOTAL].Value = list[r].Gsttotal;
                row.Cells[OFFSET_LABOUR.LEDGER_ID].Value = list[r].Ledger_id;
                row.Cells[OFFSET_LABOUR.ADDITIONAL].Value = list[r].Additional;
                row.Cells[OFFSET_LABOUR.GRANDTOTAL].Value = list[r].Grandtotal;
                row.Cells[OFFSET_LABOUR.USER_ID].Value = list[r].User_id;

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
                listgrid.CurrentCell = listgrid[OFFSET_LABOUR.PARTY_ID, listgrid.RowCount - 1];
            }
            listgrid.ResumeLayout(true);
        }

        #endregion[Load Data]

    }//cls
}//ns
