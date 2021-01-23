namespace AXCODE
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mTabSelector1 = new CXLIB.MTabSelector();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_stables_runscript = new System.Windows.Forms.Button();
            this.btn_mtabels_runscript = new System.Windows.Forms.Button();
            this.spath_menu = new System.Windows.Forms.Button();
            this.mpath_menu = new System.Windows.Forms.Button();
            this.stables_menu = new System.Windows.Forms.Button();
            this.databases_menu = new System.Windows.Forms.Button();
            this.mtables_menu = new System.Windows.Forms.Button();
            this.menucreater_menu = new System.Windows.Forms.Button();
            this.main_tabControl = new CXLIB.MTabControl();
            this.home = new System.Windows.Forms.TabPage();
            this.btn_version = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.main_tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // mTabSelector1
            // 
            this.mTabSelector1.BaseTabControl = null;
            this.mTabSelector1.Depth = 0;
            this.mTabSelector1.Location = new System.Drawing.Point(-5, 469);
            this.mTabSelector1.MouseState = CXLIB.MouseState.HOVER;
            this.mTabSelector1.Name = "mTabSelector1";
            this.mTabSelector1.Size = new System.Drawing.Size(1128, 29);
            this.mTabSelector1.TabIndex = 1;
            this.mTabSelector1.Text = "mTabSelector1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_version);
            this.splitContainer1.Panel1.Controls.Add(this.btn_stables_runscript);
            this.splitContainer1.Panel1.Controls.Add(this.btn_mtabels_runscript);
            this.splitContainer1.Panel1.Controls.Add(this.spath_menu);
            this.splitContainer1.Panel1.Controls.Add(this.mpath_menu);
            this.splitContainer1.Panel1.Controls.Add(this.stables_menu);
            this.splitContainer1.Panel1.Controls.Add(this.databases_menu);
            this.splitContainer1.Panel1.Controls.Add(this.mtables_menu);
            this.splitContainer1.Panel1.Controls.Add(this.menucreater_menu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.main_tabControl);
            this.splitContainer1.Size = new System.Drawing.Size(1122, 497);
            this.splitContainer1.SplitterDistance = 152;
            this.splitContainer1.TabIndex = 3;
            // 
            // btn_stables_runscript
            // 
            this.btn_stables_runscript.Location = new System.Drawing.Point(31, 397);
            this.btn_stables_runscript.Name = "btn_stables_runscript";
            this.btn_stables_runscript.Size = new System.Drawing.Size(75, 44);
            this.btn_stables_runscript.TabIndex = 7;
            this.btn_stables_runscript.Text = "MTabels Run Script";
            this.btn_stables_runscript.UseVisualStyleBackColor = true;
            // 
            // btn_mtabels_runscript
            // 
            this.btn_mtabels_runscript.Location = new System.Drawing.Point(31, 263);
            this.btn_mtabels_runscript.Name = "btn_mtabels_runscript";
            this.btn_mtabels_runscript.Size = new System.Drawing.Size(75, 44);
            this.btn_mtabels_runscript.TabIndex = 6;
            this.btn_mtabels_runscript.Text = "MTabels Run Script";
            this.btn_mtabels_runscript.UseVisualStyleBackColor = true;
            this.btn_mtabels_runscript.Click += new System.EventHandler(this.btn_mtabels_runscript_Click);
            // 
            // spath_menu
            // 
            this.spath_menu.Location = new System.Drawing.Point(31, 368);
            this.spath_menu.Name = "spath_menu";
            this.spath_menu.Size = new System.Drawing.Size(75, 23);
            this.spath_menu.TabIndex = 5;
            this.spath_menu.Text = "SPath";
            this.spath_menu.UseVisualStyleBackColor = true;
            // 
            // mpath_menu
            // 
            this.mpath_menu.Location = new System.Drawing.Point(31, 217);
            this.mpath_menu.Name = "mpath_menu";
            this.mpath_menu.Size = new System.Drawing.Size(75, 23);
            this.mpath_menu.TabIndex = 4;
            this.mpath_menu.Text = "MPath";
            this.mpath_menu.UseVisualStyleBackColor = true;
            // 
            // stables_menu
            // 
            this.stables_menu.Location = new System.Drawing.Point(31, 339);
            this.stables_menu.Name = "stables_menu";
            this.stables_menu.Size = new System.Drawing.Size(75, 23);
            this.stables_menu.TabIndex = 3;
            this.stables_menu.Text = "STabels";
            this.stables_menu.UseVisualStyleBackColor = true;
            // 
            // databases_menu
            // 
            this.databases_menu.Location = new System.Drawing.Point(31, 111);
            this.databases_menu.Name = "databases_menu";
            this.databases_menu.Size = new System.Drawing.Size(75, 23);
            this.databases_menu.TabIndex = 2;
            this.databases_menu.Text = "Databases";
            this.databases_menu.UseVisualStyleBackColor = true;
            // 
            // mtables_menu
            // 
            this.mtables_menu.Location = new System.Drawing.Point(31, 188);
            this.mtables_menu.Name = "mtables_menu";
            this.mtables_menu.Size = new System.Drawing.Size(75, 23);
            this.mtables_menu.TabIndex = 1;
            this.mtables_menu.Text = "MTabels";
            this.mtables_menu.UseVisualStyleBackColor = true;
            // 
            // menucreater_menu
            // 
            this.menucreater_menu.Location = new System.Drawing.Point(31, 61);
            this.menucreater_menu.Name = "menucreater_menu";
            this.menucreater_menu.Size = new System.Drawing.Size(75, 23);
            this.menucreater_menu.TabIndex = 0;
            this.menucreater_menu.Text = "menuBuilder";
            this.menucreater_menu.UseVisualStyleBackColor = true;
            // 
            // main_tabControl
            // 
            this.main_tabControl.Controls.Add(this.home);
            this.main_tabControl.Depth = 0;
            this.main_tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_tabControl.Location = new System.Drawing.Point(0, 0);
            this.main_tabControl.MouseState = CXLIB.MouseState.HOVER;
            this.main_tabControl.Name = "main_tabControl";
            this.main_tabControl.SelectedIndex = 0;
            this.main_tabControl.Size = new System.Drawing.Size(966, 497);
            this.main_tabControl.TabIndex = 1;
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(4, 22);
            this.home.Name = "home";
            this.home.Padding = new System.Windows.Forms.Padding(3);
            this.home.Size = new System.Drawing.Size(958, 471);
            this.home.TabIndex = 0;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            // 
            // btn_version
            // 
            this.btn_version.Location = new System.Drawing.Point(31, 12);
            this.btn_version.Name = "btn_version";
            this.btn_version.Size = new System.Drawing.Size(75, 23);
            this.btn_version.TabIndex = 8;
            this.btn_version.Text = "Version";
            this.btn_version.UseVisualStyleBackColor = true;
            this.btn_version.Click += new System.EventHandler(this.btn_version_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 497);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.mTabSelector1);
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.main_tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CXLIB.MTabSelector mTabSelector1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private CXLIB.MTabControl main_tabControl;
        private System.Windows.Forms.TabPage home;
        private System.Windows.Forms.Button menucreater_menu;
        private System.Windows.Forms.Button mtables_menu;
        private System.Windows.Forms.Button databases_menu;
        private System.Windows.Forms.Button stables_menu;
        private System.Windows.Forms.Button mpath_menu;
        private System.Windows.Forms.Button spath_menu;
        private System.Windows.Forms.Button btn_stables_runscript;
        private System.Windows.Forms.Button btn_mtabels_runscript;
        private System.Windows.Forms.Button btn_version;
    }
}