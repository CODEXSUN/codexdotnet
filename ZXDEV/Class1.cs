﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZXDEV
{
    class Class1
    {

        public void tallyexport()
        {

            try
            {

                xmlstc = xmlstc + "<VOUCHER VCHTYPE=" + "\"" + "Receipt" + "\" ACTION=" + "\"" + "Create" + "\">";
                xmlstc = "<ENVELOPE>";
                xmlstc = xmlstc + "<HEADER>";
                xmlstc = xmlstc + "<TALLYREQUEST>Import Data</TALLYREQUEST>";
                xmlstc = xmlstc + "</HEADER>";
                xmlstc = xmlstc + "<BODY>";
                xmlstc = xmlstc + "<IMPORTDATA>";
                xmlstc = xmlstc + "<REQUESTDESC>";
                xmlstc = xmlstc + "<REPORTNAME>Vouchers</REPORTNAME>";
                xmlstc = xmlstc + "<STATICVARIABLES>";
                xmlstc = xmlstc + "<SVCURRENTCOMPANY>" + "##SVCURRENTCOMPANY" + "</SVCURRENTCOMPANY>";
                xmlstc = xmlstc + "</STATICVARIABLES>";
                xmlstc = xmlstc + "</REQUESTDESC>";

                xmlstc = xmlstc + "<REQUESTDATA>";


                strVchNumber = txtVhrNo.Text;
                //strDate = "01/04/2020";
                strDate = dtpDate.Value.Date.ToShortDateString();
                strNarration = txtName.Text;
                strAmount = txtAmount.Text;

                xmlstc = xmlstc + "<TALLYMESSAGE >";
                xmlstc = xmlstc + "<VOUCHER VCHTYPE=" + "\"" + "Receipt" + "\" ACTION=" + "\"" + "Create" + "\">";
                xmlstc = xmlstc + "<VOUCHERNUMBER>" + strVchNumber + "</VOUCHERNUMBER>";
                xmlstc = xmlstc + "<DATE>" + strDate + "</DATE>";
                xmlstc = xmlstc + "<EFFECTIVEDATE>" + strDate + "</EFFECTIVEDATE>";
                xmlstc = xmlstc + "<NARRATION>" + strNarration + "</NARRATION>";
                xmlstc = xmlstc + "<VOUCHERTYPENAME>" + strVchType + "</VOUCHERTYPENAME>";

                //Credit Ledger
                xmlstc = xmlstc + "<ALLLEDGERENTRIES.LIST>";
                xmlstc = xmlstc + "<LEDGERNAME>" + "Tution Fees - D&apos;Ring" + "</LEDGERNAME>";
                xmlstc = xmlstc + "<ISDEEMEDPOSITIVE>No</ISDEEMEDPOSITIVE>";
                xmlstc = xmlstc + "<AMOUNT>" + strAmount + "</AMOUNT>";
                xmlstc = xmlstc + "</ALLLEDGERENTRIES.LIST>";

                //Debit Ledger
                xmlstc = xmlstc + "<ALLLEDGERENTRIES.LIST>";
                xmlstc = xmlstc + "<LEDGERNAME>" + "Tution Fees - D&apos;Ring" + "</LEDGERNAME>";
                xmlstc = xmlstc + "<ISDEEMEDPOSITIVE>Yes</ISDEEMEDPOSITIVE>";
                xmlstc = xmlstc + "<AMOUNT>-" + strAmount + "</AMOUNT>";
                xmlstc = xmlstc + "</ALLLEDGERENTRIES.LIST>";

                xmlstc = xmlstc + "</VOUCHER>";
                xmlstc = xmlstc + "</TALLYMESSAGE>";
                xmlstc = xmlstc + "</REQUESTDATA>";
                xmlstc = xmlstc + "</IMPORTDATA>";
                xmlstc = xmlstc + "</BODY>";
                xmlstc = xmlstc + "</ENVELOPE>";



                string result = "";


                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:9000");
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentLength = xmlstc.Length;
                httpWebRequest.ContentType = "application/x-www-form-urlencoded";

                streamWriter = new StreamWriter(httpWebRequest.GetRequestStream());
                streamWriter.Write(xmlstc);
                MessageBox.Show("Data inserted into Tally sucessfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
            finally
            {
                streamWriter.Close();
            }
        }
    }
}
