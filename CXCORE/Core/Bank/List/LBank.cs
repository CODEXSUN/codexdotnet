// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 11:17:05 PM

using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;

namespace CXCORE
{
    public partial class LBank
    {

        #region[Init Grid]

        private void InitGrid()
        {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Bank_Id = new DataGridViewTextBoxColumn();
            col_Bank_Id.Name = BANK.BANK_ID;
            col_Bank_Id.HeaderText = "BANK_ID ";
            col_Bank_Id.Visible = false;
            col_Bank_Id.Width = 100;
            col_Bank_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Bank_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Bank_Id);

            DataGridViewTextBoxColumn col_sn = new DataGridViewTextBoxColumn();
            col_sn.Name = "SN";
            col_sn.HeaderText = "";
            //col_sn.Visible = false; 
            col_sn.Width = 40;
            col_sn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_sn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_sn);

            DataGridViewTextBoxColumn col_Bank_name = new DataGridViewTextBoxColumn();
            col_Bank_name.Name = BANK.BANK_NAME;
            col_Bank_name.HeaderText = "BANK NAME";
            //col_Bank_name.Visible = false; 
            col_Bank_name.Width = 150;
            col_Bank_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Bank_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Bank_name);

            DataGridViewTextBoxColumn col_Account_number = new DataGridViewTextBoxColumn();
            col_Account_number.Name = BANK.ACCOUNT_NUMBER;
            col_Account_number.HeaderText = "ACCOUNT NUMBER";
            //col_Account_number.Visible = false; 
            col_Account_number.Width = 212;
            col_Account_number.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Account_number.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Account_number);

            DataGridViewTextBoxColumn col_Ifsc_code = new DataGridViewTextBoxColumn();
            col_Ifsc_code.Name = BANK.IFSC_CODE;
            col_Ifsc_code.HeaderText = "IFSC CODE";
            //col_Ifsc_code.Visible = false; 
            col_Ifsc_code.Width = 150;
            col_Ifsc_code.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Ifsc_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Ifsc_code);

            DataGridViewTextBoxColumn col_Opening_balance = new DataGridViewTextBoxColumn();
            col_Opening_balance.Name = BANK.OPENING_BALANCE;
            col_Opening_balance.HeaderText = "OPENING BALANCE";
            //col_Opening_balance.Visible = false; 
            col_Opening_balance.Width = 225;
            col_Opening_balance.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Opening_balance.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Opening_balance);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = BANK.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false;
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes);

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = BANK.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false;
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id);

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = BANK.USER_ID;
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
            if (fbank == null)
            {
                fbank = new FBank();
            }
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fbank.SetAction(BtnEvent.Open, pkValue);
            }
        }

        #endregion[Grid Action]

        #region[Enter Event]

        private void Txt_banktype_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_bank_name.BackColor = Theme.lbl_EnterBackColor;
            lbl_bank_name.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_bank_name.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Change_infocus()
        {
            lbl_bank_name.BackColor = Theme.lbl_BackColor;
            lbl_bank_name.BorderColor = Theme.lbl_BorderColor;
            lbl_bank_name.ForeColor = Theme.lbl_ForeColor;
        }

        #endregion[Enter Event]

        #region[Build Form]

        private void BuildForm()
        {
            if (fbank == null)
            {
                fbank = new FBank();
            }
            fbank.FBank_NeedToRefresh += VBank_NeedToRefresh;
            Parent.Controls.Add(fbank);
            fbank.Dock = DockStyle.Fill;
            fbank.Show();
            fbank.BringToFront();

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
            fbank.SetAction(BtnEvent.New, null);
            fbank.SetFocus();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fbank.SetAction(BtnEvent.Edit, pkValue);
                fbank.SetFocus();
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fbank.SetAction(BtnEvent.Delete, pkValue);
                fbank.SetFocus();
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fbank.SetAction(BtnEvent.Print, pkValue);
                fbank.SetFocus();
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

        public void Bank_lookup()
        {
            txt_bank_name.LookupColNames = new string[] { BANK.BANK_NAME };
            txt_bank_name.LookupUpdate += txt_bank_LookupUpdate;
            txt_bank_name.AllowNewEntry = true;
            txt_bank_name.NewEntryNeeded += txt_bank_NewEntryNeeded;
        }
        void txt_bank_LookupUpdate(object sender, EventArgs e)
        {
            txt_bank_name.LookupList = CBank_exten.GetforLookup(new DAL());
        }
        private FBank fsbank = null;
        void txt_bank_NewEntryNeeded(object sender, string pValue)
        {
            if (fsbank == null)
            {
                fsbank = new FBank();
            }
            Parent.Controls.Add(fsbank);
            fsbank.Dock = DockStyle.Fill;
            fsbank.Show();
            fsbank.BringToFront();
            fsbank.Focus();

            fsbank.SetAction(BtnEvent.New, null);
            fsbank.SetFocus();
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
                selPkValue = vSelRow.Cells[BANK.BANK_ID].Value.ToString();
            }
            return selPkValue;
        }

        #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VBank_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        #endregion[RaiseEvent]

    }//cls
}//ns
