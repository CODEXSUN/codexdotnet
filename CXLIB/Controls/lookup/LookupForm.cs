using System;
using System.Data;
using System.Windows.Forms;

/*
INPUTS:
 1) LookupColNames 
	LookupColHeadings 
	SelectedPkValue 
	DefaultPkValue
	AllowEmptySelection
	AllowNewEntry
 2) LookupList 

OUTPUTS:
 1) SelectedEntity  -- NULL ON NEW-ENTRY/EMPTY
 2) SelectedPkValue -- NULL ON NEW-ENTRY/EMPTY
 3) NEW_VALUE
*/


namespace CXLIB
{
	public partial class LookupForm : Form
	{
		//== public event EventHandler LookupChanged;
		public event EventHandler LookupSelected;
		public event EventHandler AfterSelection;
		public event EventHandler LookupRejected;
		public event EventHandler LookupHide;

		public delegate void NewEntryHandler(object sender, string pValue);
		public event NewEntryHandler NewEntryNeeded; //RESPONSIBLE FOR CREATING NEW VALUE, AND UPDATING 'EntityList' & 'SelectedPkValue'.

		private int COLSTART = 0;

		public LookupForm()
		{
			InitializeComponent();
			///
			this.StartPosition = FormStartPosition.Manual;
			this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			this.ControlBox = false;
			this.Text = "";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.KeyPreview = true;
			///

			this.Deactivate += new EventHandler(LookupForm_Deactivate);
			this.KeyDown += new KeyEventHandler(LookupForm_KeyDown);
			this.Shown += new EventHandler(LookupForm_Shown);
			///

			this.AllowNewEntry = false; //RUN-TIME-DEFAULT.

			txtSearch.KeyPress += new KeyPressEventHandler(txtSearch_KeyPress);
			txtSearch.KeyDown += new KeyEventHandler(txtSearch_KeyDown);
			txtSearch.TextChanged += new EventHandler(txtSearch_TextChanged);
			///

			listGridView1.ColumnHeadersVisible = false;
			listGridView1.UpKeyAtFirstRow += new EventHandler(listGridView1_UpKeyAtFirstRow);
			listGridView1.DownKeyAtLastRow += new EventHandler(listGridView1_DownKeyAtLastRow);
			listGridView1.RowAction += new EventHandler(listGridView1_RowAction);
			listGridView1.RowSelection += new EventHandler(listGridView1_RowSelection);
		}

		public bool ColumnHeadersVisible
		{
			get
			{
				return listGridView1.ColumnHeadersVisible;
			}
			set
			{
				listGridView1.ColumnHeadersVisible = value;
			}
		}

		public string LookupColName
		{
			get { return LookupColNames[0]; }
			set { LookupColNames = new string[]{ value }; }
		}

		public string[] LookupColNames;

		public string[] FormatStrings;

		public string[] LookupColHeadings;

		public object DefaultPkValue = null;

		public bool AllowEmptySelection = true;

		private bool f_AllowNewEntry = true; //DESIGNED-TIME-DEFAULT; CHANGED IN CONSTRUCTOR(RUN-TIME-DEFAULT).
		///
		public bool AllowNewEntry
		{
			get { return f_AllowNewEntry; }
			set 
			{
				if (f_AllowNewEntry != value) //only if the value is changed.
				{
					f_AllowNewEntry = value;
				}
			}
		}

		private DataTable f_DataTable;
		///
		public DataTable LookupList
		{
			get { return f_DataTable; }
			set { f_DataTable = value; /*== LoadLookupList() funtion is called from client(LookupBox..).*/ }
		}
				
