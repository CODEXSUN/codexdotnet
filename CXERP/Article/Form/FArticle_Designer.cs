// Version : 4.0.0.2 Date : 10-08-2020
// Auto Generated
// last update : 23-01-2021 08:38:55 PM

using System;
using System.Windows.Forms;
using CXLIB;
using System.Drawing;
using System.ComponentModel;

namespace CXERP
{ 
    public partial class FArticle : CxControl 
    { 
        public FArticle() 
        {
            InitializeComponent();
            Initialize();
            Setactives();
            SetFocus(); 
            Po_lookup(); 
            Hsncode_lookup(); 
            Size_lookup(); 
            Colour_lookup(); 
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

        private LookupBox txt_po_id;
        private XLabel lbl_po_id;
        private XTextBox txt_article_no;
        private XLabel lbl_article_no;
        private XTextBox txt_product_id;
        private XLabel lbl_product_id;
        private LookupBox txt_hsncode_id;
        private XLabel lbl_hsncode_id;
        private LookupBox txt_size_id;
        private XLabel lbl_size_id;
        private LookupBox txt_colour_id;
        private XLabel lbl_colour_id;
        private XTextBox txt_qty;
        private XLabel lbl_qty;
        private XTextBox txt_price;
        private XLabel lbl_price;
        private XTextBox txt_barcode;
        private XLabel lbl_barcode;

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

            txt_po_id = new LookupBox();
            lbl_po_id = new XLabel();
            txt_article_no = new XTextBox();
            lbl_article_no = new XLabel();
            txt_product_id = new XTextBox();
            lbl_product_id = new XLabel();
            txt_hsncode_id = new LookupBox();
            lbl_hsncode_id = new XLabel();
            txt_size_id = new LookupBox();
            lbl_size_id = new XLabel();
            txt_colour_id = new LookupBox();
            lbl_colour_id = new XLabel();
            txt_qty = new XTextBox();
            lbl_qty = new XLabel();
            txt_price = new XTextBox();
            lbl_price = new XLabel();
            txt_barcode = new XTextBox();
            lbl_barcode = new XLabel();

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

            finner_panel.Controls.Add(txt_notes);
            finner_panel.Controls.Add(lbl_notes);
            finner_panel.Controls.Add(txt_po_id);
            finner_panel.Controls.Add(lbl_po_id);
            finner_panel.Controls.Add(txt_article_no);
            finner_panel.Controls.Add(lbl_article_no);
            finner_panel.Controls.Add(txt_product_id);
            finner_panel.Controls.Add(lbl_product_id);
            finner_panel.Controls.Add(txt_hsncode_id);
            finner_panel.Controls.Add(lbl_hsncode_id);
            finner_panel.Controls.Add(txt_size_id);
            finner_panel.Controls.Add(lbl_size_id);
            finner_panel.Controls.Add(txt_colour_id);
            finner_panel.Controls.Add(lbl_colour_id);
            finner_panel.Controls.Add(txt_qty);
            finner_panel.Controls.Add(lbl_qty);
            finner_panel.Controls.Add(txt_price);
            finner_panel.Controls.Add(lbl_price);
            finner_panel.Controls.Add(txt_barcode);
            finner_panel.Controls.Add(lbl_barcode);
            finner_panel.Controls.Add(btn_save);
            finner_panel.Controls.Add(btn_active);

            #endregion[adding controls]

            #region[Header]

            btn_close.Click += new EventHandler(Btn_close_Click);

            lbl_header.Text = "Article";

            #endregion[Header]

            #region[Properties of control]

            lbl_po_id.Font = XFont.Font_10B;
            lbl_po_id.Name = "lbl_po_id";
            lbl_po_id.Text = "   Po no";
            lbl_po_id.Anchor = XAnchor.LT;
            lbl_po_id.TextAlign = ContentAlignment.MiddleLeft;
            lbl_po_id.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_po_id.Size =  XSize.OneLabel;
            lbl_po_id.Location =XLayout.FirstLabel;

            txt_po_id.Font = XFont.TxtFont;
            txt_po_id.ForeColor = XFontColor.TxtFontColor;
            txt_po_id.BackColor = XTheme.TxtBackcolor;
            txt_po_id.Name = "txt_po_id";
            txt_po_id.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_po_id.Size =  XSize.OneText;
            txt_po_id.Anchor = XAnchor.LTR;
            txt_po_id.Location =XLayout.FirstText;
            txt_po_id.TabIndex = XTab.Txt_TabIndex;
            txt_po_id.Enter += new EventHandler(Txt_po_id_Enter);


            lbl_article_no.Font = XFont.Font_10B;
            lbl_article_no.Name = "lbl_article_no";
            lbl_article_no.Text = "   Article no";
            lbl_article_no.Anchor = XAnchor.LT;
            lbl_article_no.TextAlign = ContentAlignment.MiddleLeft;
            lbl_article_no.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_article_no.Size =  XSize.OneLabel;
            lbl_article_no.Location =XLayout.R1_Label(lbl_po_id.Location);

            txt_article_no.Font = XFont.TxtFont;
            txt_article_no.ForeColor = XFontColor.TxtFontColor;
            txt_article_no.BackColor = XTheme.TxtBackcolor;
            txt_article_no.Name = "txt_article_no";
            txt_article_no.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_article_no.Size =  XSize.OneText;
            txt_article_no.Anchor = XAnchor.LTR;
            txt_article_no.Location =XLayout.R1_Text(txt_po_id.Location);
            txt_article_no.TabIndex = XTab.Index(txt_po_id.TabIndex);
            txt_article_no.Enter += new EventHandler(Txt_article_no_Enter);


            lbl_product_id.Font = XFont.Font_10B;
            lbl_product_id.Name = "lbl_product_id";
            lbl_product_id.Text = "   Describtion";
            lbl_product_id.Anchor = XAnchor.LT;
            lbl_product_id.TextAlign = ContentAlignment.MiddleLeft;
            lbl_product_id.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_product_id.Size =  XSize.OneLabel;
            lbl_product_id.Location =XLayout.R1_Label(lbl_article_no.Location);

            txt_product_id.Font = XFont.TxtFont;
            txt_product_id.ForeColor = XFontColor.TxtFontColor;
            txt_product_id.BackColor = XTheme.TxtBackcolor;
            txt_product_id.Name = "txt_product_id";
            txt_product_id.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_product_id.Size =  XSize.OneText;
            txt_product_id.Anchor = XAnchor.LTR;
            txt_product_id.Location =XLayout.R1_Text(txt_article_no.Location);
            txt_product_id.TabIndex = XTab.Index(txt_article_no.TabIndex);
            txt_product_id.Enter += new EventHandler(Txt_product_id_Enter);


            lbl_hsncode_id.Font = XFont.Font_10B;
            lbl_hsncode_id.Name = "lbl_hsncode_id";
            lbl_hsncode_id.Text = "   Hsn code";
            lbl_hsncode_id.Anchor = XAnchor.LT;
            lbl_hsncode_id.TextAlign = ContentAlignment.MiddleLeft;
            lbl_hsncode_id.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_hsncode_id.Size =  XSize.OneLabel;
            lbl_hsncode_id.Location =XLayout.R1_Label(lbl_product_id.Location);

            txt_hsncode_id.Font = XFont.TxtFont;
            txt_hsncode_id.ForeColor = XFontColor.TxtFontColor;
            txt_hsncode_id.BackColor = XTheme.TxtBackcolor;
            txt_hsncode_id.Name = "txt_hsncode_id";
            txt_hsncode_id.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_hsncode_id.Size =  XSize.OneText;
            txt_hsncode_id.Anchor = XAnchor.LTR;
            txt_hsncode_id.Location =XLayout.R1_Text(txt_product_id.Location);
            txt_hsncode_id.TabIndex = XTab.Index(txt_product_id.TabIndex);
            txt_hsncode_id.Enter += new EventHandler(Txt_hsncode_id_Enter);


            lbl_size_id.Font = XFont.Font_10B;
            lbl_size_id.Name = "lbl_size_id";
            lbl_size_id.Text = "   Size";
            lbl_size_id.Anchor = XAnchor.LT;
            lbl_size_id.TextAlign = ContentAlignment.MiddleLeft;
            lbl_size_id.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_size_id.Size =  XSize.OneLabel;
            lbl_size_id.Location =XLayout.R1_Label(lbl_hsncode_id.Location);

            txt_size_id.Font = XFont.TxtFont;
            txt_size_id.ForeColor = XFontColor.TxtFontColor;
            txt_size_id.BackColor = XTheme.TxtBackcolor;
            txt_size_id.Name = "txt_size_id";
            txt_size_id.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_size_id.Size =  XSize.OneText;
            txt_size_id.Anchor = XAnchor.LTR;
            txt_size_id.Location =XLayout.R1_Text(txt_hsncode_id.Location);
            txt_size_id.TabIndex = XTab.Index(txt_hsncode_id.TabIndex);
            txt_size_id.Enter += new EventHandler(Txt_size_id_Enter);


            lbl_colour_id.Font = XFont.Font_10B;
            lbl_colour_id.Name = "lbl_colour_id";
            lbl_colour_id.Text = "   Colour";
            lbl_colour_id.Anchor = XAnchor.LT;
            lbl_colour_id.TextAlign = ContentAlignment.MiddleLeft;
            lbl_colour_id.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_colour_id.Size =  XSize.OneLabel;
            lbl_colour_id.Location =XLayout.R1_Label(lbl_size_id.Location);

            txt_colour_id.Font = XFont.TxtFont;
            txt_colour_id.ForeColor = XFontColor.TxtFontColor;
            txt_colour_id.BackColor = XTheme.TxtBackcolor;
            txt_colour_id.Name = "txt_colour_id";
            txt_colour_id.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_colour_id.Size =  XSize.OneText;
            txt_colour_id.Anchor = XAnchor.LTR;
            txt_colour_id.Location =XLayout.R1_Text(txt_size_id.Location);
            txt_colour_id.TabIndex = XTab.Index(txt_size_id.TabIndex);
            txt_colour_id.Enter += new EventHandler(Txt_colour_id_Enter);


            lbl_qty.Font = XFont.Font_10B;
            lbl_qty.Name = "lbl_qty";
            lbl_qty.Text = "   Qty";
            lbl_qty.Anchor = XAnchor.LT;
            lbl_qty.TextAlign = ContentAlignment.MiddleLeft;
            lbl_qty.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_qty.Size =  XSize.OneLabel;
            lbl_qty.Location =XLayout.R1_Label(lbl_colour_id.Location);

            txt_qty.Font = XFont.TxtFont;
            txt_qty.ForeColor = XFontColor.TxtFontColor;
            txt_qty.BackColor = XTheme.TxtBackcolor;
            txt_qty.Name = "txt_qty";
            txt_qty.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_qty.Size =  XSize.OneText;
            txt_qty.Anchor = XAnchor.LTR;
            txt_qty.Location =XLayout.R1_Text(txt_colour_id.Location);
            txt_qty.TabIndex = XTab.Index(txt_colour_id.TabIndex);
            txt_qty.Enter += new EventHandler(Txt_qty_Enter);


            lbl_price.Font = XFont.Font_10B;
            lbl_price.Name = "lbl_price";
            lbl_price.Text = "   Price";
            lbl_price.Anchor = XAnchor.LT;
            lbl_price.TextAlign = ContentAlignment.MiddleLeft;
            lbl_price.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_price.Size =  XSize.OneLabel;
            lbl_price.Location =XLayout.R1_Label(lbl_qty.Location);

            txt_price.Font = XFont.TxtFont;
            txt_price.ForeColor = XFontColor.TxtFontColor;
            txt_price.BackColor = XTheme.TxtBackcolor;
            txt_price.Name = "txt_price";
            txt_price.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_price.Size =  XSize.OneText;
            txt_price.Anchor = XAnchor.LTR;
            txt_price.Location =XLayout.R1_Text(txt_qty.Location);
            txt_price.TabIndex = XTab.Index(txt_qty.TabIndex);
            txt_price.Enter += new EventHandler(Txt_price_Enter);


            lbl_barcode.Font = XFont.Font_10B;
            lbl_barcode.Name = "lbl_barcode";
            lbl_barcode.Text = "   Barcode";
            lbl_barcode.Anchor = XAnchor.LT;
            lbl_barcode.TextAlign = ContentAlignment.MiddleLeft;
            lbl_barcode.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_barcode.Size =  XSize.OneLabel;
            lbl_barcode.Location =XLayout.R1_Label(lbl_price.Location);

            txt_barcode.Font = XFont.TxtFont;
            txt_barcode.ForeColor = XFontColor.TxtFontColor;
            txt_barcode.BackColor = XTheme.TxtBackcolor;
            txt_barcode.Name = "txt_barcode";
            txt_barcode.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_barcode.Size =  XSize.OneText;
            txt_barcode.Anchor = XAnchor.LTR;
            txt_barcode.Location =XLayout.R1_Text(txt_price.Location);
            txt_barcode.TabIndex = XTab.Index(txt_price.TabIndex);
            txt_barcode.Enter += new EventHandler(Txt_barcode_Enter);


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
            btn_save.TabIndex = XTab.Index(txt_barcode.TabIndex);
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

            #region [FArticle]

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.split_container);
            this.Name = "fArticle";
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
