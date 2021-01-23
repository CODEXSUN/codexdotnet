// Version : 3 dt : 01-08-2017
// Auto Generated
// 20-08-2017 10:33:49 PM
// last update : 20-08-2017

using System;
using System.Windows.Forms;
using CXLIB;
using System.Drawing;
using System.ComponentModel;


namespace CXBILL
{ 
    public partial class FOffset_Po : UserControl 
    { 
        public FOffset_Po() 
        {
            InitializeComponent();
            Initialize();
            InitGrid();
            Setactives();
            SetFocus(); 
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

        private XTextBox txt_po_no;
        private XLabel lbl_po_no;
        private xDatepicker txt_po_date;
        private XLabel lbl_po_date;
        private LookupBox txt_party_id;
        private XLabel lbl_party_id;
        private XTextBox txt_party_po_ref;
        private XLabel lbl_party_po_ref;
        private xDatepicker txt_delivery_date;
        private XLabel lbl_delivery_date;
        private EditGridView editgrid;
        private XLabel txt_total_qty;
        private XLabel lbl_total_qty;
        private XLabel txt_total_amount;
        private XLabel lbl_total_amount;

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

            txt_po_no = new XTextBox();
            lbl_po_no = new XLabel();
            txt_po_date = new xDatepicker();
            lbl_po_date = new XLabel();
            txt_party_id = new LookupBox();
            lbl_party_id = new XLabel();
            txt_party_po_ref = new XTextBox();
            lbl_party_po_ref = new XLabel();
            txt_delivery_date = new xDatepicker();
            lbl_delivery_date = new XLabel();
            editgrid = new EditGridView();
            txt_total_qty = new XLabel();
            lbl_total_qty = new XLabel();
            txt_total_amount = new XLabel();
            lbl_total_amount = new XLabel();

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
            finner_panel.Controls.Add(txt_po_no);
            finner_panel.Controls.Add(lbl_po_no);
            finner_panel.Controls.Add(txt_po_date);
            finner_panel.Controls.Add(lbl_po_date);
            finner_panel.Controls.Add(txt_party_id);
            finner_panel.Controls.Add(lbl_party_id);
            finner_panel.Controls.Add(txt_party_po_ref);
            finner_panel.Controls.Add(lbl_party_po_ref);
            finner_panel.Controls.Add(txt_delivery_date);
            finner_panel.Controls.Add(lbl_delivery_date);
            finner_panel.Controls.Add(txt_total_qty);
            finner_panel.Controls.Add(lbl_total_qty);
            finner_panel.Controls.Add(txt_total_amount);
            finner_panel.Controls.Add(lbl_total_amount);
            finner_panel.Controls.Add(editgrid);
            finner_panel.Controls.Add(btn_save);
            finner_panel.Controls.Add(btn_active);

            #endregion[adding controls]

            #region[Header]

            btn_close.Click += new EventHandler(Btn_close_Click);

            lbl_header.Text = "Po";

            #endregion[Header]

            #region[Properties of control]

            lbl_po_no.Font = XFont.Font_10B;
            lbl_po_no.Name = "lbl_po_no";
            lbl_po_no.Text = "   Po no";
            lbl_po_no.Anchor = XAnchor.LT;
            lbl_po_no.TextAlign = ContentAlignment.MiddleLeft;
            lbl_po_no.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_po_no.Size =  XSize.OneLabel;
            lbl_po_no.Location =XLayout.FirstLabel;

            txt_po_no.Font = XFont.TxtFont;
            txt_po_no.ForeColor = XFontColor.TxtFontColor;
            txt_po_no.BackColor = XTheme.TxtBackcolor;
            txt_po_no.Name = "txt_po_no";
            txt_po_no.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_po_no.TextAlign = HorizontalAlignment.Left;
            txt_po_no.Size =  XSize.TwoText;
            txt_po_no.Anchor = XAnchor.LT;
            txt_po_no.Location =XLayout.FirstText;
            txt_po_no.TabIndex = XTab.Txt_TabIndex;
            txt_po_no.Enter += new EventHandler(Txt_po_no_Enter);

            lbl_po_date.Font = XFont.Font_10B;
            lbl_po_date.Name = "lbl_po_date";
            lbl_po_date.Text = "   Date";
            lbl_po_date.Anchor = XAnchor.LT;
            lbl_po_date.TextAlign = ContentAlignment.MiddleLeft;
            lbl_po_date.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_po_date.Size =  XSize.TwoLabel;
            lbl_po_date.Location =XLayout.R1_2Label_2(lbl_po_no.Location);

            txt_po_date.Font = XFont.TxtFont;
            txt_po_date.ForeColor = XFontColor.TxtFontColor;
            txt_po_date.BackColor = XTheme.TxtBackcolor;
            txt_po_date.Name = "txt_po_date";
            txt_po_date.CustomFormat = "dd-MM-yyyy";
            txt_po_date.Format = DateTimePickerFormat.Custom;
            txt_po_date.Size =  XSize.TwoText;
            txt_po_date.Anchor = XAnchor.LTR;
            txt_po_date.Location =XLayout.R1_2Text_2(txt_po_no.Location);
            txt_po_date.TabIndex = XTab.Index(txt_po_no.TabIndex);
            txt_po_date.Enter += new EventHandler(Txt_po_date_Enter);

            lbl_party_id.Font = XFont.Font_10B;
            lbl_party_id.Name = "lbl_party_id";
            lbl_party_id.Text = "   Party";
            lbl_party_id.Anchor = XAnchor.LT;
            lbl_party_id.TextAlign = ContentAlignment.MiddleLeft;
            lbl_party_id.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_party_id.Size =  XSize.OneLabel;
            lbl_party_id.Location =XLayout.R1_Label(lbl_po_date.Location);

            txt_party_id.Font = XFont.TxtFont;
            txt_party_id.ForeColor = XFontColor.TxtFontColor;
            txt_party_id.BackColor = XTheme.TxtBackcolor;
            txt_party_id.Name = "txt_party_id";
            txt_party_id.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_party_id.TextAlign = HorizontalAlignment.Left;
            txt_party_id.Size =  XSize.OneText;
            txt_party_id.Anchor = XAnchor.LTR;
            txt_party_id.Location =XLayout.R1_Text(txt_po_date.Location);
            txt_party_id.TabIndex = XTab.Index(txt_po_date.TabIndex);
            txt_party_id.Enter += new EventHandler(Txt_party_id_Enter);

            lbl_party_po_ref.Font = XFont.Font_10B;
            lbl_party_po_ref.Name = "lbl_party_po_ref";
            lbl_party_po_ref.Text = "   Party po ref";
            lbl_party_po_ref.Anchor = XAnchor.LT;
            lbl_party_po_ref.TextAlign = ContentAlignment.MiddleLeft;
            lbl_party_po_ref.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_party_po_ref.Size =  XSize.OneLabel;
            lbl_party_po_ref.Location =XLayout.R2_2Label_1(lbl_party_id.Location);

            txt_party_po_ref.Font = XFont.TxtFont;
            txt_party_po_ref.ForeColor = XFontColor.TxtFontColor;
            txt_party_po_ref.BackColor = XTheme.TxtBackcolor;
            txt_party_po_ref.Name = "txt_party_po_ref";
            txt_party_po_ref.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_party_po_ref.TextAlign = HorizontalAlignment.Left;
            txt_party_po_ref.Size =  XSize.TwoText;
            txt_party_po_ref.Anchor = XAnchor.LT;
            txt_party_po_ref.Location =XLayout.R2_2Text_1(txt_party_id.Location);
            txt_party_po_ref.TabIndex = XTab.Index(txt_party_id.TabIndex);
            txt_party_po_ref.Enter += new EventHandler(Txt_party_po_ref_Enter);

            lbl_delivery_date.Font = XFont.Font_10B;
            lbl_delivery_date.Name = "lbl_delivery_date";
            lbl_delivery_date.Text = "   Delivery date";
            lbl_delivery_date.Anchor = XAnchor.LT;
            lbl_delivery_date.TextAlign = ContentAlignment.MiddleLeft;
            lbl_delivery_date.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_delivery_date.Size =  XSize.TwoLabel;
            lbl_delivery_date.Location =XLayout.R1_2Label_2(lbl_party_po_ref.Location);

            txt_delivery_date.Font = XFont.TxtFont;
            txt_delivery_date.ForeColor = XFontColor.TxtFontColor;
            txt_delivery_date.BackColor = XTheme.TxtBackcolor;
            txt_delivery_date.Name = "txt_delivery_date";
            txt_delivery_date.CustomFormat = "dd-MM-yyyy";
            txt_delivery_date.Format = DateTimePickerFormat.Custom;
            txt_delivery_date.Size =  XSize.TwoText;
            txt_delivery_date.Anchor = XAnchor.LTR;
            txt_delivery_date.Location =XLayout.R1_2Text_2(txt_party_po_ref.Location);
            txt_delivery_date.TabIndex = XTab.Index(txt_party_po_ref.TabIndex);
            txt_delivery_date.Enter += new EventHandler(Txt_delivery_date_Enter);

            editgrid.Location = new Point(XLayout.H_left, lbl_delivery_date.Bottom + 10); 
            editgrid.Name = "editgrid"; 
            editgrid.Size = new Size(finner_panel.Width - 50, 250); 
            editgrid.TabIndex = XTab.Index(txt_delivery_date.TabIndex);
            editgrid.RowsLimit = 12; 
            Point p = new Point(editgrid.Left , editgrid.Bottom); 

            lbl_total_qty.Font = XFont.Font_10B;
            lbl_total_qty.Name = "lbl_total_qty";
            lbl_total_qty.Text = "Total qty";
            lbl_total_qty.Anchor = XAnchor.LT;
            lbl_total_qty.TextAlign = ContentAlignment.MiddleLeft;
            lbl_total_qty.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_total_qty.Size =  XSize.FourLabel;
            lbl_total_qty.Location =XLayout.R2_4Label_4(p);

            txt_total_qty.Font = XFont.TxtFont;
            txt_total_qty.ForeColor = XFontColor.TxtFontColor;
            txt_total_qty.BackColor = XTheme.TxtBackcolor;
            txt_total_qty.Name = "txt_total_qty";
            //txt_total_qty.Cursor = Cursors.No;
            txt_total_qty.TextAlign = ContentAlignment.MiddleRight;
            txt_total_qty.Size =  XSize.FourText;
            txt_total_qty.Anchor = XAnchor.LTR;
            txt_total_qty.Location =XLayout.R2_4Text_4(p);
            txt_total_qty.TabIndex = XTab.Index(editgrid.TabIndex);
            txt_total_qty.Enter += new EventHandler(Txt_total_qty_Enter);

            lbl_total_amount.Font = XFont.Font_10B;
            lbl_total_amount.Name = "lbl_total_amount";
            lbl_total_amount.Text = "Total amount";
            lbl_total_amount.Anchor = XAnchor.LT;
            lbl_total_amount.TextAlign = ContentAlignment.MiddleLeft;
            lbl_total_amount.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_total_amount.Size =  XSize.FourLabel;
            lbl_total_amount.Location =XLayout.R2_4Label_4(lbl_total_qty.Location);

            txt_total_amount.Font = XFont.TxtFont;
            txt_total_amount.ForeColor = XFontColor.TxtFontColor;
            txt_total_amount.BackColor = XTheme.TxtBackcolor;
            txt_total_amount.Name = "txt_total_amount";
            //txt_total_amount.Cursor = Cursors.No;
            txt_total_amount.TextAlign = ContentAlignment.MiddleRight;
            txt_total_amount.Size =  XSize.FourText;
            txt_total_amount.Anchor = XAnchor.LTR;
            txt_total_amount.Location =XLayout.R2_4Text_4(txt_total_qty.Location);
            txt_total_amount.TabIndex = XTab.Index(txt_total_qty.TabIndex);
            txt_total_amount.Enter += new EventHandler(Txt_total_amount_Enter);

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
            btn_save.TabIndex = XTab.Index(txt_total_amount.TabIndex);
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

            #region [FPo]

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.split_container);
            this.Name = "fPo";
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

