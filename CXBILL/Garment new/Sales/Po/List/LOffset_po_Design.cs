// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 11:17:05 PM

using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;

namespace CXBILL
{
    public partial class LOffset_po : CxControl
    {

        private FOffset_Po fpo = null;
        private bool constructed_flag = false;

        public LOffset_po()
        {
            InitializeComponent();
            Initialize();
            InitGrid();
            List_Option(ListOption.active);
            No_lookup();
            Date_lookup();
            Party_lookup();
            constructed_flag = true;
            rdo_unrefer.Checked = true;
        }

        #region[Private Declare]

        private XShadowPanel lpanel;
        private Panel linner_panel;
        private CloseButton btn_close;
        private Header lbl_header;

        private XLabel lbl_no;
        private LookupBox txt_no;
        private XLabel lbl_date;
        private LookupBox txt_date;
        private XLabel lbl_party;
        private LookupBox txt_party;
        private OfficeButton btn_search;

        private MRadioButton rdo_unrefer;
        private MRadioButton rdo_refer;
        private MRadioButton rdo_showall;
        private MRadioButton rdo_notactive;


        private OfficeButton btn_refresh;
        private OfficeButton btn_new;
        private OfficeButton btn_edit;
        private OfficeButton btn_delete;
        private OfficeButton btn_print;

        private ListGridView listgrid;

        #endregion[Private Declare]

        #region[Initialize]

        private void Initialize()
        {

            lpanel = new XShadowPanel();
            linner_panel = new Panel();
            btn_close = new CloseButton();
            lbl_header = new Header();

            rdo_unrefer = new MRadioButton();
            rdo_refer = new MRadioButton();
            rdo_showall = new MRadioButton();
            rdo_notactive = new MRadioButton();

            txt_no = new LookupBox();
            lbl_no = new XLabel();
            txt_date = new LookupBox();
            lbl_date = new XLabel();
            txt_party = new LookupBox();
            lbl_party = new XLabel();
            btn_search = new OfficeButton();

            //btn_quick = new OfficeButton();
            //Getno_panel = new Panel();
            //Getno_innerpanel = new ShadowBox();
            //txt_getno = new XTextBox();
            //lbl_getno = new XLabel();
            //btn_generate = new OfficeButton();

            btn_refresh = new OfficeButton();
            btn_new = new OfficeButton();
            btn_edit = new OfficeButton();
            btn_delete = new OfficeButton();
            btn_print = new OfficeButton();

            listgrid = new ListGridView();

            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();

            lpanel.SuspendLayout();
            linner_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(listgrid)).BeginInit();
            SuspendLayout();

            linner_panel.Location = XLayout.LInnerPanel;
            linner_panel.Name = "linner_panel";
            linner_panel.Size = XSize.LInnerPanel;

            btn_close.Click += Btn_close_Click;

            lbl_header.Text = "Po";

            #endregion[Initialize]

            #region[Add Control]

            lpanel.Name = "lpanel";
            lpanel.Dock = DockStyle.Fill;
            lpanel.Size = XSize.FPanel;
            lpanel.Location = XLayout.FPanel;
            lpanel.BackColor = XTheme.FPanel;
            lpanel.Controls.Add(linner_panel);
            lpanel.Controls.Add(btn_close);
            lpanel.Controls.Add(lbl_header);

            linner_panel.Anchor = XAnchor.LTRB;
            linner_panel.BackColor = XTheme.LInnerpanel;

            linner_panel.Controls.Add(txt_no);
            linner_panel.Controls.Add(lbl_no);
            linner_panel.Controls.Add(txt_date);
            linner_panel.Controls.Add(lbl_date);
            linner_panel.Controls.Add(txt_party);
            linner_panel.Controls.Add(lbl_party);
            linner_panel.Controls.Add(btn_search);

            linner_panel.Controls.Add(rdo_unrefer);
            linner_panel.Controls.Add(rdo_refer);
            linner_panel.Controls.Add(rdo_showall);
            linner_panel.Controls.Add(rdo_notactive);

            //linner_panel.Controls.Add(btn_quick);
            //linner_panel.Controls.Add(Getno_panel);

            linner_panel.Controls.Add(btn_refresh);
            linner_panel.Controls.Add(btn_new);
            linner_panel.Controls.Add(btn_edit);
            linner_panel.Controls.Add(btn_delete);
            linner_panel.Controls.Add(btn_print);

            linner_panel.Controls.Add(listgrid);

            #endregion[Add Control]

            #region[Search]

