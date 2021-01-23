// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// 13-03-2018 10:59:15 AM
// last update : 13-03-2018

using System.Windows.Forms;
using System.Collections.Generic;
using CXLIB;

namespace CXBILL
{
    public partial class LPayment 
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
                        LoadData(CPayment_exten.Showall(new DAL()));
                    }
                    else
                    {
                        LoadData(CPayment_exten.Unrefer(new DAL()));
                    }

                    break;

                case ListOption.notactive:

                    if (rdo_notactive.Checked == true)
                    {
                        LoadData(CPayment_exten.Notactive(new DAL()));
                    }
                    else
                    {
                        LoadData(CPayment_exten.Unrefer(new DAL()));
                    }

                    break;

                case ListOption.Search:
                    LoadData(CPayment_exten.Searchby(txt_no.Text, txt_date.Text, txt_party.Text, new DAL()));
                    break;

                default:
                    LoadData(CPayment_exten.Unrefer(new DAL()));
                    break;
            }
        }

        #endregion[list Option]

        #region[Load Data]

        public void LoadData(List<Payment> list)
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

                row.Cells[PAYMENT.PAYMENT_ID].Value = list[r].Payment_id;
                row.Cells[PAYMENT.PAYMENT_NO].Value = list[r].Payment_no;
                row.Cells[PAYMENT.PAYMENT_DATE].Value = ConvertTO.Date2S(list[r].Payment_date);
                row.Cells[PAYMENT.PARTY_ID].Value = list[r].Party_id;
                row.Cells[PAYMENT.RECEIPTTYPE_ID].Value = list[r].Receipttype_id;
                row.Cells[PAYMENT.CHEQUE_NO].Value = list[r].Cheque_no;
                row.Cells[PAYMENT.PAYMENT_AMOUNT].Value = list[r].Payment_amount;
                row.Cells[PAYMENT.CHEQUE_DATE].Value = list[r].Cheque_date;
                row.Cells[PAYMENT.BANK_ID].Value = list[r].Bank_id;
                //row.Cells[PAYMENT.TOTAL_AMOUNT].Value = list[r].Total_amount;
                row.Cells[PAYMENT.USER_ID].Value = list[r].User_id;

            }
            if (listgrid.RowCount != 0)
            {
                listgrid.CurrentCell = listgrid[PAYMENT.PARTY_ID, listgrid.RowCount - 1];
            }
            listgrid.ResumeLayout(true);

        }

        #endregion[Load Data]


    }//cls
}//ns
