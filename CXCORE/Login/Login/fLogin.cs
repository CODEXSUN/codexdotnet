// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 26-03-2019 08:29:42 PM

using System;
using System.Windows.Forms;
using System.Drawing;
using CXLIB;
//
namespace CXCORE
{
    public partial class FLogin : UserControl
    {
        private int errorcount = 1;

        #region[RaiseEvent]

        public event EventHandler Login_NeedToRefresh;
        public void RaiseEvent_NeedToRefresh()
        {
            Login_NeedToRefresh?.Invoke(this, new EventArgs());
        }

        #endregion[RaiseEvent]

        #region[SetDefault User and pass]

        public void SetDefault()
        {
            Defaultlogin obj = CDefaultlogin_exten.PKId("1", new DAL());

            if (obj.Defaultlogin_name != null)
            {
                txt_user_name.Text = obj.Defaultlogin_name;
                txt_user_password.Text = obj.Default_password;
                login_checkBox.Checked = true;
            }
            txt_errorUserPassword.Text = "";
            errorcount = 0;
        }

        #endregion[SetDefault User and pass]

        #region[Btn Login click]

        private void Btn_login_Click(object sender, EventArgs e)
        {
            if (errorcount < 5)
            {

                User obj = CUser_exten.SearchName(txt_user_name.Text.ToUpper(),new DAL());

                if (obj.User_name != "")
                {
                    if (obj.User_password == txt_user_password.Text)
                    {
                        Current.User = obj.User_id;
                        Current.User_name = obj.User_name;
                        txt_errorUserPassword.Text = "";
                        timer_warning.Stop();
                        Hide();

                        RaiseEvent_NeedToRefresh();
                    }
                    else
                    {
                        txt_user_password.Text = "";
                        txt_errorUserPassword.Text = "Warning ! Check user password ";
                        txt_user_password.Focus();
                        errorcount++;
                    }
                }
                else
                {
                    txt_user_password.Text = "";
                    txt_user_name.Text = "";
                    txt_errorUserPassword.Text = "Warning ! Check user Name ";
                    txt_user_name.Focus();
                    errorcount++;
                }
            }
            else
            {
                txt_user_password.Text = "";
                txt_user_name.Text = "";
                txt_user_name.Enabled = false;
                txt_user_password.Enabled = false;
                btn_login.Enabled = false;
                txt_errorUserPassword.Text = "Sorry ! You have tried 5 atempt error \r\n so it goes locked on ! contact admin... ";
            }
        }

        #endregion[Btn Login click]

        #region[Btn Exit]
        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion[Btn Exit]

        #region[Text Keydown]

        private void Txt_user_name_KeyDown(object sender, KeyEventArgs e)
        {
            Keys_keydown(sender, e);
        }
        private void Txt_user_password_KeyDown(object sender, KeyEventArgs e)
        {
            Keys_keydown(sender, e);
        }
        public void Keys_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
            else if (e.KeyCode == Keys.Up)
            {
                e.Handled = true;
                SendKeys.Send("+{TAB}");
            }
        }

        #endregion[Text Keydown]

        #region[Text Enter]

        private void Txt_user_name_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            txt_user_name.BackColor = Color.FromArgb(255, 242, 157);
            txt_user_name.ForeColor = Color.Crimson;
            pic_password.BackColor = Color.White; //FromArgb(255, 242, 157);
        }
        private void Txt_user_password_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            txt_user_password.BackColor = Color.FromArgb(255, 242, 157);
            txt_user_password.ForeColor = Color.Crimson;
            pic_user.BackColor = Color.White;//FromArgb(255, 242, 157);
        }
        private void Change_infocus()
        {
            txt_user_name.BackColor = Color.White;
            txt_user_name.ForeColor = SystemColors.ControlText;
            /// 
            txt_user_password.BackColor = Color.White;
            txt_user_password.ForeColor = SystemColors.ControlText;
            /// 
            pic_password.BackColor = Color.FromArgb(255, 242, 157);
            pic_user.BackColor = Color.FromArgb(255, 242, 157);
        }

        #endregion[Text Enter]

        #region[Warning Message]
        private void timer_warning_Tick(object sender, EventArgs e)
        {
            timer_warning.Start();
            if (txt_errorUserPassword.Visible == true)
            {
                txt_errorUserPassword.Visible = false;
            }
            else if (txt_errorUserPassword.Visible == false)
            {
                txt_errorUserPassword.Visible = true;
            }
        }

        #endregion[Warning Message]

        #region[Login checkbox changes]

        private void Login_checkBox_CheckedChanged(object sender, EventArgs e)
        {

            Defaultlogin obj = CDefaultlogin_exten.PKId("1", new DAL());

            if (login_checkBox.Checked == true)
            {
                if (obj.Defaultlogin_name != null)
                {
                    if ((txt_user_name.Text == obj.Defaultlogin_name) && (txt_user_password.Text == obj.Default_password))
                    {
                        return;
                    }
                    else
                    {
                        obj.Defaultlogin_id = "1";
                        obj.Defaultlogin_name = txt_user_name.Text;
                        obj.Default_password = txt_user_password.Text;
                        obj.Createon = Current.Datetime;

                        CDefaultlogin.Update(obj, new DAL());
                    }
                }
                else
                {
                    if ((txt_user_name.Text != "") || (txt_user_password.Text != ""))
                    {
                        obj.Defaultlogin_id = "1";
                        obj.Defaultlogin_name = txt_user_name.Text;
                        obj.Default_password = txt_user_password.Text;
                        obj.Createon = Current.Datetime;

                        CDefaultlogin.Insert(obj, new DAL());
                    }
                }
            }
            else if (login_checkBox.Checked == false)
            {
                CDefaultlogin.Delete("1", new DAL());
            }
        }

        #endregion[Login checkbox changes]

    }//cls
}//ns
