// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 26-03-2019 08:29:42 PM

using System;
using System.Data;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;

namespace CXCORE
{
    public partial class SCompany : UserControl
    {
        public SCompany()
        {
            InitializeComponent();
            Initilize();
            InitGrid();
            Load_company();
        }

        #region[Private Declare]
        //
        private ShadowBox fl_panel;
        private Panel fl_inner_panel;
        private Button btn_close;
        private Label lbl_header;
        private Label lbl_back;
        private OfficeButton btn_default;
        private OfficeButton btn_removedefault;
        private ListGridView gridItems;

        private FCompany xcompany_admin = null;


        //
        #endregion[Private Declare]

        #region[Initilize]

        private void Initilize()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            fl_panel = new ShadowBox();
            fl_inner_panel = new Panel();
            btn_close = new Button();
            lbl_header = new Label();
            lbl_back = new Label();
            btn_default = new OfficeButton();
            btn_removedefault = new OfficeButton();
            gridItems = new ListGridView();
            fl_panel.SuspendLayout();
            fl_inner_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(gridItems)).BeginInit();
            SuspendLayout();
            //
            // f_panel
            //
            fl_panel.BackColor = Theme.Flpanel_Backcolor;
            fl_panel.Controls.Add(fl_inner_panel);
            fl_panel.Location = new Point(0, 0);
            fl_panel.Name = "f_panel";
            fl_panel.Size = new Size(Theme.Flpanel_width, Theme.Flpanel_height + 90);
            //
            // f_inner_panel
            //
            fl_inner_panel.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;
            fl_inner_panel.BackColor = Color.FromArgb(10, 23, 43);
            fl_inner_panel.Controls.Add(btn_close);
            fl_inner_panel.Controls.Add(lbl_header);
            fl_inner_panel.Controls.Add(btn_default);
            fl_inner_panel.Controls.Add(btn_removedefault);
            fl_inner_panel.Controls.Add(gridItems);
            fl_inner_panel.Controls.Add(lbl_back);
            fl_inner_panel.Cursor = Cursors.Default;
            fl_inner_panel.Location = new Point(6, 5);
            fl_inner_panel.Name = "f_inner_panel";
            fl_inner_panel.Size = new Size(Theme.Fl_inner_panel_width, Theme.Fl_inner_panel_height + 110);
            // fl_inner_panel.BackgroundImage = Properties.Resources.scmp_img;
            // fl_inner_panel.BackgroundImageLayout = ImageLayout.Stretch;
            //
            // btn_close
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
            btn_close.Location = new Point(Theme.btn_close_left, Theme.btn_close_top);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(Theme.btn_close_width, Theme.btn_close_height);
            btn_close.TabIndex = 30;
            btn_close.Text = "X";
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += new EventHandler(Btn_close_Click);
            //
            // lbl_header
            //
            lbl_header.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_header.BackColor = Theme.Fl_header_Backcolor;
            lbl_header.Cursor = Cursors.Default;
            lbl_header.Font = Theme.Fl_header_Font;
            lbl_header.ForeColor = Theme.Fl_headerText_Fontcolor;
            lbl_header.Location = new Point(-5, 0);
            lbl_header.Name = "lbl_header";
            lbl_header.Size = new Size(Theme.Fl_header_width, Theme.Fl_header_height);
            lbl_header.Text = "Company";
            lbl_header.TextAlign = ContentAlignment.MiddleCenter;
            //
            gridItems.AllowUserToAddRows = false;
            gridItems.AllowUserToDeleteRows = false;
            gridItems.AllowUserToOrderColumns = true;
            gridItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(153, 202, 238);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(252, 0, 11);
            gridItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridItems.BackgroundColor = Color.White;
            gridItems.BorderStyle = BorderStyle.Fixed3D;
            gridItems.CellBorderStyle = DataGridViewCellBorderStyle.Custom;
            gridItems.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridItems.Cursor = Cursors.Default;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Calibri Light", 26.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(153, 202, 238);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(252, 0, 11);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gridItems.DefaultCellStyle = dataGridViewCellStyle3;
            gridItems.ColumnHeadersVisible = false;
            gridItems.GridColor = Color.DodgerBlue;
            gridItems.MultiSelect = false;
            gridItems.RowTemplate.Height = 35;
            gridItems.ScrollBars = ScrollBars.Vertical;
            gridItems.TabIndex = 1;
            //gridItems.Location = new Point(fl_inner_panel.Left, lbl_header.Bottom + 5);
            gridItems.Size = new Size(Theme.Fl_gridItems_width - 50, Theme.Fl_gridItems_height - 100);
            gridItems.Left = (fl_inner_panel.Width - gridItems.Width) / 2;
            gridItems.Top = 10 + (fl_inner_panel.Height - gridItems.Height) / 2;
            gridItems.Name = "gridItems";
            gridItems.ReadOnly = true;
            gridItems.RowHeadersVisible = false;
            gridItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridItems.StandardTab = true;
            //
            lbl_back.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_back.BackColor = Color.Linen;
            lbl_back.Cursor = Cursors.Default;
            lbl_back.Font = Theme.Fl_header_Font;
            lbl_back.ForeColor = Theme.Fl_headerText_Fontcolor;
            lbl_back.Size = new Size(gridItems.Width + 10, gridItems.Height + 10);
            lbl_back.Location = new Point(gridItems.Left - 5, gridItems.Top - 5);
            lbl_back.Name = "lbl_back";
            lbl_back.Text = " ";
            lbl_back.TextAlign = ContentAlignment.MiddleCenter;
            //
            btn_default.Font = Theme.btnFont;
            btn_default.Location = new Point(fl_inner_panel.Right - 255, fl_inner_panel.Bottom - 70);
            btn_default.Size = new Size(Theme.F_btn_list_width, Theme.F_btn_list_height);
            btn_default.TabIndex = 2;
            btn_default.Name = "btn_default";
            btn_default.Text = "Set Default";
            btn_default.Themes = Theme.PinkBtn;
            btn_default.Click += new EventHandler(Btn_default_Click);
            //
            btn_removedefault.Font = Theme.btnFont;
            btn_removedefault.Location = new Point(btn_default.Left - 145, fl_inner_panel.Bottom - 70);
            btn_removedefault.Size = new Size(Theme.F_btn_list_width, Theme.F_btn_list_height);
            btn_removedefault.TabIndex = 2;
            btn_removedefault.Name = "btn_removedefault";
            btn_removedefault.Text = "Remove Default";
            btn_removedefault.Themes = Theme.SteelblueBtn;
            btn_removedefault.Click += new EventHandler(Btn_removedefault_Click);
            //
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(fl_panel);
            Name = "flCompany";
            fl_panel.ResumeLayout(false);
            fl_inner_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(gridItems)).EndInit();
            ResumeLayout(false);
        }

        #endregion[Initilize]

        #region[Init Grid]

        private void InitGrid()
        {
            gridItems.RowAction += gridItems_RowAction;

            DataGridViewTextBoxColumn col_Company_Id = new DataGridViewTextBoxColumn();
            col_Company_Id.Name = COMPANY.COMPANY_ID;
            col_Company_Id.HeaderText = "COMPANY_ID ";
            col_Company_Id.Visible = false;
            col_Company_Id.Width = 200;
            col_Company_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Company_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridItems.Columns.Add(col_Company_Id);

            DataGridViewTextBoxColumn col_Company_Name = new DataGridViewTextBoxColumn();
            col_Company_Name.Name = COMPANY.COMPANY_NAME;
            col_Company_Name.HeaderText = "COMPANY NAME";
            //col_Company_Name.Visible = false; 
            col_Company_Name.Width = 500;
            col_Company_Name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Company_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridItems.Columns.Add(col_Company_Name);

            DataGridViewTextBoxColumn col_Default = new DataGridViewTextBoxColumn();
            col_Default.Name = "col_Default";
            col_Default.HeaderText = "";
            //col_Default.Visible = false; 
            col_Default.Width = 200;
            col_Default.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Default.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridItems.Columns.Add(col_Default);

        }

        void gridItems_RowAction(object sender, EventArgs e)
        {
            if (gridItems.SelectedRow == null)
            {
                return;
            }
            string pkValue = GetSelectedPkValue();

            Current.Company_id = pkValue;
            Current.Company_Name = cmp_name;
            Current.Comp_code = CCompany_exten.GetCode_id(Current.Company_Name);


            RaiseEvent_NeedToRefresh();
            Open_ACY();

            // this.Hide();
        }

        #endregion[Init Grid]

        #region[Load Company]

        public void Load_company()
        {
            List<Company> _xCompany = CCompany_exten.Active();

            if (_xCompany.Count != 0)
            {
                gridItems.RowCount = 0;
                gridItems.RowCount = _xCompany.Count;

                for (int r = 0; r < _xCompany.Count; r++)
                {
                    DataGridViewRow row = gridItems.Rows[r];
                    row.Cells[COMPANY.COMPANY_ID].Value = _xCompany[r].Company_id + "";
                    row.Cells[COMPANY.COMPANY_NAME].Value = "  " + _xCompany[r].Company_name + "";

                    DataTable TBL = new DAL().Listdata("SELECT " + DEFAULTCOMPANY.COMPANY_ID + " FROM " + DEFAULTCOMPANY.DEFAULTCOMPANY_TBL + " WHERE " + DEFAULTCOMPANY.COMPANY_ID + "  = " + _xCompany[r].Company_id);

                    if (TBL.Rows.Count != 0)
                    {
                        row.Cells["col_Default"].Value = "Default";
                    }
                    else
                    {
                        row.Cells["col_Default"].Value = "";
                    }
                }
            }
            else
            {
                Open_Company();

            }
        }
        private void Open_Company()
        {
            if (Current.Company_id == Current.Codexsun)
            {
                if (xcompany_admin == null)
                {
                    xcompany_admin = new FCompany();
                }
                //xcompany_admin.FCompany_NeedToRefresh += FCompany_NeedToRefresh;
                Controls.Add(xcompany_admin);
                xcompany_admin.Dock = DockStyle.Fill;
                xcompany_admin.Show();
                xcompany_admin.BringToFront();
                xcompany_admin.SetAction(BtnEvent.New, null);
                xcompany_admin.SetFocus();
            }
        }

        private SACY sacy = null;

        private void Open_ACY()
        {
            if (sacy == null)
            {
                sacy = new SACY();
            }
            sacy.SACY_NeedToRefresh += SACY_NeedToRefresh;
            Controls.Add(sacy);
            sacy.Dock = DockStyle.Fill;
            sacy.Show();
            sacy.BringToFront();
            //sacy.SetAction(BtnEvent.New, null);
            //sacy.SetFocus();
        }

        #endregion[Load Company]

        #region[Need to refresh]

        void FCompany_NeedToRefresh(object sender, EventArgs e)
        {
            Load_company();
        }

        void SACY_NeedToRefresh(object sender, EventArgs e)
        {
            RaiseEvent_NeedToRefresh();
            this.Hide();
        }

        #endregion[Need to refresh]

        #region[Btn Click]

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Btn_default_Click(object sender, EventArgs e)
        {
            Defaultcompany obj = new Defaultcompany()
            {
                Defaultcompany_id = "1",
                Company_id = GetSelectedPkValue(),
                Acy_id = "1"
            };

            CDefaultcompany.Update(obj, new DAL());

            Load_company();
        }

        private void Btn_removedefault_Click(object sender, EventArgs e)
        {
            Defaultcompany obj = new Defaultcompany()
            {
                Defaultcompany_id = "1",
                Company_id = "NO",
                Acy_id = "NO"
            };

            CDefaultcompany.Update(obj, new DAL());

            Load_company();
        }

        #endregion[Btn Click]

        #region[GetSelected PKvalue]

        private string cmp_name = "";
        private string GetSelectedPkValue()
        {
            DataGridViewRow vSelRow = null;
            if (gridItems.SelectedRows != null && gridItems.SelectedRows.Count != 0)
            {
                vSelRow = gridItems.SelectedRows[0];
            }
            //
            string selPkValue = null;
            if (vSelRow != null)
            {
                selPkValue = vSelRow.Cells[COMPANY.COMPANY_ID].Value.ToString();
                cmp_name = (vSelRow.Cells[COMPANY.COMPANY_NAME].Value.ToString()).Trim();
            }
            return selPkValue;
        }

        #endregion[GetSelected PKvalue]

        #region[RaiseEvent]

        public event EventHandler SCompany_NeedToRefresh;

        public void RaiseEvent_NeedToRefresh()
        {
            SCompany_NeedToRefresh?.Invoke(this, new EventArgs());
        }

        #endregion[RaiseEvent]


    }//cls 
}//ns 
