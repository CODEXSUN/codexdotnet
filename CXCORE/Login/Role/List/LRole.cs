// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:34:52 AM

using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;

namespace CXCORE
{
    public partial class LRole : UserControl
    {

        #region[Init Grid]

        private void InitGrid()
        {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Role_Id = new DataGridViewTextBoxColumn();
            col_Role_Id.Name = ROLE.ROLE_ID;
            col_Role_Id.HeaderText = "ROLE_ID ";
            col_Role_Id.Visible = false;
            col_Role_Id.Width = 100;
            col_Role_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Role_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Role_Id);

            DataGridViewTextBoxColumn col_Role_name = new DataGridViewTextBoxColumn();
            col_Role_name.Name = ROLE.ROLE_NAME;
            col_Role_name.HeaderText = "ROLE NAME";
            //col_Role_name.Visible = false; 
            col_Role_name.Width = 150;
            col_Role_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Role_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Role_name);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = ROLE.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false;
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes);

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = ROLE.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false;
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id);

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
            if (frole == null)
            {
                frole = new FRole();
            }
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                frole.SetAction(BtnEvent.Open, pkValue);
            }
        }

        #endregion[Grid Action]

        #region[Enter Event]

        private void Txt_roletype_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_role_name.BackColor = Theme.lbl_EnterBackColor;
            lbl_role_name.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_role_name.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Change_infocus()
        {
            lbl_role_name.BackColor = Theme.lbl_BackColor;
            lbl_role_name.BorderColor = Theme.lbl_BorderColor;
            lbl_role_name.ForeColor = Theme.lbl_ForeColor;
        }

        #endregion[Enter Event]

        #region[Build Form]

        private void BuildForm()
        {
            if (frole == null)
            {
                frole = new FRole();
            }
            frole.FRole_NeedToRefresh += VRole_NeedToRefresh;
            Parent.Controls.Add(frole);
            frole.Dock = DockStyle.Fill;
            frole.Show();
            frole.BringToFront();

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
            frole.SetAction(BtnEvent.New, null);
            frole.SetFocus();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                frole.SetAction(BtnEvent.Edit, pkValue);
                frole.SetFocus();
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                frole.SetAction(BtnEvent.Delete, pkValue);
                frole.SetFocus();
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                frole.SetAction(BtnEvent.Print, pkValue);
                frole.SetFocus();
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

        public void Role_lookup()
        {
            txt_role_name.LookupColNames = new string[] { ROLE.ROLE_NAME };
            txt_role_name.LookupUpdate += txt_role_LookupUpdate;
            txt_role_name.AllowNewEntry = true;
            txt_role_name.NewEntryNeeded += txt_role_NewEntryNeeded;
        }
        void txt_role_LookupUpdate(object sender, EventArgs e)
        {
            txt_role_name.LookupList = CRole_exten.GetforLookup(new DAL());
        }
        private FRole fsrole = null;
        void txt_role_NewEntryNeeded(object sender, string pValue)
        {
            if (fsrole == null)
            {
                fsrole = new FRole();
            }
            Parent.Controls.Add(fsrole);
            fsrole.Dock = DockStyle.Fill;
            fsrole.Show();
            fsrole.BringToFront();
            fsrole.Focus();

            fsrole.SetAction(BtnEvent.New, null);
            fsrole.SetFocus();
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
                selPkValue = vSelRow.Cells[ROLE.ROLE_ID].Value.ToString();
            }
            return selPkValue;
        }

        #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VRole_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        public event EventHandler LRole_NeedToRefresh;

        public void RaiseEvent_NeedToRefresh()
        {
            LRole_NeedToRefresh?.Invoke(this, new EventArgs());
        }

        #endregion[RaiseEvent]

    }//cls
}//ns
