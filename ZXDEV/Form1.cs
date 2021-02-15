using CXLIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZXDEV
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            //split_container.SplitterDistance = 20;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitTimerS.Start();
        }


        private bool expand;
        private void splitTimerS_Tick(object sender, EventArgs e)
        {
            if (expand)
            {
                if (split_container.SplitterDistance < 220)
                {
                    split_container.SplitterDistance += 30;
                }
                else
                {
                    //btn_splitter.Text = "⁞⁞";
                    expand = false;
                    splitTimerS.Stop();
                }
            }
            else
            {
                if (split_container.SplitterDistance > 30)
                {
                    split_container.SplitterDistance += -30;
                }
                else
                {
                    //btn_splitter.Text = ">>";
                    expand = true;
                    splitTimerS.Stop();
                }
            }
        }

    
    }
}
