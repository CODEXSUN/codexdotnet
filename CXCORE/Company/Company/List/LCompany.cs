// Version : 4.0.0.2 Date : 10-08-2020
// Auto Generated
// last update : 10-08-2020 07:17:11 PM

using System; 
using System.Drawing; 
using System.Windows.Forms; 
using CXLIB; 
 
namespace CXCORE 
{ 
    public partial class LCompany
    { 

         #region[Init Grid]

         private void InitGrid()
         {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Company_Id = new DataGridViewTextBoxColumn();
            col_Company_Id.Name = COMPANY.COMPANY_ID;
            col_Company_Id.HeaderText = "COMPANY_ID ";
            col_Company_Id.Visible = false; 
            col_Company_Id.Width = 100;
            col_Company_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Company_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Company_Id );

            DataGridViewTextBoxColumn col_Company_name = new DataGridViewTextBoxColumn();
            col_Company_name.Name = COMPANY.COMPANY_NAME;
            col_Company_name.HeaderText = "COMPANY NAME";
            //col_Company_name.Visible = false; 
            col_Company_name.Width = 188;
            col_Company_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Company_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Company_name);

            DataGridViewTextBoxColumn col_Display_name = new DataGridViewTextBoxColumn();
            col_Display_name.Name = COMPANY.DISPLAY_NAME;
            col_Display_name.HeaderText = "DISPLAY NAME";
            //col_Display_name.Visible = false; 
            col_Display_name.Width = 188;
            col_Display_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Display_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Display_name);

            DataGridViewTextBoxColumn col_Street1 = new DataGridViewTextBoxColumn();
            col_Street1.Name = COMPANY.STREET1;
            col_Street1.HeaderText = "STREET1";
            //col_Street1.Visible = false; 
            col_Street1.Width = 100;
            col_Street1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Street1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Street1);

            DataGridViewTextBoxColumn col_Street2 = new DataGridViewTextBoxColumn();
            col_Street2.Name = COMPANY.STREET2;
            col_Street2.HeaderText = "STREET2";
            //col_Street2.Visible = false; 
            col_Street2.Width = 100;
            col_Street2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Street2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Street2);

            DataGridViewTextBoxColumn col_City_id = new DataGridViewTextBoxColumn();
            col_City_id.Name = COMPANY.CITY_ID;
            col_City_id.HeaderText = "CITY";
            //col_City_id.Visible = false; 
            col_City_id.Width = 100;
            col_City_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_City_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_City_id);

            DataGridViewTextBoxColumn col_State_id = new DataGridViewTextBoxColumn();
            col_State_id.Name = COMPANY.STATE_ID;
            col_State_id.HeaderText = "STATE";
            //col_State_id.Visible = false; 
            col_State_id.Width = 100;
            col_State_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_State_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_State_id);

            DataGridViewTextBoxColumn col_Country_id = new DataGridViewTextBoxColumn();
            col_Country_id.Name = COMPANY.COUNTRY_ID;
            col_Country_id.HeaderText = "COUNTRY";
            //col_Country_id.Visible = false; 
            col_Country_id.Width = 100;
            col_Country_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Country_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Country_id);

            DataGridViewTextBoxColumn col_Pincode_id = new DataGridViewTextBoxColumn();
            col_Pincode_id.Name = COMPANY.PINCODE_ID;
            col_Pincode_id.HeaderText = "PINCODE";
            //col_Pincode_id.Visible = false; 
            col_Pincode_id.Width = 100;
            col_Pincode_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Pincode_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Pincode_id);

            DataGridViewTextBoxColumn col_Cell1 = new DataGridViewTextBoxColumn();
            col_Cell1.Name = COMPANY.CELL1;
            col_Cell1.HeaderText = "CELL1";
            //col_Cell1.Visible = false; 
            col_Cell1.Width = 100;
            col_Cell1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Cell1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Cell1);

            DataGridViewTextBoxColumn col_Cell2 = new DataGridViewTextBoxColumn();
            col_Cell2.Name = COMPANY.CELL2;
            col_Cell2.HeaderText = "CELL2";
            //col_Cell2.Visible = false; 
            col_Cell2.Width = 100;
            col_Cell2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Cell2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Cell2);

            DataGridViewTextBoxColumn col_Phone = new DataGridViewTextBoxColumn();
            col_Phone.Name = COMPANY.PHONE;
            col_Phone.HeaderText = "PHONE";
            //col_Phone.Visible = false; 
            col_Phone.Width = 100;
            col_Phone.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Phone.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Phone);

            DataGridViewTextBoxColumn col_Email = new DataGridViewTextBoxColumn();
            col_Email.Name = COMPANY.EMAIL;
            col_Email.HeaderText = "EMAIL";
            //col_Email.Visible = false; 
            col_Email.Width = 100;
            col_Email.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Email);

            DataGridViewTextBoxColumn col_Website = new DataGridViewTextBoxColumn();
            col_Website.Name = COMPANY.WEBSITE;
            col_Website.HeaderText = "WEBSITE";
            //col_Website.Visible = false; 
            col_Website.Width = 100;
            col_Website.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Website.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Website);

            DataGridViewTextBoxColumn col_Gst = new DataGridViewTextBoxColumn();
            col_Gst.Name = COMPANY.GST;
            col_Gst.HeaderText = "GST";
            //col_Gst.Visible = false; 
            col_Gst.Width = 100;
            col_Gst.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Gst.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Gst);

            DataGridViewTextBoxColumn col_Pan = new DataGridViewTextBoxColumn();
            col_Pan.Name = COMPANY.PAN;
            col_Pan.HeaderText = "PAN";
            //col_Pan.Visible = false; 
            col_Pan.Width = 100;
            col_Pan.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Pan.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Pan);

            DataGridViewTextBoxColumn col_Comp_code = new DataGridViewTextBoxColumn();
            col_Comp_code.Name = COMPANY.COMP_CODE;
            col_Comp_code.HeaderText = "COMP CODE";
            //col_Comp_code.Visible = false; 
            col_Comp_code.Width = 150;
            col_Comp_code.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Comp_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Comp_code);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = COMPANY.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false; 
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes );

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = COMPANY.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false; 
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id );

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = COMPANY.USER_ID;
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
             if (fcompany == null)
             {
                 fcompany = new FCompany();
             }
             BuildForm();
             string pkValue = GetSelectedPkValue();
             if (pkValue != null)
             {
                 fcompany.SetAction(BtnEvent.Open, pkValue);
             }
         }

         #endregion[Grid Action]

         #region[Enter Event]

         private void Txt_companytype_Enter(object sender, EventArgs e)
         {
             Change_infocus();
             lbl_company_name.BackColor = Theme.lbl_EnterBackColor;
             lbl_company_name.BorderColor = Theme.lbl_EnterBorderColor;
             lbl_company_name.ForeColor = Theme.lbl_EnterForeColor;
         }
         private void Change_infocus()
         {
             lbl_company_name.BackColor = Theme.lbl_BackColor;
             lbl_company_name.BorderColor = Theme.lbl_BorderColor;
             lbl_company_name.ForeColor = Theme.lbl_ForeColor;
         }

         #endregion[Enter Event]

         #region[Build Form]

         private void BuildForm()
         {
             if (fcompany == null)
             {
                 fcompany = new FCompany();
             }
             //fcompany.FCompany_NeedToRefresh += VCompany_NeedToRefresh;
             Parent.Controls.Add(fcompany);
             fcompany.Dock = DockStyle.Fill;
             fcompany.Show();
             fcompany.BringToFront();
             
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
                fcompany.SetAction(BtnEvent.New, null); 
                fcompany.SetFocus(); 
        } 

        private void Btn_edit_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fcompany.SetAction(BtnEvent.Edit, pkValue); 
                fcompany.SetFocus(); 
            } 
        } 

        private void Btn_delete_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fcompany.SetAction(BtnEvent.Delete, pkValue); 
                fcompany.SetFocus(); 
            } 
        } 

        private void Btn_print_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                fcompany.SetAction(BtnEvent.Print, pkValue); 
                fcompany.SetFocus(); 
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

         public void Company_lookup()
         {
             txt_company_name.LookupColNames = new string[] { COMPANY.COMPANY_NAME };
             txt_company_name.LookupUpdate += txt_company_LookupUpdate;
             txt_company_name.AllowNewEntry = true;
             txt_company_name.NewEntryNeeded += txt_company_NewEntryNeeded;
         }
         void txt_company_LookupUpdate(object sender, EventArgs e)
         {
             txt_company_name.LookupList = CCompany_exten.GetforLookup();
         }
         private FCompany fscompany = null;
         void txt_company_NewEntryNeeded(object sender, string pValue)
         {
             if (fscompany == null)
             {
                 fscompany = new FCompany();
             }
             Parent.Controls.Add(fscompany);
             fscompany.Dock = DockStyle.Fill;
             fscompany.Show();
             fscompany.BringToFront();
             fscompany.Focus();
             
             fscompany.SetAction(BtnEvent.New, null);
             fscompany.SetFocus();
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
                 selPkValue = vSelRow.Cells[COMPANY.COMPANY_ID].Value.ToString();
             }
             return selPkValue;
         }

         #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VCompany_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        #endregion[RaiseEvent]

}//cls
}//ns
