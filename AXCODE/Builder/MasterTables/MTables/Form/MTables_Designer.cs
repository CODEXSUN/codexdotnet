// Version : 3 dt : 31-07-2017
// Auto Generated
// 31-07-2017 08:39:30 PM
// last update : 31-07-2017

using System;
using System.Windows.Forms;
using CXLIB;
using System.Drawing;
using System.ComponentModel;


namespace AXCODE
{
    public partial class FMtables : UserControl
    {
        public FMtables()
        {
            InitializeComponent();
            Initialize();
            Setactives();
            SetFocus();
            Databases_lookup();
            Namespaces_lookup();
            InitGrid();
            DB_Databases_lookup();
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

        private LookupBox txt_databases_id;
        private XLabel lbl_databases_id;
        private XTextBox txt_tables_name;
        private XLabel lbl_tables_name;
        private XTextBox txt_tables_alias;
        private XLabel lbl_tables_alias;

        private LookupBox txt_db_databases;
        private XLabel lbl_db_databases;
        private LookupBox txt_db_tables_name;
        private XLabel lbl_db_tables_name;

        private LookupBox txt_namespaces_id;
        private XLabel lbl_namespaces;

        private EditGridView editgrid;
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
            txt_databases_id = new LookupBox();
            lbl_databases_id = new XLabel();
            txt_tables_name = new XTextBox();
            lbl_tables_name = new XLabel();
            txt_tables_alias = new XTextBox();
            lbl_tables_alias = new XLabel();
            txt_db_databases = new LookupBox();
            lbl_db_databases = new XLabel();
            txt_db_tables_name = new LookupBox();
            lbl_db_tables_name = new XLabel();
            txt_namespaces_id = new LookupBox();
            lbl_namespaces = new XLabel();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            editgrid = new EditGridView();
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
            //
            finner_panel.Controls.Add(txt_notes);
            finner_panel.Controls.Add(lbl_notes);
            finner_panel.Controls.Add(lbl_databases_id);
            finner_panel.Controls.Add(txt_databases_id);
            finner_panel.Controls.Add(txt_tables_name);
            finner_panel.Controls.Add(lbl_tables_name);

            finner_panel.Controls.Add(txt_tables_alias);
            finner_panel.Controls.Add(lbl_tables_alias);

            finner_panel.Controls.Add(txt_db_databases);
            finner_panel.Controls.Add(lbl_db_databases);
            finner_panel.Controls.Add(txt_db_tables_name);
            finner_panel.Controls.Add(lbl_db_tables_name);
            finner_panel.Controls.Add(txt_namespaces_id);
            finner_panel.Controls.Add(lbl_namespaces);

            finner_panel.Controls.Add(editgrid);

            finner_panel.Controls.Add(btn_save);
            finner_panel.Controls.Add(btn_active);

            #endregion[adding controls]

            #region[Header]

            btn_close.Click += new EventHandler(Btn_close_Click);

            lbl_header.Text = "Tables";

            #endregion[Header]

            #region[Properties of control]

            lbl_databases_id.Font = XFont.Font_10B;
            lbl_databases_id.Name = "lbl_databases_id";
            lbl_databases_id.Text = "   Databases";
            lbl_databases_id.Anchor = XAnchor.LT;
            lbl_databases_id.TextAlign = ContentAlignment.MiddleLeft;
            lbl_databases_id.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_databases_id.Size = XSize.OneLabel;
            lbl_databases_id.Location = XLayout.FirstLabel;

            txt_databases_id.Font = XFont.TxtFont;
            txt_databases_id.ForeColor = XFontColor.TxtFontColor;
            txt_databases_id.BackColor = XTheme.TxtBackcolor;
            txt_databases_id.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_databases_id.Name = "txt_databases_id";
            txt_databases_id.Anchor = XAnchor.LTR;
            txt_databases_id.Size = XSize.TwoText;
            txt_databases_id.Location = XLayout.FirstText;
            txt_databases_id.TabIndex = XTab.Txt_TabIndex;
            txt_databases_id.Enter += new EventHandler(Txt_databases_id_Enter);

            lbl_tables_name.Font = XFont.Font_10B;
            lbl_tables_name.Name = "lbl_tables_name";
            lbl_tables_name.Text = " DB Table";
            lbl_tables_name.Anchor = XAnchor.LT;
            lbl_tables_name.TextAlign = ContentAlignment.MiddleLeft;
            lbl_tables_name.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_tables_name.Size = XSize.OneLabel;
            lbl_tables_name.Location = XLayout.VLocation(lbl_databases_id.Location);

            txt_tables_name.Font = XFont.TxtFont;
            txt_tables_name.ForeColor = XFontColor.TxtFontColor;
            txt_tables_name.BackColor = XTheme.TxtBackcolor;
            txt_tables_name.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_tables_name.Name = "txt_tables_name";
            txt_tables_name.Anchor = XAnchor.LTR;
            txt_tables_name.Size = XSize.TwoText;
            txt_tables_name.Location = XLayout.VLocation(txt_databases_id.Location);
            txt_tables_name.TabIndex = XTab.Index(txt_databases_id.TabIndex);
            txt_tables_name.Enter += new EventHandler(Txt_tables_name_Enter);

            lbl_tables_alias.Font = XFont.Font_10B;
            lbl_tables_alias.Name = "lbl_tables_alias";
            lbl_tables_alias.Text = "   Tables alias";
            lbl_tables_alias.Anchor = XAnchor.LT;
            lbl_tables_alias.TextAlign = ContentAlignment.MiddleLeft;
            lbl_tables_alias.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_tables_alias.Size = XSize.OneLabel;
            lbl_tables_alias.Location = XLayout.VLocation(lbl_tables_name.Location);

            txt_tables_alias.Font = XFont.TxtFont;
            txt_tables_alias.ForeColor = XFontColor.TxtFontColor;
            txt_tables_alias.BackColor = XTheme.TxtBackcolor;
            txt_tables_alias.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_tables_alias.Name = "txt_tables_alias";
            txt_tables_alias.Anchor = XAnchor.LTR;
            txt_tables_alias.Size = XSize.TwoText;
            txt_tables_alias.Location = XLayout.VLocation(txt_tables_name.Location);
            txt_tables_alias.TabIndex = XTab.Index(txt_tables_name.TabIndex);
            txt_tables_alias.Enter += new EventHandler(Txt_tables_alias_Enter);

            lbl_db_databases.Font = XFont.Font_10B;
            lbl_db_databases.Name = "lbl_databases_id";
            lbl_db_databases.Text = " Db ";
            lbl_db_databases.Anchor = XAnchor.LT;
            lbl_db_databases.TextAlign = ContentAlignment.MiddleLeft;
            lbl_db_databases.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_db_databases.Size = XSize.TwoLabel;
            lbl_db_databases.Location = XLayout.R1_2Label_2(lbl_databases_id.Location);

            txt_db_databases.Font = XFont.TxtFont;
            txt_db_databases.ForeColor = XFontColor.TxtFontColor;
            txt_db_databases.BackColor = XTheme.TxtBackcolor;
            txt_db_databases.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_db_databases.Name = "txt_databases_id";
            txt_db_databases.Anchor = XAnchor.LTR;
            txt_db_databases.Size = XSize.TwoText;
            txt_db_databases.Location = XLayout.R1_2Text_2(txt_databases_id.Location);
            txt_db_databases.TabIndex = XTab.Index(editgrid.TabIndex);
            //txt_db_databases.Enter += new EventHandler(Txt_db_);

            lbl_db_tables_name.Font = XFont.Font_10B;
            lbl_db_tables_name.Name = "lbl_tables_name";
            lbl_db_tables_name.Text = "   Tables name";
            lbl_db_tables_name.Anchor = XAnchor.LT;
            lbl_db_tables_name.TextAlign = ContentAlignment.MiddleLeft;
            lbl_db_tables_name.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_db_tables_name.Size = XSize.TwoLabel;
            lbl_db_tables_name.Location = XLayout.R1_2Label_2(lbl_tables_name.Location);

            txt_db_tables_name.Font = XFont.TxtFont;
            txt_db_tables_name.ForeColor = XFontColor.TxtFontColor;
            txt_db_tables_name.BackColor = XTheme.TxtBackcolor;
            txt_db_tables_name.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_db_tables_name.Name = "txt_db_tables_name";
            txt_db_tables_name.Anchor = XAnchor.LTR;
            txt_db_tables_name.Size = XSize.TwoText;
            txt_db_tables_name.Location = XLayout.R1_2Text_2(txt_tables_name.Location);
            txt_db_tables_name.TabIndex = XTab.Index(txt_db_databases.TabIndex);
            txt_db_tables_name.Enter += new EventHandler(Txt_tables_name_Enter);

            lbl_namespaces.Font = XFont.Font_10B;
            lbl_namespaces.Name = "lbl_tables_name";
            lbl_namespaces.Text = " Namespaces";
            lbl_namespaces.Anchor = XAnchor.LT;
            lbl_namespaces.TextAlign = ContentAlignment.MiddleLeft;
            lbl_namespaces.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_namespaces.Size = XSize.TwoLabel;
            lbl_namespaces.Location = XLayout.R2_2Label_2(lbl_db_tables_name.Location);

            txt_namespaces_id.Font = XFont.TxtFont;
            txt_namespaces_id.ForeColor = XFontColor.TxtFontColor;
            txt_namespaces_id.BackColor = XTheme.TxtBackcolor;
            txt_namespaces_id.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_namespaces_id.Name = "txt_namespaces";
            txt_namespaces_id.Anchor = XAnchor.LTR;
            txt_namespaces_id.Size = XSize.TwoText;
            txt_namespaces_id.Location = XLayout.R2_2Text_2(txt_db_tables_name.Location);
            txt_namespaces_id.TabIndex = XTab.Index(txt_db_tables_name.TabIndex);
            txt_namespaces_id.Enter += new EventHandler(Txt_tables_name_Enter);

            #region[editGridView]
            //
            editgrid.AllowNewRowOnEnterKey = true;
            editgrid.AllowUserToAddRows = false;
            editgrid.AllowUserToDeleteRows = false;
            editgrid.AllowUserToResizeRows = false;
            //
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 255, 204);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(252, 0, 11);
            //
            editgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            editgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            editgrid.BackgroundColor = Color.White;
            editgrid.CellBorderStyle = DataGridViewCellBorderStyle.Custom;
            editgrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Custom;
            //
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(132, 192, 96);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            //
            editgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            editgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 255, 204);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(252, 0, 11);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            //
            editgrid.DefaultCellStyle = dataGridViewCellStyle3;
            editgrid.EnableContextMenu = true;
            editgrid.EnableHeadersVisualStyles = false;
            editgrid.GridColor = Color.SeaGreen;
            editgrid.Location = new Point(lbl_tables_alias.Left, lbl_tables_alias.Bottom + 10);
            editgrid.MultiSelect = false;
            editgrid.Name = "editGridView";
            editgrid.RowHeadersVisible = false;
            editgrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            editgrid.Size = new Size(finner_panel.Width - 50, 300);
            editgrid.StandardTab = true;
            editgrid.TabIntoComma = false;
            editgrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            editgrid.RowsLimit = 100;
            editgrid.TabIndex = XTab.Index(txt_tables_alias.TabIndex);
            //
            #endregion[editGridView]

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
            btn_save.TabIndex = XTab.Index(txt_tables_alias.TabIndex);
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

