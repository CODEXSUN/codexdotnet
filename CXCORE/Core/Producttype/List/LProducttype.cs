// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 10:33:13 PM

using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;

namespace CXCORE
{
    public partial class LProducttype 
    {

        #region[Init Grid]

        private void InitGrid()
        {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Producttype_Id = new DataGridViewTextBoxColumn();
            col_Producttype_Id.Name = PRODUCTTYPE.PRODUCTTYPE_ID;
            col_Producttype_Id.HeaderText = "PRODUCTTYPE_ID ";
            col_Producttype_Id.Visible = false;
            col_Producttype_Id.Width = 100;
            col_Producttype_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Producttype_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Producttype_Id);

            DataGridViewTextBoxColumn col_Producttype_name = new DataGridViewTextBoxColumn();
            col_Producttype_name.Name = PRODUCTTYPE.PRODUCTTYPE_NAME;
            col_Producttype_name.HeaderText = "PRODUCT TYPE";
            //col_Producttype_name.Visible = false; 
            col_Producttype_name.Width = 188;
            col_Producttype_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Producttype_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Producttype_name);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = PRODUCTTYPE.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false;
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes);

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = PRODUCTTYPE.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false;
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id);

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = PRODUCTTYPE.USER_ID;
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
            if (fproducttype == null)
            {
                fproducttype = new FProducttype();
            }
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fproducttype.SetAction(BtnEvent.Open, pkValue);
            }
        }

        #endregion[Grid Action]

        #region[Enter Event]

        private void Txt_producttypetype_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_producttype_name.BackColor = Theme.lbl_EnterBackColor;
            lbl_producttype_name.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_producttype_name.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Change_infocus()
        {
            lbl_producttype_name.BackColor = Theme.lbl_BackColor;
            lbl_producttype_name.BorderColor = Theme.lbl_BorderColor;
            lbl_producttype_name.ForeColor = Theme.lbl_ForeColor;
        }

        #endregion[Enter Event]

        #region[Build Form]

        private void BuildForm()
        {
            if (fproducttype == null)
            {
                fproducttype = new FProducttype();
            }
            fproducttype.FProducttype_NeedToRefresh += VProducttype_NeedToRefresh;
            Parent.Controls.Add(fproducttype);
            fproducttype.Dock = DockStyle.Fill;
            fproducttype.Show();
            fproducttype.BringToFront();

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
            fproducttype.SetAction(BtnEvent.New, null);
            fproducttype.SetFocus();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fproducttype.SetAction(BtnEvent.Edit, pkValue);
                fproducttype.SetFocus();
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fproducttype.SetAction(BtnEvent.Delete, pkValue);
                fproducttype.SetFocus();
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fproducttype.SetAction(BtnEvent.Print, pkValue);
                fproducttype.SetFocus();
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

        public void Producttype_lookup()
        {
            txt_producttype_name.LookupColNames = new string[] { PRODUCTTYPE.PRODUCTTYPE_NAME };
            txt_producttype_name.LookupUpdate += txt_producttype_LookupUpdate;
            txt_producttype_name.AllowNewEntry = true;
            txt_producttype_name.NewEntryNeeded += txt_producttype_NewEntryNeeded;
        }
        void txt_producttype_LookupUpdate(object sender, EventArgs e)
        {
            txt_producttype_name.LookupList = CProducttype_exten.GetforLookup(new DAL());
        }
        private FProducttype fsproducttype = null;
        void txt_producttype_NewEntryNeeded(object sender, string pValue)
        {
            if (fsproducttype == null)
            {
                fsproducttype = new FProducttype();
            }
            Parent.Controls.Add(fsproducttype);
            fsproducttype.Dock = DockStyle.Fill;
            fsproducttype.Show();
            fsproducttype.BringToFront();
            fsproducttype.Focus();

            fsproducttype.SetAction(BtnEvent.New, null);
            fsproducttype.SetFocus();
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
                selPkValue = vSelRow.Cells[PRODUCTTYPE.PRODUCTTYPE_ID].Value.ToString();
            }
            return selPkValue;
        }

        #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VProducttype_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        #endregion[RaiseEvent]

    }//cls
}//ns