		///
		public void LoadLookupList()
		{
			/*
			 * REMOVE EXISTING ROWS & COLUMNS
			 */
			listGridView1.RowCount = 0;
			listGridView1.ColumnCount = 0;

			/*
			 * CREATE COLUMNS FOR GRID
			 */
			//DataGridViewTextBoxColumn colpk = new DataGridViewTextBoxColumn();
			//colpk.Name = PK_COLUMN;
			//colpk.Visible = false;
			//listGridView1.Columns.Add(colpk);

			for (int i = 0; i <= this.LookupColNames.Length-1; i++)
			{
				DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
				col1.Name = this.LookupColNames[i];
				if(this.LookupColHeadings == null)
				{
					this.LookupColHeadings = this.LookupColNames;
				}
				try /*BECAUSE COL HEADINGS ARE OPTIONAL*/
				{
					col1.HeaderText = this.LookupColHeadings[i];
				}
				catch (Exception) { /*SUPPRESS ERRORS*/ }
				if (i == this.LookupColNames.Length - 1) ///==if LAST_COLUMN
				{
					col1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells; //-- Fill;
				}
				else
				{
					col1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
				}
				listGridView1.Columns.Add(col1);
			}

			/*
			 * LOAD DATA INTO GRID
			 */
			listGridView1.RowCount = this.f_DataTable.Rows.Count;
			for (int r = 0; r <= this.f_DataTable.Rows.Count-1; r++)
			{
				DataRow dataRow = this.f_DataTable.Rows[r];
				DataGridViewRow row = listGridView1.Rows[r];

				//row.Cells[PK_COLUMN].Value = entity.PkValue;
				for (int c = 0; c <= this.LookupColNames.Length-1; c++)
				{
					string vValue = "";
					object vObjValue = dataRow[this.LookupColNames[c]];
					string vFmtStr = this.GetFormatString(c);
					if (vFmtStr.Contains("0") || vFmtStr.Contains("#"))
					{
						decimal vDecValue = Global.ToDecimal(vObjValue);
						if (vDecValue == 0)
						{
							vValue = "";
						}
						else
						{
							if (vFmtStr != "")
							{
								vValue = vDecValue.ToString(vFmtStr);
							}
							else
							{
								vValue = vDecValue.ToString();
							}
						}
					}
					else if (vFmtStr.Contains("d") || vFmtStr.Contains("M") || vFmtStr.Contains("y"))
					{
						DateTime? vDateValue = Global.ToDateTime(vObjValue);
						if (vDateValue == null)
						{
							vValue = "";
						}
						else
						{
							if (vFmtStr != "")
							{
								vValue = vDateValue.Value.ToString(vFmtStr);
							}
							else
							{
								vValue = vDateValue.Value.ToString();
							}
						}
					}
					else
					{
						vValue = vObjValue + "";
					}
					///
					row.Cells[this.LookupColNames[c]].Value = vValue;
				}
			}
			listGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

			/*
			 * SET DEFAULT SELECTED ROW.
			 */
			listGridView1.ClearSelection();
			///
			if (listGridView1.RowCount >= 1) {
				listGridView1.CurrentCell = null; //RESET. BECAUSE SETTING THE SAME CURRENT CELL TWICE WILL 'NOT' TRIGGER RELATED EVENTS TWICE.
				listGridView1.CurrentCell = listGridView1[COLSTART, 0];
			}
		}

		protected override void OnVisibleChanged(EventArgs e)
		{
			base.OnVisibleChanged(e);
			///
			if (this.Visible == true)
			{
				if (f_AllowNewEntry == false)
				{
					btn_new.Visible = false;
					txtSearch.Width += (btn_new.Right - txtSearch.Right); 
				}
			}
		}


		private DataRow f_SelectedDataRow;
		///
		public DataRow SelectedEntity
		{
			get { return f_SelectedDataRow; }
			set { f_SelectedDataRow = value; }
		}

		private object f_SelectedPkValue;
		///
		public object SelectedPkValue
		{
			get { return f_SelectedPkValue; }
			set { f_SelectedPkValue = value; }
		}

		private string f_NewEntryValue;
		///
		public string NewEntryValue
		{
			get { return f_NewEntryValue; }
			//==set { f_NewEntryValue = value; }
		}



		private void LookupForm_Shown(object sender, EventArgs e)
		{
			txtSearch.Focus();
		}



		/*
		* SEARCH PROCESS
		*/
		private bool CANCEL_TEXT_CHANGED_EVENT = false;
		void txtSearch_TextChanged(object sender, EventArgs e)
		{
			if (CANCEL_TEXT_CHANGED_EVENT == true)
			{
				return;
			}
			///
			CANCEL_GRID_CHANGED_EVENT = true;
			listGridView1.SearchAndHilite(txtSearch.Text);
			CANCEL_GRID_CHANGED_EVENT = false;
		}
		///
		private bool CANCEL_GRID_CHANGED_EVENT = false;
		void listGridView1_RowSelection(object sender, EventArgs e)
		{
			if (CANCEL_GRID_CHANGED_EVENT == true)
			{
				return;
			}
			///
			CANCEL_TEXT_CHANGED_EVENT = true;
			txtSearch.Text = listGridView1.SelectedRow.Cells[COLSTART].Value + "";
			txtSearch.SelectAll();
			listGridView1.ClearHilites();
			CANCEL_TEXT_CHANGED_EVENT = false;
		}


