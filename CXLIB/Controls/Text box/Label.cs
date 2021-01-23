///  Version : 5 dt : 10-08-2016 
/// 
#region[Conclusion]   
/// create date : 07-10-2016   
/// last update : 07-10-2016     
#endregion[Conclusion]   
///    
#region[using] 
/// 
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
/// 
#endregion[using] 
/// 
#region[namespace] 
/// 
namespace CXLIB
{
    public partial class XLabel : System.Windows.Forms.Label
    {
        /// 
        #endregion[namespace] 
        /// 
        public XLabel()
        {
            InitializeComponent();
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Font = XFont.Font_10B;
            this.Anchor = XAnchor.LT;
            this.TextAlign = ContentAlignment.MiddleLeft;
            this.ForeColor = XFontColor.Lbl_ForeColor;
            this.Size = XSize.OneLabel;


        }

        const int WM_NCPAINT = 0x85;
        const uint RDW_INVALIDATE = 0x1;
        const uint RDW_IUPDATENOW = 0x100;
        const uint RDW_FRAME = 0x400;
        [DllImport("user32.dll")]
        static extern IntPtr GetWindowDC(IntPtr hWnd);
        [DllImport("user32.dll")]
        static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);
        [DllImport("user32.dll")]
        static extern bool RedrawWindow(IntPtr hWnd, IntPtr lprc, IntPtr hrgn, uint flags);

