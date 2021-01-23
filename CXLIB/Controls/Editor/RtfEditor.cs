using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CXLIB
{
    public partial class RtfEditor : UserControl
    {
        public RtfEditor()
        {
            InitializeComponent();
        }
        //
        #region [Action & Event]
            //
        private void tsCut_Click(object sender, EventArgs e)
        {
            if (this.rtb.ReadOnly)
            {
                return;
            }

            this.rtb.Cut();
        }

        private void tsCopy_Click(object sender, EventArgs e)
        {
            this.rtb.Copy();
        }

        private void tsPaste_Click(object sender, EventArgs e)
        {
            if (this.rtb.ReadOnly)
            {
                return;
            }

            this.rtb.Paste();
        }

        private void tsUndo_Click(object sender, EventArgs e)
        {
            if (this.rtb.ReadOnly)
            {
                return;
            }

            this.rtb.Undo();
        }

        private void tsRedo_Click(object sender, EventArgs e)
        {
            if (this.rtb.ReadOnly)
            {
                return;
            }

            this.rtb.Redo();
        }

        //
        #endregion [Action  & Event]
        //
        #region [Font style management]
        //
        private void tsBold_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(!this.rtb.SelectionFont.Bold, this.rtb.SelectionFont.Italic, this.rtb.SelectionFont.Underline, this.rtb.SelectionFont.Strikeout);
        }

        private void tsItalic_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(this.rtb.SelectionFont.Bold, !this.rtb.SelectionFont.Italic, this.rtb.SelectionFont.Underline, this.rtb.SelectionFont.Strikeout);
        }

        private void tsUnderline_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(this.rtb.SelectionFont.Bold, this.rtb.SelectionFont.Italic, !this.rtb.SelectionFont.Underline, this.rtb.SelectionFont.Strikeout);
        }

        private void tsStrikeout_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(this.rtb.SelectionFont.Bold, this.rtb.SelectionFont.Italic, this.rtb.SelectionFont.Underline, !this.rtb.SelectionFont.Strikeout);
        }

        private void ChangeFontStyle(bool fontBold, bool fontItalic, bool fontUnderline, bool fontStrikeout)
        {
            if (this.rtb.ReadOnly)
            {
                return;
            }

            int fontStyle = 0;

            if (fontBold) { fontStyle += (int)FontStyle.Bold; }
            if (fontItalic) { fontStyle += (int)FontStyle.Italic; }
            if (fontUnderline) { fontStyle += (int)FontStyle.Underline; }
            if (fontStrikeout) { fontStyle += (int)FontStyle.Strikeout; }

            this.rtb.SelectionFont = new Font(this.rtb.SelectionFont, (FontStyle)fontStyle);
            rtb_SelectionChanged(rtb, new EventArgs());
        }
        //
        #endregion Font style management
        //
        #region [Aligment]
        //

        private void tsLeft_Click(object sender, EventArgs e)
        {
            if (this.rtb.ReadOnly)
            {
                return;
            }

            this.rtb.SelectionAlignment = HorizontalAlignment.Left;
            rtb_SelectionChanged(rtb, new EventArgs());
        }

        private void tsCenter_Click(object sender, EventArgs e)
        {
            if (this.rtb.ReadOnly)
            {
                return;
            }

            this.rtb.SelectionAlignment = HorizontalAlignment.Center;
            rtb_SelectionChanged(rtb, new EventArgs());
        }

        private void tsRight_Click(object sender, EventArgs e)
        {
            if (this.rtb.ReadOnly)
            {
                return;
            }

            this.rtb.SelectionAlignment = HorizontalAlignment.Right;
            rtb_SelectionChanged(rtb, new EventArgs());
        }
        //
        #endregion [Aligment]
        //
        #region [Color]
        //
        private void tsSelectFontColor_Click(object sender, EventArgs e)
        {
            if (this.rtb.ReadOnly)
            {
                return;
            }

            ColorDialog colorDlg = new ColorDialog();
            colorDlg.Color = this.rtb.SelectionColor;
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                this.rtb.SelectionColor = colorDlg.Color;
                rtb_SelectionChanged(rtb, new EventArgs());
            }
        }


        private void tsSelectBackgroundColor_Click(object sender, EventArgs e)
        {
            if (this.rtb.ReadOnly)
            {
                return;
            }

            ColorDialog colorDlg = new ColorDialog();
            colorDlg.Color = this.rtb.SelectionBackColor;
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                this.rtb.SelectionBackColor = colorDlg.Color;
                rtb_SelectionChanged(rtb, new EventArgs());
            }
        }

        //
        #endregion [Color]
        //
        #region [Bullet & Indent]
        //

        private void tsBullet_Click(object sender, EventArgs e)
        {
            if (this.rtb.ReadOnly)
            {
                return;
            }

            this.rtb.SelectionBullet = !this.rtb.SelectionBullet;
            rtb_SelectionChanged(rtb, new EventArgs());
        }

        private void tsIdentPlus_Click(object sender, EventArgs e)
        {
            if (this.rtb.ReadOnly)
            {
                return;
            }

            if (this.rtb.SelectionAlignment == HorizontalAlignment.Left)
            {
                this.rtb.SelectionIndent += 36;
            }
        }

        private void tsIdentMinus_Click(object sender, EventArgs e)
        {
            if (this.rtb.ReadOnly)
            {
                return;
            }

            if (this.rtb.SelectionAlignment == HorizontalAlignment.Left && this.rtb.SelectionIndent >= 36)
            {
                this.rtb.SelectionIndent -= 36;
            }
        }
        //
        #endregion [Bullet & Indent]
        //
        #region [Selection changed event]
        //
        private void rtb_SelectionChanged(object sender, EventArgs e)
        {
            // Font style, family and size
            if (this.rtb.SelectionFont != null)
            {
                this.tsBold.Checked = this.rtb.SelectionFont.Bold;
                this.tsItalic.Checked = this.rtb.SelectionFont.Italic;
                this.tsUnderline.Checked = this.rtb.SelectionFont.Underline;
                this.tsStrikeout.Checked = this.rtb.SelectionFont.Strikeout;

                this.tsFontType.Text = this.rtb.SelectionFont.Name;
                this.tsFontType.ToolTipText = this.rtb.SelectionFont.Name;
                double fontSize = Math.Round(this.rtb.SelectionFont.Size);
                this.tsFontSize.Text = fontSize.ToString();
            }

            // Alignment
            this.tsRight.Checked = (this.rtb.SelectionAlignment == HorizontalAlignment.Right);
            this.tsLeft.Checked = (this.rtb.SelectionAlignment == HorizontalAlignment.Left);
            this.tsCenter.Checked = (this.rtb.SelectionAlignment == HorizontalAlignment.Center);

            // Font color and background color
            //this.tsFontColor.BackColor = this.rtb.SelectionColor;
            //this.tsFontColor.ForeColor = this.rtb.SelectionColor;
            //this.tsBackgroundColor.BackColor = this.rtb.SelectionBackColor;
            //this.tsBackgroundColor.ForeColor = this.rtb.SelectionBackColor;

            // Bulleting
            this.tsBullet.Checked = this.rtb.SelectionBullet;
        }

        #endregion [Selection changed event]
        //
        #region [Input/output variables and properties]
        //
        [Description("Default document text in plain text format.")]
        public String DocumentText
        {
            get { return this.rtb.Text; }
            set { this.rtb.Text = value; }
        }
        //
        [Description("Default document text in RTF format.")]
        public String DocumentRtf
        {
            get { return this.rtb.Rtf; }
            set { this.rtb.Rtf = value; }
        }
        //
        private String defaultFontFamily = "Arial";
        [Description("Default font style.")]
        public String DefaultFontFamily
        {
            get { return this.defaultFontFamily; }
            set { this.defaultFontFamily = value; }
        }
        //
        private int defaultFontSize = 8;
        [Description("Default font size.")]
        public int DefaultFontSize
        {
            get { return this.defaultFontSize; }
            set { this.defaultFontSize = value; }
        }
        //
        private bool defaultWordWrap = false;
        [Description("Editor should use word wrap (true) or not (false).")]
        public bool DefaultWordWrap
        {
            get { return this.defaultWordWrap; }
            set { this.defaultWordWrap = value; }
        }
        //
        private Color defaultBackgroundColor = Color.White;
        [Description("Default background color.")]
        public Color DefaultBackgroundColor
        {
            get { return this.defaultBackgroundColor; }
            set { this.defaultBackgroundColor = value; }
        }
        //
        private Color defaultFontColor = Color.Black;
        [Description("Default foreground (font) color.")]
        public Color DefaultFontColor
        {
            get { return this.defaultFontColor; }
            set { this.defaultFontColor = value; }
        }
        //
        [Description("The text in the editor is read only (true) or writeable (false).")]
        public Boolean ReadOnly
        {
            get { return this.rtb.ReadOnly; }
            set { this.rtb.ReadOnly = value; }
        }
        //
        [Description("The toolstrip of the editor is visible (true) or not (false).")]
        public Boolean ToolStripVisible
        {
            get { return this.ts.Visible; }
            set { this.ts.Visible = value; }
        }
        //
        #endregion [Input/output variables and properties]

        #region Variables and settings
        // DirtyFlag
        //private Boolean isDirty = false;
        //
        #endregion Variables and settings
        //
        #region [Control constructor and load event]
        //
        private void RTFEditor_Load(object sender, EventArgs e)
        {
            // Set up default values
            this.rtb.AllowDrop = true;

            // Set up default values defined as user-changable
            this.tsFontSize.SelectedText = this.defaultFontSize.ToString();
            this.tsFontType.Text = this.defaultFontFamily;
            this.rtb.WordWrap = this.defaultWordWrap;

            if (String.IsNullOrEmpty(this.rtb.Text))
            {
                this.rtb.Font = new Font(this.defaultFontFamily, this.defaultFontSize, FontStyle.Regular);
            }

            this.tsFontColor.BackColor = this.defaultBackgroundColor;
            this.tsFontColor.ForeColor = this.tsFontColor.BackColor;
            this.tsBackgroundColor.BackColor = this.defaultFontColor;
            this.tsBackgroundColor.ForeColor = this.tsBackgroundColor.BackColor;

            // Default language

            rtb.Focus();
        }
        //
        #endregion [Control constructor and load event]
        ///




        private void tsFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFontTypeAndSize(this.rtb.SelectionFont.FontFamily, Int32.Parse(this.tsFontSize.SelectedItem.ToString()));
        }

        private void tsFontSize_Leave(object sender, EventArgs e)
        {
            try
            {
                ChangeFontTypeAndSize(this.rtb.SelectionFont.FontFamily, Int32.Parse(this.tsFontSize.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void tsFontSize_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChangeFontTypeAndSize(this.rtb.SelectionFont.FontFamily, Int32.Parse(this.tsFontSize.Text));
            }
        }


        private void ChangeFontTypeAndSize(FontFamily fontFamily, int fontSize)
        {
            if (this.rtb.ReadOnly)
            {
                return;
            }

            // New font
            try
            {
                Font myFont = new Font(fontFamily, fontSize, this.rtb.SelectionFont.Style);
                this.rtb.SelectionFont = myFont;
                rtb_SelectionChanged(rtb, new EventArgs());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void tsFontType_Click(object sender, EventArgs e)
        {
            if (this.rtb.ReadOnly)
            {
                return;
            }

            FontDialog fontDlg = new FontDialog();
            fontDlg.Font = this.rtb.SelectionFont;
            fontDlg.ShowColor = true;
            if (fontDlg.ShowDialog() == DialogResult.OK)
            {
                this.rtb.SelectionFont = fontDlg.Font;
                this.rtb.SelectionColor = fontDlg.Color;

                rtb_SelectionChanged(rtb, new EventArgs());
            }
        }









        #region [Zoom in/out]

//
        private void tsZoom_Leave(object sender, EventArgs e)
        {
            try
            {
                ChangeZoomValue(this.tsZoom.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

//
        private void tsZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeZoomValue(this.tsZoom.SelectedItem.ToString());
        }
//
        private void ChangeZoomValue(String zoomValue)
        {
            // Write back to control
            if (!zoomValue.Contains("%"))
            {
                this.tsZoom.Text = zoomValue + "%";
            }

            // Strip percentage symbol
            zoomValue = zoomValue.Replace("%", "");

            try
            {
                this.rtb.ZoomFactor = float.Parse(zoomValue) / 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //
        private void tsZoom_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChangeZoomValue(this.tsZoom.Text);
            }
        }

        #endregion [Zoom in/out]

        private void tsImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

               Image image = (Image.FromFile(openFileDialog1.FileName));
                Image resizedImage;

                double dbl = (double)image.Width / (double)image.Height;

                //set height of image to boxHeight and check if resulting width is less than boxWidth, 
                //else set width of image to boxWidth and calculate new height

                if ((int)((double)100 * dbl) <= 100)
                {
                    resizedImage = new Bitmap(image, (int)((double)100 * dbl), 100);
                }
                else
                {
                    resizedImage = new Bitmap(image, 100, (int)((double)100 / dbl));
                }



                Clipboard.SetImage((resizedImage));
                rtb.Paste();
            }



        }
    }//cls
}//ns
