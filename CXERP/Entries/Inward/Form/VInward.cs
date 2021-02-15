// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 22-11-2017 12:14:05 PM 

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CXLIB;
using CXCORE;
using CXERP;

namespace CXERP
{
    public partial class FInward
    {
        #region[Action]

        private BtnEvent fAction = BtnEvent.Open;
        private Inward obj;
        private List<Inwarditems> list;
        private string vId;

        public void SetAction(BtnEvent pAction, string pPkValue)
        {
            fAction = pAction;

            switch (fAction)
            {
                case BtnEvent.Open:
                    btn_save.Text = "&CLOSE";
                    obj = CInward_exten.PKId(pPkValue);
                    list = CInwarditems_exten.FKId(pPkValue);
                    this.EnableControls(false);
                    break;
                case BtnEvent.New:
                    btn_save.Text = "&SAVE";
                    obj = CInward.GetNew;
                    list = CInwarditems.GetNew;
                    this.EnableControls(true);
                    break;
                case BtnEvent.Edit:
                    btn_save.Text = "&UPDATE";
                    obj = CInward_exten.PKId(pPkValue);
                    list = CInwarditems_exten.FKId(pPkValue);
                    this.EnableControls(true);
                    break;
                case BtnEvent.Delete:
                    btn_save.Text = "CONFIRM\r\n&DELETE";
                    obj = CInward_exten.PKId(pPkValue);
                    list = CInwarditems_exten.FKId(pPkValue);
                    this.EnableControls(false);
                    break;
                case BtnEvent.Print:
                    btn_save.Text = "&PRINT";
                    obj = CInward_exten.PKId(pPkValue);
                    list = CInwarditems_exten.FKId(pPkValue);
                    this.EnableControls(false);
                    print_panel.Show();
                    break;
            }

            LoadData(obj);
            Loaditems(list);
        }

        #endregion[Action]

        #region[Load Data]

        private void LoadData(Inward obj)
        {
            vId = obj.Inward_id;
            txt_order_id.Text = obj.Order_id;
            txt_invoice_no.Text = obj.Inward_no.ToString();
            txt_invoice_date.Text = obj.Inward_date;
            txt_party_id.Text = obj.Party_id;
            txt_bundel.Text = obj.Total_bundel;
            txt_total_qty.Text = obj.Total_qty.ToString();
            txt_notes.Text = obj.Notes;
            Core.Stative = obj.Active_id;
            Setactives();
        }

        #endregion[Load Data]

        #region[load items] 

        public void Loaditems(List<Inwarditems> list)
        {
            editgrid.RowCount = 0;
            if (list != null)
            {
                editgrid.RowCount = list.Count;
                for (int r = 0; r < list.Count; r++)
                {
                    DataGridViewRow row = editgrid.Rows[r];

                    row.Cells[INWARDITEMS.INWARDITEMS_ID].Value = (list[r].Inwarditems_id) + "";
                    row.Cells[INWARDITEMS.INWARD_ID].Value = (list[r].Inward_id) + "";
                    row.Cells[INWARDITEMS.PRODUCT_ID].Value = Checks.RemoveEscape((list[r].Product_id) + "");
                    row.Cells[INWARDITEMS.COLOURS_ID].Value = (list[r].Colours_id) + "";
                    row.Cells[INWARDITEMS.SIZES_ID].Value = (list[r].Sizes_id) + "";
                    row.Cells[INWARDITEMS.QTY].Value = (list[r].Qty) + "";
                    row.Cells[INWARDITEMS.BUNDLE].Value = (list[r].Bundle) + "";
                }
            }
        }

        #endregion[load items] 

        #region[Enable  Disable Controls]

        private void EnableControls(bool pEnabled)
        {
            bool pReadOnly = !pEnabled;

            txt_order_id.Enabled = !pReadOnly;
            txt_taxtype_id.Enabled = !pReadOnly;
            txt_salestype_id.Enabled = !pReadOnly;
            txt_transport_id.Enabled = !pReadOnly;
            txt_deliveredto_id.Enabled = !pReadOnly;
            txt_bundel.Enabled = !pReadOnly;
            txt_invoice_no.Enabled = !pReadOnly;
            txt_invoice_date.Enabled = !pReadOnly;
            txt_party_id.Enabled = !pReadOnly;
            txt_total_qty.Enabled = !pReadOnly;
            txt_gsttotal.Enabled = !pReadOnly;
            txt_ledger_id.Enabled = !pReadOnly;
            txt_additional.Enabled = !pReadOnly;
            txt_grandtotal.Enabled = !pReadOnly;
            txt_notes.Enabled = !pReadOnly;

            editgrid.Enabled = !pReadOnly;
            btn_active.Enabled = !pReadOnly;

        }

        #endregion[Enable  Disable Controls]

        #region[Save Event]

