using System.Drawing;

namespace CXLIB
{
    public class XLayout
    {
        private static int X;
        private static int Y;
        public static Point Splitter { get; set; } = new Point(3, 200);

        #region[FPanel]

        public static int FPanel_left { get; set; } = ((XSize.Screen_Width - XSize.FPanel_width) / 2) - 15;
        public static int FPanel_top { get; set; } = 10;
        public static Point FPanel
        {
            get => new Point(FPanel_left, FPanel_top);
        }

        #endregion[FPanel]

        #region[FInnerPanel]

        public static int FInnerPanel_left { get; set; } = 6;
        public static int FInnerPanel_top { get; set; } = 37;
        public static Point FInnerPanel
        {
            get => new Point(FInnerPanel_left, FInnerPanel_top);
        }

        public static int LInnerPanel_left { get; set; } = 6;
        public static int LInnerPanel_top { get; set; } = 37;
        public static Point LInnerPanel
        {
            get => new Point(LInnerPanel_left, LInnerPanel_top);
        }

        #endregion[FInnerPanel]

        #region[First Btn]

        public static int FFirstBtn_left { get; set; } = 30;
        public static int FFirstBtn_top { get; set; } = 200;
        public static Point FormFirstBtn
        {
            get => new Point(FFirstBtn_left, FFirstBtn_top);
        }

        public static int LFirstBtn_left { get; set; } = XSize.FPanel_width -  160;
        public static int LFirstBtn_top { get; set; } = 230;
        public static Point ListFirstBtn
        {
            get => new Point(LFirstBtn_left, LFirstBtn_top);
        }

        #endregion[First Btn]

        #region[BtnLocation]
        public static Point BtnLocation(Point location)
        {
            X = location.X;
            Y = location.Y + XSize.BtnGap;
            return Alocation;
        }

        #endregion[BtnLocation]

        #region[VLocation]
        internal static Point Alocation
        {
            get => new Point(X, Y);
        }
        public static Point VLocation(Point location)
        {
            X = location.X;
            Y = location.Y + XSize.RowGap;
            return Alocation;
        }

        #endregion[VLocation]

        #region[Location]
        public static int H_left { get; set; } = 25;
        public static int V_top { get; set; } = 30;

        #endregion[Location]

        #region[First Location]
        public static Point FirstLabel
        {
            get
            {
                X = H_left;
                Y = V_top;
                return Alocation;
            }
        }

        public static Point FirstText
        {
            get
            {
                X = H_left + XSize.OneLabelWidth;
                Y = V_top;
                return Alocation;
            }
        }

        #endregion[First Location]

        #region[1 CCOLUMN]
        public static Point R1_Label(Point location)
        {
            X = H_left;
            Y = location.Y + XSize.RowGap; ;
            return Alocation;
        }
        public static Point R1_Text(Point location)
        {
            X = H_left + XSize.OneLabelWidth -1;
            Y = location.Y + XSize.RowGap;
            return Alocation;
        }

        #endregion[1 CCOLUMN]

        #region[2 COLUMN]

        #region[ROW 1]
        public static Point R1_2Label_1(Point location)
        {
            X = H_left;
            Y = location.Y;
            return Alocation;
        }
        public static Point R1_2Text_1(Point location)
        {
            X = H_left + XSize.OneLabelWidth - 1;
            Y = location.Y;
            return Alocation;
        }

        public static Point R1_2Label_2(Point location)
        {
            X = H_left + XSize.OneLabelWidth  + XSize.TwoTxtColumn + XSize.ColumnGap;
            Y = location.Y;
            return Alocation;
        }
        public static Point R1_2Text_2(Point location)
        {
            X = H_left + XSize.OneLabelWidth + XSize.TwoTxtColumn + XSize.ColumnGap + XSize.TwoLabelWidth - 1;
            Y = location.Y;
            return Alocation;
        }

        #endregion[ROW 1]

        #region[ROW 2]

        public static Point R2_2Label_1(Point location)
        {
            X = H_left;
            Y = location.Y + XSize.RowGap; 
            return Alocation;
        }
        public static Point R2_2Text_1(Point location)
        {
            X = H_left + XSize.OneLabelWidth - 1;
            Y = location.Y + XSize.RowGap; 
            return Alocation;
        }

        public static Point R2_2Label_2(Point location)
        {
            X = H_left + XSize.OneLabelWidth + XSize.TwoTxtColumn + XSize.ColumnGap;
            Y = location.Y + XSize.RowGap; 
            return Alocation;
        }
        public static Point R2_2Text_2(Point location)
        {
            X = H_left + XSize.OneLabelWidth + XSize.TwoTxtColumn + XSize.ColumnGap + XSize.TwoLabelWidth - 1;
            Y = location.Y + XSize.RowGap;
            return Alocation;
        }

        #endregion[ROW 2]

