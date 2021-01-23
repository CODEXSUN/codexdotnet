// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2020 08.01.05 PM

using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;

namespace CXCORE
{
    public partial class LContacttype : CxControl
    {

        #region[Init Grid]

        private void InitGrid()
        {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Contacttype_Id = new DataGridViewTextBoxColumn();
            col_Contacttype_Id.Name = CONTACTTYPE.CONTACTTYPE_ID;
            col_Contacttype_Id.HeaderText = "CONTACTTYPE_ID ";
            col_Contacttype_Id.Visible = false;
            col_Contacttype_Id.Width = 100;
            col_Contacttype_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Contacttype_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Contacttype_Id);

            DataGridViewTextBoxColumn col_Contacttype_name = new DataGridViewTextBoxColumn();
            col_Contacttype_name.Name = CONTACTTYPE.CONTACTTYPE_NAME;
            col_Contacttype_name.HeaderText = "CONTACT TYPE";
            //col_Contacttype_name.Visible = false; 
            col_Contacttype_name.Width = 188;
            col_Contacttype_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Contacttype_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Contacttype_name);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = CONTACTTYPE.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false;
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes);

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = CONTACTTYPE.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false;
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id);

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = CONTACTTYPE.USER_ID;
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
            if (fcontacttype == null)
            {
                fcontacttype = new FContacttype();
            }
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fcontacttype.SetAction(BtnEvent.Open, pkValue);
            }
        }

        #endregion[Grid Action]

        #region[Enter Event]

        private void Txt_contacttypetype_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_contacttype_name.BackColor = Theme.lbl_EnterBackColor;
            lbl_contacttype_name.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_contacttype_name.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Change_infocus()
        {
            lbl_contacttype_name.BackColor = Theme.lbl_BackColor;
            lbl_contacttype_name.BorderColor = Theme.lbl_BorderColor;
            lbl_contacttype_name.ForeColor = Theme.lbl_ForeColor;
        }

        #endregion[Enter Event]

        #region[Build Form]

        private void BuildForm()
        {
            if (fcontacttype == null)
            {
                fcontacttype = new FContacttype();
            }
            fcontacttype.FContacttype_NeedToRefresh += VContacttype_NeedToRefresh;
            Parent.Controls.Add(fcontacttype);
            fcontacttype.Dock = DockStyle.Fill;
            fcontacttype.Show();
            fcontacttype.BringToFront();

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
            fcontacttype.SetAction(BtnEvent.New, null);
            fcontacttype.SetFocus();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fcontacttype.SetAction(BtnEvent.Edit, pkValue);
                fcontacttype.SetFocus();
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fcontacttype.SetAction(BtnEvent.Delete, pkValue);
                fcontacttype.SetFocus();
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fcontacttype.SetAction(BtnEvent.Print, pkValue);
                fcontacttype.SetFocus();
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

        public void Contacttype_lookup()
        {
            txt_contacttype_name.LookupColNames = new string[] { CONTACTTYPE.CONTACTTYPE_NAME };
            txt_contacttype_name.LookupUpdate += Txt_contacttype_LookupUpdate;
            txt_contacttype_name.AllowNewEntry = true;
            txt_contacttype_name.NewEntryNeeded += Txt_contacttype_NewEntryNeeded;
        }
        void Txt_contacttype_LookupUpdate(object sender, EventArgs e)
        {
            txt_contacttype_name.LookupList = CContacttype_exten.GetforLookup();
        }
        private FContacttype fscontacttype = null;
        void Txt_contacttype_NewEntryNeeded(object sender, string pValue)
        {
            if (fscontacttype == null)
            {
                fscontacttype = new FContacttype();
            }
            Parent.Controls.Add(fscontacttype);
            fscontacttype.Dock = DockStyle.Fill;
            fscontacttype.Show();
            fscontacttype.BringToFront();
            fscontacttype.Focus();

            fscontacttype.SetAction(BtnEvent.New, null);
            fscontacttype.SetFocus();
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
                selPkValue = vSelRow.Cells[CONTACTTYPE.CONTACTTYPE_ID].Value.ToString();
            }
            return selPkValue;
        }

        #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VContacttype_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        #endregion[RaiseEvent]

    }//cls
}//ns
