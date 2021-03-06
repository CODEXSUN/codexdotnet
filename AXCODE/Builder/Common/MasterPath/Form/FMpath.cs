// Version : 2.1.0.0 dt : 04-12-2018
// Auto Generated
// last update : 06-12-2018 10:53:54 PM

using System;
using System.Windows.Forms;
using CXLIB;
using System.Drawing;


namespace AXCODE
{
    public partial class FMpath : UserControl
    {


        #region[Split Timer]

        private bool expand;

        private void SplitTimer_Tick(object sender, EventArgs e)
        {
            if (expand)
            {
                if (split_container.SplitterDistance < Convert.ToInt32(ClientSize.Width) - 29)
                {
                    split_container.SplitterDistance += 50;
                }
                else
                {
                    btn_splitter.Text = "⁞⁞";
                    expand = false;
                    splitTimer.Stop();
                }
            }
            else
            {
                if (split_container.SplitterDistance > Convert.ToInt32(ClientSize.Width) - 150)
                {
                    split_container.SplitterDistance += -50;
                }
                else
                {
                    btn_splitter.Text = ">>";
                    expand = true;
                    splitTimer.Stop();
                }
            }
        }
        private void Btn_splitter_Click(object sender, EventArgs e)
        {
            splitTimer.Enabled = true;
        }
        private void Btn_close_Click(object sender, EventArgs e)
        {
            Hide();
            Form_NeedToRefresh();
        }

        #endregion[Split Timer]

        #region[Enter Event]

        private void Txt_mtables_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_mtables_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_mtables_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_mtables_id.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_root_folder_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_root_folder.BackColor = Theme.lbl_EnterBackColor;
            lbl_root_folder.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_root_folder.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_contfolder_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_contfolder.BackColor = Theme.lbl_EnterBackColor;
            lbl_contfolder.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_contfolder.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_classfolder_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_classfolder.BackColor = Theme.lbl_EnterBackColor;
            lbl_classfolder.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_classfolder.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_formfolder_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_formfolder.BackColor = Theme.lbl_EnterBackColor;
            lbl_formfolder.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_formfolder.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_listfolder_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_listfolder.BackColor = Theme.lbl_EnterBackColor;
            lbl_listfolder.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_listfolder.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_setupfolder_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_setupfolder.BackColor = Theme.lbl_EnterBackColor;
            lbl_setupfolder.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_setupfolder.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_testfolder_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_testfolder.BackColor = Theme.lbl_EnterBackColor;
            lbl_testfolder.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_testfolder.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_notes_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_notes.BackColor = Theme.lbl_EnterBackColor;
            lbl_notes.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_notes.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Change_infocus()
        {

            lbl_mtables_id.BackColor = Theme.lbl_BackColor;
            lbl_mtables_id.BorderColor = Theme.lbl_BorderColor;
            lbl_mtables_id.ForeColor = Theme.lbl_ForeColor;

            lbl_root_folder.BackColor = Theme.lbl_BackColor;
            lbl_root_folder.BorderColor = Theme.lbl_BorderColor;
            lbl_root_folder.ForeColor = Theme.lbl_ForeColor;

            lbl_contfolder.BackColor = Theme.lbl_BackColor;
            lbl_contfolder.BorderColor = Theme.lbl_BorderColor;
            lbl_contfolder.ForeColor = Theme.lbl_ForeColor;

            lbl_classfolder.BackColor = Theme.lbl_BackColor;
            lbl_classfolder.BorderColor = Theme.lbl_BorderColor;
            lbl_classfolder.ForeColor = Theme.lbl_ForeColor;

            lbl_formfolder.BackColor = Theme.lbl_BackColor;
            lbl_formfolder.BorderColor = Theme.lbl_BorderColor;
            lbl_formfolder.ForeColor = Theme.lbl_ForeColor;

            lbl_listfolder.BackColor = Theme.lbl_BackColor;
            lbl_listfolder.BorderColor = Theme.lbl_BorderColor;
            lbl_listfolder.ForeColor = Theme.lbl_ForeColor;

            lbl_setupfolder.BackColor = Theme.lbl_BackColor;
            lbl_setupfolder.BorderColor = Theme.lbl_BorderColor;
            lbl_setupfolder.ForeColor = Theme.lbl_ForeColor;

            lbl_testfolder.BackColor = Theme.lbl_BackColor;
            lbl_testfolder.BorderColor = Theme.lbl_BorderColor;
            lbl_testfolder.ForeColor = Theme.lbl_ForeColor;

            lbl_notes.BackColor = Theme.lbl_BackColor;
            lbl_notes.BorderColor = Theme.lbl_BorderColor;
            lbl_notes.ForeColor = Theme.lbl_ForeColor;

        }

        #endregion[Enter Event]

        #region[Btn Event ]

        private void Btn_active_Click(object sender, EventArgs e)
        {
            ToggleActive();
        }

        private void Btn_save_click(object sender, EventArgs e)
        {
            Save_Event();
        }

        private void Btn_list_Click(object sender, EventArgs e)
        {
            splitTimer.Enabled = true;
            this.Hide();
        }

