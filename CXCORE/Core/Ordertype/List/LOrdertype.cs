// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 15-05-2019 06:44:13 PM

using System; 
using System.Drawing; 
using System.Windows.Forms; 
using CXLIB; 
 
namespace CXCORE 
{ 
    public partial class LOrdertype : UserControl 
    { 

         #region[Init Grid]

         private void InitGrid()
         {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Ordertype_Id = new DataGridViewTextBoxColumn();
            col_Ordertype_Id.Name = ORDERTYPE.ORDERTYPE_ID;
            col_Ordertype_Id.HeaderText = "ORDERTYPE_ID ";
            col_Ordertype_Id.Visible = false; 
            col_Ordertype_Id.Width = 100;
            col_Ordertype_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Ordertype_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Ordertype_Id );

            DataGridViewTextBoxColumn col_Ordertype_name = new DataGridViewTextBoxColumn();
            col_Ordertype_name.Name = ORDERTYPE.ORDERTYPE_NAME;
            col_Ordertype_name.HeaderText = "ORDER TYPE";
            //col_Ordertype_name.Visible = false; 
            col_Ordertype_name.Width = 162;
            col_Ordertype_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Ordertype_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Ordertype_name);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = ORDERTYPE.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false; 
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes );

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = ORDERTYPE.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false; 
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id );

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = ORDERTYPE.USER_ID;
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
             if (fordertype == null)
             {
                 fordertype = new FOrdertype();
             }
             BuildForm();
             string pkValue = GetSelectedPkValue();
             if (pkValue != null)
             {
                 fordertype.SetAction(BtnEvent.Open, pkValue);
             }
         }

         #endregion[Grid Action]

         #region[Enter Event]

         private void Txt_ordertypetype_Enter(object sender, EventArgs e)
         {
             Change_infocus();
             lbl_ordertype_name.BackColor = Theme.lbl_EnterBackColor;
             lbl_ordertype_name.BorderColor = Theme.lbl_EnterBorderColor;
             lbl_ordertype_name.ForeColor = Theme.lbl_EnterForeColor;
         }
         private void Change_infocus()
         {
             lbl_ordertype_name.BackColor = Theme.lbl_BackColor;
             lbl_ordertype_name.BorderColor = Theme.lbl_BorderColor;
             lbl_ordertype_name.ForeColor = Theme.lbl_ForeColor;
         }

         #endregion[Enter Event]

         #region[Build Form]

         private void BuildForm()
         {
             if (fordertype == null)
             {
                 fordertype = new FOrdertype();
             }
             fordertype.FOrdertype_NeedToRefresh += VOrdertype_NeedToRefresh;
             Parent.Controls.Add(fordertype);
             fordertype.Dock = DockStyle.Fill;
             fordertype.Show();
             fordertype.BringToFront();
             
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
                fordertype.SetAction(BtnEvent.New, null); 
                fordertype.SetFocus(); 
        } 

        private void Btn_edit_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fordertype.SetAction(BtnEvent.Edit, pkValue); 
                fordertype.SetFocus(); 
            } 
        } 

        private void Btn_delete_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fordertype.SetAction(BtnEvent.Delete, pkValue); 
                fordertype.SetFocus(); 
            } 
        } 

        private void Btn_print_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fordertype.SetAction(BtnEvent.Print, pkValue); 
                fordertype.SetFocus(); 
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

         public void Ordertype_lookup()
         {
             txt_ordertype_name.LookupColNames = new string[] { ORDERTYPE.ORDERTYPE_NAME };
             txt_ordertype_name.LookupUpdate += txt_ordertype_LookupUpdate;
             txt_ordertype_name.AllowNewEntry = true;
             txt_ordertype_name.NewEntryNeeded += txt_ordertype_NewEntryNeeded;
         }
         void txt_ordertype_LookupUpdate(object sender, EventArgs e)
         {
             txt_ordertype_name.LookupList = COrdertype_exten.GetforLookup(new DAL());
         }
         private FOrdertype fsordertype = null;
         void txt_ordertype_NewEntryNeeded(object sender, string pValue)
         {
             if (fsordertype == null)
             {
                 fsordertype = new FOrdertype();
             }
             Parent.Controls.Add(fsordertype);
             fsordertype.Dock = DockStyle.Fill;
             fsordertype.Show();
             fsordertype.BringToFront();
             fsordertype.Focus();
             
             fsordertype.SetAction(BtnEvent.New, null);
             fsordertype.SetFocus();
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
                 selPkValue = vSelRow.Cells[ORDERTYPE.ORDERTYPE_ID].Value.ToString();
             }
             return selPkValue;
         }

         #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VOrdertype_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        public event EventHandler LOrdertype_NeedToRefresh;

        public void RaiseEvent_NeedToRefresh()
        {
            LOrdertype_NeedToRefresh?.Invoke(this, new EventArgs());
        }

        #endregion[RaiseEvent]

}//cls
}//ns
