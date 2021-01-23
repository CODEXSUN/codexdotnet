// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// 13-03-2018 10:59:15 AM
// last update : 13-03-2018

using System.Windows.Forms;
using System.Collections.Generic;
using CXLIB;

namespace CXBILL
{
    public partial class LQreceipt 
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
                        LoadData(CQreceipt_exten.Showall(new DAL()));
                    }
                    else
                    {
                        LoadData(CQreceipt_exten.Unrefer(new DAL()));
                    }

                    break;

                case ListOption.notactive:

                    if (rdo_notactive.Checked == true)
                    {
                        LoadData(CQreceipt_exten.Notactive(new DAL()));
                    }
                    else
                    {
                        LoadData(CQreceipt_exten.Unrefer(new DAL()));
                    }

                    break;

                case ListOption.Search:
                    LoadData(CQreceipt_exten.Searchby(txt_no.Text, txt_date.Text, txt_party.Text, new DAL()));
                    break;

                default:
                    LoadData(CQreceipt_exten.Showall(new DAL()));
                    break;
            }
        }

        #endregion[list Option]

        #region[Load Data]

        public void LoadData(List<QReceipt> list)
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

                row.Cells[QRECEIPT.QRECEIPT_ID].Value = list[r].Qreceipt_id;
                row.Cells[QRECEIPT.QRECEIPT_NO].Value = list[r].Qreceipt_no;
                row.Cells[QRECEIPT.QRECEIPT_DATE].Value = ConvertTO.Date2S(list[r].Qreceipt_date);
                row.Cells[QRECEIPT.PARTY_ID].Value = list[r].Party_id;
                row.Cells[QRECEIPT.RECEIPTTYPE_ID].Value = list[r].Receipttype_id;
                row.Cells[QRECEIPT.CHEQ_NO].Value = list[r].Cheq_no;
                row.Cells[QRECEIPT.QRECEIPT_AMOUNT].Value = list[r].Qreceipt_amount;
                row.Cells[QRECEIPT.CHEQ_DATE].Value = list[r].Cheq_date;
                row.Cells[QRECEIPT.BANK_ID].Value = list[r].Bank_id;
                row.Cells[QRECEIPT.TOTAL_AMOUNT].Value = list[r].Total_amount;
                row.Cells[QRECEIPT.USER_ID].Value = list[r].User_id;

            }
            if (listgrid.RowCount != 0)
            {
                listgrid.CurrentCell = listgrid[QRECEIPT.PARTY_ID, listgrid.RowCount - 1];
            }
            listgrid.ResumeLayout(true);

        }

        #endregion[Load Data]


    }//cls
}//ns
