// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// 28/03/2019 01:43:16 PM
// last update : 28-03-2019

using System;
using System.Windows.Forms;
using CXLIB;
using System.Drawing;
using System.ComponentModel;

namespace CXCORE
{
    public partial class FCompany : CxControl
    {
        public FCompany()
        {
            InitializeComponent();
            Initialize();
            Setactives();
            SetFocus();
            City_lookup();
            State_lookup();
            Country_lookup();
            Pincode_lookup();

            SetAction(BtnEvent.Edit, Current.Company_id);
        }

        #region [Private Declare]

        private Timer splitTimer;
        private SplitContainer split_container;
        private XShadowPanel fpanel;
        private Panel finner_panel;
        private CloseButton btn_close;
        private Header lbl_header;
        private OfficeButton btn_edit;
        private OfficeButton btn_print;
        private OfficeButton btn_splitter;

        private XTextBox txt_company_name;
        private XLabel lbl_company_name;
        private XTextBox txt_display_name;
        private XLabel lbl_display_name;
        private XTextBox txt_street1;
        private XLabel lbl_street1;
        private XTextBox txt_street2;
        private XLabel lbl_street2;
        private LookupBox txt_city_id;
        private XLabel lbl_city_id;
        private LookupBox txt_state_id;
        private XLabel lbl_state_id;
        private LookupBox txt_country_id;
        private XLabel lbl_country_id;
        private LookupBox txt_pincode_id;
        private XLabel lbl_pincode_id;
        private XTextBox txt_cell1;
        private XLabel lbl_cell1;
        private XTextBox txt_cell2;
        private XLabel lbl_cell2;
        private XTextBox txt_phone;
        private XLabel lbl_phone;
        private XTextBox txt_email;
        private XLabel lbl_email;
        private XTextBox txt_website;
        private XLabel lbl_website;
        private XTextBox txt_gst;
        private XLabel lbl_gst;
        private XTextBox txt_pan;
        private XLabel lbl_pan;

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
            btn_edit = new OfficeButton();
            btn_print = new OfficeButton();
            btn_splitter = new OfficeButton();
            lbl_header = new Header();
            btn_close = new CloseButton();

            txt_company_name = new XTextBox();
            lbl_company_name = new XLabel();
            txt_display_name = new XTextBox();
            lbl_display_name = new XLabel();
            txt_street1 = new XTextBox();
            lbl_street1 = new XLabel();
            txt_street2 = new XTextBox();
            lbl_street2 = new XLabel();
            txt_city_id = new LookupBox();
            lbl_city_id = new XLabel();
            txt_state_id = new LookupBox();
            lbl_state_id = new XLabel();
            txt_country_id = new LookupBox();
            lbl_country_id = new XLabel();
            txt_pincode_id = new LookupBox();
            lbl_pincode_id = new XLabel();
            txt_cell1 = new XTextBox();
            lbl_cell1 = new XLabel();
            txt_cell2 = new XTextBox();
            lbl_cell2 = new XLabel();
            txt_phone = new XTextBox();
            lbl_phone = new XLabel();
            txt_email = new XTextBox();
            lbl_email = new XLabel();
            txt_website = new XTextBox();
            lbl_website = new XLabel();
            txt_gst = new XTextBox();
            lbl_gst = new XLabel();
            txt_pan = new XTextBox();
            lbl_pan = new XLabel();

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
            split_container.Panel2.Controls.Add(btn_edit);
            split_container.Panel2.Controls.Add(btn_splitter);

            btn_edit.Font = XFont.BtnFont;
            btn_edit.Location = XLayout.FormFirstBtn;
            btn_edit.Size = XSize.BtnOne;
            btn_edit.TabIndex = 1;
            btn_edit.Name = "btn_edit";
            btn_edit.Text = "&Edit";
            btn_edit.Themes = XTheme.BlueBtn;
            btn_edit.Click += Btn_edit_Click;

