// Version : 1 dt : 11-07-2017
// Auto Generated
// 13-07-2017 10:30:32 PM
// last update : 13-07-2017

using System.Windows.Forms;
using System.Data;
using CXLIB;
using CXCORE;

namespace AXCODE
{
    public partial class LDatabases : UserControl 
    { 
        #region[list Option] 
  
         public void ListRefresh() 
         { 
             List_Option(fAction); 
         } 
         
         private ListOption fAction = ListOption.active; 
         public void List_Option(ListOption pAction) 
         { 
             fAction = pAction; 
             
             switch (fAction) 
             { 
                 case ListOption.active: 
  
                     if (chk_notactive.Checked == true) 
                     { 
                         LoadData(CDatabases.TblData(CDatabases_exten.NotActive())); 
                     } 
                     else 
                     { 
                         LoadData(CDatabases.TblData(CDatabases_exten.Active())); 
                     } 
  
                     break; 
  
                 case ListOption.notactive: 
  
                     if (chk_notactive.Checked == true) 
                     { 
                         LoadData(CDatabases.TblData(CDatabases_exten.NotActive())); 
                     } 
                     else 
                     { 
                         LoadData(CDatabases.TblData(CDatabases_exten.Active())); 
                     } 
  
                     break; 
  
                 case ListOption.Search: 
                     if (txt_databases_name.Text != "") 
                     { 
                         LoadData(CDatabases.TblData(CDatabases_exten.SearchName(txt_databases_name.Text))); 
                     } 
                     else 
                     { 
                         LoadData(CDatabases.TblData(CDatabases_exten.Active())); 
                     } 
                     break; 
  
                 default: 
                     LoadData(CDatabases.TblData(CDatabases_exten.Active())); 
                     break; 
             } 
         } 
  
         #endregion[list Option] 
  
         #region[Load Data] 
  
         public void LoadData(DataTable tbl) 
         { 
             listgrid.RowCount = 0; 
             listgrid.RowCount = tbl.Rows.Count; 
             for (int r = 0; r < tbl.Rows.Count; r++) 
             { 
                 DataGridViewRow row = listgrid.Rows[r]; 
                 
                 row.Cells[DATABASES.DATABASES_ID].Value = tbl.Rows[r][DATABASES.DATABASES_ID]; 
                 row.Cells[DATABASES.DATABASES_NAME].Value = tbl.Rows[r][DATABASES.DATABASES_NAME]; 
                 row.Cells[DATABASES.NOTES].Value = tbl.Rows[r][DATABASES.NOTES]; 
                 row.Cells[DATABASES.ACTIVE_ID].Value = tbl.Rows[r][DATABASES.ACTIVE_ID]; 
                 row.Cells[DATABASES.USER_ID].Value = CUser_exten.GetName_Id(tbl.Rows[r][DATABASES.USER_ID].ToString()); 
             } 
         } 
         
         #endregion[Load Data] 
 		 
 
 }//cls 
}//ns 
