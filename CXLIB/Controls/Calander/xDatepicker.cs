using System.Windows.Forms;

namespace CXLIB
{
    public partial class xDatepicker : DateTimePicker
    {
        public xDatepicker()
            {
            Font = Theme.txtFont;
            CustomFormat = "  dd-MM-yyy";
            Format = DateTimePickerFormat.Custom;
        }
        bool f_EnableNavigationKeys = true;
        public bool EnableNavigationKeys
        {
            get { return f_EnableNavigationKeys; }
            set { f_EnableNavigationKeys = value; }
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.Handled == true) return;
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (f_EnableNavigationKeys == false)
                {
                    return;
                }
                this.FindForm().SelectNextControl(this, true, true, true, true);
                return;
            }
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.Handled == true) return;
            if (f_EnableNavigationKeys == false)
            {
                //--do-nothing.
            }
            else if (e.KeyCode == Keys.Up)
            {
                    e.Handled = true;
                    SendKeys.Send("+{TAB}");
            }
            else if (e.KeyCode == Keys.Down)
            {
                    e.Handled = true;
                    SendKeys.Send("{TAB}");
            }
            //else if (e.KeyCode == Keys.Left)
            //{
            //        e.Handled = true;
            //        SendKeys.Send("+{TAB}");
            //}
            //else if (e.KeyCode == Keys.Right)
            //{
            //        e.Handled = true;
            //        SendKeys.Send("{TAB}");
            //}
        }
    }
}
