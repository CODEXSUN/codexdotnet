//Version : 1 dt : 11-07-2017
//Auto
//14-07-2017 07:44:25 AM
//create date : 14-07-2017
//last update : 14-07-2017

using System;
using System.Windows.Forms;
using CXLIB;
using System.Drawing;
using System.Data;

namespace AXCODE
{
    public partial class FStables : UserControl
    {
        #region[Split Timer]

        private bool expand;

        private void SplitTimer_Tick(object sender, EventArgs e)
        {
            if (expand)
            {
                if (split_container.SplitterDistance < Convert.ToInt32(ClientSize.Width) - 29)
                {
                    split_container.SplitterDistance += 50;
                }
                else
                {
                    btn_splitter.Text = "⁞⁞";
                    expand = false;
                    splitTimer.Stop();
                }
            }
            else
            {
                if (split_container.SplitterDistance > Convert.ToInt32(ClientSize.Width) - 150)
                {
                    split_container.SplitterDistance += -50;
                }
                else
                {
                    btn_splitter.Text = ">>";
                    expand = true;
                    splitTimer.Stop();
                }
            }
        }
        private void Btn_splitter_Click(object sender, EventArgs e)
        {
            splitTimer.Enabled = true;
        }
        private void Btn_close_Click(object sender, EventArgs e)
        {
            Hide();
            Form_NeedToRefresh();
        }

        #endregion[Split Timer]

        #region[Enter Event]

        private void Txt_databases_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_databases_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_databases_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_databases_id.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_tables_name_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_tables_name.BackColor = Theme.lbl_EnterBackColor;
            lbl_tables_name.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_tables_name.ForeColor = Theme.lbl_EnterForeColor;
        }

