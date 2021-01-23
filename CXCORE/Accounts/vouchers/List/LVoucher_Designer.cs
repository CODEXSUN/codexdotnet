// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 25-12-2017 07:23:53 PM

using System;
using System.Drawing;
using System.Windows.Forms;
using CodexsunLib;

namespace CodexsunCore
{
    public partial class LVoucher
    {

        private FVoucher fvoucher = null;

        public LVoucher()
        {
            InitializeComponent();
            Initialize();
            InitGrid();
            List_Option(ListOption.active);
            Voucher_no_lookup();
            Voucher_no_1_lookup();
            Voucher_date_lookup();
            Voucher_date_1_lookup();
            Vouchertype_lookup();
            Orderref_lookup();
            Ledger_lookup();
            Party_lookup();
            Purpose_lookup();

        }

        #region[Private Declare] 

        private XShadowPanel lpanel;
        private Panel linner_panel;
        private MCheckBox chk_notactive;
        private OfficeButton btn_search;
        private LookupBox txt_voucher_no;
        private LookupBox txt_voucher_date;
        private LookupBox txt_voucher_no_1;
        private LookupBox txt_voucher_date_1;
        private LookupBox txt_vouchertype;
        private LookupBox txt_orderref;
        private LookupBox txt_ledger;
        private LookupBox txt_party;
        private LookupBox txt_purpose;
        private CloseButton btn_close;
        private Header lbl_header;
        private OfficeButton btn_print;
        private OfficeButton btn_delete;
        private OfficeButton btn_edit;
        private OfficeButton btn_new;
        private OfficeButton btn_refresh;
        private ListGridView listgrid;
        private XTextBox txt_debit;
        private XTextBox txt_credit;
        private XTextBox txt_balance;


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
            txt_voucher_no = new LookupBox();
            txt_voucher_date = new LookupBox();
            txt_voucher_no_1 = new LookupBox();
            txt_voucher_date_1 = new LookupBox();
            txt_vouchertype = new LookupBox();
            txt_orderref = new LookupBox();
            txt_ledger = new LookupBox();
            txt_party = new LookupBox();
            txt_purpose = new LookupBox();
            btn_close = new CloseButton();
            lbl_header = new Header();
            btn_print = new OfficeButton();
            btn_delete = new OfficeButton();
            btn_edit = new OfficeButton();
            btn_new = new OfficeButton();
            btn_refresh = new OfficeButton();
            listgrid = new ListGridView();
            btn_search = new OfficeButton();
            txt_debit = new XTextBox();
            txt_credit = new XTextBox();
            txt_balance = new XTextBox();
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
            linner_panel.Controls.Add(txt_voucher_no);
            linner_panel.Controls.Add(txt_voucher_date);
            linner_panel.Controls.Add(txt_voucher_no_1);
            linner_panel.Controls.Add(txt_voucher_date_1);
            linner_panel.Controls.Add(txt_vouchertype);
            linner_panel.Controls.Add(txt_orderref);
            linner_panel.Controls.Add(txt_ledger);
            linner_panel.Controls.Add(txt_party);
            linner_panel.Controls.Add(txt_purpose);
            linner_panel.Controls.Add(btn_print);
            linner_panel.Controls.Add(btn_delete);
            linner_panel.Controls.Add(btn_edit);
            linner_panel.Controls.Add(btn_new);
            linner_panel.Controls.Add(btn_refresh);
            linner_panel.Controls.Add(listgrid);
            linner_panel.Controls.Add(txt_debit);
            linner_panel.Controls.Add(txt_credit);
            linner_panel.Controls.Add(txt_balance);
            linner_panel.Controls.Add(listgrid);
            linner_panel.Location = XLayout.LInnerPanel;
            linner_panel.Name = "linner_panel";
            linner_panel.Size = XSize.LInnerPanel;

            btn_close.Click += Btn_close_Click;

            lbl_header.Text = "Voucher";

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

            txt_voucher_no.Font = XFont.TxtFont;
            txt_voucher_no.ForeColor = XFontColor.TxtFontColor;
            txt_voucher_no.BackColor = XTheme.TxtBackcolor;
            txt_voucher_no.Name = "txt_voucher_no";
            txt_voucher_no.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_voucher_no.Size = new Size(58,28);
            txt_voucher_no.Anchor = XAnchor.LT;
            txt_voucher_no.Location = new Point(10, 25);
            txt_voucher_no.TabIndex = 5;

            txt_voucher_date.Font = XFont.TxtFont;
            txt_voucher_date.ForeColor = XFontColor.TxtFontColor;
            txt_voucher_date.BackColor = XTheme.TxtBackcolor;
            txt_voucher_date.Name = "txt_voucher_date";
            txt_voucher_date.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_voucher_date.Size = new Size(97, 28);
            txt_voucher_date.Anchor = XAnchor.LT;
            txt_voucher_date.Location = new Point(txt_voucher_no.Right + 3, txt_voucher_no.Top);
            txt_voucher_date.TabIndex = 6;


            txt_voucher_no_1.Font = XFont.TxtFont;
            txt_voucher_no_1.ForeColor = XFontColor.TxtFontColor;
            txt_voucher_no_1.BackColor = XTheme.TxtBackcolor;
            txt_voucher_no_1.Name = "txt_voucher_no_1";
            txt_voucher_no_1.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_voucher_no_1.Size = new Size(58, 28);
            txt_voucher_no_1.Anchor = XAnchor.LT;
            txt_voucher_no_1.Location = new Point(10, 55);
            txt_voucher_no_1.TabIndex = 13;