            btn_print.Font = XFont.BtnFont;
            btn_print.Location = XLayout.BtnLocation(btn_edit.Location);
            btn_print.Size = XSize.BtnOne;
            btn_print.TabIndex = XTab.Index(btn_edit.TabIndex);
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
            finner_panel.Controls.Add(txt_company_name);
            finner_panel.Controls.Add(lbl_company_name);
            finner_panel.Controls.Add(txt_display_name);
            finner_panel.Controls.Add(lbl_display_name);
            finner_panel.Controls.Add(txt_street1);
            finner_panel.Controls.Add(lbl_street1);
            finner_panel.Controls.Add(txt_street2);
            finner_panel.Controls.Add(lbl_street2);
            finner_panel.Controls.Add(txt_city_id);
            finner_panel.Controls.Add(lbl_city_id);
            finner_panel.Controls.Add(txt_state_id);
            finner_panel.Controls.Add(lbl_state_id);
            finner_panel.Controls.Add(txt_country_id);
            finner_panel.Controls.Add(lbl_country_id);
            finner_panel.Controls.Add(txt_pincode_id);
            finner_panel.Controls.Add(lbl_pincode_id);
            finner_panel.Controls.Add(txt_cell1);
            finner_panel.Controls.Add(lbl_cell1);
            finner_panel.Controls.Add(txt_cell2);
            finner_panel.Controls.Add(lbl_cell2);
            finner_panel.Controls.Add(txt_phone);
            finner_panel.Controls.Add(lbl_phone);
            finner_panel.Controls.Add(txt_email);
            finner_panel.Controls.Add(lbl_email);
            finner_panel.Controls.Add(txt_website);
            finner_panel.Controls.Add(lbl_website);
            finner_panel.Controls.Add(txt_gst);
            finner_panel.Controls.Add(lbl_gst);
            finner_panel.Controls.Add(txt_pan);
            finner_panel.Controls.Add(lbl_pan);
            finner_panel.Controls.Add(btn_save);
            finner_panel.Controls.Add(btn_active);

            #endregion[adding controls]

            #region[Header]

            btn_close.Click += new EventHandler(Btn_close_Click);

            lbl_header.Text = "Company";

            #endregion[Header]

            #region[Properties of control]

            lbl_company_name.Font = XFont.Font_10B;
            lbl_company_name.Name = "lbl_company_name";
            lbl_company_name.Text = "   Company name";
            lbl_company_name.Anchor = XAnchor.LT;
            lbl_company_name.TextAlign = ContentAlignment.MiddleLeft;
            lbl_company_name.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_company_name.Size = XSize.OneLabel;
            lbl_company_name.Location = XLayout.FirstLabel;

            txt_company_name.Font = XFont.TxtFont;
            txt_company_name.ForeColor = XFontColor.TxtFontColor;
            txt_company_name.BackColor = XTheme.TxtBackcolor;
            txt_company_name.Name = "txt_company_name";
            txt_company_name.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_company_name.Size = XSize.OneText;
            txt_company_name.Anchor = XAnchor.LTR;
            txt_company_name.Location = XLayout.FirstText;
            txt_company_name.TabIndex = XTab.Txt_TabIndex;
            txt_company_name.Enter += new EventHandler(Txt_company_name_Enter);
            txt_company_name.ReadOnly = true;
            txt_company_name.Cursor = Cursors.No;


            lbl_display_name.Font = XFont.Font_10B;
            lbl_display_name.Name = "lbl_display_name";
            lbl_display_name.Text = "   Display name";
            lbl_display_name.Anchor = XAnchor.LT;
            lbl_display_name.TextAlign = ContentAlignment.MiddleLeft;
            lbl_display_name.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_display_name.Size = XSize.OneLabel;
            lbl_display_name.Location = XLayout.R1_Label(lbl_company_name.Location);

            txt_display_name.Font = XFont.TxtFont;
            txt_display_name.ForeColor = XFontColor.TxtFontColor;
            txt_display_name.BackColor = XTheme.TxtBackcolor;
            txt_display_name.Name = "txt_display_name";
            txt_display_name.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_display_name.Size = XSize.OneText;
            txt_display_name.Anchor = XAnchor.LTR;
            txt_display_name.Location = XLayout.R1_Text(txt_company_name.Location);
            txt_display_name.TabIndex = XTab.Index(txt_company_name.TabIndex);
            txt_display_name.Enter += new EventHandler(Txt_display_name_Enter);


            lbl_street1.Font = XFont.Font_10B;
            lbl_street1.Name = "lbl_street1";
            lbl_street1.Text = "   Street1";
            lbl_street1.Anchor = XAnchor.LT;
            lbl_street1.TextAlign = ContentAlignment.MiddleLeft;
            lbl_street1.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_street1.Size = XSize.OneLabel;
            lbl_street1.Location = XLayout.R1_Label(lbl_display_name.Location);

