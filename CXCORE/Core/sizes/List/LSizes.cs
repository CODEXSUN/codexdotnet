// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:15:22 AM

using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;

namespace CXCORE
{
    public partial class LSizes : UserControl
    {

        #region[Init Grid]

        private void InitGrid()
        {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Sizes_Id = new DataGridViewTextBoxColumn();
            col_Sizes_Id.Name = SIZES.SIZES_ID;
            col_Sizes_Id.HeaderText = "SIZES_ID ";
            col_Sizes_Id.Visible = false;
            col_Sizes_Id.Width = 100;
            col_Sizes_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Sizes_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Sizes_Id);

            DataGridViewTextBoxColumn col_Sizes_name = new DataGridViewTextBoxColumn();
            col_Sizes_name.Name = SIZES.SIZES_NAME;
            col_Sizes_name.HeaderText = "SIZES";
            //col_Sizes_name.Visible = false; 
            col_Sizes_name.Width = 100;
            col_Sizes_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Sizes_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Sizes_name);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = SIZES.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false;
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes);

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = SIZES.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false;
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id);

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = SIZES.USER_ID;
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
            if (fsizes == null)
            {
                fsizes = new FSizes();
            }
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fsizes.SetAction(BtnEvent.Open, pkValue);
            }
        }

        #endregion[Grid Action]

        #region[Enter Event]

        private void Txt_sizestype_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_sizes_name.BackColor = Theme.lbl_EnterBackColor;
            lbl_sizes_name.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_sizes_name.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Change_infocus()
        {
            lbl_sizes_name.BackColor = Theme.lbl_BackColor;
            lbl_sizes_name.BorderColor = Theme.lbl_BorderColor;
            lbl_sizes_name.ForeColor = Theme.lbl_ForeColor;
        }

        #endregion[Enter Event]

        #region[Build Form]

        private void BuildForm()
        {
            if (fsizes == null)
            {
                fsizes = new FSizes();
            }
            fsizes.FSizes_NeedToRefresh += VSizes_NeedToRefresh;
            Parent.Controls.Add(fsizes);
            fsizes.Dock = DockStyle.Fill;
            fsizes.Show();
            fsizes.BringToFront();

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
            fsizes.SetAction(BtnEvent.New, null);
            fsizes.SetFocus();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fsizes.SetAction(BtnEvent.Edit, pkValue);
                fsizes.SetFocus();
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fsizes.SetAction(BtnEvent.Delete, pkValue);
                fsizes.SetFocus();
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fsizes.SetAction(BtnEvent.Print, pkValue);
                fsizes.SetFocus();
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

        public void Sizes_lookup()
        {
            txt_sizes_name.LookupColNames = new string[] { SIZES.SIZES_NAME };
            txt_sizes_name.LookupUpdate += txt_sizes_LookupUpdate;
            txt_sizes_name.AllowNewEntry = true;
            txt_sizes_name.NewEntryNeeded += txt_sizes_NewEntryNeeded;
        }
        void txt_sizes_LookupUpdate(object sender, EventArgs e)
        {
            txt_sizes_name.LookupList = CSizes_exten.GetforLookup(new DAL());
        }
        private FSizes fssizes = null;
        void txt_sizes_NewEntryNeeded(object sender, string pValue)
        {
            if (fssizes == null)
            {
                fssizes = new FSizes();
            }
            Parent.Controls.Add(fssizes);
            fssizes.Dock = DockStyle.Fill;
            fssizes.Show();
            fssizes.BringToFront();
            fssizes.Focus();

            fssizes.SetAction(BtnEvent.New, null);
            fssizes.SetFocus();
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
                selPkValue = vSelRow.Cells[SIZES.SIZES_ID].Value.ToString();
            }
            return selPkValue;
        }

        #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VSizes_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        public event EventHandler LSizes_NeedToRefresh;

        public void RaiseEvent_NeedToRefresh()
        {
            LSizes_NeedToRefresh?.Invoke(this, new EventArgs());
        }

        #endregion[RaiseEvent]

    }//cls
}//ns
