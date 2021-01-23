// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 25-12-2017 08:21:03 PM

using System; 
using System.Drawing; 
using System.Windows.Forms; 
using CXLIB; 
 
namespace CXCORE 
{ 
    public partial class LMethod : UserControl 
    { 
  
         #region[Init Grid]
 
          private void InitGrid()
          {
              listgrid.RowAction += Listgrid_RowAction;
              
 DataGridViewTextBoxColumn col_Method_Id = new DataGridViewTextBoxColumn();  
col_Method_Id.Name = METHOD.METHOD_ID;  
col_Method_Id.HeaderText = "METHOD_ID ";  
col_Method_Id.Visible = false; 
col_Method_Id.Width = 100;  
col_Method_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  
col_Method_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;  
listgrid.Columns.Add(col_Method_Id );  
  
DataGridViewTextBoxColumn col_Method_name = new DataGridViewTextBoxColumn();  
col_Method_name.Name = METHOD.METHOD_NAME;  
col_Method_name.HeaderText = "METHOD NAME";  
//col_Method_name.Visible = false; 
col_Method_name.Width = 175;  
col_Method_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  
col_Method_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;  
listgrid.Columns.Add(col_Method_name);  
  
DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();  
col_Notes.Name = METHOD.NOTES ;  
col_Notes.HeaderText = "NOTES";  
col_Notes.Visible = false; 
col_Notes.Width = 200;  
col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  
col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;  
listgrid.Columns.Add(col_Notes );  
  
DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();  
col_Active_Id.Name = METHOD.ACTIVE_ID ;  
col_Active_Id.HeaderText = "ACTIVE ID";  
col_Active_Id.Visible = false; 
col_Active_Id.Width = 200;  
col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  
col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;  
listgrid.Columns.Add(col_Active_Id );  
  
DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();  
col_User_Id.Name = METHOD.USER_ID ;  
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
              if (fmethod == null)
              {
                  fmethod = new FMethod();
              }
              BuildForm();
              string pkValue = GetSelectedPkValue();
              if (pkValue != null)
              {
                  fmethod.SetAction(BtnEvent.Open, pkValue);
              }
          }
 
          #endregion[Grid Action]
 
          #region[Enter Event]
 
          private void Txt_methodtype_Enter(object sender, EventArgs e)
          {
              Change_infocus();
              lbl_method_name.BackColor = Theme.lbl_EnterBackColor;
              lbl_method_name.BorderColor = Theme.lbl_EnterBorderColor;
              lbl_method_name.ForeColor = Theme.lbl_EnterForeColor;
          }
          private void Change_infocus()
          {
              lbl_method_name.BackColor = Theme.lbl_BackColor;
              lbl_method_name.BorderColor = Theme.lbl_BorderColor;
              lbl_method_name.ForeColor = Theme.lbl_ForeColor;
          }
 
          #endregion[Enter Event]
 
          #region[Build Form]
 
          private void BuildForm()
          {
              if (fmethod == null)
              {
                  fmethod = new FMethod();
              }
              fmethod.FMethod_NeedToRefresh += VMethod_NeedToRefresh;
              Parent.Controls.Add(fmethod);
              fmethod.Dock = DockStyle.Fill;
              fmethod.Show();
              fmethod.BringToFront();
              
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
                 fmethod.SetAction(BtnEvent.New, null); 
                 fmethod.SetFocus(); 
         } 
 
         private void Btn_edit_Click(object sender, EventArgs e) 
         { 
             BuildForm(); 
             string pkValue = GetSelectedPkValue(); 
             if (pkValue != null) 
             { 
                 fmethod.SetAction(BtnEvent.Edit, pkValue); 
                 fmethod.SetFocus(); 
             } 
         } 
 
         private void Btn_delete_Click(object sender, EventArgs e) 
         { 
             BuildForm(); 
             string pkValue = GetSelectedPkValue(); 
             if (pkValue != null) 
             { 
                 fmethod.SetAction(BtnEvent.Delete, pkValue); 
                 fmethod.SetFocus(); 
             } 
         } 
 
         private void Btn_print_Click(object sender, EventArgs e) 
         { 
             BuildForm(); 
             string pkValue = GetSelectedPkValue(); 
             if (pkValue != null) 
             { 
                 fmethod.SetAction(BtnEvent.Print, pkValue); 
                 fmethod.SetFocus(); 
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
 
          public void Method_lookup()
          {
              txt_method_name.LookupColNames = new string[] { METHOD.METHOD_NAME };  
             txt_method_name.LookupUpdate += txt_method_LookupUpdate;
              txt_method_name.AllowNewEntry = true;
              txt_method_name.NewEntryNeeded += txt_method_NewEntryNeeded;
          }
          void txt_method_LookupUpdate(object sender, EventArgs e)
          {
              txt_method_name.LookupList = CMethod_exten.GetforLookup(new DAL());
          }
          private FMethod fsmethod = null;
          void txt_method_NewEntryNeeded(object sender, string pValue)
          {
              if (fsmethod == null)
              {
                  fsmethod = new FMethod();
              }
              Parent.Controls.Add(fsmethod);
              fsmethod.Dock = DockStyle.Fill;
              fsmethod.Show();
              fsmethod.BringToFront();
              fsmethod.Focus();
              
              fsmethod.SetAction(BtnEvent.New, null);
              fsmethod.SetFocus();
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
                  selPkValue = vSelRow.Cells[METHOD.METHOD_ID].Value.ToString();
              }
              return selPkValue;
          }
 
          #endregion[Get selected pk value]
 
 
          #region[RaiseEvent]
 
          void VMethod_NeedToRefresh(object sender, EventArgs e)
          {
              List_Option(ListOption.active);
          }
          public event EventHandler LMethod_NeedToRefresh;
          public void RaiseEvent_NeedToRefresh()
          {
              if (LMethod_NeedToRefresh != null)
              {
                  LMethod_NeedToRefresh(this, new EventArgs());
              }
          }
 
          #endregion[RaiseEvent]
 
 
 }//cls
}//ns
