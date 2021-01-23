// Version : 4.0.0.2 Date : 10-08-2020
// Auto Generated
// last update : 10-08-2020 07:17:11 PM

using System.Windows.Forms; 
using System.Collections.Generic; 
using CXLIB; 
 
namespace CXCORE 
{ 
    public partial class LCompany
    { 
        #region[list Option] 
  
         public void ListRefresh() 
         { 
             List_Option(fAction); 
         } 
         
         private ListOption fAction = ListOption.active; 
         public void List_Option(ListOption action) 
         { 
             fAction = action; 
             
             switch (fAction) 
             { 
                 case ListOption.active: 
  
                     if (chk_notactive.Checked == true) 
                     { 
                         LoadData(CCompany_exten.NotActive()); 
                     } 
                     else 
                     { 
                         LoadData(CCompany_exten.Active()); 
                     } 
  
                     break; 
  
                 case ListOption.notactive: 
  
                     if (chk_notactive.Checked == true) 
                     { 
                         LoadData(CCompany_exten.NotActive()); 
                     } 
                     else 
                     { 
                         LoadData(CCompany_exten.Active()); 
                     } 
  
                     break; 
  
                 case ListOption.Search: 
                     if (txt_company_name.Text != "") 
                     { 
                     List<Company> list = new List<Company> 
                     { 
                     CCompany_exten.SearchName(txt_company_name.Text) 
                     }; 
                     LoadData(list); 
                     } 
                     else 
                     { 
                         LoadData(CCompany_exten.Active()); 
                     } 
                     break; 
  
                 default: 
                     LoadData(CCompany_exten.Active()); 
                     break; 
             } 
         } 
  
         #endregion[list Option] 
  
         #region[Load Data] 
  
         public void LoadData(List<Company> list) 
         { 
             listgrid.RowCount = 0; 
             listgrid.RowCount = list.Count; 
             for (int r = 0; r < list.Count; r++) 
             { 
                 DataGridViewRow row = listgrid.Rows[r]; 
                 
                 row.Cells[COMPANY.COMPANY_ID].Value = list[r].Company_id; 
                 row.Cells[COMPANY.COMPANY_NAME].Value = list[r].Company_name; 
                 row.Cells[COMPANY.DISPLAY_NAME].Value = list[r].Display_name; 
                 row.Cells[COMPANY.STREET1].Value = list[r].Street1; 
                 row.Cells[COMPANY.STREET2].Value = list[r].Street2; 
                 row.Cells[COMPANY.CITY_ID].Value = list[r].City_id; 
                 row.Cells[COMPANY.STATE_ID].Value = list[r].State_id; 
                 row.Cells[COMPANY.COUNTRY_ID].Value = list[r].Country_id; 
                 row.Cells[COMPANY.PINCODE_ID].Value = list[r].Pincode_id; 
                 row.Cells[COMPANY.CELL1].Value = list[r].Cell1; 
                 row.Cells[COMPANY.CELL2].Value = list[r].Cell2; 
                 row.Cells[COMPANY.PHONE].Value = list[r].Phone; 
                 row.Cells[COMPANY.EMAIL].Value = list[r].Email; 
                 row.Cells[COMPANY.WEBSITE].Value = list[r].Website; 
                 row.Cells[COMPANY.GST].Value = list[r].Gstin; 
                 row.Cells[COMPANY.PAN].Value = list[r].Pan; 
                 row.Cells[COMPANY.COMP_CODE].Value = list[r].Comp_code; 
                 row.Cells[COMPANY.NOTES].Value = list[r].Notes; 
                 row.Cells[COMPANY.ACTIVE_ID].Value = list[r].Active_id; 
                 row.Cells[COMPANY.USER_ID].Value = list[r].User_id; 
             } 
         } 
         
         #endregion[Load Data] 
 
 }//cls 
}//ns 