        private DAL dalsession;
        private void Save_Event(string info)
        {
            if (Validation() != false)
            {
                switch (fAction)
                {
                    case BtnEvent.Open:

                        if (info != Core.saveprint)
                        {
                            this.Hide();
                            Form_NeedToRefresh();
                        }
                        else
                        {
                            Print_copies();
                            this.Hide();
                            Form_NeedToRefresh();
                        }

                        break;

                    case BtnEvent.New:
                        try
                        {
                            var vData = CollectData();

                            dalsession = new DAL();
                            dalsession.BeginTransaction();
                            CInward.Insert(vData, dalsession);
                            vId = DAL.GetIdentity(dalsession);
                            var itemsList = Collectitems(vId);
                            CInwarditems.Insert(itemsList, dalsession);

                            //if (Customise.Inward_poid_dcid == true)
                            //{
                            //    //CDc_refered.Refered(itemsList, itemsList, dalsession);
                            //}
                            dalsession.Commit();

                            if (info != Core.saveprint)
                            {
                                MessageBox.Show(this.FindForm(), "Record Saved Successfully.", "Save...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            else
                            {
                                Print_copies();
                                this.Hide();
                                Form_NeedToRefresh();
                            }
                            //this.Hide();
                            //Form_NeedToRefresh();

                            SetAction(BtnEvent.New, null);
                            txt_invoice_no.Focus();
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

                            //var olditemslist = CInwarditems_exten.FK_withoutJoin(vId, new DAL());

                            CInwarditems.Delete(vId, dalsession);
                            CInward.Update(vData, dalsession);
                            var itemsList = Collectitems(vId);
                            CInwarditems.Insert(itemsList, dalsession);


                            //if (Customise.Inward_poid_dcid == true)
                            //{
                            //    CDc_refered.Refered(itemsList, olditemslist, dalsession);
                            //}

                            dalsession.Commit();

                            if (info != Core.saveprint)
                            {
                                MessageBox.Show(this.FindForm(), "Record Updated Successfully.", "Update...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            else
                            {
                                Print_copies();
                            }
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
                            CInwarditems.Delete(vId, dalsession);
                            CInward.Delete(vId, dalsession);
                            //var olditemslist = CInwarditems_exten.FK_withoutJoin(vId, new DAL());

                            //if (Customise.Inward_poid_dcid == true)
                            //{
                            //    CDc_refered.Refered(olditemslist, olditemslist, dalsession);
                            //}

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

        private Inward CollectData()
        {
            Inward fobj = new Inward()
            {
                Inward_id = vId,
                Uniqueno = Current.Acy_id + "~" + Current.Company_id + "~" + txt_invoice_no.Text,
                Company_id = Current.Company_id,
                //Div_id = Current.Div_id,
                Acy_id = Current.Acy_id,
                Order_id = COrder_exten.GetId_Name(txt_order_id.Text,"","",""),
                Inward_no = txt_invoice_no.Text,
                Inward_date = txt_invoice_date.Text,
                Party_id = CParty_exten.GetId_Name(txt_party_id.Text),
                Total_bundel = txt_bundel.Text,
                Total_qty = txt_total_qty.Text,
                Locked = Core.Unlocked,
                Active_id = Core.Stative,
                Notes = txt_notes.Text,
                User_id = Current.User
            };

            return fobj;
        }

        #endregion[CollectData]

        #region[Collect items] 

        private List<Inwarditems> Collectitems(string vId)
        {

            List<Inwarditems> list = new List<Inwarditems>();

            for (int r = 0; r < editgrid.RowCount; r++)
            {

                Inwarditems obj = new Inwarditems();

                if (
               (editgrid[INWARDITEMS.PRODUCT_ID, r].Value + "") == "" ||
               (editgrid[INWARDITEMS.COLOURS_ID, r].Value + "") == "" ||
                (editgrid[INWARDITEMS.QTY, r].Value + "") == "" ||
                (editgrid[INWARDITEMS.BUNDLE, r].Value + "") == ""
                )
                {
                    //==LEAVE IT(the empty row).  
                }
                else
                {
                    obj.Inwarditems_id = "";
                    obj.Inward_id = vId;
                    obj.Product_id = CProduct_exten.GetId_Name(Checks.Escape(editgrid[INWARDITEMS.PRODUCT_ID, r].Value + ""));
                    obj.Colours_id = CColours_exten.GetId_Name(editgrid[INWARDITEMS.COLOURS_ID, r].Value + "");
                    obj.Sizes_id = CSizes_exten.GetId_Name(editgrid[INWARDITEMS.SIZES_ID, r].Value + "");
                    obj.Qty = (editgrid[INWARDITEMS.QTY, r].Value + "");
                    obj.Bundle = (editgrid[INWARDITEMS.BUNDLE, r].Value + "");
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
                MessageBox.Show(this.FindForm(), "Inward no should not Empty ! ", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_invoice_no.Focus();
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