        #endregion[2 COLUMN]

        #region[3 COLUMN]

        #region[ROW 1]

        public static Point R1_3Label_1(Point location)
        {
            X = H_left;
            Y = location.Y;
            return Alocation;
        }
        public static Point R1_3Text_1(Point location)
        {
            X = H_left + XSize.OneLabelWidth - 1;
            Y = location.Y;
            return Alocation;
        }

        public static Point R1_3Label_2(Point location)
        {
            X = H_left + XSize.OneLabelWidth + XSize.ThreeTxtWidth + XSize.ColumnGap;
            Y = location.Y;
            return Alocation;
        }
        public static Point R1_3Text_2(Point location)
        {
            X = H_left + XSize.OneLabelWidth + XSize.ThreeTxtWidth + XSize.ColumnGap + XSize.ThreeLabelWidth -1;
            Y = location.Y;
            return Alocation;
        }

        public static Point R1_3Label_3(Point location)
        {
            X = H_left + XSize.OneLabelWidth + XSize.ThreeTxtWidth + XSize.ColumnGap + XSize.ThreeLabelWidth + XSize.ThreeTxtWidth + XSize.ColumnGap;
            Y = location.Y;
            return Alocation;
        }
        public static Point R1_3Text_3(Point location)
        {
            X = H_left + XSize.OneLabelWidth + XSize.ThreeTxtWidth + XSize.ColumnGap + XSize.ThreeLabelWidth + XSize.ThreeTxtWidth + XSize.ColumnGap + XSize.ThreeLabelWidth -1;
            Y = location.Y;
            return Alocation;
        }

        #endregion[ROW 1]

        #region[ROW 2]

        public static Point R2_3Label_1(Point location)
        {
            X = H_left;
            Y = location.Y + XSize.RowGap;
            return Alocation;
        }
        public static Point R2_3Text_1(Point location)
        {
            X = H_left + XSize.OneLabelWidth - 1;
            Y = location.Y + XSize.RowGap;
            return Alocation;
        }

        public static Point R2_3Label_2(Point location)
        {
            X = H_left + XSize.OneLabelWidth + XSize.ThreeTxtWidth + XSize.ColumnGap;
            Y = location.Y + XSize.RowGap;
            return Alocation;
        }
        public static Point R2_3Text_2(Point location)
        {
            X = H_left + XSize.OneLabelWidth + XSize.ThreeTxtWidth + XSize.ColumnGap + XSize.ThreeLabelWidth - 1;
            Y = location.Y + XSize.RowGap;
            return Alocation;
        }

        public static Point R2_3Label_3(Point location)
        {
            X = H_left + XSize.OneLabelWidth + XSize.ThreeTxtWidth + XSize.ColumnGap + XSize.ThreeLabelWidth + XSize.ThreeTxtWidth + XSize.ColumnGap;
            Y = location.Y + XSize.RowGap;
            return Alocation;
        }
        public static Point R2_3Text_3(Point location)
        {
            X = H_left + XSize.OneLabelWidth + XSize.ThreeTxtWidth + XSize.ColumnGap + XSize.ThreeLabelWidth + XSize.ThreeTxtWidth + XSize.ColumnGap + XSize.ThreeLabelWidth - 1;
            Y = location.Y + XSize.RowGap;
            return Alocation;
        }

        #endregion[ROW 2]

        #endregion[3 COLUMN]

        #region[4 COLUMN]

        #region[ROW 1]

        public static Point R1_4Label_1(Point location)
        {
            X = H_left;
            Y = location.Y;
            return Alocation;
        }
        public static Point R1_4Text_1(Point location)
        {
            X = H_left + XSize.OneLabelWidth - 1;
            Y = location.Y;
            return Alocation;
        }
        public static Point R1_4Label_2(Point location)
        {
            X = H_left + XSize.OneLabelWidth + XSize.FourTxtWidth + XSize.ColumnGap;
            Y = location.Y;
            return Alocation;
        }
        public static Point R1_4Text_2(Point location)
        {
            X = H_left + XSize.OneLabelWidth + XSize.FourTxtWidth + XSize.ColumnGap + XSize.FourLabelWidth - 1;
            Y = location.Y;
            return Alocation;
        }

        public static Point R1_4Label_3(Point location)
        {
            X = H_left + XSize.OneLabelWidth + XSize.FourTxtWidth + XSize.ColumnGap + XSize.FourLabelWidth + XSize.FourTxtWidth + XSize.ColumnGap;
            Y = location.Y;
            return Alocation;
        }
        public static Point R1_4Text_3(Point location)
        {
            X = H_left + XSize.OneLabelWidth + XSize.FourTxtWidth + XSize.ColumnGap + XSize.FourLabelWidth + XSize.FourTxtWidth + XSize.ColumnGap + XSize.FourLabelWidth - 1;
            Y = location.Y;
            return Alocation;
        }

