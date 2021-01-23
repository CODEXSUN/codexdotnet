// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 10-08-2020 10:29:15 AM

using System; 
using System.Drawing; 
using System.Windows.Forms; 
using CXLIB; 
 
namespace CXCORE 
{ 
    public partial class LVersion
    { 

         #region[Init Grid]

         private void InitGrid()
         {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Version_Id = new DataGridViewTextBoxColumn();
            col_Version_Id.Name = VERSION.VERSION_ID;
            col_Version_Id.HeaderText = "VERSION_ID ";
            col_Version_Id.Visible = false; 
            col_Version_Id.Width = 100;
            col_Version_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Version_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Version_Id );

            DataGridViewTextBoxColumn col_Version_name = new DataGridViewTextBoxColumn();
            col_Version_name.Name = VERSION.VERSION_NAME;
            col_Version_name.HeaderText = "VERSION NAME";
            //col_Version_name.Visible = false; 
            col_Version_name.Width = 188;
            col_Version_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Version_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Version_name);

            DataGridViewTextBoxColumn col_Created_on = new DataGridViewTextBoxColumn();
            col_Created_on.Name = VERSION.CREATED_ON;
            col_Created_on.HeaderText = "CREATED ON";
            //col_Created_on.Visible = false; 
            col_Created_on.Width = 162;
            col_Created_on.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Created_on.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Created_on);

            DataGridViewTextBoxColumn col_Changes = new DataGridViewTextBoxColumn();
            col_Changes.Name = VERSION.CHANGES;
            col_Changes.HeaderText = "CHANGES";
            //col_Changes.Visible = false; 
            col_Changes.Width = 100;
            col_Changes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Changes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Changes);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = VERSION.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false; 
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes );

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = VERSION.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false; 
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id );

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = VERSION.USER_ID;
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
             if (fversion == null)
             {
                 fversion = new FVersion();
             }
             BuildForm();
             string pkValue = GetSelectedPkValue();
             if (pkValue != null)
             {
                 fversion.SetAction(BtnEvent.Open, pkValue);
             }
         }

         #endregion[Grid Action]

         #region[Enter Event]

         private void Txt_versiontype_Enter(object sender, EventArgs e)
         {
             Change_infocus();
             lbl_version_name.BackColor = Theme.lbl_EnterBackColor;
             lbl_version_name.BorderColor = Theme.lbl_EnterBorderColor;
             lbl_version_name.ForeColor = Theme.lbl_EnterForeColor;
         }
         private void Change_infocus()
         {
             lbl_version_name.BackColor = Theme.lbl_BackColor;
             lbl_version_name.BorderColor = Theme.lbl_BorderColor;
             lbl_version_name.ForeColor = Theme.lbl_ForeColor;
         }

         #endregion[Enter Event]

         #region[Build Form]

         private void BuildForm()
         {
             if (fversion == null)
             {
                 fversion = new FVersion();
             }
             fversion.FVersion_NeedToRefresh += VVersion_NeedToRefresh;
             Parent.Controls.Add(fversion);
             fversion.Dock = DockStyle.Fill;
             fversion.Show();
             fversion.BringToFront();
             
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
                fversion.SetAction(BtnEvent.New, null); 
                fversion.SetFocus(); 
        } 

        private void Btn_edit_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fversion.SetAction(BtnEvent.Edit, pkValue); 
                fversion.SetFocus(); 
            } 
        } 

        private void Btn_delete_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fversion.SetAction(BtnEvent.Delete, pkValue); 
                fversion.SetFocus(); 
            } 
        } 

        private void Btn_print_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fversion.SetAction(BtnEvent.Print, pkValue); 
                fversion.SetFocus(); 
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

         public void Version_lookup()
         {
             txt_version_name.LookupColNames = new string[] { VERSION.VERSION_NAME };
             txt_version_name.LookupUpdate += txt_version_LookupUpdate;
             txt_version_name.AllowNewEntry = true;
             txt_version_name.NewEntryNeeded += txt_version_NewEntryNeeded;
         }
         void txt_version_LookupUpdate(object sender, EventArgs e)
         {
             txt_version_name.LookupList = CVersion_exten.GetforLookup();
         }
         private FVersion fsversion = null;
         void txt_version_NewEntryNeeded(object sender, string pValue)
         {
             if (fsversion == null)
             {
                 fsversion = new FVersion();
             }
             Parent.Controls.Add(fsversion);
             fsversion.Dock = DockStyle.Fill;
             fsversion.Show();
             fsversion.BringToFront();
             fsversion.Focus();
             
             fsversion.SetAction(BtnEvent.New, null);
             fsversion.SetFocus();
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
                 selPkValue = vSelRow.Cells[VERSION.VERSION_ID].Value.ToString();
             }
             return selPkValue;
         }

         #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VVersion_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        #endregion[RaiseEvent]

}//cls
}//ns
