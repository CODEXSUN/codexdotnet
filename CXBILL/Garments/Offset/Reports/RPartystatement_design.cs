// Version : 7.6 dt : 30-03-2017
// CODESK
// 24-01-2017 08:01:01 AM
// create date : 24-01-2017
// last update : 30-03-2017

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;
using CXCORE;
using Microsoft.Reporting.WinForms;

namespace CXBILL
{
    public partial class ROffset_1_party : CxControl
    {
        public ROffset_1_party()
        {
            InitializeComponent();
            InitGrid();
            //radio_showall.Checked = true;
            //
            Party_lookup();
        }
        //
        #region[Grid]
        //
        private void InitGrid()
        {
            //Listgrid.RowAction += gridItems_RowAction;
            //

            DataGridViewTextBoxColumn col_sno = new DataGridViewTextBoxColumn();
            col_sno.Name = STATEMENT.SNO;
            col_sno.HeaderText = "NO ";
            col_sno.Width = 100;
            col_sno.ValueType = typeof(int);
            col_sno.Visible = false;
            col_sno.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_sno.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid.Columns.Add(col_sno);

            DataGridViewTextBoxColumn col_date = new DataGridViewTextBoxColumn();
            col_date.Name = STATEMENT.SDATE;
            col_date.HeaderText = "DATE";
            col_date.ValueType = typeof(DateTime);
            col_date.ReadOnly = true;
            col_date.Width = 110;
            col_date.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_date.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid.Columns.Add(col_date);

            DataGridViewTextBoxColumn col_no = new DataGridViewTextBoxColumn();
            col_no.Name = STATEMENT.VNO;
            col_no.HeaderText = "NO ";
            col_no.Width = 100;
            col_no.ValueType = typeof(int);
            col_no.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_no.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid.Columns.Add(col_no);
            //  

            //  
            DataGridViewTextBoxColumn col_type = new DataGridViewTextBoxColumn();
            col_type.Name = STATEMENT.STYPE;
            col_type.HeaderText = "TYPE";
            col_type.ReadOnly = true;
            col_type.Width = 110;
            col_type.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_type.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid.Columns.Add(col_type);
            // 
            DataGridViewTextBoxColumn col_party = new DataGridViewTextBoxColumn();
            col_party.Name = STATEMENT.PARTY;
            col_party.HeaderText = "PARTY";
            col_party.ReadOnly = true;
            col_party.Width = 300;
            col_party.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_party.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Listgrid.Columns.Add(col_party);
            //  
            DataGridViewTextBoxColumn col_invoice_amount = new DataGridViewTextBoxColumn();
            col_invoice_amount.Name = STATEMENT.SALES_AMOUNT;
            col_invoice_amount.HeaderText = "INVOICE AMOUNT";
            col_invoice_amount.ReadOnly = true;
            col_invoice_amount.Width = 200;
            col_invoice_amount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            col_invoice_amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid.Columns.Add(col_invoice_amount);
            //  
            DataGridViewTextBoxColumn col_receipt_amount = new DataGridViewTextBoxColumn();
            col_receipt_amount.Name = STATEMENT.RECEIPT_AMOUNT;
            col_receipt_amount.HeaderText = "RECEIPT AMOUNT";
            col_receipt_amount.Width = 200;
            col_receipt_amount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            col_receipt_amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid.Columns.Add(col_receipt_amount);
            //  
            DataGridViewTextBoxColumn col_balance = new DataGridViewTextBoxColumn();
            col_balance.Name = STATEMENT.BALANCE_AMOUNT;
            col_balance.HeaderText = "BALANCE AMOUNT";
            col_balance.Width = 200;
            col_balance.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            col_balance.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid.Columns.Add(col_balance);
            // 
        }
        //
        //void gridItems_RowAction(object sender, EventArgs e)
        //{
        //    if (Listgrid.SelectedRow == null)
        //    {
        //        return;
        //    }
        //    if (finvoice == null)
        //    {
        //        finvoice = new fInvoice();
        //    }
        //    BuildInvoice();
        //    string pkValue = GetSelectedPkValue();
        //    if (pkValue != null)
        //    {
        //        finvoice.SetAction(action.Open, pkValue);
        //    }
        //}
        //
        #endregion[Grid]
        //
        #region[Radio Event]
        private void radio_salesinvoice_CheckedChanged(object sender, EventArgs e)
        {
            list_partystatement(action.invoice);
        }
        private void radio_labourbill_CheckedChanged(object sender, EventArgs e)
        {
            list_partystatement(action.labour_bill);
        }
        private void radio_showall_CheckedChanged(object sender, EventArgs e)
        {
            list_partystatement(action.showall);
        }
        private void radio_debitnote_CheckedChanged(object sender, EventArgs e)
        {
            list_partystatement(action.debit_note);
        }

