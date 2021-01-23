// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2020 07.29.30 PM

using System; 
using System.Drawing; 
using System.Windows.Forms; 
using CXLIB; 
 
namespace AXCODE 
{ 
    public partial class LNamespaces : UserControl 
    { 

         #region[Init Grid]

         private void InitGrid()
         {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Namespaces_Id = new DataGridViewTextBoxColumn();
            col_Namespaces_Id.Name = NAMESPACES.NAMESPACES_ID;
            col_Namespaces_Id.HeaderText = "NAMESPACES_ID ";
            col_Namespaces_Id.Visible = false; 
            col_Namespaces_Id.Width = 100;
            col_Namespaces_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Namespaces_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Namespaces_Id );

            DataGridViewTextBoxColumn col_Namespaces_name = new DataGridViewTextBoxColumn();
            col_Namespaces_name.Name = NAMESPACES.NAMESPACES_NAME;
            col_Namespaces_name.HeaderText = "NAMESPACES NAME";
            //col_Namespaces_name.Visible = false; 
            col_Namespaces_name.Width = 225;
            col_Namespaces_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Namespaces_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Namespaces_name);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = NAMESPACES.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false; 
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes );

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = NAMESPACES.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false; 
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id );

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
             if (fnamespaces == null)
             {
                 fnamespaces = new FNamespaces();
             }
             BuildForm();
             string pkValue = GetSelectedPkValue();
             if (pkValue != null)
             {
                 fnamespaces.SetAction(BtnEvent.Open, pkValue);
             }
         }

         #endregion[Grid Action]

         #region[Enter Event]

         private void Txt_namespacestype_Enter(object sender, EventArgs e)
         {
             Change_infocus();
             lbl_namespaces_name.BackColor = Theme.lbl_EnterBackColor;
             lbl_namespaces_name.BorderColor = Theme.lbl_EnterBorderColor;
             lbl_namespaces_name.ForeColor = Theme.lbl_EnterForeColor;
         }
         private void Change_infocus()
         {
             lbl_namespaces_name.BackColor = Theme.lbl_BackColor;
             lbl_namespaces_name.BorderColor = Theme.lbl_BorderColor;
             lbl_namespaces_name.ForeColor = Theme.lbl_ForeColor;
         }

         #endregion[Enter Event]

         #region[Build Form]

         private void BuildForm()
         {
             if (fnamespaces == null)
             {
                 fnamespaces = new FNamespaces();
             }
             fnamespaces.FNamespaces_NeedToRefresh += VNamespaces_NeedToRefresh;
             Parent.Controls.Add(fnamespaces);
             fnamespaces.Dock = DockStyle.Fill;
             fnamespaces.Show();
             fnamespaces.BringToFront();
             
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
                fnamespaces.SetAction(BtnEvent.New, null); 
                fnamespaces.SetFocus(); 
        } 

        private void Btn_edit_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fnamespaces.SetAction(BtnEvent.Edit, pkValue); 
                fnamespaces.SetFocus(); 
            } 
        } 

        private void Btn_delete_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fnamespaces.SetAction(BtnEvent.Delete, pkValue); 
                fnamespaces.SetFocus(); 
            } 
        } 

        private void Btn_print_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fnamespaces.SetAction(BtnEvent.Print, pkValue); 
                fnamespaces.SetFocus(); 
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

         public void Namespaces_lookup()
         {
             txt_namespaces_name.LookupColNames = new string[] { NAMESPACES.NAMESPACES_NAME };
             txt_namespaces_name.LookupUpdate += Txt_namespaces_LookupUpdate;
             txt_namespaces_name.AllowNewEntry = true;
             txt_namespaces_name.NewEntryNeeded += txt_namespaces_NewEntryNeeded;
         }
         void Txt_namespaces_LookupUpdate(object sender, EventArgs e)
         {
             txt_namespaces_name.LookupList = CNamespaces_exten.GetforLookup();
         }
         private FNamespaces fsnamespaces = null;
         void txt_namespaces_NewEntryNeeded(object sender, string pValue)
         {
             if (fsnamespaces == null)
             {
                 fsnamespaces = new FNamespaces();
             }
             Parent.Controls.Add(fsnamespaces);
             fsnamespaces.Dock = DockStyle.Fill;
             fsnamespaces.Show();
             fsnamespaces.BringToFront();
             fsnamespaces.Focus();
             
             fsnamespaces.SetAction(BtnEvent.New, null);
             fsnamespaces.SetFocus();
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
                 selPkValue = vSelRow.Cells[NAMESPACES.NAMESPACES_ID].Value.ToString();
             }
             return selPkValue;
         }

         #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VNamespaces_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        public event EventHandler LNamespaces_NeedToRefresh;

        public void RaiseEvent_NeedToRefresh()
        {
            LNamespaces_NeedToRefresh?.Invoke(this, new EventArgs());
        }

        #endregion[RaiseEvent]

}//cls
}//ns
