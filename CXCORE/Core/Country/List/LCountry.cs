// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 08:45:30 AM

using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;

namespace CXCORE
{
    public partial class LCountry 
    {

        #region[Init Grid]

        private void InitGrid()
        {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Country_Id = new DataGridViewTextBoxColumn();
            col_Country_Id.Name = COUNTRY.COUNTRY_ID;
            col_Country_Id.HeaderText = "COUNTRY_ID ";
            col_Country_Id.Visible = false;
            col_Country_Id.Width = 100;
            col_Country_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Country_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Country_Id);

            DataGridViewTextBoxColumn col_Country_name = new DataGridViewTextBoxColumn();
            col_Country_name.Name = COUNTRY.COUNTRY_NAME;
            col_Country_name.HeaderText = "COUNTRY NAME";
            //col_Country_name.Visible = false; 
            col_Country_name.Width = 188;
            col_Country_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Country_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Country_name);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = COUNTRY.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false;
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes);

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = COUNTRY.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false;
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id);

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = COUNTRY.USER_ID;
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
            if (fcountry == null)
            {
                fcountry = new FCountry();
            }
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fcountry.SetAction(BtnEvent.Open, pkValue);
            }
        }

        #endregion[Grid Action]

        #region[Enter Event]

        private void Txt_countrytype_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_country_name.BackColor = Theme.lbl_EnterBackColor;
            lbl_country_name.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_country_name.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Change_infocus()
        {
            lbl_country_name.BackColor = Theme.lbl_BackColor;
            lbl_country_name.BorderColor = Theme.lbl_BorderColor;
            lbl_country_name.ForeColor = Theme.lbl_ForeColor;
        }

        #endregion[Enter Event]

        #region[Build Form]

        private void BuildForm()
        {
            if (fcountry == null)
            {
                fcountry = new FCountry();
            }
            fcountry.FCountry_NeedToRefresh += VCountry_NeedToRefresh;
            Parent.Controls.Add(fcountry);
            fcountry.Dock = DockStyle.Fill;
            fcountry.Show();
            fcountry.BringToFront();

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
            fcountry.SetAction(BtnEvent.New, null);
            fcountry.SetFocus();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fcountry.SetAction(BtnEvent.Edit, pkValue);
                fcountry.SetFocus();
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fcountry.SetAction(BtnEvent.Delete, pkValue);
                fcountry.SetFocus();
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fcountry.SetAction(BtnEvent.Print, pkValue);
                fcountry.SetFocus();
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

        public void Country_lookup()
        {
            txt_country_name.LookupColNames = new string[] { COUNTRY.COUNTRY_NAME };
            txt_country_name.LookupUpdate += txt_country_LookupUpdate;
            txt_country_name.AllowNewEntry = true;
            txt_country_name.NewEntryNeeded += txt_country_NewEntryNeeded;
        }
        void txt_country_LookupUpdate(object sender, EventArgs e)
        {
            txt_country_name.LookupList = CCountry_exten.GetforLookup(new DAL());
        }
        private FCountry fscountry = null;
        void txt_country_NewEntryNeeded(object sender, string pValue)
        {
            if (fscountry == null)
            {
                fscountry = new FCountry();
            }
            Parent.Controls.Add(fscountry);
            fscountry.Dock = DockStyle.Fill;
            fscountry.Show();
            fscountry.BringToFront();
            fscountry.Focus();

            fscountry.SetAction(BtnEvent.New, null);
            fscountry.SetFocus();
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
                selPkValue = vSelRow.Cells[COUNTRY.COUNTRY_ID].Value.ToString();
            }
            return selPkValue;
        }

        #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VCountry_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        //public event EventHandler LCountry_NeedToRefresh;

        //public void RaiseEvent_NeedToRefresh()
        //{
        //    LCountry_NeedToRefresh?.Invoke(this, new EventArgs());
        //}

        #endregion[RaiseEvent]

    }//cls
}//ns
