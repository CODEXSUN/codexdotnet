using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CXLIB
{
    [DesignTimeVisible(true)]
    public partial class EditGridView : BaseGridView
    {
        public const string FOCUSABLE = "FOCUSABLE";
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();

        public delegate void NewRowHandler(object sender, DataGridViewRow pNewRow);
        public event NewRowHandler NewRowAdded; 


        public EditGridView()
        {
            InitializeComponent();
            ///
            InitOnce();
            ResetToDefault();
        }

        private void InitOnce()
        {
            menu_DeleteLine.Click += new EventHandler(menu_DeleteLine_Click);
            menu_InsertLineBefore.Click += new EventHandler(menu_InsertLineBefore_Click);
            menu_InsertLineAfter.Click += new EventHandler(menu_InsertLineAfter_Click);
        }

        /* 
        PRB: Designer serializes certain properties, and they become its default values, irrespective of changes to new default values.
        SOL: clients can call this method for re-init/reset. 
        */
        public void ResetToDefault()
        {

            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 255, 204);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(252, 0, 11);
            //
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(132, 192, 96);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            //
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 255, 204);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(252, 0, 11);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            //
            //==GRID BEHAVIOURS
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            AllowUserToOrderColumns = false;
            SelectionMode = DataGridViewSelectionMode.CellSelect;
            MultiSelect = false;

            //== ROW HEADER BEHAVIOURS
            RowHeadersVisible = false;
            //==== this.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            //==== this.RowHeadersWidth = 20;

            //== ROW BEHAVIOURS
            AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            AllowUserToResizeRows = false;

            //== COLUMN HEADER BEHAVIOURS
            ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ColumnHeadersHeight = 30;

            //== COLUMN BEHAVIOURS
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AllowUserToResizeColumns = true;

            //== DEFAULT APPEARANCE ==//
            EnableHeadersVisualStyles = false;
            BorderStyle = BorderStyle.FixedSingle;

            //== [color & font] ==//
            BackgroundColor = Color.White;//Color.FromArgb(229, 236, 245);
            //ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(229, 236, 245);
            ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkBlue;
            ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular);
            DefaultCellStyle.BackColor = Color.White; //Color.FromArgb(241, 248, 255);
            DefaultCellStyle.ForeColor = Color.Black;
            AlternatingRowsDefaultCellStyle = null;

            //== [border & grid] ==//
            GridColor = Color.LightGray;
            AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.Single;
            AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;
            AdvancedColumnHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            AdvancedColumnHeadersBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.Single;
            AdvancedColumnHeadersBorderStyle.Top  = DataGridViewAdvancedCellBorderStyle.None;
            AdvancedColumnHeadersBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;

            DefaultCellStyle = dataGridViewCellStyle3;
            EnableContextMenu = true;
            EnableHeadersVisualStyles = false;
            GridColor = Color.SeaGreen;
            MultiSelect = false;
            Name = "editgrid";
            RowHeadersVisible = false;
            SelectionMode = DataGridViewSelectionMode.CellSelect;
            StandardTab = true;
            TabIntoComma = false;
            Anchor = XAnchor.LTRB;

            AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            CellBorderStyle = DataGridViewCellBorderStyle.Custom;
            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Custom;

            ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            AllowNewRowOnEnterKey = true;

        }


        /**
        *** NEW-ROW LOGIC
        **/

        //== ON ENTER KEY PRESSED, CAN I CREATE A NEW ROW AFTER LAST ROW?.
        private bool f_AllowNewRowOnEnterKey = true;
        ///
        public bool AllowNewRowOnEnterKey
        {
            get { return f_AllowNewRowOnEnterKey; }
            set { f_AllowNewRowOnEnterKey = value; }
        }

        /*Used for barcode reading 'TAB'*/
        private bool f_TabIntoComma;
        ///
        public bool TabIntoComma 
        {
            get { return f_TabIntoComma; }
            set { f_TabIntoComma = value; }
        }


        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Tab)
            {
                if (f_TabIntoComma == true)
                {
                    SendKeys.Send(",");
                    return true; /* 'true' means: 'Tab' is processed by this procedure; not to be sent to any controls including this Grid. */
                }
            }
            ///
            return base.ProcessDialogKey(keyData);
        }

        //== ON ENTERING, IF NO ROW EXISTS CREATE THE FIRST ROW, AND SET FOCUS TO FIRST COLUMN.
        protected override void OnEnter(EventArgs e)
        {
            if (base.DesignMode == true)
            {
                return; 
            }
            //////////////////////////////////////////

            if (e != null) base.OnEnter(e);
            ///
            if (RowCount == 0)
            {
                if (f_AllowNewRowOnEnterKey == true)
                {
                    Focus();
					int newRowIdx = AddNewRow();
					if (newRowIdx != -1) {
						int firstFocusColIdx = GetFirstFoucusbleCol (newRowIdx);
					}
                }
            }
        }

		public int RowsLimit { get; set; } = -1;

		public int AddNewRow()
		{
			if (RowsLimit == -1 || RowCount < RowsLimit) {
				//
				//DataGridViewRow drow = new DataGridViewRow();
				int rowIdx = Rows.Add ();
				if (NewRowAdded != null) {
					DataGridViewRow drow = Rows[rowIdx]; //==It's a fix.
					NewRowAdded (this, drow);
				}
				return rowIdx;
			} else {
                EndEdit();
                FindForm().SelectNextControl(this, true, true, true, true);
				return -1;
			}
		}

        /**
        *** CELL-FOCUS LOGIC
        **/

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            ///
            OnEnter(null);
            ///
            base.OnCurrentCellChanged(new EventArgs());
        }

        public void FocusNextCell()
        {
            OnEnterKeyPressed();
        }

        //== ON ENTER KEY PRESSED TAKE FOCUS TO NEXT CELL, AND FURTHER TO NEXT ROW FIRST COLUMN.
        protected override void OnEnterKeyPressed()
        {
            if (CurrentCell == null)
            {
                return;
            }
            ///
            int currRowIdx = CurrentCell.RowIndex;
            int currColIdx = CurrentCell.ColumnIndex;
            int nextColIdx = -1;
            int nextRowIdx = currRowIdx;

            //== LOCATE THE NEXT FOUCSABLE COL ==//
            nextColIdx = GetNextFoucusbleCol(currRowIdx, currColIdx);
            ///
            if (nextColIdx == -1) //==IF END-OF-ROW REACHED..
            {
                //==THEN, MOVE TO NEXT ROW'S FIRST FOCUSABLE COL.
                if (nextRowIdx < RowCount - 1)
                {
                    nextRowIdx += 1;
                }
                else //== IT MEANS A LAST ROW; THEN CREATE A NEW ROW.
                {
                    if (f_AllowNewRowOnEnterKey == true)
                    {
                        nextRowIdx = AddNewRow();
                    }
                    else
                    {
                        nextRowIdx = -1;
                        FindForm().SelectNextControl(this, true, true, true, true);
                    }
                }
                ///
                if (nextRowIdx != -1)
                {
                    //== LOCATE THE FIRST FOUCSABLE COL ==//
                    nextColIdx = GetFirstFoucusbleCol(nextRowIdx);
                }
            }
            ///
            if (nextColIdx != -1 && nextRowIdx != -1)
            {
                if (CurrentCell != this[nextColIdx, nextRowIdx])// OTHERWISE UNNECESSARILY INVOKES EVENTS.
                {
                    try
                    {
                        base.SetSelectedCellCore(nextColIdx, nextRowIdx, false);
                        CurrentCell = this[nextColIdx, nextRowIdx];
                    }
                    catch (InvalidOperationException )
                    {
                        //== do-nothing; When 'ValueType' validation fails, grid will not yield focus from that cell until validated.
                    }
                }
            }
        }

        private int GetFirstFoucusbleCol(int pCurrRowIdx)
        {
            int vFirstFocusCol = -1;
            for (int c = 0; c <= ColumnCount - 1; c++)
            {
                if (IsFocusableCell(pCurrRowIdx, c))
                {
                    vFirstFocusCol = c;
                    break;
                }
            }
            return vFirstFocusCol;
        }

        private int GetNextFoucusbleCol(int pCurrRowIdx, int pCurrColIdx)
        {
            int vNextFocusCol = -1;
            for (int c = pCurrColIdx + 1; c <= ColumnCount - 1; c++)
            {
                if (IsFocusableCell(pCurrRowIdx, c))
                {
                    vNextFocusCol = c;
                    break;
                }
            }
            return vNextFocusCol;
        }

        private bool IsFocusableCell(int pRow, int pCol)
        {
            DataGridViewCell vCell = this[pCol, pRow];
            DataGridViewColumn vCol = Columns[pCol];
            if (vCell.Visible == true  && (vCell.ReadOnly == false || vCol.Tag + "" == FOCUSABLE))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /**
        *** CONTEXT-MENU LOGIC
        **/


        private bool f_EnableContextMenu = true;
        ///
        public bool EnableContextMenu
        {
            get { return f_EnableContextMenu; }
            set 
            { 
                f_EnableContextMenu = value;
                ///
                //== contextMenuStrip1.Enabled = value;
                menu_DeleteLine.Enabled = value;
                menu_InsertLineBefore.Enabled = value;
                menu_InsertLineAfter.Enabled = value;
            }
        }


        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            ///
            if (CurrentCell != null)
            {
                if ((int)e.KeyCode == 93) //==Win-Menu key
                {
                    e.Handled = true;
                    Rectangle rectCell = GetCellDisplayRectangle(CurrentCell.ColumnIndex, CurrentCell.RowIndex, true);
                    int x = rectCell.Left + rectCell.Width / 2;
                    int y = rectCell.Top + rectCell.Height / 2;
                    menu_Strip1.Show(this, x, y);
                }
            }
        }


        //== SET A R.CLICKED CELL SELECTED; 
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            ///
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo hit = HitTest(e.X, e.Y);
                if (hit.Type == DataGridViewHitTestType.Cell)
                {
                    ///DataGridViewCell clickedCell = null;
                    ///clickedCell = this[hit.ColumnIndex, hit.RowIndex];
                    ClearSelection(hit.ColumnIndex, hit.RowIndex, true);
                    Rows[hit.RowIndex].Selected = true;
                }
            }
        }

        protected override void OnRowsAdded(DataGridViewRowsAddedEventArgs e)
        {
            base.OnRowsAdded(e);
            ///
            for (int r = e.RowIndex; r <= e.RowIndex + e.RowCount - 1; r++)
            {
                Rows[r].ContextMenuStrip = menu_Strip1;
            }
        }


        public delegate void GridDeleteHandler(object sender, DataGridViewRow pGridRow);
        public event GridDeleteHandler RowDeleted;

        private void menu_DeleteLine_Click(object sender, EventArgs e)
        {
            int vSelecteRow = -1;
            if (SelectedCells.Count != 0)
            {
                vSelecteRow = SelectedCells[0].RowIndex;
            }
            ///
            if (vSelecteRow != -1)
            {
                DataGridViewRow vRow = Rows[vSelecteRow];
                Rows.RemoveAt(vSelecteRow);
                if (RowDeleted != null)
                {
                    RowDeleted(this, vRow);
                }
            }
        }

        private void menu_InsertLineBefore_Click(object sender, EventArgs e)
        {
            int vSelecteRow = -1;
            if (SelectedCells.Count != 0)
            {
                vSelecteRow = SelectedCells[0].RowIndex;
            }
            ///
            if (vSelecteRow != -1)
            {
                Rows.Insert(vSelecteRow, 1);
            }
        }

        private void menu_InsertLineAfter_Click(object sender, EventArgs e)
        {
            int vSelecteRow = -1;
            if (SelectedCells.Count != 0)
            {
                vSelecteRow = SelectedCells[0].RowIndex;
            }
            ///
            if (vSelecteRow != -1)
            {
                Rows.Insert(vSelecteRow + 1, 1);
            }
        }

        protected override void OnDownKeyAtLastRow()
        {
            /*
            this.Focus(); //=PBM OTHERWISE
            this.FindForm().SelectNextControl(this, true, true, true, true);
            */
            if (Focused == true)
            {
                FindForm().SelectNextControl(this, true, true, true, true);
            }
        }

        protected override void OnUpKeyAtFirstRow()
        {
            /*
            this.Focus(); //=PBM OTHERWISE
            this.FindForm().SelectNextControl(this, false, true, true, true);
            */
            if (Focused == true)
            {
                FindForm().SelectNextControl(this, false, true, true, true);
            }
        }




        //== SEARCH LOGIC HERE
        public bool Find(string pText, string pColName)
        {
            pText = pText.ToUpper();
            bool found = false;
            ///
            while (pText != "")
            {
                for (int r = 0; r <= RowCount - 1; r++)
                {
                    if (Rows[r].Visible == true)
                    {
                        string rText = Rows[r].Cells[pColName].Value + "";
                        rText = rText.ToUpper();
                        if (rText.StartsWith(pText))
                        {
                            CurrentCell = this[pColName, r];
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


    
    } //class
} //namespace
