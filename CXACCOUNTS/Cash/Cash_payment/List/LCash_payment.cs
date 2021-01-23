// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 10-08-2020 06:41:07 AM

using System; 
using System.Drawing; 
using System.Windows.Forms; 
using CXLIB; 
 
namespace CXACCOUNTS 
{ 
    public partial class LCash_payment 
    { 

         #region[Init Grid]

         private void InitGrid()
         {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Cash_payment_Id = new DataGridViewTextBoxColumn();
            col_Cash_payment_Id.Name = CASH_PAYMENT.CASH_PAYMENT_ID;
            col_Cash_payment_Id.HeaderText = "No";
            //col_Cash_payment_Id.Visible = false; 
            col_Cash_payment_Id.Width = 120;
            col_Cash_payment_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Cash_payment_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Cash_payment_Id );

            DataGridViewTextBoxColumn col_Order_id = new DataGridViewTextBoxColumn();
            col_Order_id.Name = CASH_PAYMENT.ORDER_ID;
            col_Order_id.HeaderText = "ORDER Ref";
            //col_Order_id.Visible = false; 
            col_Order_id.Width = 150;
            col_Order_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Order_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Order_id);

            DataGridViewTextBoxColumn col_Payment_date = new DataGridViewTextBoxColumn();
            col_Payment_date.Name = CASH_PAYMENT.PAYMENT_DATE;
            col_Payment_date.HeaderText = "DATE";
            //col_Payment_date.Visible = false; 
            col_Payment_date.Width = 100;
            col_Payment_date.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Payment_date.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Payment_date);

            DataGridViewTextBoxColumn col_Ledger_id = new DataGridViewTextBoxColumn();
            col_Ledger_id.Name = CASH_PAYMENT.LEDGER_ID;
            col_Ledger_id.HeaderText = " TO LEDGER";
            //col_Ledger_id.Visible = false; 
            col_Ledger_id.Width = 150;
            col_Ledger_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Ledger_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Ledger_id);

            DataGridViewTextBoxColumn col_Purpose = new DataGridViewTextBoxColumn();
            col_Purpose.Name = CASH_PAYMENT.PURPOSE;
            col_Purpose.HeaderText = "PURPOSE";
            //col_Purpose.Visible = false; 
            col_Purpose.Width = 350;
            col_Purpose.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Purpose.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Purpose);

            DataGridViewTextBoxColumn col_Party_id = new DataGridViewTextBoxColumn();
            col_Party_id.Name = CASH_PAYMENT.PARTY_ID;
            col_Party_id.HeaderText = "PAID TO";
            //col_Party_id.Visible = false; 
            col_Party_id.Width = 350;
            col_Party_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Party_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Party_id);

            DataGridViewTextBoxColumn col_Payment_amount = new DataGridViewTextBoxColumn();
            col_Payment_amount.Name = CASH_PAYMENT.PAYMENT_AMOUNT;
            col_Payment_amount.HeaderText = "PAID AMOUNT";
            //col_Payment_amount.Visible = false; 
            col_Payment_amount.Width = 160;
            col_Payment_amount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Payment_amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Payment_amount);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = CASH_PAYMENT.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false; 
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes );

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = CASH_PAYMENT.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false; 
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id );

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = CASH_PAYMENT.USER_ID;
            col_User_Id.HeaderText = "ENTRY BY";
            //col_User_Id.Visible = false; 
            col_User_Id.Width = 120;
            col_User_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_User_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_User_Id );

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

         #region[Grid Action]

         void Listgrid_RowAction(object sender, EventArgs e)
         {
             if (listgrid.SelectedRow == null)
             {
                 return;
             }
             if (fcash_payment == null)
             {
                 fcash_payment = new FCash_payment();
             }
             BuildForm();
             string pkValue = GetSelectedPkValue();
             if (pkValue != null)
             {
                 fcash_payment.SetAction(BtnEvent.Open, pkValue);
             }
         }

         #endregion[Grid Action]

         #region[Enter Event]

         private void Txt_order_ref_Enter(object sender, EventArgs e)
         {
             Change_infocus();
             lbl_order_ref.BackColor = Theme.lbl_EnterBackColor;
             lbl_order_ref.BorderColor = Theme.lbl_EnterBorderColor;
             lbl_order_ref.ForeColor = Theme.lbl_EnterForeColor;
         }

        private void Txt_payment_date_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_payment_date.BackColor = Theme.lbl_EnterBackColor;
            lbl_payment_date.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_payment_date.ForeColor = Theme.lbl_EnterForeColor;
        }

        private void Change_infocus()
         {
             lbl_order_ref.BackColor = Theme.lbl_BackColor;
             lbl_order_ref.BorderColor = Theme.lbl_BorderColor;
             lbl_order_ref.ForeColor = Theme.lbl_ForeColor;

            lbl_payment_date.BackColor = Theme.lbl_BackColor;
            lbl_payment_date.BorderColor = Theme.lbl_BorderColor;
            lbl_payment_date.ForeColor = Theme.lbl_ForeColor;
        }

         #endregion[Enter Event]

         #region[Build Form]

         private void BuildForm()
         {
             if (fcash_payment == null)
             {
                 fcash_payment = new FCash_payment();
             }
             fcash_payment.FCash_payment_NeedToRefresh += VCash_payment_NeedToRefresh;
             Parent.Controls.Add(fcash_payment);
             fcash_payment.Dock = DockStyle.Fill;
             fcash_payment.Show();
             fcash_payment.BringToFront();
             
         }

         #endregion[Build Form]

         #region[Checkbox Event] 

                private void Chk_notactive_CheckedChanged(object sender, EventArgs e) 
                { 
                    List_Option(ListOption.notactive); 
                } 

         #endregion[Checkbox Event] 

         #region[Btn Event] 

        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        private void Btn_new_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
                fcash_payment.SetAction(BtnEvent.New, null); 
                fcash_payment.SetFocus(); 
        } 

        private void Btn_edit_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fcash_payment.SetAction(BtnEvent.Edit, pkValue); 
                fcash_payment.SetFocus(); 
            } 
        } 

        private void Btn_delete_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fcash_payment.SetAction(BtnEvent.Delete, pkValue); 
                fcash_payment.SetFocus(); 
            } 
        } 

        private void Btn_print_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fcash_payment.SetAction(BtnEvent.Print, pkValue); 
                fcash_payment.SetFocus(); 
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

        #region[DatePicker]
        private void Txt_datePicker_TextChanged(object sender, EventArgs e)
        {
            txt_payment_date.Text = txt_datePicker.Text;
        }

        #endregion[DatePicker]

        #region[lookup] 

        public void Cash_payment_lookup()
         {
             txt_order_ref.LookupColNames = new string[] { CASH_PAYMENT.ORDER_ID };
            txt_order_ref.LookupUpdate += txt_cash_payment_LookupUpdate;
            txt_order_ref.AllowNewEntry = true;
            txt_order_ref.NewEntryNeeded += txt_cash_payment_NewEntryNeeded;
         }
         void txt_cash_payment_LookupUpdate(object sender, EventArgs e)
         {
            txt_order_ref.LookupList = CCash_payment_exten.GetforLookup();
         }
         private FCash_payment fscash_payment = null;
         void txt_cash_payment_NewEntryNeeded(object sender, string pValue)
         {
             if (fscash_payment == null)
             {
                 fscash_payment = new FCash_payment();
             }
             Parent.Controls.Add(fscash_payment);
             fscash_payment.Dock = DockStyle.Fill;
             fscash_payment.Show();
             fscash_payment.BringToFront();
             fscash_payment.Focus();
             
             fscash_payment.SetAction(BtnEvent.New, null);
             fscash_payment.SetFocus();
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
                 selPkValue = vSelRow.Cells[CASH_PAYMENT.CASH_PAYMENT_ID].Value.ToString();
             }
             return selPkValue;
         }

         #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VCash_payment_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }


        #endregion[RaiseEvent]

}//cls
}//ns