            txt_street1.Font = XFont.TxtFont;
            txt_street1.ForeColor = XFontColor.TxtFontColor;
            txt_street1.BackColor = XTheme.TxtBackcolor;
            txt_street1.Name = "txt_street1";
            txt_street1.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_street1.Size = XSize.OneText;
            txt_street1.Anchor = XAnchor.LTR;
            txt_street1.Location = XLayout.R1_Text(txt_display_name.Location);
            txt_street1.TabIndex = XTab.Index(txt_display_name.TabIndex);
            txt_street1.Enter += new EventHandler(Txt_street1_Enter);


            lbl_street2.Font = XFont.Font_10B;
            lbl_street2.Name = "lbl_street2";
            lbl_street2.Text = "   Street2";
            lbl_street2.Anchor = XAnchor.LT;
            lbl_street2.TextAlign = ContentAlignment.MiddleLeft;
            lbl_street2.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_street2.Size = XSize.OneLabel;
            lbl_street2.Location = XLayout.R1_Label(lbl_street1.Location);

            txt_street2.Font = XFont.TxtFont;
            txt_street2.ForeColor = XFontColor.TxtFontColor;
            txt_street2.BackColor = XTheme.TxtBackcolor;
            txt_street2.Name = "txt_street2";
            txt_street2.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_street2.Size = XSize.OneText;
            txt_street2.Anchor = XAnchor.LTR;
            txt_street2.Location = XLayout.R1_Text(txt_street1.Location);
            txt_street2.TabIndex = XTab.Index(txt_street1.TabIndex);
            txt_street2.Enter += new EventHandler(Txt_street2_Enter);


            lbl_city_id.Font = XFont.Font_10B;
            lbl_city_id.Name = "lbl_city_id";
            lbl_city_id.Text = "   City";
            lbl_city_id.Anchor = XAnchor.LT;
            lbl_city_id.TextAlign = ContentAlignment.MiddleLeft;
            lbl_city_id.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_city_id.Size = XSize.OneLabel;
            lbl_city_id.Location = XLayout.R2_2Label_1(lbl_street2.Location);

            txt_city_id.Font = XFont.TxtFont;
            txt_city_id.ForeColor = XFontColor.TxtFontColor;
            txt_city_id.BackColor = XTheme.TxtBackcolor;
            txt_city_id.Name = "txt_city_id";
            txt_city_id.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_city_id.Size = XSize.TwoText;
            txt_city_id.Anchor = XAnchor.LT;
            txt_city_id.Location = XLayout.R2_2Text_1(txt_street2.Location);
            txt_city_id.TabIndex = XTab.Index(txt_street2.TabIndex);
            txt_city_id.Enter += new EventHandler(Txt_city_id_Enter);


            lbl_state_id.Font = XFont.Font_10B;
            lbl_state_id.Name = "lbl_state_id";
            lbl_state_id.Text = "   State";
            lbl_state_id.Anchor = XAnchor.LT;
            lbl_state_id.TextAlign = ContentAlignment.MiddleLeft;
            lbl_state_id.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_state_id.Size = XSize.TwoLabel;
            lbl_state_id.Location = XLayout.R1_2Label_2(lbl_city_id.Location);

            txt_state_id.Font = XFont.TxtFont;
            txt_state_id.ForeColor = XFontColor.TxtFontColor;
            txt_state_id.BackColor = XTheme.TxtBackcolor;
            txt_state_id.Name = "txt_state_id";
            txt_state_id.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_state_id.Size = XSize.TwoText;
            txt_state_id.Anchor = XAnchor.LTR;
            txt_state_id.Location = XLayout.R1_2Text_2(txt_city_id.Location);
            txt_state_id.TabIndex = XTab.Index(txt_city_id.TabIndex);
            txt_state_id.Enter += new EventHandler(Txt_state_id_Enter);


            lbl_country_id.Font = XFont.Font_10B;
            lbl_country_id.Name = "lbl_country_id";
            lbl_country_id.Text = "   Country";
            lbl_country_id.Anchor = XAnchor.LT;
            lbl_country_id.TextAlign = ContentAlignment.MiddleLeft;
            lbl_country_id.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_country_id.Size = XSize.OneLabel;
            lbl_country_id.Location = XLayout.R2_2Label_1(lbl_state_id.Location);

            txt_country_id.Font = XFont.TxtFont;
            txt_country_id.ForeColor = XFontColor.TxtFontColor;
            txt_country_id.BackColor = XTheme.TxtBackcolor;
            txt_country_id.Name = "txt_country_id";
            txt_country_id.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_country_id.Size = XSize.TwoText;
            txt_country_id.Anchor = XAnchor.LT;
            txt_country_id.Location = XLayout.R2_2Text_1(txt_state_id.Location);
            txt_country_id.TabIndex = XTab.Index(txt_state_id.TabIndex);
            txt_country_id.Enter += new EventHandler(Txt_country_id_Enter);


