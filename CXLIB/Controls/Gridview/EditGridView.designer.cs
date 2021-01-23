namespace CXLIB
{
    partial class EditGridView
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
            this.components = new System.ComponentModel.Container();
            this.menu_Strip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menu_DeleteLine = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_InsertLineBefore = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_InsertLineAfter = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Strip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.menu_Strip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_Strip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_DeleteLine,
            this.menu_InsertLineBefore,
            this.menu_InsertLineAfter});
            this.menu_Strip1.Name = "contextMenuStrip1";
            this.menu_Strip1.Size = new System.Drawing.Size(185, 70);
            // 
            // menu_DeleteLine
            // 
            this.menu_DeleteLine.ForeColor = System.Drawing.Color.RoyalBlue;
            this.menu_DeleteLine.Name = "menu_DeleteLine";
            this.menu_DeleteLine.Size = new System.Drawing.Size(184, 22);
            this.menu_DeleteLine.Text = "Delete This Line";
            // 
            // menu_InsertLineBefore
            // 
            this.menu_InsertLineBefore.ForeColor = System.Drawing.Color.RoyalBlue;
            this.menu_InsertLineBefore.Name = "menu_InsertLineBefore";
            this.menu_InsertLineBefore.Size = new System.Drawing.Size(184, 22);
            this.menu_InsertLineBefore.Text = "Insert a Line Before";
            // 
            // menu_InsertLineAfter
            // 
            this.menu_InsertLineAfter.ForeColor = System.Drawing.Color.RoyalBlue;
            this.menu_InsertLineAfter.Name = "menu_InsertLineAfter";
            this.menu_InsertLineAfter.Size = new System.Drawing.Size(184, 22);
            this.menu_InsertLineAfter.Text = "Insert a Line After";
            this.menu_Strip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ContextMenuStrip menu_Strip1;
        public System.Windows.Forms.ToolStripMenuItem menu_DeleteLine;
        public System.Windows.Forms.ToolStripMenuItem menu_InsertLineBefore;
        public System.Windows.Forms.ToolStripMenuItem menu_InsertLineAfter;
    }
}
