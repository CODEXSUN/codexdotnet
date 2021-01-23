// Version : 4.0.0.2 Date : 10-08-2020
// Auto Generated
// last update : 23-01-2021 08:39:04 PM

using System; 
using System.Drawing; 
using System.Windows.Forms; 
using CXLIB; 
 
namespace CXERP 
{ 
    public partial class LPo
    { 

         #region[Init Grid]

         private void InitGrid()
         {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Po_Id = new DataGridViewTextBoxColumn();
            col_Po_Id.Name = PO.PO_ID;
            col_Po_Id.HeaderText = "PO_ID ";
            col_Po_Id.Visible = false; 
            col_Po_Id.Width = 100;
            col_Po_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Po_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Po_Id );

            DataGridViewTextBoxColumn col_Po_no = new DataGridViewTextBoxColumn();
            col_Po_no.Name = PO.PO_NO;
            col_Po_no.HeaderText = "PO NO";
            //col_Po_no.Visible = false; 
            col_Po_no.Width = 100;
            col_Po_no.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Po_no.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Po_no);

            DataGridViewTextBoxColumn col_Po_date = new DataGridViewTextBoxColumn();
            col_Po_date.Name = PO.PO_DATE;
            col_Po_date.HeaderText = "DATE";
            //col_Po_date.Visible = false; 
            col_Po_date.Width = 100;
            col_Po_date.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Po_date.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Po_date);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = PO.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false; 
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes );

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = PO.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false; 
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id );

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = PO.USER_ID;
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
             if (fpo == null)
             {
                 fpo = new FPo();
             }
             BuildForm();
             string pkValue = GetSelectedPkValue();
             if (pkValue != null)
             {
                 fpo.SetAction(BtnEvent.Open, pkValue);
             }
         }

         #endregion[Grid Action]

         #region[Enter Event]

         private void Txt_potype_Enter(object sender, EventArgs e)
         {
             Change_infocus();
             lbl_po_name.BackColor = Theme.lbl_EnterBackColor;
             lbl_po_name.BorderColor = Theme.lbl_EnterBorderColor;
             lbl_po_name.ForeColor = Theme.lbl_EnterForeColor;
         }
         private void Change_infocus()
         {
             lbl_po_name.BackColor = Theme.lbl_BackColor;
             lbl_po_name.BorderColor = Theme.lbl_BorderColor;
             lbl_po_name.ForeColor = Theme.lbl_ForeColor;
         }

         #endregion[Enter Event]

         #region[Build Form]

         private void BuildForm()
         {
             if (fpo == null)
             {
                 fpo = new FPo();
             }
             fpo.FPo_NeedToRefresh += VPo_NeedToRefresh;
             Parent.Controls.Add(fpo);
             fpo.Dock = DockStyle.Fill;
             fpo.Show();
             fpo.BringToFront();
             
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
                fpo.SetAction(BtnEvent.New, null); 
                fpo.SetFocus(); 
        } 

        private void Btn_edit_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fpo.SetAction(BtnEvent.Edit, pkValue); 
                fpo.SetFocus(); 
            } 
        } 

        private void Btn_delete_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fpo.SetAction(BtnEvent.Delete, pkValue); 
                fpo.SetFocus(); 
            } 
        } 

        private void Btn_print_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fpo.SetAction(BtnEvent.Print, pkValue); 
                fpo.SetFocus(); 
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

         public void Po_lookup()
         {
             txt_po_no.LookupColNames = new string[] { PO.PO_NO };
             txt_po_no.LookupUpdate += txt_po_LookupUpdate;
             txt_po_no.AllowNewEntry = true;
             txt_po_no.NewEntryNeeded += txt_po_NewEntryNeeded;
         }
         void txt_po_LookupUpdate(object sender, EventArgs e)
         {
             txt_po_no.LookupList = CPo_exten.GetforLookup();
         }
         private FPo fspo = null;
         void txt_po_NewEntryNeeded(object sender, string pValue)
         {
             if (fspo == null)
             {
                 fspo = new FPo();
             }
             Parent.Controls.Add(fspo);
             fspo.Dock = DockStyle.Fill;
             fspo.Show();
             fspo.BringToFront();
             fspo.Focus();
             
             fspo.SetAction(BtnEvent.New, null);
             fspo.SetFocus();
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
                 selPkValue = vSelRow.Cells[PO.PO_ID].Value.ToString();
             }
             return selPkValue;
         }

         #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VPo_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        #endregion[RaiseEvent]

}//cls
}//ns
