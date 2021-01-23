// Version : 7.4 dt : 08-01-2017
// CODESK
// 24-01-2017 08:01:01 AM
// create date : 24-01-2017
// last update : 24-01-2017
using CXLIB;

namespace CXBILL
{ 
        partial class ROffset_1_party
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
            this.Panel = new CXLIB.XShadowPanel();
            this.Inner_panel = new System.Windows.Forms.Panel();
            this.btn_search = new CXLIB.OfficeButton();
            this.txt_balance_total = new CXLIB.XTextBox();
            this.txt_receipt_total = new CXLIB.XTextBox();
            this.txt_invoice_total = new CXLIB.XTextBox();
            this.txt_to_date = new CXLIB.XTextBox();
            this.txt_from_date = new CXLIB.XTextBox();
            this.xLabel3 = new CXLIB.XLabel();
            this.xLabel2 = new CXLIB.XLabel();
            this.to_Datepicker = new CXLIB.xDatepicker();
            this.from_Datepicker = new CXLIB.xDatepicker();
            this.xLabel1 = new CXLIB.XLabel();
            this.btn_close = new CXLIB.CloseButton();
            this.Txt_party = new CXLIB.LookupBox();
            this.header = new CXLIB.Header();
            this.Btn_print = new CXLIB.OfficeButton();
            this.Listgrid = new CXLIB.ListGridView();
            this.Panel.SuspendLayout();
            this.Inner_panel.SuspendLayout();
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
            this.Panel.Size = new System.Drawing.Size(1302, 620);
            this.Panel.TabIndex = 1;
            // 
            // Inner_panel
            // 
            this.Inner_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Inner_panel.BackColor = System.Drawing.Color.White;
            this.Inner_panel.Controls.Add(this.btn_search);
            this.Inner_panel.Controls.Add(this.txt_balance_total);
            this.Inner_panel.Controls.Add(this.txt_receipt_total);
            this.Inner_panel.Controls.Add(this.txt_invoice_total);
            this.Inner_panel.Controls.Add(this.txt_to_date);
            this.Inner_panel.Controls.Add(this.txt_from_date);
            this.Inner_panel.Controls.Add(this.xLabel3);
            this.Inner_panel.Controls.Add(this.xLabel2);
            this.Inner_panel.Controls.Add(this.to_Datepicker);
            this.Inner_panel.Controls.Add(this.from_Datepicker);
            this.Inner_panel.Controls.Add(this.xLabel1);
            this.Inner_panel.Controls.Add(this.btn_close);
            this.Inner_panel.Controls.Add(this.Txt_party);
            this.Inner_panel.Controls.Add(this.header);
            this.Inner_panel.Controls.Add(this.Btn_print);
            this.Inner_panel.Controls.Add(this.Listgrid);
            this.Inner_panel.Location = new System.Drawing.Point(6, 0);
            this.Inner_panel.Name = "Inner_panel";
            this.Inner_panel.Size = new System.Drawing.Size(1290, 614);
            this.Inner_panel.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_search.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(1016, 50);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(131, 39);
            this.btn_search.TabIndex = 30;
            this.btn_search.Text = "&Search";
            this.btn_search.Themes = CXLIB.Themescheme.Green;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // txt_balance_total
            // 
            this.txt_balance_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_balance_total.BackColor = System.Drawing.Color.White;
            this.txt_balance_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_balance_total.EmptyBackColor = System.Drawing.Color.White;
            this.txt_balance_total.EmptyForeColor = System.Drawing.Color.Black;
            this.txt_balance_total.EnableLookup = true;
            this.txt_balance_total.EnableNavigationKeys = true;
            this.txt_balance_total.FilledBackColor = System.Drawing.Color.White;
            this.txt_balance_total.FilledForeColor = System.Drawing.Color.Black;
            this.txt_balance_total.FocusBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(185)))));
            this.txt_balance_total.FocusForeColor = System.Drawing.Color.Black;
            this.txt_balance_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_balance_total.ForeColor = System.Drawing.Color.Black;
            this.txt_balance_total.Location = new System.Drawing.Point(1060, 568);
            this.txt_balance_total.Name = "txt_balance_total";
            this.txt_balance_total.ReadOnlyBackColor = System.Drawing.Color.White;
            this.txt_balance_total.ReadOnlyForeColor = System.Drawing.Color.Black;
            this.txt_balance_total.Size = new System.Drawing.Size(192, 29);
            this.txt_balance_total.TabIndex = 27;
            this.txt_balance_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_receipt_total
            // 
            this.txt_receipt_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_receipt_total.BackColor = System.Drawing.Color.White;
            this.txt_receipt_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_receipt_total.EmptyBackColor = System.Drawing.Color.White;
            this.txt_receipt_total.EmptyForeColor = System.Drawing.Color.Black;
            this.txt_receipt_total.EnableLookup = true;
            this.txt_receipt_total.EnableNavigationKeys = true;
            this.txt_receipt_total.FilledBackColor = System.Drawing.Color.White;
            this.txt_receipt_total.FilledForeColor = System.Drawing.Color.Black;
            this.txt_receipt_total.FocusBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(185)))));
            this.txt_receipt_total.FocusForeColor = System.Drawing.Color.Black;
            this.txt_receipt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_receipt_total.ForeColor = System.Drawing.Color.Black;
            this.txt_receipt_total.Location = new System.Drawing.Point(857, 568);
            this.txt_receipt_total.Name = "txt_receipt_total";
            this.txt_receipt_total.ReadOnlyBackColor = System.Drawing.Color.White;
            this.txt_receipt_total.ReadOnlyForeColor = System.Drawing.Color.Black;
            this.txt_receipt_total.Size = new System.Drawing.Size(192, 29);
            this.txt_receipt_total.TabIndex = 26;
            this.txt_receipt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_invoice_total
            // 
            this.txt_invoice_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_invoice_total.BackColor = System.Drawing.Color.White;
            this.txt_invoice_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_invoice_total.EmptyBackColor = System.Drawing.Color.White;
            this.txt_invoice_total.EmptyForeColor = System.Drawing.Color.Black;
            this.txt_invoice_total.EnableLookup = true;
            this.txt_invoice_total.EnableNavigationKeys = true;
            this.txt_invoice_total.FilledBackColor = System.Drawing.Color.White;
            this.txt_invoice_total.FilledForeColor = System.Drawing.Color.Black;
            this.txt_invoice_total.FocusBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(185)))));
            this.txt_invoice_total.FocusForeColor = System.Drawing.Color.Black;
            this.txt_invoice_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_invoice_total.ForeColor = System.Drawing.Color.Black;
            this.txt_invoice_total.Location = new System.Drawing.Point(654, 568);
            this.txt_invoice_total.Name = "txt_invoice_total";
            this.txt_invoice_total.ReadOnlyBackColor = System.Drawing.Color.White;
            this.txt_invoice_total.ReadOnlyForeColor = System.Drawing.Color.Black;
            this.txt_invoice_total.Size = new System.Drawing.Size(192, 29);
            this.txt_invoice_total.TabIndex = 25;
            this.txt_invoice_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.txt_to_date.Location = new System.Drawing.Point(799, 58);
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
            this.txt_from_date.Location = new System.Drawing.Point(542, 58);
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
            this.xLabel3.Location = new System.Drawing.Point(744, 55);
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
            this.xLabel2.Location = new System.Drawing.Point(429, 55);
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
            this.to_Datepicker.Location = new System.Drawing.Point(792, 55);
            this.to_Datepicker.Name = "to_Datepicker";
            this.to_Datepicker.Size = new System.Drawing.Size(200, 28);
            this.to_Datepicker.TabIndex = 20;
            this.to_Datepicker.ValueChanged += new System.EventHandler(this.to_Datepicker_ValueChanged);
            // 
            // from_Datepicker
            // 
            this.from_Datepicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_Datepicker.CustomFormat = "  dd-MM-yyy";
            this.from_Datepicker.EnableNavigationKeys = true;
            this.from_Datepicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_Datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.from_Datepicker.Location = new System.Drawing.Point(538, 55);
            this.from_Datepicker.Name = "from_Datepicker";
            this.from_Datepicker.Size = new System.Drawing.Size(200, 28);
            this.from_Datepicker.TabIndex = 19;
            this.from_Datepicker.ValueChanged += new System.EventHandler(this.from_Datepicker_ValueChanged);
            // 
            // xLabel1
            // 
            this.xLabel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.xLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xLabel1.FocusColor = System.Drawing.Color.Red;
            this.xLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel1.Location = new System.Drawing.Point(14, 57);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(110, 26);
            this.xLabel1.TabIndex = 18;
            this.xLabel1.Text = "Party Name";
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
            this.btn_close.Location = new System.Drawing.Point(1259, 4);
            this.btn_close.Margin = new System.Windows.Forms.Padding(0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(25, 25);
            this.btn_close.TabIndex = 17;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // Txt_party
            // 
            this.Txt_party.AllowNewEntry = false;
            this.Txt_party.BackColor = System.Drawing.Color.White;
            this.Txt_party.EmptyBackColor = System.Drawing.Color.White;
            this.Txt_party.EmptyForeColor = System.Drawing.Color.Black;
            this.Txt_party.FilledBackColor = System.Drawing.Color.White;
            this.Txt_party.FilledForeColor = System.Drawing.Color.White;
            this.Txt_party.FocusBackColor = System.Drawing.Color.LightGreen;
            this.Txt_party.FocusForeColor = System.Drawing.Color.Black;
            this.Txt_party.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_party.ForeColor = System.Drawing.Color.Black;
            this.Txt_party.Location = new System.Drawing.Point(123, 57);
            this.Txt_party.LookupButtonVisible = true;
            this.Txt_party.LookupList = null;
            this.Txt_party.Name = "Txt_party";
            this.Txt_party.ReadOnlyBackColor = System.Drawing.Color.White;
            this.Txt_party.ReadOnlyForeColor = System.Drawing.Color.Black;
            this.Txt_party.SelectedEntity = null;
            this.Txt_party.Size = new System.Drawing.Size(300, 26);
            this.Txt_party.TabIndex = 6;
            this.Txt_party.TextChanged += new System.EventHandler(this.Search_party_TextChanged);
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
            this.header.Size = new System.Drawing.Size(1302, 35);
            this.header.TabIndex = 16;
            this.header.Text = "Party Statement";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_print
            // 
            this.Btn_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_print.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_print.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_print.Location = new System.Drawing.Point(1153, 51);
            this.Btn_print.Name = "Btn_print";
            this.Btn_print.Size = new System.Drawing.Size(131, 39);
            this.Btn_print.TabIndex = 9;
            this.Btn_print.Text = "&PRINT";
            this.Btn_print.Themes = CXLIB.Themescheme.BLUE;
            this.Btn_print.UseVisualStyleBackColor = true;
            this.Btn_print.Click += new System.EventHandler(this.Btn_print_Click);
            // 
            // Listgrid
            // 
            this.Listgrid.AllowUserToAddRows = false;
            this.Listgrid.AllowUserToDeleteRows = false;
            this.Listgrid.AllowUserToOrderColumns = true;
            this.Listgrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Listgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Listgrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Listgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Listgrid.BackgroundColor = System.Drawing.Color.White;
            this.Listgrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Listgrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Custom;
            this.Listgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(192)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Listgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Listgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Listgrid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Listgrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.Listgrid.EnableHeadersVisualStyles = false;
            this.Listgrid.GridColor = System.Drawing.Color.SeaGreen;
            this.Listgrid.Location = new System.Drawing.Point(5, 108);
            this.Listgrid.MultiSelect = false;
            this.Listgrid.Name = "Listgrid";
            this.Listgrid.ReadOnly = true;
            this.Listgrid.RowHeadersVisible = false;
            this.Listgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Listgrid.Size = new System.Drawing.Size(1263, 448);
            this.Listgrid.StandardTab = true;
            this.Listgrid.TabIndex = 0;
            // 
            // ROffset_1_party
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel);
            this.Name = "ROffset_1_party";
            this.Size = new System.Drawing.Size(1302, 620);
            this.Panel.ResumeLayout(false);
            this.Inner_panel.ResumeLayout(false);
            this.Inner_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Listgrid)).EndInit();
            this.ResumeLayout(false);

        }

        private XShadowPanel Panel;
        private System.Windows.Forms.Panel Inner_panel;
        private ListGridView Listgrid;
        private OfficeButton Btn_print;
        private LookupBox Txt_party;
        private Header header;
        private CloseButton btn_close;
        private XLabel xLabel1;
        private XLabel xLabel3;
        private XLabel xLabel2;
        private xDatepicker to_Datepicker;
        private xDatepicker from_Datepicker;
        private XTextBox txt_to_date;
        private XTextBox txt_from_date;
        private XTextBox txt_balance_total;
        private XTextBox txt_receipt_total;
        private XTextBox txt_invoice_total;
        private OfficeButton btn_search;
    }//cls 
}//ns 