            lbl_no.Font = XFont.Font_10B;
            lbl_no.Name = "lbl_no";
            lbl_no.Text = "No";
            lbl_no.TextAlign = ContentAlignment.MiddleCenter;
            lbl_no.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_no.Size = new Size(40, 28);
            lbl_no.Location = XLayout.FirstLabel;

            txt_no.Font = XFont.TxtFont;
            txt_no.ForeColor = XFontColor.TxtFontColor;
            txt_no.BackColor = XTheme.TxtBackcolor;
            txt_no.Name = "txt_no";
            txt_no.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_no.Size = new Size(120, 28);
            txt_no.Anchor = XAnchor.LT;
            txt_no.Location = new Point(lbl_no.Right - 1, lbl_no.Top);
            txt_no.TabIndex = 6;

            lbl_date.Font = XFont.Font_10B;
            lbl_date.Name = "lbl_date";
            lbl_date.Text = "Date";
            lbl_date.TextAlign = ContentAlignment.MiddleCenter;
            lbl_date.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_date.Size = new Size(50, 28);
            lbl_date.Location = new Point(txt_no.Right + 10, txt_no.Top);

            txt_date.Font = XFont.TxtFont;
            txt_date.ForeColor = XFontColor.TxtFontColor;
            txt_date.BackColor = XTheme.TxtBackcolor;
            txt_date.Name = "txt_date";
            txt_date.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_date.Size = new Size(130, 28);
            txt_date.Anchor = XAnchor.LT;
            txt_date.Location = new Point(lbl_date.Right - 1, lbl_date.Top);
            txt_date.TabIndex = 7;

            lbl_party.Font = XFont.Font_10B;
            lbl_party.Name = "lbl_party";
            lbl_party.Text = "Party";
            lbl_party.TextAlign = ContentAlignment.MiddleCenter;
            lbl_party.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_party.Size = new Size(80, 28);
            lbl_party.Location = new Point(txt_date.Right + 10, txt_date.Top);

            txt_party.Font = XFont.TxtFont;
            txt_party.ForeColor = XFontColor.TxtFontColor;
            txt_party.BackColor = XTheme.TxtBackcolor;
            txt_party.Name = "txt_party";
            txt_party.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_party.Size = new Size(600, 28);
            txt_party.Anchor = XAnchor.LT;
            txt_party.Location = new Point(lbl_party.Right - 1, lbl_party.Top);
            txt_party.TabIndex = 8;

            btn_search.Font = XFont.BtnFont;
            btn_search.Location = new Point(txt_party.Right + 5, txt_party.Top);
            btn_search.Size = new Size(75, 26);
            btn_search.TabIndex = 1;
            btn_search.Name = "btn_search";
            btn_search.Text = "&Search";
            btn_search.Themes = XTheme.YellowBtn;
            btn_search.Anchor = XAnchor.TR;
            btn_search.Click += Btn_search_Click;

            #endregion[Search]

            #region[Radio btn]

            rdo_unrefer.Anchor = XAnchor.TR;
            rdo_unrefer.AutoSize = false;
            rdo_unrefer.Font = XFont.TxtFont;
            rdo_unrefer.Location = new Point(XSize.FPanel_width - 160, 60);
            rdo_unrefer.MouseLocation = new Point(-1, -1);
            rdo_unrefer.Name = "rdo_unrefer";
            rdo_unrefer.Size = new Size(200, 30);
            rdo_unrefer.TabIndex = 2;
            rdo_unrefer.Text = "UN DELIVERED";
            rdo_unrefer.CheckedChanged += new EventHandler(Rdo_unrefer_CheckedChanged);

            rdo_refer.Anchor = XAnchor.TR;
            rdo_refer.AutoSize = false;
            rdo_refer.Font = XFont.TxtFont;
            rdo_refer.Location = new Point(rdo_unrefer.Left, rdo_unrefer.Bottom + 20);
            rdo_refer.MouseLocation = new Point(-1, -1);
            rdo_refer.Name = "rdo_refer";
            rdo_refer.Size = new Size(200, 30);
            rdo_refer.TabIndex = 3;
            rdo_refer.Text = " DELIVERED";
            rdo_refer.CheckedChanged += new EventHandler(Rdo_refer_CheckedChanged);

            rdo_showall.Anchor = XAnchor.TR;
            rdo_showall.AutoSize = false;
            rdo_showall.Font = XFont.TxtFont;
            rdo_showall.Location = new Point(rdo_refer.Left, rdo_refer.Bottom + 20);
            rdo_showall.MouseLocation = new Point(-1, -1);
            rdo_showall.Name = "rdo_showall";
            rdo_showall.Size = new Size(200, 30);
            rdo_showall.TabIndex = 4;
            rdo_showall.Text = " SHOW ALL";
            rdo_showall.CheckedChanged += new EventHandler(Rdo_showall_CheckedChanged);

