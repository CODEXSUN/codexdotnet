// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// 20-06-2019 10:44:05 AM
// last update : 20-06-2019

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CXLIB;
using CXCORE;

//  
namespace CXERP
{
    public partial class FOrder : UserControl
    {
        #region[Action]

        private BtnEvent fAction = BtnEvent.Open;
        private Order obj;
        private List<Orderitems> list;
        private string vId;

        public void SetAction(BtnEvent pAction, string pPkValue)
        {
            fAction = pAction;

            switch (fAction)
            {
                case BtnEvent.Open:
                    btn_save.Text = "&CLOSE";
                    obj = COrder_exten.PKId(pPkValue);
                    list = COrderitems_exten.FKId(pPkValue);
                    this.EnableControls(false);
                    break;
                case BtnEvent.New:
                    btn_save.Text = "&SAVE";
                    obj = COrder.GetNew;
                    list = COrderitems.GetNew;
                    this.EnableControls(true);
                    break;
                case BtnEvent.Edit:
                    btn_save.Text = "&UPDATE";
                    obj = COrder_exten.PKId(pPkValue);
                    list = COrderitems_exten.FKId(pPkValue);
                    this.EnableControls(true);
                    break;
                case BtnEvent.Delete:
                    btn_save.Text = "CONFIRM\r\n&DELETE";
                    obj = COrder_exten.PKId(pPkValue);
                    list = COrderitems_exten.FKId(pPkValue);
                    this.EnableControls(false);
                    break;
                case BtnEvent.Print:
                    btn_save.Text = "&PRINT";
                    obj = COrder_exten.PKId(pPkValue);
                    list = COrderitems_exten.FKId(pPkValue);
                    this.EnableControls(false);
                    //print_panel.Show();
                    break;
            }

            LoadData(obj);
            Loaditems(list);
        }

        #endregion[Action]

        #region[Load Data]

        private void LoadData(Order obj)
        {
            vId = obj.Order_id;
            txt_order_no.Text = obj.Order_no;
            txt_order_date.Text = obj.Order_date;
            txt_ordertype_id.Text = obj.Ordertype_id;
            txt_party_id.Text = obj.Party_id;
            txt_party_ref.Text = obj.Party_ref;
            txt_style_ref.Text = obj.Style_ref;
            txt_notes.Text = obj.Notes;
            Core.Stative = obj.Active_id;
            Setactives();
        }

        #endregion[Load Data]

        #region[load items] 

        public void Loaditems(List<Orderitems> list)
        {
            editgrid.RowCount = 0;
            if (list != null)
            {
                editgrid.RowCount = list.Count;
                for (int r = 0; r < list.Count; r++)
                {
                    DataGridViewRow row = editgrid.Rows[r];

                    row.Cells[ORDERITEMS.ORDERITEMS_ID].Value = (list[r].Orderitems_id) + "";
                    row.Cells[ORDERITEMS.ORDER_ID].Value = (list[r].Order_id) + "";
                    row.Cells[ORDERITEMS.ORDER_NO].Value = (list[r].Order_no) + "";
                    row.Cells[ORDERITEMS.PRODUCT_ID].Value = (list[r].Product_id) + "";
                    row.Cells[ORDERITEMS.COLOURS_ID].Value = (list[r].Colours_id) + "";
                    row.Cells[ORDERITEMS.SIZES_ID].Value = (list[r].Sizes_id) + "";
                    row.Cells[ORDERITEMS.QTY].Value = (list[r].Qty) + "";
                    row.Cells[ORDERITEMS.PRICE].Value = (list[r].Price) + "";
                }
            }
        }

        #endregion[load items] 

        #region[Enable  Disable Controls]

        private void EnableControls(bool pEnabled)
        {
            bool pReadOnly = !pEnabled;

            txt_order_no.Enabled = !pReadOnly;
            txt_order_date.Enabled = !pReadOnly;
            txt_ordertype_id.Enabled = !pReadOnly;
            txt_party_id.Enabled = !pReadOnly;
            txt_party_ref.Enabled = !pReadOnly;
            txt_style_ref.Enabled = !pReadOnly;
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
                            COrder.Insert(vData, dalsession);
                            vId = DAL.GetIdentity(dalsession);
                            var itemsList = Collectitems(vId);
                            COrderitems.Insert(itemsList, dalsession);
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
                            COrderitems.Delete(vId, dalsession);
                            COrder.Update(vData, dalsession);
                            var itemsList = Collectitems(vId);
                            COrderitems.Insert(itemsList, dalsession);
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
                            COrderitems.Delete(vId, dalsession);
                            COrder.Delete(vId, dalsession);
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

        private Order CollectData()
        {
            Order fobj = new Order()
            {
                Order_id = vId,
                Uniqueno = Current.Acy_id + "~" + Current.Company_id + "~" + txt_order_no.Text + "~"+ txt_order_date.Text,
                Company_id = Current.Company_id,
                Acy_id = Current.Acy_id,
                Order_no = txt_order_no.Text,
                Order_date = txt_order_date.Text,
                Ordertype_id = COrdertype_exten.GetId_Name(txt_ordertype_id.Text),
                Party_id = CParty_exten.GetId_Name(txt_party_id.Text),
                Party_ref = txt_party_ref.Text,
                Style_ref = txt_style_ref.Text,
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

        private List<Orderitems> Collectitems(string vId)
        {

            List<Orderitems> list = new List<Orderitems>();

            for (int r = 0; r < editgrid.RowCount; r++)
            {

                Orderitems obj = new Orderitems();

                if (
               (editgrid[ORDERITEMS.PRODUCT_ID, r].Value + "") == "" ||
                (editgrid[ORDERITEMS.QTY, r].Value + "") == "" ||
                (editgrid[ORDERITEMS.PRICE, r].Value + "") == ""
                )
                {
                    //==LEAVE IT(the empty row).  
                }
                else
                {
                    obj.Orderitems_id = "";
                    obj.Order_id = vId;
                    obj.Order_no = txt_order_no.Text;
                    obj.Product_id = CProduct_exten.GetId_Name(editgrid[ORDERITEMS.PRODUCT_ID, r].Value + "");
                    obj.Colours_id = CColours_exten.GetId_Name(editgrid[ORDERITEMS.COLOURS_ID, r].Value + "");
                    obj.Sizes_id = CSizes_exten.GetId_Name(editgrid[ORDERITEMS.SIZES_ID, r].Value + "");
                    obj.Qty = (editgrid[ORDERITEMS.QTY, r].Value + "");
                    obj.Price = ConvertTO.Decimal(editgrid[ORDERITEMS.PRICE, r].Value + "");
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
            if (txt_order_no.Text.Trim().Length == 0)
            {
                MessageBox.Show(this.FindForm(), "Order no should not Empty ! ", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_order_no.Focus();
                return false;
            }

            if (txt_party_ref.Text.Trim().Length == 0)
            {
                MessageBox.Show(this.FindForm(), "Party ref should not Empty ! ", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_party_ref.Focus();
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
