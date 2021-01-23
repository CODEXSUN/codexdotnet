// Version : 3 dt : 01-08-2017
// Auto Generated
// 23-08-2017 10:05:48 AM
// last update : 23-08-2017

using System; 
using System.Collections.Generic; 
using System.Windows.Forms; 
using CXLIB; 
using CXCORE; 
 
//  
namespace CXUPVC
{ 
    public partial class FUpvc_quotation : UserControl 
    { 
        #region[Action]

        private BtnEvent fAction = BtnEvent.Open;
        private Upvc_quotation obj;
        private List<Upvc_quotationitems> list;
        private string vId;

        public void SetAction(BtnEvent pAction, string pPkValue)
        {
            fAction = pAction;
           
            switch (fAction)
            {
                case BtnEvent.Open:
                    btn_save.Text = "&CLOSE";
                    obj = CUpvc_quotation_exten.PKId(pPkValue, new DAL());
                    list = CUpvc_quotationitems_exten.FKId(pPkValue, new DAL());
                    this.EnableControls(false);
                    break;
                case BtnEvent.New:
                    btn_save.Text = "&SAVE";
                    obj = Upvc_quotation.GetNew();
                    list = new List<Upvc_quotationitems>();
                    this.EnableControls(true);
                    break;
                case BtnEvent.Edit:
                    btn_save.Text = "&UPDATE";
                    obj = CUpvc_quotation_exten.PKId(pPkValue, new DAL());
                    list = CUpvc_quotationitems_exten.FKId(pPkValue, new DAL());
                    this.EnableControls(true);
                    break;
                case BtnEvent.Delete:
                    btn_save.Text = "CONFIRM\r\n&DELETE";
                    obj = CUpvc_quotation_exten.PKId(pPkValue, new DAL());
                    list = CUpvc_quotationitems_exten.FKId(pPkValue, new DAL());
                    this.EnableControls(false);
                    break;
                case BtnEvent.Print:
                    btn_save.Text = "&PRINT";
                    obj = CUpvc_quotation_exten.PKId(pPkValue, new DAL());
                    list = CUpvc_quotationitems_exten.FKId(pPkValue, new DAL());
                    this.EnableControls(false);
                    print_panel.Show();
                    break;
            }
           
            LoadData(obj);
            Loaditems(list);
        }

        #endregion[Action]

        #region[Load Data]

        private void LoadData(Upvc_quotation obj)
        {
            vId = obj.Upvc_quotation_id;
            Core.TaxType = obj.Salestype;
            SetSalestype();

            txt_upvc_salesmode_id.Text = obj.Upvc_salesmode_id;
            txt_upvc_quotation_no.Text = obj.Upvc_quotation_no;
            txt_upvc_quotation_date.Text = obj.Upvc_quotation_date;
            txt_party_id.Text = obj.Party_id;
            txt_shipping_id.Text = CParty_exten.GetName_Id(obj.Shipping_id);
            //txt_transport_mode_id.Text = obj.Transport_mode_id;
            //txt_vehicle_no.Text = obj.Vehicle_no;
            txt_total_qty.Text = obj.Total_qty;
            txt_gsttotal.Text = obj.Gsttotal;
            txt_ledger_id.Text = obj.Ledger_id;
            txt_additional.Text = obj.Additional;
            txt_grandtotal.Text = obj.Grandtotal;
            txt_notes.Text = obj.Notes;
            Core.Stative = obj.Active_id;
            Setactives();
        }

        #endregion[Load Data]

        #region[load items] 

