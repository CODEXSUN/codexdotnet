// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// 13-03-2018 10:59:15 AM
// last update : 13-03-2018

using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using CXLIB;

namespace CXBILL
{
    public partial class LOffset_receipt 
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
                //case ListOption.refer:

                //    if (rdo_refer.Checked == true)
                //    {
                //        LoadData(CReceipt_exten.Refer(new DAL()));
                //    }
                //    else
                //    {
                //        LoadData(CReceipt_exten.Unrefer(new DAL()));
                //    }

                //    break;

                case ListOption.showall:

                    if (rdo_showall.Checked == true)
                    {
                        LoadData(COffset_receipt_exten.Showall(new DAL()));
                    }
                    else
                    {
                        LoadData(COffset_receipt_exten.Unrefer(new DAL()));
                    }

                    break;

                case ListOption.notactive:

                    if (rdo_notactive.Checked == true)
                    {
                        LoadData(COffset_receipt_exten.Notactive(new DAL()));
                    }
                    else
                    {
                        LoadData(COffset_receipt_exten.Unrefer(new DAL()));
                    }

                    break;

                case ListOption.Search:
                    LoadData(COffset_receipt_exten.Searchby(txt_no.Text, txt_date.Text, txt_party.Text, new DAL()));
                    break;

                default:
                    LoadData(COffset_receipt_exten.Unrefer(new DAL()));
                    break;
            }
        }

        #endregion[list Option]

        #region[Load Data]

        public void LoadData(List<Offset_receipt> list)
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

                row.Cells[OFFSET_RECEIPT.OFFSET_RECEIPT_ID].Value = list[r].Offset_receipt_id;
                row.Cells[OFFSET_RECEIPT.OFFSET_RECEIPT_NO].Value = list[r].Offset_receipt_no;
                row.Cells[OFFSET_RECEIPT.OFFSET_RECEIPT_DATE].Value = ConvertTO.Date2S(list[r].Offset_receipt_date);
                row.Cells[OFFSET_RECEIPT.PARTY_ID].Value = list[r].Party_id;
                row.Cells[OFFSET_RECEIPT.RECEIPTTYPE_ID].Value = list[r].Receipttype_id;
                row.Cells[OFFSET_RECEIPT.CHEQ_NO].Value = list[r].Cheq_no;
                row.Cells[OFFSET_RECEIPT.OFFSET_RECEIPT_AMOUNT].Value = list[r].Receipt_amount;
                row.Cells[OFFSET_RECEIPT.CHEQ_DATE].Value = list[r].Cheq_date;
                row.Cells[OFFSET_RECEIPT.BANK_ID].Value = list[r].Bank_id;
                row.Cells[OFFSET_RECEIPT.TOTAL_AMOUNT].Value = list[r].Total_amount;
                row.Cells[OFFSET_RECEIPT.USER_ID].Value = list[r].User_id;

            }
            if (listgrid.RowCount != 0)
            {
                listgrid.CurrentCell = listgrid[OFFSET_RECEIPT.PARTY_ID, listgrid.RowCount - 1];
            }
            listgrid.ResumeLayout(true);

        }

        #endregion[Load Data]


    }//cls
}//ns
