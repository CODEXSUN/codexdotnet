// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:22:56 AM

using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;

namespace CXCORE
{
    public partial class LTransport : UserControl
    {

        #region[Init Grid]

        private void InitGrid()
        {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Transport_Id = new DataGridViewTextBoxColumn();
            col_Transport_Id.Name = TRANSPORT.TRANSPORT_ID;
            col_Transport_Id.HeaderText = "TRANSPORT_ID ";
            col_Transport_Id.Visible = false;
            col_Transport_Id.Width = 100;
            col_Transport_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Transport_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Transport_Id);

            DataGridViewTextBoxColumn col_Transport_name = new DataGridViewTextBoxColumn();
            col_Transport_name.Name = TRANSPORT.TRANSPORT_NAME;
            col_Transport_name.HeaderText = "TRANSPORT NAME";
            //col_Transport_name.Visible = false; 
            col_Transport_name.Width = 212;
            col_Transport_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Transport_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Transport_name);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = TRANSPORT.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false;
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes);

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = TRANSPORT.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false;
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id);

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = TRANSPORT.USER_ID;
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
            if (ftransport == null)
            {
                ftransport = new FTransport();
            }
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                ftransport.SetAction(BtnEvent.Open, pkValue);
            }
        }

        #endregion[Grid Action]

        #region[Enter Event]

        private void Txt_transporttype_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_transport_name.BackColor = Theme.lbl_EnterBackColor;
            lbl_transport_name.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_transport_name.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Change_infocus()
        {
            lbl_transport_name.BackColor = Theme.lbl_BackColor;
            lbl_transport_name.BorderColor = Theme.lbl_BorderColor;
            lbl_transport_name.ForeColor = Theme.lbl_ForeColor;
        }

        #endregion[Enter Event]

        #region[Build Form]

        private void BuildForm()
        {
            if (ftransport == null)
            {
                ftransport = new FTransport();
            }
            ftransport.FTransport_NeedToRefresh += VTransport_NeedToRefresh;
            Parent.Controls.Add(ftransport);
            ftransport.Dock = DockStyle.Fill;
            ftransport.Show();
            ftransport.BringToFront();

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
            ftransport.SetAction(BtnEvent.New, null);
            ftransport.SetFocus();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                ftransport.SetAction(BtnEvent.Edit, pkValue);
                ftransport.SetFocus();
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                ftransport.SetAction(BtnEvent.Delete, pkValue);
                ftransport.SetFocus();
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                ftransport.SetAction(BtnEvent.Print, pkValue);
                ftransport.SetFocus();
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

        public void Transport_lookup()
        {
            txt_transport_name.LookupColNames = new string[] { TRANSPORT.TRANSPORT_NAME };
            txt_transport_name.LookupUpdate += txt_transport_LookupUpdate;
            txt_transport_name.AllowNewEntry = true;
            txt_transport_name.NewEntryNeeded += txt_transport_NewEntryNeeded;
        }
        void txt_transport_LookupUpdate(object sender, EventArgs e)
        {
            txt_transport_name.LookupList = CTransport_exten.GetforLookup(new DAL());
        }
        private FTransport fstransport = null;
        void txt_transport_NewEntryNeeded(object sender, string pValue)
        {
            if (fstransport == null)
            {
                fstransport = new FTransport();
            }
            Parent.Controls.Add(fstransport);
            fstransport.Dock = DockStyle.Fill;
            fstransport.Show();
            fstransport.BringToFront();
            fstransport.Focus();

            fstransport.SetAction(BtnEvent.New, null);
            fstransport.SetFocus();
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
                selPkValue = vSelRow.Cells[TRANSPORT.TRANSPORT_ID].Value.ToString();
            }
            return selPkValue;
        }

        #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VTransport_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        public event EventHandler LTransport_NeedToRefresh;

        public void RaiseEvent_NeedToRefresh()
        {
            LTransport_NeedToRefresh?.Invoke(this, new EventArgs());
        }

        #endregion[RaiseEvent]

    }//cls
}//ns