        public void Loaditems(List<Upvc_quotationitems> list) 
        { 
            editgrid.RowCount = 0; 
            if(list != null)
            { 
                editgrid.RowCount = list.Count; 
                for (int r = 0; r < list.Count; r++) 
                { 
                    DataGridViewRow row = editgrid.Rows[r]; 
 
                    row.Cells[UPVC_QUOTATIONITEMS.UPVC_QUOTATIONITEMS_ID].Value = (list[r].Upvc_quotationitems_id) + ""; 
                    row.Cells[UPVC_QUOTATIONITEMS.UPVC_QUOTATION_ID].Value = (list[r].Upvc_quotation_id) + ""; 
                    row.Cells[UPVC_QUOTATIONITEMS.PRODUCT_ID].Value = (list[r].Product_id) + ""; 
                    row.Cells[UPVC_QUOTATIONITEMS.WIDTHS].Value = (list[r].Widths) + ""; 
                    row.Cells[UPVC_QUOTATIONITEMS.HEIGHTS].Value = (list[r].Heights) + ""; 
                    row.Cells[UPVC_QUOTATIONITEMS.AREASQ].Value = (list[r].Areasq) + ""; 
                    row.Cells[UPVC_QUOTATIONITEMS.QTY].Value = (list[r].Qty) + ""; 
                    row.Cells[UPVC_QUOTATIONITEMS.PRICE].Value = (list[r].Price) + ""; 
                    row.Cells[UPVC_QUOTATIONITEMS.SGST_PERCENT].Value = (list[r].Sgst_percent) + ""; 
                    row.Cells[UPVC_QUOTATIONITEMS.CGST_PERCENT].Value = (list[r].Cgst_percent) + ""; 
                    row.Cells[UPVC_QUOTATIONITEMS.IGST_PERCENT].Value = (list[r].Igst_percent) + ""; 
                } 
            } 
        } 

        #endregion[load items] 

        #region[Enable  Disable Controls]

