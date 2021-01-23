using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CXLIB
{
    [DesignTimeVisible(true)]
    public partial class LookupGridView : BaseGridView
    {
        public LookupGridView()
        {
            InitializeComponent();
            ///
            Init();
            ///
            DefaultAppearance();
        }

        private void Init()
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
        }

        private void DefaultAppearance()
        {
            this.ColumnHeadersDefaultCellStyle.Font = new Font(this.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            ///
            this.EnableHeadersVisualStyles = false;
            ///
            
            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.White;//FromArgb(229, 236, 245);
            this.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;//DarkBlue;
            ///
            this.DefaultCellStyle.BackColor = Color.FromArgb(229, 236, 245);
            this.DefaultCellStyle.ForeColor = Color.Black;
            this.BackgroundColor = Color.FromArgb(229, 236, 245);
            ///===this.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            ///===this.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            
            /*
            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(239, 228, 176);
            this.ColumnHeadersDefaultCellStyle.ForeColor = Color.Navy;
            ///
            this.DefaultCellStyle.BackColor = Color.Cornsilk;
            this.DefaultCellStyle.ForeColor = Color.Navy;
            this.AlternatingRowsDefaultCellStyle.BackColor = Color.PapayaWhip;
            this.AlternatingRowsDefaultCellStyle.ForeColor = Color.Navy;
            */
        }


        public int GetAutoWidth()
        {
            int gwidth = 0;
            gwidth += this.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            gwidth += this.NonClientWidth;
            return gwidth;
        }
        ///
        public int GetAutoHeight()
        {
            int gheight = 0;
            gheight = this.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
            gheight += NonClientHeight;
            return gheight;
        }
        ///
        private int NonClientWidth
        {
            get
            {
                int ncwidth = 0;

                if (this.RowHeadersVisible == true)
                {
                    ncwidth += this.RowHeadersWidth;
                }
                ncwidth += this.VerticalScrollBarWidth;
                ncwidth += this.Size.Width - this.ClientSize.Width;
                ncwidth += this.Size.Width - this.ClientSize.Width + 1;

                if (ncwidth < 0)
                {
                    ncwidth = 0;
                }

                return ncwidth;
            }
        }
        ///
        private int NonClientHeight
        {
            get
            {
                int ncheight = 0;

                if (this.ColumnHeadersVisible == true)
                {
                    ncheight += this.ColumnHeadersHeight;
                }
                ncheight += this.HorizontalScrollBarHeight;
                ncheight += this.Size.Height - this.ClientSize.Height + 1;

                if (ncheight < 0)
                {
                    ncheight = 0;
                }

                return ncheight;
            }
        }


#region SEARCH_AND_HILITE
        public Color HILITE_COLOR = Color.Yellow;

        public SearchResult SearchAndHilite(string sText)
        {
            SearchResult vRes = SearchResult.NotFound;
            //bool vExactFound = false;

            string sColumnName = this.Columns[0].Name;
            if (sText.Trim() != "")
            {
                sText = sText.Trim().ToUpper();
            }
            //==CANCEL_CURRENTCELL_CHANGE_EVENT = true;
            this.CurrentCell = null; //RESET. BECAUSE SETTING THE SAME CURRENT CELL TWICE WILL 'NOT' TRIGGER RELATED EVENTS TWICE.
            //==CANCEL_CURRENTCELL_CHANGE_EVENT = false;
            ///
            for (int r = 0; r < this.RowCount; r++)
            {
                string rText = this.Rows[r].Cells[sColumnName].Value + "";
                if (rText.Trim() != "")
                {
                    rText = rText.Trim().ToUpper();
                }
                ///
                if (sText != "" && rText.StartsWith(sText))
                {
                    /*
                    if (sText == rText)
                    {
                        vExactFound = true;
                        //==CANCEL_CURRENTCELL_CHANGE_EVENT = true;
                        dataGridView1.CurrentCell = dataGridView1[0, r];
                        //==CANCEL_CURRENTCELL_CHANGE_EVENT = false;
                    }
                    */

                    this.Rows[r].DefaultCellStyle.BackColor = HILITE_COLOR;
                    if (vRes == SearchResult.NotFound)
                    {
                        //==CANCEL_CURRENTCELL_CHANGE_EVENT = true;
                        this.CurrentCell = this[0, r];
                        this.OnCurrentCellChanged(null);
                        //==dataGridView1.ClearSelection();
                        //==CANCEL_CURRENTCELL_CHANGE_EVENT = false;
                        ///
                        this.FirstDisplayedCell = this[0, r];
                        vRes = SearchResult.SingleFound;
                    }
                    else if (vRes == SearchResult.SingleFound)
                    {
                        vRes = SearchResult.MultiFound;
                    }
                }
                else
                {
                    this.Rows[r].DefaultCellStyle.BackColor = this.DefaultCellStyle.BackColor;
                }
            }

            return vRes;
        }

        public void ClearHilites()
        {
            for (int r = 0; r < this.RowCount; r++)
            {
                if (this.Rows[r].DefaultCellStyle.BackColor == HILITE_COLOR)
                {
                    this.Rows[r].DefaultCellStyle.BackColor = this.DefaultCellStyle.BackColor;
                }
            }
        }
#endregion

    }
}
