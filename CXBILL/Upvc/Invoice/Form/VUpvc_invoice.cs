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
namespace CXBILL
{ 
    public partial class FUpvc_invoice : UserControl 
    { 
        #region[Action]

        private BtnEvent fAction = BtnEvent.Open;
        private Upvc_invoice obj;
        private List<Upvc_invoiceitems> list;
        private string vId;

        public void SetAction(BtnEvent pAction, string pPkValue)
        {
            fAction = pAction;
           
            switch (fAction)
            {
                case BtnEvent.Open:
                    btn_save.Text = "&CLOSE";
                    obj = CUpvc_invoice_exten.PKId(pPkValue, new DAL());
                    list = CUpvc_invoiceitems_exten.FKId(pPkValue, new DAL());
                    this.EnableControls(false);
                    break;
                case BtnEvent.New:
                    btn_save.Text = "&SAVE";
                    obj = CUpvc_invoice.GetNew();
                    list = new List<Upvc_invoiceitems>();
                    this.EnableControls(true);
                    break;
                case BtnEvent.Edit:
                    btn_save.Text = "&UPDATE";
                    obj = CUpvc_invoice_exten.PKId(pPkValue, new DAL());
                    list = CUpvc_invoiceitems_exten.FKId(pPkValue, new DAL());
                    this.EnableControls(true);
                    break;
                case BtnEvent.Delete:
                    btn_save.Text = "CONFIRM\r\n&DELETE";
                    obj = CUpvc_invoice_exten.PKId(pPkValue, new DAL());
                    list = CUpvc_invoiceitems_exten.FKId(pPkValue, new DAL());
                    this.EnableControls(false);
                    break;
                case BtnEvent.Print:
                    btn_save.Text = "&PRINT";
                    obj = CUpvc_invoice_exten.PKId(pPkValue, new DAL());
                    list = CUpvc_invoiceitems_exten.FKId(pPkValue, new DAL());
                    this.EnableControls(false);
                    print_panel.Show();
                    break;
            }
           
            LoadData(obj);
            Loaditems(list);
        }

        #endregion[Action]

        #region[Load Data]

        private void LoadData(Upvc_invoice obj)
        {
            vId = obj.Upvc_invoice_id;
            Core.TaxType = obj.Taxtype_id;
            SetTaxtype();

            txt_taxtype_id.Text = obj.Taxtype_id;
            txt_salestype_id.Text = obj.Salestype_id;
            txt_invoice_no.Text = obj.Invoice_no;
            txt_invoice_date.Text = obj.Invoice_date;
            txt_party_id.Text = obj.Party_id;
            txt_Delivered_id.Text = CParty_exten.GetName_Id(obj.Delivered_id);
            txt_transport_id.Text = obj.Transport_id;
            txt_vehicle_no.Text = obj.Vehicle_no;
            txt_total_qty.Text = obj.Total_qty.ToString();
            txt_gsttotal.Text = obj.Gsttotal.ToString();
            txt_ledger_id.Text = obj.Ledger_id;
            txt_additional.Text = obj.Additional.ToString();
            txt_grandtotal.Text = obj.Grandtotal.ToString();
            txt_notes.Text = obj.Notes;
            Core.Stative = obj.Active_id;
            Setactives();
        }

        #endregion[Load Data]

        #region[load items] 

        public void Loaditems(List<Upvc_invoiceitems> list) 
        {
            editgrid.SuspendLayout();
            
            if(list != null)
            {
                editgrid.RowCount = 0;
                editgrid.RowCount = list.Count; 
                for (int r = 0; r < list.Count; r++) 
                { 
                    DataGridViewRow row = editgrid.Rows[r]; 
 
                    row.Cells[UPVC_INVOICEITEMS.UPVC_INVOICEITEMS_ID].Value = (list[r].Upvc_invoiceitems_id) + ""; 
                    row.Cells[UPVC_INVOICEITEMS.UPVC_INVOICE_ID].Value = (list[r].Upvc_invoice_id) + ""; 
                    row.Cells[UPVC_INVOICEITEMS.PRODUCT_ID].Value = (list[r].Product_id) + ""; 
                    row.Cells[UPVC_INVOICEITEMS.WIDTHS].Value = (list[r].Widths) + ""; 
                    row.Cells[UPVC_INVOICEITEMS.HEIGHTS].Value = (list[r].Heights) + ""; 
                    row.Cells[UPVC_INVOICEITEMS.AREASQ].Value = (list[r].Areasq) + ""; 
                    row.Cells[UPVC_INVOICEITEMS.QTY].Value = (list[r].Qty) + ""; 
                    row.Cells[UPVC_INVOICEITEMS.PRICE].Value = (list[r].Price) + ""; 
                    row.Cells[UPVC_INVOICEITEMS.SGST_PERCENT].Value = (list[r].Sgst_percent) + ""; 
                    row.Cells[UPVC_INVOICEITEMS.CGST_PERCENT].Value = (list[r].Cgst_percent) + ""; 
                    row.Cells[UPVC_INVOICEITEMS.IGST_PERCENT].Value = (list[r].Igst_percent) + ""; 
                } 
            }
            editgrid.ResumeLayout(true);
            editgrid.Refresh();
        } 

        #endregion[load items] 

        #region[Enable  Disable Controls]

