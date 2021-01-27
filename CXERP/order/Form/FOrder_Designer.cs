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
    public partial class FOrder : UserControl 
    { 
        public FOrder() 
        {
            InitializeComponent();
            Initialize();
            InitGrid();
            Setactives();
            SetFocus();
            Ordertype_lookup();
            Party_lookup();
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

        private XTextBox txt_order_no;
        private XLabel lbl_garment_order_no;
        private xDatepicker txt_order_date;
        private XLabel lbl_garment_order_date;
        private LookupBox txt_ordertype_id;
        private XLabel lbl_ordertype_id;
        private LookupBox txt_party_id;
        private XLabel lbl_party_id;
        private XTextBox txt_party_ref;
        private XLabel lbl_party_ref;
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

            txt_order_no = new XTextBox();
            lbl_garment_order_no = new XLabel();
            txt_order_date = new xDatepicker();
            lbl_garment_order_date = new XLabel();
            txt_ordertype_id = new LookupBox();
            lbl_ordertype_id = new XLabel();
            txt_party_id = new LookupBox();
            lbl_party_id = new XLabel();
            txt_party_ref = new XTextBox();
            lbl_party_ref = new XLabel();
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
            finner_panel.Controls.Add(txt_order_no);
            finner_panel.Controls.Add(lbl_garment_order_no);
            finner_panel.Controls.Add(txt_order_date);
            finner_panel.Controls.Add(lbl_garment_order_date);
            finner_panel.Controls.Add(txt_ordertype_id);
            finner_panel.Controls.Add(lbl_ordertype_id);
            finner_panel.Controls.Add(txt_party_id);
            finner_panel.Controls.Add(lbl_party_id);
            finner_panel.Controls.Add(txt_party_ref);
            finner_panel.Controls.Add(lbl_party_ref);
            finner_panel.Controls.Add(editgrid);
            finner_panel.Controls.Add(btn_save);
            finner_panel.Controls.Add(btn_active);

            #endregion[adding controls]

            #region[Header]

            btn_close.Click += new EventHandler(Btn_close_Click);

            lbl_header.Text = "Order Sheet";

            #endregion[Header]

            #region[Properties of control]

            lbl_garment_order_no.Font = XFont.Font_10B;
            lbl_garment_order_no.Name = "lbl_garment_order_no";
            lbl_garment_order_no.Text = " Order no";
            lbl_garment_order_no.Anchor = XAnchor.LT;
            lbl_garment_order_no.TextAlign = ContentAlignment.MiddleLeft;
            lbl_garment_order_no.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_garment_order_no.Size =  XSize.OneLabel;
            lbl_garment_order_no.Location =XLayout.FirstLabel;

            txt_order_no.Font = XFont.TxtFont;
            txt_order_no.ForeColor = XFontColor.TxtFontColor;
            txt_order_no.BackColor = XTheme.TxtBackcolor;
            txt_order_no.Name = "txt_garment_order_no";
            txt_order_no.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_order_no.Size =  XSize.TwoText;
            txt_order_no.Anchor = XAnchor.LT;
            txt_order_no.Location =XLayout.FirstText;
            txt_order_no.TabIndex = XTab.Txt_TabIndex;
            txt_order_no.Enter += new EventHandler(Txt_garment_order_no_Enter);


            lbl_garment_order_date.Font = XFont.Font_10B;
            lbl_garment_order_date.Name = "lbl_garment_order_date";
            lbl_garment_order_date.Text = "   Order date";
            lbl_garment_order_date.Anchor = XAnchor.LT;
            lbl_garment_order_date.TextAlign = ContentAlignment.MiddleLeft;
            lbl_garment_order_date.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_garment_order_date.Size =  XSize.TwoLabel;
            lbl_garment_order_date.Location =XLayout.R1_2Label_2(lbl_garment_order_no.Location);

            txt_order_date.Font = XFont.TxtFont;
            txt_order_date.ForeColor = XFontColor.TxtFontColor;
            txt_order_date.BackColor = XTheme.TxtBackcolor;
            txt_order_date.Name = "txt_garment_order_date";
            txt_order_date.CustomFormat = "dd-MM-yyyy";
            txt_order_date.Format = DateTimePickerFormat.Custom;
            txt_order_date.Size =  XSize.TwoText;
            txt_order_date.Anchor = XAnchor.LTR;
            txt_order_date.Location =XLayout.R1_2Text_2(txt_order_no.Location);
            txt_order_date.TabIndex = XTab.Index(txt_order_no.TabIndex);
            txt_order_date.Enter += new EventHandler(Txt_garment_order_date_Enter);


            lbl_ordertype_id.Font = XFont.Font_10B;
            lbl_ordertype_id.Name = "lbl_ordertype_id";
            lbl_ordertype_id.Text = "   Order Type";
            lbl_ordertype_id.Anchor = XAnchor.LT;
            lbl_ordertype_id.TextAlign = ContentAlignment.MiddleLeft;
            lbl_ordertype_id.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_ordertype_id.Size =  XSize.OneLabel;
            lbl_ordertype_id.Location =XLayout.R1_Label(lbl_garment_order_date.Location);

            txt_ordertype_id.Font = XFont.TxtFont;
            txt_ordertype_id.ForeColor = XFontColor.TxtFontColor;
            txt_ordertype_id.BackColor = XTheme.TxtBackcolor;
            txt_ordertype_id.Name = "txt_ordertype_id";
            txt_ordertype_id.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_ordertype_id.Size =  XSize.OneText;
            txt_ordertype_id.Anchor = XAnchor.LTR;
            txt_ordertype_id.Location =XLayout.R1_Text(txt_order_date.Location);
            txt_ordertype_id.TabIndex = XTab.Index(txt_order_date.TabIndex);
            txt_ordertype_id.Enter += new EventHandler(Txt_ordertype_id_Enter);


            lbl_party_id.Font = XFont.Font_10B;
            lbl_party_id.Name = "lbl_party_id";
            lbl_party_id.Text = "   Party";
            lbl_party_id.Anchor = XAnchor.LT;
            lbl_party_id.TextAlign = ContentAlignment.MiddleLeft;
            lbl_party_id.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_party_id.Size =  XSize.OneLabel;
            lbl_party_id.Location =XLayout.R1_Label(lbl_ordertype_id.Location);

            txt_party_id.Font = XFont.TxtFont;
            txt_party_id.ForeColor = XFontColor.TxtFontColor;
            txt_party_id.BackColor = XTheme.TxtBackcolor;
            txt_party_id.Name = "txt_party_id";
            txt_party_id.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_party_id.Size =  XSize.OneText;
            txt_party_id.Anchor = XAnchor.LTR;
            txt_party_id.Location =XLayout.R1_Text(txt_ordertype_id.Location);
            txt_party_id.TabIndex = XTab.Index(txt_ordertype_id.TabIndex);
            txt_party_id.Enter += new EventHandler(Txt_party_id_Enter);


            lbl_party_ref.Font = XFont.Font_10B;
            lbl_party_ref.Name = "lbl_party_ref";
            lbl_party_ref.Text = "   Order reference";
            lbl_party_ref.Anchor = XAnchor.LT;
            lbl_party_ref.TextAlign = ContentAlignment.MiddleLeft;
            lbl_party_ref.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_party_ref.Size =  XSize.OneLabel;
            lbl_party_ref.Location =XLayout.R1_Label(lbl_party_id.Location);

            txt_party_ref.Font = XFont.TxtFont;
            txt_party_ref.ForeColor = XFontColor.TxtFontColor;
            txt_party_ref.BackColor = XTheme.TxtBackcolor;
            txt_party_ref.Name = "txt_party_ref";
            txt_party_ref.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_party_ref.Size = XSize.OneText;
            txt_party_ref.Anchor = XAnchor.LT;
            txt_party_ref.Location = XLayout.R1_Text(txt_party_id.Location);
            txt_party_ref.TabIndex = XTab.Index(txt_party_id.TabIndex);
            txt_party_ref.Enter += new EventHandler(Txt_party_ref_Enter);

            editgrid.Location = new Point(XLayout.H_left, txt_party_ref.Bottom + 10); 
            editgrid.Name = "editgrid"; 
            editgrid.Size = new Size(finner_panel.Width - 50, 250); 
            editgrid.TabIndex = XTab.Index(txt_party_ref.TabIndex);
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
            btn_save.TabIndex = XTab.Index(txt_party_ref.TabIndex);
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

            #region [FOrder]

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.split_container);
            this.Name = "fOrder";
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
            return txt_order_no.Text;
        }

        internal void Setname(string pValue)
        {
            txt_order_no.Text = pValue;
        }

        #region[Init Grid]

        private void InitGrid()
         {
            editgrid.RowsRemoved += new DataGridViewRowsRemovedEventHandler(Editgrid_RowsRemoved);
            editgrid.CellValidating += new DataGridViewCellValidatingEventHandler(Editgrid_CellValidating);
            editgrid.CellValueChanged += new DataGridViewCellEventHandler(Editgrid_CellValueChanged);
            editgrid.CurrentCellChanged += new EventHandler(Editgrid_CurrentCellChanged);

            DataGridViewTextBoxColumn col_Orderitems_Id = new DataGridViewTextBoxColumn();
            col_Orderitems_Id.Name = ORDERITEMS.ORDERITEMS_ID;
            col_Orderitems_Id.HeaderText = "ORDERITEMS_ID ";
            col_Orderitems_Id.Visible = false; 
            col_Orderitems_Id.Width = 100;
            col_Orderitems_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Orderitems_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Orderitems_Id );

            DataGridViewTextBoxColumn col_slno = new DataGridViewTextBoxColumn();
            col_slno.Name = Core.SLNO;
            col_slno.HeaderText = "S.NO";
            //col_slno.Visible = false; 
            col_slno.ReadOnly = true;
            col_slno.Width = 50;
            col_slno.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_slno.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_slno);

            DataGridViewTextBoxColumn col_Order_id = new DataGridViewTextBoxColumn();
            col_Order_id.Name = ORDERITEMS.ORDER_ID;
            col_Order_id.HeaderText = "ORDER ID";
            col_Order_id.Visible = false; 
            col_Order_id.Width = 100;
            col_Order_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Order_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Order_id);

            DataGridViewTextBoxColumn col_Order_no = new DataGridViewTextBoxColumn();
            col_Order_no.Name = ORDERITEMS.ORDER_NO;
            col_Order_no.HeaderText = "ORDER NO";
            col_Order_no.Visible = false; 
            col_Order_no.Width = 200;
            col_Order_no.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Order_no.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Order_no);

            DataGridViewTextBoxColumn col_Style_no = new DataGridViewTextBoxColumn();
            col_Style_no.Name = ORDERITEMS.STYLE_ID;
            col_Style_no.HeaderText = "STYLE NO";
            //col_Style_no.Visible = false; 
            col_Style_no.Width = 200;
            col_Style_no.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Style_no.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Style_no);

            DataGridViewTextBoxColumn col_Style_id = new DataGridViewTextBoxColumn();
            col_Style_id.Name = ORDERITEMS.STYLE_NAME;
            col_Style_id.HeaderText = "STYLE NAME";
            //col_Style_id.Visible = false; 
            col_Style_id.Width = 420;
            col_Style_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Style_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Style_id);

            DataGridViewTextBoxColumn col_Colours_id = new DataGridViewTextBoxColumn();
            col_Colours_id.Name = ORDERITEMS.COLOURS_ID;
            col_Colours_id.HeaderText = "COLOURS";
            //col_Colours_id.Visible = false; 
            col_Colours_id.Width = 150;
            col_Colours_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Colours_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Colours_id);

            DataGridViewTextBoxColumn col_Qty = new DataGridViewTextBoxColumn();
            col_Qty.Name = ORDERITEMS.QTY;
            col_Qty.HeaderText = "QTY";
            //col_Qty.Visible = false; 
            col_Qty.Width = 150;
            col_Qty.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Qty.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Qty);

            DataGridViewTextBoxColumn col_Price = new DataGridViewTextBoxColumn();
            col_Price.Name = ORDERITEMS.PRICE;
            col_Price.HeaderText = "PRICE";
            //col_Price.Visible = false; 
            col_Price.Width = 120;
            col_Price.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Price);

            DataGridViewTextBoxColumn col_mrp = new DataGridViewTextBoxColumn();
            col_mrp.Name = ORDERITEMS.MRP;
            col_mrp.HeaderText = "MRP";
            //col_mrp.Visible = false; 
            col_mrp.Width = 120;
            col_mrp.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_mrp.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_mrp);

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
