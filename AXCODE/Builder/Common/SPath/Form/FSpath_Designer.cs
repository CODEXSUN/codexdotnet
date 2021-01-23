// Version : 2.1.0.0 dt : 04-12-2018
// Auto Generated
// 07-12-2018 07:36:37 AM
// last update : 07-12-2018

using System;
using System.Windows.Forms;
using CXLIB;
using System.Drawing;
using System.ComponentModel;

namespace AXCODE
{
    public partial class FSpath : UserControl
    {
        public FSpath()
        {
            InitializeComponent();
            Initialize();
            Setactives();
            SetFocus();
            Mtables_lookup();
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

        private LookupBox txt_stables_id;
        private XLabel lbl_stables_id;
        private XTextBox txt_root_folder;
        private XLabel lbl_root_folder;
        private XTextBox txt_contfolder;
        private XLabel lbl_contfolder;
        private XTextBox txt_classfolder;
        private XLabel lbl_classfolder;
        private XTextBox txt_formfolder;
        private XLabel lbl_formfolder;
        private XTextBox txt_listfolder;
        private XLabel lbl_listfolder;
        private XTextBox txt_setupfolder;
        private XLabel lbl_setupfolder;
        private XTextBox txt_testfolder;
        private XLabel lbl_testfolder;

        private RichTextBox txt_notes;
        private XLabel lbl_notes;
        private OfficeButton btn_save;
        private OfficeButton btn_active;
        private OfficeButton btn_root;

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

            txt_stables_id = new LookupBox();
            lbl_stables_id = new XLabel();
            txt_root_folder = new XTextBox();
            lbl_root_folder = new XLabel();
            txt_contfolder = new XTextBox();
            lbl_contfolder = new XLabel();
            txt_classfolder = new XTextBox();
            lbl_classfolder = new XLabel();
            txt_formfolder = new XTextBox();
            lbl_formfolder = new XLabel();
            txt_listfolder = new XTextBox();
            lbl_listfolder = new XLabel();
            txt_setupfolder = new XTextBox();
            lbl_setupfolder = new XLabel();
            txt_testfolder = new XTextBox();
            lbl_testfolder = new XLabel();

            txt_notes = new RichTextBox();
            lbl_notes = new XLabel();
            btn_save = new OfficeButton();
            btn_active = new OfficeButton();
            btn_root = new OfficeButton();

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
            finner_panel.Controls.Add(txt_stables_id);
            finner_panel.Controls.Add(lbl_stables_id);
            finner_panel.Controls.Add(txt_root_folder);
            finner_panel.Controls.Add(lbl_root_folder);
            finner_panel.Controls.Add(txt_contfolder);
            finner_panel.Controls.Add(lbl_contfolder);
            finner_panel.Controls.Add(txt_classfolder);
            finner_panel.Controls.Add(lbl_classfolder);
            finner_panel.Controls.Add(txt_formfolder);
            finner_panel.Controls.Add(lbl_formfolder);
            finner_panel.Controls.Add(txt_listfolder);
            finner_panel.Controls.Add(lbl_listfolder);
            finner_panel.Controls.Add(txt_setupfolder);
            finner_panel.Controls.Add(lbl_setupfolder);
            finner_panel.Controls.Add(txt_testfolder);
            finner_panel.Controls.Add(lbl_testfolder);
            finner_panel.Controls.Add(btn_save);
            finner_panel.Controls.Add(btn_active);
            finner_panel.Controls.Add(btn_root);


            #endregion[adding controls]

            #region[Header]

            btn_close.Click += new EventHandler(Btn_close_Click);

            lbl_header.Text = "Spath";

            #endregion[Header]

            #region[Properties of control]

            lbl_stables_id.Font = XFont.Font_10B;
            lbl_stables_id.Name = "lbl_stables_id";
            lbl_stables_id.Text = "   Stables id";
            lbl_stables_id.Anchor = XAnchor.LT;
            lbl_stables_id.TextAlign = ContentAlignment.MiddleLeft;
            lbl_stables_id.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_stables_id.Size = XSize.OneLabel;
            lbl_stables_id.Location = XLayout.FirstLabel;

            txt_stables_id.Font = XFont.TxtFont;
            txt_stables_id.ForeColor = XFontColor.TxtFontColor;
            txt_stables_id.BackColor = XTheme.TxtBackcolor;
            txt_stables_id.Name = "txt_stables_id";
            txt_stables_id.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_stables_id.Size = XSize.OneText;
            txt_stables_id.Anchor = XAnchor.LTR;
            txt_stables_id.Location = XLayout.FirstText;
            txt_stables_id.TabIndex = XTab.Txt_TabIndex;
            txt_stables_id.Enter += new EventHandler(Txt_mtables_id_Enter);


            lbl_root_folder.Font = XFont.Font_10B;
            lbl_root_folder.Name = "lbl_root_folder";
            lbl_root_folder.Text = "   Root folder";
            lbl_root_folder.Anchor = XAnchor.LT;
            lbl_root_folder.TextAlign = ContentAlignment.MiddleLeft;
            lbl_root_folder.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_root_folder.Size = XSize.OneLabel;
            lbl_root_folder.Location = XLayout.R1_Label(lbl_stables_id.Location);

            txt_root_folder.Font = XFont.TxtFont;
            txt_root_folder.ForeColor = XFontColor.TxtFontColor;
            txt_root_folder.BackColor = XTheme.TxtBackcolor;
            txt_root_folder.Name = "txt_root_folder";
            txt_root_folder.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_root_folder.Size = XSize.OneText;
            txt_root_folder.Anchor = XAnchor.LTR;
            txt_root_folder.Location = XLayout.R1_Text(txt_stables_id.Location);
            txt_root_folder.TabIndex = XTab.Index(txt_stables_id.TabIndex);
            txt_root_folder.Enter += new EventHandler(Txt_root_folder_Enter);


            lbl_contfolder.Font = XFont.Font_10B;
            lbl_contfolder.Name = "lbl_contfolder";
            lbl_contfolder.Text = "   Cont folder";
            lbl_contfolder.Anchor = XAnchor.LT;
            lbl_contfolder.TextAlign = ContentAlignment.MiddleLeft;
            lbl_contfolder.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_contfolder.Size = XSize.OneLabel;
            lbl_contfolder.Location = XLayout.R1_Label(lbl_root_folder.Location);

            txt_contfolder.Font = XFont.TxtFont;
            txt_contfolder.ForeColor = XFontColor.TxtFontColor;
            txt_contfolder.BackColor = XTheme.TxtBackcolor;
            txt_contfolder.Name = "txt_contfolder";
            txt_contfolder.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_contfolder.Size = XSize.OneText;
            txt_contfolder.Anchor = XAnchor.LTR;
            txt_contfolder.Location = XLayout.R1_Text(txt_root_folder.Location);
            txt_contfolder.TabIndex = XTab.Index(txt_root_folder.TabIndex);
            txt_contfolder.Enter += new EventHandler(Txt_contfolder_Enter);


            lbl_classfolder.Font = XFont.Font_10B;
            lbl_classfolder.Name = "lbl_classfolder";
            lbl_classfolder.Text = "   Class folder";
            lbl_classfolder.Anchor = XAnchor.LT;
            lbl_classfolder.TextAlign = ContentAlignment.MiddleLeft;
            lbl_classfolder.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_classfolder.Size = XSize.OneLabel;
            lbl_classfolder.Location = XLayout.R1_Label(lbl_contfolder.Location);

            txt_classfolder.Font = XFont.TxtFont;
            txt_classfolder.ForeColor = XFontColor.TxtFontColor;
            txt_classfolder.BackColor = XTheme.TxtBackcolor;
            txt_classfolder.Name = "txt_classfolder";
            txt_classfolder.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_classfolder.Size = XSize.OneText;
            txt_classfolder.Anchor = XAnchor.LTR;
            txt_classfolder.Location = XLayout.R1_Text(txt_contfolder.Location);
            txt_classfolder.TabIndex = XTab.Index(txt_contfolder.TabIndex);
            txt_classfolder.Enter += new EventHandler(Txt_classfolder_Enter);


            lbl_formfolder.Font = XFont.Font_10B;
            lbl_formfolder.Name = "lbl_formfolder";
            lbl_formfolder.Text = "   Form folder";
            lbl_formfolder.Anchor = XAnchor.LT;
            lbl_formfolder.TextAlign = ContentAlignment.MiddleLeft;
            lbl_formfolder.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_formfolder.Size = XSize.OneLabel;
            lbl_formfolder.Location = XLayout.R1_Label(lbl_classfolder.Location);

            txt_formfolder.Font = XFont.TxtFont;
            txt_formfolder.ForeColor = XFontColor.TxtFontColor;
            txt_formfolder.BackColor = XTheme.TxtBackcolor;
            txt_formfolder.Name = "txt_formfolder";
            txt_formfolder.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_formfolder.Size = XSize.OneText;
            txt_formfolder.Anchor = XAnchor.LTR;
            txt_formfolder.Location = XLayout.R1_Text(txt_classfolder.Location);
            txt_formfolder.TabIndex = XTab.Index(txt_classfolder.TabIndex);
            txt_formfolder.Enter += new EventHandler(Txt_formfolder_Enter);


            lbl_listfolder.Font = XFont.Font_10B;
            lbl_listfolder.Name = "lbl_listfolder";
            lbl_listfolder.Text = "   List folder";
            lbl_listfolder.Anchor = XAnchor.LT;
            lbl_listfolder.TextAlign = ContentAlignment.MiddleLeft;
            lbl_listfolder.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_listfolder.Size = XSize.OneLabel;
            lbl_listfolder.Location = XLayout.R1_Label(lbl_formfolder.Location);

            txt_listfolder.Font = XFont.TxtFont;
            txt_listfolder.ForeColor = XFontColor.TxtFontColor;
            txt_listfolder.BackColor = XTheme.TxtBackcolor;
            txt_listfolder.Name = "txt_listfolder";
            txt_listfolder.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_listfolder.Size = XSize.OneText;
            txt_listfolder.Anchor = XAnchor.LTR;
            txt_listfolder.Location = XLayout.R1_Text(txt_formfolder.Location);
            txt_listfolder.TabIndex = XTab.Index(txt_formfolder.TabIndex);
            txt_listfolder.Enter += new EventHandler(Txt_listfolder_Enter);


            lbl_setupfolder.Font = XFont.Font_10B;
            lbl_setupfolder.Name = "lbl_setupfolder";
            lbl_setupfolder.Text = "   Setup folder";
            lbl_setupfolder.Anchor = XAnchor.LT;
            lbl_setupfolder.TextAlign = ContentAlignment.MiddleLeft;
            lbl_setupfolder.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_setupfolder.Size = XSize.OneLabel;
            lbl_setupfolder.Location = XLayout.R1_Label(lbl_listfolder.Location);

            txt_setupfolder.Font = XFont.TxtFont;
            txt_setupfolder.ForeColor = XFontColor.TxtFontColor;
            txt_setupfolder.BackColor = XTheme.TxtBackcolor;
            txt_setupfolder.Name = "txt_setupfolder";
            txt_setupfolder.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_setupfolder.Size = XSize.OneText;
            txt_setupfolder.Anchor = XAnchor.LTR;
            txt_setupfolder.Location = XLayout.R1_Text(txt_listfolder.Location);
            txt_setupfolder.TabIndex = XTab.Index(txt_listfolder.TabIndex);
            txt_setupfolder.Enter += new EventHandler(Txt_setupfolder_Enter);


            lbl_testfolder.Font = XFont.Font_10B;
            lbl_testfolder.Name = "lbl_testfolder";
            lbl_testfolder.Text = "   Test folder";
            lbl_testfolder.Anchor = XAnchor.LT;
            lbl_testfolder.TextAlign = ContentAlignment.MiddleLeft;
            lbl_testfolder.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_testfolder.Size = XSize.OneLabel;
            lbl_testfolder.Location = XLayout.R1_Label(lbl_setupfolder.Location);

            txt_testfolder.Font = XFont.TxtFont;
            txt_testfolder.ForeColor = XFontColor.TxtFontColor;
            txt_testfolder.BackColor = XTheme.TxtBackcolor;
            txt_testfolder.Name = "txt_testfolder";
            txt_testfolder.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_testfolder.Size = XSize.OneText;
            txt_testfolder.Anchor = XAnchor.LTR;
            txt_testfolder.Location = XLayout.R1_Text(txt_setupfolder.Location);
            txt_testfolder.TabIndex = XTab.Index(txt_setupfolder.TabIndex);
            txt_testfolder.Enter += new EventHandler(Txt_testfolder_Enter);


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
            btn_save.TabIndex = XTab.Index(txt_testfolder.TabIndex);
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

            btn_root.Anchor = XAnchor.RB;
            btn_root.Font = XFont.BtnFont;
            btn_root.Size = XSize.BtnOne;
            btn_root.Location = new Point(btn_active.Right + 100, btn_active.Top);
            btn_root.TabIndex = XTab.Index(btn_active.TabIndex);
            btn_root.Name = "btn_root";
            btn_root.Text = "&Set Folder";
            btn_root.Themes = XTheme.PinkBtn;
            btn_root.Click += new EventHandler(Btn_root_Click);

            txt_notes.TabIndex = btn_active.TabIndex + 1;

            #endregion[Properties of btn]

            #endregion[finner_panel]

            #region [Fspath]

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.split_container);
            this.Name = "fspath";
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

