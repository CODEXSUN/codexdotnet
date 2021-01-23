using System;
using System.Windows.Forms;

namespace CXLIB
{
    public class CxControl : UserControl
    {
        public TabPage mytab = null;

        public event EventHandler NeedToRefresh;

        public void RaiseEvent_NeedToRefresh()
        {
            NeedToRefresh?.Invoke(this, new EventArgs());
        }
    }
}
