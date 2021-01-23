// Version : 3 dt : 01-08-2017
// Auto Generated
// 24-08-2017 09:29:00 PM
// last update : 24-08-2017

using System;
using System.Windows.Forms;
using CXLIB;
using System.Drawing;
using System.ComponentModel;


namespace CXUPVC
{ 
    public partial class FUpvc_quotation : UserControl 
    { 
        public FUpvc_quotation() 
        {
            InitializeComponent();
            Initialize();
            InitGrid();
            SetSalestype();
            Setactives();
            SetFocus(); 
            Upvc_salesmode_lookup(); 
            Party_lookup(); 
            Shipping_lookup(); 
            //Transport_mode_lookup(); 
            Ledger_lookup();
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

        private OfficeButton btn_salestype;
        private LookupBox txt_upvc_salesmode_id;
        private XLabel lbl_upvc_salesmode_id;
        private XTextBox txt_upvc_quotation_no;
        private XLabel lbl_upvc_quotation_no;
        private xDatepicker txt_upvc_quotation_date;
        private XLabel lbl_upvc_quotation_date;
        private LookupBox txt_party_id;
        private XLabel lbl_party_id;
        private LookupBox txt_shipping_id;
        private XLabel lbl_shipping_id;
        private EditGridView editgrid;
        //private LookupBox txt_transport_mode_id;
        //private XLabel lbl_transport_mode_id;
        //private XTextBox txt_vehicle_no;
        //private XLabel lbl_vehicle_no;
        private XTextBox txt_total_qty;
        private XLabel lbl_total_qty;
        private XTextBox txt_gsttotal;
        private XLabel lbl_gsttotal;
        private LookupBox txt_ledger_id;
        private XLabel lbl_ledger_id;
        private XTextBox txt_additional;
        private XLabel lbl_additional;
        private XTextBox txt_grandtotal;
        private XLabel lbl_grandtotal;

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

            btn_salestype = new OfficeButton();
            txt_upvc_salesmode_id = new LookupBox();
            lbl_upvc_salesmode_id = new XLabel();
            txt_upvc_quotation_no = new XTextBox();
            lbl_upvc_quotation_no = new XLabel();
            txt_upvc_quotation_date = new xDatepicker();
            lbl_upvc_quotation_date = new XLabel();
            txt_party_id = new LookupBox();
            lbl_party_id = new XLabel();
            txt_shipping_id = new LookupBox();
            lbl_shipping_id = new XLabel();
            editgrid = new EditGridView();
            //txt_transport_mode_id = new LookupBox();
            //lbl_transport_mode_id = new XLabel();
            //txt_vehicle_no = new XTextBox();
            ///lbl_vehicle_no = new XLabel();
            txt_total_qty = new XTextBox();
            lbl_total_qty = new XLabel();
            txt_gsttotal = new XTextBox();
            lbl_gsttotal = new XLabel();
            txt_ledger_id = new LookupBox();
            lbl_ledger_id = new XLabel();
            txt_additional = new XTextBox();
            lbl_additional = new XLabel();
            txt_grandtotal = new XTextBox();
            lbl_grandtotal = new XLabel();

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
            finner_panel.Controls.Add(btn_salestype);
            finner_panel.Controls.Add(txt_upvc_salesmode_id);
            finner_panel.Controls.Add(lbl_upvc_salesmode_id);
            finner_panel.Controls.Add(txt_upvc_quotation_no);
            finner_panel.Controls.Add(lbl_upvc_quotation_no);
            finner_panel.Controls.Add(txt_upvc_quotation_date);
            finner_panel.Controls.Add(lbl_upvc_quotation_date);
            finner_panel.Controls.Add(txt_party_id);
            finner_panel.Controls.Add(lbl_party_id);
            finner_panel.Controls.Add(txt_shipping_id);
            finner_panel.Controls.Add(lbl_shipping_id);
            //finner_panel.Controls.Add(txt_transport_mode_id);
            //finner_panel.Controls.Add(lbl_transport_mode_id);
            //finner_panel.Controls.Add(txt_vehicle_no);
            //finner_panel.Controls.Add(lbl_vehicle_no);
            finner_panel.Controls.Add(txt_total_qty);
            finner_panel.Controls.Add(lbl_total_qty);
            finner_panel.Controls.Add(txt_gsttotal);
            finner_panel.Controls.Add(lbl_gsttotal);
            finner_panel.Controls.Add(txt_ledger_id);
            finner_panel.Controls.Add(lbl_ledger_id);
            finner_panel.Controls.Add(txt_additional);
            finner_panel.Controls.Add(lbl_additional);
            finner_panel.Controls.Add(txt_grandtotal);
            finner_panel.Controls.Add(lbl_grandtotal);
            finner_panel.Controls.Add(editgrid);
            finner_panel.Controls.Add(btn_save);
            finner_panel.Controls.Add(btn_active);
           

            #endregion[adding controls]

            #region[Header]

            btn_close.Click += new EventHandler(Btn_close_Click);

            lbl_header.Text = "Quotation";

            #endregion[Header]

            #region[Properties of control]

            btn_salestype.Anchor = XAnchor.LT;
            btn_salestype.Font = XFont.TxtFont;
            btn_salestype.Size = new Size(200, 35);
            btn_salestype.Location = new Point(20, 8);
            btn_salestype.TabIndex = XTab.Txt_TabIndex;
            btn_salestype.Name = "btn_salestype";
            btn_salestype.Text = Core.SGST;
            btn_salestype.Themes = XTheme.YellowBtn;
            btn_salestype.Click += new EventHandler(Btn_salestype_Click);
            Point b = new Point(btn_salestype.Left, btn_salestype.Bottom - 25);

            lbl_upvc_salesmode_id.Font = XFont.Font_10B;
            lbl_upvc_salesmode_id.Name = "lbl_upvc_salesmode_id";
            lbl_upvc_salesmode_id.Text = "Sales mode";
            lbl_upvc_salesmode_id.Anchor = XAnchor.LT;
            lbl_upvc_salesmode_id.TextAlign = ContentAlignment.MiddleLeft;
            lbl_upvc_salesmode_id.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_upvc_salesmode_id.Size = XSize.OneLabel;
            lbl_upvc_salesmode_id.Location = XLayout.R2_3Label_1(b);

            txt_upvc_salesmode_id.Font = XFont.TxtFont;
            txt_upvc_salesmode_id.ForeColor = XFontColor.TxtFontColor;
            txt_upvc_salesmode_id.BackColor = XTheme.TxtBackcolor;
            txt_upvc_salesmode_id.Name = "txt_upvc_salesmode_id";
            txt_upvc_salesmode_id.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_upvc_salesmode_id.TextAlign = HorizontalAlignment.Left;
            txt_upvc_salesmode_id.Size = XSize.ThreeText;
            txt_upvc_salesmode_id.Anchor = XAnchor.LT;
            txt_upvc_salesmode_id.Location = XLayout.R2_3Text_1(b);
            txt_upvc_salesmode_id.TabIndex = XTab.Txt_TabIndex;
            txt_upvc_salesmode_id.Enter += new EventHandler(Txt_upvc_salesmode_id_Enter);


            lbl_upvc_quotation_no.Font = XFont.Font_10B;
            lbl_upvc_quotation_no.Name = "lbl_upvc_quotation_no";
            lbl_upvc_quotation_no.Text = " Quotation no";
            lbl_upvc_quotation_no.Anchor = XAnchor.LT;
            lbl_upvc_quotation_no.TextAlign = ContentAlignment.MiddleLeft;
            lbl_upvc_quotation_no.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_upvc_quotation_no.Size = XSize.ThreeLabel;
            lbl_upvc_quotation_no.Location = XLayout.R1_3Label_2(lbl_upvc_salesmode_id.Location);

            txt_upvc_quotation_no.Font = XFont.TxtFont;
            txt_upvc_quotation_no.ForeColor = XFontColor.TxtFontColor;
            txt_upvc_quotation_no.BackColor = XTheme.TxtBackcolor;
            txt_upvc_quotation_no.Name = "txt_upvc_quotation_no";
            txt_upvc_quotation_no.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_upvc_quotation_no.TextAlign = HorizontalAlignment.Left;
            txt_upvc_quotation_no.Size = XSize.ThreeText;
            txt_upvc_quotation_no.Anchor = XAnchor.LTR;
            txt_upvc_quotation_no.Location = XLayout.R1_3Text_2(txt_upvc_salesmode_id.Location);
            txt_upvc_quotation_no.TabIndex = XTab.Index(txt_upvc_salesmode_id.TabIndex);
            txt_upvc_quotation_no.Enter += new EventHandler(Txt_upvc_quotation_no_Enter);


            lbl_upvc_quotation_date.Font = XFont.Font_10B;
            lbl_upvc_quotation_date.Name = "lbl_upvc_quotation_date";
            lbl_upvc_quotation_date.Text = " Date";
            lbl_upvc_quotation_date.Anchor = XAnchor.LT;
            lbl_upvc_quotation_date.TextAlign = ContentAlignment.MiddleLeft;
            lbl_upvc_quotation_date.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_upvc_quotation_date.Size = XSize.ThreeLabel;
            lbl_upvc_quotation_date.Location = XLayout.R1_3Label_3(lbl_upvc_quotation_no.Location);

            txt_upvc_quotation_date.Font = XFont.TxtFont;
            txt_upvc_quotation_date.ForeColor = XFontColor.TxtFontColor;
            txt_upvc_quotation_date.BackColor = XTheme.TxtBackcolor;
            txt_upvc_quotation_date.Name = "txt_upvc_quotation_date";
            txt_upvc_quotation_date.CustomFormat = "dd-MM-yyyy";
            txt_upvc_quotation_date.Format = DateTimePickerFormat.Custom;
            txt_upvc_quotation_date.Size = XSize.ThreeText;
            txt_upvc_quotation_date.Anchor = XAnchor.LTR;
            txt_upvc_quotation_date.Location = XLayout.R1_3Text_3(txt_upvc_quotation_no.Location);
            txt_upvc_quotation_date.TabIndex = XTab.Index(txt_upvc_quotation_no.TabIndex);
            txt_upvc_quotation_date.Enter += new EventHandler(Txt_upvc_quotation_date_Enter);


            lbl_party_id.Font = XFont.Font_10B;
            lbl_party_id.Name = "lbl_party_id";
            lbl_party_id.Text = "   Party";
            lbl_party_id.Anchor = XAnchor.LT;
            lbl_party_id.TextAlign = ContentAlignment.MiddleLeft;
            lbl_party_id.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_party_id.Size =  XSize.OneLabel;
            lbl_party_id.Location =XLayout.R2_2Label_1(lbl_upvc_quotation_date.Location);

            txt_party_id.Font = XFont.TxtFont;
            txt_party_id.ForeColor = XFontColor.TxtFontColor;
            txt_party_id.BackColor = XTheme.TxtBackcolor;
            txt_party_id.Name = "txt_party_id";
            txt_party_id.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_party_id.TextAlign = HorizontalAlignment.Left;
            txt_party_id.Size =  XSize.TwoText;
            txt_party_id.Anchor = XAnchor.LT;
            txt_party_id.Location =XLayout.R2_2Text_1(txt_upvc_quotation_date.Location);
            txt_party_id.TabIndex = XTab.Index(txt_upvc_quotation_date.TabIndex);
            txt_party_id.Enter += new EventHandler(Txt_party_id_Enter);

            lbl_shipping_id.Font = XFont.Font_10B;
            lbl_shipping_id.Name = "lbl_shipping_id";
            lbl_shipping_id.Text = "Shipping To";
            lbl_shipping_id.Anchor = XAnchor.LT;
            lbl_shipping_id.TextAlign = ContentAlignment.MiddleLeft;
            lbl_shipping_id.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_shipping_id.Size =  XSize.TwoLabel;
            lbl_shipping_id.Location =XLayout.R1_2Label_2(lbl_party_id.Location);

            txt_shipping_id.Font = XFont.TxtFont;
            txt_shipping_id.ForeColor = XFontColor.TxtFontColor;
            txt_shipping_id.BackColor = XTheme.TxtBackcolor;
            txt_shipping_id.Name = "txt_shipping_id";
            txt_shipping_id.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_shipping_id.TextAlign = HorizontalAlignment.Left;
            txt_shipping_id.Size =  XSize.TwoText;
            txt_shipping_id.Anchor = XAnchor.LTR;
            txt_shipping_id.Location =XLayout.R1_2Text_2(txt_party_id.Location);
            txt_shipping_id.TabIndex = XTab.Index(txt_party_id.TabIndex);
            txt_shipping_id.Enter += new EventHandler(Txt_shipping_id_Enter);

            editgrid.Location = new Point(XLayout.H_left, lbl_shipping_id.Bottom + 10); 
            editgrid.Name = "editgrid"; 
            editgrid.Size = new Size(finner_panel.Width - 50, 250); 
            editgrid.TabIndex = XTab.Index(txt_shipping_id.TabIndex);
            editgrid.RowsLimit = 12; 
            Point p = new Point(editgrid.Left , editgrid.Bottom);

            //lbl_transport_mode_id.Font = XFont.Font_10B;
            //lbl_transport_mode_id.Name = "lbl_transport_mode_id";
            //lbl_transport_mode_id.Text = "Transport mode";
            //lbl_transport_mode_id.Anchor = XAnchor.LT;
            //lbl_transport_mode_id.TextAlign = ContentAlignment.MiddleLeft;
            //lbl_transport_mode_id.ForeColor = XFontColor.Lbl_ForeColor;
            //lbl_transport_mode_id.Size = XSize.OneLabel;
            //lbl_transport_mode_id.Location = XLayout.R2_3Label_1(p);

            //txt_transport_mode_id.Font = XFont.TxtFont;
            //txt_transport_mode_id.ForeColor = XFontColor.TxtFontColor;
            //txt_transport_mode_id.BackColor = XTheme.TxtBackcolor;
            //txt_transport_mode_id.Name = "txt_transport_mode_id";
            //txt_transport_mode_id.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            //txt_transport_mode_id.TextAlign = HorizontalAlignment.Left;
            //txt_transport_mode_id.Size = XSize.ThreeText;
            //txt_transport_mode_id.Anchor = XAnchor.LTR;
            //txt_transport_mode_id.Location = XLayout.R2_3Text_1(p);
            //txt_transport_mode_id.TabIndex = XTab.Index(editgrid.TabIndex);
            //txt_transport_mode_id.Enter += new EventHandler(Txt_transport_mode_id_Enter);

            //lbl_vehicle_no.Font = XFont.Font_10B;
            //lbl_vehicle_no.Name = "lbl_vehicle_no";
            //lbl_vehicle_no.Text = "Vehicle no";
            //lbl_vehicle_no.Anchor = XAnchor.LT;
            //lbl_vehicle_no.TextAlign = ContentAlignment.MiddleLeft;
            //lbl_vehicle_no.ForeColor = XFontColor.Lbl_ForeColor;
            //lbl_vehicle_no.Size = XSize.OneLabel;
            //lbl_vehicle_no.Location = XLayout.R2_3Label_1(lbl_transport_mode_id.Location);

            //txt_vehicle_no.Font = XFont.TxtFont;
            //txt_vehicle_no.ForeColor = XFontColor.TxtFontColor;
            //txt_vehicle_no.BackColor = XTheme.TxtBackcolor;
            //txt_vehicle_no.Name = "txt_vehicle_no";
            //txt_vehicle_no.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            //txt_vehicle_no.TextAlign = HorizontalAlignment.Left;
            //txt_vehicle_no.Size = XSize.ThreeText;
            //txt_vehicle_no.Anchor = XAnchor.LTR;
            //txt_vehicle_no.Location = XLayout.R2_3Text_1(txt_transport_mode_id.Location);
            //txt_vehicle_no.TabIndex = XTab.Index(txt_transport_mode_id.TabIndex);
            //txt_vehicle_no.Enter += new EventHandler(Txt_vehicle_no_Enter);

            lbl_total_qty.Font = XFont.Font_10B;
            lbl_total_qty.Name = "lbl_total_qty";
            lbl_total_qty.Text = "Total qty";
            lbl_total_qty.Anchor = XAnchor.LT;
            lbl_total_qty.TextAlign = ContentAlignment.MiddleLeft;
            lbl_total_qty.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_total_qty.Size = XSize.FourLabel;
            lbl_total_qty.Location = XLayout.R2_4Label_3(p);

            txt_total_qty.Font = XFont.TxtFont;
            txt_total_qty.ForeColor = XFontColor.TxtFontColor;
            txt_total_qty.BackColor = XTheme.TxtBackcolor;
            txt_total_qty.Name = "txt_total_qty";
            txt_total_qty.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_total_qty.ReadOnly = true;
            txt_total_qty.Cursor = Cursors.No;
            txt_total_qty.TextAlign = HorizontalAlignment.Left;
            txt_total_qty.Size = XSize.FourText;
            txt_total_qty.Anchor = XAnchor.LTR;
            txt_total_qty.Location = XLayout.R2_4Text_3(p);
            txt_total_qty.Enter += new EventHandler(Txt_total_qty_Enter);

            lbl_gsttotal.Font = XFont.Font_10B;
            lbl_gsttotal.Name = "lbl_gsttotal";
            lbl_gsttotal.Text = "GST Total";
            lbl_gsttotal.Anchor = XAnchor.LT;
            lbl_gsttotal.TextAlign = ContentAlignment.MiddleLeft;
            lbl_gsttotal.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_gsttotal.Size = XSize.FourLabel;
            lbl_gsttotal.Location = XLayout.R2_4Label_4(p);

            txt_gsttotal.Font = XFont.TxtFont;
            txt_gsttotal.ForeColor = XFontColor.TxtFontColor;
            txt_gsttotal.BackColor = XTheme.TxtBackcolor;
            txt_gsttotal.Name = "txt_gsttotal";
            txt_gsttotal.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_gsttotal.ReadOnly = true;
            txt_gsttotal.Cursor = Cursors.No;
            txt_gsttotal.TextAlign = HorizontalAlignment.Right;
            txt_gsttotal.Size = XSize.FourText;
            txt_gsttotal.Anchor = XAnchor.LTR;
            txt_gsttotal.Location = XLayout.R2_4Text_4(p);
            txt_gsttotal.Enter += new EventHandler(Txt_gsttotal_Enter);

            lbl_ledger_id.Font = XFont.Font_10B;
            lbl_ledger_id.Name = "lbl_ledger_id";
            lbl_ledger_id.Text = "Ledger";
            lbl_ledger_id.Anchor = XAnchor.LT;
            lbl_ledger_id.TextAlign = ContentAlignment.MiddleLeft;
            lbl_ledger_id.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_ledger_id.Size = XSize.FourLabel;
            lbl_ledger_id.Location = XLayout.R2_4Label_3(lbl_gsttotal.Location);

            txt_ledger_id.Font = XFont.TxtFont;
            txt_ledger_id.ForeColor = XFontColor.TxtFontColor;
            txt_ledger_id.BackColor = XTheme.TxtBackcolor;
            txt_ledger_id.Name = "txt_ledger_id";
            txt_ledger_id.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_ledger_id.Size = XSize.FourText;
            txt_ledger_id.Anchor = XAnchor.LTR;
            txt_ledger_id.Location = XLayout.R2_4Text_3(txt_gsttotal.Location);
            txt_ledger_id.TabIndex = XTab.Index(txt_gsttotal.TabIndex);
            txt_ledger_id.Enter += new EventHandler(Txt_ledger_id_Enter);

            lbl_additional.Font = XFont.Font_10B;
            lbl_additional.Name = "lbl_additional";
            lbl_additional.Text = "Additional";
            lbl_additional.Anchor = XAnchor.LT;
            lbl_additional.TextAlign = ContentAlignment.MiddleLeft;
            lbl_additional.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_additional.Size = XSize.FourLabel;
            lbl_additional.Location = XLayout.R2_4Label_4(lbl_total_qty.Location);

            txt_additional.Font = XFont.TxtFont;
            txt_additional.ForeColor = XFontColor.TxtFontColor;
            txt_additional.BackColor = XTheme.TxtBackcolor;
            txt_additional.Name = "txt_additional";
            txt_additional.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_additional.TextAlign = HorizontalAlignment.Right;
            txt_additional.Size = XSize.FourText;
            txt_additional.Anchor = XAnchor.LTR;
            txt_additional.Location = XLayout.R2_4Text_4(txt_total_qty.Location);
            txt_additional.TabIndex = XTab.Index(txt_ledger_id.TabIndex);
            txt_additional.Enter += new EventHandler(Txt_additional_Enter);
            txt_additional.TextChanged += Txt_additional_TextChanged;

            lbl_grandtotal.Font = XFont.Font_10B;
            lbl_grandtotal.Name = "lbl_grandtotal";
            lbl_grandtotal.Text = "Grand Total";
            lbl_grandtotal.Anchor = XAnchor.LT;
            lbl_grandtotal.TextAlign = ContentAlignment.MiddleLeft;
            lbl_grandtotal.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_grandtotal.Size = XSize.FourLabel;
            lbl_grandtotal.Location = XLayout.R2_4Label_4(lbl_additional.Location);

            txt_grandtotal.Font = XFont.TxtFont;
            txt_grandtotal.ForeColor = XFontColor.TxtFontColor;
            txt_grandtotal.BackColor = XTheme.TxtBackcolor;
            txt_grandtotal.Name = "txt_grandtotal";
            txt_grandtotal.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_grandtotal.ReadOnly = true;
            txt_grandtotal.Cursor = Cursors.No;
            txt_grandtotal.TextAlign = HorizontalAlignment.Right;
            txt_grandtotal.Size = XSize.FourText;
            txt_grandtotal.Anchor = XAnchor.LTR;
            txt_grandtotal.Location = XLayout.R2_4Text_4(txt_additional.Location);
            txt_grandtotal.Enter += new EventHandler(Txt_grandtotal_Enter);


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
            btn_save.TabIndex = XTab.Index(txt_additional.TabIndex);
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

            #region[Print Panel]

            print_panel.BorderStyle = BorderStyle.None;
            print_panel.Controls.Add(this.btn_print_close);
            print_panel.Controls.Add(this.lbl_print_header);
            print_panel.Controls.Add(this.check_original);
            print_panel.Controls.Add(this.check_duplicate);
            print_panel.Controls.Add(this.check_triplicate);
            print_panel.Location = new Point(750, 360);
            print_panel.Name = "print_panel";
            print_panel.Size = new Size(357, 200);
            print_panel.TabIndex = 35;

            btn_print_close.Name = "btn_print_close";
            btn_print_close.Location = new Point(320, 3);
            btn_print_close.Click += new EventHandler(Btn_close_Click);
            
            lbl_print_header.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_print_header.BackColor = Theme.F_header_Backcolor;
            lbl_print_header.Cursor = Cursors.Default;
            lbl_print_header.Font = Theme.F_header_Font;
            lbl_print_header.ForeColor = Theme.F_headerText_Fontcolor;
            lbl_print_header.Location = new Point(6, 0);
            lbl_print_header.Name = "lbl_print_header";
            lbl_print_header.Size = new Size(345, 35);
            lbl_print_header.Text = "Print Option";
            lbl_print_header.TextAlign = ContentAlignment.MiddleCenter;
            
            check_original.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            check_original.AutoSize = true;
            check_original.Location = new Point(35, 50);
            check_original.Name = "check_original";
            check_original.Size = new Size(125, 17);
            check_original.TabIndex = 1;
            check_original.Text = "Original Copy";
            check_original.UseVisualStyleBackColor = true;
            check_original.Checked = true;
            
            check_duplicate.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            check_duplicate.AutoSize = true;
            check_duplicate.Location = new Point(check_original.Left, check_original.Top + 35);
            check_duplicate.Name = "check_duplicate";
            check_duplicate.Size = new Size(125, 17);
            check_duplicate.TabIndex = 1;
            check_duplicate.Text = "Duplicate Copy";
            check_duplicate.UseVisualStyleBackColor = true;
            check_duplicate.Checked = true;
            
            check_triplicate.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            check_triplicate.AutoSize = true;
            check_triplicate.Location = new Point(check_duplicate.Left, check_duplicate.Top + 35);
            check_triplicate.Name = "check_triplicate";
            check_triplicate.Size = new Size(125, 17);
            check_triplicate.TabIndex = 1;
            check_triplicate.Text = "Office Copy";
            check_triplicate.UseVisualStyleBackColor = true;
            check_triplicate.Checked = true;

            #endregion[Print Panel]

            #endregion[finner_panel]

            #region [FUpvc_quotation]

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.split_container);
            this.Name = "fUpvc_quotation";
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

