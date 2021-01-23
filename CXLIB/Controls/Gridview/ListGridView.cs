using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CXLIB
{
    [DesignTimeVisible(true)]
    public partial class ListGridView : BaseGridView
    {
        public ContextMenuStrip menu_Strip1;
        public ToolStripMenuItem menu_HideLine;
        public ToolStripMenuItem menu_export_exl;

        public ListGridView()
        {
            InitializeComponent();
            ///
            InitOnce();
            ResetToDefault();
            ///
            /* ak:temp:disabled:- InitSearch(); */
        }

        private void InitOnce()
        {
            this.InitMenu();
        }

        private void InitMenu()
        {
            menu_Strip1 = new ContextMenuStrip();
            menu_Strip1.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            menu_Strip1.ForeColor = Color.RoyalBlue;

            menu_HideLine = new ToolStripMenuItem("Hide This Line");
            menu_HideLine.Click += new EventHandler(menu_HideLine_Click);
            menu_Strip1.Items.Add(menu_HideLine);

            menu_export_exl = new ToolStripMenuItem("Export To Excel");
            menu_export_exl.Click += new EventHandler(menu_export_exl_Click);
            menu_Strip1.Items.Add(menu_export_exl);
        }

        /* 
            PRB: Designer serializes certain properties, and they become its default values, irrespective of changes to new default values.
            SOL: clients can call this method for re-init/reset. 
        */
        public void ResetToDefault()
        {
            //==GRID BEHAVIOURS
            this.ReadOnly = true;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToOrderColumns = true;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.MultiSelect = false;

            //== ROW HEADER BEHAVIOURS
            this.RowHeadersVisible = false;
            //==== this.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            //==== this.RowHeadersWidth = 20;

            //== ROW BEHAVIOURS
            this.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            this.AllowUserToResizeRows = false;

            //== COLUMN HEADER BEHAVIOURS
            this.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ColumnHeadersHeight = 30;

            //== COLUMN BEHAVIOURS
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.AllowUserToResizeColumns = true;

            
            //== DEFAULT APPEARANCE
            this.EnableHeadersVisualStyles = false;
            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BorderStyle = BorderStyle.FixedSingle;
            
            //==[color & font]
            this.BackgroundColor = Color.FromArgb(229, 236, 245);
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(110, 140, 200); //229-236-245
            this.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular);
            this.DefaultCellStyle.BackColor = Color.FromArgb(229, 236, 245);
            this.DefaultCellStyle.ForeColor = Color.Black;
            this.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            this.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

            //==[border & grid]
            this.GridColor = Color.LightGray; // FromArgb(110, 140, 200); //Color.FromArgb(236, 233, 216);
            this.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            this.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.Single;
            this.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            this.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;
            this.AdvancedColumnHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            this.AdvancedColumnHeadersBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.Single;
            this.AdvancedColumnHeadersBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            this.AdvancedColumnHeadersBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;
        }

        protected override void OnRowsAdded(DataGridViewRowsAddedEventArgs e)
        {
            base.OnRowsAdded(e);
            ///
            for (int r = e.RowIndex; r <= e.RowIndex + e.RowCount - 1; r++)
            {
                this.Rows[r].ContextMenuStrip = menu_Strip1;
            }
        }

        //== SET A R.CLICKED CELL SELECTED; 
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            ///
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo hit = this.HitTest(e.X, e.Y);
                if (hit.Type == DataGridViewHitTestType.Cell)
                {
                    ///DataGridViewCell clickedCell = null;
                    ///clickedCell = this[hit.ColumnIndex, hit.RowIndex];
                    this.ClearSelection(hit.ColumnIndex, hit.RowIndex, true);
                    this.Rows[hit.RowIndex].Selected = true;
                }
            }
        }

        public delegate void GridDeleteHandler(object sender, DataGridViewRow pGridRow);
        public event GridDeleteHandler RowDeleted;
        public event EventHandler AfterRowsDeleted;

        void menu_HideLine_Click(object sender, EventArgs e)
        {
            int vSelecteRow = -1;
            if (this.SelectedCells.Count != 0)
            {
                vSelecteRow = this.SelectedCells[0].RowIndex;
            }
            ///
            if (vSelecteRow != -1)
            {
                if (RowDeleted != null)
                {
                    DataGridViewRow vRow = this.Rows[vSelecteRow];
                    RowDeleted(this, vRow);
                }
                ///
                this.Rows.RemoveAt(vSelecteRow);
                ///
                if (AfterRowsDeleted != null)
                {
                    AfterRowsDeleted(this, new EventArgs());
                }
            }
        }

        public void DoKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
        }

        public void DoKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
        }
        
