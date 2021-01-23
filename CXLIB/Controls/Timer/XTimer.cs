using System.Windows.Forms;

namespace CXLIB
{
    public partial class XTimer : Timer
    {
        public XTimer()
        {
            InitializeComponent();
            Interval = 2;
        }
    }
}
