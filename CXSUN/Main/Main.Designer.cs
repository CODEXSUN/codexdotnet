namespace CXSUN
{
    partial class Main
    {
        // <summary>
        // Required designer variable.
        // </summary>
        System.ComponentModel.IContainer components = null;

        // <summary>
        // Clean up any resources being used.
        // </summary>
        // <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // <summary>
        // Required method for Designer support - do not modify
        // the contents of this method with the code editor.
        // </summary>
        void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Codexsun = new System.Windows.Forms.Label();
            this.tagLine = new System.Windows.Forms.Label();
            this.back_greenLine = new System.Windows.Forms.Label();
            this.materialTabSelector1 = new CXLIB.MTabSelector();
            this.main_tabControl = new CXLIB.MTabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.lbl_version = new System.Windows.Forms.Label();
            this.cmp_info = new System.Windows.Forms.Label();
            this.menu_main = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.spinner = new System.Windows.Forms.Timer(this.components);
            this.main_tabControl.SuspendLayout();
            this.Home.SuspendLayout();
            this.SuspendLayout();
            // 
            // Codexsun
            // 
            this.Codexsun.AutoSize = true;
            this.Codexsun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Codexsun.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codexsun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(104)))), ((int)(((byte)(2)))));
            this.Codexsun.Location = new System.Drawing.Point(12, 4);
            this.Codexsun.Name = "Codexsun";
            this.Codexsun.Size = new System.Drawing.Size(160, 29);
            this.Codexsun.TabIndex = 1;
            this.Codexsun.Text = "CODEXSUN";
            // 
            // tagLine
            // 
            this.tagLine.AutoSize = true;
            this.tagLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.tagLine.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(206)))), ((int)(((byte)(7)))));
            this.tagLine.Location = new System.Drawing.Point(168, 17);
            this.tagLine.Name = "tagLine";
            this.tagLine.Size = new System.Drawing.Size(139, 14);
            this.tagLine.TabIndex = 2;
            this.tagLine.Text = "Software makes simple";
            // 
            // back_greenLine
            // 
            this.back_greenLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.back_greenLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(137)))), ((int)(((byte)(1)))));
            this.back_greenLine.Location = new System.Drawing.Point(3, 60);
            this.back_greenLine.Name = "back_greenLine";
            this.back_greenLine.Size = new System.Drawing.Size(1195, 10);
            this.back_greenLine.TabIndex = 3;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.main_tabControl;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 575);
            this.materialTabSelector1.MouseState = CXLIB.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1207, 23);
            this.materialTabSelector1.TabIndex = 7;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // main_tabControl
            // 
            this.main_tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_tabControl.Controls.Add(this.Home);
            this.main_tabControl.Depth = 0;
            this.main_tabControl.Location = new System.Drawing.Point(3, 70);
            this.main_tabControl.MouseState = CXLIB.MouseState.HOVER;
            this.main_tabControl.Name = "main_tabControl";
            this.main_tabControl.SelectedIndex = 0;
            this.main_tabControl.Size = new System.Drawing.Size(1195, 506);
            this.main_tabControl.TabIndex = 6;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.Home.Controls.Add(this.lbl_version);
            this.Home.Controls.Add(this.cmp_info);
            this.Home.Location = new System.Drawing.Point(4, 22);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(1187, 480);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            // 
            // lbl_version
            // 
            this.lbl_version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_version.BackColor = System.Drawing.Color.White;
            this.lbl_version.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_version.ForeColor = System.Drawing.Color.Teal;
            this.lbl_version.Location = new System.Drawing.Point(739, 430);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(430, 18);
            this.lbl_version.TabIndex = 22;
            this.lbl_version.Text = "CodeXsun";
            this.lbl_version.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmp_info
            // 
            this.cmp_info.AutoSize = true;
            this.cmp_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmp_info.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.cmp_info.Location = new System.Drawing.Point(991, 42);
            this.cmp_info.Name = "cmp_info";
            this.cmp_info.Size = new System.Drawing.Size(162, 25);
            this.cmp_info.TabIndex = 21;
            this.cmp_info.Text = "Company name";
            // 
            // menu_main
            // 
            this.menu_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu_main.AutoSize = false;
            this.menu_main.BackColor = System.Drawing.Color.White;
            this.menu_main.Dock = System.Windows.Forms.DockStyle.None;
            this.menu_main.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_main.Location = new System.Drawing.Point(3, 38);
            this.menu_main.Name = "menu_main";
            this.menu_main.Size = new System.Drawing.Size(1195, 30);
            this.menu_main.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(0, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1200, 583);
            this.label1.TabIndex = 19;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.menu_main);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.back_greenLine);
            this.Controls.Add(this.tagLine);
            this.Controls.Add(this.Codexsun);
            this.Controls.Add(this.main_tabControl);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.main_tabControl.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        System.Windows.Forms.Label Codexsun;
        System.Windows.Forms.Label tagLine;
        System.Windows.Forms.Label back_greenLine;
        CXLIB.MTabSelector materialTabSelector1;
        CXLIB.MTabControl main_tabControl;
        System.Windows.Forms.TabPage Home;
        System.Windows.Forms.MenuStrip menu_main;
        System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer spinner;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.Label cmp_info;
    }
}

