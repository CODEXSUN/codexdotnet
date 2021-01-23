// Version : 1 dt : 11-07-2017
// Auto Generated
// 13-07-2017 10:30:25 PM
// last update : 13-07-2017

using System; 
using System.Drawing; 
using System.Windows.Forms; 
using CXLIB; 
 
namespace AXCODE 
{ 
    public partial class LServers : UserControl 
    { 
         public LServers()
          {
              InitializeComponent();
              InitGrid();
               List_Option(ListOption.active);
              Servers_lookup();
          }
 
           private FServers fservers = null;
 
   
         #region[Init Grid]
 
          private void InitGrid()
          {
              listgrid.RowAction += Listgrid_RowAction;
              
 DataGridViewTextBoxColumn col_Servers_Id = new DataGridViewTextBoxColumn();  
col_Servers_Id.Name = SERVERS.SERVERS_ID ;  
col_Servers_Id.HeaderText = "SERVERS_ID ";  
col_Servers_Id.Visible = false; 
col_Servers_Id.Width = 200;  
col_Servers_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  
col_Servers_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;  
listgrid.Columns.Add(col_Servers_Id );  
  
DataGridViewTextBoxColumn col_Servers_name = new DataGridViewTextBoxColumn();  
col_Servers_name.Name = SERVERS.SERVERS_NAME;  
col_Servers_name.HeaderText = "SERVERS NAME";  
//col_Servers_name.Visible = false; 
col_Servers_name.Width = 200;  
col_Servers_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  
col_Servers_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;  
listgrid.Columns.Add(col_Servers_name);  
  
DataGridViewTextBoxColumn col_Servers_version = new DataGridViewTextBoxColumn();  
col_Servers_version.Name = SERVERS.SERVERS_VERSION;  
col_Servers_version.HeaderText = "SERVERS VERSION";  
//col_Servers_version.Visible = false; 
col_Servers_version.Width = 200;  
col_Servers_version.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  
col_Servers_version.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;  
listgrid.Columns.Add(col_Servers_version);  
  
DataGridViewTextBoxColumn col_Servers_path = new DataGridViewTextBoxColumn();  
col_Servers_path.Name = SERVERS.SERVERS_PATH;  
col_Servers_path.HeaderText = "SERVERS PATH";  
//col_Servers_path.Visible = false; 
col_Servers_path.Width = 200;  
col_Servers_path.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  
col_Servers_path.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;  
listgrid.Columns.Add(col_Servers_path);  
  
DataGridViewTextBoxColumn col_Servers_backup_path = new DataGridViewTextBoxColumn();  
col_Servers_backup_path.Name = SERVERS.SERVERS_BACKUP_PATH;  
col_Servers_backup_path.HeaderText = "SERVERS BACKUP PATH";  
//col_Servers_backup_path.Visible = false; 
col_Servers_backup_path.Width = 200;  
col_Servers_backup_path.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  
col_Servers_backup_path.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;  
listgrid.Columns.Add(col_Servers_backup_path);  
  
DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();  
col_Notes.Name = SERVERS.NOTES ;  
col_Notes.HeaderText = "NOTES";  
col_Notes.Visible = false; 
col_Notes.Width = 200;  
col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  
col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;  
listgrid.Columns.Add(col_Notes );  
  
DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();  
col_Active_Id.Name = SERVERS.ACTIVE_ID ;  
col_Active_Id.HeaderText = "ACTIVE ID";  
col_Active_Id.Visible = false; 
col_Active_Id.Width = 200;  
col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  
col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;  
listgrid.Columns.Add(col_Active_Id );  
  
DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();  
col_User_Id.Name = SERVERS.USER_ID ;  
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
              if (fservers == null)
              {
                  fservers = new FServers();
              }
              BuildForm();
              string pkValue = GetSelectedPkValue();
              if (pkValue != null)
              {
                  fservers.SetAction(BtnEvent.Open, pkValue);
              }
          }
 
          #endregion[Grid Action]
 
          #region[Enter Event]
 
          private void Txt_serverstype_Enter(object sender, EventArgs e)
          {
              Change_infocus();
              lbl_servers_name.BackColor = Theme.lbl_EnterBackColor;
              lbl_servers_name.BorderColor = Theme.lbl_EnterBorderColor;
              lbl_servers_name.ForeColor = Theme.lbl_EnterForeColor;
          }
          private void Change_infocus()
          {
              lbl_servers_name.BackColor = Theme.lbl_BackColor;
              lbl_servers_name.BorderColor = Theme.lbl_BorderColor;
              lbl_servers_name.ForeColor = Theme.lbl_ForeColor;
          }
 
