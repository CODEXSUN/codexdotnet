// Version : 3.0.0.0 dt : 09-02-2020
// Auto Generated
// last update : 09-02-2020 09:02:20 PM

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CXLIB;
using CXCORE;
using Microsoft.Reporting.WinForms;

namespace CXBILL
{
    public partial class RSalesRegister : CxControl
    {
        public RSalesRegister()
        {
            InitializeComponent();
            InitGrid();
            Party_lookup();
            list_partystatement(action.showall);
        }
        
        #region[Grid]
        //
        private void InitGrid()
        {
            //Listgrid.RowAction += gridItems_RowAction;

            DataGridViewTextBoxColumn col_date = new DataGridViewTextBoxColumn();
            col_date.Name = SALESREGISTER.SDATE;
            col_date.HeaderText = "DATE";
            col_date.ValueType = typeof(DateTime);
            col_date.Width = 110;
            col_date.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_date.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid.Columns.Add(col_date);

            DataGridViewTextBoxColumn col_partyname = new DataGridViewTextBoxColumn();
            col_partyname.Name = SALESREGISTER.PARTYNAME;
            col_partyname.HeaderText = "PARTY";
            col_partyname.Width = 500;
            col_partyname.ValueType = typeof(int);
            col_partyname.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_partyname.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid.Columns.Add(col_partyname);

            DataGridViewTextBoxColumn col_no = new DataGridViewTextBoxColumn();
            col_no.Name = SALESREGISTER.VNO;
            col_no.HeaderText = "NO ";
            col_no.Width = 150;
            col_no.ValueType = typeof(int);
            col_no.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_no.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid.Columns.Add(col_no);

            DataGridViewTextBoxColumn col_type = new DataGridViewTextBoxColumn();
            col_type.Name = SALESREGISTER.STYPE;
            col_type.HeaderText = "TYPE";
            col_type.ReadOnly = true;
            col_type.Width = 110;
            col_type.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_type.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid.Columns.Add(col_type);

            DataGridViewTextBoxColumn col_invoice_amount = new DataGridViewTextBoxColumn();
            col_invoice_amount.Name = SALESREGISTER.SALES_AMOUNT;
            col_invoice_amount.HeaderText = "INVOICE AMOUNT";
            col_invoice_amount.ReadOnly = true;
            col_invoice_amount.Width = 200;
            col_invoice_amount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            col_invoice_amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid.Columns.Add(col_invoice_amount);

            DataGridViewTextBoxColumn col_gst_amount = new DataGridViewTextBoxColumn();
            col_gst_amount.Name = SALESREGISTER.GST_AMOUNT;
            col_gst_amount.HeaderText = "GST AMOUNT";
            col_gst_amount.ReadOnly = true;
            col_gst_amount.Width = 200;
            col_gst_amount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            col_gst_amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid.Columns.Add(col_gst_amount);
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
            //if ((Txt_party.Text != "") && (Txt_party.Text != null))
            //{
                FReportPreview frpt = new FReportPreview();

                LocalReport localReport = frpt.reportViewer1.LocalReport;

                //string voucher_type = string.Empty;

                ////if (radio_invoice.Checked == true)
                ////{
                //    voucher_type = Core.Invoice;
                ////}

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


                var Statement = RCSalesRegister.Register(Txt_party.Text, txt_from_date.Text, txt_to_date.Text);
                var v_company = CCompany_exten.PKId(Current.Company_id);

                localReport.ReportPath = Application.StartupPath + @"\PRINTS\SalesRegister.rdlc"; //(1)//
                localReport.DisplayName = "Sales Register";

                localReport.DataSources.Add(new ReportDataSource("SALESREGISTER_DS", Statement)); //(2)//
                localReport.DataSources.Add(new ReportDataSource("COMPANY_DS", new List<Company> { v_company })); //(2)//

                frpt.reportViewer1.ShowPrintButton = true;
                frpt.reportViewer1.RefreshReport();
                frpt.Show();

            //}
        }
        //
        private void Btn_close_Click(object sender, EventArgs e)
        {
            RaiseEvent_NeedToRefresh();
            Hide();
        }
        //
        #endregion[Btn event]
        
        #region[Need to refresh]

        private void From_Datepicker_ValueChanged(object sender, EventArgs e)
        {
            txt_from_date.Text = ConvertTO.Date2S(from_Datepicker.Value.ToString());
            list_partystatement(action.showall);
        }

        private void To_Datepicker_ValueChanged(object sender, EventArgs e)
        {
            txt_to_date.Text = ConvertTO.Date2S(to_Datepicker.Value.ToString());
            list_partystatement(action.showall);
        }
        
        #endregion[Need to refresh]
        
    }//cls 
}//ns 
