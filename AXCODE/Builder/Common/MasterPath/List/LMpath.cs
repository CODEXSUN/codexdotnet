// Version : 2.1.0.0 dt : 04-12-2018
// Auto Generated
// last update : 06-12-2018 10:53:54 PM

using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;

namespace AXCODE
{
    public partial class LMasterpath : UserControl
    {

        #region[Init Grid]

        private void InitGrid()
        {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Mpath_Id = new DataGridViewTextBoxColumn();
            col_Mpath_Id.Name = MASTERPATH.MASTERPATH_ID;
            col_Mpath_Id.HeaderText = "MPATH_ID ";
            col_Mpath_Id.Visible = false;
            col_Mpath_Id.Width = 100;
            col_Mpath_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Mpath_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Mpath_Id);

            DataGridViewTextBoxColumn col_Mtables_id = new DataGridViewTextBoxColumn();
            col_Mtables_id.Name = MASTERPATH.MASTERTABLES_ID;
            col_Mtables_id.HeaderText = "MTABLES ID";
            //col_Mtables_id.Visible = false; 
            col_Mtables_id.Width = 100;
            col_Mtables_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Mtables_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Mtables_id);

            DataGridViewTextBoxColumn col_Root_folder = new DataGridViewTextBoxColumn();
            col_Root_folder.Name = MASTERPATH.ROOT_FOLDER;
            col_Root_folder.HeaderText = "ROOT FOLDER";
            //col_Root_folder.Visible = false; 
            col_Root_folder.Width = 175;
            col_Root_folder.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Root_folder.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Root_folder);

            DataGridViewTextBoxColumn col_Contfolder = new DataGridViewTextBoxColumn();
            col_Contfolder.Name = MASTERPATH.CONTFOLDER;
            col_Contfolder.HeaderText = "CONT FOLDER";
            //col_Contfolder.Visible = false; 
            col_Contfolder.Width = 175;
            col_Contfolder.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Contfolder.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Contfolder);

            DataGridViewTextBoxColumn col_Classfolder = new DataGridViewTextBoxColumn();
            col_Classfolder.Name = MASTERPATH.CLASSFOLDER;
            col_Classfolder.HeaderText = "CLASS FOLDER";
            //col_Classfolder.Visible = false; 
            col_Classfolder.Width = 188;
            col_Classfolder.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Classfolder.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Classfolder);

            DataGridViewTextBoxColumn col_Formfolder = new DataGridViewTextBoxColumn();
            col_Formfolder.Name = MASTERPATH.FORMFOLDER;
            col_Formfolder.HeaderText = "FORM FOLDER";
            //col_Formfolder.Visible = false; 
            col_Formfolder.Width = 175;
            col_Formfolder.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Formfolder.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Formfolder);

            DataGridViewTextBoxColumn col_Listfolder = new DataGridViewTextBoxColumn();
            col_Listfolder.Name = MASTERPATH.LISTFOLDER;
            col_Listfolder.HeaderText = "LIST FOLDER";
            //col_Listfolder.Visible = false; 
            col_Listfolder.Width = 175;
            col_Listfolder.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Listfolder.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Listfolder);

            DataGridViewTextBoxColumn col_Setupfolder = new DataGridViewTextBoxColumn();
            col_Setupfolder.Name = MASTERPATH.SETUPFOLDER;
            col_Setupfolder.HeaderText = "SETUP FOLDER";
            //col_Setupfolder.Visible = false; 
            col_Setupfolder.Width = 188;
            col_Setupfolder.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Setupfolder.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Setupfolder);

            DataGridViewTextBoxColumn col_Testfolder = new DataGridViewTextBoxColumn();
            col_Testfolder.Name = MASTERPATH.TESTFOLDER;
            col_Testfolder.HeaderText = "TEST FOLDER";
            //col_Testfolder.Visible = false; 
            col_Testfolder.Width = 175;
            col_Testfolder.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Testfolder.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Testfolder);

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = MASTERPATH.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false;
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id);

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
            if (fmpath == null)
            {
                fmpath = new FMpath();
            }
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fmpath.SetAction(BtnEvent.Open, pkValue);
            }
        }

        #endregion[Grid Action]

        #region[Enter Event]

        private void Txt_mpathtype_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_mpath_name.BackColor = Theme.lbl_EnterBackColor;
            lbl_mpath_name.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_mpath_name.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Change_infocus()
        {
            lbl_mpath_name.BackColor = Theme.lbl_BackColor;
            lbl_mpath_name.BorderColor = Theme.lbl_BorderColor;
            lbl_mpath_name.ForeColor = Theme.lbl_ForeColor;
        }

        #endregion[Enter Event]

        #region[Build Form]

        private void BuildForm()
        {
            if (fmpath == null)
            {
                fmpath = new FMpath();
            }
            fmpath.FMpath_NeedToRefresh += VMpath_NeedToRefresh;
            Parent.Controls.Add(fmpath);
            fmpath.Dock = DockStyle.Fill;
            fmpath.Show();
            fmpath.BringToFront();

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
            fmpath.SetAction(BtnEvent.New, null);
            fmpath.SetFocus();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fmpath.SetAction(BtnEvent.Edit, pkValue);
                fmpath.SetFocus();
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fmpath.SetAction(BtnEvent.Delete, pkValue);
                fmpath.SetFocus();
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fmpath.SetAction(BtnEvent.Print, pkValue);
                fmpath.SetFocus();
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

        public void Mtables_lookup()
        {
            txt_mtables_id.LookupColNames = new string[] { MASTERPATH.MASTERTABLES_ID };
            txt_mtables_id.LookupUpdate += txt_mpath_LookupUpdate;
            txt_mtables_id.AllowNewEntry = true;
            txt_mtables_id.NewEntryNeeded += txt_mpath_NewEntryNeeded;
        }
        void txt_mpath_LookupUpdate(object sender, EventArgs e)
        {
            txt_mtables_id.LookupList = CMpath_exten.GetforLookup(new SQLITE_DAL());
        }
        private FMpath fsmpath = null;
        void txt_mpath_NewEntryNeeded(object sender, string pValue)
        {
            if (fsmpath == null)
            {
                fsmpath = new FMpath();
            }
            Parent.Controls.Add(fsmpath);
            fsmpath.Dock = DockStyle.Fill;
            fsmpath.Show();
            fsmpath.BringToFront();
            fsmpath.Focus();

            fsmpath.SetAction(BtnEvent.New, null);
            fsmpath.SetFocus();
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
                selPkValue = vSelRow.Cells[MASTERPATH.MASTERPATH_ID].Value.ToString();
            }
            return selPkValue;
        }

        #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VMpath_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }
        public event EventHandler LMpath_NeedToRefresh;
        public void RaiseEvent_NeedToRefresh()
        {
            if (LMpath_NeedToRefresh != null)
            {
                LMpath_NeedToRefresh(this, new EventArgs());
            }
        }

        #endregion[RaiseEvent]

    }//cls
}//ns
