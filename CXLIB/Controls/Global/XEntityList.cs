//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CXLIB
//{
//  public class DataTable
//    {
//        private XDictionary<object, XEntity> fDict = new XDictionary<object, XEntity>();

//        //-- TODO: Allow Empty pkName : set AutoPk flag; use f_Seq as the key.
//        private bool f_AutoPk = false;
//        private int f_Seq = 0;

//        public DataTable(string pPkName)
//        {
//            if (pPkName.Trim() == "")
//            {
//                //--ak: throw new Exception("DataTable:DataTable(pPkName) => PkName is empty.");
//                f_AutoPk = true;
//                pPkName = "TEMP_AUTO_PK";
//            }
//            ///
//            fPkName = pPkName;
//        }

//        private string fPkName;
//        ///
//        public string PkName
//        {
//            get { return fPkName; }
//        }
        

//        public void Add(XEntity pEntity)
//        {
//            if (f_AutoPk == true)
//            {
//                f_Seq++;
//                pEntity.PkValue = f_Seq;
//            }
//            fDict.Add(pEntity.PkValue, pEntity);
//        }

//        public void Insert(int pIndex, XEntity pEntity)
//        {
//            if (f_AutoPk == true)
//            {
//                f_Seq++;
//                pEntity.PkValue = f_Seq;
//            }
//            fDict.Insert(pIndex, pEntity.PkValue, pEntity);
//        }

//        public void Append(XEntity pEntity)
//        {
//            if (f_AutoPk == true)
//            {
//                f_Seq++;
//                pEntity.PkValue = f_Seq;
//            }
//            fDict.Add(pEntity.PkValue, pEntity);
//        }

//        public void Append(DataTable pList)
//        {
//            for (int r = 0; r <= pList.Count - 1; r++)
//            {
//                XEntity vEntity = pList.Item(r);
//                fDict.Add(vEntity.PkValue, vEntity);
//            }
//        }
//        public int Count
//        {
//            get
//            {
//                return fDict.Count;
//            }
//        }

//        public void Remove(int pIndex)
//        {
//            fDict.Remove(pIndex);
//        }

//        public void Remove(object pKey)
//        {
//            fDict.Remove(pKey);
//        }

//        public void Remove(XEntity pEntity)
//        {
//            fDict.Remove(pEntity.PkValue);
//        }


//        //== TO GET NTT BY INDEX.
//        public XEntity Item(int pIndex)
//        {
//            XEntity vEntity = fDict[pIndex];
//            return vEntity;
//        }

//        //== TO GET ENTITY BY KEY.
//        public XEntity Item(object pKey)
//        {
//            XEntity vEntity = fDict[pKey];
//            return vEntity;
//        }

//        //== FIND THE INDEX
//        public int IndexOf(XEntity pEntity)
//        {
//            return fDict.IndexOf(pEntity);
//        }

//    }//cls
//}//ns
