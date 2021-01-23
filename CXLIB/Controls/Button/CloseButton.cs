using System.Drawing;
using System.Windows.Forms;

namespace CXLIB
{
    public partial class CloseButton : Button
    {
        public CloseButton()
        {
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoSize = false;
            Margin = new Padding(0, 0, 0, 0);
            Padding = new Padding(0);
            Anchor = XAnchor.TR;
            BackColor = Color.FromArgb(0, 97, 168);
            Cursor = Cursors.Default;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseDownBackColor = Color.OrangeRed;
            FlatAppearance.MouseOverBackColor = Color.Crimson;
            FlatStyle = FlatStyle.Flat;
            Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(217, 237, 255);
            Name = "btn_close";
            Size = new Size(25, 25);
            Text = "X";
            UseVisualStyleBackColor = false;

            Location = XLayout.CloseBtn;
            Size = XSize.CloseBtn;
        }
    }
}
