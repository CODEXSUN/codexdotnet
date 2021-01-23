// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:11:05 AM

using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;

namespace CXCORE
{
    public partial class LSalestype 
    {

        #region[Init Grid]

        private void InitGrid()
        {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Salestype_Id = new DataGridViewTextBoxColumn();
            col_Salestype_Id.Name = SALESTYPE.SALESTYPE_ID;
            col_Salestype_Id.HeaderText = "SALESTYPE_ID ";
            col_Salestype_Id.Visible = false;
            col_Salestype_Id.Width = 100;
            col_Salestype_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Salestype_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Salestype_Id);

            DataGridViewTextBoxColumn col_Salestype_name = new DataGridViewTextBoxColumn();
            col_Salestype_name.Name = SALESTYPE.SALESTYPE_NAME;
            col_Salestype_name.HeaderText = "SALES TYPE";
            //col_Salestype_name.Visible = false; 
            col_Salestype_name.Width = 162;
            col_Salestype_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Salestype_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Salestype_name);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = SALESTYPE.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false;
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes);

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = SALESTYPE.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false;
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id);

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = SALESTYPE.USER_ID;
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
            if (fsalestype == null)
            {
                fsalestype = new FSalestype();
            }
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fsalestype.SetAction(BtnEvent.Open, pkValue);
            }
        }

        #endregion[Grid Action]

        #region[Enter Event]

        private void Txt_salestypetype_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_salestype_name.BackColor = Theme.lbl_EnterBackColor;
            lbl_salestype_name.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_salestype_name.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Change_infocus()
        {
            lbl_salestype_name.BackColor = Theme.lbl_BackColor;
            lbl_salestype_name.BorderColor = Theme.lbl_BorderColor;
            lbl_salestype_name.ForeColor = Theme.lbl_ForeColor;
        }

        #endregion[Enter Event]

        #region[Build Form]

        private void BuildForm()
        {
            if (fsalestype == null)
            {
                fsalestype = new FSalestype();
            }
            fsalestype.FSalestype_NeedToRefresh += VSalestype_NeedToRefresh;
            Parent.Controls.Add(fsalestype);
            fsalestype.Dock = DockStyle.Fill;
            fsalestype.Show();
            fsalestype.BringToFront();

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
            fsalestype.SetAction(BtnEvent.New, null);
            fsalestype.SetFocus();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fsalestype.SetAction(BtnEvent.Edit, pkValue);
                fsalestype.SetFocus();
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fsalestype.SetAction(BtnEvent.Delete, pkValue);
                fsalestype.SetFocus();
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fsalestype.SetAction(BtnEvent.Print, pkValue);
                fsalestype.SetFocus();
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

        public void Salestype_lookup()
        {
            txt_salestype_name.LookupColNames = new string[] { SALESTYPE.SALESTYPE_NAME };
            txt_salestype_name.LookupUpdate += txt_salestype_LookupUpdate;
            txt_salestype_name.AllowNewEntry = true;
            txt_salestype_name.NewEntryNeeded += txt_salestype_NewEntryNeeded;
        }
        void txt_salestype_LookupUpdate(object sender, EventArgs e)
        {
            txt_salestype_name.LookupList = CSalestype_exten.GetforLookup(new DAL());
        }
        private FSalestype fssalestype = null;
        void txt_salestype_NewEntryNeeded(object sender, string pValue)
        {
            if (fssalestype == null)
            {
                fssalestype = new FSalestype();
            }
            Parent.Controls.Add(fssalestype);
            fssalestype.Dock = DockStyle.Fill;
            fssalestype.Show();
            fssalestype.BringToFront();
            fssalestype.Focus();

            fssalestype.SetAction(BtnEvent.New, null);
            fssalestype.SetFocus();
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
                selPkValue = vSelRow.Cells[SALESTYPE.SALESTYPE_ID].Value.ToString();
            }
            return selPkValue;
        }

        #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VSalestype_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        #endregion[RaiseEvent]

    }//cls
}//ns