		/*
		* SELECTION CRITERIA: ENTER KEY PRESSED ON TEXT BOX
		*/
		void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				if (txtSearch.Text == "")
				{
					if (this.AllowEmptySelection == true)
					{
					   f_SelectedDataRow = null;
						SelectedPkValue = null;
						///
						OnLookupSelected();
						///
						OnHide();
						///
						OnAfterSelection();
					}
				}
				else if (listGridView1.SearchAndHilite(txtSearch.Text) == SearchResult.NotFound)
				{
					if (AllowNewEntry == true)
					{
						f_SelectedDataRow = null;
						SelectedPkValue = null;
						f_NewEntryValue = txtSearch.Text;
						OnNewEntryNeeded(txtSearch.Text);
						/*CASE: MODAL FORM NEW ENTRY:
							IN THE PREVIOUSE STEP, CLIENT MAY HAVE UPDATED THE 'EntityList' & 'SelectedPkValue' property.
							this.LoadLookupList(); //RELOADS 'EntityList'.
						*/
					}
				}
				else
				{
					listGridView1_RowAction(null, null);
				}
			}
		}


		/*
		* SELECTION CRITERIA: ENTER KEY PRESSED OR MOUSE DOUBLE CLICKED ON GRID
		*/
		void listGridView1_RowAction(object sender, EventArgs e)
		{
			if (listGridView1.SelectedRow == null)
			{
				///do-nothing
			}
			else
			{
				int vSelRow = listGridView1.SelectedRow.Index;
				DataRow vSelDataRow = f_DataTable.Rows[vSelRow];
				f_SelectedDataRow = vSelDataRow;
				SelectedPkValue = null;
				///
				OnLookupSelected();
				///
				OnHide();
				///
				OnAfterSelection();
			}
		}
		///
		public void DoProgrammaticSelect()
		{
			this.listGridView1_RowAction(null, null);
		}
		///
		private void btn_new_Click(object sender, EventArgs e)
		{
			OnNewEntryNeeded("");
		}
		///
		private void OnNewEntryNeeded(string pValue)
		{
			if (NewEntryNeeded != null)
			{
				NewEntryNeeded(this, pValue);
			}
		}
		///
		private void OnLookupSelected()
		{
			if (LookupSelected != null)
			{
				LookupSelected(this, new EventArgs());
			}
		}
		///
		private void OnAfterSelection()
		{
			if (AfterSelection != null)
			{
				AfterSelection(this, new EventArgs());
			}
		}
		///
		private void OnLookupRejected()
		{
			if (LookupRejected != null)
			{
				LookupRejected(this, new EventArgs());
			}
		}

		///
		/*
	private void btnSelect_Click(object sender, EventArgs e)
	{
		if (LookupSelected != null)
		{
			LookupSelected(this, new EventArgs());
		}
		if (SelectClick != null)
		{
			if (txtSearchPro.Text == "")
			{
				SelectClick(this, new EventArgs());
			}
			else
			{
				if (f_GridView.SearchAndHilite(txtSearchPro.Text) == SearchResult.NotFound)
				{
					if (f_AllowNewEntry == true)
					{
						if (DialogResult.Yes == MessageBox.Show(this.FindForm(), "Do You Want To Create a New Entry?\r\n\r\n" + txtSearchPro.Text, "New Entry...", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
						{
							OnNewEntryNeeded(txtSearchPro.Text);
						}
					}
				}
				else
				{
					SelectClick(this, new EventArgs());
				}
			}
		}
	}
		*/

		/*
		* GRID KEYS FORWARDED FROM TEXTBOX.
		*/
		void txtSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Down)
			{
				listGridView1.DownKeyAction();
				//listGridView1.SearchAndHilite( listGridView1.Rows[0].Cells[COLSTART].Value + "" );
				e.Handled = true;
				listGridView1.Focus();
			}
			else if (e.KeyCode == Keys.Up)
			{
			   listGridView1.UpKeyAction();
				e.Handled = true;
				listGridView1.Focus();
			}
			else if (e.KeyCode == Keys.PageDown)
			{
				listGridView1.PageDownKeyAction();
				e.Handled = true;
				listGridView1.Focus();
			}
			else if (e.KeyCode == Keys.PageUp)
			{
				listGridView1.PageUpKeyAction();
				e.Handled = true;
				listGridView1.Focus();
			}

		}

		/*
		* EXIT CRITERIAS
		*/
		private void LookupForm_Deactivate(object sender, EventArgs e)
		{
			OnHide();
		}
		///

		private void btn_close_Click(object sender, EventArgs e)
		{
			OnHide();
		}
		///
		void LookupForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && e.Control == false && e.Alt == false && e.Shift == false)
			{
				OnLookupRejected();
				///
				OnHide();
				///
				e.Handled = true;
			}
			else if (e.Alt == true && e.KeyCode == Keys.C && e.Control == false && e.Shift == false)
			{
				btn_new_Click(null, null);
				e.Handled = true;
			}
		}
		///
		void listGridView1_UpKeyAtFirstRow(object sender, EventArgs e)
		{
			OnHide();
		}
		///
		void listGridView1_DownKeyAtLastRow(object sender, EventArgs e)
		{
			OnHide();
		}
		///
		private bool CANCEL_LOOKUP_HIDE_EVENT=false;
		///
		private void OnHide()
		{
			if (CANCEL_LOOKUP_HIDE_EVENT == true)
			{
				return;
			}
			///
			if (LookupHide != null)
			{
				CANCEL_LOOKUP_HIDE_EVENT = true;
				LookupHide(this, new EventArgs());
				CANCEL_LOOKUP_HIDE_EVENT = false;
			}
		}
		public int GetAutoWidth()
		{
			return listGridView1.GetAutoWidth() + 8;
		}
		public void AutoFillLastColumn()
		{
			if (listGridView1.Columns.Count != 0)
			{
				listGridView1.Columns[listGridView1.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			}
		}
		public int GetAutoHeight()
		{
			return listGridView1.GetAutoHeight() + listGridView1.Top + 8;
		}

		private string GetFormatString(int pColIndex)
		{
			if (FormatStrings == null)
			{
				return "";
			}
			else
			{
				if (FormatStrings.Length - 1 >= pColIndex)
				{
					return FormatStrings[pColIndex] + "";
				}
				else
				{
					return "";
				}
			}
		}

	}
}