        Color borderColor = Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
        Color focusColor = Color.Red; //FromArgb(((int)(((byte)(54)))), ((int)(((byte)(110)))), ((int)(((byte)(212)))));

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                RedrawWindow(Handle, IntPtr.Zero, IntPtr.Zero,
                    RDW_FRAME | RDW_IUPDATENOW | RDW_INVALIDATE);
            }
        }

        public Color FocusColor
        {
            get { return focusColor; }
            set
            {
                focusColor = value;
                RedrawWindow(Handle, IntPtr.Zero, IntPtr.Zero,
                    RDW_FRAME | RDW_IUPDATENOW | RDW_INVALIDATE);
            }
        }


        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCPAINT && BorderColor != Color.Transparent &&
                BorderStyle == System.Windows.Forms.BorderStyle.FixedSingle)
            {
                var hdc = GetWindowDC(this.Handle);
                using (var g = Graphics.FromHdcInternal(hdc))
                using (var p = new Pen(BorderColor))
                    g.DrawRectangle(p, new Rectangle(0, 0, Width - 1, Height - 1));
                ReleaseDC(this.Handle, hdc);

            }

            //if (m.Msg == WM_NCPAINT && this.Focused)
            //{
            //    //var dc = GetWindowDC(Handle);
            //    //using (Graphics g = Graphics.FromHdc(dc))
            //    //{
            //    //    g.DrawRectangle(Pens.Green, 0, 0, Width - 1, Height - 1);

            //    //}

            //    var hdc = GetWindowDC(this.Handle);
            //    using (var g = Graphics.FromHdcInternal(hdc))
            //    using (var p = new Pen(FocusColor))
            //        g.DrawRectangle(p, new Rectangle(0, 0, Width - 1, Height - 1));
            //    ReleaseDC(this.Handle, hdc);

            //}
        }

        //private bool f_EnableNavigationKeys = true;
        /////
        //public bool EnableNavigationKeys
        //{
        //    get { return f_EnableNavigationKeys; }
        //    set { f_EnableNavigationKeys = value; }
        //}

        //private bool f_EnableLookup = true;
        /////
        //public bool EnableLookup
        //{
        //    get { return f_EnableLookup; }
        //    set { f_EnableLookup = value; }
        //}


        //protected override void OnKeyPress(KeyPressEventArgs e)
        //{
        //    base.OnKeyPress(e);
        //    if (e.Handled == true) return;
        //    ///

        //    if (e.KeyChar == (char)Keys.Enter)
        //    {
        //        if (f_EnableNavigationKeys == false)
        //        {
        //            return;
        //        }
        //        ///
        //        this.FindForm().SelectNextControl(this, true, true, true, true);
        //        return;
        //    }

        //}

        //protected override void OnKeyDown(KeyEventArgs e)
        //{
        //    base.OnKeyDown(e);
        //    if (e.Handled == true) return;
        //    ///
        //    if (f_EnableNavigationKeys == false)
        //    {
        //        //--do-nothing.
        //    }
        //    else if (e.KeyCode == Keys.Up)
        //    {
        //        if (base.Multiline == true)
        //        {
        //            if (base.SelectionStart == 0 && base.SelectionLength == 0)
        //            {
        //                e.Handled = true;
        //                SendKeys.Send("+{TAB}");
        //            }
        //        }
        //        else
        //        {
        //            e.Handled = true;
        //            SendKeys.Send("+{TAB}");
        //        }
        //    }
        //    else if (e.KeyCode == Keys.Down)
        //    {
        //        if (base.Multiline == true)
        //        {
        //            if (base.SelectionStart == base.Text.Length && base.SelectionLength == 0)
        //            {
        //                e.Handled = true;
        //                SendKeys.Send("{TAB}");
        //            }
        //        }
        //        else
        //        {
        //            e.Handled = true;
        //            SendKeys.Send("{TAB}");
        //        }
        //    }
        //    else if (e.KeyCode == Keys.Left)
        //    {
        //        if (base.SelectionStart == 0 && base.SelectionLength == 0)
        //        {
        //            e.Handled = true;
        //            SendKeys.Send("+{TAB}");
        //        }
        //    }
        //    else if (e.KeyCode == Keys.Right)
        //    {
        //        if (base.SelectionStart == base.Text.Length && base.SelectionLength == 0)
        //        {
        //            e.Handled = true;
        //            SendKeys.Send("{TAB}");
        //        }
        //    }
        //}

        //private void ApplyTheme()
        //{
        //    if (base.ReadOnly == true || base.Enabled == false)
        //    {
        //        base.BackColor = f_ReadOnlyBackColor;
        //        base.ForeColor = f_ReadOnlyForeColor;
        //    }
        //    else if (this.Focused == true)
        //    {
        //        base.BackColor = f_FocusBackColor;
        //        base.ForeColor = f_FocusForeColor;
        //    }
        //    else if (base.Text == "")
        //    {
        //        base.BackColor = f_EmptyBackColor;
        //        base.ForeColor = f_EmptyForeColor;
        //    }
        //    else
        //    {
        //        base.BackColor = f_FilledBackColor;
        //        base.ForeColor = f_FilledForeColor;
        //    }
        //}

        //protected override void OnReadOnlyChanged(EventArgs e)
        //{
        //    base.OnReadOnlyChanged(e);
        //    ///
        //    ApplyTheme();
        //}

        //protected override void OnEnabledChanged(EventArgs e)
        //{
        //    base.OnEnabledChanged(e);
        //    ///
        //    ApplyTheme();
        //}

        //protected override void OnGotFocus(EventArgs e)
        //{
        //    base.OnGotFocus(e);
        //    ///
        //    base.SelectAll();
        //    ApplyTheme();

        //}

        //protected override void OnLostFocus(EventArgs e)
        //{
        //    base.OnLostFocus(e);
        //    ///
        //    ApplyTheme();

        //}

        //protected override void OnTextChanged(EventArgs e)
        //{
        //    base.OnTextChanged(e);
        //    ///
        //    ApplyTheme();
        //}

        //private Color f_EmptyBackColor = Color.White;
        //private Color f_EmptyForeColor = Color.Black;

        //private Color f_FilledBackColor = Color.White;
        //private Color f_FilledForeColor = Color.Black;

        ////TODO:
        //private Color f_FocusBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(185)))));
        //private Color f_FocusForeColor = Color.Black;

        //private Color f_ReadOnlyBackColor = Color.White;
        //private Color f_ReadOnlyForeColor = Color.Black;

        //[Browsable(false)]
        //public Color FocusBackColor
        //{
        //    get
        //    {
        //        return f_FocusBackColor;
        //    }
        //    set
        //    {
        //        f_FocusBackColor = value;
        //        ApplyTheme();
        //    }
        //}

        //[Browsable(false)]
        //public Color FocusForeColor
        //{
        //    get
        //    {
        //        return f_FocusForeColor;
        //    }
        //    set
        //    {
        //        f_FocusForeColor = value;
        //        ApplyTheme();
        //    }
        //}


        //[Browsable(false)]
        //public Color EmptyBackColor
        //{
        //    get
        //    {
        //        return f_EmptyBackColor;
        //    }
        //    set
        //    {
        //        f_EmptyBackColor = value;
        //        ApplyTheme();
        //    }
        //}

        //[Browsable(false)]
        //public Color EmptyForeColor
        //{
        //    get
        //    {
        //        return f_EmptyForeColor;
        //    }
        //    set
        //    {
        //        f_EmptyForeColor = value;
        //        ApplyTheme();
        //    }
        //}

        //[Browsable(false)]
        //public Color FilledBackColor
        //{
        //    get
        //    {
        //        return f_FilledBackColor;
        //    }
        //    set
        //    {
        //        f_FilledBackColor = value;
        //        ApplyTheme();
        //    }
        //}

        //[Browsable(false)]
        //public Color FilledForeColor
        //{
        //    get
        //    {
        //        return f_FilledForeColor;
        //    }
        //    set
        //    {
        //        f_FilledForeColor = value;
        //        ApplyTheme();
        //    }
        //}


        //[Browsable(false)]
        //public Color ReadOnlyBackColor
        //{
        //    get { return f_ReadOnlyBackColor; }
        //    set
        //    {
        //        f_ReadOnlyBackColor = value;
        //        ApplyTheme();
        //    }
        //}

        //[Browsable(false)]
        //public Color ReadOnlyForeColor
        //{
        //    get { return f_ReadOnlyForeColor; }
        //    set
        //    {
        //        f_ReadOnlyForeColor = value;
        //        ApplyTheme();
        //    }
        //}
        /////
    }///cls
}///ns
