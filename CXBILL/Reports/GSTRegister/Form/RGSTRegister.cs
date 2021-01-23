// Version : 7.6 dt : 30-03-2017
// CODESK
// 24-01-2017 08:01:01 AM
// create date : 24-01-2017
// last update : 30-03-2017

using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using CXLIB;
using CXCORE;
//using CXBILL;

namespace CXBILL
{
    public partial class RGSTRegister
    {
        #region[load option]

        private action fAction = action.showall;
        public void list_GSTregister(action pAction)
        {
            fAction = pAction;
            //pAction = action.unreceipted;

            Load_sales(RCGSTRegister.SalesData(txt_from_date.Text, txt_to_date.Text));
            Load_Purchase(RCGSTRegister.PurchaseData(txt_from_date.Text, txt_to_date.Text));

            txt_difference.Text = ConvertTO.Decimal2d((Convert.ToDecimal(txt_sales_total.Text + "0") - Convert.ToDecimal(txt_purchase_total.Text + "0")).ToString());
            txt_gst_difference.Text = ConvertTO.Decimal2d((Convert.ToDecimal(txt_Sales_gst_total.Text + "0") - Convert.ToDecimal(txt_purchase_gst_total.Text + "0")).ToString());
            //
        }
        //
        #endregion[load option]

        #region[load Sales]
        
        public void Load_sales(List<Sales_Gst> vlist)
        {

            decimal _Sales_amount = 0M; decimal _Sales_gst = 0M;

            Listgrid.RowCount = 0;
            Listgrid.RowCount = vlist.Count;

            for (int r = 0; r < vlist.Count; r++)
            {
                DataGridViewRow row = Listgrid.Rows[r];


                row.Cells[SALES_GST.SALES_MONTH].Value = r+1;
                row.Cells[SALES_GST.GSTIN].Value = vlist[r].Gstin;
                row.Cells[SALES_GST.PARTY_NAME].Value = vlist[r].Party_name;
                row.Cells[SALES_GST.BILL_NO].Value = vlist[r].Bill_no;
                row.Cells[SALES_GST.BILL_DATE].Value = ConvertTO.Date2S(vlist[r].Bill_date);
                row.Cells[SALES_GST.BILL_AMOUNT].Value = vlist[r].Bill_amount;
                row.Cells[SALES_GST.TAXABLE_VALUE].Value = vlist[r].Taxable_value;
                row.Cells[SALES_GST.SGST_PERCENT].Value = vlist[r].Sgst_percent;
                row.Cells[SALES_GST.SGST_AMOUNT].Value = vlist[r].Sgst_amount;
                row.Cells[SALES_GST.CGST_PERCENT].Value = vlist[r].Cgst_percent;
                row.Cells[SALES_GST.CGST_AMOUNT].Value = vlist[r].Cgst_amount;
                row.Cells[SALES_GST.IGST_PERCENT].Value = vlist[r].Igst_percent;
                row.Cells[SALES_GST.IGST_AMOUNT].Value = vlist[r].Igst_amount;
                row.Cells[SALES_GST.GST_TOTAL].Value = vlist[r].Gst_total;

                _Sales_amount += ConvertTO.Decimal(vlist[r].Bill_amount);
                _Sales_gst += ConvertTO.Decimal(vlist[r].Gst_total);

            }

            txt_sales_total.Text = ConvertTO.Decimal2d(_Sales_amount.ToString());
            txt_Sales_gst_total.Text = ConvertTO.Decimal2d(_Sales_gst.ToString());
        }

        public void Load_Purchase(List<Purchase_Gst> vlist)
        {

            decimal _Purchase_amount = 0M; decimal _Purchase_Gst_amount = 0M;

            Listgrid_1.RowCount = 0;
            Listgrid_1.RowCount = vlist.Count;

            for (int r = 0; r < vlist.Count; r++)
            {
                DataGridViewRow row = Listgrid_1.Rows[r];
                
                row.Cells[PURCHASE_GST.PURCHASE_MONTH].Value = r+1;
                row.Cells[PURCHASE_GST.GSTIN].Value = vlist[r].Gstin;
                row.Cells[PURCHASE_GST.PARTY_NAME].Value = vlist[r].Party_name;
                row.Cells[PURCHASE_GST.BILL_NO].Value = vlist[r].Bill_no;
                row.Cells[PURCHASE_GST.BILL_DATE].Value = ConvertTO.Date2S(vlist[r].Bill_date);
                row.Cells[PURCHASE_GST.BILL_AMOUNT].Value = vlist[r].Bill_amount;
                row.Cells[PURCHASE_GST.TAXABLE_VALUE].Value = vlist[r].Taxable_value;
                row.Cells[PURCHASE_GST.SGST_PERCENT].Value = vlist[r].Sgst_percent;
                row.Cells[PURCHASE_GST.SGST_AMOUNT].Value = vlist[r].Sgst_amount;
                row.Cells[PURCHASE_GST.CGST_PERCENT].Value = vlist[r].Cgst_percent;
                row.Cells[PURCHASE_GST.CGST_AMOUNT].Value = vlist[r].Cgst_amount;
                row.Cells[PURCHASE_GST.IGST_PERCENT].Value = vlist[r].Igst_percent;
                row.Cells[PURCHASE_GST.IGST_AMOUNT].Value = vlist[r].Igst_amount;
                row.Cells[PURCHASE_GST.GST_TOTAL].Value = vlist[r].Gst_total;

                _Purchase_amount += ConvertTO.Decimal(vlist[r].Bill_amount);
                _Purchase_Gst_amount += ConvertTO.Decimal(vlist[r].Gst_total);
            }

            txt_purchase_total.Text = ConvertTO.Decimal2d(_Purchase_amount.ToString());
            txt_purchase_gst_total.Text = ConvertTO.Decimal2d(_Purchase_Gst_amount.ToString());
        }

        #endregion[load Purchase]

        #region[Search event]
        private void Search_party_TextChanged(object sender, EventArgs e)
        {
            Month obj = CMonth_exten.SearchName(Txt_month.Text, new DAL());

            txt_from_date.Text = ConvertTO.Date2S(obj.Month_starts.ToString());
            txt_to_date.Text = ConvertTO.Date2S(obj.Month_ends.ToString());

            list_GSTregister(action.Party);
        }
        //
        #endregion[Search event]

        #region[Month]

        public void Month_lookup()
        {
            Txt_month.LookupColNames = new string[] { MONTH.MONTH_NAME };
            Txt_month.LookupUpdate += Month_LookupUpdate;
        }
        void Month_LookupUpdate(object sender, EventArgs e)
        {
            Txt_month.LookupList = CMonth_exten.GetforLookup(new DAL());

        }
        #endregion[Month]


    }//cls 
}//ns 