#region SEARCH

        ////////// SEARCH LOGIC STARTS ////////////////////////////////////////////////////////////////////

        //== SEARCH LOGIC HERE
        public bool Find(string pText)
        {
            string sColumnName = this.Columns[0].Name;
            return this.Find(pText, sColumnName);
        }
        public bool Find(string pText, string sColumnName)
        {
            pText = pText.ToUpper();
            bool found = false;
            ///
            while (pText != "")
            {
                for (int r = 0; r <= this.RowCount - 1; r++)
                {
                    if (Rows[r].Visible == true)
                    {
                        string rText = this.Rows[r].Cells[sColumnName].Value + "";
                        rText = rText.ToUpper();
                        if (rText.StartsWith(pText))
                        {
                            this.CurrentCell = this[sColumnName, r];
                            found = true;
                            break; //break-for
                        }
                    }
                }
                if (found == true)
                {
                    break; //break-while
                }
                pText = pText.Substring(0, pText.Length - 1);
            }
            ///
            return found;
        }

        private void menu_export_exl_Click(object sender, EventArgs e)
        {
            this.ExportGrid("");
        }

        public void ExportGrid(string pFileNamePrefix)
        {
            ExlUtil.ExportGrid(this, pFileNamePrefix);
        }


        //private TextBox txtSearch;

        //private void InitSearch()
        //{
        //    txtSearch = new TextBox();
        //    txtSearch.Hide();
        //    txtSearch.CharacterCasing = CharacterCasing.Upper;
        //    txtSearch.BackColor = this.DefaultCellStyle.SelectionBackColor;
        //    txtSearch.ForeColor = Color.White;
        //    txtSearch.Font = new Font(txtSearch.Font, FontStyle.Bold);
        //    txtSearch.Leave += new EventHandler(txtSearch_Leave);
        //    txtSearch.KeyPress += new KeyPressEventHandler(txtSearch_KeyPress);
        //    txtSearch.TextChanged += new EventHandler(txtSearch_TextChanged);
        //    this.Controls.Add(txtSearch);
        //    this.KeyPress += new KeyPressEventHandler(ListGridView_KeyPress);
        //}

        //void ListGridView_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (this.ColumnCount == 0)
        //    {
        //        return;
        //    }

        //    if (this.RowCount == 0)
        //    {
        //        return;
        //    }

        //    if (e.KeyChar == (char)Keys.Tab || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Escape)
        //    {
        //        return;
        //    }

        //    if (e.KeyChar == (char)Keys.Enter)
        //    {
        //        if (txtSearch.Visible == true)
        //        {
        //            this.Focus();
        //            HideSearchBox();
        //        }
        //        ///
        //        /*TO REACT ENTER-PRESS AS MOUSE-DOUBLE-CLICK*/
        //        base.OnMouseDoubleClick(new MouseEventArgs(MouseButtons.None, 0, 0, 0, 0)); 
        //        ///
        //        return;
        //    }

        //    if (e.KeyChar + "" == "")
        //    {
        //        return;
        //    }

        //    Rectangle rect = this.GetCellDisplayRectangle(0, 0, false);
        //    txtSearch.Location = new Point(rect.Left, 0);
        //    txtSearch.Width = this.Columns[0].Width;
        //    txtSearch.Show();
        //    txtSearch.Text = e.KeyChar + "";
        //    txtSearch.SelectionStart = 1;
        //    txtSearch.Focus();
        //}

        ////== EXIT SEARCH MODE WHEN FOCUS LEAVES SEARCH BOX.
        //void txtSearch_Leave(object sender, EventArgs e)
        //{
        //    HideSearchBox();
        //}

        ////== EXIT SEARCH MODE WHEN ESC. PRESSED IN SEARCH BOX.
        //void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)Keys.Escape)
        //    {
        //        this.Focus();
        //        HideSearchBox();
        //        return;
        //    }

        //}

        ////== EXIT SEARCH MODE WHEN ENTER KEY PRESSED IN SEARCH BOX.
        //protected override void OnEnterKeyPressed()
        //{
        //    if (txtSearch.Visible == true)
        //    {
        //        this.Focus();
        //        HideSearchBox();
        //    }
        //}

        //void txtSearch_TextChanged(object sender, EventArgs e)
        //{
        //    if (txtSearch.Text == "")
        //    {
        //        this.Focus();
        //        HideSearchBox();
        //        return;
        //    }
        //    ///
        //    string sText = txtSearch.Text.ToUpper();
        //    bool found = Find(sText);
        //    //this.SearchAndHilite(sText);
        //}

        //private void HideSearchBox()
        //{
        //    txtSearch.Hide();
        //    //this.ClearHilites();
        //}

        //protected override bool ProcessDialogKey(Keys keyData)
        //{
        //    //== Extract the key code from the key value. 
        //    Keys vKey = (keyData & Keys.KeyCode);
        //    if (ProcessKeyLogic(vKey) == true)
        //    {
        //        return true; //== returning 'true' will stop current Key processing.
        //    }
        //    ///
        //    return base.ProcessDialogKey(keyData);
        //}
        /////
        //protected override bool ProcessDataGridViewKey(KeyEventArgs e)
        //{
        //    Keys vKey = e.KeyCode;
        //    if (ProcessKeyLogic(vKey) == true)
        //    {
        //        return true; //== returning 'true' will stop current Key processing.
        //    }
        //    ///
        //    return base.ProcessDataGridViewKey(e);
        //}

        //private bool ProcessKeyLogic(Keys pKey)
        //{
        //    if (pKey == Keys.Left)
        //    {
        //        if (txtSearch.SelectionStart >= 1)
        //        {
        //            txtSearch.SelectionStart = txtSearch.SelectionStart - 1;
        //        }
        //        return true; //== to stop current Key processing.
        //    }
        //    else if (pKey == Keys.Right)
        //    {
        //        txtSearch.SelectionStart = txtSearch.SelectionStart + 1;
        //        return true; //== to stop current Key processing.
        //    }
        //    else if (pKey == Keys.Up || pKey == Keys.Down)
        //    {
        //        if (txtSearch.Visible == true)
        //        {
        //            this.Focus();
        //            HideSearchBox();
        //            return true; //== to stop current Key processing.
        //        }
        //    }
        //    ///
        //    return false;
        //}


        ////////// SEARCH LOGIC ENDS ////////////////////////////////////////////////////////////////////

#endregion



    }

}
