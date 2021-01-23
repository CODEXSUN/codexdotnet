namespace CXLIB
{
    partial class RtfEditor
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ts = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsCut = new System.Windows.Forms.ToolStripButton();
            this.tsCopy = new System.Windows.Forms.ToolStripButton();
            this.tsPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsUndo = new System.Windows.Forms.ToolStripButton();
            this.tsRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBold = new System.Windows.Forms.ToolStripButton();
            this.tsItalic = new System.Windows.Forms.ToolStripButton();
            this.tsUnderline = new System.Windows.Forms.ToolStripButton();
            this.tsStrikeout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLeft = new System.Windows.Forms.ToolStripButton();
            this.tsCenter = new System.Windows.Forms.ToolStripButton();
            this.tsRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsFontColor = new System.Windows.Forms.ToolStripButton();
            this.tsBackgroundColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBullet = new System.Windows.Forms.ToolStripButton();
            this.tsIdentPlus = new System.Windows.Forms.ToolStripButton();
            this.tsIdentMinus = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_FontType = new System.Windows.Forms.ToolStripLabel();
            this.tsFontType = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_FontSize = new System.Windows.Forms.ToolStripLabel();
            this.tsFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_Zoom = new System.Windows.Forms.ToolStripLabel();
            this.tsZoom = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.ts.SuspendLayout();
            this.SuspendLayout();
            // 
            // ts
            // 
            this.ts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsCut,
            this.tsCopy,
            this.tsPaste,
            this.toolStripSeparator1,
            this.tsUndo,
            this.tsRedo,
            this.toolStripSeparator2,
            this.tsBold,
            this.tsItalic,
            this.tsUnderline,
            this.tsStrikeout,
            this.toolStripSeparator3,
            this.tsLeft,
            this.tsCenter,
            this.tsRight,
            this.toolStripSeparator4,
            this.tsFontColor,
            this.tsBackgroundColor,
            this.toolStripSeparator5,
            this.tsBullet,
            this.tsIdentPlus,
            this.tsIdentMinus,
            this.toolStripSeparator6,
            this.lbl_FontType,
            this.tsFontType,
            this.toolStripSeparator7,
            this.lbl_FontSize,
            this.tsFontSize,
            this.toolStripSeparator9,
            this.lbl_Zoom,
            this.tsZoom,
            this.toolStripSeparator8});
            this.ts.Location = new System.Drawing.Point(0, 0);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(1188, 25);
            this.ts.TabIndex = 0;
            this.ts.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(60, 22);
            // 
            // tsCut
            // 
            this.tsCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsCut.Image = global::CXLIB.Properties.Resources.cut;
            this.tsCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCut.Name = "tsCut";
            this.tsCut.Size = new System.Drawing.Size(23, 22);
            this.tsCut.Text = "Cut";
            this.tsCut.Click += new System.EventHandler(this.tsCut_Click);
            // 
            // tsCopy
            // 
            this.tsCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsCopy.Image = global::CXLIB.Properties.Resources.copy;
            this.tsCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCopy.Name = "tsCopy";
            this.tsCopy.Size = new System.Drawing.Size(23, 22);
            this.tsCopy.Text = "Copy";
            this.tsCopy.Click += new System.EventHandler(this.tsCopy_Click);
            // 
            // tsPaste
            // 
            this.tsPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsPaste.Image = global::CXLIB.Properties.Resources.paste;
            this.tsPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPaste.Name = "tsPaste";
            this.tsPaste.Size = new System.Drawing.Size(23, 22);
            this.tsPaste.Text = "Paste";
            this.tsPaste.Click += new System.EventHandler(this.tsPaste_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsUndo
            // 
            this.tsUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsUndo.Image = global::CXLIB.Properties.Resources.undo;
            this.tsUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUndo.Name = "tsUndo";
            this.tsUndo.Size = new System.Drawing.Size(23, 22);
            this.tsUndo.Text = "Undo";
            this.tsUndo.Click += new System.EventHandler(this.tsUndo_Click);
            // 
            // tsRedo
            // 
            this.tsRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsRedo.Image = global::CXLIB.Properties.Resources.redo;
            this.tsRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRedo.Name = "tsRedo";
            this.tsRedo.Size = new System.Drawing.Size(23, 22);
            this.tsRedo.Text = "Redo";
            this.tsRedo.Click += new System.EventHandler(this.tsRedo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBold
            // 
            this.tsBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBold.Image = global::CXLIB.Properties.Resources.B;
            this.tsBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBold.Name = "tsBold";
            this.tsBold.Size = new System.Drawing.Size(23, 22);
            this.tsBold.Text = "Bold";
            this.tsBold.Click += new System.EventHandler(this.tsBold_Click);
            // 
            // tsItalic
            // 
            this.tsItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsItalic.Image = global::CXLIB.Properties.Resources.I;
            this.tsItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsItalic.Name = "tsItalic";
            this.tsItalic.Size = new System.Drawing.Size(23, 22);
            this.tsItalic.Text = "Italic";
            this.tsItalic.Click += new System.EventHandler(this.tsItalic_Click);
            // 
            // tsUnderline
            // 
            this.tsUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsUnderline.Image = global::CXLIB.Properties.Resources.U;
            this.tsUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUnderline.Name = "tsUnderline";
            this.tsUnderline.Size = new System.Drawing.Size(23, 22);
            this.tsUnderline.Text = "Underline";
            this.tsUnderline.Click += new System.EventHandler(this.tsUnderline_Click);
            // 
            // tsStrikeout
            // 
            this.tsStrikeout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsStrikeout.Image = global::CXLIB.Properties.Resources.abc;
            this.tsStrikeout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsStrikeout.Name = "tsStrikeout";
            this.tsStrikeout.Size = new System.Drawing.Size(23, 22);
            this.tsStrikeout.Text = "Strikeout";
            this.tsStrikeout.Click += new System.EventHandler(this.tsStrikeout_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsLeft
            // 
            this.tsLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsLeft.Image = global::CXLIB.Properties.Resources.align_left;
            this.tsLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLeft.Name = "tsLeft";
            this.tsLeft.Size = new System.Drawing.Size(23, 22);
            this.tsLeft.Text = "Left";
            this.tsLeft.Click += new System.EventHandler(this.tsLeft_Click);
            // 
            // tsCenter
            // 
            this.tsCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsCenter.Image = global::CXLIB.Properties.Resources.align_center;
            this.tsCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCenter.Name = "tsCenter";
            this.tsCenter.Size = new System.Drawing.Size(23, 22);
            this.tsCenter.Text = "Center";
            this.tsCenter.Click += new System.EventHandler(this.tsCenter_Click);
            // 
            // tsRight
            // 
            this.tsRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsRight.Image = global::CXLIB.Properties.Resources.align_right;
            this.tsRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRight.Name = "tsRight";
            this.tsRight.Size = new System.Drawing.Size(23, 22);
            this.tsRight.Text = "Right";
            this.tsRight.Click += new System.EventHandler(this.tsRight_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsFontColor
            // 
            this.tsFontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsFontColor.Image = global::CXLIB.Properties.Resources.font_color;
            this.tsFontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFontColor.Name = "tsFontColor";
            this.tsFontColor.Size = new System.Drawing.Size(23, 22);
            this.tsFontColor.Text = "Font color";
            this.tsFontColor.Click += new System.EventHandler(this.tsSelectFontColor_Click);
            // 
            // tsBackgroundColor
            // 
            this.tsBackgroundColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBackgroundColor.Image = global::CXLIB.Properties.Resources.highlight_color;
            this.tsBackgroundColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBackgroundColor.Name = "tsBackgroundColor";
            this.tsBackgroundColor.Size = new System.Drawing.Size(23, 22);
            this.tsBackgroundColor.Text = "Back color";
            this.tsBackgroundColor.Click += new System.EventHandler(this.tsSelectBackgroundColor_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBullet
            // 
            this.tsBullet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBullet.Image = global::CXLIB.Properties.Resources.list_unordered;
            this.tsBullet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBullet.Name = "tsBullet";
            this.tsBullet.Size = new System.Drawing.Size(23, 22);
            this.tsBullet.Text = "Bullet";
            this.tsBullet.Click += new System.EventHandler(this.tsBullet_Click);
            // 
            // tsIdentPlus
            // 
            this.tsIdentPlus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsIdentPlus.Image = global::CXLIB.Properties.Resources.indent_increase;
            this.tsIdentPlus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsIdentPlus.Name = "tsIdentPlus";
            this.tsIdentPlus.Size = new System.Drawing.Size(23, 22);
            this.tsIdentPlus.Text = "Ident Plus";
            this.tsIdentPlus.Click += new System.EventHandler(this.tsIdentPlus_Click);
            // 
            // tsIdentMinus
            // 
            this.tsIdentMinus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsIdentMinus.Image = global::CXLIB.Properties.Resources.indent_decrease;
            this.tsIdentMinus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsIdentMinus.Name = "tsIdentMinus";
            this.tsIdentMinus.Size = new System.Drawing.Size(23, 22);
            this.tsIdentMinus.Text = "Ident Minus";
            this.tsIdentMinus.Click += new System.EventHandler(this.tsIdentMinus_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // lbl_FontType
            // 
            this.lbl_FontType.Image = global::CXLIB.Properties.Resources.styles;
            this.lbl_FontType.Name = "lbl_FontType";
            this.lbl_FontType.Size = new System.Drawing.Size(47, 22);
            this.lbl_FontType.Text = "Font";
            // 
            // tsFontType
            // 
            this.tsFontType.AutoSize = false;
            this.tsFontType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFontType.Name = "tsFontType";
            this.tsFontType.Size = new System.Drawing.Size(200, 22);
            this.tsFontType.Text = "Select Font";
            this.tsFontType.Click += new System.EventHandler(this.tsFontType_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // lbl_FontSize
            // 
            this.lbl_FontSize.Image = global::CXLIB.Properties.Resources.A_;
            this.lbl_FontSize.Name = "lbl_FontSize";
            this.lbl_FontSize.Size = new System.Drawing.Size(43, 22);
            this.lbl_FontSize.Text = "Size";
            // 
            // tsFontSize
            // 
            this.tsFontSize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tsFontSize.AutoSize = false;
            this.tsFontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.tsFontSize.Name = "tsFontSize";
            this.tsFontSize.Size = new System.Drawing.Size(50, 23);
            this.tsFontSize.SelectedIndexChanged += new System.EventHandler(this.tsFontSize_SelectedIndexChanged);
            this.tsFontSize.Leave += new System.EventHandler(this.tsFontSize_Leave);
            this.tsFontSize.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tsFontSize_KeyUp);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // lbl_Zoom
            // 
            this.lbl_Zoom.Image = global::CXLIB.Properties.Resources.zoom_factor;
            this.lbl_Zoom.Name = "lbl_Zoom";
            this.lbl_Zoom.Size = new System.Drawing.Size(55, 22);
            this.lbl_Zoom.Text = "Zoom";
            // 
            // tsZoom
            // 
            this.tsZoom.AutoSize = false;
            this.tsZoom.Items.AddRange(new object[] {
            "400%",
            "300%",
            "200%",
            "150%",
            "100%",
            "75%",
            "50%",
            "25%"});
            this.tsZoom.Name = "tsZoom";
            this.tsZoom.Size = new System.Drawing.Size(50, 23);
            this.tsZoom.SelectedIndexChanged += new System.EventHandler(this.tsZoom_SelectedIndexChanged);
            this.tsZoom.Leave += new System.EventHandler(this.tsZoom_Leave);
            this.tsZoom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tsZoom_KeyUp);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // rtb
            // 
            this.rtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb.Location = new System.Drawing.Point(0, 25);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(1188, 322);
            this.rtb.TabIndex = 1;
            this.rtb.Text = "";
            // 
            // RtfEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.ts);
            this.Name = "RtfEditor";
            this.Size = new System.Drawing.Size(1188, 347);
            this.ts.ResumeLayout(false);
            this.ts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ts;
        private System.Windows.Forms.ToolStripButton tsCut;
        private System.Windows.Forms.ToolStripButton tsCopy;
        private System.Windows.Forms.ToolStripButton tsPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsUndo;
        private System.Windows.Forms.ToolStripButton tsRedo;
        private System.Windows.Forms.ToolStripButton tsBold;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsItalic;
        private System.Windows.Forms.ToolStripButton tsUnderline;
        private System.Windows.Forms.ToolStripButton tsStrikeout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsLeft;
        private System.Windows.Forms.ToolStripButton tsCenter;
        private System.Windows.Forms.ToolStripButton tsRight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsFontColor;
        private System.Windows.Forms.ToolStripButton tsBackgroundColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsBullet;
        private System.Windows.Forms.ToolStripButton tsIdentPlus;
        private System.Windows.Forms.ToolStripButton tsIdentMinus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel lbl_FontType;
        private System.Windows.Forms.ToolStripLabel lbl_FontSize;
        private System.Windows.Forms.ToolStripComboBox tsFontSize;
        private System.Windows.Forms.ToolStripLabel lbl_Zoom;
        private System.Windows.Forms.ToolStripComboBox tsZoom;
        private System.Windows.Forms.ToolStripButton tsFontType;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
    }
}
