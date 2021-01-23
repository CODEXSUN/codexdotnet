// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 10:23:39 PM

using System;
using System.Windows.Forms;
using CXLIB;

namespace CXCORE
{
    public partial class FProduct : UserControl
    {
        #region[Action]

        private BtnEvent fAction = BtnEvent.Open;
        private Product obj;
        private string vId;

        public void SetAction(BtnEvent pAction, string pPkValue)
        {
            fAction = pAction;

            switch (fAction)
            {
                case BtnEvent.Open:
                    btn_save.Text = "&CLOSE";
                    obj = CProduct_exten.PKId(pPkValue, new DAL());
                    this.EnableControls(false);
                    break;
                case BtnEvent.New:
                    btn_save.Text = "&SAVE";
                    obj = CProduct.GetNew;
                    this.EnableControls(true);
                    break;
                case BtnEvent.Edit:
                    btn_save.Text = "&UPDATE";
                    obj = CProduct_exten.PKId(pPkValue, new DAL());
                    this.EnableControls(true);
                    break;
                case BtnEvent.Delete:
                    btn_save.Text = "CONFIRM\r\n&DELETE";
                    obj = CProduct_exten.PKId(pPkValue, new DAL());
                    this.EnableControls(false);
                    break;
                case BtnEvent.Print:
                    btn_save.Text = "&PRINT";
                    obj = CProduct_exten.PKId(pPkValue, new DAL());
                    this.EnableControls(false);
                    break;
            }

            this.LoadData();
        }

        #endregion[Action]

        #region[Load Data]

        private void LoadData()
        {
            vId = obj.Product_id;
            txt_product_name.Text = Checks.RemoveEscape(obj.Product_name);
            txt_producttype_id.Text = obj.Producttype_id;
            txt_hsncode_id.Text = obj.Hsncode_id;
            txt_unit_id.Text = obj.Unit_id;
            txt_purchase_price.Text = obj.Purchase_price.ToString();
            txt_selling_price.Text = obj.Selling_price.ToString();
            txt_sgst_percent.Text = obj.Sgst_percent;
            txt_cgst_percent.Text = obj.Cgst_percent;
            txt_igst_percent.Text = obj.Igst_percent;
            txt_opening_stock.Text = obj.Opening_stock.ToString();
            txt_opening_price.Text = obj.Opening_price.ToString();
            txt_notes.Text = obj.Notes;
            Core.Stative = obj.Active_id;
            Setactives();
        }

        #endregion[Load Data]

        #region[Enable  Disable Controls]

        private void EnableControls(bool pEnabled)
        {
            bool pReadOnly = !pEnabled;

            txt_product_name.Enabled = !pReadOnly;
            txt_producttype_id.Enabled = !pReadOnly;
            txt_hsncode_id.Enabled = !pReadOnly;
            txt_unit_id.Enabled = !pReadOnly;
            txt_purchase_price.Enabled = !pReadOnly;
            txt_selling_price.Enabled = !pReadOnly;
            txt_sgst_percent.Enabled = !pReadOnly;
            txt_cgst_percent.Enabled = !pReadOnly;
            txt_igst_percent.Enabled = !pReadOnly;
            txt_opening_stock.Enabled = !pReadOnly;
            txt_opening_price.Enabled = !pReadOnly;
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
                            CProduct.Insert(vData, dalsession);
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
                            CProduct.Update(vData, dalsession);
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
                            CProduct.Delete(vId, dalsession);
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

        private Product CollectData()
        {
            Product fobj = new Product()
            {
                Product_id = vId,
                Product_name = Checks.Escape(txt_product_name.Text),
                Producttype_id = CProducttype_exten.GetId_Name(txt_producttype_id.Text),
                Hsncode_id = CHsncode_exten.GetId_Name(txt_hsncode_id.Text),
                Unit_id = CUnit_exten.GetId_Name(txt_unit_id.Text),
                Purchase_price = ConvertTO.Decimal(txt_purchase_price.Text),
                Selling_price = ConvertTO.Decimal(txt_selling_price.Text),
                Sgst_percent = txt_sgst_percent.Text,
                Cgst_percent = txt_cgst_percent.Text,
                Igst_percent = txt_igst_percent.Text,
                Opening_stock = ConvertTO.Decimal(txt_opening_stock.Text),
                Opening_price = ConvertTO.Decimal(txt_opening_price.Text),
                Active_id = Core.Stative,
                Notes = txt_notes.Text,
                User_id = Current.User
            };

            if ((fobj.Producttype_id == null) || (fobj.Producttype_id == "")) { fobj.Producttype_id = "1"; }
            if ((fobj.Hsncode_id == null) || (fobj.Hsncode_id == "")) { fobj.Hsncode_id = "1"; }
            if ((fobj.Unit_id == null) || (fobj.Unit_id == "")) { fobj.Unit_id = "1"; }

            return fobj;
        }

        #endregion[CollectData]

        #region[Validation]

        private bool Validation()
        {
            if (txt_product_name.Text.Trim().Length == 0)
            {
                MessageBox.Show(this.FindForm(), "Product name should not Empty ! ", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_product_name.Focus();
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
