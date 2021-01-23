// Version : 7.4 dt : 08-01-2017
// CODESK
// 24-01-2017 08:01:01 AM
// create date : 24-01-2017
// last update : 24-01-2017
using CXLIB;

namespace CXBILL
        { 
        partial class RGSTRegister
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


        private void InitializeComponent() 
     //   private void Initialize()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel = new CXLIB.XShadowPanel();
            this.Inner_panel = new System.Windows.Forms.Panel();
            this.btn_print_purchase = new CXLIB.OfficeButton();
            this.xLabel9 = new CXLIB.XLabel();
            this.xLabel8 = new CXLIB.XLabel();
            this.xLabel7 = new CXLIB.XLabel();
            this.txt_difference = new CXLIB.XTextBox();
            this.xLabel6 = new CXLIB.XLabel();
            this.officeButton1 = new CXLIB.OfficeButton();
            this.txt_Sales_gst_total = new CXLIB.XTextBox();
            this.txt_sales_total = new CXLIB.XTextBox();
            this.xLabel5 = new CXLIB.XLabel();
            this.xLabel4 = new CXLIB.XLabel();
            this.Listgrid_1 = new CXLIB.ListGridView();
            this.btn_search = new CXLIB.OfficeButton();
            this.txt_gst_difference = new CXLIB.XTextBox();
            this.txt_purchase_gst_total = new CXLIB.XTextBox();
            this.txt_purchase_total = new CXLIB.XTextBox();
            this.txt_to_date = new CXLIB.XTextBox();
            this.txt_from_date = new CXLIB.XTextBox();
            this.xLabel3 = new CXLIB.XLabel();
            this.xLabel2 = new CXLIB.XLabel();
            this.to_Datepicker = new CXLIB.xDatepicker();
            this.from_Datepicker = new CXLIB.xDatepicker();
            this.xLabel1 = new CXLIB.XLabel();
            this.btn_close = new CXLIB.CloseButton();
            this.Txt_month = new CXLIB.LookupBox();
            this.header = new CXLIB.Header();
            this.btn_print_sales = new CXLIB.OfficeButton();
            this.Listgrid = new CXLIB.ListGridView();
            this.Panel.SuspendLayout();
            this.Inner_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Listgrid_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Listgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BorderColor = System.Drawing.Color.Empty;
            this.Panel.Controls.Add(this.Inner_panel);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.PanelColor = System.Drawing.Color.Empty;
            this.Panel.Size = new System.Drawing.Size(1331, 667);
            this.Panel.TabIndex = 1;
            // 
            // Inner_panel
            // 
            this.Inner_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Inner_panel.BackColor = System.Drawing.Color.White;
            this.Inner_panel.Controls.Add(this.btn_print_purchase);
            this.Inner_panel.Controls.Add(this.xLabel9);
            this.Inner_panel.Controls.Add(this.xLabel8);
            this.Inner_panel.Controls.Add(this.xLabel7);
            this.Inner_panel.Controls.Add(this.txt_difference);
            this.Inner_panel.Controls.Add(this.xLabel6);
            this.Inner_panel.Controls.Add(this.officeButton1);
            this.Inner_panel.Controls.Add(this.txt_Sales_gst_total);
            this.Inner_panel.Controls.Add(this.txt_sales_total);
            this.Inner_panel.Controls.Add(this.xLabel5);
            this.Inner_panel.Controls.Add(this.xLabel4);
            this.Inner_panel.Controls.Add(this.Listgrid_1);
            this.Inner_panel.Controls.Add(this.btn_search);
            this.Inner_panel.Controls.Add(this.txt_gst_difference);
            this.Inner_panel.Controls.Add(this.txt_purchase_gst_total);
            this.Inner_panel.Controls.Add(this.txt_purchase_total);
            this.Inner_panel.Controls.Add(this.txt_to_date);
            this.Inner_panel.Controls.Add(this.txt_from_date);
            this.Inner_panel.Controls.Add(this.xLabel3);
            this.Inner_panel.Controls.Add(this.xLabel2);
            this.Inner_panel.Controls.Add(this.to_Datepicker);
            this.Inner_panel.Controls.Add(this.from_Datepicker);
            this.Inner_panel.Controls.Add(this.xLabel1);
            this.Inner_panel.Controls.Add(this.btn_close);
            this.Inner_panel.Controls.Add(this.Txt_month);
            this.Inner_panel.Controls.Add(this.header);
            this.Inner_panel.Controls.Add(this.btn_print_sales);
            this.Inner_panel.Controls.Add(this.Listgrid);
            this.Inner_panel.Location = new System.Drawing.Point(6, 0);
            this.Inner_panel.Name = "Inner_panel";
            this.Inner_panel.Size = new System.Drawing.Size(1319, 661);
            this.Inner_panel.TabIndex = 0;
            // 
            // btn_print_purchase
            // 
            this.btn_print_purchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_print_purchase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_print_purchase.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print_purchase.Location = new System.Drawing.Point(1182, 50);
            this.btn_print_purchase.Name = "btn_print_purchase";
            this.btn_print_purchase.Size = new System.Drawing.Size(112, 39);
            this.btn_print_purchase.TabIndex = 42;
            this.btn_print_purchase.Text = "&PRINT PURCHASE";
            this.btn_print_purchase.Themes = CXLIB.Themescheme.Yellow;
            this.btn_print_purchase.UseVisualStyleBackColor = true;
            this.btn_print_purchase.Click += new System.EventHandler(this.Btn_print_purchase_Click);
            // 
            // xLabel9
            // 
            this.xLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.xLabel9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.xLabel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xLabel9.FocusColor = System.Drawing.Color.Red;
            this.xLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel9.Location = new System.Drawing.Point(705, 552);
            this.xLabel9.Name = "xLabel9";
            this.xLabel9.Size = new System.Drawing.Size(186, 29);
            this.xLabel9.TabIndex = 41;
            this.xLabel9.Text = "Total";
            this.xLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xLabel8
            // 
            this.xLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.xLabel8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.xLabel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xLabel8.FocusColor = System.Drawing.Color.Red;
            this.xLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel8.Location = new System.Drawing.Point(5, 552);
            this.xLabel8.Name = "xLabel8";
            this.xLabel8.Size = new System.Drawing.Size(186, 29);
            this.xLabel8.TabIndex = 40;
            this.xLabel8.Text = "Total";
            this.xLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xLabel7
            // 
            this.xLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.xLabel7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.xLabel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xLabel7.FocusColor = System.Drawing.Color.Red;
            this.xLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel7.Location = new System.Drawing.Point(175, 627);
            this.xLabel7.Name = "xLabel7";
            this.xLabel7.Size = new System.Drawing.Size(246, 29);
            this.xLabel7.TabIndex = 39;
            this.xLabel7.Text = "Diff (Sales - Purchase)";
            this.xLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_difference
            // 
            this.txt_difference.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_difference.BackColor = System.Drawing.Color.White;
            this.txt_difference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_difference.EmptyBackColor = System.Drawing.Color.White;
            this.txt_difference.EmptyForeColor = System.Drawing.Color.Black;
            this.txt_difference.EnableLookup = true;
            this.txt_difference.EnableNavigationKeys = true;
            this.txt_difference.FilledBackColor = System.Drawing.Color.White;
            this.txt_difference.FilledForeColor = System.Drawing.Color.Black;
            this.txt_difference.FocusBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(185)))));
            this.txt_difference.FocusForeColor = System.Drawing.Color.Black;
            this.txt_difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_difference.ForeColor = System.Drawing.Color.Black;
            this.txt_difference.Location = new System.Drawing.Point(417, 627);
            this.txt_difference.Name = "txt_difference";
            this.txt_difference.ReadOnlyBackColor = System.Drawing.Color.White;
            this.txt_difference.ReadOnlyForeColor = System.Drawing.Color.Black;
            this.txt_difference.Size = new System.Drawing.Size(298, 29);
            this.txt_difference.TabIndex = 38;
            this.txt_difference.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // xLabel6
            // 
            this.xLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.xLabel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.xLabel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xLabel6.FocusColor = System.Drawing.Color.Red;
            this.xLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel6.Location = new System.Drawing.Point(744, 623);
            this.xLabel6.Name = "xLabel6";
            this.xLabel6.Size = new System.Drawing.Size(231, 29);
            this.xLabel6.TabIndex = 37;
            this.xLabel6.Text = "GST (Sale - Purchase)";
            this.xLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // officeButton1
            // 
            this.officeButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.officeButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.officeButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.officeButton1.Location = new System.Drawing.Point(59, 625);
            this.officeButton1.Name = "officeButton1";
            this.officeButton1.Size = new System.Drawing.Size(110, 29);
            this.officeButton1.TabIndex = 36;
            this.officeButton1.Text = "&ReTotal";
            this.officeButton1.Themes = CXLIB.Themescheme.Green;
            this.officeButton1.UseVisualStyleBackColor = true;
            this.officeButton1.Click += new System.EventHandler(this.Retotal_Click);
            // 
            // txt_Sales_gst_total
            // 
            this.txt_Sales_gst_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Sales_gst_total.BackColor = System.Drawing.Color.White;
            this.txt_Sales_gst_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Sales_gst_total.EmptyBackColor = System.Drawing.Color.White;
            this.txt_Sales_gst_total.EmptyForeColor = System.Drawing.Color.Black;
            this.txt_Sales_gst_total.EnableLookup = true;
            this.txt_Sales_gst_total.EnableNavigationKeys = true;
            this.txt_Sales_gst_total.FilledBackColor = System.Drawing.Color.White;
            this.txt_Sales_gst_total.FilledForeColor = System.Drawing.Color.Black;
            this.txt_Sales_gst_total.FocusBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(185)))));
            this.txt_Sales_gst_total.FocusForeColor = System.Drawing.Color.Black;
            this.txt_Sales_gst_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sales_gst_total.ForeColor = System.Drawing.Color.Black;
            this.txt_Sales_gst_total.Location = new System.Drawing.Point(400, 552);
            this.txt_Sales_gst_total.Name = "txt_Sales_gst_total";
            this.txt_Sales_gst_total.ReadOnlyBackColor = System.Drawing.Color.White;
            this.txt_Sales_gst_total.ReadOnlyForeColor = System.Drawing.Color.Black;
            this.txt_Sales_gst_total.Size = new System.Drawing.Size(192, 29);
            this.txt_Sales_gst_total.TabIndex = 35;
            this.txt_Sales_gst_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_sales_total
            // 
            this.txt_sales_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sales_total.BackColor = System.Drawing.Color.White;
            this.txt_sales_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sales_total.EmptyBackColor = System.Drawing.Color.White;
            this.txt_sales_total.EmptyForeColor = System.Drawing.Color.Black;
            this.txt_sales_total.EnableLookup = true;
            this.txt_sales_total.EnableNavigationKeys = true;
            this.txt_sales_total.FilledBackColor = System.Drawing.Color.White;
            this.txt_sales_total.FilledForeColor = System.Drawing.Color.Black;
            this.txt_sales_total.FocusBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(185)))));
            this.txt_sales_total.FocusForeColor = System.Drawing.Color.Black;
            this.txt_sales_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sales_total.ForeColor = System.Drawing.Color.Black;
            this.txt_sales_total.Location = new System.Drawing.Point(197, 552);
            this.txt_sales_total.Name = "txt_sales_total";
            this.txt_sales_total.ReadOnlyBackColor = System.Drawing.Color.White;
            this.txt_sales_total.ReadOnlyForeColor = System.Drawing.Color.Black;
            this.txt_sales_total.Size = new System.Drawing.Size(192, 29);
            this.txt_sales_total.TabIndex = 34;
            this.txt_sales_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // xLabel5
            // 
            this.xLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xLabel5.BackColor = System.Drawing.Color.Orange;
            this.xLabel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.xLabel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xLabel5.FocusColor = System.Drawing.Color.Red;
            this.xLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel5.Location = new System.Drawing.Point(705, 102);
            this.xLabel5.Name = "xLabel5";
            this.xLabel5.Size = new System.Drawing.Size(589, 26);
            this.xLabel5.TabIndex = 33;
            this.xLabel5.Text = "PURCHASE";
            this.xLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xLabel4
            // 
            this.xLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xLabel4.BackColor = System.Drawing.Color.LimeGreen;
            this.xLabel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.xLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xLabel4.FocusColor = System.Drawing.Color.Red;
            this.xLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel4.Location = new System.Drawing.Point(5, 102);
            this.xLabel4.Name = "xLabel4";
            this.xLabel4.Size = new System.Drawing.Size(587, 26);
            this.xLabel4.TabIndex = 32;
            this.xLabel4.Text = "SALES";
            this.xLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Listgrid_1
            // 
            this.Listgrid_1.AllowUserToAddRows = false;
            this.Listgrid_1.AllowUserToDeleteRows = false;
            this.Listgrid_1.AllowUserToOrderColumns = true;
            this.Listgrid_1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Listgrid_1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Listgrid_1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Listgrid_1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Listgrid_1.BackgroundColor = System.Drawing.Color.White;
            this.Listgrid_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Listgrid_1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Custom;
            this.Listgrid_1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(192)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Listgrid_1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Listgrid_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Listgrid_1.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Listgrid_1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Listgrid_1.EnableHeadersVisualStyles = false;
            this.Listgrid_1.GridColor = System.Drawing.Color.SeaGreen;
            this.Listgrid_1.Location = new System.Drawing.Point(705, 131);
            this.Listgrid_1.MultiSelect = false;
            this.Listgrid_1.Name = "Listgrid_1";
            this.Listgrid_1.ReadOnly = true;
            this.Listgrid_1.RowHeadersVisible = false;
            this.Listgrid_1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Listgrid_1.Size = new System.Drawing.Size(589, 413);
            this.Listgrid_1.StandardTab = true;
            this.Listgrid_1.TabIndex = 31;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_search.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(910, 50);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(116, 39);
            this.btn_search.TabIndex = 30;
            this.btn_search.Text = "&Search";
            this.btn_search.Themes = CXLIB.Themescheme.Steelblue;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // txt_gst_difference
            // 
            this.txt_gst_difference.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_gst_difference.BackColor = System.Drawing.Color.White;
            this.txt_gst_difference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_gst_difference.EmptyBackColor = System.Drawing.Color.White;
            this.txt_gst_difference.EmptyForeColor = System.Drawing.Color.Black;
            this.txt_gst_difference.EnableLookup = true;
            this.txt_gst_difference.EnableNavigationKeys = true;
            this.txt_gst_difference.FilledBackColor = System.Drawing.Color.White;
            this.txt_gst_difference.FilledForeColor = System.Drawing.Color.Black;
            this.txt_gst_difference.FocusBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(185)))));
            this.txt_gst_difference.FocusForeColor = System.Drawing.Color.Black;
            this.txt_gst_difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gst_difference.ForeColor = System.Drawing.Color.Black;
            this.txt_gst_difference.Location = new System.Drawing.Point(971, 623);
            this.txt_gst_difference.Name = "txt_gst_difference";
            this.txt_gst_difference.ReadOnlyBackColor = System.Drawing.Color.White;
            this.txt_gst_difference.ReadOnlyForeColor = System.Drawing.Color.Black;
            this.txt_gst_difference.Size = new System.Drawing.Size(282, 29);
            this.txt_gst_difference.TabIndex = 27;
            this.txt_gst_difference.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_purchase_gst_total
            // 
            this.txt_purchase_gst_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_purchase_gst_total.BackColor = System.Drawing.Color.White;
            this.txt_purchase_gst_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_purchase_gst_total.EmptyBackColor = System.Drawing.Color.White;
            this.txt_purchase_gst_total.EmptyForeColor = System.Drawing.Color.Black;
            this.txt_purchase_gst_total.EnableLookup = true;
            this.txt_purchase_gst_total.EnableNavigationKeys = true;
            this.txt_purchase_gst_total.FilledBackColor = System.Drawing.Color.White;
            this.txt_purchase_gst_total.FilledForeColor = System.Drawing.Color.Black;
            this.txt_purchase_gst_total.FocusBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(185)))));
            this.txt_purchase_gst_total.FocusForeColor = System.Drawing.Color.Black;
            this.txt_purchase_gst_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_purchase_gst_total.ForeColor = System.Drawing.Color.Black;
            this.txt_purchase_gst_total.Location = new System.Drawing.Point(1102, 552);
            this.txt_purchase_gst_total.Name = "txt_purchase_gst_total";
            this.txt_purchase_gst_total.ReadOnlyBackColor = System.Drawing.Color.White;
            this.txt_purchase_gst_total.ReadOnlyForeColor = System.Drawing.Color.Black;
            this.txt_purchase_gst_total.Size = new System.Drawing.Size(192, 29);
            this.txt_purchase_gst_total.TabIndex = 26;
            this.txt_purchase_gst_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_purchase_total
            // 
            this.txt_purchase_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_purchase_total.BackColor = System.Drawing.Color.White;
            this.txt_purchase_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_purchase_total.EmptyBackColor = System.Drawing.Color.White;
            this.txt_purchase_total.EmptyForeColor = System.Drawing.Color.Black;
            this.txt_purchase_total.EnableLookup = true;
            this.txt_purchase_total.EnableNavigationKeys = true;
            this.txt_purchase_total.FilledBackColor = System.Drawing.Color.White;
            this.txt_purchase_total.FilledForeColor = System.Drawing.Color.Black;
            this.txt_purchase_total.FocusBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(185)))));
            this.txt_purchase_total.FocusForeColor = System.Drawing.Color.Black;
            this.txt_purchase_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_purchase_total.ForeColor = System.Drawing.Color.Black;
            this.txt_purchase_total.Location = new System.Drawing.Point(899, 552);
            this.txt_purchase_total.Name = "txt_purchase_total";
            this.txt_purchase_total.ReadOnlyBackColor = System.Drawing.Color.White;
            this.txt_purchase_total.ReadOnlyForeColor = System.Drawing.Color.Black;
            this.txt_purchase_total.Size = new System.Drawing.Size(192, 29);
            this.txt_purchase_total.TabIndex = 25;
            this.txt_purchase_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_to_date
            // 
            this.txt_to_date.BackColor = System.Drawing.Color.White;
            this.txt_to_date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_to_date.EmptyBackColor = System.Drawing.Color.White;
            this.txt_to_date.EmptyForeColor = System.Drawing.Color.Black;
            this.txt_to_date.EnableLookup = true;
            this.txt_to_date.EnableNavigationKeys = true;
            this.txt_to_date.FilledBackColor = System.Drawing.Color.White;
            this.txt_to_date.FilledForeColor = System.Drawing.Color.Black;
            this.txt_to_date.FocusBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(185)))));
            this.txt_to_date.FocusForeColor = System.Drawing.Color.Black;
            this.txt_to_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_to_date.ForeColor = System.Drawing.Color.Black;
            this.txt_to_date.Location = new System.Drawing.Point(700, 58);
            this.txt_to_date.Name = "txt_to_date";
            this.txt_to_date.ReadOnlyBackColor = System.Drawing.Color.White;
            this.txt_to_date.ReadOnlyForeColor = System.Drawing.Color.Black;
            this.txt_to_date.Size = new System.Drawing.Size(162, 22);
            this.txt_to_date.TabIndex = 24;
            // 
            // txt_from_date
            // 
            this.txt_from_date.BackColor = System.Drawing.Color.White;
            this.txt_from_date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_from_date.EmptyBackColor = System.Drawing.Color.White;
            this.txt_from_date.EmptyForeColor = System.Drawing.Color.Black;
            this.txt_from_date.EnableLookup = true;
            this.txt_from_date.EnableNavigationKeys = true;
            this.txt_from_date.FilledBackColor = System.Drawing.Color.White;
            this.txt_from_date.FilledForeColor = System.Drawing.Color.Black;
            this.txt_from_date.FocusBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(185)))));
            this.txt_from_date.FocusForeColor = System.Drawing.Color.Black;
            this.txt_from_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_from_date.ForeColor = System.Drawing.Color.Black;
            this.txt_from_date.Location = new System.Drawing.Point(443, 58);
            this.txt_from_date.Name = "txt_from_date";
            this.txt_from_date.ReadOnlyBackColor = System.Drawing.Color.White;
            this.txt_from_date.ReadOnlyForeColor = System.Drawing.Color.Black;
            this.txt_from_date.Size = new System.Drawing.Size(162, 22);
            this.txt_from_date.TabIndex = 23;
            // 
            // xLabel3
            // 
            this.xLabel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.xLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xLabel3.FocusColor = System.Drawing.Color.Red;
            this.xLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel3.Location = new System.Drawing.Point(645, 55);
            this.xLabel3.Name = "xLabel3";
            this.xLabel3.Size = new System.Drawing.Size(53, 28);
            this.xLabel3.TabIndex = 22;
            this.xLabel3.Text = "To";
            this.xLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xLabel2
            // 
            this.xLabel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.xLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xLabel2.FocusColor = System.Drawing.Color.Red;
            this.xLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel2.Location = new System.Drawing.Point(330, 55);
            this.xLabel2.Name = "xLabel2";
            this.xLabel2.Size = new System.Drawing.Size(110, 28);
            this.xLabel2.TabIndex = 21;
            this.xLabel2.Text = "From";
            this.xLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // to_Datepicker
            // 
            this.to_Datepicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_Datepicker.CustomFormat = "  dd-MM-yyy";
            this.to_Datepicker.EnableNavigationKeys = true;
            this.to_Datepicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_Datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.to_Datepicker.Location = new System.Drawing.Point(693, 55);
            this.to_Datepicker.Name = "to_Datepicker";
            this.to_Datepicker.Size = new System.Drawing.Size(200, 28);
            this.to_Datepicker.TabIndex = 20;
            this.to_Datepicker.ValueChanged += new System.EventHandler(this.To_Datepicker_ValueChanged);
            // 
            // from_Datepicker
            // 
            this.from_Datepicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_Datepicker.CustomFormat = "  dd-MM-yyy";
            this.from_Datepicker.EnableNavigationKeys = true;
            this.from_Datepicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_Datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.from_Datepicker.Location = new System.Drawing.Point(439, 55);
            this.from_Datepicker.Name = "from_Datepicker";
            this.from_Datepicker.Size = new System.Drawing.Size(200, 28);
            this.from_Datepicker.TabIndex = 19;
            this.from_Datepicker.ValueChanged += new System.EventHandler(this.From_Datepicker_ValueChanged);
            // 
            // xLabel1
            // 
            this.xLabel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.xLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xLabel1.FocusColor = System.Drawing.Color.Red;
            this.xLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel1.Location = new System.Drawing.Point(14, 56);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(78, 26);
            this.xLabel1.TabIndex = 18;
            this.xLabel1.Text = "MONTH";
            this.xLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_close.Location = new System.Drawing.Point(1288, 4);
            this.btn_close.Margin = new System.Windows.Forms.Padding(0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(25, 25);
            this.btn_close.TabIndex = 17;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // Txt_month
            // 
            this.Txt_month.AllowNewEntry = false;
            this.Txt_month.BackColor = System.Drawing.Color.White;
            this.Txt_month.EmptyBackColor = System.Drawing.Color.White;
            this.Txt_month.EmptyForeColor = System.Drawing.Color.Black;
            this.Txt_month.FilledBackColor = System.Drawing.Color.White;
            this.Txt_month.FilledForeColor = System.Drawing.Color.White;
            this.Txt_month.FocusBackColor = System.Drawing.Color.LightGreen;
            this.Txt_month.FocusForeColor = System.Drawing.Color.Black;
            this.Txt_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_month.ForeColor = System.Drawing.Color.Black;
            this.Txt_month.Location = new System.Drawing.Point(92, 56);
            this.Txt_month.LookupButtonVisible = true;
            this.Txt_month.LookupList = null;
            this.Txt_month.Name = "Txt_month";
            this.Txt_month.ReadOnlyBackColor = System.Drawing.Color.White;
            this.Txt_month.ReadOnlyForeColor = System.Drawing.Color.Black;
            this.Txt_month.SelectedEntity = null;
            this.Txt_month.Size = new System.Drawing.Size(216, 26);
            this.Txt_month.TabIndex = 6;
            this.Txt_month.TextChanged += new System.EventHandler(this.Search_party_TextChanged);
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
            this.header.Size = new System.Drawing.Size(1331, 35);
            this.header.TabIndex = 16;
            this.header.Text = "GST REPORT";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_print_sales
            // 
            this.btn_print_sales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_print_sales.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_print_sales.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print_sales.Location = new System.Drawing.Point(1047, 50);
            this.btn_print_sales.Name = "btn_print_sales";
            this.btn_print_sales.Size = new System.Drawing.Size(115, 39);
            this.btn_print_sales.TabIndex = 9;
            this.btn_print_sales.Text = "&PRINT SALES";
            this.btn_print_sales.Themes = CXLIB.Themescheme.Green;
            this.btn_print_sales.UseVisualStyleBackColor = true;
            this.btn_print_sales.Click += new System.EventHandler(this.Btn_print_sales_Click);
            // 
            // Listgrid
            // 
            this.Listgrid.AllowUserToAddRows = false;
            this.Listgrid.AllowUserToDeleteRows = false;
            this.Listgrid.AllowUserToOrderColumns = true;
            this.Listgrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Listgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Listgrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Listgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Listgrid.BackgroundColor = System.Drawing.Color.White;
            this.Listgrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Listgrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Custom;
            this.Listgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(192)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Listgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Listgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Listgrid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Listgrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.Listgrid.EnableHeadersVisualStyles = false;
            this.Listgrid.GridColor = System.Drawing.Color.SeaGreen;
            this.Listgrid.Location = new System.Drawing.Point(5, 130);
            this.Listgrid.MultiSelect = false;
            this.Listgrid.Name = "Listgrid";
            this.Listgrid.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Listgrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Listgrid.RowHeadersVisible = false;
            this.Listgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Listgrid.Size = new System.Drawing.Size(587, 414);
            this.Listgrid.StandardTab = true;
            this.Listgrid.TabIndex = 0;
            // 
            // RGSTRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel);
            this.Name = "RGSTRegister";
            this.Size = new System.Drawing.Size(1331, 667);
            this.Panel.ResumeLayout(false);
            this.Inner_panel.ResumeLayout(false);
            this.Inner_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Listgrid_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Listgrid)).EndInit();
            this.ResumeLayout(false);

        }

        private XShadowPanel Panel;
        private System.Windows.Forms.Panel Inner_panel;
        private ListGridView Listgrid;
        private OfficeButton btn_print_sales;
        private LookupBox Txt_month;
        private Header header;
        private CloseButton btn_close;
        private XLabel xLabel1;
        private XLabel xLabel3;
        private XLabel xLabel2;
        private xDatepicker to_Datepicker;
        private xDatepicker from_Datepicker;
        private XTextBox txt_to_date;
        private XTextBox txt_from_date;
        private XTextBox txt_gst_difference;
        private XTextBox txt_purchase_gst_total;
        private XTextBox txt_purchase_total;
        private OfficeButton btn_search;
        private XLabel xLabel5;
        private XLabel xLabel4;
        private ListGridView Listgrid_1;
        private XTextBox txt_Sales_gst_total;
        private XTextBox txt_sales_total;
        private XLabel xLabel7;
        private XTextBox txt_difference;
        private XLabel xLabel6;
        private OfficeButton officeButton1;
        private XLabel xLabel8;
        private OfficeButton btn_print_purchase;
        private XLabel xLabel9;
    }//cls 
}//ns 
