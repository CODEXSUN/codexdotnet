using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CXLIB
{
    public partial class xDateTimepicker : DateTimePicker
    {
        public xDateTimepicker()
        {
            Font = Theme.txtFont;
            CustomFormat = "  dd-MM-yyy hh:mm:ss tt";
            Format = DateTimePickerFormat.Custom;
        }
        private bool f_EnableNavigationKeys = true;
        public bool EnableNavigationKeys
        {
            get { return f_EnableNavigationKeys; }
            set { f_EnableNavigationKeys = value; }
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
                e.Handled = true;
                SendKeys.Send("+{TAB}");
            }
            else if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
            else if (e.KeyCode == Keys.Left)
            {
                e.Handled = true;
                SendKeys.Send("+{TAB}");
            }
            else if (e.KeyCode == Keys.Right)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
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
            if (m.Msg == WM_NCPAINT)
            {
                var hdc = GetWindowDC(this.Handle);
                using (var g = Graphics.FromHdcInternal(hdc))
                using (var p = new Pen(BorderColor))
                    g.DrawRectangle(p, new Rectangle(0, 0, Width - 1, Height - 1));
                ReleaseDC(this.Handle, hdc);

            }

            if (m.Msg == WM_NCPAINT && this.Focused)
            {
                //var dc = GetWindowDC(Handle);
                //using (Graphics g = Graphics.FromHdc(dc))
                //{
                //    g.DrawRectangle(Pens.Green, 0, 0, Width - 1, Height - 1);

                //}

                var hdc = GetWindowDC(this.Handle);
                using (var g = Graphics.FromHdcInternal(hdc))
                using (var p = new Pen(FocusColor))
                    g.DrawRectangle(p, new Rectangle(0, 0, Width - 1, Height - 1));
                ReleaseDC(this.Handle, hdc);
                

            }
        }

    }
}
