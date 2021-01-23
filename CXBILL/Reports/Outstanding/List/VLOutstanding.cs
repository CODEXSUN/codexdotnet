// Version : 2.1.0.0 dt : 04-12-2018
// Auto Generated
// last update : 07-12-2018 05:57:08 PM

using System.Windows.Forms;
using System.Collections.Generic;
using CXLIB;
using CXCORE;

namespace CXBILL
{
    public partial class LOutstanding 
    {
        #region[list Option] 

        public void ListRefresh()
        {
            List_Option(fAction);
        }

        private ListOption fAction = ListOption.sales;
        public void List_Option(ListOption pAction)
        {

           LoadData(COutstanding_exten.GetOutstanding(txt_party_id.Text));


        }

        #endregion[list Option] 

        #region[Load Data] 

        public void LoadData(List<Outstanding> list)
        {
            listgrid.RowCount = 0;
            totalgrid.RowCount = 1;

            listgrid.RowCount = list.Count;

            decimal opening = 0, grandtotal = 0, receipt = 0, qop = 0, qgrandtotal = 0, qreceipt = 0, sbalance = 0, qbalance = 0;
            decimal Total_opening = 0, Total_grandtotal = 0, Total_receipt = 0, Total_qop = 0, Total_qgrandtotal = 0, Total_qreceipt = 0, Total_sbalance = 0, Total_qbalance = 0;

            for (int r = 0; r < list.Count; r++)
            {
                DataGridViewRow row = listgrid.Rows[r];

                row.Cells[OUTSTANDING.OUTSTANDING_ID].Value = list[r].Outstanding_id;
                row.Cells[OUTSTANDING.PARTY_ID].Value = list[r].Party_id;
                row.Cells[OUTSTANDING.OPENING_BALANCE].Value = list[r].Opening_balance;
                row.Cells[OUTSTANDING.INVOICE_AMOUNT].Value = list[r].Invoice_amount;
                row.Cells[OUTSTANDING.RECEIPT_AMOUNT].Value = list[r].Receipt_amount;
                row.Cells[OUTSTANDING.QOP].Value = list[r].Qop;
                row.Cells[OUTSTANDING.QUOTATION_AMOUNT].Value = list[r].Quotation_amount;
                row.Cells[OUTSTANDING.QRECEIPT_AMOUNT].Value = list[r].Qreceipt_amount;

                opening = ConvertTO.Decimal(list[r].Opening_balance);
                grandtotal = ConvertTO.Decimal(list[r].Invoice_amount);
                receipt = ConvertTO.Decimal(list[r].Receipt_amount);
                qop = ConvertTO.Decimal(list[r].Qop);
                qgrandtotal = ConvertTO.Decimal(list[r].Quotation_amount);
                qreceipt = ConvertTO.Decimal(list[r].Qreceipt_amount);

                sbalance = (opening + grandtotal) - receipt;
                qbalance = (qop + qgrandtotal) - qreceipt;

                row.Cells["SBALANCE"].Value = sbalance;
                row.Cells["QBALANCE"].Value = qbalance;

                Total_opening = Total_opening + opening;
                Total_grandtotal = Total_grandtotal + grandtotal;
                Total_receipt = Total_receipt + receipt;
                Total_qop = Total_qop + qop;
                Total_qgrandtotal = Total_qgrandtotal + qgrandtotal;
                Total_qreceipt = Total_qreceipt + qreceipt;
                Total_sbalance = Total_sbalance + sbalance;
                Total_qbalance = Total_qbalance + qbalance;
            }

            totalgrid.Rows[0].Cells[OUTSTANDING.PARTY_ID].Value = "TOTAL";
            totalgrid.Rows[0].Cells[OUTSTANDING.OPENING_BALANCE].Value = Total_opening;
            totalgrid.Rows[0].Cells[OUTSTANDING.INVOICE_AMOUNT].Value = Total_grandtotal;
            totalgrid.Rows[0].Cells[OUTSTANDING.RECEIPT_AMOUNT].Value = Total_receipt;
            totalgrid.Rows[0].Cells[OUTSTANDING.QOP].Value = Total_qop;
            totalgrid.Rows[0].Cells[OUTSTANDING.QUOTATION_AMOUNT].Value = Total_qgrandtotal;
            totalgrid.Rows[0].Cells[OUTSTANDING.QRECEIPT_AMOUNT].Value = Total_qreceipt;

            totalgrid.Rows[0].Cells["SBALANCE"].Value = Total_sbalance;
            totalgrid.Rows[0].Cells["QBALANCE"].Value = Total_qbalance;
        }

        #endregion[Load Data] 

    }//cls 
}//ns 
