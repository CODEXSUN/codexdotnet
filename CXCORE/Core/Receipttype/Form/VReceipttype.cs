// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:07:41 AM

using System;
using System.Windows.Forms;
using CXLIB;

namespace CXCORE
{
    public partial class FReceipttype : UserControl
    {
        #region[Action]

        private BtnEvent fAction = BtnEvent.Open;
        private Receipttype obj;
        private string vId;

        public void SetAction(BtnEvent pAction, string pPkValue)
        {
            fAction = pAction;

            switch (fAction)
            {
                case BtnEvent.Open:
                    btn_save.Text = "&CLOSE";
                    obj = CReceipttype_exten.PKId(pPkValue, new DAL());
                    this.EnableControls(false);
                    break;
                case BtnEvent.New:
                    btn_save.Text = "&SAVE";
                    obj = CReceipttype.GetNew;
                    this.EnableControls(true);
                    break;
                case BtnEvent.Edit:
                    btn_save.Text = "&UPDATE";
                    obj = CReceipttype_exten.PKId(pPkValue, new DAL());
                    this.EnableControls(true);
                    break;
                case BtnEvent.Delete:
                    btn_save.Text = "CONFIRM\r\n&DELETE";
                    obj = CReceipttype_exten.PKId(pPkValue, new DAL());
                    this.EnableControls(false);
                    break;
                case BtnEvent.Print:
                    btn_save.Text = "&PRINT";
                    obj = CReceipttype_exten.PKId(pPkValue, new DAL());
                    this.EnableControls(false);
                    break;
            }

            this.LoadData();
        }

        #endregion[Action]

        #region[Load Data]

        private void LoadData()
        {
            vId = obj.Receipttype_id;
            txt_receipttype_name.Text = obj.Receipttype_name;
            txt_notes.Text = obj.Notes;
            Core.Stative = obj.Active_id;
            Setactives();
        }

        #endregion[Load Data]

        #region[Enable  Disable Controls]

        private void EnableControls(bool pEnabled)
        {
            bool pReadOnly = !pEnabled;

            txt_receipttype_name.Enabled = !pReadOnly;
            txt_notes.Enabled = !pReadOnly;

            btn_active.Enabled = !pReadOnly;

        }

        #endregion[Enable  Disable Controls]

        #region[Save Event]

        private DAL dalsession;
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

                            dalsession = new DAL();
                            dalsession.BeginTransaction();
                            CReceipttype.Insert(vData, dalsession);
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

                            dalsession = new DAL();
                            dalsession.BeginTransaction();
                            CReceipttype.Update(vData, dalsession);
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
                            dalsession = new DAL();
                            dalsession.BeginTransaction();
                            CReceipttype.Delete(vId, dalsession);
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

        private Receipttype CollectData()
        {
            Receipttype fobj = new Receipttype()
            {
                Receipttype_id = vId,
                Receipttype_name = txt_receipttype_name.Text,
                Active_id = Core.Stative,
                Notes = txt_notes.Text,
                User_id = Current.User
            };
            return fobj;
        }

        #endregion[CollectData]

        #region[Validation]

        private bool Validation()
        {
            if (txt_receipttype_name.Text.Trim().Length == 0)
            {
                MessageBox.Show(this.FindForm(), "Receipttype name should not Empty ! ", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_receipttype_name.Focus();
                return false;
            }

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
