// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 10:51:36 PM

using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;

namespace CXCORE
{
    public partial class LLedgergroup
    {

        #region[Init Grid]

        private void InitGrid()
        {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Ledgergroup_Id = new DataGridViewTextBoxColumn();
            col_Ledgergroup_Id.Name = LEDGERGROUP.LEDGERGROUP_ID;
            col_Ledgergroup_Id.HeaderText = "LEDGERGROUP_ID ";
            col_Ledgergroup_Id.Visible = false;
            col_Ledgergroup_Id.Width = 100;
            col_Ledgergroup_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Ledgergroup_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Ledgergroup_Id);

            DataGridViewTextBoxColumn col_Ledgergroup_name = new DataGridViewTextBoxColumn();
            col_Ledgergroup_name.Name = LEDGERGROUP.LEDGERGROUP_NAME;
            col_Ledgergroup_name.HeaderText = "LEDGER GROUP";
            //col_Ledgergroup_name.Visible = false; 
            col_Ledgergroup_name.Width = 188;
            col_Ledgergroup_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Ledgergroup_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Ledgergroup_name);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = LEDGERGROUP.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false;
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes);

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = LEDGERGROUP.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false;
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id);

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = LEDGERGROUP.USER_ID;
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
            if (fledgergroup == null)
            {
                fledgergroup = new FLedgergroup();
            }
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fledgergroup.SetAction(BtnEvent.Open, pkValue);
            }
        }

        #endregion[Grid Action]

        #region[Enter Event]

        private void Txt_ledgergrouptype_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_ledgergroup_name.BackColor = Theme.lbl_EnterBackColor;
            lbl_ledgergroup_name.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_ledgergroup_name.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Change_infocus()
        {
            lbl_ledgergroup_name.BackColor = Theme.lbl_BackColor;
            lbl_ledgergroup_name.BorderColor = Theme.lbl_BorderColor;
            lbl_ledgergroup_name.ForeColor = Theme.lbl_ForeColor;
        }

        #endregion[Enter Event]

        #region[Build Form]

        private void BuildForm()
        {
            if (fledgergroup == null)
            {
                fledgergroup = new FLedgergroup();
            }
            fledgergroup.FLedgergroup_NeedToRefresh += VLedgergroup_NeedToRefresh;
            Parent.Controls.Add(fledgergroup);
            fledgergroup.Dock = DockStyle.Fill;
            fledgergroup.Show();
            fledgergroup.BringToFront();

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
            fledgergroup.SetAction(BtnEvent.New, null);
            fledgergroup.SetFocus();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fledgergroup.SetAction(BtnEvent.Edit, pkValue);
                fledgergroup.SetFocus();
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fledgergroup.SetAction(BtnEvent.Delete, pkValue);
                fledgergroup.SetFocus();
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fledgergroup.SetAction(BtnEvent.Print, pkValue);
                fledgergroup.SetFocus();
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

        public void Ledgergroup_lookup()
        {
            txt_ledgergroup_name.LookupColNames = new string[] { LEDGERGROUP.LEDGERGROUP_NAME };
            txt_ledgergroup_name.LookupUpdate += txt_ledgergroup_LookupUpdate;
            txt_ledgergroup_name.AllowNewEntry = true;
            txt_ledgergroup_name.NewEntryNeeded += txt_ledgergroup_NewEntryNeeded;
        }
        void txt_ledgergroup_LookupUpdate(object sender, EventArgs e)
        {
            txt_ledgergroup_name.LookupList = CLedgergroup_exten.GetforLookup(new DAL());
        }
        private FLedgergroup fsledgergroup = null;
        void txt_ledgergroup_NewEntryNeeded(object sender, string pValue)
        {
            if (fsledgergroup == null)
            {
                fsledgergroup = new FLedgergroup();
            }
            Parent.Controls.Add(fsledgergroup);
            fsledgergroup.Dock = DockStyle.Fill;
            fsledgergroup.Show();
            fsledgergroup.BringToFront();
            fsledgergroup.Focus();

            fsledgergroup.SetAction(BtnEvent.New, null);
            fsledgergroup.SetFocus();
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
                selPkValue = vSelRow.Cells[LEDGERGROUP.LEDGERGROUP_ID].Value.ToString();
            }
            return selPkValue;
        }

        #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VLedgergroup_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }
       
        #endregion[RaiseEvent]

    }//cls
}//ns