            txt_voucher_date_1.Font = XFont.TxtFont;
            txt_voucher_date_1.ForeColor = XFontColor.TxtFontColor;
            txt_voucher_date_1.BackColor = XTheme.TxtBackcolor;
            txt_voucher_date_1.Name = "txt_voucher_date_1";
            txt_voucher_date_1.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_voucher_date_1.Size = new Size(97, 28);
            txt_voucher_date_1.Anchor = XAnchor.LT;
            txt_voucher_date_1.Location = new Point(txt_voucher_no_1.Right + 3, txt_voucher_no_1.Top);
            txt_voucher_date_1.TabIndex = 14;


            txt_vouchertype.Font = XFont.TxtFont;
            txt_vouchertype.ForeColor = XFontColor.TxtFontColor;
            txt_vouchertype.BackColor = XTheme.TxtBackcolor;
            txt_vouchertype.Name = "txt_voucher_name";
            txt_vouchertype.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_vouchertype.Size = new Size(155, 28);
            txt_vouchertype.Anchor = XAnchor.LT;
            txt_vouchertype.Location = new Point(txt_voucher_date.Right + 3, txt_voucher_date.Top);
            txt_vouchertype.TabIndex = 7;

            txt_orderref.Font = XFont.TxtFont;
            txt_orderref.ForeColor = XFontColor.TxtFontColor;
            txt_orderref.BackColor = XTheme.TxtBackcolor;
            txt_orderref.Name = "txt_voucher_name";
            txt_orderref.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_orderref.Size = new Size(197, 28);
            txt_orderref.Anchor = XAnchor.LT;
            txt_orderref.Location = new Point(txt_vouchertype.Right + 3, txt_vouchertype.Top);
            txt_orderref.TabIndex = 8;

            txt_ledger.Font = XFont.TxtFont;
            txt_ledger.ForeColor = XFontColor.TxtFontColor;
            txt_ledger.BackColor = XTheme.TxtBackcolor;
            txt_ledger.Name = "txt_voucher_name";
            txt_ledger.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_ledger.Size = new Size(147, 28);
            txt_ledger.Anchor = XAnchor.LT;
            txt_ledger.Location = new Point(txt_orderref.Right + 3, txt_orderref.Top);
            txt_ledger.TabIndex = 9;

            txt_party.Font = XFont.TxtFont;
            txt_party.ForeColor = XFontColor.TxtFontColor;
            txt_party.BackColor = XTheme.TxtBackcolor;
            txt_party.Name = "txt_voucher_name";
            txt_party.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_party.Size = new Size(197, 28);
            txt_party.Anchor = XAnchor.LT;
            txt_party.Location = new Point(txt_ledger.Right + 3, txt_ledger.Top);
            txt_party.TabIndex = 10;

            txt_purpose.Font = XFont.TxtFont;
            txt_purpose.ForeColor = XFontColor.TxtFontColor;
            txt_purpose.BackColor = XTheme.TxtBackcolor;
            txt_purpose.Name = "txt_voucher_name";
            txt_purpose.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_purpose.Size = new Size(197, 28);
            txt_purpose.Anchor = XAnchor.LT;
            txt_purpose.Location = new Point(txt_party.Right + 3, txt_party.Top);
            txt_purpose.TabIndex = 11;

            btn_search.Font = XFont.BtnFont;
            btn_search.Location = new Point(txt_purpose.Right + 1, txt_purpose.Top);
            btn_search.Size = new Size(75, 26);
            btn_search.TabIndex = 12;
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
            listgrid.Size = new Size(XSize.ListView_Width, XSize.ListView_Height - 50);
            listgrid.StandardTab = true;
            listgrid.TabIndex = 0;

            #endregion[List Grid] 

            txt_balance.Font = XFont.TxtFont;
            txt_balance.ForeColor = XFontColor.TxtFontColor;
            txt_balance.BackColor = XTheme.TxtBackcolor;
            txt_balance.Name = "txt_balance";
            txt_balance.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_balance.Size = XSize.FourText;
            txt_balance.Anchor = XAnchor.LT;
            txt_balance.Location = new Point((listgrid.Width - 130), listgrid.Bottom + 30);
            txt_balance.TextAlign = HorizontalAlignment.Right;

            txt_credit.Font = XFont.TxtFont;
            txt_credit.ForeColor = XFontColor.TxtFontColor;
            txt_credit.BackColor = XTheme.TxtBackcolor;
            txt_credit.Name = "txt_credit";
            txt_credit.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_credit.Size = XSize.FourText;
            txt_credit.Anchor = XAnchor.LT;
            txt_credit.Location = new Point((txt_balance.Left - 220), listgrid.Bottom + 30);
            txt_credit.TextAlign = HorizontalAlignment.Right;

            txt_debit.Font = XFont.TxtFont;
            txt_debit.ForeColor = XFontColor.TxtFontColor;
            txt_debit.BackColor = XTheme.TxtBackcolor;
            txt_debit.Name = "txt_debit";
            txt_debit.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_debit.Size = XSize.FourText;
            txt_debit.Anchor = XAnchor.LT;
            txt_debit.Location = new Point((txt_credit.Left - 220), listgrid.Bottom + 30);
            txt_debit.TextAlign = HorizontalAlignment.Right;

            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lpanel);
            Name = "LVoucher";
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
