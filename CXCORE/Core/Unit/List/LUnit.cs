// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:23:08 AM

using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;

namespace CXCORE
{
    public partial class LUnit
    {

        #region[Init Grid]

        private void InitGrid()
        {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Unit_Id = new DataGridViewTextBoxColumn();
            col_Unit_Id.Name = UNIT.UNIT_ID;
            col_Unit_Id.HeaderText = "UNIT_ID ";
            col_Unit_Id.Visible = false;
            col_Unit_Id.Width = 100;
            col_Unit_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Unit_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Unit_Id);

            DataGridViewTextBoxColumn col_Unit_name = new DataGridViewTextBoxColumn();
            col_Unit_name.Name = UNIT.UNIT_NAME;
            col_Unit_name.HeaderText = "UNITS";
            //col_Unit_name.Visible = false; 
            col_Unit_name.Width = 100;
            col_Unit_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Unit_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Unit_name);

            DataGridViewTextBoxColumn col_Unit_desc = new DataGridViewTextBoxColumn();
            col_Unit_desc.Name = UNIT.UNIT_DESC;
            col_Unit_desc.HeaderText = "UNIT DESC";
            //col_Unit_desc.Visible = false; 
            col_Unit_desc.Width = 150;
            col_Unit_desc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Unit_desc.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Unit_desc);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = UNIT.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false;
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes);

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = UNIT.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false;
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id);

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = UNIT.USER_ID;
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
            if (funit == null)
            {
                funit = new FUnit();
            }
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                funit.SetAction(BtnEvent.Open, pkValue);
            }
        }

        #endregion[Grid Action]

        #region[Enter Event]

        private void Txt_unittype_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_unit_name.BackColor = Theme.lbl_EnterBackColor;
            lbl_unit_name.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_unit_name.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Change_infocus()
        {
            lbl_unit_name.BackColor = Theme.lbl_BackColor;
            lbl_unit_name.BorderColor = Theme.lbl_BorderColor;
            lbl_unit_name.ForeColor = Theme.lbl_ForeColor;
        }

        #endregion[Enter Event]

        #region[Build Form]

        private void BuildForm()
        {
            if (funit == null)
            {
                funit = new FUnit();
            }
            funit.FUnit_NeedToRefresh += VUnit_NeedToRefresh;
            Parent.Controls.Add(funit);
            funit.Dock = DockStyle.Fill;
            funit.Show();
            funit.BringToFront();

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
            funit.SetAction(BtnEvent.New, null);
            funit.SetFocus();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                funit.SetAction(BtnEvent.Edit, pkValue);
                funit.SetFocus();
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                funit.SetAction(BtnEvent.Delete, pkValue);
                funit.SetFocus();
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                funit.SetAction(BtnEvent.Print, pkValue);
                funit.SetFocus();
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

        public void Unit_lookup()
        {
            txt_unit_name.LookupColNames = new string[] { UNIT.UNIT_NAME };
            txt_unit_name.LookupUpdate += txt_unit_LookupUpdate;
            txt_unit_name.AllowNewEntry = true;
            txt_unit_name.NewEntryNeeded += txt_unit_NewEntryNeeded;
        }
        void txt_unit_LookupUpdate(object sender, EventArgs e)
        {
            txt_unit_name.LookupList = CUnit_exten.GetforLookup(new DAL());
        }
        private FUnit fsunit = null;
        void txt_unit_NewEntryNeeded(object sender, string pValue)
        {
            if (fsunit == null)
            {
                fsunit = new FUnit();
            }
            Parent.Controls.Add(fsunit);
            fsunit.Dock = DockStyle.Fill;
            fsunit.Show();
            fsunit.BringToFront();
            fsunit.Focus();

            fsunit.SetAction(BtnEvent.New, null);
            fsunit.SetFocus();
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
                selPkValue = vSelRow.Cells[UNIT.UNIT_ID].Value.ToString();
            }
            return selPkValue;
        }

        #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VUnit_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        #endregion[RaiseEvent]

    }//cls
}//ns
