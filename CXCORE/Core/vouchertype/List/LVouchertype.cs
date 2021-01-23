// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 25-12-2017 07:47:12 PM

using System; 
using System.Drawing; 
using System.Windows.Forms; 
using CXLIB; 
 
namespace CXCORE 
{ 
    public partial class LVouchertype : UserControl 
    { 
  
         #region[Init Grid]
 
          private void InitGrid()
          {
              listgrid.RowAction += Listgrid_RowAction;
              
 DataGridViewTextBoxColumn col_Vouchertype_Id = new DataGridViewTextBoxColumn();  
col_Vouchertype_Id.Name = VOUCHERTYPE.VOUCHERTYPE_ID;  
col_Vouchertype_Id.HeaderText = "VOUCHERTYPE_ID ";  
col_Vouchertype_Id.Visible = false; 
col_Vouchertype_Id.Width = 100;  
col_Vouchertype_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  
col_Vouchertype_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;  
listgrid.Columns.Add(col_Vouchertype_Id );  
  
DataGridViewTextBoxColumn col_Vouchertype_name = new DataGridViewTextBoxColumn();  
col_Vouchertype_name.Name = VOUCHERTYPE.VOUCHERTYPE_NAME;  
col_Vouchertype_name.HeaderText = "VOUCHERTYPE NAME";  
//col_Vouchertype_name.Visible = false; 
col_Vouchertype_name.Width = 238;  
col_Vouchertype_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  
col_Vouchertype_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;  
listgrid.Columns.Add(col_Vouchertype_name);  
  
DataGridViewTextBoxColumn col_Method_id = new DataGridViewTextBoxColumn();  
col_Method_id.Name = VOUCHERTYPE.METHOD_ID;  
col_Method_id.HeaderText = "METHOD";  
//col_Method_id.Visible = false; 
col_Method_id.Width = 100;  
col_Method_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  
col_Method_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;  
listgrid.Columns.Add(col_Method_id);  
  
DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();  
col_Notes.Name = VOUCHERTYPE.NOTES ;  
col_Notes.HeaderText = "NOTES";  
col_Notes.Visible = false; 
col_Notes.Width = 200;  
col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  
col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;  
listgrid.Columns.Add(col_Notes );  
  
DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();  
col_Active_Id.Name = VOUCHERTYPE.ACTIVE_ID ;  
col_Active_Id.HeaderText = "ACTIVE ID";  
col_Active_Id.Visible = false; 
col_Active_Id.Width = 200;  
col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  
col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;  
listgrid.Columns.Add(col_Active_Id );  
  
DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();  
col_User_Id.Name = VOUCHERTYPE.USER_ID ;  
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
              if (fvouchertype == null)
              {
                  fvouchertype = new FVouchertype();
              }
              BuildForm();
              string pkValue = GetSelectedPkValue();
              if (pkValue != null)
              {
                  fvouchertype.SetAction(BtnEvent.Open, pkValue);
              }
          }
 
          #endregion[Grid Action]
 
          #region[Enter Event]
 
          private void Txt_vouchertypetype_Enter(object sender, EventArgs e)
          {
              Change_infocus();
              lbl_vouchertype_name.BackColor = Theme.lbl_EnterBackColor;
              lbl_vouchertype_name.BorderColor = Theme.lbl_EnterBorderColor;
              lbl_vouchertype_name.ForeColor = Theme.lbl_EnterForeColor;
          }
          private void Change_infocus()
          {
              lbl_vouchertype_name.BackColor = Theme.lbl_BackColor;
              lbl_vouchertype_name.BorderColor = Theme.lbl_BorderColor;
              lbl_vouchertype_name.ForeColor = Theme.lbl_ForeColor;
          }
 
          #endregion[Enter Event]
 
          #region[Build Form]
 
          private void BuildForm()
          {
              if (fvouchertype == null)
              {
                  fvouchertype = new FVouchertype();
              }
              fvouchertype.FVouchertype_NeedToRefresh += VVouchertype_NeedToRefresh;
              Parent.Controls.Add(fvouchertype);
              fvouchertype.Dock = DockStyle.Fill;
              fvouchertype.Show();
              fvouchertype.BringToFront();
              
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
                 fvouchertype.SetAction(BtnEvent.New, null); 
                 fvouchertype.SetFocus(); 
         } 
 
         private void Btn_edit_Click(object sender, EventArgs e) 
         { 
             BuildForm(); 
             string pkValue = GetSelectedPkValue(); 
             if (pkValue != null) 
             { 
                 fvouchertype.SetAction(BtnEvent.Edit, pkValue); 
                 fvouchertype.SetFocus(); 
             } 
         } 
 
         private void Btn_delete_Click(object sender, EventArgs e) 
         { 
             BuildForm(); 
             string pkValue = GetSelectedPkValue(); 
             if (pkValue != null) 
             { 
                 fvouchertype.SetAction(BtnEvent.Delete, pkValue); 
                 fvouchertype.SetFocus(); 
             } 
         } 
 
         private void Btn_print_Click(object sender, EventArgs e) 
         { 
             BuildForm(); 
             string pkValue = GetSelectedPkValue(); 
             if (pkValue != null) 
             { 
                 fvouchertype.SetAction(BtnEvent.Print, pkValue); 
                 fvouchertype.SetFocus(); 
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
 
          public void Vouchertype_lookup()
          {
              txt_vouchertype_name.LookupColNames = new string[] { VOUCHERTYPE.VOUCHERTYPE_NAME };  
             txt_vouchertype_name.LookupUpdate += txt_vouchertype_LookupUpdate;
              txt_vouchertype_name.AllowNewEntry = true;
              txt_vouchertype_name.NewEntryNeeded += txt_vouchertype_NewEntryNeeded;
          }
          void txt_vouchertype_LookupUpdate(object sender, EventArgs e)
          {
              txt_vouchertype_name.LookupList = CVouchertype_exten.GetforLookup(new DAL());
          }
          private FVouchertype fsvouchertype = null;
          void txt_vouchertype_NewEntryNeeded(object sender, string pValue)
          {
              if (fsvouchertype == null)
              {
                  fsvouchertype = new FVouchertype();
              }
              Parent.Controls.Add(fsvouchertype);
              fsvouchertype.Dock = DockStyle.Fill;
              fsvouchertype.Show();
              fsvouchertype.BringToFront();
              fsvouchertype.Focus();
              
              fsvouchertype.SetAction(BtnEvent.New, null);
              fsvouchertype.SetFocus();
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
                  selPkValue = vSelRow.Cells[VOUCHERTYPE.VOUCHERTYPE_ID].Value.ToString();
              }
              return selPkValue;
          }
 
          #endregion[Get selected pk value]
 
 
          #region[RaiseEvent]
 
          void VVouchertype_NeedToRefresh(object sender, EventArgs e)
          {
              List_Option(ListOption.active);
          }
          public event EventHandler LVouchertype_NeedToRefresh;
          public void RaiseEvent_NeedToRefresh()
          {
              if (LVouchertype_NeedToRefresh != null)
              {
                  LVouchertype_NeedToRefresh(this, new EventArgs());
              }
          }
 
          #endregion[RaiseEvent]
 
 
 }//cls
}//ns
