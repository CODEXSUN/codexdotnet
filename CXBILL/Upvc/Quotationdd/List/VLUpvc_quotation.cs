// Version : 3 dt : 01-08-2017
// Auto Generated
// 23-08-2017 10:05:48 AM
// last update : 23-08-2017

using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using CXLIB;

namespace CXUPVC
{
    public partial class LUpvc_quotation : UserControl
    {
        #region[list Option]

        public void ListRefresh()
        {
            List_Option(fAction);
        }

        private ListOption fAction = ListOption.unrefer;
        public void List_Option(ListOption pAction)
        {
            if (constructed_flag == false) { return; }

            fAction = pAction;

            switch (fAction)
            {
                case ListOption.refer:

                    if (rdo_refer.Checked == true)
                    {
                        LoadData(CUpvc_quotation_exten.Refer(new DAL()));
                    }
                    else
                    {
                        LoadData(CUpvc_quotation_exten.Unrefer(new DAL()));
                    }

                    break;

                case ListOption.showall:

                    if (rdo_showall.Checked == true)
                    {
                        LoadData(CUpvc_quotation_exten.Showall(new DAL()));
                    }
                    else
                    {
                        LoadData(CUpvc_quotation_exten.Unrefer(new DAL()));
                    }

                    break;

                case ListOption.notactive:

                    if (rdo_notactive.Checked == true)
                    {
                        LoadData(CUpvc_quotation_exten.Notactive(new DAL()));
                    }
                    else
                    {
                        LoadData(CUpvc_quotation_exten.Unrefer(new DAL()));
                    }

                    break;

                case ListOption.Search:
                    LoadData(CUpvc_quotation_exten.Searchby(txt_no.Text, txt_date.Text, txt_party.Text, new DAL()));
                    break;

                default:
                    LoadData(CUpvc_quotation_exten.Unrefer(new DAL()));
                    break;
            }
        }

        #endregion[list Option]

        #region[Load Data]

        public void LoadData(List<Upvc_quotation> list)
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

                row.Cells[UPVC_QUOTATION.UPVC_QUOTATION_ID].Value = list[r].Upvc_quotation_id;
                row.Cells[UPVC_QUOTATION.SALESTYPE].Value = list[r].Salestype;
                row.Cells[UPVC_QUOTATION.UPVC_SALESMODE_ID].Value = list[r].Upvc_salesmode_id;
                row.Cells[UPVC_QUOTATION.UPVC_QUOTATION_NO].Value = list[r].Upvc_quotation_no;
                row.Cells[UPVC_QUOTATION.UPVC_QUOTATION_DATE].Value = ConvertTO.Date2S(list[r].Upvc_quotation_date);
                row.Cells[UPVC_QUOTATION.PARTY_ID].Value = list[r].Party_id;
                //row.Cells[UPVC_QUOTATION.TRANSPORT_ID].Value = list[r].Transport_mode_id;
                //row.Cells[UPVC_QUOTATION.VEHICLE_NO].Value = list[r].Vehicle_no;
                row.Cells[UPVC_QUOTATION.TOTAL_QTY].Value = list[r].Total_qty;
                row.Cells[UPVC_QUOTATION.GSTTOTAL].Value = list[r].Gsttotal;
                row.Cells[UPVC_QUOTATION.LEDGER_ID].Value = list[r].Ledger_id;
                row.Cells[UPVC_QUOTATION.ADDITIONAL].Value = list[r].Additional;
                row.Cells[UPVC_QUOTATION.GRANDTOTAL].Value = list[r].Grandtotal;
                row.Cells[UPVC_QUOTATION.USER_ID].Value = list[r].User_id;

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
                listgrid.CurrentCell = listgrid[UPVC_QUOTATION.PARTY_ID, listgrid.RowCount - 1];
            }
            listgrid.ResumeLayout(true);
            listgrid.Refresh();
        }

        #endregion[Load Data]


    }//cls
}//ns
