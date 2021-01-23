// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 10:41:08 PM

using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;

namespace CXCORE
{
    public partial class LHsncode
    {

        #region[Init Grid]

        private void InitGrid()
        {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Hsncode_Id = new DataGridViewTextBoxColumn();
            col_Hsncode_Id.Name = HSNCODE.HSNCODE_ID;
            col_Hsncode_Id.HeaderText = "HSNCODE_ID ";
            col_Hsncode_Id.Visible = false;
            col_Hsncode_Id.Width = 100;
            col_Hsncode_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Hsncode_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Hsncode_Id);

            DataGridViewTextBoxColumn col_Hsncode_name = new DataGridViewTextBoxColumn();
            col_Hsncode_name.Name = HSNCODE.HSNCODE_NAME;
            col_Hsncode_name.HeaderText = "HSN CODE";
            //col_Hsncode_name.Visible = false; 
            col_Hsncode_name.Width = 150;
            col_Hsncode_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Hsncode_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Hsncode_name);

            DataGridViewTextBoxColumn col_Description = new DataGridViewTextBoxColumn();
            col_Description.Name = HSNCODE.DESCRIPTION;
            col_Description.HeaderText = "DESCRIPTION";
            //col_Description.Visible = false; 
            col_Description.Width = 175;
            col_Description.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Description);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = HSNCODE.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false;
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes);

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = HSNCODE.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false;
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id);

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = HSNCODE.USER_ID;
            col_User_Id.HeaderText = "ENTRY BY";
            //col_User_Id.Visible = false; 
            col_User_Id.Width = 120;
            col_User_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_User_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_User_Id);

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
            if (fhsncode == null)
            {
                fhsncode = new FHsncode();
            }
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fhsncode.SetAction(BtnEvent.Open, pkValue);
            }
        }

        #endregion[Grid Action]

        #region[Enter Event]

        private void Txt_hsncodetype_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_hsncode_name.BackColor = Theme.lbl_EnterBackColor;
            lbl_hsncode_name.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_hsncode_name.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Change_infocus()
        {
            lbl_hsncode_name.BackColor = Theme.lbl_BackColor;
            lbl_hsncode_name.BorderColor = Theme.lbl_BorderColor;
            lbl_hsncode_name.ForeColor = Theme.lbl_ForeColor;
        }

        #endregion[Enter Event]

        #region[Build Form]

        private void BuildForm()
        {
            if (fhsncode == null)
            {
                fhsncode = new FHsncode();
            }
            fhsncode.FHsncode_NeedToRefresh += VHsncode_NeedToRefresh;
            Parent.Controls.Add(fhsncode);
            fhsncode.Dock = DockStyle.Fill;
            fhsncode.Show();
            fhsncode.BringToFront();

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
            fhsncode.SetAction(BtnEvent.New, null);
            fhsncode.SetFocus();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fhsncode.SetAction(BtnEvent.Edit, pkValue);
                fhsncode.SetFocus();
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fhsncode.SetAction(BtnEvent.Delete, pkValue);
                fhsncode.SetFocus();
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fhsncode.SetAction(BtnEvent.Print, pkValue);
                fhsncode.SetFocus();
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

        public void Hsncode_lookup()
        {
            txt_hsncode_name.LookupColNames = new string[] { HSNCODE.HSNCODE_NAME };
            txt_hsncode_name.LookupUpdate += txt_hsncode_LookupUpdate;
            txt_hsncode_name.AllowNewEntry = true;
            txt_hsncode_name.NewEntryNeeded += txt_hsncode_NewEntryNeeded;
        }
        void txt_hsncode_LookupUpdate(object sender, EventArgs e)
        {
            txt_hsncode_name.LookupList = CHsncode_exten.GetforLookup(new DAL());
        }
        private FHsncode fshsncode = null;
        void txt_hsncode_NewEntryNeeded(object sender, string pValue)
        {
            if (fshsncode == null)
            {
                fshsncode = new FHsncode();
            }
            Parent.Controls.Add(fshsncode);
            fshsncode.Dock = DockStyle.Fill;
            fshsncode.Show();
            fshsncode.BringToFront();
            fshsncode.Focus();

            fshsncode.SetAction(BtnEvent.New, null);
            fshsncode.SetFocus();
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
                selPkValue = vSelRow.Cells[HSNCODE.HSNCODE_ID].Value.ToString();
            }
            return selPkValue;
        }

        #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VHsncode_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        #endregion[RaiseEvent]

    }//cls
}//ns
