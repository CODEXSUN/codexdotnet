// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 09:06:46 AM

using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;

namespace CXCORE
{
    public partial class LPincode 
    {

        #region[Init Grid]

        private void InitGrid()
        {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Pincode_Id = new DataGridViewTextBoxColumn();
            col_Pincode_Id.Name = PINCODE.PINCODE_ID;
            col_Pincode_Id.HeaderText = "PINCODE_ID ";
            col_Pincode_Id.Visible = false;
            col_Pincode_Id.Width = 100;
            col_Pincode_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Pincode_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Pincode_Id);

            DataGridViewTextBoxColumn col_Pincode_name = new DataGridViewTextBoxColumn();
            col_Pincode_name.Name = PINCODE.PINCODE_NAME;
            col_Pincode_name.HeaderText = "PINCODE NAME";
            //col_Pincode_name.Visible = false; 
            col_Pincode_name.Width = 188;
            col_Pincode_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Pincode_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Pincode_name);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = PINCODE.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false;
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes);

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = PINCODE.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false;
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id);

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = PINCODE.USER_ID;
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
            if (fpincode == null)
            {
                fpincode = new FPincode();
            }
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fpincode.SetAction(BtnEvent.Open, pkValue);
            }
        }

        #endregion[Grid Action]

        #region[Enter Event]

        private void Txt_pincodetype_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_pincode_name.BackColor = Theme.lbl_EnterBackColor;
            lbl_pincode_name.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_pincode_name.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Change_infocus()
        {
            lbl_pincode_name.BackColor = Theme.lbl_BackColor;
            lbl_pincode_name.BorderColor = Theme.lbl_BorderColor;
            lbl_pincode_name.ForeColor = Theme.lbl_ForeColor;
        }

        #endregion[Enter Event]

        #region[Build Form]

        private void BuildForm()
        {
            if (fpincode == null)
            {
                fpincode = new FPincode();
            }
            fpincode.FPincode_NeedToRefresh += VPincode_NeedToRefresh;
            Parent.Controls.Add(fpincode);
            fpincode.Dock = DockStyle.Fill;
            fpincode.Show();
            fpincode.BringToFront();

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
            fpincode.SetAction(BtnEvent.New, null);
            fpincode.SetFocus();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fpincode.SetAction(BtnEvent.Edit, pkValue);
                fpincode.SetFocus();
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fpincode.SetAction(BtnEvent.Delete, pkValue);
                fpincode.SetFocus();
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fpincode.SetAction(BtnEvent.Print, pkValue);
                fpincode.SetFocus();
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

        public void Pincode_lookup()
        {
            txt_pincode_name.LookupColNames = new string[] { PINCODE.PINCODE_NAME };
            txt_pincode_name.LookupUpdate += txt_pincode_LookupUpdate;
            txt_pincode_name.AllowNewEntry = true;
            txt_pincode_name.NewEntryNeeded += txt_pincode_NewEntryNeeded;
        }
        void txt_pincode_LookupUpdate(object sender, EventArgs e)
        {
            txt_pincode_name.LookupList = CPincode_exten.GetforLookup(new DAL());
        }
        private FPincode fspincode = null;
        void txt_pincode_NewEntryNeeded(object sender, string pValue)
        {
            if (fspincode == null)
            {
                fspincode = new FPincode();
            }
            Parent.Controls.Add(fspincode);
            fspincode.Dock = DockStyle.Fill;
            fspincode.Show();
            fspincode.BringToFront();
            fspincode.Focus();

            fspincode.SetAction(BtnEvent.New, null);
            fspincode.SetFocus();
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
                selPkValue = vSelRow.Cells[PINCODE.PINCODE_ID].Value.ToString();
            }
            return selPkValue;
        }

        #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VPincode_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        #endregion[RaiseEvent]

    }//cls
}//ns
