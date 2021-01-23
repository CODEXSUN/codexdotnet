// Version : 2.1.0.0 dt : 04-12-2018
// Auto Generated
// last update : 07-12-2018 05:57:08 PM

using System;
using System.Drawing;
using System.Windows.Forms;
using CXCORE;
using CXLIB;

namespace CXBILL
{
    public partial class LOutstanding 
    {

        #region[Init Grid]

        private void InitGrid()
        {
            listgrid.RowAction += Listgrid_RowAction;
            //totalgrid.RowAction += total_RowAction;

            DataGridViewTextBoxColumn col_Outstanding_Id = new DataGridViewTextBoxColumn();
            col_Outstanding_Id.Name = OUTSTANDING.OUTSTANDING_ID;
            col_Outstanding_Id.HeaderText = "OUTSTANDING_ID ";
            col_Outstanding_Id.Visible = false;
            col_Outstanding_Id.Width = 100;
            col_Outstanding_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Outstanding_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Outstanding_Id);

            DataGridViewTextBoxColumn col_Party_id = new DataGridViewTextBoxColumn();
            col_Party_id.Name = OUTSTANDING.PARTY_ID;
            col_Party_id.HeaderText = "PARTY";
            //col_Party_id.Visible = false; 
            col_Party_id.Width =300;
            col_Party_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Party_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Party_id);

