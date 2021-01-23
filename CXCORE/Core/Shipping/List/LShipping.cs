// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 13-07-2020 08:01:31 AM

using System; 
using System.Drawing; 
using System.Windows.Forms; 
using CXLIB; 
 
namespace CXCORE 
{ 
    public partial class LShipping : UserControl 
    { 

         #region[Init Grid]

         private void InitGrid()
         {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Shipping_Id = new DataGridViewTextBoxColumn();
            col_Shipping_Id.Name = SHIPPING.SHIPPING_ID;
            col_Shipping_Id.HeaderText = "SHIPPING_ID ";
            col_Shipping_Id.Visible = false; 
            col_Shipping_Id.Width = 100;
            col_Shipping_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Shipping_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Shipping_Id );

            DataGridViewTextBoxColumn col_Shipping_name = new DataGridViewTextBoxColumn();
            col_Shipping_name.Name = SHIPPING.SHIPPING_NAME;
            col_Shipping_name.HeaderText = "SHIPPING NAME";
            //col_Shipping_name.Visible = false; 
            col_Shipping_name.Width = 200;
            col_Shipping_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Shipping_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Shipping_name);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = SHIPPING.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false; 
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes );

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = SHIPPING.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false; 
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id );

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = SHIPPING.USER_ID;
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
             if (fshipping == null)
             {
                 fshipping = new FShipping();
             }
             BuildForm();
             string pkValue = GetSelectedPkValue();
             if (pkValue != null)
             {
                 fshipping.SetAction(BtnEvent.Open, pkValue);
             }
         }

         #endregion[Grid Action]

         #region[Enter Event]

         private void Txt_shippingtype_Enter(object sender, EventArgs e)
         {
             Change_infocus();
             lbl_shipping_name.BackColor = Theme.lbl_EnterBackColor;
             lbl_shipping_name.BorderColor = Theme.lbl_EnterBorderColor;
             lbl_shipping_name.ForeColor = Theme.lbl_EnterForeColor;
         }
         private void Change_infocus()
         {
             lbl_shipping_name.BackColor = Theme.lbl_BackColor;
             lbl_shipping_name.BorderColor = Theme.lbl_BorderColor;
             lbl_shipping_name.ForeColor = Theme.lbl_ForeColor;
         }

         #endregion[Enter Event]

         #region[Build Form]

         private void BuildForm()
         {
             if (fshipping == null)
             {
                 fshipping = new FShipping();
             }
             fshipping.FShipping_NeedToRefresh += VShipping_NeedToRefresh;
             Parent.Controls.Add(fshipping);
             fshipping.Dock = DockStyle.Fill;
             fshipping.Show();
             fshipping.BringToFront();
             
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
                fshipping.SetAction(BtnEvent.New, null); 
                fshipping.SetFocus(); 
        } 

        private void Btn_edit_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fshipping.SetAction(BtnEvent.Edit, pkValue); 
                fshipping.SetFocus(); 
            } 
        } 

        private void Btn_delete_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fshipping.SetAction(BtnEvent.Delete, pkValue); 
                fshipping.SetFocus(); 
            } 
        } 

        private void Btn_print_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fshipping.SetAction(BtnEvent.Print, pkValue); 
                fshipping.SetFocus(); 
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

         public void Shipping_lookup()
         {
             txt_shipping_name.LookupColNames = new string[] { SHIPPING.SHIPPING_NAME };
             txt_shipping_name.LookupUpdate += txt_shipping_LookupUpdate;
             txt_shipping_name.AllowNewEntry = true;
             txt_shipping_name.NewEntryNeeded += txt_shipping_NewEntryNeeded;
         }
         void txt_shipping_LookupUpdate(object sender, EventArgs e)
         {
             txt_shipping_name.LookupList = CShipping_exten.GetforLookup();
         }
         private FShipping fsshipping = null;
         void txt_shipping_NewEntryNeeded(object sender, string pValue)
         {
             if (fsshipping == null)
             {
                 fsshipping = new FShipping();
             }
             Parent.Controls.Add(fsshipping);
             fsshipping.Dock = DockStyle.Fill;
             fsshipping.Show();
             fsshipping.BringToFront();
             fsshipping.Focus();
             
             fsshipping.SetAction(BtnEvent.New, null);
             fsshipping.SetFocus();
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
                 selPkValue = vSelRow.Cells[SHIPPING.SHIPPING_ID].Value.ToString();
             }
             return selPkValue;
         }

         #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VShipping_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        public event EventHandler LShipping_NeedToRefresh;

        public void RaiseEvent_NeedToRefresh()
        {
            LShipping_NeedToRefresh?.Invoke(this, new EventArgs());
        }

        #endregion[RaiseEvent]

}//cls
}//ns
