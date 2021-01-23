// Version : 3 dt : 01-08-2017
// Auto Generated
// 17-08-2017 02:11:57 PM
// last update : 17-08-2017

using System;
using System.Windows.Forms;
using CXLIB;
using System.Drawing;
using System.ComponentModel;


namespace CXBILL
{ 
    public partial class FOffset_dc : UserControl 
    { 
        public FOffset_dc() 
        {
            InitializeComponent();
            Initialize();
            InitGrid();
            Setactives();
            SetFocus(); 
            Party_lookup();
            print_panel.Hide();
        }
        
        #region [Private Declare]

        private Timer splitTimer;
        private SplitContainer split_container;
        private XShadowPanel fpanel;
        private Panel finner_panel;
        private CloseButton btn_close;
        private Header lbl_header;
        private OfficeButton btn_list;
        private OfficeButton btn_new;
        private OfficeButton btn_edit;
        private OfficeButton btn_delete;
        private OfficeButton btn_print;
        private OfficeButton btn_splitter;

        private XTextBox txt_dc_no;
        private XLabel lbl_dc_no;
        private xDatepicker txt_dc_date;
        private XLabel lbl_dc_date;
        private LookupBox txt_party_id;
        private XLabel lbl_party_id;
        private EditGridView editgrid;
        private XLabel txt_total_qty;
        private XLabel lbl_total_qty;

        private RichTextBox txt_notes;
        private XLabel lbl_notes;
        private OfficeButton btn_save;
        private OfficeButton btn_active;
        private ShadowBox print_panel;
        private CloseButton btn_print_close;
        private Label lbl_print_header;
        private MCheckBox check_original;
        private MCheckBox check_duplicate;
        private MCheckBox check_triplicate;
        private MCheckBox check_fourplicate;

        #endregion [Private Declare]