          #endregion[Enter Event]
 
          #region[Build Form]
 
          private void BuildForm()
          {
              if (fservers == null)
              {
                  fservers = new FServers();
              }
              fservers.FServers_NeedToRefresh += VServers_NeedToRefresh;
              Parent.Controls.Add(fservers);
              fservers.Dock = DockStyle.Fill;
              fservers.Show();
              fservers.BringToFront();
              
          }
 
          #endregion[Build Form]
 
          #region[Txt search Change Event] 
          
                 private void Txt_servers_name_TextChanged(object sender, EventArgs e) 
                 { 
                     List_Option(ListOption.Search); 
                 } 
                 private void Txt_hsn_code_TextChanged(object sender, EventArgs e) 
                 { 
                     List_Option(ListOption.Hsncode); 
                 } 
          
          #endregion[Txt search Change Event] 
          
          #region[Checkbox Event] 
          
                 private void Chk_notactive_CheckedChanged(object sender, EventArgs e) 
                 { 
                     List_Option(ListOption.notactive); 
                 } 
          
          #endregion[Checkbox Event] 
          
          #region[Btn Event] 
          
                 private void Btn_new_Click(object sender, EventArgs e) 
                 { 
                     BuildForm(); 
                     fservers.SetAction(BtnEvent.New, null); 
                     fservers.SetFocus(); 
                 } 
                 private void Btn_edit_Click(object sender, EventArgs e) 
                 { 
                     BuildForm(); 
                     string pkValue = GetSelectedPkValue(); 
                     if (pkValue != null) 
                     { 
                         fservers.SetAction(BtnEvent.Edit, pkValue); 
                         fservers.SetFocus(); 
                     } 
                 } 
                 private void Btn_delete_Click(object sender, EventArgs e) 
                 { 
                     BuildForm(); 
                     string pkValue = GetSelectedPkValue(); 
                     if (pkValue != null) 
                     { 
                         fservers.SetAction(BtnEvent.Delete, pkValue); 
                         fservers.SetFocus(); 
                     } 
                 } 
                 private void Btn_print_Click(object sender, EventArgs e) 
                 { 
                     BuildForm(); 
                     string pkValue = GetSelectedPkValue(); 
                     if (pkValue != null) 
                     { 
                         fservers.SetAction(BtnEvent.Print, pkValue); 
                         fservers.SetFocus(); 
                     } 
                 } 
                 private void Btn_close_Click(object sender, EventArgs e) 
                 { 
                     Hide(); 
                     RaiseEvent_NeedToRefresh(); 
                 } 
          
          #endregion[Btn Event] 
          
          #region[lookup] 
          
          public void Servers_lookup()
          {
              txt_servers_name.LookupColNames = new string[] { SERVERS.SERVERS_NAME };  
             txt_servers_name.LookupUpdate += txt_servers_LookupUpdate;
              txt_servers_name.AllowNewEntry = true;
              txt_servers_name.NewEntryNeeded += txt_servers_NewEntryNeeded;
          }
          void txt_servers_LookupUpdate(object sender, EventArgs e)
          {
              txt_servers_name.LookupList = CServers_exten.GetforLookup();
          }
          private FServers fsservers = null;
          void txt_servers_NewEntryNeeded(object sender, string pValue)
          {
              if (fsservers == null)
              {
                  fsservers = new FServers();
              }
              Parent.Controls.Add(fsservers);
              fsservers.Dock = DockStyle.Fill;
              fsservers.Show();
              fsservers.BringToFront();
              fsservers.Focus();
              
              fsservers.SetAction(BtnEvent.New, null);
              fsservers.SetFocus();
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
                  selPkValue = vSelRow.Cells[SERVERS.SERVERS_ID].Value.ToString();
              }
              return selPkValue;
          }
          
          #endregion[Get selected pk value]
          
          
          #region[RaiseEvent]
          
          void VServers_NeedToRefresh(object sender, EventArgs e)
          {
              List_Option(ListOption.active);
          }
          public event EventHandler LServers_NeedToRefresh;
          public void RaiseEvent_NeedToRefresh()
          {
              if (LServers_NeedToRefresh != null)
              {
                  LServers_NeedToRefresh(this, new EventArgs());
              }
          }
          
          #endregion[RaiseEvent]
          
 
 }//cls
}//ns
