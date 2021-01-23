using System.Drawing;
using System.Windows.Forms;

namespace CXLIB
{
    public class Theme
    {
        #region[Theme base]
        ///


        //
        #region[Flist]
        //
        public static Color Flpanel_Backcolor { get { return Color.White; } }
        public static Color Fl_inner_panel_Backcolor { get { return Color.White; } }
        //
        public static int Flpanel_width { get { return Screen_Width - 5; } }
        public static int Flpanel_height { get { return Screen_Heigth - 135; } }
        //
        public static int Fl_inner_panel_width { get { return Flpanel_width - 10; } }
        public static int Fl_inner_panel_height { get { return Flpanel_height - 10; } }
        //
        public static int btn_close_width { get { return 29; } }
        public static int btn_close_height { get { return 29; } }
        //
        public static int btn_close_left { get { return Fl_inner_panel_width - 32; } }
        public static int btn_close_top { get { return 3; } }
        //
        public static Color Fl_header_Backcolor { get { return Color.FromArgb(0, 114, 198); } }
        public static Font Fl_header_Font { get { return new Font("Microsoft Sans Serif", 13.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))); } }
        public static Color Fl_headerText_Fontcolor { get { return Color.White; } }
        public static int Fl_header_width { get { return Flpanel_width; } }
        public static int Fl_header_height { get { return 35; } }
        //
        public static int Fl_checkbox_left { get { return Fl_inner_panel_width - 150; } }
        public static int Fl_checkbox_top { get { return ((Fl_inner_panel_height * 15) / 100); } }
        //
        public static int Fl_Side_btn_width { get { return 146; } }
        public static int Fl_Side_btn_height { get { return 48; } }


        public static Point Btn_1 { get { return new Point(145, 35); } }

        //public static int Fl_Side_btn_height { get { return 35; } }
        //
        public static int Fl_Side_btn_left { get { return Fl_inner_panel_width - (Fl_Side_btn_width + 5); } }
        public static int Fl_Side_btn_top { get { return Fl_checkbox_top + 50; } }
        public static int Fl_Side_btn_gap { get { return 10; } }
        //
        public static int Fl_search_panel_width { get { return 660; } }
        public static int Fl_search_panel_height { get { return 280; } }
        public static int Fl_search_panel_top { get { return Fl_Side_btn_top; } }
        public static int Fl_search_panel_left { get { return Fl_Side_btn_left - (Fl_search_panel_width + 10); } }
        //
        public static int Fl_lbl_search_left { get { return 17; } }
        public static int Fl_lbl_search_top { get { return 105; } }
        //
        public static int Fl_search_Cancelbtn_left { get { return 323; } }
        public static int Fl_search_Cancelbtn_top { get { return 173; } }
        //
        public static int Fl_gridItems_width { get { return Fl_inner_panel_width - 165; } }
        public static int Fl_gridItems_height { get { return Fl_inner_panel_height - 45; } }
        //
        #endregion[Flist]
        //
        // /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region[F]
        //
        public static Color White_Backcolor { get { return Color.White; } }
        public static Color Fpanel1_Backcolor { get { return Color.White; } }
        public static Color Fpanel2_Backcolor { get { return Color.White; } }
        //
        public static int F_btn_list_left { get { return 30; } }
        public static int F_btn_list_top { get { return 200; } }
        public static int F_btn_list_width { get { return 135; } }
        public static int F_btn_list_height { get { return 40; } }
        public static int F_btn_gap { get { return 10; } }
        public static int F_btn_spliter_width { get { return 22; } }

        //
        public static int Fpanel_width { get { return Screen_Width - 60; } }
        public static int Fpanel_height { get { return Screen_Heigth - 150; } }
        public static int Fpanel_left { get { return ((Screen_Width - Fpanel_width) / 2) - 15; } }
        public static int Fpanel_top { get { return 10; } }
        public static Color Fpanel_Backcolor { get { return Color.White; } }
        public static Color F_inner_panel_Backcolor { get { return LtGrey; } }
        //
        public static int F_btn_close_left { get { return Fpanel_width - 42; } }
        public static int F_btn_close_top { get { return 3; } }
        public static Color F_header_Backcolor { get { return Color.FromArgb(0, 114, 198); } }
        public static Font F_header_Font { get { return new Font("Microsoft Sans Serif", 13.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))); } }
        public static Color F_headerText_Fontcolor { get { return Color.White; } }
        public static int F_header_width { get { return Flpanel_width; } }
        public static int F_header_height { get { return 38; } }
        //
        public static int F_btn_width { get { return 120; } }
        public static int F_btn_height { get { return 48; } }
        //
        public static int F_btn_save_left { get { return Fpanel_width - 160; } }
        public static int F_btn_save_top { get { return Fpanel_height - 75; } }
        //
        public static int F_btn_cancel_left { get { return F_btn_save_left - (F_btn_width + 10); } }
        public static int F_btn_cancel_top { get { return Fpanel_height - 75; } }
        //
        public static int F_btn_notactive_left { get { return F_btn_cancel_left - (F_btn_width + 10); } }
        public static int F_btn_notactive_top { get { return Fpanel_height - 75; } }
        //
        public static int F_btn_active_left { get { return F_btn_notactive_left - (F_btn_width + 10); } }
        public static int F_btn_active_top { get { return Fpanel_height - 75; } }
        //
        public static int F_txt_notes_width { get { return F_btn_active_left - (F_btn_width + 100); } }
        public static int F_lbl_notes_width { get { return OneLabelColumn; } }
        //
        public static int F_txt_notes_height { get { return OneRow; } }
        public static int F_lbl_notes_height { get { return OneRow; } }
        //
        #endregion[F]










        // **  Ref : public static Color SplitContainerPanel2 { get { return ColorExtension.ToColor(0x515151); } }

        #region[Common]
        //

        #region[Color]
        //
        public static Color LtGrey { get { return Color.FromArgb(253, 253, 253); } }
        public static Color White { get { return Color.White; } }
        //
        #endregion[Color]
        //
        #region[Office Button Theme]
        //
        public static Themescheme RedBtn { get { return Themescheme.RED; } }
        public static Themescheme BlueBtn { get { return Themescheme.BLUE; } }
        public static Themescheme WhiteBtn { get { return Themescheme.WHITE; } }
        public static Themescheme GreenBtn { get { return Themescheme.Green; } }
        public static Themescheme PinkBtn { get { return Themescheme.Pink; } }
        public static Themescheme SteelblueBtn { get { return Themescheme.Steelblue; } }
        public static Themescheme YellowBtn { get { return Themescheme.Yellow; } }
        //
        #endregion[Office Button Theme]
        //
        public static Font txtFont { get { return new Font("Microsoft Sans Serif", 13.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))); } }
        public static Font Font_36B { get { return new Font("Microsoft Sans Serif", 35.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))); } }
        public static Font btnFont { get { return new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))); } }
        public static Color txtForeColor { get { return Color.Black; } }
        public static Color txt_Readonly_Backcolor { get { return Color.White; } }
        public static Color txt_Backcolor { get { return Color.White; } }

        public static Font Font_10B { get { return new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))); } }

        public static Font Font_11B { get { return new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))); } }

        public static Font Font_6 { get { return new Font("Microsoft Sans Serif", 6.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))); } }
        public static Color lbl_ForeColor { get { return Color.Black; } }
        //
        public static Color lbl_EnterBackColor { get { return Color.FromArgb(142, 189, 64); } }
        public static Color lbl_EnterBorderColor { get { return Color.FromArgb(142, 189, 64); } }
        public static Color lbl_EnterForeColor { get { return Color.White; } }
        public static Color lbl_BackColor { get { return Color.White; } }
        public static Color lbl_BorderColor { get { return Color.FromArgb(198, 198, 198); } }
        ///

















        //
        // Single txt
        //
        public static int lbl_left { get { return 25; } }
        public static int lbl_top { get { return 60; } }

        public static int OneLabelHeight { get { return 28; } }
        //
        public static int txt_left { get { return lbl_left + OneLabelColumn - 1; } }
        public static int txt_top { get { return lbl_top; } }

        public static int txt_Height { get { return 31; } }

        //
        // two txt
        //
        public static int lbl2b_left { get { return txt_left + TwoTextColumn + ColumnGap; } }
        public static int txt2b_left { get { return lbl2b_left + TwoLabelColumn - 1; } }
        //

        //
        // Three txt
        //
        public static int lbl3b_Left { get { return txt_left + ThreeTextColumn + ColumnGap; } }
        public static int txt3b_Left { get { return lbl3b_Left + ThreeLabelColumn - 1; } }
        public static int lbl3c_Left { get { return txt3b_Left + ThreeTextColumn + ColumnGap; } }
        public static int txt3c_Left { get { return lbl3c_Left + ThreeLabelColumn - 1; } }
        //
        //four txt
        //
        public static int lbl4b_Left { get { return txt_left + FourTextColumn + ColumnGap; } }
        public static int txt4b_Left { get { return lbl4b_Left + FourLabelColumn - 1; } }
        public static int lbl4c_Left { get { return txt4b_Left + FourTextColumn + ColumnGap; } }
        public static int txt4c_Left { get { return lbl4c_Left + FourLabelColumn - 1; } }
        public static int lbl4d_Left { get { return txt4c_Left + FourTextColumn + ColumnGap; } }
        public static int txt4d_Left { get { return lbl4d_Left + FourLabelColumn - 1; } }

        //
        public static int lbl_TabIndex { get { return 100; } }
        public static int txt_TabIndex { get { return 0; } }

        #endregion[Common]
        //
        #endregion[Theme base]







        #region[Colour]

        public static Color SplitContainer_Background { get; set; } = Color.Red;
        public static Color SplitContainer_Panel1_Background { get; set; } = Color.Violet;
        public static Color SplitContainer_Panel2_Background { get; set; } = Color.SaddleBrown;



        #endregion[Colour]

        #region[Lay out]

        #region[Screen Bounds]
        public static int Screen_Width { get { return Screen.PrimaryScreen.Bounds.Width; } }
        public static int Screen_Heigth { get { return Screen.PrimaryScreen.Bounds.Height; } }

        #endregion[Screen Bounds]

        #region[Text Column]

        public static int OneTextColumn { get; set; } = (Fpanel_width - OneLabelColumn) - (ColumnGap * 3);
        public static int TwoTextColumn { get; set; } = ((OneTextColumn) / 2) - (ColumnGap * 3);
        public static int ThreeTextColumn { get; set; } = ((OneTextColumn - OneLabelColumn) / 3) - (ColumnGap);
        public static int FourTextColumn { get; set; } = (((OneTextColumn - OneLabelColumn)) / 4) - (ColumnGap + 12);
        public static int FullTextColumn { get; set; } = (Fpanel_width) - (ColumnGap * 3);

        #endregion[Text Column]

        #region[Label Column]

        public static int OneLabelColumn { get; set; } = 140;
        public static int TwoLabelColumn { get; set; } = 100;
        public static int ThreeLabelColumn { get; set; } = 80;
        public static int FourLabelColumn { get; set; } = 70;
        public static int FullLabelColumn { get; set; } = 70;

        #endregion[Label Column]

        #region[Row]

        public static int OneRow { get; set; } = 62;
        public static int TwoRow { get; set; } = 31;
        public static int ThreeRow { get; set; } = 62;
        public static int FourRow { get; set; } = 93;
        public static int FullRow { get; set; } = Fpanel_height - 80;

        #endregion[Row]

        #region[Gap]

        public static int RowGap { get; set; } = 35;
        public static int ColumnGap { get; set; } = 20;

        #endregion[Gap]





        #endregion[Lay out]

    }///cls
}///ns