            rdo_notactive.Anchor = XAnchor.TR;
            rdo_notactive.AutoSize = false;
            rdo_notactive.Font = XFont.TxtFont;
            rdo_notactive.Location = new Point(rdo_showall.Left, rdo_showall.Bottom + 20);
            rdo_notactive.MouseLocation = new Point(-1, -1);
            rdo_notactive.Name = "rdo_notactive";
            rdo_notactive.Size = new Size(200, 30);
            rdo_notactive.TabIndex = 6;
            rdo_notactive.Text = "NOT ACTIVE";
            rdo_notactive.CheckedChanged += new EventHandler(Rdo_notactive_CheckedChanged);

            #endregion[Radio btn]

            #region[btn Properties]

            btn_refresh.Font = XFont.BtnFont;
            btn_refresh.Location = XLayout.BtnLocation(rdo_notactive.Location);
            btn_refresh.Size = XSize.BtnOne;
            btn_refresh.TabIndex = 1;
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Text = "&Refresh";
            btn_refresh.Themes = XTheme.BlueBtn;
            btn_refresh.Anchor = XAnchor.TR;
            btn_refresh.Click += Btn_refresh_Click;

            btn_new.Font = XFont.BtnFont;
            btn_new.Location = XLayout.BtnLocation(btn_refresh.Location);
            btn_new.Size = XSize.BtnOne;
            btn_new.TabIndex = XTab.Index(btn_refresh.TabIndex);
            btn_new.Name = "btn_new";
            btn_new.Text = "&New";
            btn_new.Themes = XTheme.BlueBtn;
            btn_new.Anchor = XAnchor.TR;
            btn_new.Click += Btn_new_Click;

            btn_edit.Font = XFont.BtnFont;
            btn_edit.Location = XLayout.BtnLocation(btn_new.Location);
            btn_edit.Size = XSize.BtnOne;
            btn_edit.TabIndex = XTab.Index(btn_new.TabIndex);
            btn_edit.Name = "btn_edit";
            btn_edit.Text = "&Edit";
            btn_edit.Themes = XTheme.BlueBtn;
            btn_edit.Anchor = XAnchor.TR;
            btn_edit.Click += Btn_edit_Click;

            btn_delete.Font = XFont.BtnFont;
            btn_delete.Location = XLayout.BtnLocation(btn_edit.Location);
            btn_delete.Size = XSize.BtnOne;
            btn_delete.TabIndex = XTab.Index(btn_edit.TabIndex);
            btn_delete.Name = "btn_delete";
            btn_delete.Text = "&Delete";
            btn_delete.Themes = XTheme.BlueBtn;
            btn_delete.Anchor = XAnchor.TR;
            btn_delete.Click += Btn_delete_Click;

            btn_print.Font = XFont.BtnFont;
            btn_print.Location = XLayout.BtnLocation(btn_delete.Location);
            btn_print.Size = XSize.BtnOne;
            btn_print.TabIndex = XTab.Index(btn_delete.TabIndex);
            btn_print.Name = "btn_print";
            btn_print.Text = "&Print";
            btn_print.Themes = XTheme.BlueBtn;
            btn_print.Anchor = XAnchor.TR;
            btn_print.Click += Btn_print_Click;

            #endregion[btn Properties]

            #region[List Grid]

