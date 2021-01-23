using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CXLIB
{
    [DesignTimeVisible(false)]
    public partial class BaseGridView : DataGridView
    {

        public event EventHandler DownKeyAtLastRow;

        public event EventHandler UpKeyAtFirstRow;

        public event EventHandler RowAction; //ENTER_KEY & MOUSE_DOUBLE_CLICK.

        public event EventHandler RowSelection; //ARROW_KEYS, MOUSE_CLICK


        public BaseGridView()
        {
            InitializeComponent();
            ///
            base.DoubleBuffered = true; /*to reduce flickering,blinking*/
            ///
            Init();
            ///
            DefaultAppearance();
            ///
        }

        private void Init()
        {
            BorderStyle = BorderStyle.Fixed3D;
            StandardTab = true;
        }

        private void DefaultAppearance()
        {
            ///
        }


        //== TO CANCEL 'ENTER' KEY DEFAULT BEHAVIOUR; TO RAISE 'EntitySelected' EVENT; PROVIDE FOR CUSTOM IMPL.
        //==== PBM::ENTER key is swallowed by DataGridView.
        //==== SOL::Use ProcessDialogKey & ProcessDataGridViewKey(overrides) to capture it.
        protected override bool ProcessDialogKey(Keys keyData)
        {
            //== Extract the key code from the key value. 
            Keys key = (keyData & Keys.KeyCode);
            ///
            bool stat = this.ProcessDataGridViewKeyImpl(key);
            if (stat == true)
            {
                return true;
            }
            ///
            return base.ProcessDialogKey(keyData);
        }
        ///
        protected override bool ProcessDataGridViewKey(KeyEventArgs e)
        {
            bool stat = this.ProcessDataGridViewKeyImpl(e.KeyCode);
            if (stat == true)
            {
                return true;
            }
            ///
            return base.ProcessDataGridViewKey(e);
        }
        ///
        private bool ProcessDataGridViewKeyImpl(Keys pKeyCode)
        {
            if (pKeyCode == Keys.Enter)
            {
                OnEnterKeyPressed();
                ProcessRowActionEvent();
                return true; //== returning 'true' will stop current Key processing.
            }
            else if (pKeyCode == Keys.Down)
            {
                if (this.CurrentRow != null)
                {
                    if (this.CurrentRow.Index == this.RowCount - 1) //== if last row ...
                    {
                        OnDownKeyAtLastRow();
                        if (DownKeyAtLastRow != null)
                        {
                            DownKeyAtLastRow(this, new EventArgs());
                        }
                    }
                }
            }
            else if (pKeyCode == Keys.Up)
            {
                if (this.CurrentRow != null)
                {
                    if (this.CurrentRow.Index == 0) //== if first row ...
                    {
                        OnUpKeyAtFirstRow();
                        if (UpKeyAtFirstRow != null)
                        {
                            UpKeyAtFirstRow(this, new EventArgs());
                        }
                    }
                }
            }

            return false;
        }

        protected virtual void OnEnterKeyPressed()
        {
            //== TO BE OVERRIDDEN FOR CUSTOM IMPL.
        }
        ///
        protected virtual void OnDownKeyAtLastRow()
        {
            //== TO BE OVERRIDDEN FOR CUSTOM IMPL.
        }
        ///
        protected virtual void OnUpKeyAtFirstRow()
        {
            //== TO BE OVERRIDDEN FOR CUSTOM IMPL.
        }

        //== TO RAISE 'EntitySelected' EVENT.
        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);
            ///
            ProcessRowActionEvent();
        }


        public int VerticalScrollBarWidth
        {
            get
            {
                if (base.VerticalScrollBar.Visible)
                {
                    return base.VerticalScrollBar.Width;
                }
                else
                {
                    return 0;
                }
            }
        }

        public int HorizontalScrollBarHeight
        {
            get
            {
                if (base.HorizontalScrollBar.Visible)
                {
                    return base.HorizontalScrollBar.Height;
                }
                else
                {
                    return 0;
                }
            }
        }


        public void DownKeyAction()
        {
            if (this.RowCount >= 1)
            {
                if (this.SelectedRow == null)
                {
                    this.CurrentCell = null; //RESET. BECAUSE SETTING THE SAME CURRENT CELL TWICE WILL 'NOT' TRIGGER RELATED EVENTS TWICE.
                    //OR USE!: base.SetSelectedRowCore(0, false);
                    this.CurrentCell = this[0, 0];
                }
                else
                {
                    this.ProcessDataGridViewKeyImpl(Keys.Down);
                    base.ProcessDownKey(Keys.Down);
                }
            }
        }

        public void UpKeyAction()
        {
            if (this.CurrentCell == null)
            {
                if (this.RowCount >= 1)
                {
                    this.CurrentCell = this[0, 0];
                }
            }
            else
            {
                this.ProcessDataGridViewKeyImpl(Keys.Up);
                base.ProcessUpKey(Keys.Up);
            }
        }

        public void PageDownKeyAction()
        {
            if (this.CurrentCell == null)
            {
                if (this.RowCount >= 1)
                {
                    this.CurrentCell = this[0, 0];
                }
            }
            else
            {
                this.ProcessDataGridViewKeyImpl(Keys.PageDown);
                base.ProcessNextKey(Keys.PageDown);
            }
        }

        public void PageUpKeyAction()
        {
            if (this.CurrentCell == null)
            {
                if (this.RowCount >= 1)
                {
                    this.CurrentCell = this[0, 0];
                }
            }
            else
            {
                this.ProcessDataGridViewKeyImpl(Keys.PageUp);
                base.ProcessPriorKey(Keys.PageUp);
            }
        }

        public void MoveToFirstRow()
        {
            if (this.RowCount >= 1)
            {
                this.Refresh();
                int idxFirstRow = 0;
                this.CurrentCell = this[this.FirstDisplayedCell.ColumnIndex, idxFirstRow];
                FirstDisplayedScrollingRowIndex = idxFirstRow;
            }
        }

        public void MoveToLastRow()
        {
            this.Refresh();
            if (this.RowCount >= 1 && this.FirstDisplayedCell != null)
            {
                int idxLastRow = this.RowCount - 1;
                this.CurrentCell = this[this.FirstDisplayedCell.ColumnIndex, idxLastRow];
                FirstDisplayedScrollingRowIndex = idxLastRow;
            }
        }


        public DataGridViewRow SelectedRow
        {
            get
            {
                DataGridViewRow vSelRow = null;
                if (this.SelectedRows != null && this.SelectedRows.Count != 0)
                {
                    vSelRow = this.SelectedRows[0];
                }
                return vSelRow;
            }
        }

        private void ProcessRowActionEvent()
        {
            if (this.SelectedRow != null)
            {
                if (RowAction != null)
                {
                    RowAction(this, new EventArgs());
                }
            }
        }

        protected override void OnCurrentCellChanged(EventArgs e)
        {
            if (e != null) base.OnCurrentCellChanged(e);
            ///
            if (this.SelectionMode == DataGridViewSelectionMode.FullRowSelect)
            {
                if (this.SelectedRow != null) //--SelectedRow will work in FullRowSelectMode only
                {
                    if (RowSelection != null)
                    {
                        RowSelection(this, new EventArgs());
                    }
                }
            }
            else
            {
                if (this.CurrentCell != null)
                {
                    if (RowSelection != null)
                    {
                        RowSelection(this, new EventArgs());
                    }
                }
            }
        }



    }


    public enum SearchResult
    {
        NotFound = 0,
        SingleFound = 1,
        MultiFound = 2
    }


}