            #region [FTables]

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.split_container);
            this.Name = "fTables";
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

        #region[Init Grid]
        private void InitGrid()
        {
            editgrid.CurrentCellChanged += new EventHandler(Editgrid_CurrentCellChanged);

            DataGridViewTextBoxColumn col_Tableitem_Id = new DataGridViewTextBoxColumn();
            col_Tableitem_Id.Name = MASTERTABLESITEMS.MASTERTABLESITEMS_ID;
            col_Tableitem_Id.HeaderText = "TABLEITEM_ID ";
            col_Tableitem_Id.Visible = false;
            col_Tableitem_Id.Width = 200;
            col_Tableitem_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Tableitem_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Tableitem_Id);

            DataGridViewTextBoxColumn col_Tables = new DataGridViewTextBoxColumn();
            col_Tables.Name = MASTERTABLESITEMS.MASTERTABLES_ID;
            col_Tables.HeaderText = "TABLES";
            col_Tables.Visible = false;
            col_Tables.Width = 200;
            col_Tables.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Tables.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Tables);

            DataGridViewTextBoxColumn col_Fields = new DataGridViewTextBoxColumn();
            col_Fields.Name = MASTERTABLESITEMS.FIELDSNAME;
            col_Fields.HeaderText = "FIELDS";
            //col_Fields.Visible = false; 
            col_Fields.Width = 200;
            col_Fields.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Fields.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Fields);

            DataGridViewTextBoxColumn col_Display_name = new DataGridViewTextBoxColumn();
            col_Display_name.Name = MASTERTABLESITEMS.DISPLAYNAME;
            col_Display_name.HeaderText = "DISPLAY NAME";
            //col_Display_name.Visible = false; 
            col_Display_name.Width = 200;
            col_Display_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Display_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Display_name);

            DataGridViewTextBoxColumn col_Datatype = new DataGridViewTextBoxColumn();
            col_Datatype.Name = MASTERTABLESITEMS.DATATYPE;
            col_Datatype.HeaderText = "DATA TYPE";
            //col_Datatype.Visible = false; 
            col_Datatype.Width = 300;
            col_Datatype.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Datatype.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Datatype);

            DataGridViewTextBoxColumn col_Inputtype = new DataGridViewTextBoxColumn();
            col_Inputtype.Name = MASTERTABLESITEMS.INPUTTYPE;
            col_Inputtype.HeaderText = "INPUTTYPE";
            //col_Inputtype.Visible = false; 
            col_Inputtype.Width = 200;
            col_Inputtype.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Inputtype.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Inputtype);

            DataGridViewTextBoxColumn col_Width = new DataGridViewTextBoxColumn();
            col_Width.Name = MASTERTABLESITEMS.WIDTH;
            col_Width.HeaderText = "WIDTH";
            //col_Width.Visible = false; 
            col_Width.Width = 200;
            col_Width.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Width.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Width);

            DataGridViewTextBoxColumn col_Height = new DataGridViewTextBoxColumn();
            col_Height.Name = MASTERTABLESITEMS.HEIGHT;
            col_Height.HeaderText = "HEIGHT";
            //col_Height.Visible = false; 
            col_Height.Width = 200;
            col_Height.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Height.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Height);

            DataGridViewTextBoxColumn col_Cposition = new DataGridViewTextBoxColumn();
            col_Cposition.Name = MASTERTABLESITEMS.CPOSITION;
            col_Cposition.HeaderText = "CPOSITION";
            //col_Cposition.Visible = false; 
            col_Cposition.Width = 200;
            col_Cposition.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Cposition.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Cposition);

            DataGridViewTextBoxColumn col_Rposition = new DataGridViewTextBoxColumn();
            col_Rposition.Name = MASTERTABLESITEMS.RPOSITION;
            col_Rposition.HeaderText = "RPOSITION";
            //col_Rposition.Visible = false; 
            col_Rposition.Width = 200;
            col_Rposition.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Rposition.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Rposition);

            DataGridViewTextBoxColumn col_Alignto = new DataGridViewTextBoxColumn();
            col_Alignto.Name = MASTERTABLESITEMS.ALIGNTO;
            col_Alignto.HeaderText = "ALIGN TO";
            //col_Alignto.Visible = false;
            col_Alignto.Width = 200;
            col_Alignto.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Alignto.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Alignto);

            DataGridViewTextBoxColumn col_Validate = new DataGridViewTextBoxColumn();
            col_Validate.Name = MASTERTABLESITEMS.VALIDATE;
            col_Validate.HeaderText = "VALIDATE";
            //col_Validate.Visible = false; 
            col_Validate.Width = 200;
            col_Validate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Validate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Validate);

            DataGridViewTextBoxColumn col_Isdefault = new DataGridViewTextBoxColumn();
            col_Isdefault.Name = MASTERTABLESITEMS.ISDEFAULT;
            col_Isdefault.HeaderText = "ISDEFAULT";
            //col_Isdefault.Visible = false; 
            col_Isdefault.Width = 200;
            col_Isdefault.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Isdefault.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Isdefault);

            DataGridViewTextBoxColumn col_Placement = new DataGridViewTextBoxColumn();
            col_Placement.Name = MASTERTABLESITEMS.PLACEMENT;
            col_Placement.HeaderText = "PLACEMENT";
            col_Placement.Visible = false;
            col_Placement.Width = 200;
            col_Placement.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Placement.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Placement);

            DataGridViewTextBoxColumn colFiller = new DataGridViewTextBoxColumn();
            colFiller.Name = "FILLER";
            colFiller.HeaderText = "";
            colFiller.ReadOnly = true;
            colFiller.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            colFiller.SortMode = DataGridViewColumnSortMode.NotSortable;
            colFiller.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            editgrid.Columns.Add(colFiller);
        }

        private void Editgrid_CurrentCellChanged(object sender, EventArgs e)
        {
            if (editgrid.Focused == false)
            {
                return;
            }
            if (editgrid.ReadOnly == true)
            {
                return;
            }
            // 
            if (editgrid.CurrentCell != null)
            {
                lookupRow = editgrid.CurrentCell.RowIndex;
                lookupCol = editgrid.CurrentCell.ColumnIndex;
                lookupColName = editgrid.Columns[lookupCol].Name;
                // 
                switch (lookupColName)
                {
                    case MASTERTABLESITEMS.DATATYPE:
                        ShowLookupForm();
                        break;
                    case MASTERTABLESITEMS.INPUTTYPE:
                        ShowLookupForm();
                        break;
                    case MASTERTABLESITEMS.WIDTH:
                        ShowLookupForm();
                        break;
                    case MASTERTABLESITEMS.HEIGHT:
                        ShowLookupForm();
                        break;
                    case MASTERTABLESITEMS.CPOSITION:
                        ShowLookupForm();
                        break;
                    case MASTERTABLESITEMS.RPOSITION:
                        ShowLookupForm();
                        break;
                    case MASTERTABLESITEMS.ALIGNTO:
                        ShowLookupForm();
                        break;
                    case MASTERTABLESITEMS.VALIDATE:
                        ShowLookupForm();
                        break;
                    case MASTERTABLESITEMS.ISDEFAULT:
                        ShowLookupForm();
                        break;
                    case MASTERTABLESITEMS.PLACEMENT:
                        ShowLookupForm();
                        break;
                }
            }
        }

        #endregion[Init Grid]



    }//cls 
}//ns 
