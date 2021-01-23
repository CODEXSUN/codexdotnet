// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:07:41 AM

using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;

namespace CXCORE
{
    public partial class LReceipttype : UserControl
    {

        #region[Init Grid]

        private void InitGrid()
        {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Receipttype_Id = new DataGridViewTextBoxColumn();
            col_Receipttype_Id.Name = RECEIPTTYPE.RECEIPTTYPE_ID;
            col_Receipttype_Id.HeaderText = "RECEIPTTYPE_ID ";
            col_Receipttype_Id.Visible = false;
            col_Receipttype_Id.Width = 100;
            col_Receipttype_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Receipttype_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Receipttype_Id);

            DataGridViewTextBoxColumn col_Receipttype_name = new DataGridViewTextBoxColumn();
            col_Receipttype_name.Name = RECEIPTTYPE.RECEIPTTYPE_NAME;
            col_Receipttype_name.HeaderText = "RECEIPTTYPE NAME";
            //col_Receipttype_name.Visible = false; 
            col_Receipttype_name.Width = 238;
            col_Receipttype_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Receipttype_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Receipttype_name);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = RECEIPTTYPE.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false;
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes);

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = RECEIPTTYPE.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false;
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id);

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = RECEIPTTYPE.USER_ID;
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
            if (freceipttype == null)
            {
                freceipttype = new FReceipttype();
            }
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                freceipttype.SetAction(BtnEvent.Open, pkValue);
            }
        }

        #endregion[Grid Action]

        #region[Enter Event]

        private void Txt_receipttypetype_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_receipttype_name.BackColor = Theme.lbl_EnterBackColor;
            lbl_receipttype_name.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_receipttype_name.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Change_infocus()
        {
            lbl_receipttype_name.BackColor = Theme.lbl_BackColor;
            lbl_receipttype_name.BorderColor = Theme.lbl_BorderColor;
            lbl_receipttype_name.ForeColor = Theme.lbl_ForeColor;
        }

        #endregion[Enter Event]

        #region[Build Form]

        private void BuildForm()
        {
            if (freceipttype == null)
            {
                freceipttype = new FReceipttype();
            }
            freceipttype.FReceipttype_NeedToRefresh += VReceipttype_NeedToRefresh;
            Parent.Controls.Add(freceipttype);
            freceipttype.Dock = DockStyle.Fill;
            freceipttype.Show();
            freceipttype.BringToFront();

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
            freceipttype.SetAction(BtnEvent.New, null);
            freceipttype.SetFocus();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                freceipttype.SetAction(BtnEvent.Edit, pkValue);
                freceipttype.SetFocus();
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                freceipttype.SetAction(BtnEvent.Delete, pkValue);
                freceipttype.SetFocus();
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                freceipttype.SetAction(BtnEvent.Print, pkValue);
                freceipttype.SetFocus();
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

        public void Receipttype_lookup()
        {
            txt_receipttype_name.LookupColNames = new string[] { RECEIPTTYPE.RECEIPTTYPE_NAME };
            txt_receipttype_name.LookupUpdate += txt_receipttype_LookupUpdate;
            txt_receipttype_name.AllowNewEntry = true;
            txt_receipttype_name.NewEntryNeeded += txt_receipttype_NewEntryNeeded;
        }
        void txt_receipttype_LookupUpdate(object sender, EventArgs e)
        {
            txt_receipttype_name.LookupList = CReceipttype_exten.GetforLookup(new DAL());
        }
        private FReceipttype fsreceipttype = null;
        void txt_receipttype_NewEntryNeeded(object sender, string pValue)
        {
            if (fsreceipttype == null)
            {
                fsreceipttype = new FReceipttype();
            }
            Parent.Controls.Add(fsreceipttype);
            fsreceipttype.Dock = DockStyle.Fill;
            fsreceipttype.Show();
            fsreceipttype.BringToFront();
            fsreceipttype.Focus();

            fsreceipttype.SetAction(BtnEvent.New, null);
            fsreceipttype.SetFocus();
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
                selPkValue = vSelRow.Cells[RECEIPTTYPE.RECEIPTTYPE_ID].Value.ToString();
            }
            return selPkValue;
        }

        #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VReceipttype_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        public event EventHandler LReceipttype_NeedToRefresh;

        public void RaiseEvent_NeedToRefresh()
        {
            LReceipttype_NeedToRefresh?.Invoke(this, new EventArgs());
        }

        #endregion[RaiseEvent]

    }//cls
}//ns
