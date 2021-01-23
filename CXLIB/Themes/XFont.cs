using System.Drawing;

namespace CXLIB
{
    public class XFont
    {
        public static Font TxtFont { get; set; } = new Font("Microsoft Sans Serif", 13.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        public static Font BtnFont { get; set; } = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        public static Font Fheader_Font { get; set; } = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        public static Font Font_10B { get { return new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))); } }
        public static Font Font_10R { get { return new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))); } }
        public static Font Font_11R { get { return new Font("Microsoft Sans Serif", 10.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))); } }


        public static Font Font_20B { get; set; } = new Font("Microsoft Sans Serif", 26.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));




        public static string Arial { get; set; } = "Arial";
        public static string Tahoma { get; set; } = "Tahoma";
        public static string MicrosoftSansSerif { get; set; } = "Microsoft Sans Serif";
        public static string Calibri { get; set; } = "Calibri";
        public static string TimesNewRoman { get; set; } = "Times New Roman";
        public static string CooperBlack { get; set; } = "Cooper Black";
        public static string BlackChancery { get; set; } = "BlackChancery";
        public static string Garamond { get; set; } = "Garamond";





    }

    public class XFontColor
    {
        public static Color Lbl_ForeColor { get; set; } = Color.Black;
        public static Color TxtFontColor { get; set; }
    }
}
