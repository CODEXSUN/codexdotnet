// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 26-03-2019 08:29:42 PM

using System.Windows.Forms;
using System.Drawing;
using CXLIB;
using System;
//
namespace CXCORE
{
    public partial class FLogin : UserControl
    {
        public FLogin()
        {
            InitializeComponent();
            Intilize();
            //finner_panel.BackColor = Color.FromArgb(225, 65, 56, 58);
            finner_panel.BackColor = Color.FromArgb(225, 4, 32, 43);
            txt_user_name.Focus();

            txt_user_name.Enter += new EventHandler(Txt_user_name_Enter);
            txt_user_name.KeyDown += new KeyEventHandler(Txt_user_name_KeyDown);
            txt_user_password.Enter += new EventHandler(Txt_user_password_Enter);
            txt_user_password.KeyDown += new KeyEventHandler(Txt_user_password_KeyDown);

        }

        #region [Private Declare]

        private Panel fpanel;
        private Panel finner_panel;
        private TextBox txt_user_name;
        private TextBox txt_user_password;
        private OfficeButton btn_login;
        private PictureBox pic_password;
        private PictureBox pic_user;
        private PictureBox pic_logo;
        private Label lbl_contact;
        private Timer timer_warning;
        private Label txt_errorUserPassword;
        private Label lbl_cell;
        private OfficeButton btn_exit;
        private CheckBox login_checkBox;

        #endregion [Private Declare]

        #region [Intilize]

        private void Intilize()
        {
            components = new System.ComponentModel.Container();
            timer_warning = new Timer(components);
            fpanel = new Panel();
            login_checkBox = new CheckBox();
            btn_exit = new OfficeButton();
            lbl_contact = new Label();
            lbl_cell = new Label();
            finner_panel = new Panel();
            txt_errorUserPassword = new Label();
            btn_login = new OfficeButton();
            pic_user = new PictureBox();
            pic_password = new PictureBox();
            pic_logo = new PictureBox();
            txt_user_password = new TextBox();
            txt_user_name = new TextBox();
            fpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pic_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pic_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pic_logo)).BeginInit();
            SuspendLayout();
            // 
            // timer_warning
            // 
            timer_warning.Enabled = true;
            timer_warning.Interval = 500;
            timer_warning.Tick += new System.EventHandler(timer_warning_Tick);
            // 
            // f_panel
            // 
            fpanel.BackColor = Color.White;
            fpanel.BackgroundImage = Login_bg.Bg;
            fpanel.BackgroundImageLayout = ImageLayout.Stretch;
            fpanel.BorderStyle = BorderStyle.FixedSingle;
            fpanel.Controls.Add(login_checkBox);
            fpanel.Controls.Add(btn_exit);
            fpanel.Controls.Add(lbl_contact);
            fpanel.Controls.Add(lbl_cell);

