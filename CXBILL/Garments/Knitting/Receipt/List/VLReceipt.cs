// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// 13-03-2018 10:59:15 AM
// last update : 13-03-2018

using System.Windows.Forms;
using System.Collections.Generic;
using CXLIB;

namespace CXKNITTING
{
    public partial class LReceipt 
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
                        LoadData(CReceipt_exten.Showall(new DAL()));
                    }
                    else
                    {
                        LoadData(CReceipt_exten.Unrefer(new DAL()));
                    }

                    break;

                case ListOption.notactive:

                    if (rdo_notactive.Checked == true)
                    {
                        LoadData(CReceipt_exten.Notactive(new DAL()));
                    }
                    else
                    {
                        LoadData(CReceipt_exten.Unrefer(new DAL()));
                    }

                    break;

                case ListOption.Search:
                    LoadData(CReceipt_exten.Searchby(txt_no.Text, txt_date.Text, txt_party.Text, new DAL()));
                    break;

                default:
                    LoadData(CReceipt_exten.Unrefer(new DAL()));
                    break;
            }
        }

        #endregion[list Option]

        #region[Load Data]

        public void LoadData(List<Knitting_Receipt> list)
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

                row.Cells[KNITTING_RECEIPT.KNITTING_RECEIPT_ID].Value = list[r].Knitting_Receipt_id;
                row.Cells[KNITTING_RECEIPT.KNITTING_RECEIPT_NO].Value = list[r].Knitting_Receipt_no;
                row.Cells[KNITTING_RECEIPT.KNITTING_RECEIPT_DATE].Value = ConvertTO.Date2S(list[r].Knitting_Receipt_date);
                row.Cells[KNITTING_RECEIPT.PARTY_ID].Value = list[r].Party_id;
                row.Cells[KNITTING_RECEIPT.RECEIPTTYPE_ID].Value = list[r].Receipttype_id;
                row.Cells[KNITTING_RECEIPT.CHEQ_NO].Value = list[r].Cheq_no;
                row.Cells[KNITTING_RECEIPT.KNITTING_RECEIPT_AMOUNT].Value = list[r].Receipt_amount;
                row.Cells[KNITTING_RECEIPT.CHEQ_DATE].Value = list[r].Cheq_date;
                row.Cells[KNITTING_RECEIPT.BANK_ID].Value = list[r].Bank_id;
                row.Cells[KNITTING_RECEIPT.TOTAL_AMOUNT].Value = list[r].Total_amount;
                row.Cells[KNITTING_RECEIPT.USER_ID].Value = list[r].User_id;

            }
            if (listgrid.RowCount != 0)
            {
                listgrid.CurrentCell = listgrid[KNITTING_RECEIPT.PARTY_ID, listgrid.RowCount - 1];
            }
            listgrid.ResumeLayout(true);

        }

        #endregion[Load Data]


    }//cls
}//ns
