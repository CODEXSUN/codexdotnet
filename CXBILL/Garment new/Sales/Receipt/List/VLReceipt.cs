// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 14-07-2020 10:01:14 PM

using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using CXLIB;

namespace CXBILL
{
    public partial class LReceipt
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
                        LoadData(CReceipt_exten.Notactive());
                    }
                    else
                    {
                        LoadData(CReceipt_exten.Showall());
                    }

                    break;

                case ListOption.Search:
                    LoadData(CReceipt_exten.Searchby(txt_no.Text, txt_date.Text,  txt_Todate.Text, txt_party.Text ));
                    break;

                default:
                     LoadData(CReceipt_exten.Showall());
                    break;
            }
        }

        #endregion[list Option]

        #region[Load Data]

        public void LoadData(List<Receipt> list)
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

                row.Cells[RECEIPT.RECEIPT_ID].Value = list[r].Receipt_id;
                row.Cells[RECEIPT.RECEIPT_NO].Value = list[r].Receipt_no;
                row.Cells[RECEIPT.RECEIPT_DATE].Value = ConvertTO.Date2S(list[r].Receipt_date);
                row.Cells[RECEIPT.PARTY_ID].Value = list[r].Party_id;
                row.Cells[RECEIPT.RECEIPTTYPE_ID].Value = list[r].Receipttype_id;
                row.Cells[RECEIPT.CHEQ_NO].Value = list[r].Cheq_no;
                row.Cells[RECEIPT.RECEIPT_AMOUNT].Value = list[r].Receipt_amount;
                row.Cells[RECEIPT.CHEQ_DATE].Value = list[r].Cheq_date;
                row.Cells[RECEIPT.BANK_ID].Value = list[r].Bank_id;
                row.Cells[RECEIPT.TOTAL_AMOUNT].Value = list[r].Total_amount;
                row.Cells[RECEIPT.USER_ID].Value = list[r].User_id;

                //switch (list[r].Locked)
                //{
                //    case Core.Locked:
                //        row.Cells[GRID.CELL].Style.BackColor = Color.FromArgb(0, 152, 70);
                //        row.Cells[GRID.CELL].Style.ForeColor = Color.White;
                //        row.Cells[GRID.CELL].Value = Core.Txt_Locked;
                //        break;
                //    case Core.Partial:
                //        row.Cells[GRID.CELL].Style.BackColor = Color.FromArgb(255, 237, 0);
                //        row.Cells[GRID.CELL].Style.ForeColor = Color.FromArgb(0, 141, 210);
                //        row.Cells[GRID.CELL].Value = Core.Txt_Partial;

                //        break;
                //    default:
                //        row.Cells[GRID.CELL].Style.BackColor = Color.FromArgb(227, 30, 36);
                //        row.Cells[GRID.CELL].Style.ForeColor = Color.White;
                //        row.Cells[GRID.CELL].Value = Core.Txt_Unlocked;
                //        break;
                //}
            }
                listgrid.Refresh();
                if (listgrid.RowCount != 0)
                {
                    listgrid.CurrentCell = listgrid[RECEIPT.PARTY_ID, listgrid.RowCount - 1];
                }
                listgrid.ResumeLayout(true);
        }

        #endregion[Load Data]


    }//cls
}//ns
