// Version : 4.0.0.2 Date : 10-08-2020
// Auto Generated
// last update : 25-01-2021 10:14:36 AM

using System; 
using System.Windows.Forms; 
using CXLIB; 
 
namespace CXERP
{ 
    public partial class FPo
    { 
        #region[Action]

        private BtnEvent fAction = BtnEvent.Open;
        private Po obj;
        private string vId;

        public void SetAction(BtnEvent action, string pk)
        {
            fAction = action;
           
            switch (fAction)
            {
                case BtnEvent.Open:
                    btn_save.Text = "&CLOSE";
                    obj = CPo_exten.PKId(pk);
                    this.EnableControls(false);
                    break;
                case BtnEvent.New:
                    btn_save.Text = "&SAVE";
                    obj = CPo.GetNew;
                    this.EnableControls(true);
                    break;
                case BtnEvent.Edit:
                    btn_save.Text = "&UPDATE";
                    obj = CPo_exten.PKId(pk);
                    this.EnableControls(true);
                    break;
                case BtnEvent.Delete:
                    btn_save.Text = "CONFIRM\r\n&DELETE";
                    obj = CPo_exten.PKId(pk);
                    this.EnableControls(false);
                    break;
                case BtnEvent.Print:
                    btn_save.Text = "&PRINT";
                    obj = CPo_exten.PKId(pk);
                    this.EnableControls(false);
                    break;
            }
           
            this.LoadData();
        }

        #endregion[Action]

        #region[Load Data]

        private void LoadData()
        {
            vId = obj.Po_id;
            txt_po_no.Text = obj.Po_no;
            txt_po_date.Text = obj.Po_date;
            txt_delivery_date.Text = obj.Delivery_date;
            txt_notes.Text = obj.Notes;
            Core.Stative = obj.Active_id;
            Setactives();
        }

        #endregion[Load Data]

        #region[Enable  Disable Controls]

        private void EnableControls(bool pEnabled)
        {
            bool pReadOnly = !pEnabled;
           
            txt_po_no.Enabled = !pReadOnly;
            txt_po_date.Enabled = !pReadOnly;
            txt_delivery_date.Enabled = !pReadOnly;
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
                                                 CPo.Insert(vData, dalsession); 
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
                                                 CPo.Update(vData, dalsession); 
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
                                                 CPo.Delete(vId, dalsession); 
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

        private Po CollectData()
        {
            Po fobj = new Po()
           {
                Po_id = vId,
                Po_no = txt_po_no.Text,
                Po_date = txt_po_date.Text,
                Delivery_date = txt_delivery_date.Text,
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
            if (txt_po_no.Text.Trim().Length == 0)
            {
                MessageBox.Show(this.FindForm(), "Po no should not Empty ! ", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_po_no.Focus();
                return false;
            }
           
            if (txt_po_date.Text.Trim().Length == 0)
            {
                MessageBox.Show(this.FindForm(), "Po date should not Empty ! ", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_po_date.Focus();
                return false;
            }
           
            if (txt_delivery_date.Text.Trim().Length == 0)
            {
                MessageBox.Show(this.FindForm(), "Delivery date should not Empty ! ", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_delivery_date.Focus();
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
