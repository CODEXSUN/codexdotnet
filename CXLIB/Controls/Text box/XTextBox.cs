//Version : 5 dt : 10-08-2016 
//create date : 07-10-2016   
//last update : 07-10-2016     

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CXLIB
{
    public partial class XTextBox : TextBox
    {
        public XTextBox()
        {
            InitializeComponent();

            Font = XFont.TxtFont;

            ForeColor = XFontColor.TxtFontColor;

            BackColor = XTheme.TxtBackcolor;
        }
        private bool f_EnableNavigationKeys = true;
      
        public bool EnableNavigationKeys
        {
            get { return f_EnableNavigationKeys; }
            set { f_EnableNavigationKeys = value; }
        }

        private bool f_EnableLookup = true;
      
        public bool EnableLookup
        {
            get { return f_EnableLookup; }
            set { f_EnableLookup = value; }
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.Handled == true) return;
          

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (f_EnableNavigationKeys == false)
                {
                    return;
                }
              
                this.FindForm().SelectNextControl(this, true, true, true, true);
                return;
            }

        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.Handled == true) return;
          
            if (f_EnableNavigationKeys == false)
            {
                //--do-nothing.
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (base.Multiline == true)
                {
                    if (base.SelectionStart == 0 && base.SelectionLength == 0)
                    {
                        e.Handled = true;
                        SendKeys.Send("+{TAB}");
                    }
                }
                else
                {
                    e.Handled = true;
                    SendKeys.Send("+{TAB}");
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (base.Multiline == true)
                {
                    if (base.SelectionStart == base.Text.Length && base.SelectionLength == 0)
                    {
                        e.Handled = true;
                        SendKeys.Send("{TAB}");
                    }
                }
                else
                {
                    e.Handled = true;
                    SendKeys.Send("{TAB}");
                }
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

        private void ApplyTheme()
        {
            if (base.ReadOnly == true || base.Enabled == false)
            {
                base.BackColor = f_ReadOnlyBackColor;
                base.ForeColor = f_ReadOnlyForeColor;
            }
            else if (this.Focused == true)
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
          
            ApplyTheme();
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
          
            ApplyTheme();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
          
            base.SelectAll();
            ApplyTheme();

        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
          
            ApplyTheme();

        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
          
            ApplyTheme();
        }

        private Color f_EmptyBackColor = Color.White;
        private Color f_EmptyForeColor = Color.Black;

        private Color f_FilledBackColor = Color.White;
        private Color f_FilledForeColor = Color.Black;

        //TODO:
        private Color f_FocusBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(185)))));
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
      
    }///cls
}///ns
