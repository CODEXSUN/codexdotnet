// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// 20-06-2019 10:44:05 AM
// last update : 20-06-2019

using System;
using System.Windows.Forms;
using CXLIB;
using System.Drawing;
using System.ComponentModel;


namespace CXERP
{ 
    public partial class FStyle : UserControl 
    { 
        public FStyle() 
        {
            InitializeComponent();
            Initialize();
            InitGrid();
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

        private XTextBox txt_article_no;
        private XLabel lbl_article_no;
        private xDatepicker txt_article_date;
        private XLabel lbl_article_date;

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

            txt_article_no = new XTextBox();
            lbl_article_no = new XLabel();
            txt_article_date = new xDatepicker();
            lbl_article_date = new XLabel();
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
            finner_panel.Controls.Add(txt_article_no);
            finner_panel.Controls.Add(lbl_article_no);
            finner_panel.Controls.Add(txt_article_date);
            finner_panel.Controls.Add(lbl_article_date);
            finner_panel.Controls.Add(editgrid);
            finner_panel.Controls.Add(btn_save);
            finner_panel.Controls.Add(btn_active);

            #endregion[adding controls]

            #region[Header]

            btn_close.Click += new EventHandler(Btn_close_Click);

            lbl_header.Text = "Style Sheet";

            #endregion[Header]

            #region[Properties of control]

            lbl_article_no.Font = XFont.Font_10B;
            lbl_article_no.Name = "lbl_garment_article_no";
            lbl_article_no.Text = " Style no";
            lbl_article_no.Anchor = XAnchor.LT;
            lbl_article_no.TextAlign = ContentAlignment.MiddleLeft;
            lbl_article_no.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_article_no.Size =  XSize.OneLabel;
            lbl_article_no.Location =XLayout.FirstLabel;

            txt_article_no.Font = XFont.TxtFont;
            txt_article_no.ForeColor = XFontColor.TxtFontColor;
            txt_article_no.BackColor = XTheme.TxtBackcolor;
            txt_article_no.Name = "txt_garment_article_no";
            txt_article_no.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_article_no.Size =  XSize.TwoText;
            txt_article_no.Anchor = XAnchor.LT;
            txt_article_no.Location =XLayout.FirstText;
            txt_article_no.TabIndex = XTab.Txt_TabIndex;
            txt_article_no.Enter += new EventHandler(Txt_article_no_Enter);


            lbl_article_date.Font = XFont.Font_10B;
            lbl_article_date.Name = "lbl_garment_article_date";
            lbl_article_date.Text = "   Style date";
            lbl_article_date.Anchor = XAnchor.LT;
            lbl_article_date.TextAlign = ContentAlignment.MiddleLeft;
            lbl_article_date.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_article_date.Size =  XSize.TwoLabel;
            lbl_article_date.Location =XLayout.R1_2Label_2(lbl_article_no.Location);

            txt_article_date.Font = XFont.TxtFont;
            txt_article_date.ForeColor = XFontColor.TxtFontColor;
            txt_article_date.BackColor = XTheme.TxtBackcolor;
            txt_article_date.Name = "txt_garment_article_date";
            txt_article_date.CustomFormat = "dd-MM-yyyy";
            txt_article_date.Format = DateTimePickerFormat.Custom;
            txt_article_date.Size =  XSize.TwoText;
            txt_article_date.Anchor = XAnchor.LTR;
            txt_article_date.Location =XLayout.R1_2Text_2(txt_article_no.Location);
            txt_article_date.TabIndex = XTab.Index(txt_article_no.TabIndex);
            txt_article_date.Enter += new EventHandler(Txt_Style_date_Enter);

            editgrid.Location = new Point(XLayout.H_left, txt_article_date.Bottom + 10); 
            editgrid.Name = "editgrid"; 
            editgrid.Size = new Size(finner_panel.Width - 50, 250); 
            editgrid.TabIndex = XTab.Index(txt_article_date.TabIndex);
            editgrid.RowsLimit = 12; 
            Point p = new Point(editgrid.Left , editgrid.Bottom); 


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
            btn_save.TabIndex = XTab.Index(txt_article_date.TabIndex);
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

            #region [FStyle]

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.split_container);
            this.Name = "fStyle";
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

