// Version : 2.1.0.0 dt : 04-12-2018
// Auto Generated
// 06-12-2018 10:53:54 PM
// last update : 06-12-2018

using System;
using System.Windows.Forms;
using CXLIB;

namespace AXCODE
{
    public partial class FMpath : UserControl
    {
        #region[Action]

        private BtnEvent fAction = BtnEvent.Open;
        private MasterTablePath obj;
        private string vId;

        public void SetAction(BtnEvent pAction, string pPkValue)
        {
            fAction = pAction;

            switch (fAction)
            {
                case BtnEvent.Open:
                    btn_save.Text = "CLOSE";
                    obj = CMpath_exten.PKId(pPkValue, new SQLITE_DAL());
                    this.EnableControls(false);
                    break;
                case BtnEvent.New:
                    btn_save.Text = "SAVE";
                    obj = CMpath.GetNew;
                    this.EnableControls(true);
                    break;
                case BtnEvent.Edit:
                    btn_save.Text = "UPDATE";
                    obj = CMpath_exten.PKId(pPkValue, new SQLITE_DAL());
                    this.EnableControls(true);
                    break;
                case BtnEvent.Delete:
                    btn_save.Text = "CONFIRM\r\nDELETE";
                    obj = CMpath_exten.PKId(pPkValue, new SQLITE_DAL());
                    this.EnableControls(false);
                    break;
                case BtnEvent.Print:
                    btn_save.Text = "PRINT";
                    obj = CMpath_exten.PKId(pPkValue, new SQLITE_DAL());
                    this.EnableControls(false);
                    break;
            }

            this.LoadData();
        }

        #endregion[Action]

        #region[Load Data]

        private void LoadData()
        {
            vId = obj.Masterpath_id;
            txt_mtables_id.Text = obj.Mastertables_id;
            txt_root_folder.Text = obj.Root_folder;
            txt_contfolder.Text = obj.Contfolder;
            txt_classfolder.Text = obj.Classfolder;
            txt_formfolder.Text = obj.Formfolder;
            txt_listfolder.Text = obj.Listfolder;
            txt_setupfolder.Text = obj.Setupfolder;
            txt_testfolder.Text = obj.Testfolder;
            Core.Stative = obj.Active_id;
            Setactives();
        }

        #endregion[Load Data]

        #region[Enable  Disable Controls]

        private void EnableControls(bool pEnabled)
        {
            bool pReadOnly = !pEnabled;

            txt_mtables_id.Enabled = !pReadOnly;
            txt_root_folder.Enabled = !pReadOnly;
            txt_contfolder.Enabled = !pReadOnly;
            txt_classfolder.Enabled = !pReadOnly;
            txt_formfolder.Enabled = !pReadOnly;
            txt_listfolder.Enabled = !pReadOnly;
            txt_setupfolder.Enabled = !pReadOnly;
            txt_testfolder.Enabled = !pReadOnly;
            txt_notes.Enabled = !pReadOnly;

            btn_active.Enabled = !pReadOnly;

        }

        #endregion[Enable  Disable Controls]

        #region[Save Event]

        private SQLITE_DAL dalsession;
        private void Save_Event()
        {
            if (Validation() != false)
            {
                switch (fAction)
                {
                    case BtnEvent.Open:
                        this.Hide();
                        Form_NeedToRefresh();
                        break;

                    case BtnEvent.New:
                        try
                        {
                            var vData = CollectData();

                            dalsession = new SQLITE_DAL();
                            dalsession.BeginTransaction();
                            CMpath.Insert(vData, dalsession);
                            dalsession.Commit();

                            MessageBox.Show(this.FindForm(), "Record Saved Successfully.", "Save...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.Hide();
                            Form_NeedToRefresh();
                        }
                        catch (Exception ex)
                        {
                            if (dalsession != null)
                            {
                                dalsession.Rollback();
                            }
                            MessageBox.Show(this.FindForm(), "Something Goes Wrong \r\n" + ex.Message, "Could Not Save...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            SetFocus();
                            return;
                        }
                        break;

                    case BtnEvent.Edit:
                        try
                        {
                            var vData = CollectData();

                            dalsession = new SQLITE_DAL();
                            dalsession.BeginTransaction();
                            CMpath.Update(vData, dalsession);
                            dalsession.Commit();

                            MessageBox.Show(this.FindForm(), "Record Updated Successfully.", "Update...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.Hide();
                            Form_NeedToRefresh();
                        }
                        catch (Exception ex)
                        {
                            if (dalsession != null)
                            {
                                dalsession.Rollback();
                            }
                            MessageBox.Show(this.FindForm(), "Something Goes Wrong \r\n" + ex.Message, "Could Not Update...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            SetFocus();
                            return;
                        }
                        break;

                    case BtnEvent.Delete:
                        try
                        {
                            dalsession = new SQLITE_DAL();
                            dalsession.BeginTransaction();
                            CMpath.Delete(vId, dalsession);
                            dalsession.Commit();

                            MessageBox.Show(this.FindForm(), "Record Deleted Successfully.", "Delete...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.Hide();
                            Form_NeedToRefresh();
                        }
                        catch (Exception ex)
                        {
                            if (dalsession != null)
                            {
                                dalsession.Rollback();
                            }
                            MessageBox.Show(this.FindForm(), "Something Goes Wrong \r\n" + ex.Message, "Could Not Update...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            SetFocus();
                            return;
                        }
                        break;

                    case BtnEvent.Print:
                        this.Hide();
                        Form_NeedToRefresh();
                        break;
                }
            }
        }

        #endregion[Save Event]

        #region[Collect Data]

        private MasterTablePath CollectData()
        {
            MasterTablePath fobj = new MasterTablePath()
            {
                Masterpath_id = vId,
                Mastertables_id = CMtables_exten.GetId_Name(txt_mtables_id.Text),
                Root_folder = txt_root_folder.Text,
                Contfolder = txt_contfolder.Text,
                Classfolder = txt_classfolder.Text,
                Formfolder = txt_formfolder.Text,
                Listfolder = txt_listfolder.Text,
                Setupfolder = txt_setupfolder.Text,
                Testfolder = txt_testfolder.Text,
                Active_id = Core.Stative,
            };
            return fobj;
        }

        #endregion[CollectData]

        #region[Validation]

        private bool Validation()
        {
            if (Core.Stative == Core.Idle)
            {
                MessageBox.Show(this.FindForm(), "Select Active or not !", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btn_active.Focus();
                return false;
            }

            return true;
        }

        #endregion[Validation]

    }//cls 
}//ns 