            lbl_pincode_id.Font = XFont.Font_10B;
            lbl_pincode_id.Name = "lbl_pincode_id";
            lbl_pincode_id.Text = "   Pincode";
            lbl_pincode_id.Anchor = XAnchor.LT;
            lbl_pincode_id.TextAlign = ContentAlignment.MiddleLeft;
            lbl_pincode_id.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_pincode_id.Size = XSize.TwoLabel;
            lbl_pincode_id.Location = XLayout.R1_2Label_2(lbl_country_id.Location);

            txt_pincode_id.Font = XFont.TxtFont;
            txt_pincode_id.ForeColor = XFontColor.TxtFontColor;
            txt_pincode_id.BackColor = XTheme.TxtBackcolor;
            txt_pincode_id.Name = "txt_pincode_id";
            txt_pincode_id.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_pincode_id.Size = XSize.TwoText;
            txt_pincode_id.Anchor = XAnchor.LTR;
            txt_pincode_id.Location = XLayout.R1_2Text_2(txt_country_id.Location);
            txt_pincode_id.TabIndex = XTab.Index(txt_country_id.TabIndex);
            txt_pincode_id.Enter += new EventHandler(Txt_pincode_id_Enter);


            lbl_cell1.Font = XFont.Font_10B;
            lbl_cell1.Name = "lbl_cell1";
            lbl_cell1.Text = "   Cell";
            lbl_cell1.Anchor = XAnchor.LT;
            lbl_cell1.TextAlign = ContentAlignment.MiddleLeft;
            lbl_cell1.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_cell1.Size = XSize.OneLabel;
            lbl_cell1.Location = XLayout.R2_2Label_1(lbl_pincode_id.Location);

            txt_cell1.Font = XFont.TxtFont;
            txt_cell1.ForeColor = XFontColor.TxtFontColor;
            txt_cell1.BackColor = XTheme.TxtBackcolor;
            txt_cell1.Name = "txt_cell1";
            txt_cell1.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_cell1.Size = XSize.TwoText;
            txt_cell1.Anchor = XAnchor.LT;
            txt_cell1.Location = XLayout.R2_2Text_1(txt_pincode_id.Location);
            txt_cell1.TabIndex = XTab.Index(txt_pincode_id.TabIndex);
            txt_cell1.Enter += new EventHandler(Txt_cell1_Enter);


            lbl_cell2.Font = XFont.Font_10B;
            lbl_cell2.Name = "lbl_cell2";
            lbl_cell2.Text = "   Cell";
            lbl_cell2.Anchor = XAnchor.LT;
            lbl_cell2.TextAlign = ContentAlignment.MiddleLeft;
            lbl_cell2.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_cell2.Size = XSize.TwoLabel;
            lbl_cell2.Location = XLayout.R1_2Label_2(lbl_cell1.Location);

            txt_cell2.Font = XFont.TxtFont;
            txt_cell2.ForeColor = XFontColor.TxtFontColor;
            txt_cell2.BackColor = XTheme.TxtBackcolor;
            txt_cell2.Name = "txt_cell2";
            txt_cell2.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_cell2.Size = XSize.TwoText;
            txt_cell2.Anchor = XAnchor.LTR;
            txt_cell2.Location = XLayout.R1_2Text_2(txt_cell1.Location);
            txt_cell2.TabIndex = XTab.Index(txt_cell1.TabIndex);
            txt_cell2.Enter += new EventHandler(Txt_cell2_Enter);


            lbl_phone.Font = XFont.Font_10B;
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Text = "   Phone";
            lbl_phone.Anchor = XAnchor.LT;
            lbl_phone.TextAlign = ContentAlignment.MiddleLeft;
            lbl_phone.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_phone.Size = XSize.OneLabel;
            lbl_phone.Location = XLayout.R2_2Label_1(lbl_cell2.Location);

            txt_phone.Font = XFont.TxtFont;
            txt_phone.ForeColor = XFontColor.TxtFontColor;
            txt_phone.BackColor = XTheme.TxtBackcolor;
            txt_phone.Name = "txt_phone";
            txt_phone.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_phone.Size = XSize.TwoText;
            txt_phone.Anchor = XAnchor.LT;
            txt_phone.Location = XLayout.R2_2Text_1(txt_cell2.Location);
            txt_phone.TabIndex = XTab.Index(txt_cell2.TabIndex);
            txt_phone.Enter += new EventHandler(Txt_phone_Enter);


