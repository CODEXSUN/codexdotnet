// Version : 1 dt : 11-07-2017
// Auto Generated
// 13-07-2017 10:30:25 PM
// last update : 13-07-2017

namespace AXCODE 
{ 
    public partial class LServers
    { 
        private System.ComponentModel.IContainer components = null; 
         protected override void Dispose(bool disposing) 
         { 
             if (disposing && (components != null)) 
             { 
                 components.Dispose(); 
             } 
             base.Dispose(disposing); 
         } 
  
         #region[Component Designer generated code] 
  
         private void InitializeComponent() 
         { 
             System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle(); 
             System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle(); 
             System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle(); 
             this.panel = new CXLIB.XShadowPanel(); 
             this.Inner_panel = new System.Windows.Forms.Panel(); 
             this.chk_notactive = new CXLIB.MCheckBox(); 
             this.txt_servers_name = new CXLIB.LookupBox(); 
             this.lbl_servers_name = new CXLIB.XLabel(); 
             this.btn_close = new CXLIB.CloseButton(); 
             this.header = new CXLIB.Header(); 
             this.btn_print = new CXLIB.OfficeButton(); 
             this.btn_delete = new CXLIB.OfficeButton(); 
             this.btn_edit = new CXLIB.OfficeButton(); 
             this.btn_new = new CXLIB.OfficeButton(); 
             this.listgrid = new CXLIB.ListGridView(); 
             this.panel.SuspendLayout(); 
             this.Inner_panel.SuspendLayout(); 
             ((System.ComponentModel.ISupportInitialize)(this.listgrid)).BeginInit(); 
             this.SuspendLayout(); 
             //  
             // panel 
             //  
             this.panel.BorderColor = System.Drawing.Color.Empty; 
             this.panel.Controls.Add(this.Inner_panel); 
             this.panel.Dock = System.Windows.Forms.DockStyle.Fill; 
             this.panel.Location = new System.Drawing.Point(0, 0); 
             this.panel.Name = "panel"; 
             this.panel.PanelColor = System.Drawing.Color.Empty; 
             this.panel.Size = new System.Drawing.Size(1000, 600); 
             this.panel.TabIndex = 2; 
             //  
             // Inner_panel 
             //  
             this.Inner_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)  
             | System.Windows.Forms.AnchorStyles.Left)  
             | System.Windows.Forms.AnchorStyles.Right))); 
             this.Inner_panel.BackColor = System.Drawing.Color.White; 
             this.Inner_panel.Controls.Add(this.chk_notactive); 
             this.Inner_panel.Controls.Add(this.txt_servers_name); 
             this.Inner_panel.Controls.Add(this.lbl_servers_name); 
             this.Inner_panel.Controls.Add(this.btn_close); 
             this.Inner_panel.Controls.Add(this.header); 
             this.Inner_panel.Controls.Add(this.btn_print); 
             this.Inner_panel.Controls.Add(this.btn_delete); 
             this.Inner_panel.Controls.Add(this.btn_edit); 
             this.Inner_panel.Controls.Add(this.btn_new); 
             this.Inner_panel.Controls.Add(this.listgrid); 
             this.Inner_panel.Location = new System.Drawing.Point(6, 0); 
             this.Inner_panel.Name = "Inner_panel"; 
             this.Inner_panel.Size = new System.Drawing.Size(988, 594); 
             this.Inner_panel.TabIndex = 0; 
             //  
             // chk_notactive 
             //  
             this.chk_notactive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right))); 
             this.chk_notactive.AutoSize = true; 
             this.chk_notactive.Depth = 0; 
             this.chk_notactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F); 
             this.chk_notactive.Location = new System.Drawing.Point(833, 146); 
             this.chk_notactive.Margin = new System.Windows.Forms.Padding(0); 
             this.chk_notactive.MouseLocation = new System.Drawing.Point(-1, -1); 
             this.chk_notactive.MouseState = CXLIB.MouseState.HOVER; 
             this.chk_notactive.Name = "chk_notactive"; 
             this.chk_notactive.Ripple = true; 
             this.chk_notactive.Size = new System.Drawing.Size(92, 30); 
             this.chk_notactive.TabIndex = 4; 
             this.chk_notactive.Text = "Not Active"; 
             this.chk_notactive.UseVisualStyleBackColor = true; 
             this.chk_notactive.CheckedChanged += new System.EventHandler(this.Chk_notactive_CheckedChanged); 
             //  
             // txt_servers_name 
             //  
             this.txt_servers_name.AllowNewEntry = false; 
             this.txt_servers_name.BackColor = System.Drawing.Color.White; 
             this.txt_servers_name.EmptyBackColor = System.Drawing.Color.White; 
             this.txt_servers_name.EmptyForeColor = System.Drawing.Color.Black; 
             this.txt_servers_name.FilledBackColor = System.Drawing.Color.White; 
             this.txt_servers_name.FilledForeColor = System.Drawing.Color.White; 
             this.txt_servers_name.FocusBackColor = System.Drawing.Color.LightGreen; 
             this.txt_servers_name.FocusForeColor = System.Drawing.Color.Black; 
             this.txt_servers_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); 
             this.txt_servers_name.ForeColor = System.Drawing.Color.Black; 
             this.txt_servers_name.Location = new System.Drawing.Point(92, 51); 
             this.txt_servers_name.LookupButtonVisible = true; 
             this.txt_servers_name.LookupList = null; 
             this.txt_servers_name.Name = "txt_servers_name"; 
             this.txt_servers_name.ReadOnlyBackColor = System.Drawing.Color.White; 
             this.txt_servers_name.ReadOnlyForeColor = System.Drawing.Color.Black; 
             this.txt_servers_name.SelectedEntity = null; 
             this.txt_servers_name.Size = new System.Drawing.Size(500, 24); 
             this.txt_servers_name.TabIndex = 5; 
             this.txt_servers_name.TextChanged += new System.EventHandler(this.Txt_servers_name_TextChanged); 
             //  
             // lbl_servers_name 
             //  
             this.lbl_servers_name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190))))); 
             this.lbl_servers_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; 
             this.lbl_servers_name.FocusColor = System.Drawing.Color.Red; 
             this.lbl_servers_name.Location = new System.Drawing.Point(18, 51); 
             this.lbl_servers_name.Name = "lbl_servers_name"; 
             this.lbl_servers_name.Size = new System.Drawing.Size(75, 24); 
             this.lbl_servers_name.TabIndex = 19; 
             this.lbl_servers_name.Text = "Servers"; 
             this.lbl_servers_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; 
             //  
             // btn_close 
             //  
             this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right))); 
             this.btn_close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink; 
             this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(168))))); 
             this.btn_close.Cursor = System.Windows.Forms.Cursors.Default; 
             this.btn_close.FlatAppearance.BorderSize = 0; 
             this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed; 
             this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson; 
             this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat; 
             this.btn_close.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); 
             this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(255))))); 
             this.btn_close.Location = new System.Drawing.Point(957, 4); 
             this.btn_close.Margin = new System.Windows.Forms.Padding(0); 
             this.btn_close.Name = "btn_close"; 
             this.btn_close.Size = new System.Drawing.Size(25, 25); 
             this.btn_close.TabIndex = 7; 
             this.btn_close.Text = "X"; 
             this.btn_close.UseVisualStyleBackColor = false; 
             this.btn_close.Click += new System.EventHandler(this.Btn_close_Click); 
             //  
             // header 
             //  
             this.header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)  
             | System.Windows.Forms.AnchorStyles.Right))); 
             this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198))))); 
             this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); 
             this.header.ForeColor = System.Drawing.Color.White; 
             this.header.Location = new System.Drawing.Point(-1, 0); 
             this.header.Name = "header"; 
             this.header.Size = new System.Drawing.Size(1000, 35); 
             this.header.TabIndex = 16; 
             this.header.Text = "Servers"; 
             this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; 
             //  
             // btn_print 
             //  
             this.btn_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right))); 
             this.btn_print.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink; 
             this.btn_print.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); 
             this.btn_print.Location = new System.Drawing.Point(833, 343); 
             this.btn_print.Name = "btn_print"; 
             this.btn_print.Size = new System.Drawing.Size(131, 39); 
             this.btn_print.TabIndex = 3; 
             this.btn_print.Text = "&PRINT"; 
             this.btn_print.Themes = CXLIB.Themescheme.BLUE; 
             this.btn_print.UseVisualStyleBackColor = true; 
             this.btn_print.Click += new System.EventHandler(this.Btn_print_Click); 
             //  
             // btn_delete 
             //  
             this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right))); 
             this.btn_delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink; 
             this.btn_delete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); 
             this.btn_delete.Location = new System.Drawing.Point(833, 294); 
             this.btn_delete.Name = "btn_delete"; 
             this.btn_delete.Size = new System.Drawing.Size(131, 39); 
             this.btn_delete.TabIndex = 2; 
             this.btn_delete.Text = "&DELETE"; 
             this.btn_delete.Themes = CXLIB.Themescheme.BLUE; 
             this.btn_delete.UseVisualStyleBackColor = true; 
             this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click); 
             //  
             // btn_edit 
             //  
             this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right))); 
             this.btn_edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink; 
             this.btn_edit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); 
             this.btn_edit.Location = new System.Drawing.Point(833, 245); 
             this.btn_edit.Name = "btn_edit"; 
             this.btn_edit.Size = new System.Drawing.Size(131, 39); 
             this.btn_edit.TabIndex = 1; 
             this.btn_edit.Text = "&EDIT"; 
             this.btn_edit.Themes = CXLIB.Themescheme.BLUE; 
             this.btn_edit.UseVisualStyleBackColor = true; 
             this.btn_edit.Click += new System.EventHandler(this.Btn_edit_Click); 
             //  
             // btn_new 
             //  
             this.btn_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right))); 
             this.btn_new.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink; 
             this.btn_new.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); 
             this.btn_new.Location = new System.Drawing.Point(833, 196); 
             this.btn_new.Name = "btn_new"; 
             this.btn_new.Size = new System.Drawing.Size(131, 39); 
             this.btn_new.TabIndex = 0; 
             this.btn_new.Text = "&New"; 
             this.btn_new.Themes = CXLIB.Themescheme.BLUE; 
             this.btn_new.UseVisualStyleBackColor = true; 
             this.btn_new.Click += new System.EventHandler(this.Btn_new_Click); 
             //  
             // listgrid 
             //  
             this.listgrid.AllowUserToAddRows = false; 
             this.listgrid.AllowUserToDeleteRows = false; 
             this.listgrid.AllowUserToOrderColumns = true; 
             this.listgrid.AllowUserToResizeRows = false; 
             dataGridViewCellStyle1.BackColor = System.Drawing.Color.White; 
             dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); 
             dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black; 
             dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204))))); 
             dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(0)))), ((int)(((byte)(11))))); 
             dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True; 
             this.listgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1; 
             this.listgrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)  
             | System.Windows.Forms.AnchorStyles.Left)  
             | System.Windows.Forms.AnchorStyles.Right))); 
             this.listgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill; 
             this.listgrid.BackgroundColor = System.Drawing.Color.White; 
             this.listgrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D; 
             this.listgrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Custom; 
             this.listgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Custom; 
             dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter; 
             dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(192)))), ((int)(((byte)(96))))); 
             dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); 
             dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White; 
             dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3); 
             dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight; 
             dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText; 
             dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True; 
             this.listgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2; 
             this.listgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize; 
             this.listgrid.Cursor = System.Windows.Forms.Cursors.Default; 
             dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft; 
             dataGridViewCellStyle3.BackColor = System.Drawing.Color.White; 
             dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); 
             dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black; 
             dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204))))); 
             dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(0)))), ((int)(((byte)(11))))); 
             dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False; 
             this.listgrid.DefaultCellStyle = dataGridViewCellStyle3; 
             this.listgrid.EnableHeadersVisualStyles = false; 
             this.listgrid.GridColor = System.Drawing.Color.SeaGreen; 
             this.listgrid.Location = new System.Drawing.Point(5, 83); 
             this.listgrid.MultiSelect = false; 
             this.listgrid.Name = "listgrid"; 
             this.listgrid.ReadOnly = true; 
             this.listgrid.RowHeadersVisible = false; 
             this.listgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect; 
             this.listgrid.Size = new System.Drawing.Size(802, 508); 
             this.listgrid.StandardTab = true; 
             this.listgrid.TabIndex = 0; 
             //  
             // LServers 
             //  
             this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); 
             this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; 
             this.Controls.Add(this.panel); 
             this.Name = "LServers"; 
             this.Size = new System.Drawing.Size(1000, 600); 
             this.panel.ResumeLayout(false); 
             this.Inner_panel.ResumeLayout(false); 
             this.Inner_panel.PerformLayout(); 
             ((System.ComponentModel.ISupportInitialize)(this.listgrid)).EndInit(); 
             this.ResumeLayout(false); 
  
         } 
  
         #endregion[Component Designer generated code] 
  
         private CXLIB.XShadowPanel panel; 
         private System.Windows.Forms.Panel Inner_panel; 
         private CXLIB.MCheckBox chk_notactive; 
         private CXLIB.LookupBox txt_servers_name; 
         private CXLIB.XLabel lbl_servers_name; 
         private CXLIB.CloseButton btn_close; 
         private CXLIB.Header header; 
         private CXLIB.OfficeButton btn_print; 
         private CXLIB.OfficeButton btn_delete; 
         private CXLIB.OfficeButton btn_edit; 
         private CXLIB.OfficeButton btn_new; 
         private CXLIB.ListGridView listgrid; 
     }//cls 
}//ns 
