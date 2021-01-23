// Version : 1 dt : 11-07-2017
// CODESK
// 13-07-2017 10:42:25 PM
// create date : 13-07-2017
// last update : 13-07-2017

using System; 
using System.ComponentModel; 
using System.Collections.Generic; 
using System.Drawing; 
using System.Windows.Forms; 
using CXLIB; 
 
//  
namespace AXCODE
{ 
    public partial class FUser : UserControl 
    { 
        #region[Action]

        private BtnEvent fAction = BtnEvent.Open;
        private User obj;
        private string vId;

        public void SetAction(BtnEvent pAction, string pPkValue)
        {
            fAction = pAction;
           
            switch (fAction)
            {
                case BtnEvent.Open:
                    btn_save.Text = "CLOSE";
                    obj = CUser.PropertiesData(CUser_exten.PKId(pPkValue));
                    this.EnableControls(false);
                    break;
                case BtnEvent.New:
                    btn_save.Text = "SAVE";
                    obj = new User();
                    this.EnableControls(true);
                    break;
                case BtnEvent.Edit:
                    btn_save.Text = "UPDATE";
                    obj = CUser.PropertiesData(CUser_exten.PKId(pPkValue));
                    this.EnableControls(true);
                    break;
                case BtnEvent.Delete:
                    btn_save.Text = "CONFIRM\r\nDELETE";
                    obj = CUser.PropertiesData(CUser_exten.PKId(pPkValue));
                    this.EnableControls(false);
                    break;
                case BtnEvent.Print:
                    btn_save.Text = "PRINT";
                    obj = CUser.PropertiesData(CUser_exten.PKId(pPkValue));
                    this.EnableControls(false);
                    break;
            }
           
            this.LoadData();
        }

        #endregion[Action]

        #region[Load Data]

        private void LoadData()
        {
            vId = obj.User_id;
            txt_user_name.Text = obj.User_name;
            txt_user_password.Text = obj.User_password;
            txt_createon.Text = obj.Createon;
            txt_entryby.Text = obj.Entryby;
            txt_notes.Text =obj.Notes;
            Core.Stative = obj.Active_id;
            Setactives();
        }

        #endregion[Load Data]

        #region[Enable  Disable Controls]

        private void EnableControls(bool pEnabled)
        {
            bool pReadOnly = !pEnabled;
           
            txt_user_name.Enabled = !pReadOnly;
            txt_user_password.Enabled = !pReadOnly;
            txt_createon.Enabled = !pReadOnly;
            txt_entryby.Enabled = !pReadOnly;
            txt_notes.Enabled = !pReadOnly;
           
            btn_active.Enabled = !pReadOnly;
            btn_not_active.Enabled = !pReadOnly;
           
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
                                                 var vData = FetchData(); 
 
                                                 dalsession = new DAL(); 
                                                 dalsession.BeginTransaction(); 
                                                 CUser.Insert(vData, dalsession); 
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
                                                 var vData = FetchData(); 
 
                                                 dalsession = new DAL(); 
                                                 dalsession.BeginTransaction(); 
                                                 CUser.Update(vData, dalsession); 
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
                                                 CUser.Delete(vId, dalsession); 
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

        #region[Fetch Data]

        private User FetchData()
        {
            User fobj = new User()
           {
           User_id = vId,
            User_name = txt_user_name.Text,
            User_password = txt_user_password.Text,
            Createon = txt_createon.Text,
            Entryby = txt_entryby.Text,
            Notes = txt_notes.Text,
            Active_id =Core.Stative
            };
            return fobj;
        }

        #endregion[Fetch Data]

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
