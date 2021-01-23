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
    public partial class FArticle : UserControl
    {
        #region[Action]

        private BtnEvent fAction = BtnEvent.Open;
        private Article obj;
        private List<Articleitems> list;
        private string vId;

        public void SetAction(BtnEvent pAction, string pPkValue)
        {
            fAction = pAction;

            switch (fAction)
            {
                case BtnEvent.Open:
                    btn_save.Text = "&CLOSE";
                    obj = CArticle_exten.PKId(pPkValue);
                    list = CArticleitems_exten.FKId(pPkValue);
                    this.EnableControls(false);
                    break;
                case BtnEvent.New:
                    btn_save.Text = "&SAVE";
                    obj = CArticle.GetNew;
                    list = CArticleitems.GetNew;
                    this.EnableControls(true);
                    break;
                case BtnEvent.Edit:
                    btn_save.Text = "&UPDATE";
                    obj = CArticle_exten.PKId(pPkValue);
                    list = CArticleitems_exten.FKId(pPkValue);
                    this.EnableControls(true);
                    break;
                case BtnEvent.Delete:
                    btn_save.Text = "CONFIRM\r\n&DELETE";
                    obj = CArticle_exten.PKId(pPkValue);
                    list = CArticleitems_exten.FKId(pPkValue);
                    this.EnableControls(false);
                    break;
                case BtnEvent.Print:
                    btn_save.Text = "&PRINT";
                    obj = CArticle_exten.PKId(pPkValue);
                    list = CArticleitems_exten.FKId(pPkValue);
                    this.EnableControls(false);
                    //print_panel.Show();
                    break;
            }

            LoadData(obj);
            Loaditems(list);
        }

        #endregion[Action]

        #region[Load Data]

        private void LoadData(Article obj)
        {
            vId = obj.Article_id;
            txt_article_no.Text = obj.Article_no;
            txt_article_date.Text = obj.Article_date;
            txt_notes.Text = obj.Notes;
            Core.Stative = obj.Active_id;
            Setactives();
        }

        #endregion[Load Data]

        #region[load items] 

        public void Loaditems(List<Articleitems> list)
        {
            editgrid.RowCount = 0;
            if (list != null)
            {
                editgrid.RowCount = list.Count;
                for (int r = 0; r < list.Count; r++)
                {
                    DataGridViewRow row = editgrid.Rows[r];

                    row.Cells[ARTICLEITEMS.ARTICLEITEMS_ID].Value = (list[r].Articleitems_id) + "";
                    row.Cells[ARTICLEITEMS.ARTICLE_ID].Value = (list[r].Article_id) + "";
                    row.Cells[ARTICLEITEMS.ARTICLE_NO].Value = (list[r].Article_no) + "";
                    row.Cells[ARTICLEITEMS.PRODUCT_ID].Value = (list[r].Product_id) + "";
                    row.Cells[ARTICLEITEMS.COLOURS_ID].Value = (list[r].Colours_id) + "";
                    row.Cells[ARTICLEITEMS.SIZES_ID].Value = (list[r].Sizes_id) + "";
                    row.Cells[ARTICLEITEMS.QTY].Value = (list[r].Qty) + "";
                    row.Cells[ARTICLEITEMS.PRICE].Value = (list[r].Price) + "";
                }
            }
        }

        #endregion[load items] 

        #region[Enable  Disable Controls]

        private void EnableControls(bool pEnabled)
        {
            bool pReadOnly = !pEnabled;

            txt_article_no.Enabled = !pReadOnly;
            txt_article_date.Enabled = !pReadOnly;
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
                            vId = DAL.GetIdentity(dalsession);
                            var itemsList = Collectitems(vId);
                            CArticleitems.Insert(itemsList, dalsession);
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
                            CArticleitems.Delete(vId, dalsession);
                            CArticle.Update(vData, dalsession);
                            var itemsList = Collectitems(vId);
                            CArticleitems.Insert(itemsList, dalsession);
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
                            CArticleitems.Delete(vId, dalsession);
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
                Uniqueno = Current.Acy_id + "~" + Current.Company_id + "~" + txt_article_no.Text + "~"+ txt_article_date.Text,
                Company_id = Current.Company_id,
                Acy_id = Current.Acy_id,
                Article_no = txt_article_no.Text,
                Article_date = txt_article_date.Text,
                Locked = Core.Unlocked,
                Active_id = Core.Stative,
                Notes = txt_notes.Text,
                User_id = Current.User
            };
            return fobj;
        }

        #endregion[CollectData]

        #region[Collect items] 

        private List<Articleitems> Collectitems(string vId)
        {

            List<Articleitems> list = new List<Articleitems>();

            for (int r = 0; r < editgrid.RowCount; r++)
            {

                Articleitems obj = new Articleitems();

                if (
               (editgrid[ARTICLEITEMS.PRODUCT_ID, r].Value + "") == "" ||
                (editgrid[ARTICLEITEMS.QTY, r].Value + "") == "" ||
                (editgrid[ARTICLEITEMS.PRICE, r].Value + "") == ""
                )
                {
                    //==LEAVE IT(the empty row).  
                }
                else
                {
                    obj.Articleitems_id = "";
                    obj.Article_id = vId;
                    obj.Article_no = txt_article_no.Text;
                    obj.Product_id = CProduct_exten.GetId_Name(editgrid[ARTICLEITEMS.PRODUCT_ID, r].Value + "");
                    obj.Colours_id = CColours_exten.GetId_Name(editgrid[ARTICLEITEMS.COLOURS_ID, r].Value + "");
                    obj.Sizes_id = CSizes_exten.GetId_Name(editgrid[ARTICLEITEMS.SIZES_ID, r].Value + "");
                    obj.Qty = (editgrid[ARTICLEITEMS.QTY, r].Value + "");
                    obj.Price = ConvertTO.Decimal(editgrid[ARTICLEITEMS.PRICE, r].Value + "");
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
            if (txt_article_no.Text.Trim().Length == 0)
            {
                MessageBox.Show(this.FindForm(), "Article no should not Empty ! ", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_article_no.Focus();
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
