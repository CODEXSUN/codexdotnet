//Version : 1 dt : 11-07-2017
//Auto
//13-07-2017 10:30:32 PM
//create date : 13-07-2017
//last update : 13-07-2017

using System;
using System.Windows.Forms;
using CXLIB;
using System.Drawing;
using System.ComponentModel;


namespace AXCODE
{ 
    public partial class FDatabases : UserControl 
    { 
        public FDatabases() 
        {
            InitializeComponent();
            Initialize();
            Setactives();
            SetFocus(); 
        }
        
        #region [Private Declar]
        //
        private Timer splitTimer;
        private SplitContainer split_container;
        private XShadowPanel fpanel;
        private Panel f_inner_panel;
        private Button btn_close;
        private Label lbl_header;
        private OfficeButton btn_list;
        private OfficeButton btn_new;
        private OfficeButton btn_edit;
        private OfficeButton btn_delete;
        private OfficeButton btn_print;
        private OfficeButton btn_splitter;
        //
        private XTextBox txt_databases_name;
        private XLabel lbl_databases_name;
        private RichTextBox txt_notes;
        private XLabel lbl_notes;
        private OfficeButton btn_save;
        private OfficeButton btn_cancel;
        private OfficeButton btn_not_active;
        private OfficeButton btn_active;
        //
        #endregion [Private Declar]
        private void Initialize() 
        { 
            #region[declare new]
            components = new Container();
            splitTimer = new Timer(components);
            split_container = new SplitContainer();
            fpanel = new XShadowPanel();
            f_inner_panel = new Panel();
            btn_list = new OfficeButton();
            btn_new = new OfficeButton();
            btn_edit = new OfficeButton();
            btn_delete = new OfficeButton();
            btn_print = new OfficeButton();
            btn_splitter = new OfficeButton();
            lbl_header = new Label();
            btn_close = new Button();
            txt_databases_name = new XTextBox();
            lbl_databases_name = new XLabel();
            txt_notes = new RichTextBox();
            lbl_notes = new XLabel();
            btn_save = new OfficeButton();
            btn_cancel = new OfficeButton();
            btn_not_active = new OfficeButton();
            btn_active = new OfficeButton();
            #endregion[declare new]
            //
            #region[container suspend]
            //
            ((ISupportInitialize)(split_container)).BeginInit();
            split_container.Panel1.SuspendLayout();
            split_container.Panel2.SuspendLayout();
            split_container.SuspendLayout();
            fpanel.SuspendLayout();
            f_inner_panel.SuspendLayout();
            SuspendLayout();
            //
            #endregion[container suspend]
            //
            #region[splitTimer]
            //
            splitTimer.Interval = 2;
            splitTimer.Tick += new EventHandler(SplitTimer_Tick);
            //
            #endregion[splitTimer]
            //
            #region[split_container]
            //
            split_container.Dock = DockStyle.Fill;
            split_container.Location = new Point(0, 0);
            split_container.Name = "split_container";
            split_container.Size = new Size(Theme.Screen_Width, Theme.Screen_Heigth);
            split_container.SplitterDistance = Theme.Screen_Width;
            split_container.TabIndex = 0;
            //
            // split_container.Panel1
            //
            split_container.Panel1.Controls.Add(fpanel);
            split_container.Panel1.BackColor = Theme.Fpanel1_Backcolor;
            //
            #region[split_container.Panel2]
            //
            split_container.Panel2.BackColor = Theme.Fpanel2_Backcolor;
            split_container.Panel2.Controls.Add(btn_print);
            split_container.Panel2.Controls.Add(btn_delete);
            split_container.Panel2.Controls.Add(btn_edit);
            split_container.Panel2.Controls.Add(btn_new);
            split_container.Panel2.Controls.Add(btn_list);
            split_container.Panel2.Controls.Add(btn_splitter);
            //
            btn_list.Font = Theme.btnFont;
            btn_list.Location = new Point(Theme.F_btn_list_left,Theme.F_btn_list_top);
            btn_list.Size = new Size(Theme.F_btn_list_width, Theme.F_btn_list_height);
            btn_list.TabIndex = 1;
            btn_list.Name = "btn_list";
            btn_list.Text = "&List";
            btn_list.Themes = Theme.BlueBtn;
            btn_list.Click += Btn_list_Click;
            //
            btn_new.Font = Theme.btnFont;
            btn_new.Location = new Point(Theme.F_btn_list_left, (btn_list.Bottom + Theme.F_btn_gap));
            btn_new.Size = new Size(Theme.F_btn_list_width, Theme.F_btn_list_height);
            btn_new.TabIndex = btn_list.TabIndex + 1;
            btn_new.Name = "btn_new";
            btn_new.Text = "&New";
            btn_new.Themes = Theme.BlueBtn;
            btn_new.Click += Btn_new_Click;
            //
            btn_edit.Font = Theme.btnFont;
            btn_edit.Location = new Point(Theme.F_btn_list_left, (btn_new.Bottom + Theme.F_btn_gap));
            btn_edit.Size = new Size(Theme.F_btn_list_width, Theme.F_btn_list_height);
            btn_edit.TabIndex = btn_new.TabIndex + 1;
            btn_edit.Name = "btn_edit";
            btn_edit.Text = "&Edit";
            btn_edit.Themes = Theme.BlueBtn;
            btn_edit.Click += Btn_edit_Click;
            //
            btn_delete.Font = Theme.btnFont;
            btn_delete.Location = new Point(Theme.F_btn_list_left, (btn_edit.Bottom + Theme.F_btn_gap));
            btn_delete.Size = new Size(Theme.F_btn_list_width, Theme.F_btn_list_height);
            btn_delete.TabIndex = btn_edit.TabIndex + 1;
            btn_delete.Name = "btn_delete";
            btn_delete.Text = "&Delete";
            btn_delete.Themes = Theme.BlueBtn;
            btn_delete.Click += Btn_delete_Click;
            //
            btn_print.Font = Theme.btnFont;
            btn_print.Location = new Point(Theme.F_btn_list_left, (btn_delete.Bottom + Theme.F_btn_gap));
            btn_print.Size = new Size(Theme.F_btn_list_width, Theme.F_btn_list_height);
            btn_print.TabIndex = btn_delete.TabIndex + 1;
            btn_print.Name = "btn_print";
            btn_print.Text = "&Print";
            btn_print.Themes = Theme.BlueBtn;
            btn_print.Click += Btn_print_Click;
            //
            btn_splitter.Font = Theme.btnFont;
            btn_splitter.Location = new Point(Theme.F_btn_list_left - 30, Theme.F_btn_list_top);
            btn_splitter.Size = new Size(Theme.F_btn_spliter_width, btn_print.Bottom - btn_list.Top);
            btn_splitter.TabIndex = btn_print.TabIndex + 1;
            btn_splitter.Name = "btn_splitter";
            btn_splitter.Text = "⁞⁞";
            btn_splitter.Themes = Theme.WhiteBtn;
            btn_splitter.Click += new EventHandler(Btn_splitter_Click);
            //
            #endregion[split_container.Panel2]
            //
            #endregion[split_container]
            //
            #region[fpanel]
            //
            fpanel.Name = "fpanel";
            fpanel.Anchor = ((AnchorStyles)((AnchorStyles.Top)) | ((AnchorStyles.Right)) | ((AnchorStyles.Left)));
            fpanel.Controls.Add(f_inner_panel);
            fpanel.Size = new Size(Theme.Fpanel_width, Theme.Fpanel_height);
            fpanel.Location = new Point(Theme.Fpanel_left, Theme.Fpanel_top);
            fpanel.BackColor = Theme.Fpanel_Backcolor;
            fpanel.TabIndex = 1;
            //
            #endregion[fpanel]
            //
            #region[f_inner_panel]
            //
            f_inner_panel.Anchor = ((AnchorStyles)((AnchorStyles.Top)) | ((AnchorStyles.Right)) | ((AnchorStyles.Left)));
            f_inner_panel.Cursor = Cursors.Default;
            f_inner_panel.Name = "f_inner_panel";
            f_inner_panel.Size = new Size(Theme.Fpanel_width - 11, Theme.Fpanel_height - 11);
            f_inner_panel.Location = new Point(6, 0);
            f_inner_panel.BackColor = Theme.F_inner_panel_Backcolor;
            f_inner_panel.AutoScroll = true;
            f_inner_panel.TabIndex = 2;
            //
            #region[adding controls]
            //
            f_inner_panel.Controls.Add(btn_close);
            f_inner_panel.Controls.Add(lbl_header);
            f_inner_panel.Controls.Add(txt_notes);
            f_inner_panel.Controls.Add(lbl_notes);
            f_inner_panel.Controls.Add(txt_databases_name);
            f_inner_panel.Controls.Add(lbl_databases_name);
            f_inner_panel.Controls.Add(btn_save);
            f_inner_panel.Controls.Add(btn_cancel);
            f_inner_panel.Controls.Add(btn_not_active);
            f_inner_panel.Controls.Add(btn_active);
            //
            #endregion[adding controls]
            //
            #region[Header]
            //
            btn_close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_close.BackColor = Color.FromArgb(0, 97, 168);
            btn_close.Cursor = Cursors.Default;
            btn_close.FlatAppearance.BorderSize = 0;
            btn_close.FlatAppearance.MouseDownBackColor = Color.OrangeRed;
            btn_close.FlatAppearance.MouseOverBackColor = Color.Crimson;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_close.ForeColor = Color.FromArgb(217, 237, 255);
            btn_close.Location = new Point(Theme.F_btn_close_left, Theme.F_btn_close_top);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(Theme.btn_close_width, Theme.btn_close_height);
            btn_close.TabIndex = 30;
            btn_close.Text = "X";
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += new EventHandler(Btn_close_Click);
            //
            lbl_header.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_header.BackColor = Theme.F_header_Backcolor;
            lbl_header.Cursor = Cursors.Default;
            lbl_header.Font = Theme.F_header_Font;
            lbl_header.ForeColor = Theme.F_headerText_Fontcolor;
            lbl_header.Location = new Point(-5, 0);
            lbl_header.Name = "lbl_header";
            lbl_header.Size = new Size(Theme.F_header_width, Theme.F_header_height);
            lbl_header.Text = "Databases";
            lbl_header.TextAlign = ContentAlignment.MiddleCenter;
            //
            #endregion[Header]
            //
            #region[Properties of control]
            //
            lbl_databases_name.Font = Theme.Font_10B;
            lbl_databases_name.ForeColor = Theme.lbl_ForeColor;
            lbl_databases_name.Location = new Point(Theme.lbl_left, Theme.lbl_top);
            lbl_databases_name.Size = new Size(Theme.OneLabelColumn, Theme.OneLabelHeight);
            lbl_databases_name.Name = "lbl_databases_name";
            lbl_databases_name.Text = "   Databases Name";
            lbl_databases_name.Anchor = (AnchorStyles)(AnchorStyles.Top | AnchorStyles.Left);
            lbl_databases_name.TextAlign = ContentAlignment.MiddleLeft;
            lbl_databases_name.TabIndex = Theme.lbl_TabIndex;
            //
            txt_databases_name.Font = Theme.txtFont;
            txt_databases_name.ForeColor = Theme.txtForeColor;
            txt_databases_name.BackColor = Theme.txt_Backcolor;
            txt_databases_name.ReadOnlyBackColor = Theme.txt_Readonly_Backcolor;
            txt_databases_name.Location = new Point(Theme.txt_left, Theme.txt_top);
            txt_databases_name.Size = new Size(Theme.OneTextColumn, Theme.txt_Height);
            txt_databases_name.Name = "txt_databases_name";
            txt_databases_name.Anchor = (AnchorStyles)(AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            txt_databases_name.TabIndex = Theme.txt_TabIndex;
            txt_databases_name.Enter += new EventHandler(Txt_databases_name_Enter);
            //
            lbl_notes.Font = Theme.Font_10B;
            lbl_notes.ForeColor = Theme.lbl_ForeColor;
            lbl_notes.Location = new Point(Theme.lbl_left, Theme.Fpanel_height - 75);
            lbl_notes.Size = new Size(Theme.F_lbl_notes_width, Theme.F_lbl_notes_height);
            lbl_notes.Anchor = (AnchorStyles)(AnchorStyles.Left | AnchorStyles.Bottom);
            lbl_notes.Name = "lbl_notes";
            lbl_notes.Text = "   Notes";
            lbl_notes.TextAlign = ContentAlignment.MiddleLeft;
            lbl_notes.TabIndex = lbl_databases_name.TabIndex + 1;
            lbl_notes.Click += new EventHandler(Lbl_notes_Click);
            //
            txt_notes.Font = Theme.txtFont;
            txt_notes.ForeColor = Theme.txtForeColor;
            txt_notes.BackColor = Theme.White;
            txt_notes.Location = new Point(Theme.txt_left, Theme.Fpanel_height - 75);
            txt_notes.Size = new Size(Theme.F_txt_notes_width, Theme.F_txt_notes_height);
            txt_notes.Name = "txt_notes";
            txt_notes.Anchor = (AnchorStyles)(AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right);
            txt_notes.Enter += new EventHandler(Txt_notes_Enter);
            //
            #endregion[Properties of control]
            //
            #region[Properties of btn]
            //
            btn_save.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            btn_save.Font = Theme.btnFont;
            btn_save.Size = new Size(Theme.F_btn_width, Theme.F_btn_height);
            btn_save.Location = new Point(Theme.F_btn_save_left, Theme.F_btn_save_top);
            btn_save.TabIndex = txt_databases_name.TabIndex + 1;
            btn_save.Name = "btn_save";
            btn_save.Text = "&SAVE";
            btn_save.Themes = Theme.BlueBtn;
            btn_save.Click += new EventHandler(Btn_save_click);
            //
            btn_cancel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            btn_cancel.Font = Theme.btnFont;
            btn_cancel.Size = new Size(Theme.F_btn_width, Theme.F_btn_height);
            btn_cancel.Location = new Point(Theme.F_btn_cancel_left, Theme.F_btn_cancel_top);
            btn_cancel.TabIndex = btn_save.TabIndex + 1;
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Text = "&CANCEL";
            btn_cancel.Themes = Theme.BlueBtn;
            btn_cancel.Click += new EventHandler(Btn_cancel_Click);
            //
            btn_not_active.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            btn_not_active.Font = Theme.btnFont;
            btn_not_active.Size = new Size(Theme.F_btn_width, Theme.F_btn_height);
            btn_not_active.Location = new Point(Theme.F_btn_notactive_left, Theme.F_btn_notactive_top);
            btn_not_active.TabIndex = btn_cancel.TabIndex + 1;
            btn_not_active.Name = "btn_not_active";
            btn_not_active.Text = "&Not Active";
            btn_not_active.Click += new EventHandler(Btn_not_active_Click);
            //
            btn_active.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            btn_active.Font = Theme.btnFont;
            btn_active.Size = new Size(Theme.F_btn_width, Theme.F_btn_height);
            btn_active.Location = new Point(Theme.F_btn_active_left, Theme.F_btn_active_top);
            btn_active.TabIndex = btn_not_active.TabIndex + 1;
            btn_active.Name = "btn_active";
            btn_active.Text = "&Active";
            btn_active.Click += new EventHandler(Btn_active_Click);
            //
            txt_notes.TabIndex = btn_active.TabIndex + 1;
            //
            #endregion[Properties of btn]
            //
            #endregion[f_inner_panel]
            //
            #region [FDatabases]
            //
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.split_container);
            this.Name = "fDatabases";
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, ClientSize.Height);
            //
            this.split_container.Panel1.ResumeLayout(false);
            this.split_container.Panel2.ResumeLayout(false);
            ((ISupportInitialize)(this.split_container)).EndInit();
            this.split_container.ResumeLayout(false);
            this.fpanel.ResumeLayout(false);
            this.f_inner_panel.ResumeLayout(false);
            this.f_inner_panel.PerformLayout();
            this.ResumeLayout(false);
            //
            #endregion [Fpost]
        }
}//cls 
}//ns 
