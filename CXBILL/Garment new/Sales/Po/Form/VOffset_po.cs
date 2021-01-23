// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 22-11-2017 12:14:05 PM

using System; 
using System.Collections.Generic; 
using System.Windows.Forms; 
using CXLIB; 
using CXCORE; 
 
//  
namespace CXBILL
{ 
    public partial class FOffset_Po : UserControl 
    { 
        #region[Action]

        private BtnEvent fAction = BtnEvent.Open;
        private Offset_po obj;
        private List<Offset_poitems> list;
        private string vId;

        public void SetAction(BtnEvent pAction, string pPkValue)
        {
            fAction = pAction;
           
            switch (fAction)
            {
                case BtnEvent.Open:
                    btn_save.Text = "&CLOSE";
                    obj = COffset_po_exten.PKId(pPkValue, new DAL());
                    list = COffset_Poitems_exten.FKId(pPkValue, new DAL());
                    this.EnableControls(false);
                    break;
                case BtnEvent.New:
                    btn_save.Text = "&SAVE";
                    obj = COffset_po.GetNew;
                    list = COffset_poitems.GetNew;
                    this.EnableControls(true);
                    break;
                case BtnEvent.Edit:
                    btn_save.Text = "&UPDATE";
                    obj = COffset_po_exten.PKId(pPkValue, new DAL());
                    list = COffset_Poitems_exten.FKId(pPkValue, new DAL());
                    this.EnableControls(true);
                    break;
                case BtnEvent.Delete:
                    btn_save.Text = "CONFIRM\r\n&DELETE";
                    obj = COffset_po_exten.PKId(pPkValue, new DAL());
                    list = COffset_Poitems_exten.FKId(pPkValue, new DAL());
                    this.EnableControls(false);
                    break;
                case BtnEvent.Print:
                    btn_save.Text = "&PRINT";
                    obj = COffset_po_exten.PKId(pPkValue, new DAL());
                    list = COffset_Poitems_exten.FKId(pPkValue, new DAL());
                    this.EnableControls(false);
                    //print_panel.Show();
                    break;
            }
           
            LoadData(obj);
            Loaditems(list);
        }

        #endregion[Action]

        #region[Load Data]

        private void LoadData(Offset_po obj)
        {
            vId = obj.Offset_po_id;
            txt_po_no.Text = obj.Offset_po_no;
            txt_po_date.Text = obj.Offset_po_date;
            txt_party_id.Text = obj.Party_id;
            txt_party_po_ref.Text = obj.Party_po_ref;
            txt_delivery_date.Text = obj.Delivery_date;
            txt_total_qty.Text = obj.Total_qty;
            txt_total_amount.Text = obj.Total_amount;
            txt_notes.Text = obj.Notes;
            Core.Stative = obj.Active_id;
            Setactives();
        }

        #endregion[Load Data]

        #region[load items] 

        public void Loaditems(List<Offset_poitems> list) 
        { 
            editgrid.RowCount = 0; 
            if(list != null)
            { 
                editgrid.RowCount = list.Count; 
                for (int r = 0; r < list.Count; r++) 
                { 
                    DataGridViewRow row = editgrid.Rows[r]; 
 
                    row.Cells[OFFSET_POITEMS.OFFSET_POITEMS_ID].Value = (list[r].Offset_poitems_id) + ""; 
                    row.Cells[OFFSET_POITEMS.OFFSET_PO_ID].Value = (list[r].Offset_po_id) + ""; 
                    row.Cells[OFFSET_POITEMS.PRODUCT_ID].Value = Checks.RemoveEscape(list[r].Product_id) + ""; 
                    row.Cells[OFFSET_POITEMS.QTY].Value = (list[r].Qty) + ""; 
                    row.Cells[OFFSET_POITEMS.PRICE].Value = (list[r].Price) + ""; 
                    row.Cells[OFFSET_POITEMS.SUB_TOTAL].Value = (list[r].Sub_total) + ""; 
                } 
            } 
        } 

        #endregion[load items] 

        #region[Enable  Disable Controls]

