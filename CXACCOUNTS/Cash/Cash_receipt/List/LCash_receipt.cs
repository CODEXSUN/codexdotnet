// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 09-08-2020 09:29:47 PM

using System; 
using System.Drawing; 
using System.Windows.Forms; 
using CXLIB; 
 
namespace CXACCOUNTS 
{ 
    public partial class LCash_receipt 
    { 

         #region[Init Grid]

         private void InitGrid()
         {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Cash_receipt_Id = new DataGridViewTextBoxColumn();
            col_Cash_receipt_Id.Name = CASH_RECEIPT.CASH_RECEIPT_ID;
            col_Cash_receipt_Id.HeaderText = "No";
            //col_Cash_receipt_Id.Visible = false; 
            col_Cash_receipt_Id.Width = 80;
            col_Cash_receipt_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Cash_receipt_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Cash_receipt_Id );

            DataGridViewTextBoxColumn col_Receipt_date = new DataGridViewTextBoxColumn();
            col_Receipt_date.Name = CASH_RECEIPT.RECEIPT_DATE;
            col_Receipt_date.HeaderText = "DATE";
            //col_Receipt_date.Visible = false; 
            col_Receipt_date.Width = 80;
            col_Receipt_date.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Receipt_date.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Receipt_date);

            DataGridViewTextBoxColumn col_Party_id = new DataGridViewTextBoxColumn();
            col_Party_id.Name = CASH_RECEIPT.PARTY_ID;
            col_Party_id.HeaderText = "Receipt From";
            //col_Party_id.Visible = false; 
            col_Party_id.Width = 350;
            col_Party_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Party_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Party_id);

            DataGridViewTextBoxColumn col_Purpose = new DataGridViewTextBoxColumn();
            col_Purpose.Name = CASH_RECEIPT.PURPOSE;
            col_Purpose.HeaderText = "PURPOSE";
            //col_Purpose.Visible = false; 
            col_Purpose.Width = 350;
            col_Purpose.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Purpose.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Purpose);

            DataGridViewTextBoxColumn col_Receipt_amount = new DataGridViewTextBoxColumn();
            col_Receipt_amount.Name = CASH_RECEIPT.RECEIPT_AMOUNT;
            col_Receipt_amount.HeaderText = "RECEIPT AMOUNT";
            //col_Receipt_amount.Visible = false; 
            col_Receipt_amount.Width = 212;
            col_Receipt_amount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Receipt_amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Receipt_amount);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = CASH_RECEIPT.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false; 
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes );

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = CASH_RECEIPT.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false; 
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id );

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = CASH_RECEIPT.USER_ID;
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
             if (fcash_receipt == null)
             {
                 fcash_receipt = new FCash_receipt();
             }
             BuildForm();
             string pkValue = GetSelectedPkValue();
             if (pkValue != null)
             {
                 fcash_receipt.SetAction(BtnEvent.Open, pkValue);
             }
         }

         #endregion[Grid Action]

         #region[Enter Event]

         private void Txt_cash_receipttype_Enter(object sender, EventArgs e)
         {
             Change_infocus();
             lbl_receipt_date.BackColor = Theme.lbl_EnterBackColor;
             lbl_receipt_date.BorderColor = Theme.lbl_EnterBorderColor;
             lbl_receipt_date.ForeColor = Theme.lbl_EnterForeColor;
         }
         private void Change_infocus()
         {
             lbl_receipt_date.BackColor = Theme.lbl_BackColor;
             lbl_receipt_date.BorderColor = Theme.lbl_BorderColor;
             lbl_receipt_date.ForeColor = Theme.lbl_ForeColor;
         }

         #endregion[Enter Event]

         #region[Build Form]

         private void BuildForm()
         {
             if (fcash_receipt == null)
             {
                 fcash_receipt = new FCash_receipt();
             }
             fcash_receipt.FCash_receipt_NeedToRefresh += VCash_receipt_NeedToRefresh;
             Parent.Controls.Add(fcash_receipt);
             fcash_receipt.Dock = DockStyle.Fill;
             fcash_receipt.Show();
             fcash_receipt.BringToFront();
             
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
                fcash_receipt.SetAction(BtnEvent.New, null); 
                fcash_receipt.SetFocus(); 
        } 

        private void Btn_edit_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fcash_receipt.SetAction(BtnEvent.Edit, pkValue); 
                fcash_receipt.SetFocus(); 
            } 
        } 

        private void Btn_delete_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fcash_receipt.SetAction(BtnEvent.Delete, pkValue); 
                fcash_receipt.SetFocus(); 
            } 
        } 

        private void Btn_print_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fcash_receipt.SetAction(BtnEvent.Print, pkValue); 
                fcash_receipt.SetFocus(); 
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

         public void receipt_date_lookup()
         {
             txt_receipt_date.LookupColNames = new string[] { CASH_RECEIPT.RECEIPT_DATE };
            txt_receipt_date.LookupUpdate += txt_cash_receipt_LookupUpdate;
            txt_receipt_date.AllowNewEntry = true;
            txt_receipt_date.NewEntryNeeded += txt_cash_receipt_NewEntryNeeded;
         }
         void txt_cash_receipt_LookupUpdate(object sender, EventArgs e)
         {
            txt_receipt_date.LookupList = CCash_receipt_exten.GetforLookup();
         }
         private FCash_receipt fscash_receipt = null;
         void txt_cash_receipt_NewEntryNeeded(object sender, string pValue)
         {
             if (fscash_receipt == null)
             {
                 fscash_receipt = new FCash_receipt();
             }
             Parent.Controls.Add(fscash_receipt);
             fscash_receipt.Dock = DockStyle.Fill;
             fscash_receipt.Show();
             fscash_receipt.BringToFront();
             fscash_receipt.Focus();
             
             fscash_receipt.SetAction(BtnEvent.New, null);
             fscash_receipt.SetFocus();
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
                 selPkValue = vSelRow.Cells[CASH_RECEIPT.CASH_RECEIPT_ID].Value.ToString();
             }
             return selPkValue;
         }

         #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VCash_receipt_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }


        #endregion[RaiseEvent]

}//cls
}//ns
