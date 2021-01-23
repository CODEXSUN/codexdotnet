// Version : 3 dt : 01-08-2017
// Auto Generated
// 17-08-2017 02:11:58 PM
// last update : 17-08-2017

using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CXBILL_EXTEN.Labour.Class;
using CXBILL_EXTEN.Labour.Const;
using CXLIB;

namespace CXBILL_EXTEN.Labour.List
{
    public partial class LLabour 
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
                        LoadData(CLabour_exten.Refer());
                    }
                    else
                    {
                        LoadData(CLabour_exten.Unrefer());
                    }

                    break;

                case ListOption.showall:

                    if (rdo_showall.Checked == true)
                    {
                        LoadData(CLabour_exten.Showall());
                    }
                    else
                    {
                        LoadData(CLabour_exten.Unrefer());
                    }

                    break;

                case ListOption.notactive:

                    if (rdo_notactive.Checked == true)
                    {
                        LoadData(CLabour_exten.Notactive());
                    }
                    else
                    {
                        LoadData(CLabour_exten.Unrefer());
                    }

                    break;

                case ListOption.Search:
                    LoadData(CLabour_exten.Searchby(txt_no.Text, txt_date.Text, txt_Todate.Text, txt_party.Text));
                    break;

                default:
                    LoadData(CLabour_exten.Showall());
                    break;
            }
        }

        #endregion[list Option]

        #region[Load Data]

        public void LoadData(List<Const.Labour> list)
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

                row.Cells[LABOUR.LABOUR_ID].Value = list[r].Labour_id;
                row.Cells[LABOUR.LABOUR_NO].Value = list[r].Labour_no;
                row.Cells[LABOUR.LABOUR_DATE].Value = ConvertTO.Date2S(list[r].Labour_date);
                row.Cells[LABOUR.PARTY_ID].Value = list[r].Party_id;
                row.Cells[LABOUR.TOTAL_QTY].Value = list[r].Total_qty;
                row.Cells[LABOUR.TOTAL_TAXABLE_AMOUNT].Value = list[r].Total_taxable_amount;
                row.Cells[LABOUR.GSTTOTAL].Value = list[r].Gsttotal;
                row.Cells[LABOUR.LEDGER_ID].Value = list[r].Ledger_id;
                row.Cells[LABOUR.ADDITIONAL].Value = list[r].Additional;
                row.Cells[LABOUR.GRANDTOTAL].Value = list[r].Grandtotal;
                row.Cells[LABOUR.USER_ID].Value = list[r].User_id;

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
                listgrid.CurrentCell = listgrid[LABOUR.PARTY_ID, listgrid.RowCount - 1];
            }
            listgrid.ResumeLayout(true);
        }

        #endregion[Load Data]


    }//cls
}//ns