        private void EnableControls(bool pEnabled)
        {
            bool pReadOnly = !pEnabled;
           
            txt_po_no.Enabled = !pReadOnly;
            txt_po_date.Enabled = !pReadOnly;
            txt_party_id.Enabled = !pReadOnly;
            txt_party_po_ref.Enabled = !pReadOnly;
            txt_delivery_date.Enabled = !pReadOnly;
            txt_total_qty.Enabled = !pReadOnly;
            txt_total_amount.Enabled = !pReadOnly;
            txt_notes.Enabled = !pReadOnly;
            editgrid.Enabled = !pReadOnly;
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
                                                 COffset_po.Insert(vData, dalsession); 
                                                 vId = DAL.GetIdentity(dalsession); 
                                                 var itemsList = Collectitems(vId); 
                                                 COffset_poitems.Insert(itemsList, dalsession); 
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
                                                 COffset_poitems.Delete(vId, dalsession); 
                                                 COffset_po.Update(vData, dalsession); 
                                                 var itemsList = Collectitems(vId); 
                                                 COffset_poitems.Insert(itemsList, dalsession); 
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
                                                 COffset_poitems.Delete(vId, dalsession); 
                                                 COffset_po.Delete(vId, dalsession); 
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

        private Offset_po CollectData()
        {
            Offset_po fobj = new Offset_po()
            {
                Offset_po_id = vId,
                Uniqueno = Current.Acy_id + "~" + Current.Company_id + "~" + txt_po_no.Text,
                Company_id = Current.Company_id,
                Acy_id = Current.Acy_id,
                Offset_po_no = txt_po_no.Text,
                Offset_po_date = txt_po_date.Text,
                Party_id = CParty_exten.GetId_Name(txt_party_id.Text),
                Party_po_ref = txt_party_po_ref.Text,
                Delivery_date = txt_delivery_date.Text,
                Total_qty = txt_total_qty.Text,
                Total_amount = txt_total_amount.Text,
                Refered_no ="",
                Locked =Core.Unlocked,
                Active_id = Core.Stative,
                Notes = txt_notes.Text,
                User_id = Current.User
            };
            return fobj;
        }

        #endregion[CollectData]

        #region[Collect items] 

        private List<Offset_poitems> Collectitems(string vId) 
        { 

            List<Offset_poitems> list = new List<Offset_poitems>(); 

            for (int r = 0; r < editgrid.RowCount; r++) 
            { 

                Offset_poitems obj = new Offset_poitems(); 

                if ( 
               (editgrid[OFFSET_POITEMS.PRODUCT_ID, r].Value + "") == "" || 
                (editgrid[OFFSET_POITEMS.QTY, r].Value + "") == "" || 
                (editgrid[OFFSET_POITEMS.PRICE, r].Value + "") == "" 
                ) 
                { 
                    //==LEAVE IT(the empty row).  
                } 
                else 
                { 
                    obj.Offset_poitems_id = ""; 
                    obj.Offset_po_id = vId; 
                    obj.Product_id = CProduct_exten.GetId_Name(Checks.RemoveEscape(editgrid[OFFSET_POITEMS.PRODUCT_ID, r].Value + ""));
                    obj.Qty = (editgrid[OFFSET_POITEMS.QTY, r].Value + ""); 
                    obj.Price = (editgrid[OFFSET_POITEMS.PRICE, r].Value + ""); 
                    obj.Sub_total = (editgrid[OFFSET_POITEMS.SUB_TOTAL, r].Value + ""); 
                    obj.Refered_qty = (editgrid[OFFSET_POITEMS.QTY, r].Value + "");
                    obj.Locked = Core.Unlocked; 

                    list.Add(obj); 
                } 

            } 

            if (list.Count != 0) 
            { 
                return list; 
            } 

            return null; 
        } 

        #endregion[Collect items] 

        #region[Validation]

        private bool Validation()
        {
            if (txt_po_no.Text.Trim().Length == 0)
            {
                MessageBox.Show(this.FindForm(), "Po no should not Empty ! ", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_po_no.Focus();
                return false;
            }
           
            if (txt_party_id.Text.Trim().Length == 0)
            {
                MessageBox.Show(this.FindForm(), "Party id should not Empty ! ", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_party_id.Focus();
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
