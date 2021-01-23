namespace CXSETUP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_status_1 = new System.Windows.Forms.Label();
            this.Main_menu = new System.Windows.Forms.MenuStrip();
            this.Setup_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.new_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.update_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exit_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_screen = new System.Windows.Forms.Panel();
            this.Main_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(72, 516);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(20, 16);
            this.lbl_status.TabIndex = 10;
            this.lbl_status.Text = "....";
            // 
            // lbl_status_1
            // 
            this.lbl_status_1.AutoSize = true;
            this.lbl_status_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status_1.Location = new System.Drawing.Point(72, 537);
            this.lbl_status_1.Name = "lbl_status_1";
            this.lbl_status_1.Size = new System.Drawing.Size(20, 16);
            this.lbl_status_1.TabIndex = 19;
            this.lbl_status_1.Text = "....";
            // 
            // Main_menu
            // 
            this.Main_menu.BackColor = System.Drawing.Color.White;
            this.Main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Setup_menu});
            this.Main_menu.Location = new System.Drawing.Point(0, 0);
            this.Main_menu.Name = "Main_menu";
            this.Main_menu.Size = new System.Drawing.Size(932, 28);
            this.Main_menu.TabIndex = 20;
            this.Main_menu.Text = "menuStrip1";
            // 
            // Setup_menu
            // 
            this.Setup_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new_menu,
            this.toolStripMenuItem1,
            this.update_menu,
            this.toolStripMenuItem2,
            this.exit_menu});
            this.Setup_menu.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Setup_menu.Name = "Setup_menu";
            this.Setup_menu.Size = new System.Drawing.Size(60, 24);
            this.Setup_menu.Text = "Setup";
            // 
            // new_menu
            // 
            this.new_menu.Name = "new_menu";
            this.new_menu.Size = new System.Drawing.Size(128, 24);
            this.new_menu.Text = "New";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 6);
            // 
            // update_menu
            // 
            this.update_menu.Name = "update_menu";
            this.update_menu.Size = new System.Drawing.Size(128, 24);
            this.update_menu.Text = "Update";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(125, 6);
            // 
            // exit_menu
            // 
            this.exit_menu.Name = "exit_menu";
            this.exit_menu.Size = new System.Drawing.Size(128, 24);
            this.exit_menu.Text = "Exit";
            // 
            // Main_screen
            // 
            this.Main_screen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_screen.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Main_screen.Location = new System.Drawing.Point(0, 31);
            this.Main_screen.Name = "Main_screen";
            this.Main_screen.Size = new System.Drawing.Size(932, 531);
            this.Main_screen.TabIndex = 21;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 562);
            this.Controls.Add(this.Main_screen);
            this.Controls.Add(this.lbl_status_1);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.Main_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Main_menu;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CODEXSUN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Main_menu.ResumeLayout(false);
            this.Main_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_status_1;
        private System.Windows.Forms.MenuStrip Main_menu;
        private System.Windows.Forms.ToolStripMenuItem Setup_menu;
        private System.Windows.Forms.ToolStripMenuItem new_menu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem update_menu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exit_menu;
        private System.Windows.Forms.Panel Main_screen;
    }
}