        private void EnableControls(bool pEnabled)
        {
            bool pReadOnly = !pEnabled;
           
            txt_taxtype_id.Enabled = !pReadOnly;
            txt_invoice_no.Enabled = !pReadOnly;
            txt_invoice_date.Enabled = !pReadOnly;
            txt_party_id.Enabled = !pReadOnly;
            txt_Delivered_id.Enabled = !pReadOnly;
            txt_transport_id.Enabled = !pReadOnly;
            txt_vehicle_no.Enabled = !pReadOnly;
            txt_total_qty.Enabled = !pReadOnly;
            txt_gsttotal.Enabled = !pReadOnly;
            txt_ledger_id.Enabled = !pReadOnly;
            txt_additional.Enabled = !pReadOnly;
            txt_grandtotal.Enabled = !pReadOnly;
            txt_notes.Enabled = !pReadOnly;

            editgrid.Enabled = !pReadOnly;
            txt_salestype_id.Enabled = !pReadOnly;
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
                                                 CUpvc_invoice.Insert(vData, dalsession); 
                                                 vId = DAL.GetIdentity(dalsession); 
                                                 var itemsList = Collectitems(vId); 
                                                 CUpvc_invoiceitems.Insert(itemsList, dalsession); 
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
                                                 CUpvc_invoiceitems.Delete(vId, dalsession); 
                                                 CUpvc_invoice.Update(vData, dalsession); 
                                                 var itemsList = Collectitems(vId); 
                                                 CUpvc_invoiceitems.Insert(itemsList, dalsession); 
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
                                                 CUpvc_invoiceitems.Delete(vId, dalsession); 
                                                 CUpvc_invoice.Delete(vId, dalsession); 
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

        private Upvc_invoice CollectData()
        {
            Upvc_invoice fobj = new Upvc_invoice()
           {
                Upvc_invoice_id = vId,
                Uniqueno = Current.Acy_id + "~" + Current.Company_id + "~" + txt_invoice_no.Text,
                Company_id =Current.Company_id,
                Acy_id = Current.Acy_id,
                Taxtype_id = CTaxtype_exten.GetId_Name(txt_taxtype_id.Text),
                Salestype_id = CSalestype_exten.GetId_Name(txt_salestype_id.Text),
                Invoice_no = txt_invoice_no.Text,
                Invoice_date = txt_invoice_date.Text,
                Party_id = CParty_exten.GetId_Name(txt_party_id.Text),
                Delivered_id = CParty_exten.GetId_Name(txt_Delivered_id.Text),
                Transport_id = CTransport_exten.GetId_Name(txt_transport_id.Text),
                Vehicle_no = txt_vehicle_no.Text,
                Total_qty = ConvertTO.Decimal(txt_total_qty.Text),
                Total_areasq = ConvertTO.Decimal(vTotAreasq.ToString()),
                Total_taxable_amount = ConvertTO.Decimal(vTotTaxable.ToString()),
                Total_cgst = ConvertTO.Decimal(vTotCgst.ToString()),
                Total_sgst = ConvertTO.Decimal(vTotSgst.ToString()),
                Total_igst = ConvertTO.Decimal(vTotIgst.ToString()),
                Gsttotal = ConvertTO.Decimal(txt_gsttotal.Text),
                Ledger_id = CLedger_exten.GetId_Name(txt_ledger_id.Text+""),
                Additional = ConvertTO.Decimal(txt_additional.Text),
                Rounds = ConvertTO.Decimal(vRoundoff.ToString()),
                Grandtotal = ConvertTO.Decimal(txt_grandtotal.Text),
                Refered_no = ConvertTO.Decimal(txt_grandtotal.Text),
                Locked = Core.Unlocked,
                Active_id = Core.Stative,
                Notes = txt_notes.Text,
                User_id = Current.User
            };
            return fobj;
        }

        #endregion[CollectData]

        #region[Collect items] 

        private List<Upvc_invoiceitems> Collectitems(string vId) 
        { 

            List<Upvc_invoiceitems> list = new List<Upvc_invoiceitems>(); 

            for (int r = 0; r < editgrid.RowCount; r++) 
            { 

                Upvc_invoiceitems obj = new Upvc_invoiceitems(); 

                if ( 
               (editgrid[UPVC_INVOICEITEMS.PRODUCT_ID, r].Value + "") == "" || 
                (editgrid[UPVC_INVOICEITEMS.QTY, r].Value + "") == "" || 
                (editgrid[UPVC_INVOICEITEMS.PRICE, r].Value + "") == "" 
                ) 
                { 
                    //==LEAVE IT(the empty row).  
                } 
                else 
                { 
                    obj.Upvc_invoiceitems_id = ""; 
                    obj.Upvc_invoice_id = vId; 
                    obj.Product_id = CProduct_exten.GetId_Name(editgrid[UPVC_INVOICEITEMS.PRODUCT_ID, r].Value + "");
                    obj.Widths = (editgrid[UPVC_INVOICEITEMS.WIDTHS, r].Value + ""); 
                    obj.Heights = (editgrid[UPVC_INVOICEITEMS.HEIGHTS, r].Value + ""); 
                    obj.Areasq = (editgrid[UPVC_INVOICEITEMS.AREASQ, r].Value + ""); 
                    obj.Qty = (editgrid[UPVC_INVOICEITEMS.QTY, r].Value + ""); 
                    obj.Price = (editgrid[UPVC_INVOICEITEMS.PRICE, r].Value + ""); 
                    obj.Sgst_percent = (editgrid[UPVC_INVOICEITEMS.SGST_PERCENT, r].Value + "0"); 
                    obj.Cgst_percent = (editgrid[UPVC_INVOICEITEMS.CGST_PERCENT, r].Value + "0"); 
                    obj.Igst_percent = (editgrid[UPVC_INVOICEITEMS.IGST_PERCENT, r].Value + "0"); 
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
            if (txt_invoice_no.Text.Trim().Length == 0)
            {
                MessageBox.Show(this.FindForm(), " Invoice no should not Empty ! ", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_invoice_no.Focus();
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
