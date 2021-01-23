// Version : 2.2.0.0 dt : 14-11-2017
// Auto Generated
// last update : 16-11-2017 03:20:26 PM

using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using CXLIB;

namespace ERP
{
    public partial class Main : MForm
    {
        readonly SkinManager skinmanager;
        

        public Main()
        {
            InitializeComponent();

            skinmanager = SkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = SkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(Primary.BlackGrey3535, Primary.BlackGrey3535, Primary.BlueGrey500, Accent.Pink400, TextShade.WHITE);
            
            Left = Top = 0;
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height - 40;
            Location = new Point();
            StartPosition = FormStartPosition.Manual;
            
            Current.SoftwareType = Server.SOFTWARETYPE;



            IntiMainMenu();
            
            ShowLoginform();
            
            GetVersionInfo();

        }

        #region[Override fliker]

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        #endregion[Override fliker]

        #region[Get Version info]

        void GetVersionInfo()
        {

            ////string InstalledVersion = Assembly.GetEntryAssembly().GetName().Version.ToString();

            ////string remoteversion = "";// RemoteVersion.Check();

            ////if (remoteversion == null)
            ////{
            ////    return;
            ////}

            ////if (remoteversion == InstalledVersion)
            ////{
            ////    lbl_version.Text = InstalledVersion;
            ////}
            ////else
            ////{
            ////    lbl_version.Text = " New Version " + remoteversion + " is found please update...";

            ////    spinner.Enabled = true;
            ////    spinner.Interval = 500;
            ////    spinner.Tick += new EventHandler(Timer_warning_Tick);
            ////}

        }

        private void Timer_warning_Tick(object sender, EventArgs e)
        {
            spinner.Start();
            if (lbl_version.Visible == true)
            {
                lbl_version.Visible = false;
            }
            else if (lbl_version.Visible == false)
            {
                lbl_version.Visible = true;
                lbl_version.ForeColor = Color.BlueViolet;
            }
        }

        #endregion[Get Version info]

    }//cls
}//ns
