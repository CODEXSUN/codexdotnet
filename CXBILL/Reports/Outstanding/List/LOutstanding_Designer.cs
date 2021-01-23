// Version : 2.1.0.0 dt : 04-12-2018
// Auto Generated
// last update : 07-12-2018 05:57:08 PM

using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;

namespace CXBILL
{
    public partial class LOutstanding : CxControl
    {

        //private FOutstanding foutstanding = null;

        public LOutstanding()
        {
            InitializeComponent();
            Initialize();
            InitGrid();
            InitTotalGrid();
            Outstanding_lookup();
            SetOutstanding();
            rdo_sales.Checked = true;
            List_Option(ListOption.sales);
        }

        #region[Private Declare] 

        private XShadowPanel lpanel;
        private Panel linner_panel;
        private MRadioButton rdo_sales;
        private MRadioButton rdo_Quotation;
        private OfficeButton btn_search;
        private LookupBox txt_party_id;
        private XLabel lbl_party_id;
        private CloseButton btn_close;
        private Header lbl_header;
        private OfficeButton btn_print;
        //private OfficeButton btn_delete;
        //private OfficeButton btn_edit;
        //private OfficeButton btn_new;
        private OfficeButton btn_reload;
        private ListGridView listgrid;
        private ListGridView totalgrid;

        #endregion[Private Declare] 

        #region[Initialize] 
        private void Initialize()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lpanel = new XShadowPanel();
            linner_panel = new Panel();
            rdo_sales = new MRadioButton();
            rdo_Quotation = new MRadioButton();
            txt_party_id = new LookupBox();
            lbl_party_id = new XLabel();
            btn_close = new CloseButton();
            lbl_header = new Header();
            btn_print = new OfficeButton();
            //btn_delete = new OfficeButton();
            //btn_edit = new OfficeButton();
            //btn_new = new OfficeButton();
            btn_reload = new OfficeButton();
            listgrid = new ListGridView();
            totalgrid = new ListGridView();
            btn_search = new OfficeButton();
            lpanel.SuspendLayout();
            linner_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(listgrid)).BeginInit();
            SuspendLayout();

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
            linner_panel.Controls.Add(btn_search);
            linner_panel.Controls.Add(rdo_sales);
            linner_panel.Controls.Add(rdo_Quotation);
            linner_panel.Controls.Add(txt_party_id);
            linner_panel.Controls.Add(lbl_party_id);
            linner_panel.Controls.Add(btn_print);
            //linner_panel.Controls.Add(btn_delete);
            //linner_panel.Controls.Add(btn_edit);
            //linner_panel.Controls.Add(btn_new);
            linner_panel.Controls.Add(btn_reload);
            linner_panel.Controls.Add(listgrid);
            linner_panel.Controls.Add(totalgrid);
            linner_panel.Location = XLayout.LInnerPanel;
            linner_panel.Name = "linner_panel";
            linner_panel.Size = XSize.LInnerPanel;

            btn_close.Click += Btn_close_Click;

            lbl_header.Text = "Outstanding";

            rdo_sales.Anchor = XAnchor.TR;
            rdo_sales.AutoSize = false;
            rdo_sales.Font = XFont.TxtFont;
            rdo_sales.Location = new Point(XSize.FPanel_width - 160, 60);
            rdo_sales.MouseLocation = new Point(-1, -1);
            rdo_sales.Name = "chk_sales";
            rdo_sales.Size = new Size(120, 30);
            rdo_sales.TabIndex = 4;
            rdo_sales.Text = " SALES";
            rdo_sales.CheckedChanged += new EventHandler(Rdo_sales_CheckedChanged);

            rdo_Quotation.Anchor = XAnchor.TR;
            rdo_Quotation.AutoSize = false;
            rdo_Quotation.Font = XFont.TxtFont;
            rdo_Quotation.Location = new Point(rdo_sales.Left, rdo_sales.Bottom + 20);
            rdo_Quotation.MouseLocation = new Point(-1, -1);
            rdo_Quotation.Name = "chk_sales";
            rdo_Quotation.Size = new Size(120, 30);
            rdo_Quotation.TabIndex = 4;
            rdo_Quotation.Text = " QUOTATION";
            rdo_Quotation.CheckedChanged += new EventHandler(Rdo_Quotation_CheckedChanged);

            txt_party_id.Font = XFont.TxtFont;
            txt_party_id.ForeColor = XFontColor.TxtFontColor;
            txt_party_id.BackColor = XTheme.TxtBackcolor;
            txt_party_id.Name = "txt_party_id";
            txt_party_id.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_party_id.Size = XSize.TwoText;
            txt_party_id.Anchor = XAnchor.LTR;
            txt_party_id.Location = XLayout.FirstText;
            txt_party_id.TabIndex = 5;

            lbl_party_id.Font = XFont.Font_10B;
            lbl_party_id.Name = "lbl_party_id";
            lbl_party_id.Text = "Party";
            lbl_party_id.TextAlign = ContentAlignment.MiddleCenter;
            lbl_party_id.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_party_id.Size = XSize.OneLabel;
            lbl_party_id.Location = XLayout.FirstLabel;

