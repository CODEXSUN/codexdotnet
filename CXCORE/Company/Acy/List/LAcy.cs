// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 07-08-2020 07:48:01 AM

using System; 
using System.Drawing; 
using System.Windows.Forms; 
using CXLIB; 
 
namespace CXCORE 
{ 
    public partial class LAcy : UserControl 
    { 

         #region[Init Grid]

         private void InitGrid()
         {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Acy_Id = new DataGridViewTextBoxColumn();
            col_Acy_Id.Name = ACY.ACY_ID;
            col_Acy_Id.HeaderText = "ACY_ID ";
            col_Acy_Id.Visible = false; 
            col_Acy_Id.Width = 100;
            col_Acy_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Acy_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Acy_Id );

            DataGridViewTextBoxColumn col_Acy_name = new DataGridViewTextBoxColumn();
            col_Acy_name.Name = ACY.ACY_NAME;
            col_Acy_name.HeaderText = "ACY NAME";
            //col_Acy_name.Visible = false; 
            col_Acy_name.Width = 100;
            col_Acy_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Acy_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Acy_name);

            DataGridViewTextBoxColumn col_From_date = new DataGridViewTextBoxColumn();
            col_From_date.Name = ACY.FROM_DATE;
            col_From_date.HeaderText = "FROM DATE";
            //col_From_date.Visible = false; 
            col_From_date.Width = 150;
            col_From_date.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_From_date.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_From_date);

            DataGridViewTextBoxColumn col_To_date = new DataGridViewTextBoxColumn();
            col_To_date.Name = ACY.TO_DATE;
            col_To_date.HeaderText = "TO DATE";
            //col_To_date.Visible = false; 
            col_To_date.Width = 100;
            col_To_date.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_To_date.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_To_date);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = ACY.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false; 
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes );

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = ACY.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false; 
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id );

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = ACY.USER_ID;
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
             if (facy == null)
             {
                 facy = new FAcy();
             }
             BuildForm();
             string pkValue = GetSelectedPkValue();
             if (pkValue != null)
             {
                 facy.SetAction(BtnEvent.Open, pkValue);
             }
         }

         #endregion[Grid Action]

         #region[Enter Event]

         private void Txt_acytype_Enter(object sender, EventArgs e)
         {
             Change_infocus();
             lbl_acy_name.BackColor = Theme.lbl_EnterBackColor;
             lbl_acy_name.BorderColor = Theme.lbl_EnterBorderColor;
             lbl_acy_name.ForeColor = Theme.lbl_EnterForeColor;
         }
         private void Change_infocus()
         {
             lbl_acy_name.BackColor = Theme.lbl_BackColor;
             lbl_acy_name.BorderColor = Theme.lbl_BorderColor;
             lbl_acy_name.ForeColor = Theme.lbl_ForeColor;
         }

         #endregion[Enter Event]

         #region[Build Form]

         private void BuildForm()
         {
             if (facy == null)
             {
                 facy = new FAcy();
             }
             facy.FAcy_NeedToRefresh += VAcy_NeedToRefresh;
             Parent.Controls.Add(facy);
             facy.Dock = DockStyle.Fill;
             facy.Show();
             facy.BringToFront();
             
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
                facy.SetAction(BtnEvent.New, null); 
                facy.SetFocus(); 
        } 

        private void Btn_edit_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                facy.SetAction(BtnEvent.Edit, pkValue); 
                facy.SetFocus(); 
            } 
        } 

        private void Btn_delete_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                facy.SetAction(BtnEvent.Delete, pkValue); 
                facy.SetFocus(); 
            } 
        } 

        private void Btn_print_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                facy.SetAction(BtnEvent.Print, pkValue); 
                facy.SetFocus(); 
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

         public void Acy_lookup()
         {
             txt_acy_name.LookupColNames = new string[] { ACY.ACY_NAME };
             txt_acy_name.LookupUpdate += txt_acy_LookupUpdate;
             txt_acy_name.AllowNewEntry = true;
             txt_acy_name.NewEntryNeeded += txt_acy_NewEntryNeeded;
         }
         void txt_acy_LookupUpdate(object sender, EventArgs e)
         {
             txt_acy_name.LookupList = CAcy_exten.GetforLookup();
         }
         private FAcy fsacy = null;
         void txt_acy_NewEntryNeeded(object sender, string pValue)
         {
             if (fsacy == null)
             {
                 fsacy = new FAcy();
             }
             Parent.Controls.Add(fsacy);
             fsacy.Dock = DockStyle.Fill;
             fsacy.Show();
             fsacy.BringToFront();
             fsacy.Focus();
             
             fsacy.SetAction(BtnEvent.New, null);
             fsacy.SetFocus();
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
                 selPkValue = vSelRow.Cells[ACY.ACY_ID].Value.ToString();
             }
             return selPkValue;
         }

         #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VAcy_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        public event EventHandler LAcy_NeedToRefresh;

        public void RaiseEvent_NeedToRefresh()
        {
            LAcy_NeedToRefresh?.Invoke(this, new EventArgs());
        }

        #endregion[RaiseEvent]

}//cls
}//ns