            listgrid.AllowUserToAddRows = false;
            listgrid.AllowUserToDeleteRows = false;
            listgrid.AllowUserToOrderColumns = true;
            listgrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = XFont.Font_10R;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 255, 204);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(252, 0, 11);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            listgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            listgrid.Anchor = XAnchor.LTRB;
            listgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listgrid.BackgroundColor = Color.White;
            listgrid.BorderStyle = BorderStyle.Fixed3D;
            listgrid.CellBorderStyle = DataGridViewCellBorderStyle.Custom;
            listgrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(132, 192, 96);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            listgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            listgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listgrid.Cursor = Cursors.Default;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = XFont.Font_10R;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 255, 204);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(252, 0, 11);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            listgrid.DefaultCellStyle = dataGridViewCellStyle3;
            listgrid.EnableHeadersVisualStyles = false;
            listgrid.GridColor = Color.SeaGreen;
            listgrid.MultiSelect = false;
            listgrid.Name = "listgrid";
            listgrid.ReadOnly = true;
            listgrid.RowHeadersVisible = false;
            listgrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listgrid.Location = XLayout.ListView;
            listgrid.Size = XSize.ListView;
            listgrid.StandardTab = true;
            listgrid.TabIndex = 0;

            #endregion[List Grid]

            #region[List]

            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lpanel);
            Name = "LPo";
            Size = new Size(1000, 600);
            lpanel.ResumeLayout(false);
            linner_panel.ResumeLayout(false);
            linner_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(listgrid)).EndInit();
            ResumeLayout(false);

        }

        #endregion[List]

        #region[Init Grid]

        private void InitGrid()
        {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Po_Id = new DataGridViewTextBoxColumn();
            col_Po_Id.Name = OFFSET_PO.OFFSET_PO_ID;
            col_Po_Id.HeaderText = "PO_ID ";
            col_Po_Id.Visible = false;
            col_Po_Id.Width = 100;
            col_Po_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Po_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Po_Id);

            DataGridViewTextBoxColumn col_Po_no = new DataGridViewTextBoxColumn();
            col_Po_no.Name = OFFSET_PO.OFFSET_PO_NO;
            col_Po_no.HeaderText = "PO NO";
            //col_Po_no.Visible = false;
            col_Po_no.Width = 100;
            col_Po_no.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Po_no.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Po_no);

            DataGridViewTextBoxColumn col_Po_date = new DataGridViewTextBoxColumn();
            col_Po_date.Name = OFFSET_PO.OFFSET_PO_DATE;
            col_Po_date.HeaderText = "DATE";
            //col_Po_date.Visible = false;
            col_Po_date.Width = 100;
            col_Po_date.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Po_date.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Po_date);

            DataGridViewTextBoxColumn col_Party_id = new DataGridViewTextBoxColumn();
            col_Party_id.Name = OFFSET_PO.PARTY_ID;
            col_Party_id.HeaderText = "PARTY";
            //col_Party_id.Visible = false;
            col_Party_id.Width = 300;
            col_Party_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Party_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Party_id);

            DataGridViewTextBoxColumn col_Party_po_ref = new DataGridViewTextBoxColumn();
            col_Party_po_ref.Name = OFFSET_PO.PARTY_PO_REF;
            col_Party_po_ref.HeaderText = "PARTY PO REF";
            //col_Party_po_ref.Visible = false;
            col_Party_po_ref.Width = 188;
            col_Party_po_ref.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Party_po_ref.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Party_po_ref);

            DataGridViewTextBoxColumn col_Delivery_date = new DataGridViewTextBoxColumn();
            col_Delivery_date.Name = OFFSET_PO.DELIVERY_DATE;
            col_Delivery_date.HeaderText = "DELIVERY DATE";
            //col_Delivery_date.Visible = false;
            col_Delivery_date.Width = 200;
            col_Delivery_date.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Delivery_date.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Delivery_date);

            DataGridViewTextBoxColumn col_Total_qty = new DataGridViewTextBoxColumn();
            col_Total_qty.Name = OFFSET_PO.TOTAL_QTY;
            col_Total_qty.HeaderText = "TOTAL QTY";
            //col_Total_qty.Visible = false;
            col_Total_qty.Width = 150;
            col_Total_qty.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Total_qty.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Total_qty);

            DataGridViewTextBoxColumn col_Total_amount = new DataGridViewTextBoxColumn();
            col_Total_amount.Name = OFFSET_PO.TOTAL_AMOUNT;
            col_Total_amount.HeaderText = "TOTAL AMOUNT";
            //col_Total_amount.Visible = false;
            col_Total_amount.Width = 188;
            col_Total_amount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Total_amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Total_amount);

            DataGridViewTextBoxColumn col_grid = new DataGridViewTextBoxColumn();
            col_grid.Name = GRID.CELL;
            col_grid.HeaderText = "STATUS";
            //col_grid.Visible = false;
            col_grid.Width = 120;
            col_grid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_grid.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_grid);

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = OFFSET_PO.USER_ID;
            col_User_Id.HeaderText = "ENTRY BY";
            //col_User_Id.Visible = false;
            col_User_Id.Width = 120;
            col_User_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_User_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_User_Id);

            DataGridViewTextBoxColumn colFiller = new DataGridViewTextBoxColumn();
            colFiller.Name = "FILLER";
            colFiller.HeaderText = "";
            colFiller.ReadOnly = true;
            colFiller.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            colFiller.SortMode = DataGridViewColumnSortMode.NotSortable;
            colFiller.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            listgrid.Columns.Add(colFiller);

        }

        #endregion[Init Grid]

    }//cls
}//ns
