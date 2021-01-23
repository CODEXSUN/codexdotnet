// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 07-08-2020 07:48:01 AM

using System;
using System.Windows.Forms;
using CXLIB;
using System.Drawing;
using System.ComponentModel;

namespace CXCORE
{ 
    public partial class FAcy : UserControl 
    { 
        public FAcy() 
        {
            InitializeComponent();
            Initialize();
            Setactives();
            SetFocus(); 
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

        private XTextBox txt_acy_name;
        private XLabel lbl_acy_name;
        private xDatepicker txt_from_date;
        private XLabel lbl_from_date;
        private xDatepicker txt_to_date;
        private XLabel lbl_to_date;

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

            txt_acy_name = new XTextBox();
            lbl_acy_name = new XLabel();
            txt_from_date = new xDatepicker();
            lbl_from_date = new XLabel();
            txt_to_date = new xDatepicker();
            lbl_to_date = new XLabel();

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
            finner_panel.Controls.Add(txt_acy_name);
            finner_panel.Controls.Add(lbl_acy_name);
            finner_panel.Controls.Add(txt_from_date);
            finner_panel.Controls.Add(lbl_from_date);
            finner_panel.Controls.Add(txt_to_date);
            finner_panel.Controls.Add(lbl_to_date);
            finner_panel.Controls.Add(btn_save);
            finner_panel.Controls.Add(btn_active);

            #endregion[adding controls]

            #region[Header]

            btn_close.Click += new EventHandler(Btn_close_Click);

            lbl_header.Text = "Acy tbl";

            #endregion[Header]

            #region[Properties of control]

            lbl_acy_name.Font = XFont.Font_10B;
            lbl_acy_name.Name = "lbl_acy_name";
            lbl_acy_name.Text = "   Acy name";
            lbl_acy_name.Anchor = XAnchor.LT;
            lbl_acy_name.TextAlign = ContentAlignment.MiddleLeft;
            lbl_acy_name.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_acy_name.Size =  XSize.OneLabel;
            lbl_acy_name.Location =XLayout.FirstLabel;

            txt_acy_name.Font = XFont.TxtFont;
            txt_acy_name.ForeColor = XFontColor.TxtFontColor;
            txt_acy_name.BackColor = XTheme.TxtBackcolor;
            txt_acy_name.Name = "txt_acy_name";
            txt_acy_name.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_acy_name.Size =  XSize.OneText;
            txt_acy_name.Anchor = XAnchor.LTR;
            txt_acy_name.Location =XLayout.FirstText;
            txt_acy_name.TabIndex = XTab.Txt_TabIndex;
            txt_acy_name.Enter += new EventHandler(Txt_acy_name_Enter);


            lbl_from_date.Font = XFont.Font_10B;
            lbl_from_date.Name = "lbl_from_date";
            lbl_from_date.Text = "   From date";
            lbl_from_date.Anchor = XAnchor.LT;
            lbl_from_date.TextAlign = ContentAlignment.MiddleLeft;
            lbl_from_date.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_from_date.Size =  XSize.OneLabel;
            lbl_from_date.Location =XLayout.R1_Label(lbl_acy_name.Location);

            txt_from_date.Font = XFont.TxtFont;
            txt_from_date.ForeColor = XFontColor.TxtFontColor;
            txt_from_date.BackColor = XTheme.TxtBackcolor;
            txt_from_date.Name = "txt_from_date";
            txt_from_date.CustomFormat = "dd-MM-yyyy";
            txt_from_date.Format = DateTimePickerFormat.Custom;
            txt_from_date.Size =  XSize.OneText;
            txt_from_date.Anchor = XAnchor.LTR;
            txt_from_date.Location =XLayout.R1_Text(txt_acy_name.Location);
            txt_from_date.TabIndex = XTab.Index(txt_acy_name.TabIndex);
            txt_from_date.Enter += new EventHandler(Txt_from_date_Enter);


            lbl_to_date.Font = XFont.Font_10B;
            lbl_to_date.Name = "lbl_to_date";
            lbl_to_date.Text = "   To date";
            lbl_to_date.Anchor = XAnchor.LT;
            lbl_to_date.TextAlign = ContentAlignment.MiddleLeft;
            lbl_to_date.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_to_date.Size =  XSize.OneLabel;
            lbl_to_date.Location =XLayout.R1_Label(lbl_from_date.Location);

            txt_to_date.Font = XFont.TxtFont;
            txt_to_date.ForeColor = XFontColor.TxtFontColor;
            txt_to_date.BackColor = XTheme.TxtBackcolor;
            txt_to_date.Name = "txt_to_date";
            txt_to_date.CustomFormat = "dd-MM-yyyy";
            txt_to_date.Format = DateTimePickerFormat.Custom;
            txt_to_date.Size =  XSize.OneText;
            txt_to_date.Anchor = XAnchor.LTR;
            txt_to_date.Location =XLayout.R1_Text(txt_from_date.Location);
            txt_to_date.TabIndex = XTab.Index(txt_from_date.TabIndex);
            txt_to_date.Enter += new EventHandler(Txt_to_date_Enter);


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
            btn_save.TabIndex = XTab.Index(txt_to_date.TabIndex);
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

            #region [FAcy]

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.split_container);
            this.Name = "fAcy";
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
