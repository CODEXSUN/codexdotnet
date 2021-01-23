// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 09-08-2020 09:29:38 PM

using System; 
using System.Drawing; 
using System.Windows.Forms; 
using CXLIB; 
 
namespace CXACCOUNTS 
{ 
    public partial class LCash_in_hand
    { 

         #region[Init Grid]

         private void InitGrid()
         {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Cash_in_hand_Id = new DataGridViewTextBoxColumn();
            col_Cash_in_hand_Id.Name = CASH_IN_HAND.CASH_IN_HAND_ID;
            col_Cash_in_hand_Id.HeaderText = "CASH_IN_HAND_ID ";
            col_Cash_in_hand_Id.Visible = false; 
            col_Cash_in_hand_Id.Width = 100;
            col_Cash_in_hand_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Cash_in_hand_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Cash_in_hand_Id );

            DataGridViewTextBoxColumn col_Entry_date = new DataGridViewTextBoxColumn();
            col_Entry_date.Name = CASH_IN_HAND.ENTRY_DATE;
            col_Entry_date.HeaderText = "ENTRY DATE";
            //col_Entry_date.Visible = false; 
            col_Entry_date.Width = 162;
            col_Entry_date.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Entry_date.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Entry_date);

            DataGridViewTextBoxColumn col_Cash_receipt_id = new DataGridViewTextBoxColumn();
            col_Cash_receipt_id.Name = CASH_IN_HAND.CASH_RECEIPT_ID;
            col_Cash_receipt_id.HeaderText = "CASH RECEIPT ID";
            //col_Cash_receipt_id.Visible = false; 
            col_Cash_receipt_id.Width = 225;
            col_Cash_receipt_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Cash_receipt_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Cash_receipt_id);

            DataGridViewTextBoxColumn col_Cash_payment_id = new DataGridViewTextBoxColumn();
            col_Cash_payment_id.Name = CASH_IN_HAND.CASH_PAYMENT_ID;
            col_Cash_payment_id.HeaderText = "CASH PAYMENT ID";
            //col_Cash_payment_id.Visible = false; 
            col_Cash_payment_id.Width = 225;
            col_Cash_payment_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Cash_payment_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Cash_payment_id);

            DataGridViewTextBoxColumn col_Receipt_amount = new DataGridViewTextBoxColumn();
            col_Receipt_amount.Name = CASH_IN_HAND.RECEIPT_AMOUNT;
            col_Receipt_amount.HeaderText = "RECEIPT AMOUNT";
            //col_Receipt_amount.Visible = false; 
            col_Receipt_amount.Width = 212;
            col_Receipt_amount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Receipt_amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Receipt_amount);

            DataGridViewTextBoxColumn col_Payment_amount = new DataGridViewTextBoxColumn();
            col_Payment_amount.Name = CASH_IN_HAND.PAYMENT_AMOUNT;
            col_Payment_amount.HeaderText = "PAYMENT AMOUNT";
            //col_Payment_amount.Visible = false; 
            col_Payment_amount.Width = 212;
            col_Payment_amount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Payment_amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Payment_amount);

            DataGridViewTextBoxColumn col_Balance_amount = new DataGridViewTextBoxColumn();
            col_Balance_amount.Name = CASH_IN_HAND.BALANCE_AMOUNT;
            col_Balance_amount.HeaderText = "BALANCE AMOUNT";
            //col_Balance_amount.Visible = false; 
            col_Balance_amount.Width = 212;
            col_Balance_amount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Balance_amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Balance_amount);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = CASH_IN_HAND.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false; 
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes );

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = CASH_IN_HAND.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false; 
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id );

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = CASH_IN_HAND.USER_ID;
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
             if (fcash_in_hand == null)
             {
                 fcash_in_hand = new FCash_in_hand();
             }
             BuildForm();
             string pkValue = GetSelectedPkValue();
             if (pkValue != null)
             {
                 fcash_in_hand.SetAction(BtnEvent.Open, pkValue);
             }
         }

         #endregion[Grid Action]

         #region[Enter Event]

         private void Txt_cash_in_handtype_Enter(object sender, EventArgs e)
         {
             Change_infocus();
             lbl_cash_in_hand_name.BackColor = Theme.lbl_EnterBackColor;
             lbl_cash_in_hand_name.BorderColor = Theme.lbl_EnterBorderColor;
             lbl_cash_in_hand_name.ForeColor = Theme.lbl_EnterForeColor;
         }
         private void Change_infocus()
         {
             lbl_cash_in_hand_name.BackColor = Theme.lbl_BackColor;
             lbl_cash_in_hand_name.BorderColor = Theme.lbl_BorderColor;
             lbl_cash_in_hand_name.ForeColor = Theme.lbl_ForeColor;
         }

         #endregion[Enter Event]

         #region[Build Form]

         private void BuildForm()
         {
             if (fcash_in_hand == null)
             {
                 fcash_in_hand = new FCash_in_hand();
             }
             fcash_in_hand.FCash_in_hand_NeedToRefresh += VCash_in_hand_NeedToRefresh;
             Parent.Controls.Add(fcash_in_hand);
             fcash_in_hand.Dock = DockStyle.Fill;
             fcash_in_hand.Show();
             fcash_in_hand.BringToFront();
             
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
                fcash_in_hand.SetAction(BtnEvent.New, null); 
                fcash_in_hand.SetFocus(); 
        } 

        private void Btn_edit_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fcash_in_hand.SetAction(BtnEvent.Edit, pkValue); 
                fcash_in_hand.SetFocus(); 
            } 
        } 

        private void Btn_delete_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fcash_in_hand.SetAction(BtnEvent.Delete, pkValue); 
                fcash_in_hand.SetFocus(); 
            } 
        } 

        private void Btn_print_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fcash_in_hand.SetAction(BtnEvent.Print, pkValue); 
                fcash_in_hand.SetFocus(); 
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

         public void Cash_in_hand_lookup()
         {
             txt_cash_in_hand_id .LookupColNames = new string[] { CASH_IN_HAND.ENTRY_DATE };
            txt_cash_in_hand_id.LookupUpdate += txt_cash_in_hand_LookupUpdate;
            txt_cash_in_hand_id.AllowNewEntry = true;
            txt_cash_in_hand_id.NewEntryNeeded += txt_cash_in_hand_NewEntryNeeded;
         }
         void txt_cash_in_hand_LookupUpdate(object sender, EventArgs e)
         {
            txt_cash_in_hand_id.LookupList = CCash_in_hand_exten.GetforLookup();
         }
         private FCash_in_hand fscash_in_hand = null;
         void txt_cash_in_hand_NewEntryNeeded(object sender, string pValue)
         {
             if (fscash_in_hand == null)
             {
                 fscash_in_hand = new FCash_in_hand();
             }
             Parent.Controls.Add(fscash_in_hand);
             fscash_in_hand.Dock = DockStyle.Fill;
             fscash_in_hand.Show();
             fscash_in_hand.BringToFront();
             fscash_in_hand.Focus();
             
             fscash_in_hand.SetAction(BtnEvent.New, null);
             fscash_in_hand.SetFocus();
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
                 selPkValue = vSelRow.Cells[CASH_IN_HAND.CASH_IN_HAND_ID].Value.ToString();
             }
             return selPkValue;
         }

         #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VCash_in_hand_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        #endregion[RaiseEvent]

}//cls
}//ns