        private void Initialize() 
        { 

            #region[declare new]

            components = new Container();
            splitTimer = new Timer(components);
            split_container = new SplitContainer();
            fpanel = new XShadowPanel();
            finner_panel = new Panel();
            btn_list = new OfficeButton();
            btn_new = new OfficeButton();
            btn_edit = new OfficeButton();
            btn_delete = new OfficeButton();
            btn_print = new OfficeButton();
            btn_splitter = new OfficeButton();
            lbl_header = new Header();
            btn_close = new CloseButton();

            txt_dc_no = new XTextBox();
            lbl_dc_no = new XLabel();
            txt_dc_date = new xDatepicker();
            lbl_dc_date = new XLabel();
            txt_party_id = new LookupBox();
            lbl_party_id = new XLabel();
            editgrid = new EditGridView();
            txt_total_qty = new XLabel();
            lbl_total_qty = new XLabel();

            txt_notes = new RichTextBox();
            lbl_notes = new XLabel();
            btn_save = new OfficeButton();
            btn_active = new OfficeButton();
            print_panel = new ShadowBox();
            btn_print_close = new CloseButton();
            lbl_print_header = new Label();
            check_original = new MCheckBox();
            check_duplicate = new MCheckBox();
            check_triplicate = new MCheckBox();
            check_fourplicate = new MCheckBox();

            #endregion[declare new]

            #region[container suspend]

            ((ISupportInitialize)(split_container)).BeginInit();
            ((ISupportInitialize)(editgrid)).BeginInit();
            split_container.Panel1.SuspendLayout();
            split_container.Panel2.SuspendLayout();
            split_container.SuspendLayout();
            fpanel.SuspendLayout();
            finner_panel.SuspendLayout();
            SuspendLayout();

            #endregion[container suspend]

            #region[splitTimer]

            splitTimer.Interval = 2;
            splitTimer.Tick += new EventHandler(SplitTimer_Tick);

            #endregion[splitTimer]

            #region[split_container]

            split_container.Dock = DockStyle.Fill;
            split_container.Location = new Point(0, 0);
            split_container.Name = "split_container";
            split_container.BackColor = XTheme.Splitcontainer_colour;
            split_container.Size = XSize.FSplitcontainer;
            split_container.SplitterDistance = XSize.Screen_Width;
            split_container.TabIndex = XTab.Splitcontainer;

            // split_container.Panel1

            split_container.Panel1.Controls.Add(fpanel);

            #region[split_container.Panel2]

            split_container.Panel2.Controls.Add(btn_print);
            split_container.Panel2.Controls.Add(btn_delete);
            split_container.Panel2.Controls.Add(btn_edit);
            split_container.Panel2.Controls.Add(btn_new);
            split_container.Panel2.Controls.Add(btn_list);
            split_container.Panel2.Controls.Add(btn_splitter);

            btn_list.Font = XFont.BtnFont;
            btn_list.Location =  XLayout.FormFirstBtn;
            btn_list.Size = XSize.BtnOne;
            btn_list.TabIndex = 1;
            btn_list.Name = "btn_list";
            btn_list.Text = "&List";
            btn_list.Themes = XTheme.BlueBtn;
            btn_list.Click += Btn_list_Click;

            btn_new.Font = XFont.BtnFont;
            btn_new.Location = XLayout.BtnLocation(btn_list.Location);
            btn_new.Size = XSize.BtnOne;
            btn_new.TabIndex = XTab.Index(btn_list.TabIndex);
            btn_new.Name = "btn_new";
            btn_new.Text = "&New";
            btn_new.Themes = XTheme.BlueBtn;
            btn_new.Click += Btn_new_Click;

            btn_edit.Font = XFont.BtnFont;
            btn_edit.Location = XLayout.BtnLocation(btn_new.Location);
            btn_edit.Size = XSize.BtnOne;
            btn_edit.TabIndex = XTab.Index(btn_new.TabIndex);
            btn_edit.Name = "btn_edit";
            btn_edit.Text = "&Edit";
            btn_edit.Themes = XTheme.BlueBtn;
            btn_edit.Click += Btn_edit_Click;

            btn_delete.Font = XFont.BtnFont;
            btn_delete.Location = XLayout.BtnLocation(btn_edit.Location);
            btn_delete.Size = XSize.BtnOne;
            btn_delete.TabIndex = XTab.Index(btn_edit.TabIndex);
            btn_delete.Name = "btn_delete";
            btn_delete.Text = "&Delete";
            btn_delete.Themes = XTheme.BlueBtn;
            btn_delete.Click += Btn_delete_Click;

            btn_print.Font = XFont.BtnFont;
            btn_print.Location = XLayout.BtnLocation(btn_delete.Location);
            btn_print.Size = XSize.BtnOne;
            btn_print.TabIndex = XTab.Index(btn_delete.TabIndex);
            btn_print.Name = "btn_print";
            btn_print.Text = "&Print";
            btn_print.Themes = XTheme.BlueBtn;
            btn_print.Click += Btn_print_Click;

            btn_splitter.Font = XFont.BtnFont;
            btn_splitter.Location = XLayout.Splitter;
            btn_splitter.Size = XSize.Splitter;
            btn_splitter.TabIndex = XTab.Index(btn_print.TabIndex);
            btn_splitter.Name = "btn_splitter";
            btn_splitter.Text = "⁞⁞";
            btn_splitter.Themes = XTheme.WhiteBtn;
            btn_splitter.Click += new EventHandler(Btn_splitter_Click);

            #endregion[split_container.Panel2]

            #endregion[split_container]

            #region[fpanel]

            fpanel.Name = "fpanel";
            fpanel.Anchor = XAnchor.LTR;
            fpanel.Size =  XSize.FPanel;
            fpanel.Location = XLayout.FPanel;
            fpanel.BackColor = XTheme.FPanel;
            fpanel.Controls.Add(finner_panel);
            fpanel.Controls.Add(btn_close);
            fpanel.Controls.Add(lbl_header);

            #endregion[fpanel]

            #region[finner_panel]

            finner_panel.Anchor = XAnchor.LTR;
            finner_panel.Cursor = Cursors.Default;
            finner_panel.Name = "finner_panel";
            finner_panel.Size = XSize.FInnerPanel;
            finner_panel.Location = XLayout.FInnerPanel;
            finner_panel.BackColor = XTheme.FInnerpanel;
            finner_panel.AutoScroll = true;

            #region[adding controls]

            finner_panel.Controls.Add(print_panel);
            finner_panel.Controls.Add(txt_notes);
            finner_panel.Controls.Add(lbl_notes);
            finner_panel.Controls.Add(txt_dc_no);
            finner_panel.Controls.Add(lbl_dc_no);
            finner_panel.Controls.Add(txt_dc_date);
            finner_panel.Controls.Add(lbl_dc_date);
            finner_panel.Controls.Add(txt_party_id);
            finner_panel.Controls.Add(lbl_party_id);
            finner_panel.Controls.Add(txt_total_qty);
            finner_panel.Controls.Add(lbl_total_qty);
            finner_panel.Controls.Add(editgrid);
            finner_panel.Controls.Add(btn_save);
            finner_panel.Controls.Add(btn_active);

            #endregion[adding controls]

            #region[Header]

            btn_close.Click += new EventHandler(Btn_close_Click);

            lbl_header.Text = "Dc";

            #endregion[Header]

            #region[Properties of control]

            lbl_dc_no.Font = XFont.Font_10B;
            lbl_dc_no.Name = "lbl_dc_no";
            lbl_dc_no.Text = "   Dc no";
            lbl_dc_no.Anchor = XAnchor.LT;
            lbl_dc_no.TextAlign = ContentAlignment.MiddleLeft;
            lbl_dc_no.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_dc_no.Size =  XSize.OneLabel;
            lbl_dc_no.Location =XLayout.FirstLabel;

            txt_dc_no.Font = XFont.TxtFont;
            txt_dc_no.ForeColor = XFontColor.TxtFontColor;
            txt_dc_no.BackColor = XTheme.TxtBackcolor;
            txt_dc_no.Name = "txt_dc_no";
            txt_dc_no.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_dc_no.TextAlign = HorizontalAlignment.Left;
            txt_dc_no.Size =  XSize.TwoText;
            txt_dc_no.Anchor = XAnchor.LT;
            txt_dc_no.Location =XLayout.FirstText;
            txt_dc_no.TabIndex = XTab.Txt_TabIndex;
            txt_dc_no.Enter += new EventHandler(Txt_dc_no_Enter);


            lbl_dc_date.Font = XFont.Font_10B;
            lbl_dc_date.Name = "lbl_dc_date";
            lbl_dc_date.Text = "   Dc date";
            lbl_dc_date.Anchor = XAnchor.LT;
            lbl_dc_date.TextAlign = ContentAlignment.MiddleLeft;
            lbl_dc_date.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_dc_date.Size =  XSize.TwoLabel;
            lbl_dc_date.Location =XLayout.R1_2Label_2(lbl_dc_no.Location);

            txt_dc_date.Font = XFont.TxtFont;
            txt_dc_date.ForeColor = XFontColor.TxtFontColor;
            txt_dc_date.BackColor = XTheme.TxtBackcolor;
            txt_dc_date.Name = "txt_dc_date";
            txt_dc_date.CustomFormat = "dd-MM-yyyy";
            txt_dc_date.Format = DateTimePickerFormat.Custom;
            txt_dc_date.Size =  XSize.TwoText;
            txt_dc_date.Anchor = XAnchor.LTR;
            txt_dc_date.Location =XLayout.R1_2Text_2(txt_dc_no.Location);
            txt_dc_date.TabIndex = XTab.Index(txt_dc_no.TabIndex);
            txt_dc_date.Enter += new EventHandler(Txt_dc_date_Enter);


            lbl_party_id.Font = XFont.Font_10B;
            lbl_party_id.Name = "lbl_party_id";
            lbl_party_id.Text = "   Party";
            lbl_party_id.Anchor = XAnchor.LT;
            lbl_party_id.TextAlign = ContentAlignment.MiddleLeft;
            lbl_party_id.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_party_id.Size =  XSize.OneLabel;
            lbl_party_id.Location =XLayout.R1_Label(lbl_dc_date.Location);

            txt_party_id.Font = XFont.TxtFont;
            txt_party_id.ForeColor = XFontColor.TxtFontColor;
            txt_party_id.BackColor = XTheme.TxtBackcolor;
            txt_party_id.Name = "txt_party_id";
            txt_party_id.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_party_id.TextAlign = HorizontalAlignment.Left;
            txt_party_id.Size =  XSize.OneText;
            txt_party_id.Anchor = XAnchor.LTR;
            txt_party_id.Location =XLayout.R1_Text(txt_dc_date.Location);
            txt_party_id.TabIndex = XTab.Index(txt_dc_date.TabIndex);
            txt_party_id.Enter += new EventHandler(Txt_party_id_Enter);

            editgrid.Location = new Point(XLayout.H_left, lbl_party_id.Bottom + 10); 
            editgrid.Name = "editgrid"; 
            editgrid.Size = new Size(finner_panel.Width - 50, 250); 
            editgrid.TabIndex = XTab.Index(txt_party_id.TabIndex);
            editgrid.RowsLimit = 12; 
            Point p = new Point(editgrid.Left , editgrid.Bottom); 

            lbl_total_qty.Font = XFont.Font_10B;
            lbl_total_qty.Name = "lbl_total_qty";
            lbl_total_qty.Text = "Total qty";
            lbl_total_qty.Anchor = XAnchor.LT;
            lbl_total_qty.TextAlign = ContentAlignment.MiddleLeft;
            lbl_total_qty.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_total_qty.Size =  XSize.FourLabel;
            lbl_total_qty.Location =XLayout.R2_4Label_4(p);

            txt_total_qty.Font = XFont.TxtFont;
            txt_total_qty.ForeColor = XFontColor.TxtFontColor;
            txt_total_qty.BackColor = XTheme.TxtBackcolor;
            txt_total_qty.Name = "txt_total_qty";
            txt_total_qty.TextAlign = ContentAlignment.MiddleRight;
            txt_total_qty.Size =  XSize.FourText;
            txt_total_qty.Anchor = XAnchor.LTR;
            txt_total_qty.Location =XLayout.R2_4Text_4(p);
            txt_total_qty.TabIndex = XTab.Index(editgrid.TabIndex);
            txt_total_qty.Enter += new EventHandler(Txt_total_qty_Enter);


            lbl_notes.Font = XFont.Font_10B;
            lbl_notes.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_notes.Location = XLayout.LblNotes;
            lbl_notes.Size = XSize.LblNotes;
            lbl_notes.Anchor = XAnchor.LB;
            lbl_notes.Name = "lbl_notes";
            lbl_notes.Text = "   Notes";
            lbl_notes.TextAlign = ContentAlignment.MiddleLeft;
            lbl_notes.Click += new EventHandler(Lbl_notes_Click);

            txt_notes.Font = Theme.txtFont;
            txt_notes.ForeColor = Theme.txtForeColor;
            txt_notes.BackColor = Theme.White;
            txt_notes.Location = XLayout.TxtNotes;
            txt_notes.Size =  XSize.TxtNotes;
            txt_notes.Name = "txt_notes";
            txt_notes.Anchor = XAnchor.LRB;
            txt_notes.TabIndex = XTab.Index(txt_notes.TabIndex);
            txt_notes.Enter += new EventHandler(Txt_notes_Enter);

            #endregion[Properties of control]

            #region[Properties of btn]

            btn_save.Anchor = XAnchor.RB;
            btn_save.Font = XFont.BtnFont;
            btn_save.Size = XSize.BtnOne;
            btn_save.Location = XLayout.BtnSave;
            btn_save.TabIndex = XTab.Index(txt_total_qty.TabIndex);
            btn_save.Name = "btn_save";
            btn_save.Text = "&SAVE";
            btn_save.Themes = XTheme.BlueBtn;
            btn_save.Click += new EventHandler(Btn_save_click);

            btn_active.Anchor = XAnchor.RB;
            btn_active.Font = XFont.BtnFont;
            btn_active.Size = XSize.BtnOne;
            btn_active.Location = XLayout.BtnActive;
            btn_active.TabIndex = XTab.Index(btn_save.TabIndex);
            btn_active.Name = "btn_active";
            btn_active.Text = "&Active";
            btn_active.Click += new EventHandler(Btn_active_Click);

            txt_notes.TabIndex = btn_active.TabIndex + 1;

            #endregion[Properties of btn]

            #region[Print panel]

            print_panel.BorderStyle = BorderStyle.None;
            print_panel.Controls.Add(this.btn_print_close);
            print_panel.Controls.Add(this.lbl_print_header);
            print_panel.Controls.Add(this.check_original);
            print_panel.Controls.Add(this.check_duplicate);
            print_panel.Controls.Add(this.check_triplicate);
            print_panel.Controls.Add(this.check_fourplicate);
            print_panel.Location = new Point(600, 330);
            print_panel.Name = "print_panel";
            print_panel.Size = new Size(357, 200);
            print_panel.TabIndex = 35;

            #region[Header]
            //
            btn_print_close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_print_close.BackColor = Color.FromArgb(0, 97, 168);
            btn_print_close.Cursor = Cursors.Default;
            btn_print_close.FlatAppearance.BorderSize = 0;
            btn_print_close.FlatAppearance.MouseDownBackColor = Color.OrangeRed;
            btn_print_close.FlatAppearance.MouseOverBackColor = Color.Crimson;
            btn_print_close.FlatStyle = FlatStyle.Flat;
            btn_print_close.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_print_close.ForeColor = Color.FromArgb(217, 237, 255);
            btn_print_close.Location = new Point(323, 3);
            btn_print_close.Name = "btn_print_close";
            btn_print_close.Size = new Size(Theme.btn_close_width - 5, Theme.btn_close_height - 5);
            btn_print_close.TabIndex = 30;
            btn_print_close.Text = "X";
            btn_print_close.UseVisualStyleBackColor = false;
            btn_print_close.Click += new EventHandler(Btn_close_Click);
            //
            lbl_print_header.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_print_header.BackColor = Theme.F_header_Backcolor;
            lbl_print_header.Cursor = Cursors.Default;
            lbl_print_header.Font = Theme.F_header_Font;
            lbl_print_header.ForeColor = Theme.F_headerText_Fontcolor;
            lbl_print_header.Location = new Point(6, 0);
            lbl_print_header.Name = "lbl_print_header";
            lbl_print_header.Size = new Size(345, 30);
            lbl_print_header.Text = "Print Option";
            lbl_print_header.TextAlign = ContentAlignment.MiddleCenter;
            //
            #endregion[Header]

            check_original.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            check_original.AutoSize = true;
            check_original.Location = new Point(35, 50);
            check_original.Name = "check_original";
            check_original.Size = new Size(125, 17);
            check_original.TabIndex = 1;
            check_original.Text = "Original Copy";
            check_original.UseVisualStyleBackColor = true;
            check_original.Checked = true;
            //check_original.CheckedChanged += new EventHandler(radio_billed_CheckedChanged);
            //
            check_duplicate.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            check_duplicate.AutoSize = true;
            check_duplicate.Location = new Point(check_original.Left, check_original.Top + 35);
            check_duplicate.Name = "check_duplicate";
            check_duplicate.Size = new Size(125, 17);
            check_duplicate.TabIndex = 1;
            check_duplicate.Text = "Duplicate Copy";
            check_duplicate.UseVisualStyleBackColor = true;
            check_duplicate.Checked = true;
            //check_duplicate.CheckedChanged += new EventHandler(radio_billed_CheckedChanged);
            //
            check_triplicate.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            check_triplicate.AutoSize = true;
            check_triplicate.Location = new Point(check_duplicate.Left, check_duplicate.Top + 35);
            check_triplicate.Name = "check_triplicate";
            check_triplicate.Size = new Size(125, 17);
            check_triplicate.TabIndex = 1;
            check_triplicate.Text = "Triplicate Copy";
            check_triplicate.UseVisualStyleBackColor = true;
            check_triplicate.Checked = true;
            //check_triplicate.CheckedChanged += new EventHandler(radio_billed_CheckedChanged);
            //
            check_fourplicate.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            check_fourplicate.AutoSize = true;
            check_fourplicate.Location = new Point(check_triplicate.Left, check_triplicate.Top + 35);
            check_fourplicate.Name = "check_fourplicate";
            check_fourplicate.Size = new Size(125, 17);
            check_fourplicate.TabIndex = 1;
            check_fourplicate.Text = "Quadruplicate Copy";
            check_fourplicate.UseVisualStyleBackColor = true;
            //check_fourplicate.CheckedChanged += new EventHandler(radio_billed_CheckedChanged);


            #endregion[Print panel]

            #endregion[finner_panel]

            #region [FDc]

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.split_container);
            this.Name = "fDc";
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, ClientSize.Height);

