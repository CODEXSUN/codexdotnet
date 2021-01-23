using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;

namespace AXCODE
{
    public partial class LStables : UserControl
    {

        #region[Init Grid]

        private void InitGrid()
        {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Stables_Id = new DataGridViewTextBoxColumn();
            col_Stables_Id.Name = STABLES.STABLES_ID;
            col_Stables_Id.HeaderText = "TABLES_ID ";
            //col_Stables_Id.Visible = false;
            col_Stables_Id.Width = 100;
            col_Stables_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Stables_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Stables_Id);

            DataGridViewTextBoxColumn col_Databases_id = new DataGridViewTextBoxColumn();
            col_Databases_id.Name = STABLES.DATABASES_ID;
            col_Databases_id.HeaderText = "DATABASES";
            //col_Databases_id.Visible = false; 
            col_Databases_id.Width = 150;
            col_Databases_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Databases_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Databases_id);

            DataGridViewTextBoxColumn col_Tables_name = new DataGridViewTextBoxColumn();
            col_Tables_name.Name = STABLES.STABLES_NAME;
            col_Tables_name.HeaderText = "TABLES NAME";
            //col_Tables_name.Visible = false; 
            col_Tables_name.Width = 175;
            col_Tables_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Tables_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Tables_name);

            DataGridViewTextBoxColumn col_Tables_alias = new DataGridViewTextBoxColumn();
            col_Tables_alias.Name = STABLES.NAMESPACES_ID;
            col_Tables_alias.HeaderText = "NAMESPACES";
            //col_Tables_alias.Visible = false; 
            col_Tables_alias.Width = 188;
            col_Tables_alias.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Tables_alias.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Tables_alias);

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = STABLES.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false;
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
            if (fstables == null)
            {
                fstables = new FStables();
            }
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fstables.SetAction(BtnEvent.Open, pkValue);
            }
        }

        #endregion[Grid Action]

        #region[Enter Event]

        private void Txt_billtablestype_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_database.BackColor = Theme.lbl_EnterBackColor;
            lbl_database.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_database.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Change_infocus()
        {
            lbl_database.BackColor = Theme.lbl_BackColor;
            lbl_database.BorderColor = Theme.lbl_BorderColor;
            lbl_database.ForeColor = Theme.lbl_ForeColor;
        }

        #endregion[Enter Event]

        #region[Build Form]

        private void BuildForm()
        {
            if (fstables == null)
            {
                fstables = new FStables();
            }
            //fbilltables.FStables_NeedToRefresh += VStables_NeedToRefresh;
            Parent.Controls.Add(fstables);
            fstables.Dock = DockStyle.Fill;
            fstables.Show();
            fstables.BringToFront();

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
            fstables.SetAction(BtnEvent.New, null);
            fstables.SetFocus();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fstables.SetAction(BtnEvent.Edit, pkValue);
                fstables.SetFocus();
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fstables.SetAction(BtnEvent.Delete, pkValue);
                fstables.SetFocus();
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fstables.SetAction(BtnEvent.Print, pkValue);
                fstables.SetFocus();
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

        private void Btn_generate_Click(object sender, EventArgs e)
        {
            STablesScript.SRun(Convert.ToInt32("" + CStables_exten.GetId_Name(txt_mtables.Text)));

            MessageBox.Show("Sucess!");

        }

        #endregion[Btn Event] 

        #region[No lookup]

        public void No_lookup()
        {
            txt_database.LookupColNames = new string[] { DATABASES.DATABASES_NAME };
            txt_database.LookupUpdate += Txt_no_LookupUpdate;
        }
        void Txt_no_LookupUpdate(object sender, EventArgs e)
        {
            txt_database.LookupList = CDatabases_exten.GetforLookup();
        }

        #endregion[No lookup]

        #region[Party lookup]

        public void Party_lookup()
        {
            txt_mtables.LookupColNames = new string[] { STABLES.STABLES_NAME };
            txt_mtables.LookupUpdate += Txt_party_LookupUpdate;
        }
        void Txt_party_LookupUpdate(object sender, EventArgs e)
        {
            txt_mtables.LookupList = CStables_exten.GetforLookup(new SQLITE_DAL());
        }

        #endregion[Party lookup]

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
                selPkValue = vSelRow.Cells[STABLES.STABLES_ID].Value.ToString();
            }
            return selPkValue;
        }

        #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VStables_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }
        public event EventHandler LStables_NeedToRefresh;
        public void RaiseEvent_NeedToRefresh()
        {
            if (LStables_NeedToRefresh != null)
            {
                LStables_NeedToRefresh(this, new EventArgs());
            }
        }

        #endregion[RaiseEvent]

    }//cls
}//ns
