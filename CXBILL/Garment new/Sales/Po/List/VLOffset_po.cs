// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 11:17:05 PM

using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using CXLIB;

namespace CXBILL
{
    public partial class LOffset_po
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
                        LoadData(COffset_po_exten.Refer(new DAL()));
                    }
                    else
                    {
                        LoadData(COffset_po_exten.Unrefer(new DAL()));
                    }

                    break;

                case ListOption.showall:

                    if (rdo_showall.Checked == true)
                    {
                        LoadData(COffset_po_exten.Showall(new DAL()));
                    }
                    else
                    {
                        LoadData(COffset_po_exten.Unrefer(new DAL()));
                    }

                    break;

                case ListOption.notactive:

                    if (rdo_notactive.Checked == true)
                    {
                        LoadData(COffset_po_exten.Notactive(new DAL()));
                    }
                    else
                    {
                        LoadData(COffset_po_exten.Unrefer(new DAL()));
                    }

                    break;

                case ListOption.Search:
                    LoadData(COffset_po_exten.Searchby(txt_no.Text, txt_date.Text, txt_party.Text, new DAL()));
                    break;

                default:
                    LoadData(COffset_po_exten.Unrefer(new DAL()));
                    break;
            }
        }

        #endregion[list Option]

        #region[Load Data]

        public void LoadData(List<Offset_po> list)
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

                row.Cells[OFFSET_PO.OFFSET_PO_ID].Value = list[r].Offset_po_id;
                row.Cells[OFFSET_PO.OFFSET_PO_NO].Value = list[r].Offset_po_no;
                row.Cells[OFFSET_PO.OFFSET_PO_DATE].Value = ConvertTO.Date2S(list[r].Offset_po_date);
                row.Cells[OFFSET_PO.PARTY_ID].Value = list[r].Party_id;
                row.Cells[OFFSET_PO.PARTY_PO_REF].Value = list[r].Party_po_ref;
                row.Cells[OFFSET_PO.DELIVERY_DATE].Value = ConvertTO.Date2S(list[r].Delivery_date);
                row.Cells[OFFSET_PO.TOTAL_QTY].Value = list[r].Total_qty;
                row.Cells[OFFSET_PO.TOTAL_AMOUNT].Value = list[r].Total_amount;
                row.Cells[OFFSET_PO.USER_ID].Value = list[r].User_id;

                switch (list[r].Locked)
                {
                    case Core.Locked:
                        row.Cells[GRID.CELL].Style.BackColor = Color.FromArgb(0, 152, 70);
                        row.Cells[GRID.CELL].Style.ForeColor = Color.White;
                        row.Cells[GRID.CELL].Value = "DELIVERED";
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
                    listgrid.CurrentCell = listgrid[OFFSET_PO.PARTY_ID, listgrid.RowCount - 1];
                }
            }
            listgrid.ResumeLayout(true);
        }

        #endregion[Load Data]


    }//cls
}//ns
