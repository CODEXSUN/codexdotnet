// Version : 4.0.0.2 Date : 10-08-2020
// Auto Generated
// last update : 23-01-2021 08:38:55 PM

using System; 
using System.Windows.Forms;
using CXCORE;
using CXLIB; 
 
namespace CXERP
{ 
    public partial class FArticle
    { 
        #region[Action]

        private BtnEvent fAction = BtnEvent.Open;
        private Article obj;
        private string vId;

        public void SetAction(BtnEvent action, string pk)
        {
            fAction = action;
           
            switch (fAction)
            {
                case BtnEvent.Open:
                    btn_save.Text = "&CLOSE";
                    obj = CArticle_exten.PKId(pk);
                    this.EnableControls(false);
                    break;
                case BtnEvent.New:
                    btn_save.Text = "&SAVE";
                    obj = CArticle.GetNew;
                    this.EnableControls(true);
                    break;
                case BtnEvent.Edit:
                    btn_save.Text = "&UPDATE";
                    obj = CArticle_exten.PKId(pk);
                    this.EnableControls(true);
                    break;
                case BtnEvent.Delete:
                    btn_save.Text = "CONFIRM\r\n&DELETE";
                    obj = CArticle_exten.PKId(pk);
                    this.EnableControls(false);
                    break;
                case BtnEvent.Print:
                    btn_save.Text = "&PRINT";
                    obj = CArticle_exten.PKId(pk);
                    this.EnableControls(false);
                    break;
            }
           
            this.LoadData();
        }

        #endregion[Action]

        #region[Load Data]

        private void LoadData()
        {
            vId = obj.Article_id;
            txt_po_id.Text = obj.Po_id;
            txt_article_no.Text = obj.Article_no;
            txt_product_id.Text = obj.Product_id;
            txt_hsncode_id.Text = obj.Hsncode_id;
            txt_size_id.Text = obj.Size_id;
            txt_colour_id.Text = obj.Colour_id;
            txt_qty.Text = obj.Qty;
            txt_price.Text = obj.Price.ToString();
            txt_barcode.Text = obj.Barcode;
            txt_notes.Text = obj.Notes;
            Core.Stative = obj.Active_id;
            Setactives();
        }

        #endregion[Load Data]

        #region[Enable  Disable Controls]

        private void EnableControls(bool pEnabled)
        {
            bool pReadOnly = !pEnabled;
           
            txt_po_id.Enabled = !pReadOnly;
            txt_article_no.Enabled = !pReadOnly;
            txt_product_id.Enabled = !pReadOnly;
            txt_hsncode_id.Enabled = !pReadOnly;
            txt_size_id.Enabled = !pReadOnly;
            txt_colour_id.Enabled = !pReadOnly;
            txt_qty.Enabled = !pReadOnly;
            txt_price.Enabled = !pReadOnly;
            txt_barcode.Enabled = !pReadOnly;
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
                                                 CArticle.Insert(vData, dalsession); 
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
                                                 CArticle.Update(vData, dalsession); 
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
                                                 CArticle.Delete(vId, dalsession); 
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

        private Article CollectData()
        {
            Article fobj = new Article()
           {
                Article_id = vId,
                Po_id = txt_po_id.Text,
                Article_no = txt_article_no.Text,
                Product_id = txt_product_id.Text,
                Hsncode_id = CHsncode_exten.GetId_Name(txt_hsncode_id.Text),
                Size_id = CSizes_exten.GetId_Name(txt_size_id.Text),
                Colour_id = CColours_exten.GetId_Name(txt_colour_id.Text),
                Qty = txt_qty.Text,
                Price = ConvertTO.Decimal(txt_price.Text),
                Barcode = txt_barcode.Text,
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