            DataGridViewTextBoxColumn col_Upvc_quotationitems_Id = new DataGridViewTextBoxColumn();
            col_Upvc_quotationitems_Id.Name = UPVC_QUOTATIONITEMS.UPVC_QUOTATIONITEMS_ID;
            col_Upvc_quotationitems_Id.HeaderText = "UPVC_QUOTATIONITEMS_ID ";
            col_Upvc_quotationitems_Id.Visible = false;
            col_Upvc_quotationitems_Id.Width = 100;
            col_Upvc_quotationitems_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Upvc_quotationitems_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Upvc_quotationitems_Id);

            DataGridViewTextBoxColumn col_Upvc_quotation_Id = new DataGridViewTextBoxColumn();
            col_Upvc_quotation_Id.Name = UPVC_QUOTATIONITEMS.UPVC_QUOTATION_ID;
            col_Upvc_quotation_Id.HeaderText = "UPVC_QUOTATION_ID ";
            col_Upvc_quotation_Id.Visible = false;
            col_Upvc_quotation_Id.Width = 100;
            col_Upvc_quotation_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Upvc_quotation_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Upvc_quotation_Id);

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
            col_Product_id.Name = UPVC_QUOTATIONITEMS.PRODUCT_ID;
            col_Product_id.HeaderText = "Description";
            //col_Product_id.Visible = false; 
            col_Product_id.Width = 500;
            col_Product_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Product_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Product_id);

            DataGridViewTextBoxColumn col_Qty = new DataGridViewTextBoxColumn();
            col_Qty.Name = UPVC_QUOTATIONITEMS.QTY;
            col_Qty.HeaderText = "QTY";
            //col_Qty.Visible = false; 
            col_Qty.Width = 100;
            col_Qty.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Qty.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Qty);

            DataGridViewTextBoxColumn col_Widths = new DataGridViewTextBoxColumn();
            col_Widths.Name = UPVC_QUOTATIONITEMS.WIDTHS;
            col_Widths.HeaderText = "WIDTHS";
            //col_Widths.Visible = false; 
            col_Widths.Width = 100;
            col_Widths.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Widths.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Widths);

            DataGridViewTextBoxColumn col_Heights = new DataGridViewTextBoxColumn();
            col_Heights.Name = UPVC_QUOTATIONITEMS.HEIGHTS;
            col_Heights.HeaderText = "HEIGHTS";
            //col_Heights.Visible = false; 
            col_Heights.Width = 100;
            col_Heights.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Heights.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Heights);

            DataGridViewTextBoxColumn col_Areasq = new DataGridViewTextBoxColumn();
            col_Areasq.Name = UPVC_QUOTATIONITEMS.AREASQ;
            col_Areasq.HeaderText = "AREA SQ";
            //col_Areasq.Visible = false; 
            col_Areasq.ReadOnly = true;
            col_Areasq.Width = 130;
            col_Areasq.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Areasq.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Areasq);

            DataGridViewTextBoxColumn col_Price = new DataGridViewTextBoxColumn();
            col_Price.Name = UPVC_QUOTATIONITEMS.PRICE;
            col_Price.HeaderText = "PRICE";
            //col_Price.Visible = false; 
            col_Price.Width = 100;
            col_Price.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Price);

            DataGridViewTextBoxColumn col_TAXABLEAMOUNT = new DataGridViewTextBoxColumn();
            col_TAXABLEAMOUNT.Name = UPVC_QUOTATIONITEMS.TAXABLEAMOUNT;
            col_TAXABLEAMOUNT.HeaderText = "Value";
            //col_TAXABLEAMOUNT.Visible = false;
            col_TAXABLEAMOUNT.ReadOnly = true;
            col_TAXABLEAMOUNT.Width = 100;
            col_TAXABLEAMOUNT.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_TAXABLEAMOUNT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_TAXABLEAMOUNT);

            DataGridViewTextBoxColumn col_Sgst_percent = new DataGridViewTextBoxColumn();
            col_Sgst_percent.Name = UPVC_QUOTATIONITEMS.SGST_PERCENT;
            col_Sgst_percent.HeaderText = "SGST   %";
            //col_Sgst_percent.Visible = false; 
            col_Sgst_percent.Width = 100;
            col_Sgst_percent.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Sgst_percent.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Sgst_percent);

            DataGridViewTextBoxColumn col_Cgst_percent = new DataGridViewTextBoxColumn();
            col_Cgst_percent.Name = UPVC_QUOTATIONITEMS.CGST_PERCENT;
            col_Cgst_percent.HeaderText = "CGST   %";
            //col_Cgst_percent.Visible = false; 
            col_Cgst_percent.Width = 100;
            col_Cgst_percent.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Cgst_percent.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Cgst_percent);

            DataGridViewTextBoxColumn col_Igst_percent = new DataGridViewTextBoxColumn();
            col_Igst_percent.Name = UPVC_QUOTATIONITEMS.IGST_PERCENT;
            col_Igst_percent.HeaderText = "IGST   %";
            //col_Igst_percent.Visible = false; 
            col_Igst_percent.Width = 100;
            col_Igst_percent.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Igst_percent.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Igst_percent);

            DataGridViewTextBoxColumn col_SGST_AMOUNT = new DataGridViewTextBoxColumn();
            col_SGST_AMOUNT.Name = UPVC_QUOTATIONITEMS.SGST_AMOUNT;
            col_SGST_AMOUNT.HeaderText = "SGST_AMOUNT";
            col_SGST_AMOUNT.Visible = false;
            col_SGST_AMOUNT.Width = 100;
            col_SGST_AMOUNT.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_SGST_AMOUNT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_SGST_AMOUNT);

            DataGridViewTextBoxColumn col_CGST_AMOUNT = new DataGridViewTextBoxColumn();
            col_CGST_AMOUNT.Name = UPVC_QUOTATIONITEMS.CGST_AMOUNT;
            col_CGST_AMOUNT.HeaderText = "CGST_AMOUNT";
            col_CGST_AMOUNT.Visible = false;
            col_CGST_AMOUNT.Width = 100;
            col_CGST_AMOUNT.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_CGST_AMOUNT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_CGST_AMOUNT);

            DataGridViewTextBoxColumn col_IGST_AMOUNT = new DataGridViewTextBoxColumn();
            col_IGST_AMOUNT.Name = UPVC_QUOTATIONITEMS.IGST_AMOUNT;
            col_IGST_AMOUNT.HeaderText = "IGST_AMOUNT";
            col_IGST_AMOUNT.Visible = false;
            col_IGST_AMOUNT.Width = 100;
            col_IGST_AMOUNT.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_IGST_AMOUNT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_IGST_AMOUNT);

            if (btn_salestype.Text == Core.SGST)
            {
                col_Sgst_percent.Visible = true;
                col_Cgst_percent.Visible = true;
                col_Igst_percent.Visible = false;
            }
            else
            {
                col_Sgst_percent.Visible = false;
                col_Cgst_percent.Visible = false;
                col_Igst_percent.Visible = true;
            }

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
