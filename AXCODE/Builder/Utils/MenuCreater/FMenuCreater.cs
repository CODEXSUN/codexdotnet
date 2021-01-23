using System;
using System.Windows.Forms;

namespace AXCODE
{
    public partial class FMenuCreater : UserControl
    {
        public FMenuCreater()
        {
            InitializeComponent();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void Btn_create_Click(object sender, EventArgs e)
        {
            Create();
        }
        private void Create()
        {
            string tbl = txt_table.Text;
            string path = txt_path.Text;

            path =@"D:\WorkSpace\C#\CODEXNET\CODEIT\Main";

            CMenu.Creater(tbl, path, MenuType.Form);
        }

    }//cls
}//ns
