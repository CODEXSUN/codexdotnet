using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace CXLIB
{
    //== eXtended Panel: Rounded-Corners, Gradient, Border, Shadow, Logo ==//
	public partial class XPanel : Panel
	{
        public const string XCategory = "Extended";
        
        int _borderWidth = 1;
		[Browsable(true), Category(XPanel.XCategory)]
		[DefaultValue(1)]
		public int BorderWidth
		{
			get { return _borderWidth; }
			set { _borderWidth = value; Invalidate(); }
		}

		int _shadowOffSet = 0;
		[Browsable(true), Category(XPanel.XCategory)]
		[DefaultValue(0)]
		public int ShadowOffSet
		{
			get
			{
				return _shadowOffSet;
			}
			set { _shadowOffSet = Math.Abs(value); Invalidate(); }
		}

        Color _shadowColor = Color.Gray;
        [Browsable(true), Category(XPanel.XCategory)]
        [DefaultValue("Color.Gray")]
        public Color ShadowColor
        {
            get { return _shadowColor; }
            set { _shadowColor = value; Invalidate(); }
        }

		int _roundCornerRadius = 0;
		[Browsable(true), Category(XPanel.XCategory)]
		[DefaultValue(0)]
		public int RoundCornerRadius
		{
			get { return _roundCornerRadius; }
			set { _roundCornerRadius = Math.Abs(value); Invalidate(); }
		}

		Image _image;
		[Browsable(true), Category(XPanel.XCategory)]
		public Image Image
		{
			get { return _image; }
			set { _image = value; Invalidate(); }
		}

		Point _imageLocation = new Point(4, 4);
		[Browsable(true), Category(XPanel.XCategory)]
		[DefaultValue("4,4")]
		public Point ImageLocation
		{
			get { return _imageLocation; }
			set { _imageLocation = value; Invalidate(); }
		}

		Color _borderColor = Color.Gray;
		[Browsable(true), Category(XPanel.XCategory)]
		[DefaultValue("Color.Gray")]
		public Color BorderColor
		{
			get { return _borderColor; }
			set { _borderColor = value; Invalidate(); }
		}

		Color _gradientStartColor = Color.White;
		[Browsable(true), Category(XPanel.XCategory)]
		[DefaultValue("Color.White")]
		public Color GradientStartColor
		{
			get { return _gradientStartColor; }
			set { _gradientStartColor = value; Invalidate(); }
		}

		Color _gradientEndColor = Color.Gray;
		[Browsable(true), Category(XPanel.XCategory)]
		[DefaultValue("Color.Gray")]
		public Color GradientEndColor
		{
			get { return _gradientEndColor; }
			set { _gradientEndColor = value; Invalidate(); }
		}

        bool _drawGradient = false;
        [Browsable(true), Category(XPanel.XCategory)]
        [DefaultValue(false)]
        public bool DrawGradient
        {
            get
            {
                return _drawGradient;
            }
            set
            {
                _drawGradient = value;
                Invalidate();
            }
        }

        LinearGradientMode _gradientDirection = LinearGradientMode.BackwardDiagonal;
        [Browsable(true), Category(XPanel.XCategory)]
        [DefaultValue("LinearGradientMode.BackwardDiagonal")]
        public LinearGradientMode GradientDirection
        {
            get { return _gradientDirection; }
            set { _gradientDirection = value; Invalidate(); }
        }

        SideEnum _roundCornerSide = SideEnum.Top;
        [Browsable(true), Category(XPanel.XCategory)]
        [DefaultValue("SideEnum.Top")]
        public SideEnum RoundCornerSide
        {
            get { return _roundCornerSide; }
            set { _roundCornerSide = value; Invalidate(); }
        }
        
        public XPanel()
		{
			this.SetStyle(ControlStyles.DoubleBuffer, true);
			this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			this.SetStyle(ControlStyles.ResizeRedraw, true);
			this.SetStyle(ControlStyles.UserPaint, true);
			this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			InitializeComponent();
		}

		protected override void OnPaintBackground(PaintEventArgs e)
		{
            base.OnPaintBackground(e);
            ///
            int tmpShadowOffSet = Math.Min(Math.Min(_shadowOffSet, this.Width - 2), this.Height - 2);
            int tmpRoundCornerRadius = 0; //--ak:temp: Math.Min(Math.Min(_roundCornerRadius, this.Width - 2), this.Height - 2);

            Rectangle rect = new Rectangle(0, 0, this.Width - tmpShadowOffSet - 1, this.Height - tmpShadowOffSet - 1);
            Rectangle rectShadow = new Rectangle(tmpShadowOffSet, tmpShadowOffSet, this.Width - tmpShadowOffSet - 1, this.Height - tmpShadowOffSet - 1);

            GraphicsPath graphPathShadow = null;
            GraphicsPath graphPath = null;

            if (tmpRoundCornerRadius >= 1)
            {
                if (this.Width > 1 && this.Height > 1)
                {
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                    if (_roundCornerSide == SideEnum.Top)
                    {
                        graphPathShadow = XPanelUtil.GetRoundPathXTop(rectShadow, tmpRoundCornerRadius);
                        graphPath = XPanelUtil.GetRoundPathXTop(rect, tmpRoundCornerRadius);
                    }
                    else if (_roundCornerSide == SideEnum.Left)
                    {
                        graphPathShadow = XPanelUtil.GetRoundPathXLeft(rectShadow, tmpRoundCornerRadius);
                        graphPath = XPanelUtil.GetRoundPathXLeft(rect, tmpRoundCornerRadius);
                    }
                    else if (_roundCornerSide == SideEnum.Bottom)
                    {
                        graphPathShadow = XPanelUtil.GetRoundPathXTop(rectShadow, tmpRoundCornerRadius);
                        graphPath = XPanelUtil.GetRoundPathXTop(rect, tmpRoundCornerRadius);
                    }
                    else if (_roundCornerSide == SideEnum.Right)
                    {
                        graphPathShadow = XPanelUtil.GetRoundPathXLeft(rectShadow, tmpRoundCornerRadius);
                        graphPath = XPanelUtil.GetRoundPathXLeft(rect, tmpRoundCornerRadius);
                    }
                }
            }
            else
            {
                graphPath = new GraphicsPath();
                graphPath.AddRectangle(rect);

                graphPath = new GraphicsPath();
                graphPath.AddRectangle(rectShadow);
            }
                
            //== Draw Shadow ==
            if (tmpShadowOffSet > 0)
			{
				using (PathGradientBrush gBrush = new PathGradientBrush(graphPathShadow))
				{
					gBrush.WrapMode = WrapMode.Clamp;
					ColorBlend colorBlend = new ColorBlend(3);
                    colorBlend.Colors = new Color[]{Color.Transparent, 
												Color.FromArgb(180, this._shadowColor), 
												Color.FromArgb(180, this._shadowColor)};

					colorBlend.Positions = new float[] { 0f, .1f, 1f };

					gBrush.InterpolationColors = colorBlend;
					e.Graphics.FillPath(gBrush, graphPathShadow);
				}
			}

			//== Draw Background ==
            if (_drawGradient == true)
            {
                //////LinearGradientBrush brush = new LinearGradientBrush(rect,
                //////    this._gradientStartColor,
                //////    this._gradientEndColor,
                //////    this._gradientDirection);
                SolidBrush brush = new SolidBrush(this._gradientStartColor);
                //TextureBrush brush3 = new TextureBrush(Image.FromFile(@"D:\PROJECTS\Backups\bg3.bmp"));
                e.Graphics.FillPath(brush, graphPath);
            }
            else
            {
            }

            //== Draw Border ==
            if (this._borderWidth != 0)
            {
                e.Graphics.DrawPath(new Pen(Color.FromArgb(180, this._borderColor), _borderWidth), graphPath);
            }

			//== Draw Logo Image ==
			if (_image != null)
			{
				e.Graphics.DrawImageUnscaled(_image, _imageLocation);
			}
		}


	} //class-XPanel


    public enum SideEnum
    {
        Top,
        Left,
        Bottom,
        Right,
        All
    }

    public class XPanelUtil
    {
        /* Used by XPanel */
        public static GraphicsPath GetRoundPathXTop(Rectangle r, int depth)
        {
            GraphicsPath graphPath = new GraphicsPath();

            if (depth == 0)
            {
                graphPath.AddRectangle(r);
            }
            else
            {
                graphPath.AddArc(r.X, r.Y, depth, depth, 180, 90);
                graphPath.AddArc(r.X + r.Width - depth, r.Y, depth, depth, 270, 90);
                //===graphPath.AddArc(r.X + r.Width - depth, r.Y + r.Height - depth, depth, depth, 0, 90);
                //===graphPath.AddArc(r.X, r.Y + r.Height - depth, depth, depth, 90, 90);
                //===graphPath.AddLine(r.X, r.Y + r.Height - depth, r.X, r.Y + depth / 2);
                graphPath.AddLine(r.X + r.Width - 1, r.Y + r.Height - 1, r.X + r.Width - 1, r.Y + r.Height - 1);
                graphPath.AddLine(r.X, r.Y + r.Height - 1, r.X, r.Y + r.Height - 1);
                graphPath.AddLine(r.X, r.Y + depth / 2, r.X, r.Y + depth / 2);

            }
            return graphPath;
        }

        public static GraphicsPath GetRoundPathXLeft(Rectangle r, int depth)
        {
            GraphicsPath graphPath = new GraphicsPath();

            if (depth == 0)
            {
                graphPath.AddRectangle(r);
            }
            else
            {
                graphPath.AddArc(r.X, r.Y, depth, depth, 180, 90);
                //====graphPath.AddArc(r.X + r.Width - depth, r.Y, depth, depth, 270, 90);
                //====graphPath.AddArc(r.X + r.Width - depth, r.Y + r.Height - depth, depth, depth, 0, 90);
                graphPath.AddLine(r.X + r.Width - 1, r.Y, r.X + r.Width - 1, r.Y);
                graphPath.AddLine(r.X + r.Width - 1, r.Y + r.Height - 1, r.X + r.Width - 1, r.Y + r.Height - 1);
                graphPath.AddArc(r.X, r.Y + r.Height - depth, depth, depth, 90, 90);
                graphPath.AddLine(r.X, r.Y + r.Height - depth, r.X, r.Y + depth / 2);
            }
            return graphPath;
        }

        public static GraphicsPath GetRoundPathXAll(Rectangle r, int depth)
        {
            GraphicsPath graphPath = new GraphicsPath();

            if (depth == 0)
            {
                graphPath.AddRectangle(r);
            }
            else
            {
                graphPath.AddArc(r.X, r.Y, depth, depth, 180, 90);
                graphPath.AddArc(r.X + r.Width - depth, r.Y, depth, depth, 270, 90);
                graphPath.AddArc(r.X + r.Width - depth, r.Y + r.Height - depth, depth, depth, 0, 90);
                graphPath.AddArc(r.X, r.Y + r.Height - depth, depth, depth, 90, 90);
                graphPath.AddLine(r.X, r.Y + r.Height - depth, r.X, r.Y + depth / 2);
            }
            return graphPath;
        }

        /* Used by DrawRoundRectBorder() */
        private static GraphicsPath GetRoundPath(Rectangle r, int depth, int borderSize)
        {
            GraphicsPath graphPath = new GraphicsPath();

            if (depth == 0)
            {
                graphPath.AddRectangle(r);
            }
            else
            {
                if (borderSize >= 2)
                {
                    r.X += borderSize - 1;
                    r.Y += borderSize - 1;
                    r.Width -= (borderSize - 1) * 2;
                    r.Height -= (borderSize - 1) * 2;
                }
                ///
                graphPath.AddArc(r.X, r.Y, depth, depth, 180, 90);
                graphPath.AddArc(r.X + r.Width - 1 - depth, r.Y, depth, depth, 270, 90);
                ///
                if (borderSize % 2 == 0)
                {
                    r.Width += 1;
                    r.Height += 1;
                }
                ///
                graphPath.AddLine(r.X + r.Width - 1, r.Y + r.Height - 1, r.X + r.Width - 1, r.Y + r.Height - 1);
                graphPath.AddLine(r.X, r.Y + r.Height - 1, r.X, r.Y + r.Height - 1);
                graphPath.AddLine(r.X, r.Y + depth / 2, r.X, r.Y + depth / 2);
            }
            return graphPath;
        }

        /* Used by UserControls */
        public static void DrawRoundRectBorder(Graphics g, Control ctrl, Rectangle rect, int roundCornerDepth, int borderSize, Color borderColor, Color gradientStartColor, Color gradientEndColor, LinearGradientMode gradientDirection)
        {
            borderSize = 2;
            DrawRoundRectBorder(g, ctrl, rect, roundCornerDepth, borderSize, borderColor, gradientStartColor, gradientEndColor, gradientDirection, true);
        }
        public static void DrawRoundRectBorder(Graphics g, Control ctrl, Rectangle rect, int roundCornerDepth, int borderSize, Color borderColor, Color gradientStartColor, Color gradientEndColor, LinearGradientMode gradientDirection, bool bgOpaque)
        {
            roundCornerDepth = 0; //--ak:temp:

            if (rect.Width == 0 && rect.Height == 0) 
            {
                return;
            }

            ctrl.BackColor = Color.Transparent; //== THIS AFFECTS LABLE ETC.'S BG.
            ///
            if (bgOpaque == true) 
            {
                g.FillRectangle(new SolidBrush(borderColor), rect); //==DRAW OPAQUE BG.
            }
            
            GraphicsPath graphPath = XPanelUtil.GetRoundPath(rect, roundCornerDepth, borderSize);

            //== Draw Background ==
            LinearGradientBrush brush = new LinearGradientBrush(rect,
                gradientStartColor,
                gradientEndColor,
                gradientDirection);
            //SolidBrush brush2 = new SolidBrush(gradientStartColor);
            //TextureBrush brush3 = new TextureBrush(Image.FromFile(@"D:\PROJECTS\Backups\bg3.bmp"));
            g.FillPath(brush, graphPath);

            //== Draw Border ==
            g.DrawPath(new Pen(borderColor, borderSize), graphPath);
        }

   }
}