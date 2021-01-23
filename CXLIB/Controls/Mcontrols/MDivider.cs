using System.ComponentModel;
using System.Windows.Forms;

namespace CXLIB
{
    public sealed class MDivider : Control, IControl
    {
        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public SkinManager SkinManager { get { return SkinManager.Instance; } }
        [Browsable(false)]
        public MouseState MouseState { get; set; }
        
        public MDivider()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            Height = 1;
            BackColor = SkinManager.GetDividersColor();
        }
    }
}