            fpanel.Controls.Add(finner_panel);
            fpanel.Dock = DockStyle.Fill;
            fpanel.Location = new Point(0, 0);
            fpanel.Name = "f_panel";
            fpanel.Size = new Size(900, 650);
            fpanel.TabIndex = 0;
            // 
            // login_checkBox
            // 
            login_checkBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            login_checkBox.AutoSize = true;
            login_checkBox.BackColor = Color.Transparent;
            login_checkBox.ForeColor = SystemColors.ControlLightLight;
            login_checkBox.Location = new Point(755, 547);
            login_checkBox.Name = "login_checkBox";
            login_checkBox.Size = new Size(106, 17);
            login_checkBox.TabIndex = 21;
            login_checkBox.Text = "&Remember Login";
            login_checkBox.UseVisualStyleBackColor = false;
            login_checkBox.CheckedChanged += new System.EventHandler(Login_checkBox_CheckedChanged);
            // 
            // btn_exit
            // 
            btn_exit.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            btn_exit.BackColor = Color.Gainsboro;
            btn_exit.FlatAppearance.BorderColor = Color.Gainsboro;
            btn_exit.FlatAppearance.BorderSize = 0;
            btn_exit.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 123, 170);
            btn_exit.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 96, 144);
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            btn_exit.ForeColor = Color.White;
            btn_exit.Location = new Point(841, 21);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(31, 28);
            btn_exit.TabIndex = 4;
            btn_exit.Text = "X";
            btn_exit.Themes = Themescheme.RED;
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += new System.EventHandler(Btn_exit_Click);
            // 
            // label1
            // 
            lbl_contact.Anchor = XAnchor.LB;
            lbl_contact.AutoSize = true;
            lbl_contact.BackColor = Color.Transparent;
            lbl_contact.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lbl_contact.ForeColor = Color.FromArgb(8, 158, 193);
            lbl_contact.Location = new Point(17, 569);
            lbl_contact.Name = "lbl_contact";
            lbl_contact.Size = new Size(98, 25);
            lbl_contact.TabIndex = 1;
            lbl_contact.Text = "Contact :";
            // 
            // label4
            // 
            lbl_cell.Anchor =  XAnchor.LB;
            lbl_cell.AutoSize = true;
            lbl_cell.BackColor = Color.Transparent;
            lbl_cell.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lbl_cell.ForeColor = Color.Lime;
            lbl_cell.Location = new Point(110, 569);
            lbl_cell.Name = "lbl_cell";
            lbl_cell.Size = new Size(149, 25);
            lbl_cell.TabIndex = 2;
            lbl_cell.Text = " 9655227738";
            // 
            // _panel
            // 
            finner_panel.Anchor = XAnchor.LTR;
            //finner_panel.BackColor = Color.FromArgb(235, 202, 254);//(17, 21, 22);
            finner_panel.Controls.Add(txt_errorUserPassword);
            finner_panel.Controls.Add(pic_logo);
            finner_panel.Controls.Add(btn_login);
            finner_panel.Controls.Add(pic_user);
            finner_panel.Controls.Add(pic_password);
            finner_panel.Controls.Add(txt_user_password);
            finner_panel.Controls.Add(txt_user_name);
            finner_panel.Location = new Point(-9, 307);
            finner_panel.Name = "_panel";
            finner_panel.Size = new Size(908, 201);
            finner_panel.TabIndex = 0;
            // 
            // txt_status
            // 
            txt_errorUserPassword.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            txt_errorUserPassword.AutoSize = true;
            txt_errorUserPassword.BackColor = Color.Transparent;
            txt_errorUserPassword.Font = new Font("Calibri", 15.75F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
            txt_errorUserPassword.ForeColor = Color.LavenderBlush;
            txt_errorUserPassword.Location = new Point(447, 111);
            txt_errorUserPassword.Name = "txt_status";
            txt_errorUserPassword.Size = new Size(32, 26);
            txt_errorUserPassword.TabIndex = 20;
            txt_errorUserPassword.Text = "    ";
            // 
            // btn_login
            // 
            btn_login.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            btn_login.BackColor = Color.Gainsboro;
            btn_login.FlatAppearance.BorderColor = Color.Gainsboro;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 123, 170);
            btn_login.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 96, 144);
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(734, 128);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(136, 48);
            btn_login.TabIndex = 2;
            btn_login.Text = "&LOGIN";
            btn_login.Themes = Themescheme.Green;
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += new System.EventHandler(Btn_login_Click);
            // 
            // pic_user
            // 
            pic_user.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            pic_user.BackColor = Color.White;
            pic_user.Image = global::CXLIB.Properties.Resources.person_users;
            pic_user.Location = new Point(836, 32);
            pic_user.Name = "pic_user";
            pic_user.Size = new Size(28, 24);
            pic_user.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_user.TabIndex = 17;
            pic_user.TabStop = false;
            // 
            // pic_password
            // 
            pic_password.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            pic_password.BackColor = Color.White;
            pic_password.Image = global::CXLIB.Properties.Resources.key;
            pic_password.Location = new Point(836, 82);
            pic_password.Name = "pic_password";
            pic_password.Size = new Size(28, 24);
            pic_password.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_password.TabIndex = 18;
            pic_password.TabStop = false;
            // 
            // pic_logo
            // 
            pic_logo.BackColor = Color.Transparent;
            pic_logo.BackgroundImage = global::CXLIB.Properties.Resources.codexsun;
            pic_logo.BackgroundImageLayout = ImageLayout.Stretch;
            pic_logo.ErrorImage = null;
            pic_logo.Image = global::CXLIB.Properties.Resources.codexsun;
            pic_logo.InitialImage = null;
            pic_logo.Location = new Point(152, 0);
            pic_logo.Name = "pic_logo";
            pic_logo.Size = new Size(490, 180);
            pic_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_logo.TabIndex = 19;
            pic_logo.TabStop = false;
            // 
            // txt_user_password
            // 
            txt_user_password.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            txt_user_password.BorderStyle = BorderStyle.None;
            txt_user_password.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            txt_user_password.ForeColor = Color.SteelBlue;
            txt_user_password.Location = new Point(534, 78);
            txt_user_password.Name = "txt_user_password";
            txt_user_password.Size = new Size(333, 33);
            txt_user_password.TabIndex = 1;
            txt_user_password.UseSystemPasswordChar = true;
            // 
            // txt_user_name
            // 
            txt_user_name.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            txt_user_name.BorderStyle = BorderStyle.None;
            txt_user_name.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            txt_user_name.ForeColor = Color.SteelBlue;
            txt_user_name.Location = new Point(534, 28);
            txt_user_name.Name = "txt_user_name";
            txt_user_name.Size = new Size(333, 33);
            txt_user_name.TabIndex = 0;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(fpanel);
            Name = "fLogin";
            Size = new Size(900, 650);
            fpanel.ResumeLayout(false);
            fpanel.PerformLayout();
          //  finner_panel.ResumeLayout(false);
           // finner_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pic_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pic_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pic_logo)).EndInit();
            ResumeLayout(false);

    }

        #endregion[Intilize]

    }//cls
}//ns
