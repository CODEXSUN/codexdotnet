// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 15-06-2019 10:08:59 AM

using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using CXLIB;

namespace CXERP
{
    public partial class LStyle
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
                        LoadData(CStyle_exten.Refer());
                    }
                    else
                    {
                        LoadData(CStyle_exten.Unrefer());
                    }

                    break;

                case ListOption.showall:

                    if (rdo_showall.Checked == true)
                    {
                        LoadData(CStyle_exten.Showall());
                    }
                    else
                    {
                        LoadData(CStyle_exten.Unrefer());
                    }

                    break;

                case ListOption.notactive:

                    if (rdo_notactive.Checked == true)
                    {
                        LoadData(CStyle_exten.Notactive());
                    }
                    else
                    {
                        LoadData(CStyle_exten.Unrefer());
                    }

                    break;

                case ListOption.Search:
                    LoadData(CStyle_exten.Searchby(txt_no.Text, txt_date.Text, txt_Todate.Text, ""));
                    break;

                default:
                    LoadData(CStyle_exten.Unrefer());
                    break;
            }
        }

        #endregion[list Option]

        #region[Load Data]

        public void LoadData(List<Style> list)
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

                row.Cells[STYLE.STYLE_ID].Value = list[r].Style_id;
                row.Cells[STYLE.STYLE_NO].Value = list[r].Style_no;
                row.Cells[STYLE.STYLE_NAME].Value = list[r].Style_name;
                row.Cells[STYLE.LOCKED].Value = list[r].Locked;
                row.Cells[STYLE.USER_ID].Value = list[r].User_id;

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


                if (listgrid.RowCount != 0)
                {
                    listgrid.CurrentCell = listgrid[STYLE.STYLE_NO, listgrid.RowCount - 1];
                }
            }
            listgrid.Refresh();
            listgrid.ResumeLayout(true);
        }

        #endregion[Load Data]


    }//cls
}//ns
