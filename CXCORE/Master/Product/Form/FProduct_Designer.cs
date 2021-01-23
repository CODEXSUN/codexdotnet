// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 10:23:39 PM

using System;
using System.Windows.Forms;
using CXLIB;
using System.Drawing;
using System.ComponentModel;

namespace CXCORE
{
    public partial class FProduct : UserControl
    {
        public FProduct()
        {
            InitializeComponent();
            Initialize();
            Setactives();
            SetFocus();
            Producttype_lookup();
            Hsncode_lookup();
            Unit_lookup();
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

        private XTextBox txt_product_name;
        private XLabel lbl_product_name;
        private LookupBox txt_producttype_id;
        private XLabel lbl_producttype_id;
        private LookupBox txt_hsncode_id;
        private XLabel lbl_hsncode_id;
        private LookupBox txt_unit_id;
        private XLabel lbl_unit_id;
        private XTextBox txt_purchase_price;
        private XLabel lbl_purchase_price;
        private XTextBox txt_selling_price;
        private XLabel lbl_selling_price;
        private XTextBox txt_sgst_percent;
        private XLabel lbl_sgst_percent;
        private XTextBox txt_cgst_percent;
        private XLabel lbl_cgst_percent;
        private XTextBox txt_igst_percent;
        private XLabel lbl_igst_percent;
        private XTextBox txt_opening_stock;
        private XLabel lbl_opening_stock;
        private XTextBox txt_opening_price;
        private XLabel lbl_opening_price;

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

            txt_product_name = new XTextBox();
            lbl_product_name = new XLabel();
            txt_producttype_id = new LookupBox();
            lbl_producttype_id = new XLabel();
            txt_hsncode_id = new LookupBox();
            lbl_hsncode_id = new XLabel();
            txt_unit_id = new LookupBox();
            lbl_unit_id = new XLabel();
            txt_purchase_price = new XTextBox();
            lbl_purchase_price = new XLabel();
            txt_selling_price = new XTextBox();
            lbl_selling_price = new XLabel();
            txt_sgst_percent = new XTextBox();
            lbl_sgst_percent = new XLabel();
            txt_cgst_percent = new XTextBox();
            lbl_cgst_percent = new XLabel();
            txt_igst_percent = new XTextBox();
            lbl_igst_percent = new XLabel();
            txt_opening_stock = new XTextBox();
            lbl_opening_stock = new XLabel();
            txt_opening_price = new XTextBox();
            lbl_opening_price = new XLabel();

            txt_notes = new RichTextBox();
            lbl_notes = new XLabel();
            btn_save = new OfficeButton();
            btn_active = new OfficeButton();

            #endregion[declare new]

            #region[container suspend]

            ((ISupportInitialize)(split_container)).BeginInit();
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
            finner_panel.Controls.Add(txt_product_name);
            finner_panel.Controls.Add(lbl_product_name);
            finner_panel.Controls.Add(txt_producttype_id);
            finner_panel.Controls.Add(lbl_producttype_id);
            finner_panel.Controls.Add(txt_hsncode_id);
            finner_panel.Controls.Add(lbl_hsncode_id);
            finner_panel.Controls.Add(txt_unit_id);
            finner_panel.Controls.Add(lbl_unit_id);
            finner_panel.Controls.Add(txt_purchase_price);
            finner_panel.Controls.Add(lbl_purchase_price);
            finner_panel.Controls.Add(txt_selling_price);
            finner_panel.Controls.Add(lbl_selling_price);
            finner_panel.Controls.Add(txt_sgst_percent);
            finner_panel.Controls.Add(lbl_sgst_percent);
            finner_panel.Controls.Add(txt_cgst_percent);
            finner_panel.Controls.Add(lbl_cgst_percent);
            finner_panel.Controls.Add(txt_igst_percent);
            finner_panel.Controls.Add(lbl_igst_percent);
            finner_panel.Controls.Add(txt_opening_stock);
            finner_panel.Controls.Add(lbl_opening_stock);
            finner_panel.Controls.Add(txt_opening_price);
            finner_panel.Controls.Add(lbl_opening_price);
            finner_panel.Controls.Add(btn_save);
            finner_panel.Controls.Add(btn_active);

            #endregion[adding controls]

            #region[Header]

            btn_close.Click += new EventHandler(Btn_close_Click);

            lbl_header.Text = "Product";

            #endregion[Header]

            #region[Properties of control]

            lbl_product_name.Font = XFont.Font_10B;
            lbl_product_name.Name = "lbl_product_name";
            lbl_product_name.Text = "   Product";
            lbl_product_name.Anchor = XAnchor.LT;
            lbl_product_name.TextAlign = ContentAlignment.MiddleLeft;
            lbl_product_name.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_product_name.Size = XSize.OneLabel;
            lbl_product_name.Location = XLayout.FirstLabel;

            txt_product_name.Font = XFont.TxtFont;
            txt_product_name.ForeColor = XFontColor.TxtFontColor;
            txt_product_name.BackColor = XTheme.TxtBackcolor;
            txt_product_name.Name = "txt_product_name";
            txt_product_name.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_product_name.Size = XSize.OneText;
            txt_product_name.Anchor = XAnchor.LTR;
            txt_product_name.Location = XLayout.FirstText;
            txt_product_name.TabIndex = XTab.Txt_TabIndex;
            txt_product_name.Enter += new EventHandler(Txt_product_name_Enter);


            lbl_producttype_id.Font = XFont.Font_10B;
            lbl_producttype_id.Name = "lbl_producttype_id";
            lbl_producttype_id.Text = "   Product type";
            lbl_producttype_id.Anchor = XAnchor.LT;
            lbl_producttype_id.TextAlign = ContentAlignment.MiddleLeft;
            lbl_producttype_id.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_producttype_id.Size = XSize.OneLabel;
            lbl_producttype_id.Location = XLayout.R1_Label(lbl_product_name.Location);

            txt_producttype_id.Font = XFont.TxtFont;
            txt_producttype_id.ForeColor = XFontColor.TxtFontColor;
            txt_producttype_id.BackColor = XTheme.TxtBackcolor;
            txt_producttype_id.Name = "txt_producttype_id";
            txt_producttype_id.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_producttype_id.Size = XSize.OneText;
            txt_producttype_id.Anchor = XAnchor.LTR;
            txt_producttype_id.Location = XLayout.R1_Text(txt_product_name.Location);
            txt_producttype_id.TabIndex = XTab.Index(txt_product_name.TabIndex);
            txt_producttype_id.Enter += new EventHandler(Txt_producttype_id_Enter);


            lbl_hsncode_id.Font = XFont.Font_10B;
            lbl_hsncode_id.Name = "lbl_hsncode_id";
            lbl_hsncode_id.Text = "   Hsn code";
            lbl_hsncode_id.Anchor = XAnchor.LT;
            lbl_hsncode_id.TextAlign = ContentAlignment.MiddleLeft;
            lbl_hsncode_id.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_hsncode_id.Size = XSize.OneLabel;
            lbl_hsncode_id.Location = XLayout.R1_Label(lbl_producttype_id.Location);

            txt_hsncode_id.Font = XFont.TxtFont;
            txt_hsncode_id.ForeColor = XFontColor.TxtFontColor;
            txt_hsncode_id.BackColor = XTheme.TxtBackcolor;
            txt_hsncode_id.Name = "txt_hsncode_id";
            txt_hsncode_id.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_hsncode_id.Size = XSize.OneText;
            txt_hsncode_id.Anchor = XAnchor.LTR;
            txt_hsncode_id.Location = XLayout.R1_Text(txt_producttype_id.Location);
            txt_hsncode_id.TabIndex = XTab.Index(txt_producttype_id.TabIndex);
            txt_hsncode_id.Enter += new EventHandler(Txt_hsncode_id_Enter);


            lbl_unit_id.Font = XFont.Font_10B;
            lbl_unit_id.Name = "lbl_unit_id";
            lbl_unit_id.Text = "   Unit";
            lbl_unit_id.Anchor = XAnchor.LT;
            lbl_unit_id.TextAlign = ContentAlignment.MiddleLeft;
            lbl_unit_id.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_unit_id.Size = XSize.OneLabel;
            lbl_unit_id.Location = XLayout.R1_Label(lbl_hsncode_id.Location);

            txt_unit_id.Font = XFont.TxtFont;
            txt_unit_id.ForeColor = XFontColor.TxtFontColor;
            txt_unit_id.BackColor = XTheme.TxtBackcolor;
            txt_unit_id.Name = "txt_unit_id";
            txt_unit_id.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_unit_id.Size = XSize.OneText;
            txt_unit_id.Anchor = XAnchor.LTR;
            txt_unit_id.Location = XLayout.R1_Text(txt_hsncode_id.Location);
            txt_unit_id.TabIndex = XTab.Index(txt_hsncode_id.TabIndex);
            txt_unit_id.Enter += new EventHandler(Txt_unit_id_Enter);


            lbl_purchase_price.Font = XFont.Font_10B;
            lbl_purchase_price.Name = "lbl_purchase_price";
            lbl_purchase_price.Text = "   Purchase price";
            lbl_purchase_price.Anchor = XAnchor.LT;
            lbl_purchase_price.TextAlign = ContentAlignment.MiddleLeft;
            lbl_purchase_price.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_purchase_price.Size = XSize.OneLabel;
            lbl_purchase_price.Location = XLayout.R1_Label(lbl_unit_id.Location);

            txt_purchase_price.Font = XFont.TxtFont;
            txt_purchase_price.ForeColor = XFontColor.TxtFontColor;
            txt_purchase_price.BackColor = XTheme.TxtBackcolor;
            txt_purchase_price.Name = "txt_purchase_price";
            txt_purchase_price.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_purchase_price.Size = XSize.OneText;
            txt_purchase_price.Anchor = XAnchor.LTR;
            txt_purchase_price.Location = XLayout.R1_Text(txt_unit_id.Location);
            txt_purchase_price.TabIndex = XTab.Index(txt_unit_id.TabIndex);
            txt_purchase_price.Enter += new EventHandler(Txt_purchase_price_Enter);


            lbl_selling_price.Font = XFont.Font_10B;
            lbl_selling_price.Name = "lbl_selling_price";
            lbl_selling_price.Text = "   Selling price";
            lbl_selling_price.Anchor = XAnchor.LT;
            lbl_selling_price.TextAlign = ContentAlignment.MiddleLeft;
            lbl_selling_price.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_selling_price.Size = XSize.OneLabel;
            lbl_selling_price.Location = XLayout.R1_Label(lbl_purchase_price.Location);

            txt_selling_price.Font = XFont.TxtFont;
            txt_selling_price.ForeColor = XFontColor.TxtFontColor;
            txt_selling_price.BackColor = XTheme.TxtBackcolor;
            txt_selling_price.Name = "txt_selling_price";
            txt_selling_price.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_selling_price.Size = XSize.OneText;
            txt_selling_price.Anchor = XAnchor.LTR;
            txt_selling_price.Location = XLayout.R1_Text(txt_purchase_price.Location);
            txt_selling_price.TabIndex = XTab.Index(txt_purchase_price.TabIndex);
            txt_selling_price.Enter += new EventHandler(Txt_selling_price_Enter);


            lbl_sgst_percent.Font = XFont.Font_10B;
            lbl_sgst_percent.Name = "lbl_sgst_percent";
            lbl_sgst_percent.Text = "   Sgst    %";
            lbl_sgst_percent.Anchor = XAnchor.LT;
            lbl_sgst_percent.TextAlign = ContentAlignment.MiddleLeft;
            lbl_sgst_percent.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_sgst_percent.Size = XSize.OneLabel;
            lbl_sgst_percent.Location = XLayout.R1_Label(lbl_selling_price.Location);

            txt_sgst_percent.Font = XFont.TxtFont;
            txt_sgst_percent.ForeColor = XFontColor.TxtFontColor;
            txt_sgst_percent.BackColor = XTheme.TxtBackcolor;
            txt_sgst_percent.Name = "txt_sgst_percent";
            txt_sgst_percent.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_sgst_percent.Size = XSize.OneText;
            txt_sgst_percent.Anchor = XAnchor.LTR;
            txt_sgst_percent.Location = XLayout.R1_Text(txt_selling_price.Location);
            txt_sgst_percent.TabIndex = XTab.Index(txt_selling_price.TabIndex);
            txt_sgst_percent.Enter += new EventHandler(Txt_sgst_percent_Enter);


            lbl_cgst_percent.Font = XFont.Font_10B;
            lbl_cgst_percent.Name = "lbl_cgst_percent";
            lbl_cgst_percent.Text = "   Cgst    %";
            lbl_cgst_percent.Anchor = XAnchor.LT;
            lbl_cgst_percent.TextAlign = ContentAlignment.MiddleLeft;
            lbl_cgst_percent.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_cgst_percent.Size = XSize.OneLabel;
            lbl_cgst_percent.Location = XLayout.R1_Label(lbl_sgst_percent.Location);

            txt_cgst_percent.Font = XFont.TxtFont;
            txt_cgst_percent.ForeColor = XFontColor.TxtFontColor;
            txt_cgst_percent.BackColor = XTheme.TxtBackcolor;
            txt_cgst_percent.Name = "txt_cgst_percent";
            txt_cgst_percent.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_cgst_percent.Size = XSize.OneText;
            txt_cgst_percent.Anchor = XAnchor.LTR;
            txt_cgst_percent.Location = XLayout.R1_Text(txt_sgst_percent.Location);
            txt_cgst_percent.TabIndex = XTab.Index(txt_sgst_percent.TabIndex);
            txt_cgst_percent.Enter += new EventHandler(Txt_cgst_percent_Enter);


            lbl_igst_percent.Font = XFont.Font_10B;
            lbl_igst_percent.Name = "lbl_igst_percent";
            lbl_igst_percent.Text = "   Igst     %";
            lbl_igst_percent.Anchor = XAnchor.LT;
            lbl_igst_percent.TextAlign = ContentAlignment.MiddleLeft;
            lbl_igst_percent.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_igst_percent.Size = XSize.OneLabel;
            lbl_igst_percent.Location = XLayout.R1_Label(lbl_cgst_percent.Location);

            txt_igst_percent.Font = XFont.TxtFont;
            txt_igst_percent.ForeColor = XFontColor.TxtFontColor;
            txt_igst_percent.BackColor = XTheme.TxtBackcolor;
            txt_igst_percent.Name = "txt_igst_percent";
            txt_igst_percent.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_igst_percent.Size = XSize.OneText;
            txt_igst_percent.Anchor = XAnchor.LTR;
            txt_igst_percent.Location = XLayout.R1_Text(txt_cgst_percent.Location);
            txt_igst_percent.TabIndex = XTab.Index(txt_cgst_percent.TabIndex);
            txt_igst_percent.Enter += new EventHandler(Txt_igst_percent_Enter);


            lbl_opening_stock.Font = XFont.Font_10B;
            lbl_opening_stock.Name = "lbl_opening_stock";
            lbl_opening_stock.Text = "   Opening stock";
            lbl_opening_stock.Anchor = XAnchor.LT;
            lbl_opening_stock.TextAlign = ContentAlignment.MiddleLeft;
            lbl_opening_stock.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_opening_stock.Size = XSize.OneLabel;
            lbl_opening_stock.Location = XLayout.R1_Label(lbl_igst_percent.Location);

            txt_opening_stock.Font = XFont.TxtFont;
            txt_opening_stock.ForeColor = XFontColor.TxtFontColor;
            txt_opening_stock.BackColor = XTheme.TxtBackcolor;
            txt_opening_stock.Name = "txt_opening_stock";
            txt_opening_stock.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_opening_stock.Size = XSize.OneText;
            txt_opening_stock.Anchor = XAnchor.LTR;
            txt_opening_stock.Location = XLayout.R1_Text(txt_igst_percent.Location);
            txt_opening_stock.TabIndex = XTab.Index(txt_igst_percent.TabIndex);
            txt_opening_stock.Enter += new EventHandler(Txt_opening_stock_Enter);


            lbl_opening_price.Font = XFont.Font_10B;
            lbl_opening_price.Name = "lbl_opening_price";
            lbl_opening_price.Text = "   Opening price";
            lbl_opening_price.Anchor = XAnchor.LT;
            lbl_opening_price.TextAlign = ContentAlignment.MiddleLeft;
            lbl_opening_price.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_opening_price.Size = XSize.OneLabel;
            lbl_opening_price.Location = XLayout.R1_Label(lbl_opening_stock.Location);

            txt_opening_price.Font = XFont.TxtFont;
            txt_opening_price.ForeColor = XFontColor.TxtFontColor;
            txt_opening_price.BackColor = XTheme.TxtBackcolor;
            txt_opening_price.Name = "txt_opening_price";
            txt_opening_price.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_opening_price.Size = XSize.OneText;
            txt_opening_price.Anchor = XAnchor.LTR;
            txt_opening_price.Location = XLayout.R1_Text(txt_opening_stock.Location);
            txt_opening_price.TabIndex = XTab.Index(txt_opening_stock.TabIndex);
            txt_opening_price.Enter += new EventHandler(Txt_opening_price_Enter);


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
            btn_save.TabIndex = XTab.Index(txt_opening_price.TabIndex);
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

            #region [FProduct]

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.split_container);
            this.Name = "fProduct";
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, ClientSize.Height);

            this.split_container.Panel1.ResumeLayout(false);
            this.split_container.Panel2.ResumeLayout(false);
            ((ISupportInitialize)(this.split_container)).EndInit();
            this.split_container.ResumeLayout(false);
            this.fpanel.ResumeLayout(false);
            this.finner_panel.ResumeLayout(false);
            this.finner_panel.PerformLayout();
            this.ResumeLayout(false);

            #endregion [Fpost]

        }

    }//cls 
}//ns 
