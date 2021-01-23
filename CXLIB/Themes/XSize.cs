using System.Drawing;
using System.Windows.Forms;

namespace CXLIB
{
    public class XSize
    {

        #region[Gap]
        public static int BtnGap { get; set; } = 50;
        public static int RowGap { get; set; } = 35;
        public static int ColumnGap { get; set; } = 20;
        public static int Margin { get; set; } = 65;

        #endregion[Gap]

        #region[Screen  width]

        public static int Screen_Width { get; set; } = Screen.PrimaryScreen.Bounds.Width;
        public static int Screen_Heigth { get; set; } = Screen.PrimaryScreen.Bounds.Height;

        #endregion[Screen  width]

        #region[FSplitcontainer]

        private static int Splitcontainer_width { get; set; } = Screen_Width;
        private static int Splitcontainer_height { get; set; } = Screen_Heigth;
        public static Size FSplitcontainer
        {
            get => new Size(Splitcontainer_width, Splitcontainer_height);

        }

        #endregion[FSplitcontainer]

        #region[FPanel]

        public static int FPanel_width { get; set; } = Splitcontainer_width - 60;
        public static int FPanel_height { get; set; } = Splitcontainer_height - 150; //78
        public static Size FPanel
        {
            get => new Size(FPanel_width, FPanel_height);
        }

        #endregion[FPanel]

        #region[FInnerPanel]

        public static Size FInnerPanel
        {
            get => new Size(FPanel_width - 11, FPanel_height - 41);
        }

        public static Size LInnerPanel
        {
            get => new Size(FPanel_width - 11, FPanel_height - 41);
        }

        #endregion[FInnerPanel]

        #region[BtnOne]

        public static int Header_width { get; set; } = FPanel_width;
        public static int Header_height { get; set; } = 38;
        public static Size Header
        {
            get => new Size(Header_width - 10, Header_height);
        }

        #endregion[BtnOne]

        #region[BtnOne]

        public static int BtnOne_width { get; set; } = 135;
        public static int BtnOne_height { get; set; } = 40;
        public static Size BtnOne
        {
            get => new Size(BtnOne_width, BtnOne_height);
        }

        #endregion[BtnOne]

        #region[Splitter]

        public static int Splitter_width { get; set; } = 22;
        public static int Splitter_height { get; set; } = 240;
        public static Size Splitter
        {
            get => new Size(Splitter_width, Splitter_height);
        }

        #endregion[Splitter]

        #region[CloseBtn]

        public static Size CloseBtn
        {
            get => new Size(FBtnclose_width, FBtnclose_height);
        }
        public static int FBtnclose_width { get; internal set; } = 29;
        public static int FBtnclose_height { get; internal set; } = 29;

        #endregion[CloseBtn]

        #region[Fheader]

        public static Size Fheader
        {
            get => new Size(Fheader_width, Fheader_height);
        }
        public static int Fheader_height { get; internal set; } = FPanel_width;
        public static int Fheader_width { get; internal set; } = 35;

        #endregion[Fheader]

        #region[Label Size]

        #region[One Label]
        public static Size OneLabel
        {
            get => new Size(OneLabelWidth, OneLabelHeight);
        }
        public static int OneLabelWidth { get; set; } = 140;
        public static int OneLabelHeight { get; set; } = 28;

        #endregion[One Label]

        #region[Two Label]
        public static Size TwoLabel
        {
            get => new Size(TwoLabelWidth, TwoLabelHeight);
        }
        public static int TwoLabelWidth { get; set; } = 120;
        public static int TwoLabelHeight { get; set; } = 28;

        #endregion[Two Label]

        #region[Three Label]
        public static Size ThreeLabel
        {
            get => new Size(ThreeLabelWidth, ThreeLabelHeight);
        }
        public static int ThreeLabelWidth { get; set; } = 90;
        public static int ThreeLabelHeight { get; set; } = 28;

        #endregion[Three Label]

        #region[Four Label]
        public static Size FourLabel
        {
            get => new Size(FourLabelWidth, FourLabelHeight);
        }
        public static int FourLabelWidth { get; set; } = 100;
        public static int FourLabelHeight { get; set; } = 28;

        #endregion[Four Label]

        #region[Full Label]
        public static Size FullLabel
        {
            get => new Size(FullLabelWidth, FullLabelHeight);
        }
        public static int FullLabelWidth { get; set; } = FPanel_width - 40;
        public static int FullLabelHeight { get; set; } = 28;

        #endregion[Full Label]

        #endregion[Label Size]

        #region[Txt Size]

        #region[One Text]

        public static Size OneText
        {
            get => new Size(OneTxtColumn, OneTxtHeight);
        }
        public static int OneTxtColumn { get; set; } = FPanel_width - (Margin + OneLabelWidth);
        public static int OneTxtHeight { get; set; } = 28;

        #endregion[One Text]

        #region[Two Text]

        public static Size TwoText
        {
            get => new Size(TwoTxtColumn, TwoTxtHeight);
        }
        public static int TwoTxtColumn { get; set; } = (FPanel_width - (Margin + OneLabelWidth +TwoLabelWidth + ColumnGap))/2;
        public static int TwoTxtHeight { get; set; } = 28;

        #endregion[Two Text]

        #region[Three Text]

        public static Size ThreeText
        {
            get => new Size(ThreeTxtWidth, ThreeTxtHeight);
        }
        public static int ThreeTxtWidth { get; set; } = (FPanel_width - (Margin + OneLabelWidth + ThreeLabelWidth + ThreeLabelWidth + ColumnGap + ColumnGap)) / 3;
        public static int ThreeTxtHeight { get; set; } = 28;

        #endregion[Three Text]

        #region[Four Text]

        public static Size FourText
        {
            get => new Size(FourTxtWidth, FourTxtHeight);
        }
        public static int FourTxtWidth { get; set; } = (FPanel_width - (Margin + OneLabelWidth + FourLabelWidth + FourLabelWidth + FourLabelWidth + ColumnGap + ColumnGap + ColumnGap))/4;
        public static int FourTxtHeight { get; set; } = 28;

        #endregion[Four Text]

        #region[Full Text]

        public static Size FullText
        {
            get => new Size(FullTxtColumn, FullTxtHeight);
        }
        public static int FullTxtColumn { get; set; } = FPanel_width - Margin; 
        public static int FullTxtHeight { get; set; } = 28;

        #endregion[Four Text]

        #endregion[Txt Size]

        #region[Notes]
        public static Size LblNotes
        {
            get => new Size(OneLabelWidth, 62);
        }
        public static Size TxtNotes
        {
            get => new Size(TwoTxtColumn, 62);
        }
        #endregion[Notes]

        #region[List Edit Grid]

        public static int ListView_Width { get; set; } = FPanel_width - 190;
        public static int ListView_Height { get; set; } = FPanel_height - 140;
        public static Size ListView
        {
            get => new Size(ListView_Width, ListView_Height);
        }

        public static int EditView_Width { get; set; } = FPanel_width - 160;
        public static int EditView_Height { get; set; } = FPanel_height - 160;
        public static Size EditView
        {
            get => new Size(EditView_Width, EditView_Height);
        }

        #endregion[List Edit Grid]
    }

}
