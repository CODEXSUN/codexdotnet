// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 08:46:35 AM

using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;

namespace CXCORE
{
    public partial class LDeliveredto : UserControl
    {

        #region[Init Grid]

        private void InitGrid()
        {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Deliveredto_Id = new DataGridViewTextBoxColumn();
            col_Deliveredto_Id.Name = DELIVEREDTO.DELIVEREDTO_ID;
            col_Deliveredto_Id.HeaderText = "DELIVEREDTO_ID ";
            col_Deliveredto_Id.Visible = false;
            col_Deliveredto_Id.Width = 100;
            col_Deliveredto_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Deliveredto_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Deliveredto_Id);

            DataGridViewTextBoxColumn col_Deliveredto_name = new DataGridViewTextBoxColumn();
            col_Deliveredto_name.Name = DELIVEREDTO.DELIVEREDTO_NAME;
            col_Deliveredto_name.HeaderText = "DELIVERED TO";
            //col_Deliveredto_name.Visible = false; 
            col_Deliveredto_name.Width = 188;
            col_Deliveredto_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Deliveredto_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Deliveredto_name);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = DELIVEREDTO.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false;
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes);

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = DELIVEREDTO.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false;
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id);

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = DELIVEREDTO.USER_ID;
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
            if (fdeliveredto == null)
            {
                fdeliveredto = new FDeliveredto();
            }
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fdeliveredto.SetAction(BtnEvent.Open, pkValue);
            }
        }

        #endregion[Grid Action]

        #region[Enter Event]

        private void Txt_deliveredtotype_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_deliveredto_name.BackColor = Theme.lbl_EnterBackColor;
            lbl_deliveredto_name.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_deliveredto_name.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Change_infocus()
        {
            lbl_deliveredto_name.BackColor = Theme.lbl_BackColor;
            lbl_deliveredto_name.BorderColor = Theme.lbl_BorderColor;
            lbl_deliveredto_name.ForeColor = Theme.lbl_ForeColor;
        }

        #endregion[Enter Event]

        #region[Build Form]

        private void BuildForm()
        {
            if (fdeliveredto == null)
            {
                fdeliveredto = new FDeliveredto();
            }
            fdeliveredto.FDeliveredto_NeedToRefresh += VDeliveredto_NeedToRefresh;
            Parent.Controls.Add(fdeliveredto);
            fdeliveredto.Dock = DockStyle.Fill;
            fdeliveredto.Show();
            fdeliveredto.BringToFront();

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
            fdeliveredto.SetAction(BtnEvent.New, null);
            fdeliveredto.SetFocus();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fdeliveredto.SetAction(BtnEvent.Edit, pkValue);
                fdeliveredto.SetFocus();
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fdeliveredto.SetAction(BtnEvent.Delete, pkValue);
                fdeliveredto.SetFocus();
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fdeliveredto.SetAction(BtnEvent.Print, pkValue);
                fdeliveredto.SetFocus();
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

        public void Deliveredto_lookup()
        {
            txt_deliveredto_name.LookupColNames = new string[] { DELIVEREDTO.DELIVEREDTO_NAME };
            txt_deliveredto_name.LookupUpdate += txt_deliveredto_LookupUpdate;
            txt_deliveredto_name.AllowNewEntry = true;
            txt_deliveredto_name.NewEntryNeeded += txt_deliveredto_NewEntryNeeded;
        }
        void txt_deliveredto_LookupUpdate(object sender, EventArgs e)
        {
            txt_deliveredto_name.LookupList = CDeliveredto_exten.GetforLookup(new DAL());
        }
        private FDeliveredto fsdeliveredto = null;
        void txt_deliveredto_NewEntryNeeded(object sender, string pValue)
        {
            if (fsdeliveredto == null)
            {
                fsdeliveredto = new FDeliveredto();
            }
            Parent.Controls.Add(fsdeliveredto);
            fsdeliveredto.Dock = DockStyle.Fill;
            fsdeliveredto.Show();
            fsdeliveredto.BringToFront();
            fsdeliveredto.Focus();

            fsdeliveredto.SetAction(BtnEvent.New, null);
            fsdeliveredto.SetFocus();
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
                selPkValue = vSelRow.Cells[DELIVEREDTO.DELIVEREDTO_ID].Value.ToString();
            }
            return selPkValue;
        }

        #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VDeliveredto_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        public event EventHandler LDeliveredto_NeedToRefresh;

        public void RaiseEvent_NeedToRefresh()
        {
            LDeliveredto_NeedToRefresh?.Invoke(this, new EventArgs());
        }

        #endregion[RaiseEvent]

    }//cls
}//ns
