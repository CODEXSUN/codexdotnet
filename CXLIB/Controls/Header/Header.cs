using System.Drawing;
using System.Windows.Forms;

namespace CXLIB
{
    public class Header:Label
    {
        public Header()
        {
            Anchor = XAnchor.LTR;
            BackColor = Color.FromArgb(0, 114, 198);
            Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            ForeColor = Color.White;
            Name = "lbl_header";
            TextAlign = ContentAlignment.MiddleCenter;
            Location = new Point(5, 0);
            Size = XSize.Header;

        }
    }
}