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
    public partial class FOffset_dc : UserControl
    {
        #region[Action]

        private BtnEvent fAction = BtnEvent.Open;
        private Offset_dc obj;
        private List<Offset_dcitems> list;
        private string vId;

        public void SetAction(BtnEvent pAction, string pPkValue)
        {
            fAction = pAction;

            switch (fAction)
            {
                case BtnEvent.Open:
                    btn_save.Text = "&CLOSE";
                    obj = COffset_dc_exten.PKId(pPkValue, new DAL());
                    list = COffset_dcitems_exten.FKId(pPkValue, new DAL());
                    this.EnableControls(false);
                    break;
                case BtnEvent.New:
                    btn_save.Text = "&SAVE";
                    obj = COffset_dc.GetNew;
                    list = COffset_dcitems.GetNew;
                    this.EnableControls(true);
                    break;
                case BtnEvent.Edit:
                    btn_save.Text = "&UPDATE";
                    obj = COffset_dc_exten.PKId(pPkValue, new DAL());
                    list = COffset_dcitems_exten.FKId(pPkValue, new DAL());
                    this.EnableControls(true);
                    break;
                case BtnEvent.Delete:
                    btn_save.Text = "CONFIRM\r\n&DELETE";
                    obj = COffset_dc_exten.PKId(pPkValue, new DAL());
                    list = COffset_dcitems_exten.FKId(pPkValue, new DAL());
                    this.EnableControls(false);
                    break;
                case BtnEvent.Print:
                    btn_save.Text = "&PRINT";
                    obj = COffset_dc_exten.PKId(pPkValue, new DAL());
                    list = COffset_dcitems_exten.FKId(pPkValue, new DAL());
                    this.EnableControls(false);
                    print_panel.Show();
                    break;
            }

            LoadData(obj);
            Loaditems(list);
        }

        #endregion[Action]

        #region[Load Data]

        private void LoadData(Offset_dc obj)
        {
            vId = obj.Offset_dc_id;
            txt_dc_no.Text = obj.Offset_dc_no;
            txt_dc_date.Text = obj.Offset_dc_date;
            txt_party_id.Text = obj.Party_id;
            txt_total_qty.Text = obj.Total_qty;
            txt_notes.Text = obj.Notes;
            Core.Stative = obj.Active_id;
            Setactives();
        }

        #endregion[Load Data]

        #region[load items] 

        public void Loaditems(List<Offset_dcitems> list)
        {
            editgrid.RowCount = 0;
            if (list != null)
            {
                editgrid.RowCount = list.Count;
                for (int r = 0; r < list.Count; r++)
                {
                    DataGridViewRow row = editgrid.Rows[r];

                    row.Cells[OFFSET_DCITEMS.OFFSET_DCITEMS_ID].Value = (list[r].Offset_dcitems_id) + "";
                    row.Cells[OFFSET_DCITEMS.OFFSET_DC_ID].Value = (list[r].Offset_dc_id) + "";
                    //row.Cells[DCITEMS.DC_NO].Value = (list[r].Dc_no) + ""; 
                    row.Cells[OFFSET_DCITEMS.OFFSET_PO_ID].Value = (list[r].Offset_po_id) + "";
                    row.Cells[OFFSET_DCITEMS.OFFSET_POITEMS_ID].Value = (list[r].Offset_poitems_id) + "";
                    row.Cells[OFFSET_DCITEMS.PRODUCT_ID].Value = (list[r].Product_id) + "";
                    row.Cells[OFFSET_DCITEMS.QTY].Value = (list[r].Qty) + "";
                }
            }
        }

        #endregion[load items] 

        #region[Enable  Disable Controls]

        private void EnableControls(bool pEnabled)
        {
            bool pReadOnly = !pEnabled;

            txt_dc_no.Enabled = !pReadOnly;
            txt_dc_date.Enabled = !pReadOnly;
            txt_party_id.Enabled = !pReadOnly;
            txt_total_qty.Enabled = !pReadOnly;
            txt_notes.Enabled = !pReadOnly;
            editgrid.Enabled = !pReadOnly;
            btn_active.Enabled = !pReadOnly;
            editgrid.Enabled = !pReadOnly;

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
                            COffset_dc.Insert(vData, dalsession);
                            vId = DAL.GetIdentity(dalsession);
                            var itemsList = Collectitems(vId);
                            COffset_dcitems.Insert(itemsList, dalsession);
                            CPo_refered.Refered(itemsList, itemsList, dalsession);
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
                            COffset_dcitems.Delete(vId, dalsession);
                            COffset_dc.Update(vData, dalsession);
                            var itemsList = Collectitems(vId);
                            COffset_dcitems.Insert(itemsList, dalsession);
                            var olditemslist = COffset_dcitems_exten.FK_withoutJoin(vId, new DAL());
                            CPo_refered.Refered(itemsList, olditemslist, dalsession);
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
                            COffset_dcitems.Delete(vId, dalsession);
                            COffset_dc.Delete(vId, dalsession);
                            var olditemslist = COffset_dcitems_exten.FK_withoutJoin(vId, new DAL());
                            CPo_refered.Refered(olditemslist, olditemslist, dalsession);
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

        private Offset_dc CollectData()
        {
            Offset_dc fobj = new Offset_dc()
            {
                Offset_dc_id = vId,
                Unqiueno = Current.Acy_id + "~" + Current.Company_id + "~" + txt_dc_no.Text,
                Company_id = Current.Company_id,
                Acy_id = Current.Acy_id,
                Offset_dc_no = txt_dc_no.Text,
                Offset_dc_date = txt_dc_date.Text,
                Party_id = CParty_exten.GetId_Name(txt_party_id.Text),
                Total_qty = txt_total_qty.Text,
                Refered_no = "",
                Locked = Core.Unlocked,
                Active_id = Core.Stative,
                Notes = txt_notes.Text,
                User_id = Current.User
            };
            return fobj;
        }

        #endregion[CollectData]

        #region[Collect items] 

        private List<Offset_dcitems> Collectitems(string vId)
        {

            List<Offset_dcitems> list = new List<Offset_dcitems>();

            for (int r = 0; r < editgrid.RowCount; r++)
            {

                Offset_dcitems obj = new Offset_dcitems();

                if (
               (editgrid[OFFSET_DCITEMS.PRODUCT_ID, r].Value + "") == "" ||
                (editgrid[OFFSET_DCITEMS.QTY, r].Value + "") == "")
                {
                    //==LEAVE IT(the empty row).  
                }
                else
                {
                    obj.Offset_dcitems_id = "";
                    obj.Offset_dc_id = vId;
                    obj.Offset_dc_no = txt_dc_no.Text;
                    if (((editgrid[OFFSET_DCITEMS.OFFSET_PO_ID, r].Value + "") == "") || ((editgrid[OFFSET_DCITEMS.OFFSET_PO_ID, r].Value + "") == Core.Without_Po))
                    {
                        obj.Offset_po_id = "1";
                        obj.Offset_poitems_id = "1";
                    }
                    else
                    {
                        obj.Offset_po_id = COffset_po_exten.GetId_Name(editgrid[OFFSET_DCITEMS.OFFSET_PO_ID, r].Value + "");
                        obj.Offset_poitems_id = editgrid[OFFSET_DCITEMS.OFFSET_POITEMS_ID, r].Value + "";
                    }

                    obj.Product_id = CProduct_exten.GetId_Name(editgrid[OFFSET_DCITEMS.PRODUCT_ID, r].Value + "");
                    obj.Qty = (editgrid[OFFSET_DCITEMS.QTY, r].Value + "");
                    obj.Refered_qty = (editgrid[OFFSET_DCITEMS.QTY, r].Value + "");
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
            if (txt_dc_no.Text.Trim().Length == 0)
            {
                MessageBox.Show(this.FindForm(), "Dc no should not Empty ! ", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_dc_no.Focus();
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