        internal string GetName()
        {
            return txt_article_no.Text;
        }

        internal void Setname(string pValue)
        {
            txt_article_no.Text = pValue;
        }

        #region[Init Grid]

        private void InitGrid()
         {
            editgrid.RowsRemoved += new DataGridViewRowsRemovedEventHandler(Editgrid_RowsRemoved);
            editgrid.CellValidating += new DataGridViewCellValidatingEventHandler(Editgrid_CellValidating);
            editgrid.CellValueChanged += new DataGridViewCellEventHandler(Editgrid_CellValueChanged);
            editgrid.CurrentCellChanged += new EventHandler(Editgrid_CurrentCellChanged);

            DataGridViewTextBoxColumn col_Styleitems_Id = new DataGridViewTextBoxColumn();
            col_Styleitems_Id.Name = STYLEITEMS.STYLEITEMS_ID;
            col_Styleitems_Id.HeaderText = "STYLEITEMS_ID ";
            col_Styleitems_Id.Visible = false; 
            col_Styleitems_Id.Width = 100;
            col_Styleitems_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Styleitems_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Styleitems_Id );

            DataGridViewTextBoxColumn col_slno = new DataGridViewTextBoxColumn();
            col_slno.Name = Core.SLNO;
            col_slno.HeaderText = "S.NO";
            //col_slno.Visible = false; 
            col_slno.ReadOnly = true;
            col_slno.Width = 50;
            col_slno.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_slno.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_slno);

            DataGridViewTextBoxColumn col_Style_id = new DataGridViewTextBoxColumn();
            col_Style_id.Name = STYLEITEMS.STYLE_ID;
            col_Style_id.HeaderText = " STYLE ID";
            col_Style_id.Visible = false; 
            col_Style_id.Width = 100;
            col_Style_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Style_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Style_id);

            DataGridViewTextBoxColumn col_Style_no = new DataGridViewTextBoxColumn();
            col_Style_no.Name = STYLEITEMS.STYLE_NO;
            col_Style_no.HeaderText = " STYLE NO";
            col_Style_no.Visible = false; 
            col_Style_no.Width = 200;
            col_Style_no.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Style_no.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Style_no);

            DataGridViewTextBoxColumn col_Product_id = new DataGridViewTextBoxColumn();
            col_Product_id.Name = STYLEITEMS.PRODUCT_ID;
            col_Product_id.HeaderText = "PRODUCT";
            //col_Product_id.Visible = false; 
            col_Product_id.Width = 500;
            col_Product_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Product_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Product_id);

            DataGridViewTextBoxColumn col_Colours_id = new DataGridViewTextBoxColumn();
            col_Colours_id.Name = STYLEITEMS.COLOURS_ID;
            col_Colours_id.HeaderText = "COLOURS";
            //col_Colours_id.Visible = false; 
            col_Colours_id.Width = 150;
            col_Colours_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Colours_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Colours_id);

            DataGridViewTextBoxColumn col_Sizes_id = new DataGridViewTextBoxColumn();
            col_Sizes_id.Name = STYLEITEMS.SIZES_ID;
            col_Sizes_id.HeaderText = "SIZES";
            //col_Sizes_id.Visible = false; 
            col_Sizes_id.Width = 150;
            col_Sizes_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Sizes_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Sizes_id);

            DataGridViewTextBoxColumn col_Qty = new DataGridViewTextBoxColumn();
            col_Qty.Name = STYLEITEMS.QTY;
            col_Qty.HeaderText = "QTY";
            //col_Qty.Visible = false; 
            col_Qty.Width = 200;
            col_Qty.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Qty.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Qty);

            DataGridViewTextBoxColumn col_Price = new DataGridViewTextBoxColumn();
            col_Price.Name = STYLEITEMS.PRICE;
            col_Price.HeaderText = "PRICE";
            //col_Price.Visible = false; 
            col_Price.Width = 150;
            col_Price.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Price);


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
