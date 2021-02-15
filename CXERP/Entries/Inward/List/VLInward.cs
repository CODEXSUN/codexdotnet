// Version : 3 dt : 01-08-2017
// Auto Generated
// 17-08-2017 02:11:58 PM
// last update : 17-08-2017

using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using CXLIB;

namespace CXERP
{
    public partial class LInward 
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
                        LoadData(CInward_exten.Refer());
                    }
                    else
                    {
                        LoadData(CInward_exten.Unrefer());
                    }

                    break;

                case ListOption.showall:

                    if (rdo_showall.Checked == true)
                    {
                        LoadData(CInward_exten.Showall());
                    }
                    else
                    {
                        LoadData(CInward_exten.Unrefer());
                    }

                    break;

                case ListOption.notactive:

                    if (rdo_notactive.Checked == true)
                    {
                        LoadData(CInward_exten.Notactive());
                    }
                    else
                    {
                        LoadData(CInward_exten.Unrefer());
                    }

                    break;

                case ListOption.Search:
                    LoadData(CInward_exten.Searchby(txt_no.Text, txt_date.Text, txt_Todate.Text, txt_party.Text));
                    break;

                default:
                    LoadData(CInward_exten.Showall());
                    break;
            }
        }

        #endregion[list Option]

        #region[Load Data]

        public void LoadData(List<Inward> list)
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

                row.Cells[INWARD.INWARD_ID].Value = list[r].Inward_id;
                row.Cells[INWARD.INWARD_NO].Value = list[r].Inward_no;
                row.Cells[INWARD.INWARD_DATE].Value = ConvertTO.Date2S(list[r].Inward_date);
                row.Cells[INWARD.PARTY_ID].Value = list[r].Party_id;
                row.Cells[INWARD.TOTAL_QTY].Value = list[r].Total_qty;
                row.Cells[INWARD.TOTAL_BUNDEL].Value = list[r].Total_bundel;
                row.Cells[INWARD.USER_ID].Value = list[r].User_id;

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
                listgrid.CurrentCell = listgrid[INWARD.PARTY_ID, listgrid.RowCount - 1];
            }
            listgrid.ResumeLayout(true);
        }

        #endregion[Load Data]


    }//cls
}//ns
