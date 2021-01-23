using System.Windows.Forms;

namespace CXSETUP
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
            ClickEvent();
        }

        private void ClickEvent()
        {

            new_menu.Click += New_menu_Click;
            update_menu.Click += Update_menu_Click;
            exit_menu.Click += Exit_menu_Click;
        }

        private NewSetup newSetup = null;
        private void New_menu_Click(object sender, System.EventArgs e)
        {
            if (newSetup == null)
            {
                newSetup = new NewSetup();
            }
            Main_screen.Controls.Add(newSetup);
            newSetup.Dock = DockStyle.Fill;
            newSetup.Show();
            newSetup.BringToFront();

        }

        private void Update_menu_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Exit_menu_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

    }//cls
}//ns
