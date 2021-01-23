// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:37:39 AM

using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;

namespace CXCORE
{
    public partial class LUser
    {

        #region[Init Grid]

        private void InitGrid()
        {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = USER.USER_ID;
            col_User_Id.HeaderText = "USER_ID ";
            col_User_Id.Visible = false;
            col_User_Id.Width = 100;
            col_User_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_User_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_User_Id);

            DataGridViewTextBoxColumn col_User_name = new DataGridViewTextBoxColumn();
            col_User_name.Name = USER.USER_NAME;
            col_User_name.HeaderText = "USER NAME";
            //col_User_name.Visible = false; 
            col_User_name.Width = 150;
            col_User_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_User_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_User_name);

            DataGridViewTextBoxColumn col_User_password = new DataGridViewTextBoxColumn();
            col_User_password.Name = USER.USER_PASSWORD;
            col_User_password.HeaderText = "USER PASSWORD";
            //col_User_password.Visible = false; 
            col_User_password.Width = 200;
            col_User_password.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_User_password.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_User_password);

            DataGridViewTextBoxColumn col_Createon = new DataGridViewTextBoxColumn();
            col_Createon.Name = USER.CREATEON;
            col_Createon.HeaderText = "CREATEON";
            //col_Createon.Visible = false; 
            col_Createon.Width = 100;
            col_Createon.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Createon.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Createon);

            DataGridViewTextBoxColumn col_Role_id = new DataGridViewTextBoxColumn();
            col_Role_id.Name = USER.ROLE_ID;
            col_Role_id.HeaderText = "ROLE ID";
            //col_Role_id.Visible = false; 
            col_Role_id.Width = 100;
            col_Role_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Role_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Role_id);

            DataGridViewTextBoxColumn col_Entryby = new DataGridViewTextBoxColumn();
            col_Entryby.Name = USER.ENTRYBY;
            col_Entryby.HeaderText = "ENTRYBY";
            //col_Entryby.Visible = false; 
            col_Entryby.Width = 100;
            col_Entryby.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Entryby.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Entryby);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = USER.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false;
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes);

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = USER.ACTIVE_ID;
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
            if (fuser == null)
            {
                fuser = new FUser();
            }
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fuser.SetAction(BtnEvent.Open, pkValue);
            }
        }

        #endregion[Grid Action]

        #region[Enter Event]

        private void Txt_usertype_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_user_name.BackColor = Theme.lbl_EnterBackColor;
            lbl_user_name.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_user_name.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Change_infocus()
        {
            lbl_user_name.BackColor = Theme.lbl_BackColor;
            lbl_user_name.BorderColor = Theme.lbl_BorderColor;
            lbl_user_name.ForeColor = Theme.lbl_ForeColor;
        }

        #endregion[Enter Event]

        #region[Build Form]

        private void BuildForm()
        {
            if (fuser == null)
            {
                fuser = new FUser();
            }
            fuser.FUser_NeedToRefresh += VUser_NeedToRefresh;
            Parent.Controls.Add(fuser);
            fuser.Dock = DockStyle.Fill;
            fuser.Show();
            fuser.BringToFront();

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
            fuser.SetAction(BtnEvent.New, null);
            fuser.SetFocus();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fuser.SetAction(BtnEvent.Edit, pkValue);
                fuser.SetFocus();
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fuser.SetAction(BtnEvent.Delete, pkValue);
                fuser.SetFocus();
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fuser.SetAction(BtnEvent.Print, pkValue);
                fuser.SetFocus();
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

        public void User_lookup()
        {
            txt_user_name.LookupColNames = new string[] { USER.USER_NAME };
            txt_user_name.LookupUpdate += txt_user_LookupUpdate;
            txt_user_name.AllowNewEntry = true;
            txt_user_name.NewEntryNeeded += txt_user_NewEntryNeeded;
        }
        void txt_user_LookupUpdate(object sender, EventArgs e)
        {
            txt_user_name.LookupList = CUser_exten.GetforLookup(new DAL());
        }
        private FUser fsuser = null;
        void txt_user_NewEntryNeeded(object sender, string pValue)
        {
            if (fsuser == null)
            {
                fsuser = new FUser();
            }
            Parent.Controls.Add(fsuser);
            fsuser.Dock = DockStyle.Fill;
            fsuser.Show();
            fsuser.BringToFront();
            fsuser.Focus();

            fsuser.SetAction(BtnEvent.New, null);
            fsuser.SetFocus();
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
                selPkValue = vSelRow.Cells[USER.USER_ID].Value.ToString();
            }
            return selPkValue;
        }

        #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VUser_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        #endregion[RaiseEvent]

    }//cls
}//ns
