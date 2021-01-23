// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 10:55:36 PM

using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;

namespace CXCORE
{
    public partial class LLedger
    {

        #region[Init Grid]

        private void InitGrid()
        {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Ledger_Id = new DataGridViewTextBoxColumn();
            col_Ledger_Id.Name = LEDGER.LEDGER_ID;
            col_Ledger_Id.HeaderText = "LEDGER_ID ";
            col_Ledger_Id.Visible = false;
            col_Ledger_Id.Width = 100;
            col_Ledger_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Ledger_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Ledger_Id);

            DataGridViewTextBoxColumn col_Ledger_name = new DataGridViewTextBoxColumn();
            col_Ledger_name.Name = LEDGER.LEDGER_NAME;
            col_Ledger_name.HeaderText = "LEDGER NAME";
            //col_Ledger_name.Visible = false; 
            col_Ledger_name.Width = 250;
            col_Ledger_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Ledger_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Ledger_name);

            DataGridViewTextBoxColumn col_Ledgergroup_id = new DataGridViewTextBoxColumn();
            col_Ledgergroup_id.Name = LEDGER.LEDGERGROUP_ID;
            col_Ledgergroup_id.HeaderText = "LEDGER GROUP";
            //col_Ledgergroup_id.Visible = false; 
            col_Ledgergroup_id.Width = 250;
            col_Ledgergroup_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Ledgergroup_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Ledgergroup_id);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = LEDGER.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false;
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes);

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = LEDGER.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false;
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id);

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = LEDGER.USER_ID;
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
            if (fledger == null)
            {
                fledger = new FLedger();
            }
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fledger.SetAction(BtnEvent.Open, pkValue);
            }
        }

        #endregion[Grid Action]

        #region[Enter Event]

        private void Txt_ledgertype_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_ledger_name.BackColor = Theme.lbl_EnterBackColor;
            lbl_ledger_name.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_ledger_name.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Change_infocus()
        {
            lbl_ledger_name.BackColor = Theme.lbl_BackColor;
            lbl_ledger_name.BorderColor = Theme.lbl_BorderColor;
            lbl_ledger_name.ForeColor = Theme.lbl_ForeColor;
        }

        #endregion[Enter Event]

        #region[Build Form]

        private void BuildForm()
        {
            if (fledger == null)
            {
                fledger = new FLedger();
            }
            fledger.FLedger_NeedToRefresh += VLedger_NeedToRefresh;
            Parent.Controls.Add(fledger);
            fledger.Dock = DockStyle.Fill;
            fledger.Show();
            fledger.BringToFront();

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
            fledger.SetAction(BtnEvent.New, null);
            fledger.SetFocus();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fledger.SetAction(BtnEvent.Edit, pkValue);
                fledger.SetFocus();
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fledger.SetAction(BtnEvent.Delete, pkValue);
                fledger.SetFocus();
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fledger.SetAction(BtnEvent.Print, pkValue);
                fledger.SetFocus();
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

        public void Ledger_lookup()
        {
            txt_ledger_name.LookupColNames = new string[] { LEDGER.LEDGER_NAME };
            txt_ledger_name.LookupUpdate += txt_ledger_LookupUpdate;
            txt_ledger_name.AllowNewEntry = true;
            txt_ledger_name.NewEntryNeeded += txt_ledger_NewEntryNeeded;
        }
        void txt_ledger_LookupUpdate(object sender, EventArgs e)
        {
            txt_ledger_name.LookupList = CLedger_exten.GetforLookup();
        }
        private FLedger fsledger = null;
        void txt_ledger_NewEntryNeeded(object sender, string pValue)
        {
            if (fsledger == null)
            {
                fsledger = new FLedger();
            }
            Parent.Controls.Add(fsledger);
            fsledger.Dock = DockStyle.Fill;
            fsledger.Show();
            fsledger.BringToFront();
            fsledger.Focus();

            fsledger.SetAction(BtnEvent.New, null);
            fsledger.SetFocus();
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
                selPkValue = vSelRow.Cells[LEDGER.LEDGER_ID].Value.ToString();
            }
            return selPkValue;
        }

        #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VLedger_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        #endregion[RaiseEvent]

    }//cls
}//ns
