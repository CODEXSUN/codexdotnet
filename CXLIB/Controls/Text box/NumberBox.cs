///  Version : 5 dt : 10-08-2016 
/// 
#region[Conclusion]   
/// create date : 07-10-2016   
/// last update : 07-10-2016     
#endregion[Conclusion]   
///    
#region[using] 
/// 
using System;
using System.Windows.Forms;
/// 
#endregion[using] 
/// 
#region[namespace] 
/// 
namespace CXLIB
{
    public partial class xNumberBox : CXLIB.XTextBox
    {
        /// 
        #endregion[namespace] 
        /// 
        public xNumberBox()
        {
            InitializeComponent();

            SuppressIfZero = true;
            AllowDecimal = false;
            AllowNegative = false;
            FormatString = "0";
            MaxNumber = 9999999999.99M; //decimal(12,2)
        }
        private bool suppressIfZero;
        private bool allowDecimal;
        private bool allowNegative;
        private decimal maxNumber;
        private string formatString;
        public bool AllowDecimal
        {
            get { return allowDecimal; }
            set { allowDecimal = value; }
        }
        public bool AllowNegative
        {
            get { return allowNegative; }
            set { allowNegative = value; }
        }
        public string FormatString
        {
            get { return formatString; }
            set { formatString = value; }
        }
        public decimal MaxNumber
        {
            get { return maxNumber; }
            set { maxNumber = value; }
        }

        public bool SuppressIfZero
        {
            get { return suppressIfZero; }
            set { suppressIfZero = value; }
        }

        public static bool IsNumber(string numberString)
        {

            decimal d;
            return IsNumber(numberString, out d);
        }

        public static bool IsNumber(string numberString, out Decimal number)
        {

            if (Decimal.TryParse("0" + numberString.Trim(), out number) == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            //base.OnKeyPress(e);
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                //do-nothing
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                //do-nothing
            }

            else if (e.KeyChar == '.' && allowDecimal == true)
            {
                //do-nothing
            }
            else if (e.KeyChar == '-' && allowNegative == true)
            {
                //do-nothing
            }
            else
            {
                Console.Beep();
                e.Handled = true;

                return;
            }
            /////
            string curtext = base.Text;
            string newtext = "";
            newtext += curtext.Substring(0, this.SelectionStart);
            if (e.KeyChar == (char)Keys.Back)
            {
                if (newtext.Length >= 1)
                {
                    newtext = newtext.Substring(0, newtext.Length - 1);
                }
            }
            else
            {
                newtext += e.KeyChar;
            }
            newtext += curtext.Substring(this.SelectionStart + this.SelectionLength);
            /////
            Decimal newnum;
            if (IsNumber(newtext, out newnum) == false)
            {
                Console.Beep();
                e.Handled = true;

                return;
            }
            if (MaxNumber != 0 && newnum > MaxNumber)
            {
                Console.Beep();
                e.Handled = true;
                return;
            }
            //////

        }
        private void ApplySettings()
        {
            decimal num = 0;
            ///
            try
            {
                num = Convert.ToDecimal(base.Text == "" ? "0" : base.Text);
            }
            catch (FormatException fe)
            {
                base.Text = "" + fe;
                base.Text = "";
                return;
            }
            ///
            if (suppressIfZero == true && base.Text == "")
            {
                return;
            }

            else if (suppressIfZero == true && Convert.ToDecimal(base.Text) == 0)
            {

                base.Text = "";
                return;
            }
            //base.OnLeave(e);
            if (formatString != "")
            {
                base.Text = String.Format("{0:" + formatString + "}", num);
            }
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            ///
            ApplySettings();
        }
        ///
    }///cls
}///ns
