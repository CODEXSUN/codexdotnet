// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 15-10-2019 10:05:59 AM

using System; 
using System.Drawing; 
using System.Windows.Forms; 
using CXLIB; 
 
namespace CXCORE 
{ 
    public partial class LMonth : CxControl 
    { 

         #region[Init Grid]

         private void InitGrid()
         {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Month_Id = new DataGridViewTextBoxColumn();
            col_Month_Id.Name = MONTH.MONTH_ID;
            col_Month_Id.HeaderText = "MONTH_ID ";
            col_Month_Id.Visible = false; 
            col_Month_Id.Width = 100;
            col_Month_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Month_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Month_Id );

            DataGridViewTextBoxColumn col_Month_name = new DataGridViewTextBoxColumn();
            col_Month_name.Name = MONTH.MONTH_NAME;
            col_Month_name.HeaderText = "MONTH NAME";
            //col_Month_name.Visible = false; 
            col_Month_name.Width = 162;
            col_Month_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Month_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Month_name);

            DataGridViewTextBoxColumn col_Month_starts = new DataGridViewTextBoxColumn();
            col_Month_starts.Name = MONTH.MONTH_STARTS;
            col_Month_starts.HeaderText = "MONTH STARTS";
            //col_Month_starts.Visible = false; 
            col_Month_starts.Width = 188;
            col_Month_starts.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Month_starts.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Month_starts);

            DataGridViewTextBoxColumn col_Month_ends = new DataGridViewTextBoxColumn();
            col_Month_ends.Name = MONTH.MONTH_ENDS;
            col_Month_ends.HeaderText = "MONTH ENDS";
            //col_Month_ends.Visible = false; 
            col_Month_ends.Width = 162;
            col_Month_ends.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Month_ends.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Month_ends);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = MONTH.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false; 
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes );

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = MONTH.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false; 
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id );

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = MONTH.USER_ID;
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
             if (fmonth == null)
             {
                 fmonth = new FMonth();
             }
             BuildForm();
             string pkValue = GetSelectedPkValue();
             if (pkValue != null)
             {
                 fmonth.SetAction(BtnEvent.Open, pkValue);
             }
         }

         #endregion[Grid Action]

         #region[Enter Event]

         private void Txt_monthtype_Enter(object sender, EventArgs e)
         {
             Change_infocus();
             lbl_month_name.BackColor = Theme.lbl_EnterBackColor;
             lbl_month_name.BorderColor = Theme.lbl_EnterBorderColor;
             lbl_month_name.ForeColor = Theme.lbl_EnterForeColor;
         }
         private void Change_infocus()
         {
             lbl_month_name.BackColor = Theme.lbl_BackColor;
             lbl_month_name.BorderColor = Theme.lbl_BorderColor;
             lbl_month_name.ForeColor = Theme.lbl_ForeColor;
         }

         #endregion[Enter Event]

         #region[Build Form]

         private void BuildForm()
         {
             if (fmonth == null)
             {
                 fmonth = new FMonth();
             }
             fmonth.FMonth_NeedToRefresh += VMonth_NeedToRefresh;
             Parent.Controls.Add(fmonth);
             fmonth.Dock = DockStyle.Fill;
             fmonth.Show();
             fmonth.BringToFront();
             
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
                fmonth.SetAction(BtnEvent.New, null); 
                fmonth.SetFocus(); 
        } 

        private void Btn_edit_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fmonth.SetAction(BtnEvent.Edit, pkValue); 
                fmonth.SetFocus(); 
            } 
        } 

        private void Btn_delete_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fmonth.SetAction(BtnEvent.Delete, pkValue); 
                fmonth.SetFocus(); 
            } 
        } 

        private void Btn_print_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fmonth.SetAction(BtnEvent.Print, pkValue); 
                fmonth.SetFocus(); 
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

         public void Month_lookup()
         {
             txt_month_name.LookupColNames = new string[] { MONTH.MONTH_NAME };
             txt_month_name.LookupUpdate += txt_month_LookupUpdate;
             txt_month_name.AllowNewEntry = true;
             txt_month_name.NewEntryNeeded += txt_month_NewEntryNeeded;
         }
         void txt_month_LookupUpdate(object sender, EventArgs e)
         {
             txt_month_name.LookupList = CMonth_exten.GetforLookup(new DAL());
         }
         private FMonth fsmonth = null;
         void txt_month_NewEntryNeeded(object sender, string pValue)
         {
             if (fsmonth == null)
             {
                 fsmonth = new FMonth();
             }
             Parent.Controls.Add(fsmonth);
             fsmonth.Dock = DockStyle.Fill;
             fsmonth.Show();
             fsmonth.BringToFront();
             fsmonth.Focus();
             
             fsmonth.SetAction(BtnEvent.New, null);
             fsmonth.SetFocus();
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
                 selPkValue = vSelRow.Cells[MONTH.MONTH_ID].Value.ToString();
             }
             return selPkValue;
         }

         #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VMonth_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        //public event EventHandler LMonth_NeedToRefresh;

        //public void RaiseEvent_NeedToRefresh()
        //{
        //    LMonth_NeedToRefresh?.Invoke(this, new EventArgs());
        //}

        #endregion[RaiseEvent]

}//cls
}//ns
