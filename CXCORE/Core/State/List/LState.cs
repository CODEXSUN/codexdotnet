// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:15:52 AM

using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;

namespace CXCORE
{
    public partial class LState
    {

        #region[Init Grid]

        private void InitGrid()
        {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_State_Id = new DataGridViewTextBoxColumn();
            col_State_Id.Name = STATE.STATE_ID;
            col_State_Id.HeaderText = "STATE_ID ";
            col_State_Id.Visible = false;
            col_State_Id.Width = 100;
            col_State_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_State_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_State_Id);

            DataGridViewTextBoxColumn col_State_name = new DataGridViewTextBoxColumn();
            col_State_name.Name = STATE.STATE_NAME;
            col_State_name.HeaderText = "STATE NAME";
            //col_State_name.Visible = false; 
            col_State_name.Width = 162;
            col_State_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_State_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_State_name);

            DataGridViewTextBoxColumn col_State_code = new DataGridViewTextBoxColumn();
            col_State_code.Name = STATE.STATE_CODE;
            col_State_code.HeaderText = "STATE CODE";
            //col_State_code.Visible = false; 
            col_State_code.Width = 162;
            col_State_code.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_State_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_State_code);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = STATE.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false;
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes);

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = STATE.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false;
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id);

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = STATE.USER_ID;
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
            if (fstate == null)
            {
                fstate = new FState();
            }
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fstate.SetAction(BtnEvent.Open, pkValue);
            }
        }

        #endregion[Grid Action]

        #region[Enter Event]

        private void Txt_statetype_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_state_name.BackColor = Theme.lbl_EnterBackColor;
            lbl_state_name.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_state_name.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Change_infocus()
        {
            lbl_state_name.BackColor = Theme.lbl_BackColor;
            lbl_state_name.BorderColor = Theme.lbl_BorderColor;
            lbl_state_name.ForeColor = Theme.lbl_ForeColor;
        }

        #endregion[Enter Event]

        #region[Build Form]

        private void BuildForm()
        {
            if (fstate == null)
            {
                fstate = new FState();
            }
            fstate.FState_NeedToRefresh += VState_NeedToRefresh;
            Parent.Controls.Add(fstate);
            fstate.Dock = DockStyle.Fill;
            fstate.Show();
            fstate.BringToFront();

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
            fstate.SetAction(BtnEvent.New, null);
            fstate.SetFocus();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fstate.SetAction(BtnEvent.Edit, pkValue);
                fstate.SetFocus();
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fstate.SetAction(BtnEvent.Delete, pkValue);
                fstate.SetFocus();
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fstate.SetAction(BtnEvent.Print, pkValue);
                fstate.SetFocus();
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

        public void State_lookup()
        {
            txt_state_name.LookupColNames = new string[] { STATE.STATE_NAME };
            txt_state_name.LookupUpdate += txt_state_LookupUpdate;
            txt_state_name.AllowNewEntry = true;
            txt_state_name.NewEntryNeeded += txt_state_NewEntryNeeded;
        }
        void txt_state_LookupUpdate(object sender, EventArgs e)
        {
            txt_state_name.LookupList = CState_exten.GetforLookup(new DAL());
        }
        private FState fsstate = null;
        void txt_state_NewEntryNeeded(object sender, string pValue)
        {
            if (fsstate == null)
            {
                fsstate = new FState();
            }
            Parent.Controls.Add(fsstate);
            fsstate.Dock = DockStyle.Fill;
            fsstate.Show();
            fsstate.BringToFront();
            fsstate.Focus();

            fsstate.SetAction(BtnEvent.New, null);
            fsstate.SetFocus();
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
                selPkValue = vSelRow.Cells[STATE.STATE_ID].Value.ToString();
            }
            return selPkValue;
        }

        #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VState_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        #endregion[RaiseEvent]

    }//cls
}//ns