            btn_search.Font = XFont.BtnFont;
            btn_search.Location = new Point(txt_party_id.Right + 10, txt_party_id.Top);
            btn_search.Size = new Size(75, 26);
            btn_search.TabIndex = 1;
            btn_search.Name = "btn_search";
            btn_search.Text = "&Search";
            btn_search.Themes = XTheme.YellowBtn;
            btn_search.Anchor = XAnchor.TR;
            btn_search.Click += Btn_search_Click;

            #region[btn Properties] 

            btn_reload.Font = XFont.BtnFont;
            btn_reload.Location = new Point(rdo_Quotation.Left, rdo_Quotation.Bottom + 20);
            btn_reload.Size = XSize.BtnOne;
            btn_reload.TabIndex = 1;
            btn_reload.Name = "btn_reload";
            btn_reload.Text = "&Reolad";
            btn_reload.Themes = XTheme.BlueBtn;
            btn_reload.Anchor = XAnchor.TR;
            btn_reload.Click += Btn_reload_Click;

            //btn_new.Font = XFont.BtnFont;
            //btn_new.Location = XLayout.BtnLocation(btn_reload.Location);
            //btn_new.Size = XSize.BtnOne;
            //btn_new.TabIndex = XTab.Index(btn_reload.TabIndex);
            //btn_new.Name = "btn_new";
            //btn_new.Text = "&New";
            //btn_new.Themes = XTheme.BlueBtn;
            //btn_new.Anchor = XAnchor.TR;
            //btn_new.Click += Btn_new_Click;

            //btn_edit.Font = XFont.BtnFont;
            //btn_edit.Location = XLayout.BtnLocation(btn_new.Location);
            //btn_edit.Size = XSize.BtnOne;
            //btn_edit.TabIndex = XTab.Index(btn_new.TabIndex);
            //btn_edit.Name = "btn_edit";
            //btn_edit.Text = "&Edit";
            //btn_edit.Themes = XTheme.BlueBtn;
            //btn_edit.Anchor = XAnchor.TR;
            //btn_edit.Click += Btn_edit_Click;

            //btn_delete.Font = XFont.BtnFont;
            //btn_delete.Location = XLayout.BtnLocation(btn_edit.Location);
            //btn_delete.Size = XSize.BtnOne;
            //btn_delete.TabIndex = XTab.Index(btn_edit.TabIndex);
            //btn_delete.Name = "btn_delete";
            //btn_delete.Text = "&Delete";
            //btn_delete.Themes = XTheme.BlueBtn;
            //btn_delete.Anchor = XAnchor.TR;
            //btn_delete.Click += Btn_delete_Click;

            btn_print.Font = XFont.BtnFont;
            btn_print.Location = XLayout.BtnLocation(btn_reload.Location);
            btn_print.Size = XSize.BtnOne;
           // btn_print.TabIndex = XTab.Index(btn_delete.TabIndex);
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
            listgrid.Size = new Size(XSize.ListView_Width, XSize.ListView_Height - 40);
            listgrid.StandardTab = true;
            listgrid.TabIndex = 0;

            #endregion[List Grid] 


            #region[totalgrid] 

            totalgrid.AllowUserToAddRows = false;
            totalgrid.AllowUserToDeleteRows = false;
            totalgrid.AllowUserToOrderColumns = true;
            totalgrid.AllowUserToResizeRows = false;
            totalgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            totalgrid.Anchor = XAnchor.LTRB;
            totalgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            totalgrid.BackgroundColor = Color.White;
            totalgrid.BorderStyle = BorderStyle.Fixed3D;
            totalgrid.CellBorderStyle = DataGridViewCellBorderStyle.Custom;
            totalgrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Custom;
            totalgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            totalgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            totalgrid.Cursor = Cursors.Default;

            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = XFont.Font_11R;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 255, 204);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(252, 0, 11);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;

            totalgrid.DefaultCellStyle = dataGridViewCellStyle4;
            totalgrid.EnableHeadersVisualStyles = false;
            totalgrid.GridColor = Color.SeaGreen;
            totalgrid.MultiSelect = false;
            totalgrid.Name = "totalgrid";
            totalgrid.ReadOnly = true;
            totalgrid.RowHeadersVisible = false;
            totalgrid.ColumnHeadersVisible = false;
            totalgrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            totalgrid.Location = new Point(listgrid.Left, listgrid.Bottom + 20);
            totalgrid.Size = new Size(XSize.ListView_Width, 7);
            totalgrid.StandardTab = true;
            totalgrid.TabIndex = 5;

            #endregion[totalgrid] 


            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lpanel);
            Name = "LOutstanding";
            Size = new Size(1000, 600);
            lpanel.ResumeLayout(false);
            linner_panel.ResumeLayout(false);
            linner_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(listgrid)).EndInit();
            ResumeLayout(false);

        }

        #endregion[Initialize] 

    }//cls 
}//ns 
