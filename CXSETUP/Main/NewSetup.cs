using System;
using System.Data;
using System.Windows.Forms;
using CXLIB;

namespace CXSETUP
{
    public partial class NewSetup : UserControl
    {
        public NewSetup()
        {
            InitializeComponent();
            ClickEvents();
            ComboBoxLoadData();
            Databases_lookup();
        }

        private void ClickEvents()
        {
            cmb_softwaretype.SelectedIndexChanged += Cmb_softwaretype_SelectedIndexChanged;
            btn_setupdb.Click += Btn_setupdb_Click;
        }

        #region[Combo Box]

        private void ComboBoxLoadData()
        {
            cmb_softwaretype.Items.Add(Softwares.GARMENT);
            //cmb_softwaretype.Items.Add(Softwares.OFFSET);
            cmb_softwaretype.Items.Add(Softwares.OFFSET_1);
            cmb_softwaretype.Items.Add(Softwares.TEX);
            //cmb_softwaretype.Items.Add(Softwares.KNITTING);
            cmb_softwaretype.Items.Add(Softwares.UPVC);

            cmb_acy.Items.Add(ACY.Y_2017_18);
            cmb_acy.Items.Add(ACY.Y_2018_19);
            cmb_acy.Items.Add(ACY.Y_2019_20);
            cmb_acy.Items.Add(ACY.Y_2020_21);
            cmb_acy.Items.Add(ACY.Y_2021_22);
        }

        private void Cmb_softwaretype_SelectedIndexChanged(object sender, EventArgs e)
        {
            Current.SoftwareType = Softwares.Getcode(cmb_softwaretype.Text);
        }

        #endregion[Combo Box]

        #region[Database lookup] 

        public void Databases_lookup()
        {
            DataTable tbl = new SYS_DAL().Listdata("SHOW DATABASES");

            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                var s = tbl.Rows[i]["DATABASE"].ToString();

                if ((s != "mysql") && (s != "information_schema") && (s != "performance_schema"))
                {
                    txt_database.Items.Add(s);
                }
            }
        }


        #endregion[Database lookup] 

        #region[Btn Click]

        private void Btn_setupdb_Click(object sender, System.EventArgs e)
        {

            RunSetup.Processing += Status;
            //InsertDefault.Processing_1 += Status;

            try
            {
                RunSetup.Install(CollectData());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                MessageBox.Show("Setup Database Finished");
            }

        }

        #endregion[Btn Click]

        #region[Collect Data]

        private Setup CollectData()
        {
            Setup obj = new Setup()
            {
                SoftwareType = cmb_softwaretype.Text,
                Database = txt_database.Text,
                Company = txt_companyname.Text,
                Displayname = txt_displayname.Text,
                Acy_name = cmb_acy.Text,
                Mode = "new"
            };

            if (obj.Database == "") { obj.Database = "NEW_DB"; }
            if (obj.Company == "") { obj.Company = (obj.Database).Replace("_DB", ""); }
            if (obj.Displayname == "") { obj.Displayname = obj.Company; }
            if (obj.Acy_name == "") { obj.Acy_name = "2019-2020"; }
            if (obj.Mode == "") { obj.Mode = "new"; }

            return obj;
        }

        #endregion[Collect Data]

        #region[Status]

        private void Status(object sender, EventArgs e)
        {
            lbl_status.Text = RunSetup.screenText.ToString() + "";
            //lbl_status_1.Text = InsertDefault.screenText_1.ToString() + "";
            lbl_status.Refresh();
            lbl_status_1.Refresh();
            Application.DoEvents();
            this.Refresh();
        }

        #endregion[Status]

    }//cls
}//ns
