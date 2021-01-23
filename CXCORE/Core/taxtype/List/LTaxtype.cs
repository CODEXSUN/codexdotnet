// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:22:51 AM

using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;

namespace CXCORE
{
    public partial class LTaxtype
    {

        #region[Init Grid]

        private void InitGrid()
        {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Taxtype_Id = new DataGridViewTextBoxColumn();
            col_Taxtype_Id.Name = TAXTYPE.TAXTYPE_ID;
            col_Taxtype_Id.HeaderText = "TAXTYPE_ID ";
            col_Taxtype_Id.Visible = false;
            col_Taxtype_Id.Width = 100;
            col_Taxtype_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Taxtype_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Taxtype_Id);

            DataGridViewTextBoxColumn col_Taxtype_name = new DataGridViewTextBoxColumn();
            col_Taxtype_name.Name = TAXTYPE.TAXTYPE_NAME;
            col_Taxtype_name.HeaderText = "TAX TYPE";
            //col_Taxtype_name.Visible = false; 
            col_Taxtype_name.Width = 100;
            col_Taxtype_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Taxtype_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Taxtype_name);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = TAXTYPE.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false;
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes);

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = TAXTYPE.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false;
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id);

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = TAXTYPE.USER_ID;
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
            if (ftaxtype == null)
            {
                ftaxtype = new FTaxtype();
            }
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                ftaxtype.SetAction(BtnEvent.Open, pkValue);
            }
        }

        #endregion[Grid Action]

        #region[Enter Event]

        private void Txt_taxtypetype_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_taxtype_name.BackColor = Theme.lbl_EnterBackColor;
            lbl_taxtype_name.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_taxtype_name.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Change_infocus()
        {
            lbl_taxtype_name.BackColor = Theme.lbl_BackColor;
            lbl_taxtype_name.BorderColor = Theme.lbl_BorderColor;
            lbl_taxtype_name.ForeColor = Theme.lbl_ForeColor;
        }

        #endregion[Enter Event]

        #region[Build Form]

        private void BuildForm()
        {
            if (ftaxtype == null)
            {
                ftaxtype = new FTaxtype();
            }
            ftaxtype.FTaxtype_NeedToRefresh += VTaxtype_NeedToRefresh;
            Parent.Controls.Add(ftaxtype);
            ftaxtype.Dock = DockStyle.Fill;
            ftaxtype.Show();
            ftaxtype.BringToFront();

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
            ftaxtype.SetAction(BtnEvent.New, null);
            ftaxtype.SetFocus();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                ftaxtype.SetAction(BtnEvent.Edit, pkValue);
                ftaxtype.SetFocus();
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                ftaxtype.SetAction(BtnEvent.Delete, pkValue);
                ftaxtype.SetFocus();
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                ftaxtype.SetAction(BtnEvent.Print, pkValue);
                ftaxtype.SetFocus();
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

        public void Taxtype_lookup()
        {
            txt_taxtype_name.LookupColNames = new string[] { TAXTYPE.TAXTYPE_NAME };
            txt_taxtype_name.LookupUpdate += Txt_taxtype_LookupUpdate;
            txt_taxtype_name.AllowNewEntry = true;
            txt_taxtype_name.NewEntryNeeded += Txt_taxtype_NewEntryNeeded;
        }
        void Txt_taxtype_LookupUpdate(object sender, EventArgs e)
        {
            txt_taxtype_name.LookupList = CTaxtype_exten.GetforLookup(new DAL());
        }
        private FTaxtype fstaxtype = null;
        void Txt_taxtype_NewEntryNeeded(object sender, string pValue)
        {
            if (fstaxtype == null)
            {
                fstaxtype = new FTaxtype();
            }
            Parent.Controls.Add(fstaxtype);
            fstaxtype.Dock = DockStyle.Fill;
            fstaxtype.Show();
            fstaxtype.BringToFront();
            fstaxtype.Focus();

            fstaxtype.SetAction(BtnEvent.New, null);
            fstaxtype.SetFocus();
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
                selPkValue = vSelRow.Cells[TAXTYPE.TAXTYPE_ID].Value.ToString();
            }
            return selPkValue;
        }

        #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VTaxtype_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        #endregion[RaiseEvent]

    }//cls
}//ns
