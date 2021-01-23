// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 25-12-2017 07:23:38 PM

using System;
using System.Drawing;
using System.Windows.Forms;
using CodexsunLib;

namespace CodexsunCore
{
    public partial class LVoucher : UserControl
    {

        #region[Init Grid]

        private void InitGrid()
        {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Voucher_Id = new DataGridViewTextBoxColumn();
            col_Voucher_Id.Name = VOUCHER.VOUCHER_ID;
            col_Voucher_Id.HeaderText = "VOUCHER_ID ";
            col_Voucher_Id.Visible = false;
            col_Voucher_Id.Width = 100;
            col_Voucher_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Voucher_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Voucher_Id);


            DataGridViewTextBoxColumn col_Voucher_no = new DataGridViewTextBoxColumn();
            col_Voucher_no.Name = VOUCHER.VOUCHER_NO;
            col_Voucher_no.HeaderText = "NO";
            //col_Voucher_no.Visible = false; 
            col_Voucher_no.Width = 60;
            col_Voucher_no.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Voucher_no.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Voucher_no);

            DataGridViewTextBoxColumn col_Voucher_date = new DataGridViewTextBoxColumn();
            col_Voucher_date.Name = VOUCHER.VOUCHER_DATE;
            col_Voucher_date.HeaderText = "DATE";
            //col_Voucher_date.Visible = false; 
            col_Voucher_date.Width = 100;
            col_Voucher_date.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Voucher_date.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Voucher_date);

            DataGridViewTextBoxColumn col_Vouchertype_id = new DataGridViewTextBoxColumn();
            col_Vouchertype_id.Name = VOUCHER.VOUCHERTYPE_ID;
            col_Vouchertype_id.HeaderText = "TYPE";
            //col_Vouchertype_id.Visible = false; 
            col_Vouchertype_id.Width = 158;
            col_Vouchertype_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Vouchertype_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Vouchertype_id);

            DataGridViewTextBoxColumn col_Order_id = new DataGridViewTextBoxColumn();
            col_Order_id.Name = VOUCHER.ORDER_ID;
            col_Order_id.HeaderText = "ORDER Ref";
            //col_Order_id.Visible = false; 
            col_Order_id.Width = 200;
            col_Order_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Order_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Order_id);

            DataGridViewTextBoxColumn col_Ledger_id = new DataGridViewTextBoxColumn();
            col_Ledger_id.Name = VOUCHER.LEDGER_ID;
            col_Ledger_id.HeaderText = "LEDGER ID";
            //col_Ledger_id.Visible = false;
            col_Ledger_id.Width = 150;
            col_Ledger_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Ledger_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Ledger_id);

            DataGridViewTextBoxColumn col_Party_id = new DataGridViewTextBoxColumn();
            col_Party_id.Name = VOUCHER.PARTY_ID;
            col_Party_id.HeaderText = "PARTY";
            //col_Party_id.Visible = false; 
            col_Party_id.Width = 200;
            col_Party_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Party_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Party_id);

            DataGridViewTextBoxColumn col_Purpose = new DataGridViewTextBoxColumn();
            col_Purpose.Name = VOUCHER.PURPOSE;
            col_Purpose.HeaderText = "PURPOSE";
            //col_Purpose.Visible = false; 
            col_Purpose.Width = 200;
            col_Purpose.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Purpose.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Purpose);

            DataGridViewTextBoxColumn col_Debit = new DataGridViewTextBoxColumn();
            col_Debit.Name = VOUCHER.DEBIT;
            col_Debit.HeaderText = "DEBIT";
            //col_Debit.Visible = false; 
            col_Debit.Width = 100;
            col_Debit.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Debit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Debit);

            DataGridViewTextBoxColumn col_Credit = new DataGridViewTextBoxColumn();
            col_Credit.Name = VOUCHER.CREDIT;
            col_Credit.HeaderText = "CREDIT";
            //col_Credit.Visible = false; 
            col_Credit.Width = 100;
            col_Credit.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Credit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Credit);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = VOUCHER.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false;
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes);

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = VOUCHER.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false;
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id);

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = VOUCHER.USER_ID;
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
            if (fvoucher == null)
            {
                fvoucher = new FVoucher();
            }
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fvoucher.SetAction(BtnEvent.Open, pkValue);
            }
        }

        #endregion[Grid Action]

        #region[Build Form]

        private void BuildForm()
        {
            if (fvoucher == null)
            {
                fvoucher = new FVoucher();
            }
            fvoucher.FVoucher_NeedToRefresh += VVoucher_NeedToRefresh;
            Parent.Controls.Add(fvoucher);
            fvoucher.Dock = DockStyle.Fill;
            fvoucher.Show();
            fvoucher.BringToFront();

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
            fvoucher.SetAction(BtnEvent.New, null);
            fvoucher.SetFocus();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fvoucher.SetAction(BtnEvent.Edit, pkValue);
                fvoucher.SetFocus();
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fvoucher.SetAction(BtnEvent.Delete, pkValue);
                fvoucher.SetFocus();
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fvoucher.SetAction(BtnEvent.Print, pkValue);
                fvoucher.SetFocus();
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

        #region[voucher_no lookup] 

        public void Voucher_no_lookup()
        {
            txt_voucher_no.LookupColNames = new string[] { VOUCHER.VOUCHER_NO };
            txt_voucher_no.LookupUpdate += Txt_voucher_no_LookupUpdate;
        }
        void Txt_voucher_no_LookupUpdate(object sender, EventArgs e)
        {
            txt_voucher_no.LookupList = CVoucher_exten.Voucher_no_lookup(new DAL());
            txt_voucher_no_1.LookupList = CVoucher_exten.Voucher_no_lookup(new DAL());
        }

        #endregion[voucher_no lookup] 

        #region[voucher_no_1 lookup] 

        public void Voucher_no_1_lookup()
        {
            txt_voucher_no_1.LookupColNames = new string[] { VOUCHER.VOUCHER_NO };
            txt_voucher_no_1.LookupUpdate += Txt_voucher_no_1_LookupUpdate;
        }
        void Txt_voucher_no_1_LookupUpdate(object sender, EventArgs e)
        {
            txt_voucher_no_1.LookupList = CVoucher_exten.Voucher_no_lookup(new DAL());
        }

        #endregion[voucher_no lookup] 

        #region[voucher_date lookup] 

        public void Voucher_date_lookup()
        {
            txt_voucher_date.LookupColNames = new string[] { VOUCHER.VOUCHER_DATE };
            txt_voucher_date.LookupUpdate += Txt_voucher_date_LookupUpdate;
        }
        void Txt_voucher_date_LookupUpdate(object sender, EventArgs e)
        {
            txt_voucher_date.LookupList = CVoucher_exten.Voucher_date_lookup(new DAL());
            txt_voucher_date_1.LookupList = CVoucher_exten.Voucher_date_lookup(new DAL());
        }

        #endregion[voucher_date lookup] 

        #region[voucher_date_1 lookup] 

        public void Voucher_date_1_lookup()
        {
            txt_voucher_date_1.LookupColNames = new string[] { VOUCHER.VOUCHER_DATE };
            txt_voucher_date_1.LookupUpdate += Txt_voucher_date_1_LookupUpdate;
        }
        void Txt_voucher_date_1_LookupUpdate(object sender, EventArgs e)
        {
            txt_voucher_date_1.LookupList = CVoucher_exten.Voucher_date_lookup(new DAL());
        }

        #endregion[voucher_date_1 lookup] 

        #region[vouchertype lookup] 

        public void Vouchertype_lookup()
        {
            txt_vouchertype.LookupColNames = new string[] { VOUCHERTYPE.VOUCHERTYPE_NAME};
            txt_vouchertype.LookupUpdate += Txt_vouchertype_LookupUpdate;
        }
        void Txt_vouchertype_LookupUpdate(object sender, EventArgs e)
        {
            txt_vouchertype.LookupList = CVoucher_exten.Vouchertype_lookup(new DAL());
        }

        #endregion[vouchertype lookup] 

        #region[orderref lookup] 

        public void Orderref_lookup()
        {
            txt_orderref.LookupColNames = new string[] { ORDER.ORDER_NAME};
            txt_orderref.LookupUpdate += Txt_orderref_LookupUpdate;
        }
        void Txt_orderref_LookupUpdate(object sender, EventArgs e)
        {
            txt_orderref.LookupList = CVoucher_exten.Orderref_lookup(new DAL());
        }

        #endregion[orderref lookup] 

        #region[ledger lookup] 

        public void Ledger_lookup()
        {
            txt_ledger.LookupColNames = new string[] { LEDGER.LEDGER_NAME};
            txt_ledger.LookupUpdate += Txt_ledger_LookupUpdate;
        }
        void Txt_ledger_LookupUpdate(object sender, EventArgs e)
        {
            txt_ledger.LookupList = CVoucher_exten.Ledger_lookup(new DAL());
        }

        #endregion[ledger lookup] 

        #region[party lookup] 

        public void Party_lookup()
        {
            txt_party.LookupColNames = new string[] { PARTY.PARTY_NAME };
            txt_party.LookupUpdate += Txt_party_LookupUpdate;
        }
        void Txt_party_LookupUpdate(object sender, EventArgs e)
        {
            txt_party.LookupList = CVoucher_exten.Party_lookup(new DAL());
        }

        #endregion[party lookup] 

        #region[purpose lookup] 

        public void Purpose_lookup()
        {
            txt_purpose.LookupColNames = new string[] { VOUCHER.PURPOSE};
            txt_purpose.LookupUpdate += Txt_purpose_LookupUpdate;
        }
        void Txt_purpose_LookupUpdate(object sender, EventArgs e)
        {
            txt_purpose.LookupList = CVoucher_exten.Purpose_lookup(new DAL());
        }

        #endregion[purpose lookup] 

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
                selPkValue = vSelRow.Cells[VOUCHER.VOUCHER_ID].Value.ToString();
            }
            return selPkValue;
        }

        #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VVoucher_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }
        public event EventHandler LVoucher_NeedToRefresh;
        public void RaiseEvent_NeedToRefresh()
        {
            if (LVoucher_NeedToRefresh != null)
            {
                LVoucher_NeedToRefresh(this, new EventArgs());
            }
        }

        #endregion[RaiseEvent]

    }//cls
}//ns
