// Version : 2.1.0.0 dt : 04-12-2018
// Auto Generated
// last update : 06-12-2018 10:53:54 PM

using System.Drawing;
using System.Windows.Forms;
using CXLIB;

namespace AXCODE
{
    public partial class LSpath
    {

        private FSpath fmpath = null;

        public LSpath()
        {
            InitializeComponent();
            Initialize();
            InitGrid();
            List_Option(ListOption.active);
            Mtables_lookup();
        }

        #region[Private Declare] 

        private XShadowPanel lpanel;
        private Panel linner_panel;
        private MCheckBox chk_notactive;
        private OfficeButton btn_search;
        private LookupBox txt_mtables_id;
        private XLabel lbl_mpath_name;
        private CloseButton btn_close;
        private Header lbl_header;
        private OfficeButton btn_print;
        private OfficeButton btn_delete;
        private OfficeButton btn_edit;
        private OfficeButton btn_new;
        private OfficeButton btn_refresh;
        private ListGridView listgrid;

        #endregion[Private Declare] 

        #region[Initialize] 
        private void Initialize()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lpanel = new XShadowPanel();
            linner_panel = new Panel();
            chk_notactive = new MCheckBox();
            txt_mtables_id = new LookupBox();
            lbl_mpath_name = new XLabel();
            btn_close = new CloseButton();
            lbl_header = new Header();
            btn_print = new OfficeButton();
            btn_delete = new OfficeButton();
            btn_edit = new OfficeButton();
            btn_new = new OfficeButton();
            btn_refresh = new OfficeButton();
            listgrid = new ListGridView();
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
            linner_panel.Controls.Add(chk_notactive);
            linner_panel.Controls.Add(txt_mtables_id);
            linner_panel.Controls.Add(lbl_mpath_name);
            linner_panel.Controls.Add(btn_print);
            linner_panel.Controls.Add(btn_delete);
            linner_panel.Controls.Add(btn_edit);
            linner_panel.Controls.Add(btn_new);
            linner_panel.Controls.Add(btn_refresh);
            linner_panel.Controls.Add(listgrid);
            linner_panel.Location = XLayout.LInnerPanel;
            linner_panel.Name = "linner_panel";
            linner_panel.Size = XSize.LInnerPanel;

            btn_close.Click += Btn_close_Click;

            lbl_header.Text = "Mpath";

            chk_notactive.Anchor = XAnchor.TR;
            chk_notactive.AutoSize = true;
            chk_notactive.Font = XFont.TxtFont;
            chk_notactive.Location = XLayout.ListFirstBtn;
            chk_notactive.MouseLocation = new Point(-1, -1);
            chk_notactive.Name = "chk_notactive";
            chk_notactive.Size = new Size(92, 30);
            chk_notactive.TabIndex = 4;
            chk_notactive.Text = "Not Active";
            chk_notactive.CheckedChanged += new System.EventHandler(Chk_notactive_CheckedChanged);

            txt_mtables_id.Font = XFont.TxtFont;
            txt_mtables_id.ForeColor = XFontColor.TxtFontColor;
            txt_mtables_id.BackColor = XTheme.TxtBackcolor;
            txt_mtables_id.Name = "txt_mpath_name";
            txt_mtables_id.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_mtables_id.Size = XSize.TwoText;
            txt_mtables_id.Anchor = XAnchor.LTR;
            txt_mtables_id.Location = XLayout.FirstText;
            txt_mtables_id.TabIndex = 5;

            lbl_mpath_name.Font = XFont.Font_10B;
            lbl_mpath_name.Name = "lbl_mpath_name";
            lbl_mpath_name.Text = "Mpath";
            lbl_mpath_name.TextAlign = ContentAlignment.MiddleCenter;
            lbl_mpath_name.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_mpath_name.Size = XSize.OneLabel;
            lbl_mpath_name.Location = XLayout.FirstLabel;

            btn_search.Font = XFont.BtnFont;
            btn_search.Location = new Point(txt_mtables_id.Right + 10, txt_mtables_id.Top);
            btn_search.Size = new Size(75, 26);
            btn_search.TabIndex = 1;
            btn_search.Name = "btn_search";
            btn_search.Text = "&Search";
            btn_search.Themes = XTheme.YellowBtn;
            btn_search.Anchor = XAnchor.TR;
            btn_search.Click += Btn_search_Click;

            #region[btn Properties] 

            btn_refresh.Font = XFont.BtnFont;
            btn_refresh.Location = XLayout.BtnLocation(chk_notactive.Location);
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

            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lpanel);
            Name = "LMpath";
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
