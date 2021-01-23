using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CXLIB
{
    public partial class LookupBox : TextBox, IEditBox
    {
        public delegate void NewEntryHandler(object sender, string pValue);

        public event EventHandler ValueChanged;
        public event EventHandler LookupUpdate; //==In this event client is reposible for updating 'LookupList' property.
        public event EventHandler AfterSelection;
        public event NewEntryHandler NewEntryNeeded; //RESPONSIBLE FOR CREATING NEW VALUE, AND UPDATING 'EntityList' & 'SelectedPkValue'.

        private PictureBox btnLookup;

        public LookupBox()
        {
            InitializeComponent();
            ///
            btnLookup = new PictureBox();
            //btnLookup.Image = global::SathguruProject.Properties.Resources.lookup;
            btnLookup.Size = new Size(16, 16);
            btnLookup.Cursor = Cursors.Arrow;
            btnLookup.SizeMode = PictureBoxSizeMode.Zoom;
            btnLookup.Click += new EventHandler(btnLookup_Click);
            this.Controls.Add(btnLookup);
            ///
            base.Padding = new Padding(base.Padding.Left, base.Padding.Top, base.Padding.Right + btnLookup.Width, base.Padding.Bottom);
            ///
            base.ReadOnly = true; //textbox always read-only
            ///
            this.OnResize(null);
        }


        private bool fReadOnly = false;
        public new bool ReadOnly
        {
            get { return fReadOnly; }
            set 
            { 
                fReadOnly = value;
                btnLookup.Enabled = !fReadOnly;
            }
        }

        /// <summary>
        /// CHANGED BY SUNDAR
        ///  public new bool LookupButtonVisible
        /// new has been deleted
        /// </summary>
        public bool LookupButtonVisible
        {
            get { return btnLookup.Visible; }
            set
            {
                btnLookup.Visible = value;
            }
        }

        public object SelectedPkValue = null;
		private DataRow f_DataRow = null;
        public DataRow SelectedEntity
        {
            get { return f_DataRow; }
            set
            {
                f_DataRow = value;
                if (f_DataRow == null)
                {
					SelectedPkValue = null;
					base.Text = "";
                }
                else
                {
					SelectedPkValue = null;
					string vColName = LookupColNames[0];
					base.Text = f_DataRow[vColName] + "";
                }
                ///
                this.OnAfterSelection();
            }
        }
        //private bool f_IsDirtyMode = false;
        //private XEntity f_CommitedValue = null;
        private LookupForm frmLookup;


        public string[] LookupColNames;

        public string[] LookupColHeadings;

        public object DefaultPkValue = null;

        public bool AllowEmptySelection = true;

        private bool f_AllowNewEntry = false;
        ///
        public bool AllowNewEntry
        {
            get { return f_AllowNewEntry; }
            set{ f_AllowNewEntry = value; }
        }

        private DataTable f_LookupList;
        ///
        public DataTable LookupList
        {
            get { return f_LookupList; }
            set { f_LookupList = value; }
        }


        private void OnAfterSelection()
        {
            if (AfterSelection != null)
            {
                AfterSelection(this, new EventArgs());
            }
        }

        //== LOOKUP PROCESS ==================================

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            ///
            if (e.Alt == true && e.KeyCode == Keys.Down)
            {
                e.Handled = true;
                ShowLookupForm();
            }

            if (e.Alt == false && e.Control == false && e.Shift == false)
            {
                if (e.KeyCode == Keys.Up)
                {
                    e.Handled = true;
                    SendKeys.Send("+{TAB}");
                    //==vCtrl.FindForm().SelectNextControl(vCtrl, false, true, true, true);
                }
                else if (e.KeyCode == Keys.Down)
                {
                    e.Handled = true;
                    SendKeys.Send("{TAB}");
                    //==vCtrl.FindForm().SelectNextControl(vCtrl, true, true, true, true);
                }
                else if (e.KeyCode == Keys.Left)
                {
                    if (base.SelectionStart == 0 && base.SelectionLength == 0)
                    {
                        e.Handled = true;
                        SendKeys.Send("+{TAB}");
                    }
                }
                else if (e.KeyCode == Keys.Right)
                {
                    if (base.SelectionStart == base.Text.Length && base.SelectionLength == 0)
                    {
                        e.Handled = true;
                        SendKeys.Send("{TAB}");
                    }
                }
            }

        }

        protected override void OnResize(EventArgs e)
        {
            if (e != null) base.OnResize(e);
            ///
            btnLookup.Size = new Size(this.ClientSize.Height, this.ClientSize.Height);
            btnLookup.Location = new Point(this.ClientSize.Width - btnLookup.Width, 0);
        }

        void btnLookup_Click(object sender, EventArgs e)
        {
            ShowLookupForm();
        }

        public void ShowLookupForm()
        {
            if (fReadOnly == true)
            {
                return;
            }
            ///

            frmLookup_LookupHide(null, null);

            if (LookupUpdate != null)
            {
                LookupUpdate(this, new EventArgs());
            }
            ///
            if (f_LookupList == null)
            {
                return;
            }

            frmLookup = new LookupForm();

            frmLookup.LookupColNames = this.LookupColNames;
            frmLookup.LookupColHeadings = this.LookupColHeadings != null ? this.LookupColHeadings : this.LookupColNames;
            frmLookup.SelectedPkValue = this.SelectedPkValue;
            frmLookup.DefaultPkValue = this.DefaultPkValue;
            frmLookup.AllowNewEntry = this.AllowNewEntry;
            frmLookup.AllowEmptySelection = this.AllowEmptySelection;
            ///
            frmLookup.LookupList = this.f_LookupList; //before 'LookupList', set 'LookupColNames', 'LookupColHeadings', 'SelectedPkValue'
            frmLookup.LoadLookupList();

            //== frmLookup.CalendarChanged += new EventHandler(frmLookup_CalendarChanged);
            //== frmLookup.CalendarRejected += new EventHandler(frmLookupr_CalendarRejected);
            frmLookup.LookupSelected += new EventHandler(frmLookup_LookupSelected);
            frmLookup.AfterSelection += new EventHandler(frmLookup_AfterSelection);
            frmLookup.LookupHide += new EventHandler(frmLookup_LookupHide);
            frmLookup.NewEntryNeeded += new LookupForm.NewEntryHandler(frmLookup_NewEntryNeeded);
            frmLookup.Owner = this.FindForm();
            /////////////////
            frmLookup.Show();
            /////////////////
            int vWidth = frmLookup.GetAutoWidth();
            if (vWidth < this.Width) vWidth = this.Width;
            frmLookup.AutoFillLastColumn();
            ///
            int vHeight = frmLookup.GetAutoHeight();
            ///
            Rectangle screenRect = Global.GetScreenRect(this);
            frmLookup.Bounds = Global.GetSnapRect(screenRect, vWidth, vHeight);
        }

        void frmLookup_NewEntryNeeded(object sender, string pValue)
        {
            OnNewEntryNeeded(pValue);
        }

        private void OnNewEntryNeeded(string pValue)
        {
            if (NewEntryNeeded != null)
            {
                NewEntryNeeded(this, pValue);
            }
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            ///
            ShowLookupForm();
        }

        /*
        void frmLookup_LookupChanged(object sender, EventArgs e)
        {
            if (f_IsDirtyMode == false)
            {
                f_IsDirtyMode = true;
                f_CommitedValue = f_Value;
            }
            ///
            f_Value = frmLookup.SelectedEntity;
            ShowValue();
        }

        void frmLookup_LookupRejected(object sender, EventArgs e)
        {
            if (f_IsDirtyMode == true)
            {
                f_IsDirtyMode = false;
                f_Value = f_CommitedValue;
                ShowValue();
            }
        }
        */

        public void DoProgrammaticSelect()
        {
            if (frmLookup != null)
            {
                frmLookup.DoProgrammaticSelect();
            }
        }

        void frmLookup_LookupSelected(object sender, EventArgs e)
        {
            ///==f_IsDirtyMode = false;
            f_DataRow = frmLookup.SelectedEntity;
            if (f_DataRow == null)
            {
                SelectedPkValue = null;
                base.Text = "";
            }
            else
            {
                SelectedPkValue = null;
                string vColName = LookupColNames[0];
                base.Text = f_DataRow[vColName] + "";
            }
        }

        void frmLookup_AfterSelection(object sender, EventArgs e)
        {
            this.OnAfterSelection();
            this.FindForm().SelectNextControl(this, true, true, true, true);
            //==SendKeys.Send("{TAB}");
        }

        public void DoLookupHide()
        {
            frmLookup_LookupHide(null, null);
        }

        void frmLookup_LookupHide(object sender, EventArgs e)
        {
            Application.DoEvents();
        //    Application.DoEvents();
            if (frmLookup != null)
            {
                frmLookup.Dispose();
                frmLookup = null;
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            ///
            ShowLookupForm();
        }

        //== END OF LOOKUP PROCESS ======================================



        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            ///
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.FindForm().SelectNextControl(this, true, true, true, true);
                return;
            }
        }


        protected virtual void OnValueChanged()
        {
            if (ValueChanged != null)
            {
                ValueChanged(this, new EventArgs());
            }
        }

        protected override void OnValidating(CancelEventArgs e)
        {
            base.OnValidating(e);
            ///

            ///...

            this.OnValueChanged();
        }





        private void ApplyTheme()
        {
            if (base.ReadOnly == true || base.Enabled == false)
            {
                base.BackColor = f_ReadOnlyBackColor;
                base.ForeColor = f_ReadOnlyForeColor;
            }
            else if (this.Focused == true || btnLookup.Focused == true)
            {
                base.BackColor = f_FocusBackColor;
                base.ForeColor = f_FocusForeColor;
            }
            else if (base.Text == "")
            {
                base.BackColor = f_EmptyBackColor;
                base.ForeColor = f_EmptyForeColor;
            }
            else
            {
                base.BackColor = f_FilledBackColor;
                base.ForeColor = f_FilledForeColor;
            }
        }

        protected override void OnReadOnlyChanged(EventArgs e)
        {
            base.OnReadOnlyChanged(e);
            ///
            //btnLookup.Enabled = !txtBox.ReadOnly;
            ///
            ApplyTheme();
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            ///
            ApplyTheme();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            ///
            base.SelectAll();
            ApplyTheme();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            ///
            ApplyTheme();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            ///
            ApplyTheme();
        }

        private Color f_EmptyBackColor = Color.White;
        private Color f_EmptyForeColor = Color.Black;

        private Color f_FilledBackColor = Color.White;
        private Color f_FilledForeColor = Color.White;

        private Color f_FocusBackColor = Color.LightGreen;
        private Color f_FocusForeColor = Color.Black;

        private Color f_ReadOnlyBackColor = Color.White;
        private Color f_ReadOnlyForeColor = Color.Black;

        [Browsable(false)]
        public Color FocusBackColor
        {
            get
            {
                return f_FocusBackColor;
            }
            set
            {
                f_FocusBackColor = value;
                ApplyTheme();
            }
        }

        [Browsable(false)]
        public Color FocusForeColor
        {
            get
            {
                return f_FocusForeColor;
            }
            set
            {
                f_FocusForeColor = value;
                ApplyTheme();
            }
        }


        [Browsable(false)]
        public Color EmptyBackColor
        {
            get
            {
                return f_EmptyBackColor;
            }
            set
            {
                f_EmptyBackColor = value;
                ApplyTheme();
            }
        }

        [Browsable(false)]
        public Color EmptyForeColor
        {
            get
            {
                return f_EmptyForeColor;
            }
            set
            {
                f_EmptyForeColor = value;
                ApplyTheme();
            }
        }

        [Browsable(false)]
        public Color FilledBackColor
        {
            get
            {
                return f_FilledBackColor;
            }
            set
            {
                f_FilledBackColor = value;
                ApplyTheme();
            }
        }


        [Browsable(false)]
        public Color FilledForeColor
        {
            get
            {
                return f_FilledForeColor;
            }
            set
            {
                f_FilledForeColor = value;
                ApplyTheme();
            }
        }


        [Browsable(false)]
        public Color ReadOnlyBackColor
        {
            get { return f_ReadOnlyBackColor; }
            set
            {
                f_ReadOnlyBackColor = value;
                ApplyTheme();
            }
        }


        [Browsable(false)]
        public Color ReadOnlyForeColor
        {
            get { return f_ReadOnlyForeColor; }
            set
            {
                f_ReadOnlyForeColor = value;
                ApplyTheme();
            }
        }


    }
}
