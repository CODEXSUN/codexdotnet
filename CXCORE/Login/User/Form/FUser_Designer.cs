// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:37:39 AM

using System;
using System.Windows.Forms;
using CXLIB;
using System.Drawing;
using System.ComponentModel;

namespace CXCORE
{
    public partial class FUser : UserControl
    {
        public FUser()
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

        private XTextBox txt_user_name;
        private XLabel lbl_user_name;
        private XTextBox txt_user_password;
        private XLabel lbl_user_password;
        private xDateTimepicker txt_createon;
        private XLabel lbl_createon;
        private XTextBox txt_role_id;
        private XLabel lbl_role_id;
        private XTextBox txt_entryby;
        private XLabel lbl_entryby;

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

            txt_user_name = new XTextBox();
            lbl_user_name = new XLabel();
            txt_user_password = new XTextBox();
            lbl_user_password = new XLabel();
            txt_createon = new xDateTimepicker();
            lbl_createon = new XLabel();
            txt_role_id = new XTextBox();
            lbl_role_id = new XLabel();
            txt_entryby = new XTextBox();
            lbl_entryby = new XLabel();

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
            finner_panel.Controls.Add(txt_user_name);
            finner_panel.Controls.Add(lbl_user_name);
            finner_panel.Controls.Add(txt_user_password);
            finner_panel.Controls.Add(lbl_user_password);
            finner_panel.Controls.Add(txt_createon);
            finner_panel.Controls.Add(lbl_createon);
            finner_panel.Controls.Add(txt_role_id);
            finner_panel.Controls.Add(lbl_role_id);
            finner_panel.Controls.Add(txt_entryby);
            finner_panel.Controls.Add(lbl_entryby);
            finner_panel.Controls.Add(btn_save);
            finner_panel.Controls.Add(btn_active);

            #endregion[adding controls]

            #region[Header]

            btn_close.Click += new EventHandler(Btn_close_Click);

            lbl_header.Text = "User";

            #endregion[Header]

            #region[Properties of control]

            lbl_user_name.Font = XFont.Font_10B;
            lbl_user_name.Name = "lbl_user_name";
            lbl_user_name.Text = "   User name";
            lbl_user_name.Anchor = XAnchor.LT;
            lbl_user_name.TextAlign = ContentAlignment.MiddleLeft;
            lbl_user_name.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_user_name.Size = XSize.OneLabel;
            lbl_user_name.Location = XLayout.FirstLabel;

            txt_user_name.Font = XFont.TxtFont;
            txt_user_name.ForeColor = XFontColor.TxtFontColor;
            txt_user_name.BackColor = XTheme.TxtBackcolor;
            txt_user_name.Name = "txt_user_name";
            txt_user_name.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_user_name.Size = XSize.OneText;
            txt_user_name.Anchor = XAnchor.LTR;
            txt_user_name.Location = XLayout.FirstText;
            txt_user_name.TabIndex = XTab.Txt_TabIndex;
            txt_user_name.Enter += new EventHandler(Txt_user_name_Enter);


            lbl_user_password.Font = XFont.Font_10B;
            lbl_user_password.Name = "lbl_user_password";
            lbl_user_password.Text = "   User password";
            lbl_user_password.Anchor = XAnchor.LT;
            lbl_user_password.TextAlign = ContentAlignment.MiddleLeft;
            lbl_user_password.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_user_password.Size = XSize.OneLabel;
            lbl_user_password.Location = XLayout.R1_Label(lbl_user_name.Location);

            txt_user_password.Font = XFont.TxtFont;
            txt_user_password.ForeColor = XFontColor.TxtFontColor;
            txt_user_password.BackColor = XTheme.TxtBackcolor;
            txt_user_password.Name = "txt_user_password";
            txt_user_password.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_user_password.Size = XSize.OneText;
            txt_user_password.Anchor = XAnchor.LTR;
            txt_user_password.Location = XLayout.R1_Text(txt_user_name.Location);
            txt_user_password.TabIndex = XTab.Index(txt_user_name.TabIndex);
            txt_user_password.Enter += new EventHandler(Txt_user_password_Enter);


            lbl_createon.Font = XFont.Font_10B;
            lbl_createon.Name = "lbl_createon";
            lbl_createon.Text = "   Createon";
            lbl_createon.Anchor = XAnchor.LT;
            lbl_createon.TextAlign = ContentAlignment.MiddleLeft;
            lbl_createon.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_createon.Size = XSize.OneLabel;
            lbl_createon.Location = XLayout.R1_Label(lbl_user_password.Location);

            txt_createon.Font = XFont.TxtFont;
            txt_createon.ForeColor = XFontColor.TxtFontColor;
            txt_createon.BackColor = XTheme.TxtBackcolor;
            txt_createon.Name = "txt_createon";
            txt_createon.CustomFormat = "dd-MM-yyyy hh:mm:ss tt";
            txt_createon.Format = DateTimePickerFormat.Custom;
            txt_createon.Size = XSize.OneText;
            txt_createon.Anchor = XAnchor.LTR;
            txt_createon.Location = XLayout.R1_Text(txt_user_password.Location);
            txt_createon.TabIndex = XTab.Index(txt_user_password.TabIndex);
            txt_createon.Enter += new EventHandler(Txt_createon_Enter);


            lbl_role_id.Font = XFont.Font_10B;
            lbl_role_id.Name = "lbl_role_id";
            lbl_role_id.Text = "   Role id";
            lbl_role_id.Anchor = XAnchor.LT;
            lbl_role_id.TextAlign = ContentAlignment.MiddleLeft;
            lbl_role_id.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_role_id.Size = XSize.OneLabel;
            lbl_role_id.Location = XLayout.R1_Label(lbl_createon.Location);

            txt_role_id.Font = XFont.TxtFont;
            txt_role_id.ForeColor = XFontColor.TxtFontColor;
            txt_role_id.BackColor = XTheme.TxtBackcolor;
            txt_role_id.Name = "txt_role_id";
            txt_role_id.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_role_id.Size = XSize.OneText;
            txt_role_id.Anchor = XAnchor.LTR;
            txt_role_id.Location = XLayout.R1_Text(txt_createon.Location);
            txt_role_id.TabIndex = XTab.Index(txt_createon.TabIndex);
            txt_role_id.Enter += new EventHandler(Txt_role_id_Enter);


            lbl_entryby.Font = XFont.Font_10B;
            lbl_entryby.Name = "lbl_entryby";
            lbl_entryby.Text = "   Entryby";
            lbl_entryby.Anchor = XAnchor.LT;
            lbl_entryby.TextAlign = ContentAlignment.MiddleLeft;
            lbl_entryby.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_entryby.Size = XSize.OneLabel;
            lbl_entryby.Location = XLayout.R1_Label(lbl_role_id.Location);

            txt_entryby.Font = XFont.TxtFont;
            txt_entryby.ForeColor = XFontColor.TxtFontColor;
            txt_entryby.BackColor = XTheme.TxtBackcolor;
            txt_entryby.Name = "txt_entryby";
            txt_entryby.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_entryby.Size = XSize.OneText;
            txt_entryby.Anchor = XAnchor.LTR;
            txt_entryby.Location = XLayout.R1_Text(txt_role_id.Location);
            txt_entryby.TabIndex = XTab.Index(txt_role_id.TabIndex);
            txt_entryby.Enter += new EventHandler(Txt_entryby_Enter);


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
            btn_save.TabIndex = XTab.Index(txt_entryby.TabIndex);
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

            #region [FUser]

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.split_container);
            this.Name = "fUser";
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