        private void EnableControls(bool pEnabled)
        {
            bool pReadOnly = !pEnabled;
           
            txt_upvc_salesmode_id.Enabled = !pReadOnly;
            txt_upvc_quotation_no.Enabled = !pReadOnly;
            txt_upvc_quotation_date.Enabled = !pReadOnly;
            txt_party_id.Enabled = !pReadOnly;
            txt_shipping_id.Enabled = !pReadOnly;
            //txt_transport_mode_id.Enabled = !pReadOnly;
            //txt_vehicle_no.Enabled = !pReadOnly;
            txt_total_qty.Enabled = !pReadOnly;
            txt_gsttotal.Enabled = !pReadOnly;
            txt_ledger_id.Enabled = !pReadOnly;
            txt_additional.Enabled = !pReadOnly;
            txt_grandtotal.Enabled = !pReadOnly;
            txt_notes.Enabled = !pReadOnly;

            editgrid.Enabled = !pReadOnly;
            btn_salestype.Enabled = !pReadOnly;
            btn_active.Enabled = !pReadOnly;
            print_panel.Hide();

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
                                                 CUpvc_quotation.Insert(vData, dalsession); 
                                                 vId = DAL.GetIdentity(dalsession); 
                                                 var itemsList = Collectitems(vId); 
                                                 CUpvc_quotationitems.Insert(itemsList, dalsession); 
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
                                                 CUpvc_quotationitems.Delete(vId, dalsession); 
                                                 CUpvc_quotation.Update(vData, dalsession); 
                                                 var itemsList = Collectitems(vId); 
                                                 CUpvc_quotationitems.Insert(itemsList, dalsession); 
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
                                                 CUpvc_quotationitems.Delete(vId, dalsession); 
                                                 CUpvc_quotation.Delete(vId, dalsession); 
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
                        Print_copies();
                        this.Hide();
                        Form_NeedToRefresh();
                        break;
                }
            }
        }

        #endregion[Save Event]

        #region[Collect Data]

        private Upvc_quotation CollectData()
        {
            Upvc_quotation fobj = new Upvc_quotation()
           {
                Upvc_quotation_id = vId,
                Uniqueno =Current.Acy_id + "~" + Current.Company_id + "~" + txt_upvc_quotation_no.Text,
                Company_id =Current.Company_id,
                Salestype = Core.TaxType,
                Upvc_salesmode_id = CUpvc_salesmode_exten.GetId_Name(txt_upvc_salesmode_id.Text),
                Upvc_quotation_no = txt_upvc_quotation_no.Text,
                Upvc_quotation_date = txt_upvc_quotation_date.Text,
                Party_id = CParty_exten.GetId_Name(txt_party_id.Text),
                Shipping_id = CParty_exten.GetId_Name(txt_shipping_id.Text),
                //Transport_mode_id = CTransport_mode_exten.GetId_Name(txt_transport_mode_id.Text),
                //Vehicle_no = txt_vehicle_no.Text,
                Total_qty = txt_total_qty.Text,
                Total_areasq = vTotAreasq.ToString(),
                Total_taxable_amount = vTotTaxable.ToString(),
                Total_cgst = vTotCgst.ToString(),
                Total_sgst = vTotSgst.ToString(),
                Total_igst = vTotIgst.ToString(),
                Gsttotal = txt_gsttotal.Text,
                Ledger_id = txt_ledger_id.Text,
                Additional = txt_additional.Text,
                Rounds = vRoundoff.ToString(),
                Grandtotal = txt_grandtotal.Text,
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

        private List<Upvc_quotationitems> Collectitems(string vId) 
        { 

            List<Upvc_quotationitems> list = new List<Upvc_quotationitems>(); 

            for (int r = 0; r < editgrid.RowCount; r++) 
            { 

                Upvc_quotationitems obj = new Upvc_quotationitems(); 

                if ( 
               (editgrid[UPVC_QUOTATIONITEMS.PRODUCT_ID, r].Value + "") == "" || 
                (editgrid[UPVC_QUOTATIONITEMS.QTY, r].Value + "") == "" || 
                (editgrid[UPVC_QUOTATIONITEMS.PRICE, r].Value + "") == "" 
                ) 
                { 
                    //==LEAVE IT(the empty row).  
                } 
                else 
                { 
                    obj.Upvc_quotationitems_id = ""; 
                    obj.Upvc_quotation_id = vId; 
                    obj.Product_id = CProduct_exten.GetId_Name(editgrid[UPVC_QUOTATIONITEMS.PRODUCT_ID, r].Value + "");
                    obj.Widths = (editgrid[UPVC_QUOTATIONITEMS.WIDTHS, r].Value + ""); 
                    obj.Heights = (editgrid[UPVC_QUOTATIONITEMS.HEIGHTS, r].Value + ""); 
                    obj.Areasq = (editgrid[UPVC_QUOTATIONITEMS.AREASQ, r].Value + ""); 
                    obj.Qty = (editgrid[UPVC_QUOTATIONITEMS.QTY, r].Value + ""); 
                    obj.Price = (editgrid[UPVC_QUOTATIONITEMS.PRICE, r].Value + ""); 
                    obj.Sgst_percent = (editgrid[UPVC_QUOTATIONITEMS.SGST_PERCENT, r].Value + ""); 
                    obj.Cgst_percent = (editgrid[UPVC_QUOTATIONITEMS.CGST_PERCENT, r].Value + ""); 
                    obj.Igst_percent = (editgrid[UPVC_QUOTATIONITEMS.IGST_PERCENT, r].Value + ""); 
                    obj.Refered_id = ""; 
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
            if (txt_upvc_quotation_no.Text.Trim().Length == 0)
            {
                MessageBox.Show(this.FindForm(), " Quotation no should not Empty ! ", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_upvc_quotation_no.Focus();
                return false;
            }

            if (txt_party_id.Text.Trim().Length == 0)
            {
                MessageBox.Show(this.FindForm(), " Party Name should not Empty ! ", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_party_id.Focus();
                return false;
            }

            if (Core.Stative == Core.Idle)
            {
                MessageBox.Show(this.FindForm(), " Select Active or not !", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btn_active.Focus();
                return false;
            }
           
            return true;
        }

        #endregion[Validation]

}//cls 
}//ns 
