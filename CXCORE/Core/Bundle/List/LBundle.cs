// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 08:28:28 AM

using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;

namespace CXCORE
{
    public partial class LBundle : UserControl
    {

        #region[Init Grid]

        private void InitGrid()
        {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Bundle_Id = new DataGridViewTextBoxColumn();
            col_Bundle_Id.Name = BUNDLE.BUNDLE_ID;
            col_Bundle_Id.HeaderText = "BUNDLE_ID ";
            col_Bundle_Id.Visible = false;
            col_Bundle_Id.Width = 100;
            col_Bundle_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Bundle_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Bundle_Id);

            DataGridViewTextBoxColumn col_Bundle_name = new DataGridViewTextBoxColumn();
            col_Bundle_name.Name = BUNDLE.BUNDLE_NAME;
            col_Bundle_name.HeaderText = "BUNDLE NAME";
            //col_Bundle_name.Visible = false; 
            col_Bundle_name.Width = 175;
            col_Bundle_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Bundle_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Bundle_name);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = BUNDLE.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false;
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes);

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = BUNDLE.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false;
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id);

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = BUNDLE.USER_ID;
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
            if (fbundle == null)
            {
                fbundle = new FBundle();
            }
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fbundle.SetAction(BtnEvent.Open, pkValue);
            }
        }

        #endregion[Grid Action]

        #region[Enter Event]

        private void Txt_bundletype_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_bundle_name.BackColor = Theme.lbl_EnterBackColor;
            lbl_bundle_name.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_bundle_name.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Change_infocus()
        {
            lbl_bundle_name.BackColor = Theme.lbl_BackColor;
            lbl_bundle_name.BorderColor = Theme.lbl_BorderColor;
            lbl_bundle_name.ForeColor = Theme.lbl_ForeColor;
        }

        #endregion[Enter Event]

        #region[Build Form]

        private void BuildForm()
        {
            if (fbundle == null)
            {
                fbundle = new FBundle();
            }
            fbundle.FBundle_NeedToRefresh += VBundle_NeedToRefresh;
            Parent.Controls.Add(fbundle);
            fbundle.Dock = DockStyle.Fill;
            fbundle.Show();
            fbundle.BringToFront();

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
            fbundle.SetAction(BtnEvent.New, null);
            fbundle.SetFocus();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fbundle.SetAction(BtnEvent.Edit, pkValue);
                fbundle.SetFocus();
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fbundle.SetAction(BtnEvent.Delete, pkValue);
                fbundle.SetFocus();
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fbundle.SetAction(BtnEvent.Print, pkValue);
                fbundle.SetFocus();
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

        public void Bundle_lookup()
        {
            txt_bundle_name.LookupColNames = new string[] { BUNDLE.BUNDLE_NAME };
            txt_bundle_name.LookupUpdate += txt_bundle_LookupUpdate;
            txt_bundle_name.AllowNewEntry = true;
            txt_bundle_name.NewEntryNeeded += txt_bundle_NewEntryNeeded;
        }
        void txt_bundle_LookupUpdate(object sender, EventArgs e)
        {
            txt_bundle_name.LookupList = CBundle_exten.GetforLookup(new DAL());
        }
        private FBundle fsbundle = null;
        void txt_bundle_NewEntryNeeded(object sender, string pValue)
        {
            if (fsbundle == null)
            {
                fsbundle = new FBundle();
            }
            Parent.Controls.Add(fsbundle);
            fsbundle.Dock = DockStyle.Fill;
            fsbundle.Show();
            fsbundle.BringToFront();
            fsbundle.Focus();

            fsbundle.SetAction(BtnEvent.New, null);
            fsbundle.SetFocus();
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
                selPkValue = vSelRow.Cells[BUNDLE.BUNDLE_ID].Value.ToString();
            }
            return selPkValue;
        }

        #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VBundle_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        public event EventHandler LBundle_NeedToRefresh;

        public void RaiseEvent_NeedToRefresh()
        {
            LBundle_NeedToRefresh?.Invoke(this, new EventArgs());
        }

        #endregion[RaiseEvent]

    }//cls
}//ns
