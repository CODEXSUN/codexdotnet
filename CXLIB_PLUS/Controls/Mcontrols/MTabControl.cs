using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CXLIB_PLUS
{
    public class MTabControl : TabControl, IControl
    {
        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public SkinManager SkinManager { get { return SkinManager.Instance; } }
        [Browsable(false)]
        public MouseState MouseState { get; set; }
        
		protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x1328 && !DesignMode) m.Result = (IntPtr)1;
            else base.WndProc(ref m);
        }
    }
}