        private void Btn_new_Click(object sender, EventArgs e)
        {
            splitTimer.Enabled = true;
            SetAction(BtnEvent.New, null);
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            if (vId != "")
            {
                splitTimer.Enabled = true;
                SetAction(BtnEvent.Edit, vId);
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            if (vId != "")
            {
                splitTimer.Enabled = true;
                SetAction(BtnEvent.Delete, vId);
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            if (vId != "")
            {
                splitTimer.Enabled = true;
                SetAction(BtnEvent.Print, vId);
            }
        }

        private void Btn_root_Click(object sender, EventArgs e)
        {
            if (txt_root_folder.Text == "")
            {

                txt_root_folder.Text = "CXCORE";

            }

                string tablename = txt_mtables_id.Text.Remove((txt_mtables_id.Text).Length - 4).UpperFirst();

                string rootFolder = txt_root_folder.Text + "\\" + tablename;


                txt_contfolder.Text = rootFolder + "\\Const";
                txt_classfolder.Text = rootFolder + "\\Crud";
                txt_formfolder.Text = rootFolder + "\\Form";
                txt_listfolder.Text = rootFolder + "\\List";
                txt_setupfolder.Text = rootFolder + "\\Setup";
                txt_testfolder.Text = rootFolder + "\\Test";

        }

        #endregion[Btn Event ]

        #region[Lbl Event ]

        private void Lbl_notes_Click(object sender, EventArgs e)
        {
            txt_notes.Refresh();
            if (txt_notes.Height == 600)
            {
                txt_notes.BackColor = Color.White;
                txt_notes.Width = Theme.F_txt_notes_width - 100;
                txt_notes.Height = Theme.F_txt_notes_height;
                txt_notes.Location = new Point(Theme.txt_left, Theme.Fpanel_height - 75);
            }
            else if (txt_notes.Height == Theme.F_txt_notes_height)
            {
                txt_notes.Location = new Point(lbl_notes.Right - 1, 137);
                txt_notes.Width = 1170;
                txt_notes.Height = 600;
                txt_notes.BackColor = Color.FromArgb(255, 255, 192);
            }
        }
        #endregion[Lbl Event ]

        #region[Active Event ]

        private void ToggleActive()
        {
            if (btn_active.Text != Core.ACTIVE_TXT)
            {
                btn_active.Themes = Themescheme.Green;
                btn_active.Text = Core.ACTIVE_TXT;
                Core.Stative = Core.Active;
            }
            else
            {
                btn_active.Themes = Themescheme.RED;
                btn_active.Text = Core.NOTACTIVE_TXT;
                Core.Stative = Core.NotActive;
            }
        }

        private void Setactives()
        {
            if (Core.Stative == Core.Active)
            {
                btn_active.Themes = Themescheme.Green;
                btn_active.Text = Core.ACTIVE_TXT;
                btn_save.Focus();
                this.Refresh();
            }
            else if (Core.Stative == Core.NotActive)
            {
                btn_active.Themes = Themescheme.RED;
                btn_active.Text = Core.NOTACTIVE_TXT;
                this.Refresh();
            }
            else if (Core.Stative == Core.Idle)
            {
                btn_active.Themes = Themescheme.WHITE;
                btn_active.Text = Core.IDLE_TXT;
            }
        }

        #endregion[Active Event ]

        #region[lookup] 

        public void Mtables_lookup()
        {
            txt_mtables_id.LookupColNames = new string[] { MASTERTABLES.MASTERTABLES_NAME };
            txt_mtables_id.LookupUpdate += txt_mpath_LookupUpdate;
            txt_mtables_id.AllowNewEntry = true;
            txt_mtables_id.NewEntryNeeded += txt_mpath_NewEntryNeeded;
        }
        void txt_mpath_LookupUpdate(object sender, EventArgs e)
        {
            txt_mtables_id.LookupList = CMtables_exten.GetforLookup(new SQLITE_DAL());
        }
        private FMpath fsmpath = null;
        void txt_mpath_NewEntryNeeded(object sender, string pValue)
        {
            if (fsmpath == null)
            {
                fsmpath = new FMpath();
            }
            Parent.Controls.Add(fsmpath);
            fsmpath.Dock = DockStyle.Fill;
            fsmpath.Show();
            fsmpath.BringToFront();
            fsmpath.Focus();

            fsmpath.SetAction(BtnEvent.New, null);
            fsmpath.SetFocus();
        }

        #endregion[lookup] 

        #region[Raise Event ]

        public event EventHandler FMpath_NeedToRefresh;

        public void Form_NeedToRefresh()
        {
            if (FMpath_NeedToRefresh != null)
            {
                FMpath_NeedToRefresh(this, new EventArgs());
            }
        }
        #endregion[Raise Event ]

        #region[GetName]

        public string GetName()
        {
            return txt_mtables_id.Text;
        }
        public void setname(string pName)
        {
            txt_mtables_id.Text = pName;
        }
        public void SetFocus()
        {
            txt_mtables_id.Focus();
        }
        #endregion[Set Focus]

    }//cls 
}//ns 
