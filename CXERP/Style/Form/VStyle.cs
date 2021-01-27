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
    public partial class FStyle : UserControl
    {
        #region[Action]

        private BtnEvent fAction = BtnEvent.Open;
        private Style obj;
        private List<Styleitems> list;
        private string vId;

        public void SetAction(BtnEvent pAction, string pPkValue)
        {
            fAction = pAction;

            switch (fAction)
            {
                case BtnEvent.Open:
                    btn_save.Text = "&CLOSE";
                    obj = CStyle_exten.PKId(pPkValue);
                    list = CStyleitems_exten.FKId(pPkValue);
                    this.EnableControls(false);
                    break;
                case BtnEvent.New:
                    btn_save.Text = "&SAVE";
                    obj = CStyle.GetNew;
                    list = CStyleitems.GetNew;
                    this.EnableControls(true);
                    break;
                case BtnEvent.Edit:
                    btn_save.Text = "&UPDATE";
                    obj = CStyle_exten.PKId(pPkValue);
                    list = CStyleitems_exten.FKId(pPkValue);
                    this.EnableControls(true);
                    break;
                case BtnEvent.Delete:
                    btn_save.Text = "CONFIRM\r\n&DELETE";
                    obj = CStyle_exten.PKId(pPkValue);
                    list = CStyleitems_exten.FKId(pPkValue);
                    this.EnableControls(false);
                    break;
                case BtnEvent.Print:
                    btn_save.Text = "&PRINT";
                    obj = CStyle_exten.PKId(pPkValue);
                    list = CStyleitems_exten.FKId(pPkValue);
                    this.EnableControls(false);
                    //print_panel.Show();
                    break;
            }

            LoadData(obj);
            Loaditems(list);
        }

        #endregion[Action]

        #region[Load Data]

        private void LoadData(Style obj)
        {
            vId = obj.Style_id;
            txt_style_no.Text = obj.Style_no;
            txt_style_name.Text = obj.Style_name;
            txt_notes.Text = obj.Notes;
            Core.Stative = obj.Active_id;
            Setactives();
        }

        #endregion[Load Data]

        #region[load items] 

        public void Loaditems(List<Styleitems> list)
        {
            editgrid.RowCount = 0;
            if (list != null)
            {
                editgrid.RowCount = list.Count;
                for (int r = 0; r < list.Count; r++)
                {
                    DataGridViewRow row = editgrid.Rows[r];

                    row.Cells[STYLEITEMS.STYLEITEMS_ID].Value = (list[r].Styleitems_id) + "";
                    row.Cells[STYLEITEMS.STYLE_ID].Value = (list[r].Style_id) + "";
                    row.Cells[STYLEITEMS.STYLE_NO].Value = (list[r].Style_no) + "";
                    row.Cells[STYLEITEMS.ARTICLE_ID].Value = (list[r].Article_id) + "";
                    row.Cells[STYLEITEMS.PRODUCT_ID].Value = (list[r].Product_id) + "";
                    row.Cells[STYLEITEMS.COLOURS_ID].Value = (list[r].Colours_id) + "";
                    row.Cells[STYLEITEMS.SIZES_ID].Value = (list[r].Sizes_id) + "";
                    row.Cells[STYLEITEMS.QTY].Value = (list[r].Qty) + "";
                    row.Cells[STYLEITEMS.PRICE].Value = (list[r].Price) + "";
                }
            }
        }

        #endregion[load items] 

        #region[Enable  Disable Controls]

        private void EnableControls(bool pEnabled)
        {
            bool pReadOnly = !pEnabled;

            txt_style_no.Enabled = !pReadOnly;
            txt_style_name.Enabled = !pReadOnly;
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
                            CStyle.Insert(vData, dalsession);
                            vId = DAL.GetIdentity(dalsession);
                            var itemsList = Collectitems(vId);
                            CStyleitems.Insert(itemsList, dalsession);
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
                            CStyleitems.Delete(vId, dalsession);
                            CStyle.Update(vData, dalsession);
                            var itemsList = Collectitems(vId);
                            CStyleitems.Insert(itemsList, dalsession);
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
                            CStyleitems.Delete(vId, dalsession);
                            CStyle.Delete(vId, dalsession);
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

        private Style CollectData()
        {
            Style fobj = new Style()
            {
                Style_id = vId,
                Uniqueno = Current.Acy_id + "~" + Current.Company_id + "~" + txt_style_no.Text + "~"+ txt_style_name.Text,
                Company_id = Current.Company_id,
                Acy_id = Current.Acy_id,
                Style_no = txt_style_no.Text,
                Style_name = txt_style_name.Text,
                Locked = Core.Unlocked,
                Active_id = Core.Stative,
                Notes = txt_notes.Text,
                User_id = Current.User
            };
            return fobj;
        }

        #endregion[CollectData]

        #region[Collect items] 

        private List<Styleitems> Collectitems(string vId)
        {

            List<Styleitems> list = new List<Styleitems>();

            for (int r = 0; r < editgrid.RowCount; r++)
            {

                Styleitems obj = new Styleitems();

                if (
                    (editgrid[STYLEITEMS.ARTICLE_ID, r].Value + "") == "" ||
               (editgrid[STYLEITEMS.PRODUCT_ID, r].Value + "") == "" ||
                (editgrid[STYLEITEMS.QTY, r].Value + "") == "" ||
                (editgrid[STYLEITEMS.PRICE, r].Value + "") == ""
                )
                {
                    //==LEAVE IT(the empty row).  
                }
                else
                {
                    obj.Styleitems_id = "";
                    obj.Style_id = vId;
                    obj.Style_no = txt_style_no.Text;
                    obj.Article_id = CArticle_exten.GetId_Name(editgrid[STYLEITEMS.ARTICLE_ID, r].Value + "");
                    obj.Product_id = CProduct_exten.GetId_Name(editgrid[STYLEITEMS.PRODUCT_ID, r].Value + "");
                    obj.Colours_id = CColours_exten.GetId_Name(editgrid[STYLEITEMS.COLOURS_ID, r].Value + "");
                    obj.Sizes_id = CSizes_exten.GetId_Name(editgrid[STYLEITEMS.SIZES_ID, r].Value + "");
                    obj.Qty = (editgrid[STYLEITEMS.QTY, r].Value + "");
                    obj.Price = ConvertTO.Decimal(editgrid[STYLEITEMS.PRICE, r].Value + "");
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
            if (txt_style_no.Text.Trim().Length == 0)
            {
                MessageBox.Show(this.FindForm(), "Style no should not Empty ! ", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_style_no.Focus();
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
