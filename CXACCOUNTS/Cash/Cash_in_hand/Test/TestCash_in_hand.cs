// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 09-08-2020 09:29:38 PM

using System; 
 using Microsoft.VisualStudio.TestTools.UnitTesting; 
 using System.Collections.Generic; 
 using System.Data; 
 using CXCORE; 
 using CXLIB; 
 
namespace CXTEST
{
    [TestClass] 
     public class TestCash_in_hand 
     { 
  
         [TestMethod] 
         public void Cash_in_handTest() 
         { 
  
             #region[Insert] 
  
             Cash_in_hand obj = new Cash_in_hand() 
             { 
                 Cash_in_hand_id = "", 
                 Entry_date = "'2020-08-09'", 
                 Cash_receipt_id = "1", 
                 Cash_payment_id = "1", 
                 Receipt_amount = "1.03", 
                 Payment_amount = "1.03", 
                 Balance_amount = "1.03", 
                 Notes = Core.EmptyNotes, 
                 Active_id = Core.Active, 
                 User_id = Current.Codexsun 
             }; 
  
             CCash_in_hand.Insert(obj, new DAL()); 
  
             #endregion[Insert] 
  
             #region[search names & pkid] 
  
             Cash_in_hand obj1 = CCash_in_hand_exten.SearchName(obj.Cash_in_hand_name, new DAL()); 
  
             Cash_in_hand obj2 = CCash_in_hand_exten.PKId(obj1.Cash_in_hand_id, new DAL()); 
  
             Assert.AreEqual(obj.Entry_date, obj2.Entry_date); 
             Assert.AreEqual(obj.Cash_receipt_id, obj2.Cash_receipt_id); 
             Assert.AreEqual(obj.Cash_payment_id, obj2.Cash_payment_id); 
             Assert.AreEqual(obj.Receipt_amount, obj2.Receipt_amount); 
             Assert.AreEqual(obj.Payment_amount, obj2.Payment_amount); 
             Assert.AreEqual(obj.Balance_amount, obj2.Balance_amount); 
             Assert.AreEqual(obj.Notes, obj2.Notes); 
             Assert.AreEqual(obj.Active_id, obj2.Active_id); 
             Assert.AreEqual(CUser_exten.GetName_Id(obj.User_id), obj2.User_id); 
  
  
             #endregion[search names & pkid] 
  
             #region[Update] 
  
             obj.Cash_in_hand_id = obj2.Cash_in_hand_id; 
                 obj.Entry_date = "'2020-08-09'"; 
                 obj.Cash_receipt_id = "00"; 
                 obj.Cash_payment_id = "00"; 
                 obj.Receipt_amount = "1.23"; 
                 obj.Payment_amount = "1.23"; 
                 obj.Balance_amount = "1.23"; 
             obj.Notes = "test notes"; 
             obj.Active_id = Core.NotActive; 
             obj.User_id = Current.Codexsun; 
  
             CCash_in_hand.Update(obj, new DAL()); 
  
             obj1 = CCash_in_hand_exten.SearchName(obj.Cash_in_hand_name, new DAL()); 
  
             obj2 = CCash_in_hand_exten.PKId(obj1.Cash_in_hand_id, new DAL()); 
  
             Assert.AreEqual(obj.Cash_in_hand_id, obj2.Cash_in_hand_id); 
             Assert.AreEqual(obj.Entry_date, obj2.Entry_date); 
             Assert.AreEqual(obj.Cash_receipt_id, obj2.Cash_receipt_id); 
             Assert.AreEqual(obj.Cash_payment_id, obj2.Cash_payment_id); 
             Assert.AreEqual(obj.Receipt_amount, obj2.Receipt_amount); 
             Assert.AreEqual(obj.Payment_amount, obj2.Payment_amount); 
             Assert.AreEqual(obj.Balance_amount, obj2.Balance_amount); 
             Assert.AreEqual(obj.Notes, obj2.Notes); 
             Assert.AreEqual(obj.Active_id, obj2.Active_id); 
             Assert.AreEqual(CUser_exten.GetName_Id(obj.User_id), obj2.User_id); 
  
             #endregion[Update] 
  
             #region[delete] 
  
             CCash_in_hand.Delete(obj.Cash_in_hand_id, new DAL()); 
  
             obj2 = CCash_in_hand_exten.PKId(obj1.Cash_in_hand_id, new DAL()); 
  
             Assert.AreEqual(null, obj2.Cash_in_hand_id); 
  
             #endregion[delete] 
  
             #region[active] 
  
             obj = new Cash_in_hand() 
             { 
             Cash_in_hand_id = "", 
             Entry_date = "'2020-08-09'", 
             Cash_receipt_id = "00", 
             Cash_payment_id = "00", 
             Receipt_amount = "1.23", 
             Payment_amount = "1.23", 
             Balance_amount = "1.23", 
             Notes = Core.EmptyNotes, 
             Active_id = Core.Active, 
             User_id = Current.Codexsun 
             }; 
  
             CCash_in_hand.Insert(obj, new DAL()); 
  
             obj1 = CCash_in_hand_exten.SearchName(obj.Cash_in_hand_name, new DAL()); 
  
             obj2 = CCash_in_hand_exten.PKId(obj1.Cash_in_hand_id, new DAL()); 
  
             List<Cash_in_hand> list = CCash_in_hand_exten.Active(new DAL()); 
  
 
             if (list.Count != 0)
             {
                 for (int i = 0; i < list.Count; i++)
                 {
                     Assert.AreEqual(Core.Active, list[i].Active_id); 
                 }
             }
  
             #endregion[Active] 
  
             #region[Not Active] 
  
             obj.Cash_in_hand_id = obj1.Cash_in_hand_id; 
             obj.Entry_date = "'2020-08-09'"; 
             obj.Cash_receipt_id = "00"; 
             obj.Cash_payment_id = "00"; 
             obj.Receipt_amount = "1.23"; 
             obj.Payment_amount = "1.23"; 
             obj.Balance_amount = "1.23"; 
             obj.Notes = "test notes"; 
             obj.Active_id = Core.NotActive; 
             obj.User_id = Current.Codexsun; 
  
             CCash_in_hand.Update(obj, new DAL()); 
  
             list = CCash_in_hand_exten.NotActive(new DAL()); 
  
 
             if (list.Count != 0)
             {
                 for (int i = 0; i < list.Count; i++)
                 {
                     Assert.AreEqual(Core.NotActive, list[i].Active_id); 
                 }
             }
 
             #endregion[Not Active] 
  
             #region[Lookup] 
  
             obj.Cash_in_hand_id = obj1.Cash_in_hand_id; 
             obj.Entry_date = "'2020-08-09'"; 
             obj.Cash_receipt_id = "00"; 
             obj.Cash_payment_id = "00"; 
             obj.Receipt_amount = "1.25"; 
             obj.Payment_amount = "1.25"; 
             obj.Balance_amount = "1.25"; 
             obj.Notes = "test notes"; 
             obj.Active_id = Core.Active; 
             obj.User_id = Current.Codexsun; 
  
             CCash_in_hand.Update(obj, new DAL()); 
  
             DataTable tbl = CCash_in_hand_exten.GetforLookup(new DAL()); 
  
 
             if (list.Count != 0)
             {
                 for (int i = 0; i < list.Count; i++)
                 {
                     Assert.AreEqual(Core.Active, (tbl.Rows[i][COUNTRY.ACTIVE_ID]) + ""); 
                 }
             }
 
             #endregion[Lookup] 
  
             #region[Get id name] 
 
             Assert.AreEqual(CCash_in_hand_exten.GetId_Name(obj.Cash_in_hand_name), obj.Cash_in_hand_id + ""); 
             Assert.AreEqual(CCash_in_hand_exten.GetName_Id(obj.Cash_in_hand_id), obj.Cash_in_hand_name + ""); 
 
             CCash_in_hand.Delete(obj.Cash_in_hand_id, new DAL());
 
             #endregion[Get id name] 
         } 
 
     }//cls
}//ns