            this.split_container.Panel1.ResumeLayout(false);
            this.split_container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(editgrid)).EndInit();
            ((ISupportInitialize)(this.split_container)).EndInit();
            this.split_container.ResumeLayout(false);
            this.fpanel.ResumeLayout(false);
            this.finner_panel.ResumeLayout(false);
            this.finner_panel.PerformLayout();
            this.ResumeLayout(false);

            #endregion [Fpost]
        }
  
         #region[Init Grid]

         private void InitGrid()
         {
            editgrid.RowsRemoved += new DataGridViewRowsRemovedEventHandler(Editgrid_RowsRemoved);
            editgrid.CellValidating += new DataGridViewCellValidatingEventHandler(Editgrid_CellValidating);
            editgrid.CellValueChanged += new DataGridViewCellEventHandler(Editgrid_CellValueChanged);
            editgrid.CurrentCellChanged += new EventHandler(Editgrid_CurrentCellChanged);

            DataGridViewTextBoxColumn col_Dcitems_Id = new DataGridViewTextBoxColumn();
            col_Dcitems_Id.Name = OFFSET_DCITEMS.OFFSET_DCITEMS_ID;
            col_Dcitems_Id.HeaderText = "DCITEMS_ID ";
            col_Dcitems_Id.Visible = false; 
            col_Dcitems_Id.Width = 100;
            col_Dcitems_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Dcitems_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Dcitems_Id );

            DataGridViewTextBoxColumn col_Dc_Id = new DataGridViewTextBoxColumn();
            col_Dc_Id.Name = OFFSET_DCITEMS.OFFSET_DC_ID;
            col_Dc_Id.HeaderText = "DC_ID ";
            col_Dc_Id.Visible = false;
            col_Dc_Id.Width = 100;
            col_Dc_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Dc_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Dc_Id);

            DataGridViewTextBoxColumn col_slno = new DataGridViewTextBoxColumn();
            col_slno.Name = Core.SLNO;
            col_slno.HeaderText = "S.NO";
            //col_slno.Visible = false; 
            col_slno.ReadOnly = true;
            col_slno.Width = 50;
            col_slno.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_slno.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_slno);

            DataGridViewTextBoxColumn col_Po_id = new DataGridViewTextBoxColumn();
            col_Po_id.Name = OFFSET_DCITEMS.OFFSET_PO_ID;
            col_Po_id.HeaderText = "PO";
            //col_Po_id.Visible = false; 
            col_Po_id.Width = 200;
            col_Po_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Po_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Po_id);

            DataGridViewTextBoxColumn col_Poitems_id = new DataGridViewTextBoxColumn();
            col_Poitems_id.Name = OFFSET_DCITEMS.OFFSET_POITEMS_ID;
            col_Poitems_id.HeaderText = "POITEMS_ID";
            col_Poitems_id.Visible = false; 
            col_Poitems_id.Width = 200;
            col_Poitems_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Poitems_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Poitems_id);

            DataGridViewTextBoxColumn col_Product_id = new DataGridViewTextBoxColumn();
            col_Product_id.Name = OFFSET_DCITEMS.PRODUCT_ID;
            col_Product_id.HeaderText = "PARTICULARS";
            //col_Product_id.Visible = false; 
            col_Product_id.Width = 600;
            col_Product_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Product_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Product_id);

            DataGridViewTextBoxColumn col_Qty = new DataGridViewTextBoxColumn();
            col_Qty.Name = OFFSET_DCITEMS.QTY;
            col_Qty.HeaderText = "QTY";
            //col_Qty.Visible = false; 
            col_Qty.Width = 200;
            col_Qty.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Qty.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Qty);


            DataGridViewTextBoxColumn colFiller = new DataGridViewTextBoxColumn();
            colFiller.Name = "FILLER";
            colFiller.HeaderText = "";
            colFiller.ReadOnly = true;
            colFiller.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            colFiller.SortMode = DataGridViewColumnSortMode.NotSortable;
            colFiller.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            editgrid.Columns.Add(colFiller);

            }

            #endregion[Init Grid]

}//cls 
}//ns 
