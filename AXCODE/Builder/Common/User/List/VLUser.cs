// Version : 1 dt : 11-07-2017
// Auto Generated
// 13-07-2017 10:42:25 PM
// last update : 13-07-2017

using System; 
using System.Windows.Forms; 
using System.Data; 
using CXLIB; 
 
namespace AXCODE 
{ 
    public partial class LUser : UserControl 
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
                         LoadData(CUser.TblData(CUser_exten.NotActive())); 
                     } 
                     else 
                     { 
                         LoadData(CUser.TblData(CUser_exten.Active())); 
                     } 
  
                     break; 
  
                 case ListOption.notactive: 
  
                     if (chk_notactive.Checked == true) 
                     { 
                         LoadData(CUser.TblData(CUser_exten.NotActive())); 
                     } 
                     else 
                     { 
                         LoadData(CUser.TblData(CUser_exten.Active())); 
                     } 
  
                     break; 
  
                 case ListOption.Search: 
                     if (txt_user_name.Text != "") 
                     { 
                         LoadData(CUser.TblData(CUser_exten.SearchName(txt_user_name.Text))); 
                     } 
                     else 
                     { 
                         LoadData(CUser.TblData(CUser_exten.Active())); 
                     } 
                     break; 
  
                 default: 
                     LoadData(CUser.TblData(CUser_exten.Active())); 
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
                 
                 row.Cells[USER.USER_ID].Value = tbl.Rows[r][USER.USER_ID]; 
                 row.Cells[USER.USER_NAME].Value = tbl.Rows[r][USER.USER_NAME]; 
                 row.Cells[USER.USER_PASSWORD].Value = tbl.Rows[r][USER.USER_PASSWORD]; 
                 row.Cells[USER.CREATEON].Value = tbl.Rows[r][USER.CREATEON]; 
                 row.Cells[USER.ENTRYBY].Value = tbl.Rows[r][USER.ENTRYBY]; 
                 row.Cells[USER.NOTES].Value = tbl.Rows[r][USER.NOTES]; 
                 row.Cells[USER.ACTIVE_ID].Value = tbl.Rows[r][USER.ACTIVE_ID]; 
                 row.Cells[USER.USER_ID].Value = CUser_exten.GetName_Id(tbl.Rows[r][USER.USER_ID].ToString()); 
             } 
         } 
         
         #endregion[Load Data] 
 		 
 
 }//cls 
}//ns 
