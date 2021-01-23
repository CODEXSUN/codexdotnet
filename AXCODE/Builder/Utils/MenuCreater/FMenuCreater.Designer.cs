namespace AXCODE
{
    partial class FMenuCreater
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
            this.txt_result = new System.Windows.Forms.RichTextBox();
            this.lbl_table = new System.Windows.Forms.Label();
            this.btn_display = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_header = new System.Windows.Forms.Label();
            this.txt_table = new CXLIB.LookupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radio_none = new System.Windows.Forms.RadioButton();
            this.radio_list = new System.Windows.Forms.RadioButton();
            this.radio_form = new System.Windows.Forms.RadioButton();
            this.btn_addMain = new System.Windows.Forms.Button();
            this.txt_path = new CXLIB.LookupBox();
            this.lbl_path = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_result
            // 
            this.txt_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_result.Location = new System.Drawing.Point(12, 171);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(1050, 453);
            this.txt_result.TabIndex = 5;
            this.txt_result.Text = "";
            // 
            // lbl_table
            // 
            this.lbl_table.BackColor = System.Drawing.Color.White;
            this.lbl_table.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_table.Location = new System.Drawing.Point(31, 64);
            this.lbl_table.Name = "lbl_table";
            this.lbl_table.Padding = new System.Windows.Forms.Padding(0, 0, 10, 1);
            this.lbl_table.Size = new System.Drawing.Size(90, 29);
            this.lbl_table.TabIndex = 128;
            this.lbl_table.Text = "Table";
            this.lbl_table.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_display
            // 
            this.btn_display.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btn_display.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_display.FlatAppearance.BorderSize = 2;
            this.btn_display.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(123)))), ((int)(((byte)(170)))));
            this.btn_display.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_display.ForeColor = System.Drawing.Color.White;
            this.btn_display.Location = new System.Drawing.Point(910, 51);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(118, 48);
            this.btn_display.TabIndex = 131;
            this.btn_display.Text = "DISPLAY";
            this.btn_display.UseVisualStyleBackColor = false;
            this.btn_display.Click += new System.EventHandler(this.Btn_create_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(1032, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 27);
            this.btn_close.TabIndex = 134;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // lbl_header
            // 
            this.lbl_header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_header.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.Color.White;
            this.lbl_header.Location = new System.Drawing.Point(-5, 0);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(1108, 35);
            this.lbl_header.TabIndex = 135;
            this.lbl_header.Text = "Menu Creator";
            this.lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_table
            // 
            this.txt_table.AllowNewEntry = false;
            this.txt_table.BackColor = System.Drawing.Color.White;
            this.txt_table.EmptyBackColor = System.Drawing.Color.White;
            this.txt_table.EmptyForeColor = System.Drawing.Color.Black;
            this.txt_table.FilledBackColor = System.Drawing.Color.White;
            this.txt_table.FilledForeColor = System.Drawing.Color.SteelBlue;
            this.txt_table.FocusBackColor = System.Drawing.Color.LightBlue;
            this.txt_table.FocusForeColor = System.Drawing.Color.Black;
            this.txt_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_table.ForeColor = System.Drawing.Color.Black;
            this.txt_table.Location = new System.Drawing.Point(116, 64);
            this.txt_table.LookupButtonVisible = true;
            this.txt_table.LookupList = null;
            this.txt_table.Name = "txt_table";
            this.txt_table.ReadOnlyBackColor = System.Drawing.Color.White;
            this.txt_table.ReadOnlyForeColor = System.Drawing.Color.Black;
            this.txt_table.SelectedEntity = null;
            this.txt_table.Size = new System.Drawing.Size(311, 29);
            this.txt_table.TabIndex = 137;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.radio_none);
            this.groupBox2.Controls.Add(this.radio_list);
            this.groupBox2.Controls.Add(this.radio_form);
            this.groupBox2.Location = new System.Drawing.Point(612, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(106, 87);
            this.groupBox2.TabIndex = 139;
            this.groupBox2.TabStop = false;
            // 
            // radio_none
            // 
            this.radio_none.AutoSize = true;
            this.radio_none.Location = new System.Drawing.Point(17, 58);
            this.radio_none.Name = "radio_none";
            this.radio_none.Size = new System.Drawing.Size(51, 17);
            this.radio_none.TabIndex = 2;
            this.radio_none.Text = "None";
            this.radio_none.UseVisualStyleBackColor = true;
            // 
            // radio_list
            // 
            this.radio_list.AutoSize = true;
            this.radio_list.Location = new System.Drawing.Point(17, 38);
            this.radio_list.Name = "radio_list";
            this.radio_list.Size = new System.Drawing.Size(41, 17);
            this.radio_list.TabIndex = 1;
            this.radio_list.Text = "List";
            this.radio_list.UseVisualStyleBackColor = true;
            // 
            // radio_form
            // 
            this.radio_form.AutoSize = true;
            this.radio_form.Checked = true;
            this.radio_form.Location = new System.Drawing.Point(17, 18);
            this.radio_form.Name = "radio_form";
            this.radio_form.Size = new System.Drawing.Size(48, 17);
            this.radio_form.TabIndex = 0;
            this.radio_form.TabStop = true;
            this.radio_form.Text = "Form";
            this.radio_form.UseVisualStyleBackColor = true;
            // 
            // btn_addMain
            // 
            this.btn_addMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btn_addMain.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_addMain.FlatAppearance.BorderSize = 2;
            this.btn_addMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(123)))), ((int)(((byte)(170)))));
            this.btn_addMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_addMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addMain.ForeColor = System.Drawing.Color.White;
            this.btn_addMain.Location = new System.Drawing.Point(910, 105);
            this.btn_addMain.Name = "btn_addMain";
            this.btn_addMain.Size = new System.Drawing.Size(118, 48);
            this.btn_addMain.TabIndex = 141;
            this.btn_addMain.Text = "ADD to main";
            this.btn_addMain.UseVisualStyleBackColor = false;
            // 
            // txt_path
            // 
            this.txt_path.AllowNewEntry = false;
            this.txt_path.BackColor = System.Drawing.Color.White;
            this.txt_path.EmptyBackColor = System.Drawing.Color.White;
            this.txt_path.EmptyForeColor = System.Drawing.Color.Black;
            this.txt_path.FilledBackColor = System.Drawing.Color.White;
            this.txt_path.FilledForeColor = System.Drawing.Color.SteelBlue;
            this.txt_path.FocusBackColor = System.Drawing.Color.LightBlue;
            this.txt_path.FocusForeColor = System.Drawing.Color.Black;
            this.txt_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_path.ForeColor = System.Drawing.Color.Black;
            this.txt_path.Location = new System.Drawing.Point(116, 107);
            this.txt_path.LookupButtonVisible = true;
            this.txt_path.LookupList = null;
            this.txt_path.Name = "txt_path";
            this.txt_path.ReadOnlyBackColor = System.Drawing.Color.White;
            this.txt_path.ReadOnlyForeColor = System.Drawing.Color.Black;
            this.txt_path.SelectedEntity = null;
            this.txt_path.Size = new System.Drawing.Size(311, 29);
            this.txt_path.TabIndex = 143;
            // 
            // lbl_path
            // 
            this.lbl_path.BackColor = System.Drawing.Color.White;
            this.lbl_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_path.Location = new System.Drawing.Point(31, 107);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Padding = new System.Windows.Forms.Padding(0, 0, 10, 1);
            this.lbl_path.Size = new System.Drawing.Size(90, 29);
            this.lbl_path.TabIndex = 142;
            this.lbl_path.Text = "Path";
            this.lbl_path.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FMenuCreater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.lbl_path);
            this.Controls.Add(this.btn_addMain);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_table);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.lbl_table);
            this.Controls.Add(this.txt_result);
            this.Name = "FMenuCreater";
            this.Size = new System.Drawing.Size(1080, 646);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_result;
        private System.Windows.Forms.Label lbl_table;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_header;
        private CXLIB.LookupBox txt_table;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radio_list;
        private System.Windows.Forms.RadioButton radio_form;
        private System.Windows.Forms.RadioButton radio_none;
        private System.Windows.Forms.Button btn_addMain;
        private CXLIB.LookupBox txt_path;
        private System.Windows.Forms.Label lbl_path;
    }
}