        private void Txt_tables_alias_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_tables_alias.BackColor = Theme.lbl_EnterBackColor;
            lbl_tables_alias.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_tables_alias.ForeColor = Theme.lbl_EnterForeColor;
        }
        //private void Txt_createdon_Enter(object sender, EventArgs e)
        //{
        //    Change_infocus();
        //    lbl_createdon.BackColor = Theme.lbl_EnterBackColor;
        //    lbl_createdon.BorderColor = Theme.lbl_EnterBorderColor;
        //    lbl_createdon.ForeColor = Theme.lbl_EnterForeColor;
        //}
        //private void Txt_notes_Enter(object sender, EventArgs e)
        //{
        //    Change_infocus();
        //    lbl_notes.BackColor = Theme.lbl_EnterBackColor;
        //    lbl_notes.BorderColor = Theme.lbl_EnterBorderColor;
        //    lbl_notes.ForeColor = Theme.lbl_EnterForeColor;
        //}
        private void Change_infocus()
        {

            lbl_databases_id.BackColor = Theme.lbl_BackColor;
            lbl_databases_id.BorderColor = Theme.lbl_BorderColor;
            lbl_databases_id.ForeColor = Theme.lbl_ForeColor;

            lbl_tables_name.BackColor = Theme.lbl_BackColor;
            lbl_tables_name.BorderColor = Theme.lbl_BorderColor;
            lbl_tables_name.ForeColor = Theme.lbl_ForeColor;

            //lbl_createdon.BackColor = Theme.lbl_BackColor;
            //lbl_createdon.BorderColor = Theme.lbl_BorderColor;
            //lbl_createdon.ForeColor = Theme.lbl_ForeColor;

            //lbl_notes.BackColor = Theme.lbl_BackColor;
            //lbl_notes.BorderColor = Theme.lbl_BorderColor;
            //lbl_notes.ForeColor = Theme.lbl_ForeColor;

        }

        #endregion[Enter Event]

        #region[Btn Event ]

        private void Btn_grid2_Click(object sender, EventArgs e)
        {
            ToggleGrid2();
        }

        private void Btn_active_Click(object sender, EventArgs e)
        {
            ToggleActive();
        }
        private void Btn_not_active_Click(object sender, EventArgs e)
        {
            Core.Stative = Core.NotActive;
            Setactives();
        }
        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            Form_NeedToRefresh();
            this.Hide();
        }
        private void Btn_save_click(object sender, EventArgs e)
        {
            Save_Event();
        }
        private void Btn_list_Click(object sender, EventArgs e)
        {
            splitTimer.Enabled = true;
            this.Hide();
        }
        private void Btn_new_Click(object sender, EventArgs e)
        {
            splitTimer.Enabled = true;
            SetAction(BtnEvent.New, null);
            editgrid.RowCount = 0;
            editgrid_2.RowCount = 0;
        }
        private void Btn_edit_Click(object sender, EventArgs e)
        {
            if (vId != "")
            {
                splitTimer.Enabled = true;
                SetAction(BtnEvent.Edit, vId);
            }
        }
        private void Btn_delete_Click(object sender, EventArgs e)
        {
            if (vId != "")
            {
                splitTimer.Enabled = true;
                SetAction(BtnEvent.Delete, vId);
            }
        }
        private void Btn_print_Click(object sender, EventArgs e)
        {
            if (vId != "")
            {
                splitTimer.Enabled = true;
                SetAction(BtnEvent.Print, vId);
            }
        }

        #endregion[Btn Event ]

        //#region[Lbl Event ]

        //private void Lbl_notes_Click(object sender, EventArgs e)
        //{
        //    txt_notes.Refresh();
        //    if (txt_notes.Height == 600)
        //    {
        //        txt_notes.BackColor = Color.White;
        //        txt_notes.Width = Theme.F_txt_notes_width - 100;
        //        txt_notes.Height = Theme.F_txt_notes_height;
        //        txt_notes.Location = new Point(Theme.txt_left, Theme.Fpanel_height - 75);
        //    }
        //    else if (txt_notes.Height == Theme.F_txt_notes_height)
        //    {
        //        txt_notes.Location = new Point(lbl_notes.Right - 1, 137);
        //        txt_notes.Width = 1170;
        //        txt_notes.Height = 600;
        //        txt_notes.BackColor = Color.FromArgb(255, 255, 192);
        //    }
        //}
        //#endregion[Lbl Event ]

        #region[Active Event ]

        private void ToggleGrid2()
        {
            if (editgrid_2.Visible == true)
            {
                editgrid_2.Visible = false;
            }
            else
            {
                editgrid_2.Visible = true;
            }
        }

        private void ToggleActive()
        {
            if (btn_active.Text != Core.ACTIVE_TXT)
            {
                btn_active.Themes = Themescheme.Green;
                btn_active.Text = Core.ACTIVE_TXT;
                Core.Stative = Core.Active;
            }
            else
            {
                btn_active.Themes = Themescheme.RED;
                btn_active.Text = Core.NOTACTIVE_TXT;
                Core.Stative = Core.NotActive;
            }
        }


        private void Setactives()
        {
            if (Core.Stative == Core.Active)
            {
                btn_active.Themes = Themescheme.Green;
                btn_save.Focus();
                this.Refresh();
            }
            else if (Core.Stative == Core.NotActive)
            {
                btn_active.Themes = Themescheme.WHITE;
                this.Refresh();
            }
            else if (Core.Stative == Core.Idle)
            {
                btn_active.Themes = Themescheme.WHITE;
            }
        }

        #endregion[Active Event ]

        #region[Raise Event ]

        public event EventHandler FTables_NeedToRefresh;

        public void Form_NeedToRefresh()
        {
            FTables_NeedToRefresh?.Invoke(this, new EventArgs());
        }
        #endregion[Raise Event ]

        #region[Db Database lookup] 

        public void DB_Databases_lookup()
        {
            txt_db_databases.LookupColNames = new string[] { "DATABASE" };
            txt_db_databases.LookupUpdate += Txt_db_databases_LookupUpdate;
            txt_db_databases.AfterSelection += Txt_db_database_AfterSelection;
        }
        void Txt_db_databases_LookupUpdate(object sender, EventArgs e)
        {
            txt_db_databases.LookupList = new DAL().Listdata("SHOW DATABASES");

        }
        private void Txt_db_database_AfterSelection(object sender, EventArgs e)
        {
            var r = txt_db_databases.SelectedEntity;
            if (r != null)
            {
                string database_name = r["DATABASE"].ToString();
                DB_Table_lookup(database_name);
            }
        }

        #endregion[Db Database lookup] 

        #region[Db Table lookup] 

        public void DB_Table_lookup(string database_name)
        {
            txt_db_tables_name.LookupColNames = new string[] { "Tables_in_" + database_name.ToLower() };
            txt_db_tables_name.LookupUpdate += Db_Table_LookupUpdate;
            txt_db_tables_name.AfterSelection += Txt_db_table_AfterSelection;
        }
        void Db_Table_LookupUpdate(object sender, EventArgs e)
        {
            txt_db_tables_name.LookupList = new DAL().Listdata("SHOW TABLES FROM " + txt_db_databases.Text); ;
        }

        private void Txt_db_table_AfterSelection(object sender, EventArgs e)
        {
            var r = txt_db_tables_name.SelectedEntity;
            if (r != null)
            {
                if (chk_WithSub.Checked == true)
                {
                    Load_tbl_structure_2();
                }
                else
                {
                    Load_tbl_structure();
                }

                if (txt_tables_name.Text == "")
                {
                    txt_tables_name.Text = txt_db_tables_name.Text.ToUpper();
                    txt_tables_alias.Text = txt_db_tables_name.Text.ToUpper().Replace("_", " ");

                }
            }
        }

        #endregion[Db Table lookup]

        #region[Load Tbl Structure]
        public void Load_tbl_structure()
        {

            if (txt_db_databases.Text.Trim().Length != 0 && txt_db_tables_name.Text.Trim().Length != 0)
            {
                string q = "SHOW COLUMNS FROM " + txt_db_tables_name.Text + " FROM " + txt_db_databases.Text;

                DataTable tbl = new DAL().Listdata(q);

                editgrid.RowCount = 0;
                editgrid.RowCount = tbl.Rows.Count - 1;
                for (int r = 1; r < tbl.Rows.Count; r++)
                {
                    DataGridViewRow row = editgrid.Rows[r - 1];

                    if (!(((tbl.Rows[r][STRUCTURE.FIELD] + "") == "NOTES") ||
                            ((tbl.Rows[r][STRUCTURE.FIELD] + "") == "ACTIVE_ID") ||
                                ((tbl.Rows[r][STRUCTURE.FIELD] + "") == "USER_ID")))
                    {
                        row.Cells[SFIELDS.SFIELDS_ID].Value = "";
                        row.Cells[SFIELDS.STABLES_ID].Value = "";

                        row.Cells[SFIELDS.FIELDSNAME].Value = tbl.Rows[r][STRUCTURE.FIELD];
                        row.Cells[SFIELDS.DISPLAY_NAME].Value = (tbl.Rows[r][STRUCTURE.FIELD] + "").Replace("_ID", " ");

                        row.Cells[SFIELDS.DATATYPE].Value = Types_delimiter(tbl.Rows[r][STRUCTURE.TYPE] + "").ToUpper();
                        //row.Cells[SFIELDS.LENGTHS].Value = Width_delimiter(tbl.Rows[r][STRUCTURE.TYPE] + "");


                        //row.Cells[SFIELDS.PKEYS].Value = AutoCode.CheckKEYS(tbl.Rows[r][STRUCTURE.KEY] + "");

                        //if (tbl.Rows[r][STRUCTURE.KEY] + "" == "MUL")
                        //{
                        //    row.Cells[SFIELDS.REFEREDTBL].Value = (tbl.Rows[r][STRUCTURE.FIELD] + "").Replace("_ID", "_TBL");
                        //}
                        //else
                        //{
                        //    row.Cells[SFIELDS.REFEREDTBL].Value = "";
                        //}

                        //row.Cells[SFIELDS.IFNULL].Value = AutoCode.CheckNULL(tbl.Rows[r][STRUCTURE.NULL] + "");
                        row.Cells[SFIELDS.INPUTTYPE].Value = "";
                        row.Cells[SFIELDS.WIDTH].Value = "";
                        row.Cells[SFIELDS.HEIGHT].Value = "";
                        row.Cells[SFIELDS.CPOSITION].Value = "";
                        row.Cells[SFIELDS.RPOSITION].Value = "";
                        row.Cells[SFIELDS.ALIGNTO].Value = "";
                        row.Cells[SFIELDS.VALIDATE].Value = "";
                        row.Cells[SFIELDS.ISDEFAULT].Value = "";
                        row.Cells[SFIELDS.PLACEMENT].Value = "";
                    }

                }

            }
        }

        public void Load_tbl_structure_2()
        {

            if (txt_db_databases.Text.Trim().Length != 0 && txt_db_tables_name.Text.Trim().Length != 0)
            {
                string q = "SHOW COLUMNS FROM " + txt_db_tables_name.Text + " FROM " + txt_db_databases.Text;

                DataTable tbl = new DAL().Listdata(q);

                editgrid_2.RowCount = 0;
                editgrid_2.RowCount = tbl.Rows.Count - 1;
                for (int r = 1; r < tbl.Rows.Count; r++)
                {
                    DataGridViewRow row = editgrid_2.Rows[r - 1];

                    if (!(((tbl.Rows[r][STRUCTURE.FIELD] + "") == "NOTES") ||
                            ((tbl.Rows[r][STRUCTURE.FIELD] + "") == "ACTIVE_ID") ||
                                ((tbl.Rows[r][STRUCTURE.FIELD] + "") == "USER_ID")))
                    {
                        row.Cells[SFIELDSITEMS.SFIELDSITEMS_ID].Value = "";
                        row.Cells[SFIELDSITEMS.STABLES_ID].Value = "";

                        row.Cells[SFIELDSITEMS.FIELDSNAME].Value = tbl.Rows[r][STRUCTURE.FIELD];
                        row.Cells[SFIELDSITEMS.DISPLAY_NAME].Value = (tbl.Rows[r][STRUCTURE.FIELD] + "").Replace("_ID", " ");

                        row.Cells[SFIELDSITEMS.DATATYPE].Value = Types_delimiter(tbl.Rows[r][STRUCTURE.TYPE] + "").ToUpper();
                        // row.Cells[SFIELDSITEMS.LENGTHS].Value = Width_delimiter(tbl.Rows[r][STRUCTURE.TYPE] + "");


                        //row.Cells[SFIELDSITEMS.PKEYS].Value = AutoCode.CheckKEYS(tbl.Rows[r][STRUCTURE.KEY] + "");

                        //if (tbl.Rows[r][STRUCTURE.KEY] + "" == "MUL")
                        //{
                        //    row.Cells[SFIELDSITEMS.REFEREDTBL].Value = (tbl.Rows[r][STRUCTURE.FIELD] + "").Replace("_ID", "_TBL");
                        //}
                        //else
                        //{
                        //    row.Cells[SFIELDSITEMS.REFEREDTBL].Value = "";
                        //}

                        //row.Cells[SFIELDSITEMS.IFNULL].Value = AutoCode.CheckNULL(tbl.Rows[r][STRUCTURE.NULL] + "");
                        row.Cells[SFIELDSITEMS.INPUTTYPE].Value = "";
                        row.Cells[SFIELDSITEMS.WIDTH].Value = "";
                    }

                }

            }
        }

        #endregion[Load Tbl Structure]

        #region[Delimiter]
        private string Types_delimiter(string txts)
        {                //
            char[] delimiterChars = { ' ', '(', ')' };
            string[] words = (txts + "").Trim().Split(delimiterChars);
            //
            if (txts.Trim().Length != 0)
            {
                return words[0];
            }
            return "";
        }
        //
        private string Width_delimiter(string txts)
        {                //
            char[] delimiterChars = { ' ', '(', ')' };
            string[] words = (txts + "").Trim().Split(delimiterChars);
            if ((txts.Trim().Length != 0) && (txts.Trim() != "datetime") && (txts.Trim() != "date") && (txts.Trim() != "longtext"))
            {
                return words[1];
            }
            return "";
        }

        #endregion[Delimiter]

        #region[Databases Lookup]

        public void Databases_lookup()
        {
            txt_databases_id.LookupColNames = new string[] { DATABASES.DATABASES_NAME };
            txt_databases_id.LookupUpdate += Txt_databases_LookupUpdate;
            txt_databases_id.AllowNewEntry = true;
            txt_databases_id.NewEntryNeeded += Txt_databases_NewEntryNeeded;
        }
        void Txt_databases_LookupUpdate(object sender, EventArgs e)
        {
            txt_databases_id.LookupList = CDatabases_exten.GetforLookup();
        }
        private FDatabases xdatabases = null;
        void Txt_databases_NewEntryNeeded(object sender, string pValue)
        {
            if (xdatabases == null)
            {
                xdatabases = new FDatabases();
                xdatabases.FDatabases_NeedToRefresh += Databases_NeedToRefresh;
            }
            this.Parent.Controls.Add(xdatabases);
            xdatabases.Dock = DockStyle.Fill;
            xdatabases.Show();
            xdatabases.BringToFront();
            xdatabases.Focus();

            xdatabases.SetAction(BtnEvent.New, null);
            xdatabases.SetFocus();
            xdatabases.setname(pValue);
        }
        void Databases_NeedToRefresh(object sender, EventArgs e)
        {
            txt_databases_id.Text = xdatabases.GetName();
            txt_tables_name.Focus();
        }

        #endregion[DatabasesLookup]

        #region[Namespaces Lookup]

        public void Namespaces_lookup()
        {
            txt_namespaces_id.LookupColNames = new string[] { NAMESPACES.NAMESPACES_NAME };
            txt_namespaces_id.LookupUpdate += Txt_namespaces_LookupUpdate;
            txt_namespaces_id.AllowNewEntry = true;
            txt_namespaces_id.NewEntryNeeded += Txt_namespaces_NewEntryNeeded;
        }
        void Txt_namespaces_LookupUpdate(object sender, EventArgs e)
        {
            txt_namespaces_id.LookupList = CNamespaces_exten.GetforLookup();
        }
        private FNamespaces xnamespaces = null;
        void Txt_namespaces_NewEntryNeeded(object sender, string pValue)
        {
            if (xnamespaces == null)
            {
                xnamespaces = new FNamespaces();
                xnamespaces.FNamespaces_NeedToRefresh += Namespaces_NeedToRefresh;
            }
            this.Parent.Controls.Add(xnamespaces);
            xnamespaces.Dock = DockStyle.Fill;
            xnamespaces.Show();
            xnamespaces.BringToFront();
            xnamespaces.Focus();

            xnamespaces.SetAction(BtnEvent.New, null);
            xnamespaces.SetFocus();
            xnamespaces.setname(pValue);
        }
        void Namespaces_NeedToRefresh(object sender, EventArgs e)
        {
            txt_namespaces_id.Text = xnamespaces.GetName();
            txt_tables_name.Focus();
        }

        #endregion[NamespacesLookup]

        #region[Set Focus]

        public string GetName()
        {
            return txt_databases_id.Text;
        }
        public void Setname(string pName)
        {
            txt_databases_id.Text = pName;
        }
        public void SetFocus()
        {
            txt_databases_id.Focus();
        }
        #endregion[Set Focus]

        #region[Grid lookup]

        private int lookupRow;
        private int lookupCol;
        private string lookupColName;
        private LookupForm frmLookup;

        public void ShowLookupForm()
        {
            FrmLookup_LookupHide(null, null);

            frmLookup = new LookupForm();

            switch (lookupColName)
            {

                case SFIELDS.DATATYPE:
                    {
                        frmLookup.LookupColNames = new string[] { SFIELDS.DATATYPE };
                        frmLookup.SelectedPkValue = editgrid[SFIELDS.DATATYPE, lookupRow].Value;
                        frmLookup.AllowNewEntry = true;
                        frmLookup.AllowEmptySelection = true;

                        frmLookup.LookupList = Datatypes.Lookups();
                        frmLookup.LoadLookupList();
                    }
                    break;

                //case SFIELDS.PKEYS:
                //    {
                //        frmLookup.LookupColNames = new string[] { SFIELDS.PKEYS };
                //        frmLookup.SelectedPkValue = editgrid[SFIELDS.PKEYS, lookupRow].Value;
                //        frmLookup.AllowNewEntry = true;
                //        frmLookup.AllowEmptySelection = true;

                //        frmLookup.LookupList = AutoCode.Pkeys();
                //        frmLookup.LoadLookupList();
                //    }
                //    break;

                //case SFIELDS.IFNULL:
                //    {
                //        frmLookup.LookupColNames = new string[] { SFIELDS.IFNULL };
                //        frmLookup.SelectedPkValue = editgrid[SFIELDS.IFNULL, lookupRow].Value;
                //        frmLookup.AllowNewEntry = true;
                //        frmLookup.AllowEmptySelection = true;

                //        frmLookup.LookupList = AutoCode.Ifnull();
                //        frmLookup.LoadLookupList();
                //    }
                //    break;

                //case SFIELDS.REFEREDTBL:
                //    {
                //        frmLookup.LookupColNames = new string[] { STABLES.STABLES_NAME, STABLES.STABLES_ID };
                //        frmLookup.SelectedPkValue = editgrid[SFIELDS.REFEREDTBL, lookupRow].Value;
                //        frmLookup.AllowNewEntry = true;
                //        frmLookup.AllowEmptySelection = true;

                //        frmLookup.LookupList = CStables_exten.GetforLookup(new SQLITE_DAL());

                //        frmLookup.LoadLookupList();
                //    }
                //    break;

                case SFIELDS.INPUTTYPE:
                    {
                        frmLookup.LookupColNames = new string[] { SFIELDS.INPUTTYPE };
                        frmLookup.SelectedPkValue = editgrid[SFIELDS.INPUTTYPE, lookupRow].Value;
                        frmLookup.AllowNewEntry = true;
                        frmLookup.AllowEmptySelection = true;

                        frmLookup.LookupList = AutoCode.InputType();
                        frmLookup.LoadLookupList();
                    }
                    break;

                case SFIELDS.WIDTH:
                    {
                        frmLookup.LookupColNames = new string[] { SFIELDS.WIDTH };
                        frmLookup.SelectedPkValue = editgrid[SFIELDS.WIDTH, lookupRow].Value;
                        frmLookup.AllowNewEntry = true;
                        frmLookup.AllowEmptySelection = true;

                        frmLookup.LookupList = AutoCode.Width();
                        frmLookup.LoadLookupList();
                    }
                    break;

                case SFIELDS.HEIGHT:
                    {
                        frmLookup.LookupColNames = new string[] { SFIELDS.HEIGHT };
                        frmLookup.SelectedPkValue = editgrid[SFIELDS.HEIGHT, lookupRow].Value;
                        frmLookup.AllowNewEntry = true;
                        frmLookup.AllowEmptySelection = true;

                        frmLookup.LookupList = AutoCode.Height();
                        frmLookup.LoadLookupList();
                    }
                    break;

                case SFIELDS.CPOSITION:
                    {
                        frmLookup.LookupColNames = new string[] { SFIELDS.CPOSITION };
                        frmLookup.SelectedPkValue = editgrid[SFIELDS.CPOSITION, lookupRow].Value;
                        frmLookup.AllowNewEntry = true;
                        frmLookup.AllowEmptySelection = true;

                        frmLookup.LookupList = AutoCode.Cposition();
                        frmLookup.LoadLookupList();
                    }
                    break;

                case SFIELDS.RPOSITION:
                    {
                        frmLookup.LookupColNames = new string[] { SFIELDS.RPOSITION };
                        frmLookup.SelectedPkValue = editgrid[SFIELDS.RPOSITION, lookupRow].Value;
                        frmLookup.AllowNewEntry = true;
                        frmLookup.AllowEmptySelection = true;

                        frmLookup.LookupList = AutoCode.Rposition();
                        frmLookup.LoadLookupList();
                    }
                    break;

                case SFIELDS.ALIGNTO:
                    {
                        frmLookup.LookupColNames = new string[] { SFIELDS.ALIGNTO };
                        frmLookup.SelectedPkValue = editgrid[SFIELDS.ALIGNTO, lookupRow].Value;
                        frmLookup.AllowNewEntry = true;
                        frmLookup.AllowEmptySelection = true;

                        frmLookup.LookupList = AutoCode.Alignto();
                        frmLookup.LoadLookupList();
                    }
                    break;

                case SFIELDS.VALIDATE:
                    {
                        frmLookup.LookupColNames = new string[] { SFIELDS.VALIDATE };
                        frmLookup.SelectedPkValue = editgrid[SFIELDS.VALIDATE, lookupRow].Value;
                        frmLookup.AllowNewEntry = true;
                        frmLookup.AllowEmptySelection = true;

                        frmLookup.LookupList = AutoCode.Validate();
                        frmLookup.LoadLookupList();
                    }
                    break;
                case SFIELDS.ISDEFAULT:
                    {
                        frmLookup.LookupColNames = new string[] { SFIELDS.ISDEFAULT };
                        frmLookup.SelectedPkValue = editgrid[SFIELDS.ISDEFAULT, lookupRow].Value;
                        frmLookup.AllowNewEntry = true;
                        frmLookup.AllowEmptySelection = true;
                        // 
                        frmLookup.LookupList = AutoCode.IsDefault();
                        frmLookup.LoadLookupList();
                    }
                    break;
                case SFIELDS.PLACEMENT:
                    {
                        frmLookup.LookupColNames = new string[] { SFIELDS.PLACEMENT };
                        frmLookup.SelectedPkValue = editgrid[SFIELDS.PLACEMENT, lookupRow].Value;
                        frmLookup.AllowNewEntry = true;
                        frmLookup.AllowEmptySelection = true;
                        // 
                        frmLookup.LookupList = AutoCode.Placement();
                        frmLookup.LoadLookupList();
                    }
                    break;
                case SFIELDS.READONLY:
                    {
                        frmLookup.LookupColNames = new string[] { SFIELDS.READONLY };
                        frmLookup.SelectedPkValue = editgrid[SFIELDS.READONLY, lookupRow].Value;
                        frmLookup.AllowNewEntry = true;
                        frmLookup.AllowEmptySelection = true;
                        // 
                        frmLookup.LookupList = AutoCode.Readonly();
                        frmLookup.LoadLookupList();
                    }
                    break;

                default:
                    throw new System.Exception("'" + lookupColName + "' Not Found");

            }

            frmLookup.LookupSelected += new EventHandler(FrmLookup_LookupSelected);
            frmLookup.AfterSelection += new EventHandler(FrmLookup_AfterSelection);
            frmLookup.LookupHide += new EventHandler(FrmLookup_LookupHide);
            frmLookup.Owner = this.FindForm();
            //////////// 
            frmLookup.Show();
            //////////// 
            int vWidth = frmLookup.GetAutoWidth();
            int vCellWidth = editgrid.Columns[lookupColName].Width;
            if (vWidth < vCellWidth) vWidth = vCellWidth;
            frmLookup.AutoFillLastColumn();
            // 
            int vHeight = frmLookup.GetAutoHeight();
            // 
            Rectangle screenRect = Global.GetScreenRect(editgrid);
            frmLookup.Bounds = Global.GetSnapRect(screenRect, vWidth, vHeight);
        }
        // 
        void FrmLookup_LookupSelected(object sender, EventArgs e)
        {
            DataRow vEntity = frmLookup.SelectedEntity;

            switch (lookupColName)
            {
                case SFIELDS.DATATYPE:
                    if (vEntity == null)
                    {
                        editgrid[SFIELDS.DATATYPE, lookupRow].Value = "";
                    }
                    else
                    {
                        editgrid[SFIELDS.DATATYPE, lookupRow].Value = vEntity[SFIELDS.DATATYPE];
                    }
                    break;

                //case SFIELDS.PKEYS:
                //    if (vEntity == null)
                //    {
                //        editgrid[SFIELDS.PKEYS, lookupRow].Value = "";
                //    }
                //    else
                //    {
                //        editgrid[SFIELDS.PKEYS, lookupRow].Value = vEntity[SFIELDS.PKEYS];
                //    }
                //    break;

                //case SFIELDS.IFNULL:
                //    if (vEntity == null)
                //    {
                //        editgrid[SFIELDS.IFNULL, lookupRow].Value = "";
                //    }
                //    else
                //    {
                //        editgrid[SFIELDS.IFNULL, lookupRow].Value = vEntity[SFIELDS.IFNULL];
                //    }
                //    break;

                //case SFIELDS.REFEREDTBL:
                //    if (vEntity == null)
                //    {
                //        editgrid[SFIELDS.REFEREDTBL, lookupRow].Value = "";
                //    }
                //    else
                //    {
                //        editgrid[SFIELDS.REFEREDTBL, lookupRow].Value = vEntity[STABLES.STABLES_NAME];
                //    }
                //    break;

                case SFIELDS.INPUTTYPE:
                    if (vEntity == null)
                    {
                        editgrid[SFIELDS.INPUTTYPE, lookupRow].Value = "";
                    }
                    else
                    {
                        editgrid[SFIELDS.INPUTTYPE, lookupRow].Value = vEntity[SFIELDS.INPUTTYPE];
                    }
                    break;

                case SFIELDS.WIDTH:
                    if (vEntity == null)
                    {
                        editgrid[SFIELDS.WIDTH, lookupRow].Value = "";
                    }
                    else
                    {
                        editgrid[SFIELDS.WIDTH, lookupRow].Value = vEntity[SFIELDS.WIDTH];
                    }
                    break;

                case SFIELDS.HEIGHT:
                    if (vEntity == null)
                    {
                        editgrid[SFIELDS.HEIGHT, lookupRow].Value = "";
                    }
                    else
                    {
                        editgrid[SFIELDS.HEIGHT, lookupRow].Value = vEntity[SFIELDS.HEIGHT];
                    }
                    break;

                case SFIELDS.CPOSITION:
                    if (vEntity == null)
                    {
                        editgrid[SFIELDS.CPOSITION, lookupRow].Value = "";
                    }
                    else
                    {
                        editgrid[SFIELDS.CPOSITION, lookupRow].Value = vEntity[SFIELDS.CPOSITION];
                    }
                    break;

                case SFIELDS.RPOSITION:
                    if (vEntity == null)
                    {
                        editgrid[SFIELDS.RPOSITION, lookupRow].Value = "";
                    }
                    else
                    {
                        editgrid[SFIELDS.RPOSITION, lookupRow].Value = vEntity[SFIELDS.RPOSITION];
                    }
                    break;

                case SFIELDS.ALIGNTO:
                    if (vEntity == null)
                    {
                        editgrid[SFIELDS.ALIGNTO, lookupRow].Value = "";
                    }
                    else
                    {
                        editgrid[SFIELDS.ALIGNTO, lookupRow].Value = vEntity[SFIELDS.ALIGNTO];
                    }
                    break;

                case SFIELDS.VALIDATE:
                    if (vEntity == null)
                    {
                        editgrid[SFIELDS.VALIDATE, lookupRow].Value = "";
                    }
                    else
                    {
                        editgrid[SFIELDS.VALIDATE, lookupRow].Value = vEntity[SFIELDS.VALIDATE];
                    }
                    break;

                case SFIELDS.ISDEFAULT:
                    if (vEntity == null)
                    {
                        editgrid[SFIELDS.ISDEFAULT, lookupRow].Value = "";
                    }
                    else
                    {
                        editgrid[SFIELDS.ISDEFAULT, lookupRow].Value = vEntity[SFIELDS.ISDEFAULT];
                    }
                    break;
                case SFIELDS.PLACEMENT:
                    if (vEntity == null)
                    {
                        editgrid[SFIELDS.PLACEMENT, lookupRow].Value = "";
                    }
                    else
                    {
                        editgrid[SFIELDS.PLACEMENT, lookupRow].Value = vEntity[SFIELDS.PLACEMENT];
                    }
                    break;
                case SFIELDS.READONLY:
                    if (vEntity == null)
                    {
                        editgrid[SFIELDS.READONLY, lookupRow].Value = "";
                    }
                    else
                    {
                        editgrid[SFIELDS.READONLY, lookupRow].Value = vEntity[SFIELDS.READONLY];
                    }
                    break;
            }
        }

        void FrmLookup_AfterSelection(object sender, EventArgs e)
        {
            editgrid.FocusNextCell();
        }
        // 
        void FrmLookup_LookupHide(object sender, EventArgs e)
        {
            Application.DoEvents();
            Application.DoEvents();
            if (frmLookup != null)
            {
                frmLookup.Dispose();
                frmLookup = null;
            }
        }

        #endregion[Grid lookup]

        #region[Grid lookup 2]

        public void ShowLookupForm_2()
        {
            FrmLookup_2_LookupHide(null, null);

            frmLookup = new LookupForm();

            switch (lookupColName)
            {

                case SFIELDS.DATATYPE:
                    {
                        frmLookup.LookupColNames = new string[] { SFIELDS.DATATYPE };
                        frmLookup.SelectedPkValue = editgrid_2[SFIELDS.DATATYPE, lookupRow].Value;
                        frmLookup.AllowNewEntry = true;
                        frmLookup.AllowEmptySelection = true;

                        frmLookup.LookupList = Datatypes.Lookups();
                        frmLookup.LoadLookupList();
                    }
                    break;

                //case SFIELDS.PKEYS:
                //    {
                //        frmLookup.LookupColNames = new string[] { SFIELDS.PKEYS };
                //        frmLookup.SelectedPkValue = editgrid_2[SFIELDS.PKEYS, lookupRow].Value;
                //        frmLookup.AllowNewEntry = true;
                //        frmLookup.AllowEmptySelection = true;

                //        frmLookup.LookupList = AutoCode.Pkeys();
                //        frmLookup.LoadLookupList();
                //    }
                //    break;

                //case SFIELDS.IFNULL:
                //    {
                //        frmLookup.LookupColNames = new string[] { SFIELDS.IFNULL };
                //        frmLookup.SelectedPkValue = editgrid_2[SFIELDS.IFNULL, lookupRow].Value;
                //        frmLookup.AllowNewEntry = true;
                //        frmLookup.AllowEmptySelection = true;

                //        frmLookup.LookupList = AutoCode.Ifnull();
                //        frmLookup.LoadLookupList();
                //    }
                //    break;

                //case SFIELDS.REFEREDTBL:
                //    {
                //        frmLookup.LookupColNames = new string[] { STABLES.STABLES_NAME, STABLES.STABLES_ID };
                //        frmLookup.SelectedPkValue = editgrid_2[SFIELDS.REFEREDTBL, lookupRow].Value;
                //        frmLookup.AllowNewEntry = true;
                //        frmLookup.AllowEmptySelection = true;

                //        frmLookup.LookupList = CStables_exten.GetforLookup(new SQLITE_DAL());

                //        frmLookup.LoadLookupList();
                //    }
                //    break;

                case SFIELDS.INPUTTYPE:
                    {
                        frmLookup.LookupColNames = new string[] { SFIELDS.INPUTTYPE };
                        frmLookup.SelectedPkValue = editgrid_2[SFIELDS.INPUTTYPE, lookupRow].Value;
                        frmLookup.AllowNewEntry = true;
                        frmLookup.AllowEmptySelection = true;

                        frmLookup.LookupList = AutoCode.InputType();
                        frmLookup.LoadLookupList();
                    }
                    break;

                case SFIELDS.WIDTH:
                    {
                        frmLookup.LookupColNames = new string[] { SFIELDS.WIDTH };
                        frmLookup.SelectedPkValue = editgrid_2[SFIELDS.WIDTH, lookupRow].Value;
                        frmLookup.AllowNewEntry = true;
                        frmLookup.AllowEmptySelection = true;

                        frmLookup.LookupList = AutoCode.Width();
                        frmLookup.LoadLookupList();
                    }
                    break;

                case SFIELDS.HEIGHT:
                    {
                        frmLookup.LookupColNames = new string[] { SFIELDS.HEIGHT };
                        frmLookup.SelectedPkValue = editgrid_2[SFIELDS.HEIGHT, lookupRow].Value;
                        frmLookup.AllowNewEntry = true;
                        frmLookup.AllowEmptySelection = true;

                        frmLookup.LookupList = AutoCode.Height();
                        frmLookup.LoadLookupList();
                    }
                    break;

                case SFIELDS.ALIGNTO:
                    {
                        frmLookup.LookupColNames = new string[] { SFIELDS.ALIGNTO };
                        frmLookup.SelectedPkValue = editgrid_2[SFIELDS.ALIGNTO, lookupRow].Value;
                        frmLookup.AllowNewEntry = true;
                        frmLookup.AllowEmptySelection = true;

                        frmLookup.LookupList = AutoCode.Alignto();
                        frmLookup.LoadLookupList();
                    }
                    break;

                case SFIELDS.VALIDATE:
                    {
                        frmLookup.LookupColNames = new string[] { SFIELDS.VALIDATE };
                        frmLookup.SelectedPkValue = editgrid_2[SFIELDS.VALIDATE, lookupRow].Value;
                        frmLookup.AllowNewEntry = true;
                        frmLookup.AllowEmptySelection = true;

                        frmLookup.LookupList = AutoCode.Validate();
                        frmLookup.LoadLookupList();
                    }
                    break;
                case SFIELDS.ISDEFAULT:
                    {
                        frmLookup.LookupColNames = new string[] { SFIELDS.ISDEFAULT };
                        frmLookup.SelectedPkValue = editgrid_2[SFIELDS.ISDEFAULT, lookupRow].Value;
                        frmLookup.AllowNewEntry = true;
                        frmLookup.AllowEmptySelection = true;
                        // 
                        frmLookup.LookupList = AutoCode.IsDefault();
                        frmLookup.LoadLookupList();
                    }
                    break;
                case SFIELDS.PLACEMENT:
                    {
                        frmLookup.LookupColNames = new string[] { SFIELDS.PLACEMENT };
                        frmLookup.SelectedPkValue = editgrid_2[SFIELDS.PLACEMENT, lookupRow].Value;
                        frmLookup.AllowNewEntry = true;
                        frmLookup.AllowEmptySelection = true;
                        // 
                        frmLookup.LookupList = AutoCode.Placement();
                        frmLookup.LoadLookupList();
                    }
                    break;

                default:
                    throw new System.Exception("'" + lookupColName + "' Not Found");

            }

            frmLookup.LookupSelected += new EventHandler(FrmLookup_2_LookupSelected);
            frmLookup.AfterSelection += new EventHandler(FrmLookup_2_AfterSelection);
            frmLookup.LookupHide += new EventHandler(FrmLookup_2_LookupHide);
            frmLookup.Owner = this.FindForm();
            //////////// 
            frmLookup.Show();
            //////////// 
            int vWidth = frmLookup.GetAutoWidth();
            int vCellWidth = editgrid_2.Columns[lookupColName].Width;
            if (vWidth < vCellWidth) vWidth = vCellWidth;
            frmLookup.AutoFillLastColumn();
            // 
            int vHeight = frmLookup.GetAutoHeight();
            // 
            Rectangle screenRect = Global.GetScreenRect(editgrid_2);
            frmLookup.Bounds = Global.GetSnapRect(screenRect, vWidth, vHeight);
        }
        // 
        void FrmLookup_2_LookupSelected(object sender, EventArgs e)
        {
            DataRow vEntity = frmLookup.SelectedEntity;

            switch (lookupColName)
            {
                case MASTERTABLESITEMS.DATATYPE:
                    if (vEntity == null)
                    {
                        editgrid_2[MASTERTABLESITEMS.DATATYPE, lookupRow].Value = "";
                    }
                    else
                    {
                        editgrid_2[MASTERTABLESITEMS.DATATYPE, lookupRow].Value = vEntity[MASTERTABLESITEMS.DATATYPE];
                    }
                    break;

                //case MTABLESITEMS.PKEYS:
                //    if (vEntity == null)
                //    {
                //        editgrid_2[MTABLESITEMS.PKEYS, lookupRow].Value = "";
                //    }
                //    else
                //    {
                //        editgrid_2[MTABLESITEMS.PKEYS, lookupRow].Value = vEntity[MTABLESITEMS.PKEYS];
                //    }
                //    break;

                //case MTABLESITEMS.IFNULL:
                //    if (vEntity == null)
                //    {
                //        editgrid_2[MTABLESITEMS.IFNULL, lookupRow].Value = "";
                //    }
                //    else
                //    {
                //        editgrid_2[MTABLESITEMS.IFNULL, lookupRow].Value = vEntity[MTABLESITEMS.IFNULL];
                //    }
                //    break;

                //case MTABLESITEMS.REFEREDTBL:
                //    if (vEntity == null)
                //    {
                //        editgrid_2[MTABLESITEMS.REFEREDTBL, lookupRow].Value = "";
                //    }
                //    else
                //    {
                //        editgrid_2[MTABLESITEMS.REFEREDTBL, lookupRow].Value = vEntity[MTABLES.MTABLES_NAME];
                //    }
                //    break;

                case MASTERTABLESITEMS.INPUTTYPE:
                    if (vEntity == null)
                    {
                        editgrid_2[MASTERTABLESITEMS.INPUTTYPE, lookupRow].Value = "";
                    }
                    else
                    {
                        editgrid_2[MASTERTABLESITEMS.INPUTTYPE, lookupRow].Value = vEntity[MASTERTABLESITEMS.INPUTTYPE];
                    }
                    break;

                case MASTERTABLESITEMS.WIDTH:
                    if (vEntity == null)
                    {
                        editgrid_2[MASTERTABLESITEMS.WIDTH, lookupRow].Value = "";
                    }
                    else
                    {
                        editgrid_2[MASTERTABLESITEMS.WIDTH, lookupRow].Value = vEntity[MASTERTABLESITEMS.WIDTH];
                    }
                    break;

                case MASTERTABLESITEMS.HEIGHT:
                    if (vEntity == null)
                    {
                        editgrid_2[MASTERTABLESITEMS.HEIGHT, lookupRow].Value = "";
                    }
                    else
                    {
                        editgrid_2[MASTERTABLESITEMS.HEIGHT, lookupRow].Value = vEntity[MASTERTABLESITEMS.HEIGHT];
                    }
                    break;

                case SFIELDS.ALIGNTO:
                    if (vEntity == null)
                    {
                        editgrid_2[SFIELDS.ALIGNTO, lookupRow].Value = "";
                    }
                    else
                    {
                        editgrid_2[SFIELDS.ALIGNTO, lookupRow].Value = vEntity[SFIELDS.ALIGNTO];
                    }
                    break;

                case MASTERTABLESITEMS.VALIDATE:
                    if (vEntity == null)
                    {
                        editgrid_2[MASTERTABLESITEMS.VALIDATE, lookupRow].Value = "";
                    }
                    else
                    {
                        editgrid_2[MASTERTABLESITEMS.VALIDATE, lookupRow].Value = vEntity[MASTERTABLESITEMS.VALIDATE];
                    }
                    break;

                case MASTERTABLESITEMS.ISDEFAULT:
                    if (vEntity == null)
                    {
                        editgrid_2[MASTERTABLESITEMS.ISDEFAULT, lookupRow].Value = "";
                    }
                    else
                    {
                        editgrid_2[MASTERTABLESITEMS.ISDEFAULT, lookupRow].Value = vEntity[MASTERTABLESITEMS.ISDEFAULT];
                    }
                    break;
                case MASTERTABLESITEMS.PLACEMENT:
                    if (vEntity == null)
                    {
                        editgrid_2[MASTERTABLESITEMS.PLACEMENT, lookupRow].Value = "";
                    }
                    else
                    {
                        editgrid_2[MASTERTABLESITEMS.PLACEMENT, lookupRow].Value = vEntity[MASTERTABLESITEMS.PLACEMENT];
                    }
                    break;



            }
        }

        void FrmLookup_2_AfterSelection(object sender, EventArgs e)
        {
            editgrid_2.FocusNextCell();
        }
        // 
        void FrmLookup_2_LookupHide(object sender, EventArgs e)
        {
            Application.DoEvents();
            Application.DoEvents();
            if (frmLookup != null)
            {
                frmLookup.Dispose();
                frmLookup = null;
            }
        }

        #endregion[Grid lookup 2]

    }//cls 
}//ns 
