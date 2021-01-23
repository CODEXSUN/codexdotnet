//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CXLIB
//{
//    public class XEntity
//    {
//        private List<string> fColumns = new List<string>();

//        private Dictionary<string, object> fValues = new Dictionary<string, object>();

//        private string fPkName;


//        public XEntity(string pPkName)
//        {
//            if (pPkName.Trim() == "")
//            {
//                //--ak: throw new Exception("XEntity:XEntity(pPkName) => PkName is empty.");
//            }
//            ///
//            fPkName = pPkName;
//        }

//        public string PkName
//        {
//            get
//            {
//                return fPkName;
//            }
//        }
//        ///
//        public object PkValue
//        {
//            get
//            {
//                object vPkValue = this.Get(fPkName);
//                return vPkValue;
//            }
//            set
//            {
//                object vPkValue = value;
//                this.Set(fPkName, vPkValue);
//            }
//        }

//        public void Add(string pName, object pValue)
//        {
//            if (fValues.ContainsKey(pName) == true)
//            {
//                throw new Exception(string.Format("XEntity:Add() => Column name [{0}] is already added. Duplicates not allowed.", pName));
//            }
//            ///
//            fColumns.Add(pName);
//            fValues.Add(pName, pValue);
//        }

//        public List<string> Columns
//        {
//            get { return fColumns; }
//        }

//        public bool ContainsColumn(string pName)
//        {
//            return fValues.ContainsKey(pName);
//        }

//        public void Set(string pName, object pValue)
//        {
//            if (fValues.ContainsKey(pName) == false)
//            {
//                if (pName == fPkName)
//                {
//                    this.Add(fPkName, pValue);
//                }
//                else
//                {
//                    throw new Exception(string.Format("XEntity:Set() => Column name [{0}] is not already added.", pName));
//                }
//            }
//            ///
//            fValues[pName] = pValue;
//        }

//        public object Get(string pName)
//        {
//            if (fValues.ContainsKey(pName) == false)
//            {
//               // throw new Exception(string.Format("XEntity:Get() => Column name [{0}] does not exist.", pName));
//            }
//            ///
//            object vValue = fValues[pName];
//            return vValue;
//        }

//        /*
//        object[,] vValues = {   
//                                { ReceiptAllocColumns.SALE_INV_ID, SaleInvID }, 
//                                { ReceiptAllocColumns.PENDING_AMOUNT, PendingAmount} 
//                            };
//        */
//        public void AddValues(object[,] pValues)
//        {
//            for (int r = 0; r < pValues.GetLength(0); r++)
//            {
//                string vName = (string)pValues[r, 0];
//                object vValue = pValues[r, 1];
//                this.Add(vName, vValue);
//            }
//        }


//        public XEntity Clone()
//        {
//            XEntity xeClone = new XEntity(this.PkName);
//            foreach (string vColName in fColumns)
//            {
//                object vColValue = fValues[vColName];
//                xeClone.Add(vColName, vColValue);
//            }
//            return xeClone;
//        }

//        public XEntity CloneAsNew()
//        {
//            XEntity xeClone = new XEntity(this.PkName);
//            foreach (string vColName in fColumns)
//            {
//                object vColValue = null;
//                xeClone.Add(vColName, vColValue);
//            }
//            return xeClone;
//        }

//    }//cls
//}//ns