            DataGridViewTextBoxColumn col_Poitems_Id = new DataGridViewTextBoxColumn();
            col_Poitems_Id.Name = OFFSET_POITEMS.OFFSET_POITEMS_ID;
            col_Poitems_Id.HeaderText = "POITEMS_ID ";
            col_Poitems_Id.Visible = false; 
            col_Poitems_Id.Width = 100;
            col_Poitems_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Poitems_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Poitems_Id );

            DataGridViewTextBoxColumn col_Po_Id = new DataGridViewTextBoxColumn();
            col_Po_Id.Name = OFFSET_POITEMS.OFFSET_PO_ID;
            col_Po_Id.HeaderText = "PO_ID ";
            col_Po_Id.Visible = false;
            col_Po_Id.Width = 100;
            col_Po_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Po_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Po_Id);

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
            col_Product_id.Name = OFFSET_POITEMS.PRODUCT_ID;
            col_Product_id.HeaderText = "PARTICULARS";
            //col_Product_id.Visible = false; 
            col_Product_id.Width = 810;
            col_Product_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Product_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            editgrid.Columns.Add(col_Product_id);

            DataGridViewTextBoxColumn col_Qty = new DataGridViewTextBoxColumn();
            col_Qty.Name = OFFSET_POITEMS.QTY;
            col_Qty.HeaderText = "QTY";
            //col_Qty.Visible = false; 
            col_Qty.Width = 200;
            col_Qty.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Qty.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Qty);

            DataGridViewTextBoxColumn col_Price = new DataGridViewTextBoxColumn();
            col_Price.Name = OFFSET_POITEMS.PRICE;
            col_Price.HeaderText = "PRICE";
            //col_Price.Visible = false; 
            col_Price.Width = 200;
            col_Price.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            col_Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Price);

            DataGridViewTextBoxColumn col_Sub_total = new DataGridViewTextBoxColumn();
            col_Sub_total.Name = OFFSET_POITEMS.SUB_TOTAL;
            col_Sub_total.HeaderText = "SUB TOTAL";
            col_Sub_total.ReadOnly = true;
            //col_Sub_total.Visible = false; 
            col_Sub_total.Width = 200;
            col_Sub_total.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            col_Sub_total.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editgrid.Columns.Add(col_Sub_total);

            //DataGridViewTextBoxColumn colFiller = new DataGridViewTextBoxColumn();
            //colFiller.Name = "FILLER";
            //colFiller.HeaderText = "";
            //colFiller.ReadOnly = true;
            //colFiller.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            //colFiller.SortMode = DataGridViewColumnSortMode.NotSortable;
            //colFiller.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //editgrid.Columns.Add(colFiller);

            }

            #endregion[Init Grid]

}//cls 
}//ns 
