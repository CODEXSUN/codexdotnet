using System.Windows.Forms;

namespace CXLIB
{
    public class XAnchor
    {
        public static AnchorStyles LTRB { get {return AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom; } }
        public static AnchorStyles LTR { get { return AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right; } }
        public static AnchorStyles LTB { get { return AnchorStyles.Left | AnchorStyles.Top |  AnchorStyles.Bottom; } }
        public static AnchorStyles LRB { get { return AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom; } }
        public static AnchorStyles TR { get { return AnchorStyles.Top | AnchorStyles.Right; } }
        public static AnchorStyles RB { get { return AnchorStyles.Right | AnchorStyles.Bottom; } }
        public static AnchorStyles LT { get { return AnchorStyles.Left | AnchorStyles.Top;  } }
        public static AnchorStyles LB { get { return AnchorStyles.Left | AnchorStyles.Bottom; } }
    }
}