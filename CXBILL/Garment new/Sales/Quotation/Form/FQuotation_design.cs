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
    public partial class FQuotation : UserControl
    {
        public FQuotation()
        {
            InitializeComponent();
            Initialize();
            InitGrid();
            Setactives();
            SetFocus();
            Party_lookup();
            Ledger_lookup();
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

        private XTextBox txt_quotation_no;
        private XLabel lbl_quotation_no;
        private xDatepicker txt_quotation_date;
        private XLabel lbl_quotation_date;
        private LookupBox txt_party_id;
        private XLabel lbl_party_id;
        private EditGridView editgrid;
        //private XLabel txt_total_qty;
        //private XLabel lbl_total_qty;
        //private XLabel txt_gsttotal;
        //private XLabel lbl_gsttotal;
        private LookupBox txt_ledger_id;
        private XLabel lbl_ledger_id;
        private XTextBox txt_additional;
        private XLabel lbl_additional;
        private XLabel txt_grandtotal;
        private XLabel lbl_grandtotal;
        private XTextBox txt_balance;
        private XLabel lbl_balance;

        private RichTextBox txt_notes;
        private XLabel lbl_notes;
        private OfficeButton btn_save;
        private OfficeButton btn_saveprint;
        private OfficeButton btn_active;

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

            txt_quotation_no = new XTextBox();
            lbl_quotation_no = new XLabel();
            txt_quotation_date = new xDatepicker();
            lbl_quotation_date = new XLabel();
            txt_party_id = new LookupBox();
            lbl_party_id = new XLabel();
            editgrid = new EditGridView();
            //txt_total_qty = new XLabel();
            //lbl_total_qty = new XLabel();
            //txt_gsttotal = new XLabel();
            //lbl_gsttotal = new XLabel();
            txt_ledger_id = new LookupBox();
            lbl_ledger_id = new XLabel();
            txt_additional = new XTextBox();
            lbl_additional = new XLabel();
            txt_grandtotal = new XLabel();
            lbl_grandtotal = new XLabel();
            txt_balance = new XTextBox();
            lbl_balance = new XLabel();

            txt_notes = new RichTextBox();
            lbl_notes = new XLabel();
            btn_save = new OfficeButton();
            btn_saveprint = new OfficeButton();
            btn_active = new OfficeButton();

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
            btn_list.Location = XLayout.FormFirstBtn;
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
            fpanel.Size = XSize.FPanel;
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

            finner_panel.Controls.Add(txt_quotation_no);
            finner_panel.Controls.Add(lbl_quotation_no);
            finner_panel.Controls.Add(txt_quotation_date);
            finner_panel.Controls.Add(lbl_quotation_date);
            finner_panel.Controls.Add(txt_notes);
            finner_panel.Controls.Add(lbl_notes);
            finner_panel.Controls.Add(txt_party_id);
            finner_panel.Controls.Add(lbl_party_id);
            //finner_panel.Controls.Add(txt_total_qty);
            //finner_panel.Controls.Add(lbl_total_qty);
            //finner_panel.Controls.Add(txt_gsttotal);
            //finner_panel.Controls.Add(lbl_gsttotal);
            finner_panel.Controls.Add(txt_ledger_id);
            finner_panel.Controls.Add(lbl_ledger_id);
            finner_panel.Controls.Add(txt_additional);
            finner_panel.Controls.Add(lbl_additional);
            finner_panel.Controls.Add(txt_grandtotal);
            finner_panel.Controls.Add(lbl_grandtotal);
            finner_panel.Controls.Add(txt_balance);
            finner_panel.Controls.Add(lbl_balance);
            finner_panel.Controls.Add(editgrid);
            finner_panel.Controls.Add(btn_save);
            finner_panel.Controls.Add(btn_saveprint);
            finner_panel.Controls.Add(btn_active);

            #endregion[adding controls]

            #region[Header]

            btn_close.Click += new EventHandler(Btn_close_Click);

            lbl_header.Text = "Quotation";

            #endregion[Header]

            #region[Properties of control]

            lbl_quotation_no.Font = XFont.Font_10B;
            lbl_quotation_no.Name = "lbl_quotation_no";
            lbl_quotation_no.Text = "   Quotation no";
            lbl_quotation_no.Anchor = XAnchor.LT;
            lbl_quotation_no.TextAlign = ContentAlignment.MiddleLeft;
            lbl_quotation_no.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_quotation_no.Size = XSize.OneLabel;
            lbl_quotation_no.Location = XLayout.FirstLabel;

            txt_quotation_no.Font = XFont.TxtFont;
            txt_quotation_no.ForeColor = XFontColor.TxtFontColor;
            txt_quotation_no.BackColor = XTheme.TxtBackcolor;
            txt_quotation_no.Name = "txt_quotation_no";
            txt_quotation_no.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_quotation_no.TextAlign = HorizontalAlignment.Left;
            txt_quotation_no.Size = new Size(XSize.TwoTxtColumn -20,XSize.TwoTxtHeight);
            txt_quotation_no.Anchor = XAnchor.LT;
            txt_quotation_no.Location = XLayout.FirstText;
            txt_quotation_no.TabIndex = XTab.Txt_TabIndex;
            txt_quotation_no.Enter += new EventHandler(Txt_quotation_no_Enter);


            lbl_quotation_date.Font = XFont.Font_10B;
            lbl_quotation_date.Name = "lbl_quotation_date";
            lbl_quotation_date.Text = "   Date";
            lbl_quotation_date.Anchor = XAnchor.LT;
            lbl_quotation_date.TextAlign = ContentAlignment.MiddleLeft;
            lbl_quotation_date.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_quotation_date.Size = XSize.TwoLabel;
            lbl_quotation_date.Location = XLayout.R1_2Label_2(lbl_quotation_no.Location);

            txt_quotation_date.Font = XFont.TxtFont;
            txt_quotation_date.ForeColor = XFontColor.TxtFontColor;
            txt_quotation_date.BackColor = XTheme.TxtBackcolor;
            txt_quotation_date.Name = "txt_quotation_date";
            txt_quotation_date.CustomFormat = "  dd-MM-yyyy";
            txt_quotation_date.Format = DateTimePickerFormat.Custom;
            txt_quotation_date.Size = XSize.TwoText;
            txt_quotation_date.Anchor = XAnchor.LTR;
            txt_quotation_date.Location = XLayout.R1_2Text_2(txt_quotation_no.Location);
            txt_quotation_date.TabIndex = XTab.Index(txt_quotation_no.TabIndex);
            txt_quotation_date.Enter += new EventHandler(Txt_quotation_date_Enter);

            lbl_party_id.Font = XFont.Font_10B;
            lbl_party_id.Name = "lbl_party_id";
            lbl_party_id.Text = "   Party";
            lbl_party_id.Anchor = XAnchor.LT;
            lbl_party_id.TextAlign = ContentAlignment.MiddleLeft;
            lbl_party_id.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_party_id.Size = XSize.OneLabel;
            lbl_party_id.Location = XLayout.R1_Label(lbl_quotation_date.Location);

            txt_party_id.Font = XFont.TxtFont;
            txt_party_id.ForeColor = XFontColor.TxtFontColor;
            txt_party_id.BackColor = XTheme.TxtBackcolor;
            txt_party_id.Name = "txt_party_id";
            txt_party_id.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_party_id.TextAlign = HorizontalAlignment.Left;
            txt_party_id.Size = XSize.OneText;
            txt_party_id.Anchor = XAnchor.LTR;
            txt_party_id.Location = XLayout.R1_Text(txt_quotation_date.Location);
            txt_party_id.TabIndex = XTab.Index(txt_quotation_date.TabIndex);
            txt_party_id.Enter += new EventHandler(Txt_party_id_Enter);
            txt_party_id.TextChanged += Txt_party_TextChanged;



            editgrid.Location = new Point(XLayout.H_left, txt_party_id.Bottom + 10);
            editgrid.Name = "editgrid";
            editgrid.Size = new Size(finner_panel.Width - 50, 250);
            editgrid.TabIndex = XTab.Index(txt_party_id.TabIndex);
            editgrid.RowsLimit = 12;
            Point p = new Point(editgrid.Left, editgrid.Bottom);

            //lbl_total_qty.Font = XFont.Font_10B;
            //lbl_total_qty.Name = "lbl_total_qty";
            //lbl_total_qty.Text = "Total qty";
            //lbl_total_qty.Anchor = XAnchor.LT;
            //lbl_total_qty.TextAlign = ContentAlignment.MiddleLeft;
            //lbl_total_qty.ForeColor = XFontColor.Lbl_ForeColor;
            //lbl_total_qty.Size = XSize.FourLabel;
            //lbl_total_qty.Location = XLayout.R2_4Label_3(p);

            //txt_total_qty.Font = XFont.TxtFont;
            //txt_total_qty.ForeColor = XFontColor.TxtFontColor;
            //txt_total_qty.BackColor = XTheme.TxtBackcolor;
            //txt_total_qty.Name = "txt_total_qty";
            //txt_total_qty.TextAlign = ContentAlignment.MiddleRight;
            //txt_total_qty.Size = XSize.FourText;
            //txt_total_qty.Anchor = XAnchor.LT;
            //txt_total_qty.Location = XLayout.R2_4Text_3(p);
            //txt_total_qty.TabIndex = XTab.Index(editgrid.TabIndex);
            //txt_total_qty.Enter += new EventHandler(Txt_total_qty_Enter);

            //lbl_gsttotal.Font = XFont.Font_10B;
            //lbl_gsttotal.Name = "lbl_gsttotal";
            //lbl_gsttotal.Text = "Gst total";
            //lbl_gsttotal.Anchor = XAnchor.LT;
            //lbl_gsttotal.TextAlign = ContentAlignment.MiddleLeft;
            //lbl_gsttotal.ForeColor = XFontColor.Lbl_ForeColor;
            //lbl_gsttotal.Size = XSize.FourLabel;
            //lbl_gsttotal.Location = XLayout.R2_4Label_4(p);

            //txt_gsttotal.Font = XFont.TxtFont;
            //txt_gsttotal.ForeColor = XFontColor.TxtFontColor;
            //txt_gsttotal.BackColor = XTheme.TxtBackcolor;
            //txt_gsttotal.Name = "txt_gsttotal";
            //txt_gsttotal.TextAlign = ContentAlignment.MiddleRight;
            //txt_gsttotal.Size = XSize.FourText;
            //txt_gsttotal.Anchor = XAnchor.LTR;
            //txt_gsttotal.Location = XLayout.R2_4Text_4(p);
            //txt_gsttotal.TabIndex = XTab.Index(txt_total_qty.TabIndex);
            //txt_gsttotal.Enter += new EventHandler(Txt_gsttotal_Enter);

            lbl_ledger_id.Font = XFont.Font_10B;
            lbl_ledger_id.Name = "lbl_ledger_id";
            lbl_ledger_id.Text = "Invoice No";
            lbl_ledger_id.Anchor = XAnchor.LT;
            lbl_ledger_id.TextAlign = ContentAlignment.MiddleLeft;
            lbl_ledger_id.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_ledger_id.Size = XSize.FourLabel;
            lbl_ledger_id.Location = XLayout.R2_4Label_3(p);

            txt_ledger_id.Font = XFont.TxtFont;
            txt_ledger_id.ForeColor = XFontColor.TxtFontColor;
            txt_ledger_id.BackColor = XTheme.TxtBackcolor;
            txt_ledger_id.Name = "txt_ledger_id";
            txt_ledger_id.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_ledger_id.TextAlign = HorizontalAlignment.Left;
            txt_ledger_id.Size = XSize.FourText;
            txt_ledger_id.Anchor = XAnchor.LT;
            txt_ledger_id.Location = XLayout.R2_4Text_3(p);
            txt_ledger_id.TabIndex = XTab.Index(editgrid.TabIndex);
            txt_ledger_id.Enter += new EventHandler(Txt_ledger_id_Enter);
            txt_ledger_id.TextChanged += Txt_ledger_id_TextChanged;

            lbl_additional.Font = XFont.Font_10B;
            lbl_additional.Name = "lbl_additional";
            lbl_additional.Text = "Additional";
            lbl_additional.Anchor = XAnchor.LT;
            lbl_additional.TextAlign = ContentAlignment.MiddleLeft;
            lbl_additional.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_additional.Size = XSize.FourLabel;
            lbl_additional.Location = XLayout.R2_4Label_4(p);

            txt_additional.Font = XFont.TxtFont;
            txt_additional.ForeColor = XFontColor.TxtFontColor;
            txt_additional.BackColor = XTheme.TxtBackcolor;
            txt_additional.Name = "txt_additional";
            txt_additional.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_additional.TextAlign = HorizontalAlignment.Right;
            txt_additional.Size = XSize.FourText;
            txt_additional.Anchor = XAnchor.LTR;
            txt_additional.Location = XLayout.R2_4Text_4(p);
            txt_additional.TabIndex = XTab.Index(txt_ledger_id.TabIndex);
            txt_additional.Enter += new EventHandler(Txt_additional_Enter);
            txt_additional.TextChanged += Txt_additional_TextChanged;

            lbl_grandtotal.Font = XFont.Font_10B;
            lbl_grandtotal.Name = "lbl_grandtotal";
            lbl_grandtotal.Text = "Grand total";
            lbl_grandtotal.Anchor = XAnchor.LT;
            lbl_grandtotal.TextAlign = ContentAlignment.MiddleLeft;
            lbl_grandtotal.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_grandtotal.Size = XSize.FourLabel;
            lbl_grandtotal.Location = XLayout.R2_4Label_4(lbl_additional.Location);

            txt_grandtotal.Font = XFont.TxtFont;
            txt_grandtotal.ForeColor = XFontColor.TxtFontColor;
            txt_grandtotal.BackColor = XTheme.TxtBackcolor;
            txt_grandtotal.Name = "txt_grandtotal";
            txt_grandtotal.TextAlign = ContentAlignment.MiddleRight;
            txt_grandtotal.Size = XSize.FourText;
            txt_grandtotal.Anchor = XAnchor.LTR;
            txt_grandtotal.Location = XLayout.R2_4Text_4(txt_additional.Location);
            txt_grandtotal.TabIndex = XTab.Index(txt_additional.TabIndex);
            txt_grandtotal.Enter += new EventHandler(Txt_grandtotal_Enter);

            lbl_balance.Font = XFont.Font_10B;
            lbl_balance.Name = "lbl_balance";
            lbl_balance.Text = "Ledger Balance";
            lbl_balance.Anchor = XAnchor.LT;
            lbl_balance.TextAlign = ContentAlignment.MiddleLeft;
            lbl_balance.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_balance.Size = XSize.OneLabel;
            lbl_balance.Location = XLayout.R1_4Label_1(lbl_additional.Location);

            txt_balance.Font = XFont.TxtFont;
            txt_balance.ForeColor = XFontColor.TxtFontColor;
            txt_balance.BackColor = XTheme.TxtBackcolor;
            txt_balance.Name = "txt_balance";
            txt_balance.TextAlign = HorizontalAlignment.Right;
            txt_balance.Size = XSize.FourText;
            txt_balance.Anchor = XAnchor.LTR;
            txt_balance.Location = XLayout.R1_4Text_1(txt_additional.Location);
            txt_balance.TabIndex = XTab.Index(txt_additional.TabIndex);
            txt_balance.Enter += new EventHandler(Txt_balance_Enter);

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
            txt_notes.Size = XSize.TxtNotes;
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
            btn_save.TabIndex = XTab.Index(txt_grandtotal.TabIndex);
            btn_save.Name = "btn_save";
            btn_save.Text = "&SAVE";
            btn_save.Themes = XTheme.BlueBtn;
            btn_save.Click += new EventHandler(Btn_save_click);

            btn_saveprint.Anchor = XAnchor.RB;
            btn_saveprint.Font = XFont.BtnFont;
            btn_saveprint.Size = XSize.BtnOne;
            btn_saveprint.Location = new Point(btn_save.Left - 180, btn_save.Top);
            btn_saveprint.TabIndex = XTab.Index(btn_save.TabIndex);
            btn_saveprint.Name = "btn_saveprint";
            btn_saveprint.Text = "&SAVE + PRINT ";
            btn_saveprint.Themes = XTheme.PinkBtn;
            btn_saveprint.Click += new EventHandler(Btn_saveprint_click);

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

            #endregion[finner_panel]

            #region [FQuotation]

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.split_container);
            this.Name = "fQuotation";
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

        private void Txt_ledger_id_TextChanged(object sender, EventArgs e)
        {
            txt_additional.Text = CInvoice_exten.FindInvoiceGstTotal(txt_ledger_id.Text);
        }

        #region[Init Grid]

        private void InitGrid()
        {
            editgrid.RowsRemoved += new DataGridViewRowsRemovedEventHandler(Editgrid_RowsRemoved);
            editgrid.CellValidating += new DataGridViewCellValidatingEventHandler(Editgrid_CellValidating);
            editgrid.CellValueChanged += new DataGridViewCellEventHandler(Editgrid_CellValueChanged);
            editgrid.CurrentCellChanged += new EventHandler(Editgrid_CurrentCellChanged);

            DataGridViewTextBoxColumn col_Quotationitems_Id = new DataGridViewTextBoxColumn();
            col_Quotationitems_Id.Name = QUOTATIONITEMS.QUOTATIONITEMS_ID;
            col_Quotationitems_Id.HeaderText = "QUOTATIONITEMS_ID ";
            col_Quotationitems_Id.Visible = false;
            col_Quotationitems_Id.Width = 100;
            col_Quotationitems_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Quotationitems_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Quotationitems_Id);

            DataGridViewTextBoxColumn col_Quotation_Id = new DataGridViewTextBoxColumn();
            col_Quotation_Id.Name = QUOTATIONITEMS.QUOTATION_ID;
            col_Quotation_Id.HeaderText = "QUOTATION_ID ";
            col_Quotation_Id.Visible = false;
            col_Quotation_Id.Width = 100;
            col_Quotation_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Quotation_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Quotation_Id);

            DataGridViewTextBoxColumn col_slno = new DataGridViewTextBoxColumn();
            col_slno.Name = Core.SLNO;
            col_slno.HeaderText = "S.NO";
            //col_slno.Visible = false; 
            col_slno.ReadOnly = true;
            col_slno.Width = 50;
            col_slno.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_slno.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_slno);

            DataGridViewTextBoxColumn col_Product_id = new DataGridViewTextBoxColumn();
            col_Product_id.Name = QUOTATIONITEMS.PRODUCT_ID;
            col_Product_id.HeaderText = "PARTICULARS";
            //col_Product_id.Visible = false; 
            col_Product_id.Width = 600;
            col_Product_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Product_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Product_id);

            DataGridViewTextBoxColumn col_Sizes_id = new DataGridViewTextBoxColumn();
            col_Sizes_id.Name = QUOTATIONITEMS.SIZES_ID;
            col_Sizes_id.HeaderText = "SIZE";
            //col_Sizes_id.Visible = false; 
            col_Sizes_id.Width = 100;
            col_Sizes_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Sizes_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Sizes_id);

            DataGridViewTextBoxColumn col_Qty = new DataGridViewTextBoxColumn();
            col_Qty.Name = QUOTATIONITEMS.QTY;
            col_Qty.HeaderText = "QTY";
            //col_Qty.Visible = false; 
            col_Qty.Width = 100;
            col_Qty.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Qty.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Qty);

            DataGridViewTextBoxColumn col_Price = new DataGridViewTextBoxColumn();
            col_Price.Name = QUOTATIONITEMS.PRICE;
            col_Price.HeaderText = "PRICE";
            //col_Price.Visible = false; 
            col_Price.Width = 100;
            col_Price.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            col_Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Price);

            //DataGridViewTextBoxColumn col_Sgst_percent = new DataGridViewTextBoxColumn();
            //col_Sgst_percent.Name = QUOTATIONITEMS.SGST_PERCENT;
            //col_Sgst_percent.HeaderText = "SGST   %";
            ////col_Sgst_percent.Visible = false; 
            //col_Sgst_percent.Width = 100;
            //col_Sgst_percent.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //col_Sgst_percent.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //editgrid.Columns.Add(col_Sgst_percent);

            //DataGridViewTextBoxColumn col_Cgst_percent = new DataGridViewTextBoxColumn();
            //col_Cgst_percent.Name = QUOTATIONITEMS.CGST_PERCENT;
            //col_Cgst_percent.HeaderText = "CGST   %";
            ////col_Cgst_percent.Visible = false; 
            //col_Cgst_percent.Width = 100;
            //col_Cgst_percent.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //col_Cgst_percent.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //editgrid.Columns.Add(col_Cgst_percent);

            //DataGridViewTextBoxColumn col_Igst_percent = new DataGridViewTextBoxColumn();
            //col_Igst_percent.Name = QUOTATIONITEMS.IGST_PERCENT;
            //col_Igst_percent.HeaderText = "IGST    %";
            ////col_Igst_percent.Visible = false; 
            //col_Igst_percent.Width = 100;
            //col_Igst_percent.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //col_Igst_percent.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //editgrid.Columns.Add(col_Igst_percent);

            DataGridViewTextBoxColumn col_TAXABLEAMOUNT = new DataGridViewTextBoxColumn();
            col_TAXABLEAMOUNT.Name = QUOTATIONITEMS.TAXABLEAMOUNT;
            col_TAXABLEAMOUNT.HeaderText = "Value";
            col_TAXABLEAMOUNT.Visible = false;
            col_TAXABLEAMOUNT.Width = 100;
            col_TAXABLEAMOUNT.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_TAXABLEAMOUNT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_TAXABLEAMOUNT);

            //DataGridViewTextBoxColumn col_SGST_AMOUNT = new DataGridViewTextBoxColumn();
            //col_SGST_AMOUNT.Name = QUOTATIONITEMS.SGST_AMOUNT;
            //col_SGST_AMOUNT.HeaderText = "SGST_AMOUNT";
            //col_SGST_AMOUNT.Visible = false;
            //col_SGST_AMOUNT.Width = 100;
            //col_SGST_AMOUNT.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //col_SGST_AMOUNT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //editgrid.Columns.Add(col_SGST_AMOUNT);

            //DataGridViewTextBoxColumn col_CGST_AMOUNT = new DataGridViewTextBoxColumn();
            //col_CGST_AMOUNT.Name = QUOTATIONITEMS.CGST_AMOUNT;
            //col_CGST_AMOUNT.HeaderText = "CGST_AMOUNT";
            //col_CGST_AMOUNT.Visible = false;
            //col_CGST_AMOUNT.Width = 100;
            //col_CGST_AMOUNT.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //col_CGST_AMOUNT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //editgrid.Columns.Add(col_CGST_AMOUNT);

            //DataGridViewTextBoxColumn col_IGST_AMOUNT = new DataGridViewTextBoxColumn();
            //col_IGST_AMOUNT.Name = QUOTATIONITEMS.IGST_AMOUNT;
            //col_IGST_AMOUNT.HeaderText = "IGST_AMOUNT";
            //col_IGST_AMOUNT.Visible = false;
            //col_IGST_AMOUNT.Width = 100;
            //col_IGST_AMOUNT.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //col_IGST_AMOUNT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //editgrid.Columns.Add(col_IGST_AMOUNT);

            //if (txt_taxtype_id.Text == Core.SGST)
            //{
            //    col_Sgst_percent.Visible = true;
            //    col_Cgst_percent.Visible = true;
            //    col_Igst_percent.Visible = false;
            //}
            //else
            //{
            //    col_Sgst_percent.Visible = false;
            //    col_Cgst_percent.Visible = false;
            //    col_Igst_percent.Visible = true;
            //}

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
