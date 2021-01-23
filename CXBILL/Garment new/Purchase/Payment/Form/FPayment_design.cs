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
    public partial class FPayment : UserControl
    {
        public FPayment()
        {
            InitializeComponent();
            Initialize();
            InitGrid();
            Setactives();
            SetFocus();
            Party_lookup();
            Receipttype_lookup();
            Bank_lookup();
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

        private XTextBox txt_payment_no;
        private XLabel lbl_payment_no;
        private xDatepicker txt_payment_date;
        private XLabel lbl_payment_date;
        private LookupBox txt_party_id;
        private XLabel lbl_party_id;
        private LookupBox txt_receipttype_id;
        private XLabel lbl_receipttype_id;
        private XTextBox txt_cheq_no;
        private XLabel lbl_cheq_no;
        private XTextBox txt_payment_amount;
        private XLabel lbl_payment_amount;
        private XTextBox txt_cheq_date;
        private XLabel lbl_cheq_date;
        private LookupBox txt_bank_id;
        private XLabel lbl_bank_id;
        private EditGridView editgrid;
        private XTextBox txt_total_amount;
        private XLabel lbl_total_amount;

        private RichTextBox txt_notes;
        private XLabel lbl_notes;
        private OfficeButton btn_save;
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

            txt_payment_no = new XTextBox();
            lbl_payment_no = new XLabel();
            txt_payment_date = new xDatepicker();
            lbl_payment_date = new XLabel();
            txt_party_id = new LookupBox();
            lbl_party_id = new XLabel();
            txt_receipttype_id = new LookupBox();
            lbl_receipttype_id = new XLabel();
            txt_cheq_no = new XTextBox();
            lbl_cheq_no = new XLabel();
            txt_payment_amount = new XTextBox();
            lbl_payment_amount = new XLabel();
            txt_cheq_date = new XTextBox();
            lbl_cheq_date = new XLabel();
            txt_bank_id = new LookupBox();
            lbl_bank_id = new XLabel();
            editgrid = new EditGridView();
            txt_total_amount = new XTextBox();
            lbl_total_amount = new XLabel();

            txt_notes = new RichTextBox();
            lbl_notes = new XLabel();
            btn_save = new OfficeButton();
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

            finner_panel.Controls.Add(txt_notes);
            finner_panel.Controls.Add(lbl_notes);
            finner_panel.Controls.Add(txt_payment_no);
            finner_panel.Controls.Add(lbl_payment_no);
            finner_panel.Controls.Add(txt_payment_date);
            finner_panel.Controls.Add(lbl_payment_date);
            finner_panel.Controls.Add(txt_party_id);
            finner_panel.Controls.Add(lbl_party_id);
            finner_panel.Controls.Add(txt_receipttype_id);
            finner_panel.Controls.Add(lbl_receipttype_id);
            finner_panel.Controls.Add(txt_cheq_no);
            finner_panel.Controls.Add(lbl_cheq_no);
            finner_panel.Controls.Add(txt_payment_amount);
            finner_panel.Controls.Add(lbl_payment_amount);
            finner_panel.Controls.Add(txt_cheq_date);
            finner_panel.Controls.Add(lbl_cheq_date);
            finner_panel.Controls.Add(txt_bank_id);
            finner_panel.Controls.Add(lbl_bank_id);
            finner_panel.Controls.Add(txt_total_amount);
            finner_panel.Controls.Add(lbl_total_amount);
            finner_panel.Controls.Add(editgrid);
            finner_panel.Controls.Add(btn_save);
            finner_panel.Controls.Add(btn_active);

            #endregion[adding controls]

            #region[Header]

            btn_close.Click += new EventHandler(Btn_close_Click);

            lbl_header.Text = "Payment";

            #endregion[Header]

            #region[Properties of control]

            lbl_payment_no.Font = XFont.Font_10B;
            lbl_payment_no.Name = "lbl_receipt_no";
            lbl_payment_no.Text = "   Payment no";
            lbl_payment_no.Anchor = XAnchor.LT;
            lbl_payment_no.TextAlign = ContentAlignment.MiddleLeft;
            lbl_payment_no.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_payment_no.Size = XSize.OneLabel;
            lbl_payment_no.Location = XLayout.FirstLabel;

            txt_payment_no.Font = XFont.TxtFont;
            txt_payment_no.ForeColor = XFontColor.TxtFontColor;
            txt_payment_no.BackColor = XTheme.TxtBackcolor;
            txt_payment_no.Name = "txt_receipt_no";
            txt_payment_no.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_payment_no.TextAlign = HorizontalAlignment.Left;
            txt_payment_no.Size = XSize.TwoText;
            txt_payment_no.Anchor = XAnchor.LT;
            txt_payment_no.Location = XLayout.FirstText;
            txt_payment_no.TabIndex = XTab.Txt_TabIndex;
            txt_payment_no.Enter += new EventHandler(Txt_receipt_no_Enter);


            lbl_payment_date.Font = XFont.Font_10B;
            lbl_payment_date.Name = "lbl_receipt_date";
            lbl_payment_date.Text = "   Payment date";
            lbl_payment_date.Anchor = XAnchor.LT;
            lbl_payment_date.TextAlign = ContentAlignment.MiddleLeft;
            lbl_payment_date.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_payment_date.Size = XSize.TwoLabel;
            lbl_payment_date.Location = XLayout.R1_2Label_2(lbl_payment_no.Location);

            txt_payment_date.Font = XFont.TxtFont;
            txt_payment_date.ForeColor = XFontColor.TxtFontColor;
            txt_payment_date.BackColor = XTheme.TxtBackcolor;
            txt_payment_date.Name = "txt_receipt_date";
            txt_payment_date.CustomFormat = "dd-MM-yyyy";
            txt_payment_date.Format = DateTimePickerFormat.Custom;
            txt_payment_date.Size = XSize.TwoText;
            txt_payment_date.Anchor = XAnchor.LTR;
            txt_payment_date.Location = XLayout.R1_2Text_2(txt_payment_no.Location);
            txt_payment_date.TabIndex = XTab.Index(txt_payment_no.TabIndex);
            txt_payment_date.Enter += new EventHandler(Txt_receipt_date_Enter);


            lbl_party_id.Font = XFont.Font_10B;
            lbl_party_id.Name = "lbl_party_id";
            lbl_party_id.Text = "   Party";
            lbl_party_id.Anchor = XAnchor.LT;
            lbl_party_id.TextAlign = ContentAlignment.MiddleLeft;
            lbl_party_id.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_party_id.Size = XSize.OneLabel;
            lbl_party_id.Location = XLayout.R1_Label(lbl_payment_date.Location);

            txt_party_id.Font = XFont.TxtFont;
            txt_party_id.ForeColor = XFontColor.TxtFontColor;
            txt_party_id.BackColor = XTheme.TxtBackcolor;
            txt_party_id.Name = "txt_party_id";
            txt_party_id.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_party_id.TextAlign = HorizontalAlignment.Left;
            txt_party_id.Size = XSize.OneText;
            txt_party_id.Anchor = XAnchor.LTR;
            txt_party_id.Location = XLayout.R1_Text(txt_payment_date.Location);
            txt_party_id.TabIndex = XTab.Index(txt_payment_date.TabIndex);
            txt_party_id.Enter += new EventHandler(Txt_party_id_Enter);


            lbl_receipttype_id.Font = XFont.Font_10B;
            lbl_receipttype_id.Name = "lbl_receipttype_id";
            lbl_receipttype_id.Text = "Payment type";
            lbl_receipttype_id.Anchor = XAnchor.LT;
            lbl_receipttype_id.TextAlign = ContentAlignment.MiddleLeft;
            lbl_receipttype_id.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_receipttype_id.Size = XSize.OneLabel;
            lbl_receipttype_id.Location = XLayout.R2_2Label_1(lbl_party_id.Location);

            txt_receipttype_id.Font = XFont.TxtFont;
            txt_receipttype_id.ForeColor = XFontColor.TxtFontColor;
            txt_receipttype_id.BackColor = XTheme.TxtBackcolor;
            txt_receipttype_id.Name = "txt_receipttype_id";
            txt_receipttype_id.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_receipttype_id.TextAlign = HorizontalAlignment.Left;
            txt_receipttype_id.Size = XSize.TwoText;
            txt_receipttype_id.Anchor = XAnchor.LT;
            txt_receipttype_id.Location = XLayout.R2_2Text_1(txt_party_id.Location);
            txt_receipttype_id.TabIndex = XTab.Index(txt_party_id.TabIndex);
            txt_receipttype_id.Enter += new EventHandler(Txt_receipttype_id_Enter);
            txt_receipttype_id.TextChanged += Txt_receipttype_id_TextChanged;


            lbl_cheq_no.Font = XFont.Font_10B;
            lbl_cheq_no.Name = "lbl_cheq_no";
            lbl_cheq_no.Text = "   Cheq no";
            lbl_cheq_no.Anchor = XAnchor.LT;
            lbl_cheq_no.TextAlign = ContentAlignment.MiddleLeft;
            lbl_cheq_no.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_cheq_no.Size = XSize.OneLabel;
            lbl_cheq_no.Location = XLayout.R2_2Label_1(lbl_receipttype_id.Location);

            txt_cheq_no.Font = XFont.TxtFont;
            txt_cheq_no.ForeColor = XFontColor.TxtFontColor;
            txt_cheq_no.BackColor = XTheme.TxtBackcolor;
            txt_cheq_no.Name = "txt_cheq_no";
            txt_cheq_no.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_cheq_no.TextAlign = HorizontalAlignment.Left;
            txt_cheq_no.Size = XSize.TwoText;
            txt_cheq_no.Anchor = XAnchor.LT;
            txt_cheq_no.Location = XLayout.R2_2Text_1(txt_receipttype_id.Location);
            txt_cheq_no.TabIndex = XTab.Index(txt_receipttype_id.TabIndex);
            txt_cheq_no.Enter += new EventHandler(Txt_cheq_no_Enter);


            lbl_payment_amount.Font = XFont.Font_10B;
            lbl_payment_amount.Name = "lbl_receipt_amount";
            lbl_payment_amount.Text = "       Amount";
            lbl_payment_amount.Anchor = XAnchor.LT;
            lbl_payment_amount.TextAlign = ContentAlignment.MiddleLeft;
            lbl_payment_amount.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_payment_amount.Size = new Size(XSize.TwoLabelWidth, 48);
            lbl_payment_amount.Location = XLayout.R2_2Label_2(lbl_receipttype_id.Location);

            txt_payment_amount.Font = XFont.Font_20B;
            txt_payment_amount.ForeColor = XFontColor.TxtFontColor;
            txt_payment_amount.BackColor = XTheme.TxtBackcolor;
            txt_payment_amount.Name = "txt_receipt_amount";
            txt_payment_amount.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_payment_amount.TextAlign = HorizontalAlignment.Right;
            txt_payment_amount.Size = new Size(XSize.TwoTxtColumn, 56);
            txt_payment_amount.Anchor = XAnchor.LTR;
            txt_payment_amount.Location = XLayout.R2_2Text_2(txt_receipttype_id.Location);
            txt_payment_amount.TabIndex = XTab.Index(txt_cheq_no.TabIndex);
            txt_payment_amount.Enter += new EventHandler(Txt_receipt_amount_Enter);


            lbl_cheq_date.Font = XFont.Font_10B;
            lbl_cheq_date.Name = "lbl_cheq_date";
            lbl_cheq_date.Text = "   Cheq date";
            lbl_cheq_date.Anchor = XAnchor.LT;
            lbl_cheq_date.TextAlign = ContentAlignment.MiddleLeft;
            lbl_cheq_date.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_cheq_date.Size = XSize.OneLabel;
            lbl_cheq_date.Location = XLayout.R2_2Label_1(lbl_cheq_no.Location);

            txt_cheq_date.Font = XFont.TxtFont;
            txt_cheq_date.ForeColor = XFontColor.TxtFontColor;
            txt_cheq_date.BackColor = XTheme.TxtBackcolor;
            txt_cheq_date.Name = "txt_cheq_date";
            txt_cheq_date.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_cheq_date.TextAlign = HorizontalAlignment.Left;
            txt_cheq_date.Size = XSize.TwoText;
            txt_cheq_date.Anchor = XAnchor.LT;
            txt_cheq_date.Location = XLayout.R2_2Text_1(txt_cheq_no.Location);
            txt_cheq_date.TabIndex = XTab.Index(txt_payment_amount.TabIndex);
            txt_cheq_date.Enter += new EventHandler(Txt_cheq_date_Enter);


            lbl_bank_id.Font = XFont.Font_10B;
            lbl_bank_id.Name = "lbl_bank_id";
            lbl_bank_id.Text = "   Bank";
            lbl_bank_id.Anchor = XAnchor.LT;
            lbl_bank_id.TextAlign = ContentAlignment.MiddleLeft;
            lbl_bank_id.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_bank_id.Size = XSize.OneLabel;
            lbl_bank_id.Location = XLayout.R2_2Label_1(lbl_cheq_date.Location);

            txt_bank_id.Font = XFont.TxtFont;
            txt_bank_id.ForeColor = XFontColor.TxtFontColor;
            txt_bank_id.BackColor = XTheme.TxtBackcolor;
            txt_bank_id.Name = "txt_bank_id";
            txt_bank_id.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_bank_id.TextAlign = HorizontalAlignment.Left;
            txt_bank_id.Size = XSize.TwoText;
            txt_bank_id.Anchor = XAnchor.LT;
            txt_bank_id.Location = XLayout.R2_2Text_1(txt_cheq_date.Location);
            txt_bank_id.TabIndex = XTab.Index(txt_cheq_date.TabIndex);
            txt_bank_id.Enter += new EventHandler(Txt_bank_id_Enter);

            editgrid.Location = new Point(XLayout.H_left, lbl_bank_id.Bottom + 10);
            editgrid.Name = "editgrid";
            editgrid.Size = new Size(finner_panel.Width - 50, 220);
            editgrid.TabIndex = XTab.Index(txt_bank_id.TabIndex);
            editgrid.RowsLimit = 12;
            Point p = new Point(editgrid.Left, editgrid.Bottom - 10);

            lbl_total_amount.Font = XFont.Font_10B;
            lbl_total_amount.Name = "lbl_total_amount";
            lbl_total_amount.Text = "Total amount";
            lbl_total_amount.Anchor = XAnchor.LT;
            lbl_total_amount.TextAlign = ContentAlignment.MiddleLeft;
            lbl_total_amount.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_total_amount.Size = XSize.FourLabel;
            lbl_total_amount.Location = XLayout.R2_4Label_4(p);

            txt_total_amount.Font = XFont.TxtFont;
            txt_total_amount.ForeColor = XFontColor.TxtFontColor;
            txt_total_amount.BackColor = XTheme.TxtBackcolor;
            txt_total_amount.Name = "txt_total_amount";
            txt_total_amount.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_total_amount.ReadOnly = true;
            txt_total_amount.Cursor = Cursors.No;
            txt_total_amount.TextAlign = HorizontalAlignment.Right;
            txt_total_amount.Size = XSize.FourText;
            txt_total_amount.Anchor = XAnchor.LTR;
            txt_total_amount.Location = XLayout.R2_4Text_4(p);
            txt_total_amount.TabIndex = XTab.Index(editgrid.TabIndex + 5);
            txt_total_amount.Enter += new EventHandler(Txt_total_amount_Enter);


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
            txt_notes.TabIndex = XTab.Index(txt_total_amount.TabIndex);
            txt_notes.Enter += new EventHandler(Txt_notes_Enter);

            #endregion[Properties of control]

            #region[Properties of btn]

            btn_save.Anchor = XAnchor.RB;
            btn_save.Font = XFont.BtnFont;
            btn_save.Size = XSize.BtnOne;
            btn_save.Location = XLayout.BtnSave;
            btn_save.TabIndex = XTab.Index(editgrid.TabIndex);
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

            #endregion[finner_panel]

            #region [FPayment]

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.split_container);
            this.Name = "fPayment";
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
            //editgrid.CellValidating += new DataGridViewCellValidatingEventHandler(Editgrid_CellValidating);
            editgrid.CellValueChanged += new DataGridViewCellEventHandler(Editgrid_CellValueChanged);
            editgrid.CurrentCellChanged += new EventHandler(Editgrid_CurrentCellChanged);

            DataGridViewTextBoxColumn col_Paymentitems_Id = new DataGridViewTextBoxColumn();
            col_Paymentitems_Id.Name = PAYMENTITEMS.PAYMENTITEMS_ID;
            col_Paymentitems_Id.HeaderText = "PAYMENTITEMS_ID ";
            col_Paymentitems_Id.Visible = false;
            col_Paymentitems_Id.Width = 100;
            col_Paymentitems_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Paymentitems_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Paymentitems_Id);

            DataGridViewTextBoxColumn col_slno = new DataGridViewTextBoxColumn();
            col_slno.Name = Core.SLNO;
            col_slno.HeaderText = "S.NO";
            //col_slno.Visible = false; 
            col_slno.ReadOnly = true;
            col_slno.Width = 50;
            col_slno.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_slno.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_slno);

            DataGridViewTextBoxColumn col_Payment_id = new DataGridViewTextBoxColumn();
            col_Payment_id.Name = PAYMENTITEMS.PAYMENT_ID;
            col_Payment_id.HeaderText = "PAYMENT";
            col_Payment_id.Visible = false;
            col_Payment_id.Width = 280;
            col_Payment_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Payment_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Payment_id);

            DataGridViewTextBoxColumn col_Payment_by = new DataGridViewTextBoxColumn();
            col_Payment_by.Name = PAYMENTITEMS.PAYMENT_BY;
            col_Payment_by.HeaderText = "PAYMENT BY";
            //col_Payment_by.Visible = false; 
            col_Payment_by.Width = 300;
            col_Payment_by.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Payment_by.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Payment_by);

            DataGridViewTextBoxColumn col_Invoiced_no = new DataGridViewTextBoxColumn();
            col_Invoiced_no.Name = PAYMENTITEMS.PURCHASE_NO;
            col_Invoiced_no.HeaderText = "PURCHASE NO";
            //col_Invoiced_no.Visible = false; 
            col_Invoiced_no.Width = 300;
            col_Invoiced_no.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Invoiced_no.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Invoiced_no);

            DataGridViewTextBoxColumn col_Invoiced_amount = new DataGridViewTextBoxColumn();
            col_Invoiced_amount.Name = PAYMENTITEMS.PURCHASE_AMOUNT;
            col_Invoiced_amount.HeaderText = "PURCHASE AMOUNT";
            //col_Invoiced_amount.Visible = false; 
            col_Invoiced_amount.Width = 300;
            col_Invoiced_amount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            col_Invoiced_amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Invoiced_amount);

            DataGridViewTextBoxColumn col_Payment_amount = new DataGridViewTextBoxColumn();
            col_Payment_amount.Name = PAYMENTITEMS.PAYMENT_AMOUNT;
            col_Payment_amount.HeaderText = "PAYMENT AMOUNT";
            //col_Payment_amount.Visible = false; 
            col_Payment_amount.Width = 300;
            col_Payment_amount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            col_Payment_amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Payment_amount);


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

        private void Txt_receipttype_id_TextChanged(object sender, EventArgs e)
        {

            if (txt_receipttype_id.Text.ToUpper() == "CASH")
            {
                txt_cheq_no.Enabled = false;
                txt_cheq_date.Enabled = false;
                //txt_cheq_datepick.Enabled = false;
                txt_cheq_date.Text = "";
                txt_bank_id.Enabled = false;
            }
            else if (txt_receipttype_id.Text.ToUpper() == "CHEQUE")
            {
                txt_cheq_no.Enabled = true;
                txt_cheq_date.Enabled = true;
                //txt_cheq_datepick.Enabled = true;
                txt_bank_id.Enabled = true;

            }
        }

    }//cls 
}//ns 
