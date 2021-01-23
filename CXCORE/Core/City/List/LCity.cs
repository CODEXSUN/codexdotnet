// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 11:17:33 PM

using System; 
using System.Drawing; 
using System.Windows.Forms; 
using CXLIB; 
 
namespace CXCORE 
{ 
    public partial class LCity : CxControl 
    { 

         #region[Init Grid]

         private void InitGrid()
         {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_City_Id = new DataGridViewTextBoxColumn();
            col_City_Id.Name = CITY.CITY_ID;
            col_City_Id.HeaderText = "CITY_ID ";
            col_City_Id.Visible = false; 
            col_City_Id.Width = 100;
            col_City_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_City_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_City_Id );

            DataGridViewTextBoxColumn col_City_name = new DataGridViewTextBoxColumn();
            col_City_name.Name = CITY.CITY_NAME;
            col_City_name.HeaderText = "CITY NAME";
            //col_City_name.Visible = false; 
            col_City_name.Width = 150;
            col_City_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_City_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_City_name);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = CITY.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false; 
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes );

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = CITY.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false; 
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id );

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = CITY.USER_ID;
            col_User_Id.HeaderText = "ENTRY BY";
            //col_User_Id.Visible = false; 
            col_User_Id.Width = 120;
            col_User_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_User_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_User_Id );

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
             if (fcity == null)
             {
                 fcity = new FCity();
             }
             BuildForm();
             string pkValue = GetSelectedPkValue();
             if (pkValue != null)
             {
                 fcity.SetAction(BtnEvent.Open, pkValue);
             }
         }

         #endregion[Grid Action]

         #region[Enter Event]

         private void Txt_citytype_Enter(object sender, EventArgs e)
         {
             Change_infocus();
             lbl_city_name.BackColor = Theme.lbl_EnterBackColor;
             lbl_city_name.BorderColor = Theme.lbl_EnterBorderColor;
             lbl_city_name.ForeColor = Theme.lbl_EnterForeColor;
         }
         private void Change_infocus()
         {
             lbl_city_name.BackColor = Theme.lbl_BackColor;
             lbl_city_name.BorderColor = Theme.lbl_BorderColor;
             lbl_city_name.ForeColor = Theme.lbl_ForeColor;
         }

         #endregion[Enter Event]

         #region[Build Form]

         private void BuildForm()
         {
             if (fcity == null)
             {
                 fcity = new FCity();
             }
             fcity.FCity_NeedToRefresh += VCity_NeedToRefresh;
             Parent.Controls.Add(fcity);
             fcity.Dock = DockStyle.Fill;
             fcity.Show();
             fcity.BringToFront();
             
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
                fcity.SetAction(BtnEvent.New, null); 
                fcity.SetFocus(); 
        } 

        private void Btn_edit_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fcity.SetAction(BtnEvent.Edit, pkValue); 
                fcity.SetFocus(); 
            } 
        } 

        private void Btn_delete_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fcity.SetAction(BtnEvent.Delete, pkValue); 
                fcity.SetFocus(); 
            } 
        } 

        private void Btn_print_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fcity.SetAction(BtnEvent.Print, pkValue); 
                fcity.SetFocus(); 
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

         public void City_lookup()
         {
             txt_city_name.LookupColNames = new string[] { CITY.CITY_NAME };
             txt_city_name.LookupUpdate += txt_city_LookupUpdate;
             txt_city_name.AllowNewEntry = true;
             txt_city_name.NewEntryNeeded += txt_city_NewEntryNeeded;
         }
         void txt_city_LookupUpdate(object sender, EventArgs e)
         {
             txt_city_name.LookupList = CCity_exten.GetforLookup(new DAL());
         }
         private FCity fscity = null;
         void txt_city_NewEntryNeeded(object sender, string pValue)
         {
             if (fscity == null)
             {
                 fscity = new FCity();
             }
             Parent.Controls.Add(fscity);
             fscity.Dock = DockStyle.Fill;
             fscity.Show();
             fscity.BringToFront();
             fscity.Focus();
             
             fscity.SetAction(BtnEvent.New, null);
             fscity.SetFocus();
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
                 selPkValue = vSelRow.Cells[CITY.CITY_ID].Value.ToString();
             }
             return selPkValue;
         }

         #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VCity_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        //public event EventHandler LCity_NeedToRefresh;

        //public void RaiseEvent_NeedToRefresh()
        //{
        //    LCity_NeedToRefresh?.Invoke(this, new EventArgs());
        //}

        #endregion[RaiseEvent]

    }//cls
}//ns