            DataGridViewTextBoxColumn col_Opening = new DataGridViewTextBoxColumn();
            col_Opening.Name = OUTSTANDING.OPENING_BALANCE;
            col_Opening.HeaderText = "OPENING";
            col_Opening.Visible = false;
            col_Opening.Width = 200;
            col_Opening.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Opening.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Opening);

            DataGridViewTextBoxColumn col_Sales = new DataGridViewTextBoxColumn();
            col_Sales.Name = OUTSTANDING.INVOICE_AMOUNT;
            col_Sales.HeaderText = "SALES";
            col_Sales.Visible = false;
            col_Sales.Width = 200;
            col_Sales.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Sales.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Sales);

            DataGridViewTextBoxColumn col_Receipt = new DataGridViewTextBoxColumn();
            col_Receipt.Name = OUTSTANDING.RECEIPT_AMOUNT;
            col_Receipt.HeaderText = "RECEIPT";
            col_Receipt.Visible = false;
            col_Receipt.Width = 200;
            col_Receipt.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Receipt.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Receipt);

            DataGridViewTextBoxColumn col_Sbalance = new DataGridViewTextBoxColumn();
            col_Sbalance.Name = "SBALANCE";
            col_Sbalance.HeaderText = "BALANCE";
            col_Sbalance.Visible = false;
            col_Sbalance.Width = 200;
            col_Sbalance.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Sbalance.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Sbalance);

            DataGridViewTextBoxColumn col_Qop = new DataGridViewTextBoxColumn();
            col_Qop.Name = OUTSTANDING.QOP;
            col_Qop.HeaderText = "QOP";
            col_Qop.Visible = false;
            col_Qop.Width = 200;
            col_Qop.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Qop.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Qop);

            DataGridViewTextBoxColumn col_Quotation = new DataGridViewTextBoxColumn();
            col_Quotation.Name = OUTSTANDING.QUOTATION_AMOUNT;
            col_Quotation.HeaderText = "QUOTATION";
            col_Quotation.Visible = false;
            col_Quotation.Width = 200;
            col_Quotation.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Quotation.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Quotation);

            DataGridViewTextBoxColumn col_Qreceipt = new DataGridViewTextBoxColumn();
            col_Qreceipt.Name = OUTSTANDING.QRECEIPT_AMOUNT;
            col_Qreceipt.HeaderText = "QRECEIPT";
            col_Qreceipt.Visible = false;
            col_Qreceipt.Width = 200;
            col_Qreceipt.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Qreceipt.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Qreceipt);

            DataGridViewTextBoxColumn col_Qbalance = new DataGridViewTextBoxColumn();
            col_Qbalance.Name = "QBALANCE";
            col_Qbalance.HeaderText = "BALANCE";
            col_Qbalance.Visible = false;
            col_Qbalance.Width = 200;
            col_Qbalance.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Qbalance.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Qbalance);

            DataGridViewTextBoxColumn colFiller = new DataGridViewTextBoxColumn();
            colFiller.Name = "FILLER";
            colFiller.HeaderText = "";
            colFiller.ReadOnly = true;
            colFiller.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            colFiller.SortMode = DataGridViewColumnSortMode.NotSortable;
            colFiller.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            listgrid.Columns.Add(colFiller);
        }

        #endregion[Init Grid]

        #region[Init Grid]

        private void InitTotalGrid()
        {
            DataGridViewTextBoxColumn col_Outstanding_Id1 = new DataGridViewTextBoxColumn();
            col_Outstanding_Id1.Name = OUTSTANDING.OUTSTANDING_ID;
            col_Outstanding_Id1.HeaderText = "OUTSTANDING_ID ";
            col_Outstanding_Id1.Visible = false;
            col_Outstanding_Id1.Width = 100;
            col_Outstanding_Id1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Outstanding_Id1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            totalgrid.Columns.Add(col_Outstanding_Id1);

            DataGridViewTextBoxColumn col_Party_id1 = new DataGridViewTextBoxColumn();
            col_Party_id1.Name = OUTSTANDING.PARTY_ID;
            col_Party_id1.HeaderText = "PARTY";
            //col_Party_id1.Visible = false; 
            col_Party_id1.Width = 300;
            col_Party_id1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Party_id1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            totalgrid.Columns.Add(col_Party_id1);

            DataGridViewTextBoxColumn col_Opening1 = new DataGridViewTextBoxColumn();
            col_Opening1.Name = OUTSTANDING.OPENING_BALANCE;
            col_Opening1.HeaderText = "OPENING";
            col_Opening1.Visible = false;
            col_Opening1.Width = 200;
            col_Opening1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Opening1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            totalgrid.Columns.Add(col_Opening1);

            DataGridViewTextBoxColumn col_Sales1 = new DataGridViewTextBoxColumn();
            col_Sales1.Name = OUTSTANDING.INVOICE_AMOUNT;
            col_Sales1.HeaderText = "SALES";
            col_Sales1.Visible = false;
            col_Sales1.Width = 200;
            col_Sales1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Sales1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            totalgrid.Columns.Add(col_Sales1);

            DataGridViewTextBoxColumn col_Receipt1 = new DataGridViewTextBoxColumn();
            col_Receipt1.Name = OUTSTANDING.RECEIPT_AMOUNT;
            col_Receipt1.HeaderText = "RECEIPT";
            col_Receipt1.Visible = false;
            col_Receipt1.Width = 200;
            col_Receipt1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Receipt1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            totalgrid.Columns.Add(col_Receipt1);

            DataGridViewTextBoxColumn col_Sbalance1 = new DataGridViewTextBoxColumn();
            col_Sbalance1.Name = "SBALANCE";
            col_Sbalance1.HeaderText = "BALANCE";
            col_Sbalance1.Visible = false;
            col_Sbalance1.Width = 200;
            col_Sbalance1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Sbalance1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            totalgrid.Columns.Add(col_Sbalance1);

            DataGridViewTextBoxColumn col_Qop1 = new DataGridViewTextBoxColumn();
            col_Qop1.Name = OUTSTANDING.QOP;
            col_Qop1.HeaderText = "QOP";
            col_Qop1.Visible = false;
            col_Qop1.Width = 200;
            col_Qop1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Qop1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            totalgrid.Columns.Add(col_Qop1);

            DataGridViewTextBoxColumn col_Quotation1 = new DataGridViewTextBoxColumn();
            col_Quotation1.Name = OUTSTANDING.QUOTATION_AMOUNT;
            col_Quotation1.HeaderText = "QUOTATION";
            col_Quotation1.Visible = false;
            col_Quotation1.Width = 200;
            col_Quotation1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Quotation1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            totalgrid.Columns.Add(col_Quotation1);

            DataGridViewTextBoxColumn col_Qreceipt1 = new DataGridViewTextBoxColumn();
            col_Qreceipt1.Name = OUTSTANDING.QRECEIPT_AMOUNT;
            col_Qreceipt1.HeaderText = "QRECEIPT";
            col_Qreceipt1.Visible = false;
            col_Qreceipt1.Width = 200;
            col_Qreceipt1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Qreceipt1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            totalgrid.Columns.Add(col_Qreceipt1);

            DataGridViewTextBoxColumn col_Qbalance1 = new DataGridViewTextBoxColumn();
            col_Qbalance1.Name = "QBALANCE";
            col_Qbalance1.HeaderText = "BALANCE";
            col_Qbalance1.Visible = false;
            col_Qbalance1.Width = 200;
            col_Qbalance1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Qbalance1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            totalgrid.Columns.Add(col_Qbalance1);

            DataGridViewTextBoxColumn colFiller = new DataGridViewTextBoxColumn();
            colFiller.Name = "FILLER";
            colFiller.HeaderText = "";
            colFiller.ReadOnly = true;
            colFiller.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            colFiller.SortMode = DataGridViewColumnSortMode.NotSortable;
            colFiller.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            totalgrid.Columns.Add(colFiller);
        }

        #endregion[Init Grid]

        private void SetOutstanding()
        {

            if (rdo_sales.Checked == true)
            {
                listgrid.Columns[OUTSTANDING.OPENING_BALANCE].Visible = true;
                listgrid.Columns[OUTSTANDING.INVOICE_AMOUNT].Visible = true;
                listgrid.Columns[OUTSTANDING.RECEIPT_AMOUNT].Visible = true;
                listgrid.Columns["SBALANCE"].Visible = true;

                listgrid.Columns[OUTSTANDING.QOP].Visible = false;
                listgrid.Columns[OUTSTANDING.QUOTATION_AMOUNT].Visible = false;
                listgrid.Columns[OUTSTANDING.QRECEIPT_AMOUNT].Visible = false;
                listgrid.Columns["QBALANCE"].Visible = false;

                totalgrid.Columns[OUTSTANDING.OPENING_BALANCE].Visible = true;
                totalgrid.Columns[OUTSTANDING.INVOICE_AMOUNT].Visible = true;
                totalgrid.Columns[OUTSTANDING.RECEIPT_AMOUNT].Visible = true;
                totalgrid.Columns["SBALANCE"].Visible = true;

                totalgrid.Columns[OUTSTANDING.QOP].Visible = false;
                totalgrid.Columns[OUTSTANDING.QUOTATION_AMOUNT].Visible = false;
                totalgrid.Columns[OUTSTANDING.QRECEIPT_AMOUNT].Visible = false;
                totalgrid.Columns["QBALANCE"].Visible = false;
            }

            if (rdo_Quotation.Checked == true)
            {

                listgrid.Columns[OUTSTANDING.OPENING_BALANCE].Visible = false;
                listgrid.Columns[OUTSTANDING.INVOICE_AMOUNT].Visible = false;
                listgrid.Columns[OUTSTANDING.RECEIPT_AMOUNT].Visible = false;
                listgrid.Columns["SBALANCE"].Visible = false;

                listgrid.Columns[OUTSTANDING.QOP].Visible = true;
                listgrid.Columns[OUTSTANDING.QUOTATION_AMOUNT].Visible = true;
                listgrid.Columns[OUTSTANDING.QRECEIPT_AMOUNT].Visible = true;
                listgrid.Columns["QBALANCE"].Visible = true;

                totalgrid.Columns[OUTSTANDING.OPENING_BALANCE].Visible = false;
                totalgrid.Columns[OUTSTANDING.INVOICE_AMOUNT].Visible = false;
                totalgrid.Columns[OUTSTANDING.RECEIPT_AMOUNT].Visible = false;
                totalgrid.Columns["SBALANCE"].Visible = false;

                totalgrid.Columns[OUTSTANDING.QOP].Visible = true;
                totalgrid.Columns[OUTSTANDING.QUOTATION_AMOUNT].Visible = true;
                totalgrid.Columns[OUTSTANDING.QRECEIPT_AMOUNT].Visible = true;
                totalgrid.Columns["QBALANCE"].Visible = true;

            }
        }

        #region[Grid Action]

        void Listgrid_RowAction(object sender, EventArgs e)
        {
            //if (listgrid.SelectedRow == null)
            //{
            //    return;
            //}
            //if (foutstanding == null)
            //{
            //    foutstanding = new FOutstanding();
            //}
            //BuildForm();
            //string pkValue = GetSelectedPkValue();
            //if (pkValue != null)
            //{
            //    foutstanding.SetAction(BtnEvent.Open, pkValue);
            //}
        }

        #endregion[Grid Action]

        #region[Enter Event]

        private void Txt_outstandingtype_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_party_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_party_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_party_id.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Change_infocus()
        {
            lbl_party_id.BackColor = Theme.lbl_BackColor;
            lbl_party_id.BorderColor = Theme.lbl_BorderColor;
            lbl_party_id.ForeColor = Theme.lbl_ForeColor;
        }

        #endregion[Enter Event]

        #region[Build Form]

        private void BuildForm()
        {
            //if (foutstanding == null)
            //{
            //    foutstanding = new FOutstanding();
            //}
            //foutstanding.FOutstanding_NeedToRefresh += VOutstanding_NeedToRefresh;
            //Parent.Controls.Add(foutstanding);
            //foutstanding.Dock = DockStyle.Fill;
            //foutstanding.Show();
            //foutstanding.BringToFront();

        }

        #endregion[Build Form]

        #region[Checkbox Event] 

        private void Rdo_sales_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_sales.Checked == true)
            {
                List_Option(ListOption.sales);


            }
            SetOutstanding();
        }

        private void Rdo_Quotation_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Quotation.Checked == true)
            {
                List_Option(ListOption.quotation);


            }
            SetOutstanding();
        }

        #endregion[Checkbox Event] 

        #region[Btn Event] 

        private void Btn_reload_Click(object sender, EventArgs e)
        {
            txt_party_id.Text = "";
            List_Option(ListOption.reload);
        }

        private void Btn_new_Click(object sender, EventArgs e)
        {
            BuildForm();
            //foutstanding.SetAction(BtnEvent.New, null);
            //foutstanding.SetFocus();
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                //foutstanding.SetAction(BtnEvent.Print, pkValue);
                //foutstanding.SetFocus();
            }
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Hide();
            RaiseEvent_NeedToRefresh();
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            List_Option(ListOption.Search);
        }

        #endregion[Btn Event] 

        #region[lookup] 

        public void Outstanding_lookup()
        {
            txt_party_id.LookupColNames = new string[] { PARTY.PARTY_NAME };
            txt_party_id.LookupUpdate += Txt_outstanding_LookupUpdate;
            txt_party_id.AllowNewEntry = false;
        }
        void Txt_outstanding_LookupUpdate(object sender, EventArgs e)
        {
            txt_party_id.LookupList = CParty_exten.GetforLookup(new DAL());
        }

        #endregion[lookup] 

        #region[Get selected pk value]

        private string GetSelectedPkValue()
        {
            DataGridViewRow vSelRow = null;
            if (listgrid.SelectedRows != null && listgrid.SelectedRows.Count != 0)
            {
                vSelRow = listgrid.SelectedRows[0];
            }

            string selPkValue = null;
            if (vSelRow != null)
            {
                selPkValue = vSelRow.Cells[OUTSTANDING.OUTSTANDING_ID].Value.ToString();
            }
            return selPkValue;
        }

        #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VOutstanding_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.sales);
        }
        //public event EventHandler LOutstanding_NeedToRefresh;
        //public void RaiseEvent_NeedToRefresh()
        //{
        //    LOutstanding_NeedToRefresh?.Invoke(this, new EventArgs());
        //}

        #endregion[RaiseEvent]

    }//cls
}//ns
