using System.Drawing;

namespace CXLIB
{
    public class XTheme
    {
        public static Color lbl_EnterBackColor;
        public static Color lbl_EnterBorderColor;
        public static Color lbl_EnterForeColor;
        public static Color lbl_BackColor;
        public static Color lbl_BorderColor;
        public static Color lbl_ForeColor;

        public static Themescheme BlueBtn { get; set; } = Themescheme.BLUE;
        public static Themescheme WhiteBtn { get; set; } = Themescheme.WHITE;
        public static Themescheme YellowBtn { get; set; } = Themescheme.Yellow;
        public static Themescheme PinkBtn { get; set; } = Themescheme.Pink;
        public static Themescheme SteelBtn { get; set; } = Themescheme.Steelblue;
        public static Themescheme RedBtn { get; set; } = Themescheme.RED;

        public static Color Splitcontainer_colour { get; set; } = Color.White;

        public static Color CloseBtn { get; set; } = Color.FromArgb(0, 97, 168);

        public static Color Fheader_Backcolor { get; set; } = Color.FromArgb(0, 114, 198);
        public static Color FheaderText_Fontcolor { get; set; } = Color.White;
        public static Color FPanel { get; internal set; } = Color.White;
        public static Color FInnerpanel { get; internal set; } = Color.White;
        public static Color LInnerpanel { get; internal set; } = Color.White;
        public static Color TxtBackcolor { get; set; } = Color.White;
        public static Color TxtReadonlyBackcolor { get; set; } = Color.White;
    }
}
