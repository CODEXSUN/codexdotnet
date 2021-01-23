// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 26-03-2019 08:29:42 PM

using System;
using System.Windows.Forms;
using CXLIB;
using CXCORE;
using System.Drawing;
using System.Collections.Generic;

namespace CXSUN
{
    public partial class Main
    {

        #region [mycontrol] 

        void Mymenu_Click(object sender, EventArgs e, CxControl usc)
        {
            usc.NeedToRefresh += Remove_tab;

            usc.mytab = new TabPage(sender.ToString());

            main_tabControl.TabPages.Add(usc.mytab);
            usc.mytab.Controls.Add(usc);

            usc.Dock = DockStyle.Fill;
            usc.Show();
            usc.BringToFront();

            main_tabControl.SelectTab(usc.mytab);
        }
        void Remove_tab(object sender, EventArgs e)
        {
            var usc = sender as CxControl;
            main_tabControl.TabPages.Remove(usc.mytab);
           
        }

        #endregion[mycontrol] 

        #region[Admin]

        #region [Login] 

        FLogin flogin = null;
        void ShowLoginform()
        {
            if (flogin == null)
            {
                flogin = new FLogin();
            }

            flogin.Login_NeedToRefresh += FLogin_Refresh;
            Controls.Add(flogin);
            flogin.Show();
            flogin.Location = new Point(0, 0);
            flogin.Size = new Size(Theme.Screen_Width, Theme.Screen_Heigth);
            flogin.BringToFront();
            flogin.SetDefault();
        }
        public void FLogin_Refresh(object sender, EventArgs e)
        {
            Scompany_menu_Click(null, null);
        }

        #endregion [Login] 

        #region [Logout] 

        void Logout_menu_Click(object sender, EventArgs e)
        {
            //user_menu.Text = "";
            LogoutallOpened();

            Current.User = "";
            Current.User_name = "";

            if (flogin == null)
            {
                flogin = new FLogin();
            }

            flogin.Login_NeedToRefresh += FLogin_Refresh;
            Controls.Add(flogin);
            flogin.Show();
            flogin.Location = new Point(0, 0);
            flogin.Size = new Size(Theme.Screen_Width, Theme.Screen_Heigth);
            flogin.BringToFront();
            flogin. SetDefault();
        }

        #endregion [Logout] 

        #region[Select Company]

        SCompany scompany = null;
        void Scompany_menu_Click(object sender, EventArgs e)
        {
            List<Company> cmp = CCompany_exten.Active();

            if (cmp.Count != 0)
            {
                Defaultcompany defaultcompany = CDefaultcompany_exten.PKId("1", new DAL());

                if ((defaultcompany.Company_id == null) || (defaultcompany.Company_id == "NO"))
                {
                    if (scompany == null)
                    {
                        scompany = new SCompany();
                    }

                    //scompany. RaiseEvent_NeedToRefresh += SCompany_Refresh;
                    Controls.Add(scompany);
                    scompany.Show();
                    scompany.Dock = DockStyle.Fill;
                    scompany.BringToFront();
                }
                else
                {
                    Current.Company_id = defaultcompany.Company_id;

                    Current.Company_Name = CCompany_exten.GetName_Id(Current.Company_id);
                    Current.Comp_code = CCompany_exten.GetCode_id(Current.Company_id);

                    Current.Acy_id = defaultcompany.Acy_id;
                    Current.Acy_Name = CAcy_exten.GetName_Id(defaultcompany.Acy_id);
                    Current.Acy_From = CAcy_exten.AcyFrom_Id(defaultcompany.Acy_id);
                    Current.Acy_To = CAcy_exten.AcyTo_Id(defaultcompany.Acy_id);


                    SCompany_Refresh(null, null);
                }
            }
        }

        void Select_company_menu_Click(object sender, EventArgs e)
        {
            LogoutallOpened();
            if (scompany == null)
            {
                scompany = new SCompany();
            }
            //scompany.SCompany_NeedToRefresh += SCompany_Refresh;
            Controls.Add(scompany);
            scompany.Show();
            scompany.Dock = DockStyle.Fill;
            scompany.BringToFront();
        }

        public void SCompany_Refresh(object sender, EventArgs e)
        {
            //user_menu.Text = Current.User_name;

            Current.SoftwareTo = Current.Comp_code;
            _ = new GetCustomised();

            cmp_info.Text = " " + Current.Company_Name + " - " + Current.Acy_Name;
            cmp_info.Location = new Point(Home.Width - ((cmp_info.Text.Length * 6) + 220), Home.Top + 30);
        }

        #endregion[Select Company]

        #endregion[Admin]

    }//cls
}//ns
