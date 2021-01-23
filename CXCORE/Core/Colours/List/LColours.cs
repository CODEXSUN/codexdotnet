// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 08:38:20 AM

using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;

namespace CXCORE
{
    public partial class LColours : UserControl
    {

        #region[Init Grid]

        private void InitGrid()
        {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Colours_Id = new DataGridViewTextBoxColumn();
            col_Colours_Id.Name = COLOURS.COLOURS_ID;
            col_Colours_Id.HeaderText = "COLOURS_ID ";
            col_Colours_Id.Visible = false;
            col_Colours_Id.Width = 100;
            col_Colours_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Colours_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Colours_Id);

            DataGridViewTextBoxColumn col_Colours_name = new DataGridViewTextBoxColumn();
            col_Colours_name.Name = COLOURS.COLOURS_NAME;
            col_Colours_name.HeaderText = "COLOURS NAME";
            //col_Colours_name.Visible = false; 
            col_Colours_name.Width = 188;
            col_Colours_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Colours_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Colours_name);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = COLOURS.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false;
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes);

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = COLOURS.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false;
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id);

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = COLOURS.USER_ID;
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
            if (fcolours == null)
            {
                fcolours = new FColours();
            }
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fcolours.SetAction(BtnEvent.Open, pkValue);
            }
        }

        #endregion[Grid Action]

        #region[Enter Event]

        private void Txt_colourstype_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_colours_name.BackColor = Theme.lbl_EnterBackColor;
            lbl_colours_name.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_colours_name.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Change_infocus()
        {
            lbl_colours_name.BackColor = Theme.lbl_BackColor;
            lbl_colours_name.BorderColor = Theme.lbl_BorderColor;
            lbl_colours_name.ForeColor = Theme.lbl_ForeColor;
        }

        #endregion[Enter Event]

        #region[Build Form]

        private void BuildForm()
        {
            if (fcolours == null)
            {
                fcolours = new FColours();
            }
            fcolours.FColours_NeedToRefresh += VColours_NeedToRefresh;
            Parent.Controls.Add(fcolours);
            fcolours.Dock = DockStyle.Fill;
            fcolours.Show();
            fcolours.BringToFront();

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
            fcolours.SetAction(BtnEvent.New, null);
            fcolours.SetFocus();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fcolours.SetAction(BtnEvent.Edit, pkValue);
                fcolours.SetFocus();
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fcolours.SetAction(BtnEvent.Delete, pkValue);
                fcolours.SetFocus();
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fcolours.SetAction(BtnEvent.Print, pkValue);
                fcolours.SetFocus();
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

        public void Colours_lookup()
        {
            txt_colours_name.LookupColNames = new string[] { COLOURS.COLOURS_NAME };
            txt_colours_name.LookupUpdate += txt_colours_LookupUpdate;
            txt_colours_name.AllowNewEntry = true;
            txt_colours_name.NewEntryNeeded += txt_colours_NewEntryNeeded;
        }
        void txt_colours_LookupUpdate(object sender, EventArgs e)
        {
            txt_colours_name.LookupList = CColours_exten.GetforLookup(new DAL());
        }
        private FColours fscolours = null;
        void txt_colours_NewEntryNeeded(object sender, string pValue)
        {
            if (fscolours == null)
            {
                fscolours = new FColours();
            }
            Parent.Controls.Add(fscolours);
            fscolours.Dock = DockStyle.Fill;
            fscolours.Show();
            fscolours.BringToFront();
            fscolours.Focus();

            fscolours.SetAction(BtnEvent.New, null);
            fscolours.SetFocus();
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
                selPkValue = vSelRow.Cells[COLOURS.COLOURS_ID].Value.ToString();
            }
            return selPkValue;
        }

        #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VColours_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        public event EventHandler LColours_NeedToRefresh;

        public void RaiseEvent_NeedToRefresh()
        {
            LColours_NeedToRefresh?.Invoke(this, new EventArgs());
        }

        #endregion[RaiseEvent]

    }//cls
}//ns
