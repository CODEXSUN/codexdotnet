// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 13-07-2020 08:01:31 AM

using System; 
using System.Windows.Forms; 
using CXLIB; 
 
namespace CXCORE
{ 
    public partial class FShipping : UserControl 
    { 
        #region[Action]

        private BtnEvent fAction = BtnEvent.Open;
        private Shipping obj;
        private string vId;

        public void SetAction(BtnEvent action, string pk)
        {
            fAction = action;
           
            switch (fAction)
            {
                case BtnEvent.Open:
                    btn_save.Text = "&CLOSE";
                    obj = CShipping_exten.PKId(pk);
                    this.EnableControls(false);
                    break;
                case BtnEvent.New:
                    btn_save.Text = "&SAVE";
                    obj = CShipping.GetNew;
                    this.EnableControls(true);
                    break;
                case BtnEvent.Edit:
                    btn_save.Text = "&UPDATE";
                    obj = CShipping_exten.PKId(pk);
                    this.EnableControls(true);
                    break;
                case BtnEvent.Delete:
                    btn_save.Text = "CONFIRM\r\n&DELETE";
                    obj = CShipping_exten.PKId(pk);
                    this.EnableControls(false);
                    break;
                case BtnEvent.Print:
                    btn_save.Text = "&PRINT";
                    obj = CShipping_exten.PKId(pk);
                    this.EnableControls(false);
                    break;
            }
           
            this.LoadData();
        }

        #endregion[Action]

        #region[Load Data]

        private void LoadData()
        {
            vId = obj.Shipping_id;
            txt_shipping_name.Text = obj.Shipping_name;
            txt_notes.Text = obj.Notes;
            Core.Stative = obj.Active_id;
            Setactives();
        }

        #endregion[Load Data]

        #region[Enable  Disable Controls]

        private void EnableControls(bool pEnabled)
        {
            bool pReadOnly = !pEnabled;
           
            txt_shipping_name.Enabled = !pReadOnly;
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
                                                 CShipping.Insert(vData, dalsession); 
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
                                                 CShipping.Update(vData, dalsession); 
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
                                                 CShipping.Delete(vId, dalsession); 
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

        private Shipping CollectData()
        {
            Shipping fobj = new Shipping()
           {
                Shipping_id = vId,
                Shipping_name = txt_shipping_name.Text,
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
            if (txt_shipping_name.Text.Trim().Length == 0)
            {
                MessageBox.Show(this.FindForm(), "Shipping name should not Empty ! ", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_shipping_name.Focus();
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