        private void radio_receipt_CheckedChanged(object sender, EventArgs e)
        {
            list_partystatement(action.receipt);
        }
        //
        #endregion[Radio Event]
        //
        #region[Btn event]
        //
        private void Btn_search_Click(object sender, EventArgs e)
        {
            if ((Txt_party.Text != "") && (Txt_party.Text != null))
            {
                list_partystatement(action.showall);
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            if ((Txt_party.Text != "") && (Txt_party.Text != null))
            {
                FReportPreview frpt = new FReportPreview();

                LocalReport localReport = frpt.reportViewer1.LocalReport;

                string voucher_type = string.Empty;

                //if (radio_invoice.Checked == true)
                //{
                    voucher_type = Core.Invoice;
                //}

                //if (radio_labourbill.Checked == true)
                //{
                //    voucher_type = Core.Labour;
                //}
                //if (radio_receipt.Checked == true)
                //{
                //    voucher_type = Core.Receipt;
                //}
                //if (radio_debitnote.Checked == true)
                //{
                //    voucher_type = Core.Debitnote;
                //}


                var Statement = RcPartystatement.Statement(Txt_party.Text, txt_from_date.Text, txt_to_date.Text, voucher_type);
                var v_company = CCompany_exten.PKId(Current.Company_id);

                localReport.ReportPath = Application.StartupPath + @"\PRINTS\Statement.rdlc"; //(1)//
                localReport.DisplayName = "statement";

                localReport.DataSources.Add(new ReportDataSource("STATEMENT_DS", Statement)); //(2)//
                localReport.DataSources.Add(new ReportDataSource("COMPANY_DS", new List<Company> { v_company })); //(2)//

                frpt.reportViewer1.ShowPrintButton = true;
                frpt.reportViewer1.RefreshReport();
                frpt.Show();

            }
        }
        //
        private void Btn_close_Click(object sender, EventArgs e)
        {
            RaiseEvent_NeedToRefresh();
            Hide();
        }
        //
        #endregion[Btn event]
        //
        #region[Need to refresh]
        //
        public void rSales_NeedToRefresh(object sender, EventArgs e)
        {
            list_partystatement(action.showall);
            //radio_showall.Checked = true;
        }
        //
        //public event EventHandler partystatement_NeedToRefresh;
        //public void RaiseEvent_NeedToRefresh()
        //{
        //    if (partystatement_NeedToRefresh != null)
        //    {
        //        partystatement_NeedToRefresh(this, new EventArgs());
        //    }
        //}

        private void from_Datepicker_ValueChanged(object sender, EventArgs e)
        {
            txt_from_date.Text = ConvertTO.Date2S(from_Datepicker.Value.ToString());
            //radio_showall.Checked = true;
            list_partystatement(action.showall);
        }

        private void to_Datepicker_ValueChanged(object sender, EventArgs e)
        {
            txt_to_date.Text = ConvertTO.Date2S(to_Datepicker.Value.ToString());
            //radio_showall.Checked = true;
            list_partystatement(action.showall);
        }


        //
        #endregion[Need to refresh]
        //
    }//cls 
}//ns 
