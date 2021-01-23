// Version : 1 dt : 11-07-2017
// Auto Generated
// 13-07-2017 10:30:25 PM
// last update : 13-07-2017

using System; 
using System.Windows.Forms; 
using System.Data; 
using CXLIB; 
 
namespace AXCODE 
{ 
    public partial class LServers : UserControl 
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
                         LoadData(CServers.TblData(CServers_exten.NotActive())); 
                     } 
                     else 
                     { 
                         LoadData(CServers.TblData(CServers_exten.Active())); 
                     } 
  
                     break; 
  
                 case ListOption.notactive: 
  
                     if (chk_notactive.Checked == true) 
                     { 
                         LoadData(CServers.TblData(CServers_exten.NotActive())); 
                     } 
                     else 
                     { 
                         LoadData(CServers.TblData(CServers_exten.Active())); 
                     } 
  
                     break; 
  
                 case ListOption.Search: 
                     if (txt_servers_name.Text != "") 
                     { 
                         LoadData(CServers.TblData(CServers_exten.SearchName(txt_servers_name.Text))); 
                     } 
                     else 
                     { 
                         LoadData(CServers.TblData(CServers_exten.Active())); 
                     } 
                     break; 
  
                 default: 
                     LoadData(CServers.TblData(CServers_exten.Active())); 
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
                 
                 row.Cells[SERVERS.SERVERS_ID].Value = tbl.Rows[r][SERVERS.SERVERS_ID]; 
                 row.Cells[SERVERS.SERVERS_NAME].Value = tbl.Rows[r][SERVERS.SERVERS_NAME]; 
                 row.Cells[SERVERS.SERVERS_VERSION].Value = tbl.Rows[r][SERVERS.SERVERS_VERSION]; 
                 row.Cells[SERVERS.SERVERS_PATH].Value = tbl.Rows[r][SERVERS.SERVERS_PATH]; 
                 row.Cells[SERVERS.SERVERS_BACKUP_PATH].Value = tbl.Rows[r][SERVERS.SERVERS_BACKUP_PATH]; 
                 row.Cells[SERVERS.NOTES].Value = tbl.Rows[r][SERVERS.NOTES]; 
                 row.Cells[SERVERS.ACTIVE_ID].Value = tbl.Rows[r][SERVERS.ACTIVE_ID]; 
                 row.Cells[SERVERS.USER_ID].Value = CUser_exten.GetName_Id(tbl.Rows[r][SERVERS.USER_ID].ToString()); 
             } 
         } 
         
         #endregion[Load Data] 
 		 
 
 }//cls 
}//ns 
