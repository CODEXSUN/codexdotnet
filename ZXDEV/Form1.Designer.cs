
namespace ZXDEV
{
    partial class Form1
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
            this.split_container = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitTimerS = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.split_container)).BeginInit();
            this.split_container.Panel2.SuspendLayout();
            this.split_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // split_container
            // 
            this.split_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split_container.Location = new System.Drawing.Point(0, 0);
            this.split_container.Name = "split_container";
            // 
            // split_container.Panel1
            // 
            this.split_container.Panel1.BackColor = System.Drawing.Color.Black;
            // 
            // split_container.Panel2
            // 
            this.split_container.Panel2.Controls.Add(this.button1);
            this.split_container.Panel2.Controls.Add(this.pictureBox1);
            this.split_container.Panel2.Controls.Add(this.label1);
            this.split_container.Size = new System.Drawing.Size(800, 450);
            this.split_container.SplitterDistance = 100;
            this.split_container.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 30);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // splitTimerS
            // 
            this.splitTimerS.Interval = 2;
            this.splitTimerS.Tick += new System.EventHandler(this.splitTimerS_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.split_container);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.split_container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split_container)).EndInit();
            this.split_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer split_container;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer splitTimerS;
    }
}