            lbl_email.Font = XFont.Font_10B;
            lbl_email.Name = "lbl_email";
            lbl_email.Text = "   Email";
            lbl_email.Anchor = XAnchor.LT;
            lbl_email.TextAlign = ContentAlignment.MiddleLeft;
            lbl_email.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_email.Size = XSize.TwoLabel;
            lbl_email.Location = XLayout.R1_2Label_2(lbl_phone.Location);

            txt_email.Font = XFont.TxtFont;
            txt_email.ForeColor = XFontColor.TxtFontColor;
            txt_email.BackColor = XTheme.TxtBackcolor;
            txt_email.Name = "txt_email";
            txt_email.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_email.Size = XSize.TwoText;
            txt_email.Anchor = XAnchor.LTR;
            txt_email.Location = XLayout.R1_2Text_2(txt_phone.Location);
            txt_email.TabIndex = XTab.Index(txt_phone.TabIndex);
            txt_email.Enter += new EventHandler(Txt_email_Enter);


            lbl_website.Font = XFont.Font_10B;
            lbl_website.Name = "lbl_website";
            lbl_website.Text = "   Website";
            lbl_website.Anchor = XAnchor.LT;
            lbl_website.TextAlign = ContentAlignment.MiddleLeft;
            lbl_website.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_website.Size = XSize.OneLabel;
            lbl_website.Location = XLayout.R2_2Label_1(lbl_email.Location);

            txt_website.Font = XFont.TxtFont;
            txt_website.ForeColor = XFontColor.TxtFontColor;
            txt_website.BackColor = XTheme.TxtBackcolor;
            txt_website.Name = "txt_website";
            txt_website.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_website.Size = XSize.OneText;
            txt_website.Anchor = XAnchor.LTR;
            txt_website.Location = XLayout.R2_2Text_1(txt_email.Location);
            txt_website.TabIndex = XTab.Index(txt_email.TabIndex);
            txt_website.Enter += new EventHandler(Txt_website_Enter);


            lbl_gst.Font = XFont.Font_10B;
            lbl_gst.Name = "lbl_gst";
            lbl_gst.Text = "   Gst No";
            lbl_gst.Anchor = XAnchor.LT;
            lbl_gst.TextAlign = ContentAlignment.MiddleLeft;
            lbl_gst.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_gst.Size = XSize.OneLabel;
            lbl_gst.Location = XLayout.R2_2Label_1(lbl_website.Location);

            txt_gst.Font = XFont.TxtFont;
            txt_gst.ForeColor = XFontColor.TxtFontColor;
            txt_gst.BackColor = XTheme.TxtBackcolor;
            txt_gst.Name = "txt_gst";
            txt_gst.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_gst.Size = XSize.TwoText;
            txt_gst.Anchor = XAnchor.LT;
            txt_gst.Location = XLayout.R2_2Text_1(txt_website.Location);
            txt_gst.TabIndex = XTab.Index(txt_website.TabIndex);
            txt_gst.Enter += new EventHandler(Txt_gst_Enter);


            lbl_pan.Font = XFont.Font_10B;
            lbl_pan.Name = "lbl_pan";
            lbl_pan.Text = "   Pan";
            lbl_pan.Anchor = XAnchor.LT;
            lbl_pan.TextAlign = ContentAlignment.MiddleLeft;
            lbl_pan.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_pan.Size = XSize.TwoLabel;
            lbl_pan.Location = XLayout.R1_2Label_2(lbl_gst.Location);

            txt_pan.Font = XFont.TxtFont;
            txt_pan.ForeColor = XFontColor.TxtFontColor;
            txt_pan.BackColor = XTheme.TxtBackcolor;
            txt_pan.Name = "txt_pan";
            txt_pan.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_pan.Size = XSize.TwoText;
            txt_pan.Anchor = XAnchor.LT;
            txt_pan.Location = XLayout.R1_2Text_2(txt_gst.Location);
            txt_pan.TabIndex = XTab.Index(txt_gst.TabIndex);
            txt_pan.Enter += new EventHandler(Txt_pan_Enter);


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
            btn_save.TabIndex = XTab.Index(txt_pan.TabIndex);
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

            #region [FCompany]

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.split_container);
            this.Name = "fCompany";
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
