// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 09-08-2020 09:29:47 PM

using System; 
 using Microsoft.VisualStudio.TestTools.UnitTesting; 
 using System.Collections.Generic; 
 using System.Data; 
 using CXCORE; 
 using CXLIB; 
 
namespace CXTEST
{
    [TestClass] 
     public class TestCash_receipt 
     { 
  
         [TestMethod] 
         public void Cash_receiptTest() 
         { 
  
             #region[Insert] 
  
             Cash_receipt obj = new Cash_receipt() 
             { 
                 Cash_receipt_id = "", 
                 Receipt_date = "'2020-08-09'", 
                 Party_id = "1", 
                 Purpose = "00", 
                 Receipt_amount = "1.03", 
                 Notes = Core.EmptyNotes, 
                 Active_id = Core.Active, 
                 User_id = Current.Codexsun 
             }; 
  
             CCash_receipt.Insert(obj, new DAL()); 
  
             #endregion[Insert] 
  
             #region[search names & pkid] 
  
             Cash_receipt obj1 = CCash_receipt_exten.SearchName(obj.Cash_receipt_name, new DAL()); 
  
             Cash_receipt obj2 = CCash_receipt_exten.PKId(obj1.Cash_receipt_id, new DAL()); 
  
             Assert.AreEqual(obj.Receipt_date, obj2.Receipt_date); 
             Assert.AreEqual(obj.Party_id, obj2.Party_id); 
             Assert.AreEqual(obj.Purpose, obj2.Purpose); 
             Assert.AreEqual(obj.Receipt_amount, obj2.Receipt_amount); 
             Assert.AreEqual(obj.Notes, obj2.Notes); 
             Assert.AreEqual(obj.Active_id, obj2.Active_id); 
             Assert.AreEqual(CUser_exten.GetName_Id(obj.User_id), obj2.User_id); 
  
  
             #endregion[search names & pkid] 
  
             #region[Update] 
  
             obj.Cash_receipt_id = obj2.Cash_receipt_id; 
                 obj.Receipt_date = "'2020-08-09'"; 
                 obj.Party_id = "00"; 
                 obj.Purpose = "00"; 
                 obj.Receipt_amount = "1.23"; 
             obj.Notes = "test notes"; 
             obj.Active_id = Core.NotActive; 
             obj.User_id = Current.Codexsun; 
  
             CCash_receipt.Update(obj, new DAL()); 
  
             obj1 = CCash_receipt_exten.SearchName(obj.Cash_receipt_name, new DAL()); 
  
             obj2 = CCash_receipt_exten.PKId(obj1.Cash_receipt_id, new DAL()); 
  
             Assert.AreEqual(obj.Cash_receipt_id, obj2.Cash_receipt_id); 
             Assert.AreEqual(obj.Receipt_date, obj2.Receipt_date); 
             Assert.AreEqual(obj.Party_id, obj2.Party_id); 
             Assert.AreEqual(obj.Purpose, obj2.Purpose); 
             Assert.AreEqual(obj.Receipt_amount, obj2.Receipt_amount); 
             Assert.AreEqual(obj.Notes, obj2.Notes); 
             Assert.AreEqual(obj.Active_id, obj2.Active_id); 
             Assert.AreEqual(CUser_exten.GetName_Id(obj.User_id), obj2.User_id); 
  
             #endregion[Update] 
  
             #region[delete] 
  
             CCash_receipt.Delete(obj.Cash_receipt_id, new DAL()); 
  
             obj2 = CCash_receipt_exten.PKId(obj1.Cash_receipt_id, new DAL()); 
  
             Assert.AreEqual(null, obj2.Cash_receipt_id); 
  
             #endregion[delete] 
  
             #region[active] 
  
             obj = new Cash_receipt() 
             { 
             Cash_receipt_id = "", 
             Receipt_date = "'2020-08-09'", 
             Party_id = "00", 
             Purpose = "00", 
             Receipt_amount = "1.23", 
             Notes = Core.EmptyNotes, 
             Active_id = Core.Active, 
             User_id = Current.Codexsun 
             }; 
  
             CCash_receipt.Insert(obj, new DAL()); 
  
             obj1 = CCash_receipt_exten.SearchName(obj.Cash_receipt_name, new DAL()); 
  
             obj2 = CCash_receipt_exten.PKId(obj1.Cash_receipt_id, new DAL()); 
  
             List<Cash_receipt> list = CCash_receipt_exten.Active(new DAL()); 
  
 
             if (list.Count != 0)
             {
                 for (int i = 0; i < list.Count; i++)
                 {
                     Assert.AreEqual(Core.Active, list[i].Active_id); 
                 }
             }
  
             #endregion[Active] 
  
             #region[Not Active] 
  
             obj.Cash_receipt_id = obj1.Cash_receipt_id; 
             obj.Receipt_date = "'2020-08-09'"; 
             obj.Party_id = "00"; 
             obj.Purpose = "00"; 
             obj.Receipt_amount = "1.23"; 
             obj.Notes = "test notes"; 
             obj.Active_id = Core.NotActive; 
             obj.User_id = Current.Codexsun; 
  
             CCash_receipt.Update(obj, new DAL()); 
  
             list = CCash_receipt_exten.NotActive(new DAL()); 
  
 
             if (list.Count != 0)
             {
                 for (int i = 0; i < list.Count; i++)
                 {
                     Assert.AreEqual(Core.NotActive, list[i].Active_id); 
                 }
             }
 
             #endregion[Not Active] 
  
             #region[Lookup] 
  
             obj.Cash_receipt_id = obj1.Cash_receipt_id; 
             obj.Receipt_date = "'2020-08-09'"; 
             obj.Party_id = "00"; 
             obj.Purpose = "00"; 
             obj.Receipt_amount = "1.25"; 
             obj.Notes = "test notes"; 
             obj.Active_id = Core.Active; 
             obj.User_id = Current.Codexsun; 
  
             CCash_receipt.Update(obj, new DAL()); 
  
             DataTable tbl = CCash_receipt_exten.GetforLookup(new DAL()); 
  
 
             if (list.Count != 0)
             {
                 for (int i = 0; i < list.Count; i++)
                 {
                     Assert.AreEqual(Core.Active, (tbl.Rows[i][COUNTRY.ACTIVE_ID]) + ""); 
                 }
             }
 
             #endregion[Lookup] 
  
             #region[Get id name] 
 
             Assert.AreEqual(CCash_receipt_exten.GetId_Name(obj.Cash_receipt_name), obj.Cash_receipt_id + ""); 
             Assert.AreEqual(CCash_receipt_exten.GetName_Id(obj.Cash_receipt_id), obj.Cash_receipt_name + ""); 
 
             CCash_receipt.Delete(obj.Cash_receipt_id, new DAL());
 
             #endregion[Get id name] 
         } 
 
     }//cls
}//ns
