// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 10:23:39 PM

using System.Windows.Forms;
using System.Collections.Generic;
using CXLIB;

namespace CXCORE
{
    public partial class LProduct
    {
        #region[list Option] 

        public void ListRefresh()
        {
            List_Option(fAction);
        }

        private ListOption fAction = ListOption.active;
        public void List_Option(ListOption pAction)
        {
            fAction = pAction;

            switch (fAction)
            {
                case ListOption.active:

                    if (chk_notactive.Checked == true)
                    {
                        LoadData(CProduct_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CProduct_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.notactive:

                    if (chk_notactive.Checked == true)
                    {
                        LoadData(CProduct_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CProduct_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.Search:
                    if (txt_product_name.Text != "")
                    {
                        List<Product> list = new List<Product>
                     {
                     CProduct_exten.SearchName(txt_product_name.Text, new DAL())
                     };
                        LoadData(list);
                    }
                    else
                    {
                        LoadData(CProduct_exten.Active(new DAL()));
                    }
                    break;

                default:
                    LoadData(CProduct_exten.Active(new DAL()));
                    break;
            }
        }

        #endregion[list Option] 

        #region[Load Data] 

        public void LoadData(List<Product> list)
        {
            listgrid.RowCount = 0;
            listgrid.RowCount = list.Count;
            for (int r = 0; r < list.Count; r++)
            {
                DataGridViewRow row = listgrid.Rows[r];

                row.Cells["SN"].Value = (r + 1);
                row.Cells[PRODUCT.PRODUCT_ID].Value = list[r].Product_id;
                row.Cells[PRODUCT.PRODUCT_NAME].Value = Checks.RemoveEscape(list[r].Product_name);
                row.Cells[PRODUCT.PRODUCTTYPE_ID].Value = list[r].Producttype_id;
                row.Cells[PRODUCT.HSNCODE_ID].Value = list[r].Hsncode_id;
                row.Cells[PRODUCT.UNIT_ID].Value = list[r].Unit_id;
                row.Cells[PRODUCT.PURCHASE_PRICE].Value = list[r].Purchase_price;
                row.Cells[PRODUCT.SELLING_PRICE].Value = list[r].Selling_price;
                row.Cells[PRODUCT.SGST_PERCENT].Value = list[r].Sgst_percent;
                row.Cells[PRODUCT.CGST_PERCENT].Value = list[r].Cgst_percent;
                row.Cells[PRODUCT.IGST_PERCENT].Value = list[r].Igst_percent;
                row.Cells[PRODUCT.OPENING_STOCK].Value = list[r].Opening_stock;
                row.Cells[PRODUCT.OPENING_PRICE].Value = list[r].Opening_price;
                row.Cells[PRODUCT.NOTES].Value = list[r].Notes;
                row.Cells[PRODUCT.ACTIVE_ID].Value = list[r].Active_id;
                row.Cells[PRODUCT.USER_ID].Value = list[r].User_id;
            }
        }

        #endregion[Load Data] 

    }//cls 
}//ns 
