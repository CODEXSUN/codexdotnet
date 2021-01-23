using System.Collections.Generic;

namespace CXLIB
{
    ///==[ ACTS AS BOTH 'LIST' AND 'DICTIONARY'. ]=================================
    ///==[ ALLOWS DUPLICATE KEYS. ]================================================
    ///==[ This class allows duplicate keys; IndexOf() & this[key] & Remove() return/affect the first match only. ]==
    public class XDictionary<K, V>
    {
        private List<XKeyValuePair<K, V>> f_List = new List<XKeyValuePair<K, V>>();

        public void Add(K pKey, V pValue)
        {
            XKeyValuePair<K, V> kvp = new XKeyValuePair<K, V>(pKey, pValue);
            f_List.Add(kvp);
        }

        public void Insert(int pIndex, K pKey, V pValue)
        {
            XKeyValuePair<K, V> kvp = new XKeyValuePair<K, V>(pKey, pValue);
            f_List.Insert(pIndex, kvp);
        }

        public int Count
        {
            get
            {
                return f_List.Count;
            }
        }

        public V this[int i]
        {
            get
            {
                V val = f_List[i].Value;
                return val;
            }
        }

        public V this[K pKey] 
        {
            get
            {
                int vIdx = this.IndexOf(pKey);
                if (vIdx == -1)
                {
                    return default(V);
                }
                else
                {
                    V vValue = f_List[vIdx].Value;
                    return vValue;
                }
            }
        }

        public K Key(int i)
        {
            return f_List[i].Key;
        }

        public XKeyValuePair<K, V> KeyValuePair(int i)
        {
            return f_List[i];
        }

        public int IndexOf(K pKey)
        {
            for (int i = 0; i < f_List.Count; i++)
            {
                K vKey = f_List[i].Key;
                if (vKey.Equals(pKey))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool ContainsKey(K pKey)
        {
            int vIdx = this.IndexOf(pKey);
            if (vIdx == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Remove(int pIndex)
        {
            f_List.RemoveAt(pIndex);
        }

        public void Remove(K pKey)
        {
            int vIdx = this.IndexOf(pKey);
            this.Remove(vIdx);
        }

        public void MoveToLast(K pKey) 
        {
            /*MoveToLast() means MoveToTOP() for stack operation*/
            int vIdx = this.IndexOf(pKey);
            if (vIdx != f_List.Count - 1) //--if NOT last-item .. 
            {
                V vValue = this[vIdx];
                this.Remove(vIdx);
                this.Add(pKey, vValue);
            }
        }

        public XKeyValuePair<K, V> LastItem
        {
            /*LastItem means TOPItem() for stack operation*/
            get
            {
                if (f_List.Count == 0)
                {
                    return null;
                }
                else
                {
                    return f_List[f_List.Count - 1];
                }
            }
        }
    }//cls//

    ///===[ class XKeyValuePair<K, V> ]====================================================
    public class XKeyValuePair<K, V>
    {
        public K Key;
        public V Value;

        public XKeyValuePair(K pKey, V pValue)
        {
            Key = pKey;
            Value = pValue;
        }
    }//cls//


}//ns//