        public static Point R1_4Label_4(Point location)
        {
            X = H_left + XSize.OneLabelWidth + XSize.FourTxtWidth + XSize.ColumnGap + XSize.FourLabelWidth + XSize.FourTxtWidth + XSize.ColumnGap;
            Y = location.Y;
            return Alocation;
        }
        public static Point R1_4Text_4(Point location)
        {
            X = H_left + XSize.OneLabelWidth + XSize.FourTxtWidth + XSize.ColumnGap + XSize.FourLabelWidth + XSize.FourTxtWidth + XSize.ColumnGap + XSize.FourLabelWidth - 1;
            Y = location.Y;
            return Alocation;
        }

        #endregion[ROW 1]

        #region[ROW 2]

        public static Point R2_4Label_1(Point location)
        {
            X = H_left;
            Y = location.Y + XSize.RowGap;
            return Alocation;
        }
        public static Point R2_4Text_1(Point location)
        {
            X = H_left + XSize.OneLabelWidth - 1;
            Y = location.Y + XSize.RowGap;
            return Alocation;
        }
        public static Point R2_4Label_2(Point location)
        {
            X = H_left + XSize.OneLabelWidth + XSize.FourTxtWidth + XSize.ColumnGap;
            Y = location.Y + XSize.RowGap;
            return Alocation;
        }
        public static Point R2_4Text_2(Point location)
        {
            X = H_left + XSize.OneLabelWidth + XSize.FourTxtWidth + XSize.ColumnGap + XSize.FourLabelWidth - 1;
            Y = location.Y + XSize.RowGap;
            return Alocation;
        }

        public static Point R2_4Label_3(Point location)
        {
            X = H_left + XSize.OneLabelWidth + XSize.FourTxtWidth + XSize.ColumnGap + XSize.FourLabelWidth + XSize.FourTxtWidth + XSize.ColumnGap;
            Y = location.Y + XSize.RowGap;
            return Alocation;
        }
        public static Point R2_4Text_3(Point location)
        {
            X = H_left + XSize.OneLabelWidth + XSize.FourTxtWidth + XSize.ColumnGap + XSize.FourLabelWidth + XSize.FourTxtWidth + XSize.ColumnGap + XSize.FourLabelWidth - 1;
            Y = location.Y + XSize.RowGap;
            return Alocation;
        }

        public static Point R2_4Label_4(Point location)
        {
            X = H_left + XSize.OneLabelWidth + XSize.FourTxtWidth + XSize.ColumnGap + XSize.FourLabelWidth + XSize.FourTxtWidth + XSize.ColumnGap + XSize.FourLabelWidth + XSize.FourTxtWidth + XSize.ColumnGap;
            Y = location.Y + XSize.RowGap; ;
            return Alocation;
        }
        public static Point R2_4Text_4(Point location)
        {
            X = H_left + XSize.OneLabelWidth + XSize.FourTxtWidth + XSize.ColumnGap + XSize.FourLabelWidth + XSize.FourTxtWidth + XSize.ColumnGap + XSize.FourLabelWidth + XSize.FourTxtWidth + XSize.ColumnGap + XSize.FourLabelWidth - 1;
            Y = location.Y + XSize.RowGap;
            return Alocation;
        }

        #endregion[ROW 2]

        #endregion[4 COLUMN]

        #region[CloseBtn]

        public static Point CloseBtn
        {
            get => new Point(FBtnclose_left, FBtnclose_top);
        }
        public static int FBtnclose_left { get; internal set; } = XSize.FPanel_width - 42;
        public static int FBtnclose_top { get; internal set; } = 3;

        #endregion[BtnOne]

        #region[Notes]
        public static Point LblNotes
        {
            get => new Point(H_left, XSize.FPanel_height - 108);
        }
        public static Point TxtNotes
        {
            get => new Point(H_left + XSize.OneLabelWidth, XSize.FPanel_height - 108);
        }
        #endregion[Notes]

        #region[btn_active & btn_save]
        public static Point BtnActive
        {
            get => new Point((H_left + XSize.TwoTxtColumn + 180), (XSize.FPanel_height - 98));
        }
        public static Point BtnSave
        {
            get => new Point(XSize.FPanel_width - 178, XSize.FPanel_height - 98);
        }
        #endregion[Notes]

        #region[List Edit Grid]

        public static int ListView_left { get; set; } = 10;
        public static int ListView_top { get; set; } = 90;
        public static Point ListView
        {
            get => new Point(ListView_left, ListView_top);
        }

        public static int EditView_left { get; set; } = XSize.FPanel_width - 160;
        public static int EditView_top { get; set; } = 200;
        public static Point EditView
        {
            get => new Point(EditView_left, EditView_top);
        }

        #endregion[List Edit Grid]
    }
}
