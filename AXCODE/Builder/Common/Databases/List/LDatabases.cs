// Version : 1 dt : 11-07-2017
// Auto Generated
// 13-07-2017 10:30:32 PM
// last update : 13-07-2017

using System; 
using System.Drawing; 
using System.Windows.Forms; 
using CXLIB; 
 
namespace AXCODE 
{ 
    public partial class LDatabases : UserControl 
    { 
         public LDatabases()
          {
              InitializeComponent();
              InitGrid();
               List_Option(ListOption.active);
              Databases_lookup();
          }
 
           private FDatabases fdatabases = null;
 
   
         #region[Init Grid]
 
          private void InitGrid()
          {
              listgrid.RowAction += Listgrid_RowAction;
              
 DataGridViewTextBoxColumn col_Databases_Id = new DataGridViewTextBoxColumn();  
col_Databases_Id.Name = DATABASES.DATABASES_ID ;  
col_Databases_Id.HeaderText = "DATABASES_ID ";  
col_Databases_Id.Visible = false; 
col_Databases_Id.Width = 200;  
col_Databases_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  
col_Databases_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;  
listgrid.Columns.Add(col_Databases_Id );  
  
DataGridViewTextBoxColumn col_Databases_name = new DataGridViewTextBoxColumn();  
col_Databases_name.Name = DATABASES.DATABASES_NAME;  
col_Databases_name.HeaderText = "DATABASES NAME";  
//col_Databases_name.Visible = false; 
col_Databases_name.Width = 200;  
col_Databases_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  
col_Databases_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;  
listgrid.Columns.Add(col_Databases_name);  
  
DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();  
col_Notes.Name = DATABASES.NOTES ;  
col_Notes.HeaderText = "NOTES";  
col_Notes.Visible = false; 
col_Notes.Width = 200;  
col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  
col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;  
listgrid.Columns.Add(col_Notes );  
  
DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();  
col_Active_Id.Name = DATABASES.ACTIVE_ID ;  
col_Active_Id.HeaderText = "ACTIVE ID";  
col_Active_Id.Visible = false; 
col_Active_Id.Width = 200;  
col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  
col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;  
listgrid.Columns.Add(col_Active_Id );  
  
DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();  
col_User_Id.Name = DATABASES.USER_ID ;  
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
              if (fdatabases == null)
              {
                  fdatabases = new FDatabases();
              }
              BuildForm();
              string pkValue = GetSelectedPkValue();
              if (pkValue != null)
              {
                  fdatabases.SetAction(BtnEvent.Open, pkValue);
              }
          }
 
          #endregion[Grid Action]
 
          #region[Enter Event]
 
          private void Txt_databasestype_Enter(object sender, EventArgs e)
          {
              Change_infocus();
              lbl_databases_name.BackColor = Theme.lbl_EnterBackColor;
              lbl_databases_name.BorderColor = Theme.lbl_EnterBorderColor;
              lbl_databases_name.ForeColor = Theme.lbl_EnterForeColor;
          }
          private void Change_infocus()
          {
              lbl_databases_name.BackColor = Theme.lbl_BackColor;
              lbl_databases_name.BorderColor = Theme.lbl_BorderColor;
              lbl_databases_name.ForeColor = Theme.lbl_ForeColor;
          }
 
          #endregion[Enter Event]
 
          #region[Build Form]
 
          private void BuildForm()
          {
              if (fdatabases == null)
              {
                  fdatabases = new FDatabases();
              }
              fdatabases.FDatabases_NeedToRefresh += VDatabases_NeedToRefresh;
              Parent.Controls.Add(fdatabases);
              fdatabases.Dock = DockStyle.Fill;
              fdatabases.Show();
              fdatabases.BringToFront();
              
          }
 
          #endregion[Build Form]
 
          #region[Txt search Change Event] 
          
                 private void Txt_databases_name_TextChanged(object sender, EventArgs e) 
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
                     fdatabases.SetAction(BtnEvent.New, null); 
                     fdatabases.SetFocus(); 
                 } 
                 private void Btn_edit_Click(object sender, EventArgs e) 
                 { 
                     BuildForm(); 
                     string pkValue = GetSelectedPkValue(); 
                     if (pkValue != null) 
                     { 
                         fdatabases.SetAction(BtnEvent.Edit, pkValue); 
                         fdatabases.SetFocus(); 
                     } 
                 } 
                 private void Btn_delete_Click(object sender, EventArgs e) 
                 { 
                     BuildForm(); 
                     string pkValue = GetSelectedPkValue(); 
                     if (pkValue != null) 
                     { 
                         fdatabases.SetAction(BtnEvent.Delete, pkValue); 
                         fdatabases.SetFocus(); 
                     } 
                 } 
                 private void Btn_print_Click(object sender, EventArgs e) 
                 { 
                     BuildForm(); 
                     string pkValue = GetSelectedPkValue(); 
                     if (pkValue != null) 
                     { 
                         fdatabases.SetAction(BtnEvent.Print, pkValue); 
                         fdatabases.SetFocus(); 
                     } 
                 } 
                 private void Btn_close_Click(object sender, EventArgs e) 
                 { 
                     Hide(); 
                     RaiseEvent_NeedToRefresh(); 
                 } 
          
          #endregion[Btn Event] 
          
          #region[lookup] 
          
          public void Databases_lookup()
          {
              txt_databases_name.LookupColNames = new string[] { DATABASES.DATABASES_NAME };  
             txt_databases_name.LookupUpdate += txt_databases_LookupUpdate;
              txt_databases_name.AllowNewEntry = true;
              txt_databases_name.NewEntryNeeded += txt_databases_NewEntryNeeded;
          }
          void txt_databases_LookupUpdate(object sender, EventArgs e)
          {
              txt_databases_name.LookupList = CDatabases_exten.GetforLookup();
          }
          private FDatabases fsdatabases = null;
          void txt_databases_NewEntryNeeded(object sender, string pValue)
          {
              if (fsdatabases == null)
              {
                  fsdatabases = new FDatabases();
              }
              Parent.Controls.Add(fsdatabases);
              fsdatabases.Dock = DockStyle.Fill;
              fsdatabases.Show();
              fsdatabases.BringToFront();
              fsdatabases.Focus();
              
              fsdatabases.SetAction(BtnEvent.New, null);
              fsdatabases.SetFocus();
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
                  selPkValue = vSelRow.Cells[DATABASES.DATABASES_ID].Value.ToString();
              }
              return selPkValue;
          }
          
          #endregion[Get selected pk value]
          
          #region[RaiseEvent]
          
          void VDatabases_NeedToRefresh(object sender, EventArgs e)
          {
              List_Option(ListOption.active);
          }
          public event EventHandler LDatabases_NeedToRefresh;
          public void RaiseEvent_NeedToRefresh()
          {
              if (LDatabases_NeedToRefresh != null)
              {
                  LDatabases_NeedToRefresh(this, new EventArgs());
              }
          }
          
          #endregion[RaiseEvent]
          
 
 }//cls
}//ns
