// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 10-08-2020 06:41:07 AM

using System; 
 using Microsoft.VisualStudio.TestTools.UnitTesting; 
 using System.Collections.Generic; 
 using System.Data; 
 using CXCORE; 
 using CXLIB; 
 
namespace CXTEST
{
    [TestClass] 
     public class TestCash_payment 
     { 
  
         [TestMethod] 
         public void Cash_paymentTest() 
         { 
  
             #region[Insert] 
  
             Cash_payment obj = new Cash_payment() 
             { 
                 Cash_payment_id = "", 
                 Order_id = "1", 
                 Payment_date = "'2020-08-10'", 
                 Ledger_id = "1", 
                 Purpose = "00", 
                 Party_id = "1", 
                 Payment_amount = "1.03", 
                 Notes = Core.EmptyNotes, 
                 Active_id = Core.Active, 
                 User_id = Current.Codexsun 
             }; 
  
             CCash_payment.Insert(obj, new DAL()); 
  
             #endregion[Insert] 
  
             #region[search names & pkid] 
  
             Cash_payment obj1 = CCash_payment_exten.SearchName(obj.Cash_payment_name, new DAL()); 
  
             Cash_payment obj2 = CCash_payment_exten.PKId(obj1.Cash_payment_id, new DAL()); 
  
             Assert.AreEqual(obj.Order_id, obj2.Order_id); 
             Assert.AreEqual(obj.Payment_date, obj2.Payment_date); 
             Assert.AreEqual(obj.Ledger_id, obj2.Ledger_id); 
             Assert.AreEqual(obj.Purpose, obj2.Purpose); 
             Assert.AreEqual(obj.Party_id, obj2.Party_id); 
             Assert.AreEqual(obj.Payment_amount, obj2.Payment_amount); 
             Assert.AreEqual(obj.Notes, obj2.Notes); 
             Assert.AreEqual(obj.Active_id, obj2.Active_id); 
             Assert.AreEqual(CUser_exten.GetName_Id(obj.User_id), obj2.User_id); 
  
  
             #endregion[search names & pkid] 
  
             #region[Update] 
  
             obj.Cash_payment_id = obj2.Cash_payment_id; 
                 obj.Order_id = "00"; 
                 obj.Payment_date = "'2020-08-10'"; 
                 obj.Ledger_id = "00"; 
                 obj.Purpose = "00"; 
                 obj.Party_id = "00"; 
                 obj.Payment_amount = "1.23"; 
             obj.Notes = "test notes"; 
             obj.Active_id = Core.NotActive; 
             obj.User_id = Current.Codexsun; 
  
             CCash_payment.Update(obj, new DAL()); 
  
             obj1 = CCash_payment_exten.SearchName(obj.Cash_payment_name, new DAL()); 
  
             obj2 = CCash_payment_exten.PKId(obj1.Cash_payment_id, new DAL()); 
  
             Assert.AreEqual(obj.Cash_payment_id, obj2.Cash_payment_id); 
             Assert.AreEqual(obj.Order_id, obj2.Order_id); 
             Assert.AreEqual(obj.Payment_date, obj2.Payment_date); 
             Assert.AreEqual(obj.Ledger_id, obj2.Ledger_id); 
             Assert.AreEqual(obj.Purpose, obj2.Purpose); 
             Assert.AreEqual(obj.Party_id, obj2.Party_id); 
             Assert.AreEqual(obj.Payment_amount, obj2.Payment_amount); 
             Assert.AreEqual(obj.Notes, obj2.Notes); 
             Assert.AreEqual(obj.Active_id, obj2.Active_id); 
             Assert.AreEqual(CUser_exten.GetName_Id(obj.User_id), obj2.User_id); 
  
             #endregion[Update] 
  
             #region[delete] 
  
             CCash_payment.Delete(obj.Cash_payment_id, new DAL()); 
  
             obj2 = CCash_payment_exten.PKId(obj1.Cash_payment_id, new DAL()); 
  
             Assert.AreEqual(null, obj2.Cash_payment_id); 
  
             #endregion[delete] 
  
             #region[active] 
  
             obj = new Cash_payment() 
             { 
             Cash_payment_id = "", 
             Order_id = "00", 
             Payment_date = "'2020-08-10'", 
             Ledger_id = "00", 
             Purpose = "00", 
             Party_id = "00", 
             Payment_amount = "1.23", 
             Notes = Core.EmptyNotes, 
             Active_id = Core.Active, 
             User_id = Current.Codexsun 
             }; 
  
             CCash_payment.Insert(obj, new DAL()); 
  
             obj1 = CCash_payment_exten.SearchName(obj.Cash_payment_name, new DAL()); 
  
             obj2 = CCash_payment_exten.PKId(obj1.Cash_payment_id, new DAL()); 
  
             List<Cash_payment> list = CCash_payment_exten.Active(new DAL()); 
  
 
             if (list.Count != 0)
             {
                 for (int i = 0; i < list.Count; i++)
                 {
                     Assert.AreEqual(Core.Active, list[i].Active_id); 
                 }
             }
  
             #endregion[Active] 
  
             #region[Not Active] 
  
             obj.Cash_payment_id = obj1.Cash_payment_id; 
             obj.Order_id = "00"; 
             obj.Payment_date = "'2020-08-10'"; 
             obj.Ledger_id = "00"; 
             obj.Purpose = "00"; 
             obj.Party_id = "00"; 
             obj.Payment_amount = "1.23"; 
             obj.Notes = "test notes"; 
             obj.Active_id = Core.NotActive; 
             obj.User_id = Current.Codexsun; 
  
             CCash_payment.Update(obj, new DAL()); 
  
             list = CCash_payment_exten.NotActive(new DAL()); 
  
 
             if (list.Count != 0)
             {
                 for (int i = 0; i < list.Count; i++)
                 {
                     Assert.AreEqual(Core.NotActive, list[i].Active_id); 
                 }
             }
 
             #endregion[Not Active] 
  
             #region[Lookup] 
  
             obj.Cash_payment_id = obj1.Cash_payment_id; 
             obj.Order_id = "00"; 
             obj.Payment_date = "'2020-08-10'"; 
             obj.Ledger_id = "00"; 
             obj.Purpose = "00"; 
             obj.Party_id = "00"; 
             obj.Payment_amount = "1.25"; 
             obj.Notes = "test notes"; 
             obj.Active_id = Core.Active; 
             obj.User_id = Current.Codexsun; 
  
             CCash_payment.Update(obj, new DAL()); 
  
             DataTable tbl = CCash_payment_exten.GetforLookup(new DAL()); 
  
 
             if (list.Count != 0)
             {
                 for (int i = 0; i < list.Count; i++)
                 {
                     Assert.AreEqual(Core.Active, (tbl.Rows[i][COUNTRY.ACTIVE_ID]) + ""); 
                 }
             }
 
             #endregion[Lookup] 
  
             #region[Get id name] 
 
             Assert.AreEqual(CCash_payment_exten.GetId_Name(obj.Cash_payment_name), obj.Cash_payment_id + ""); 
             Assert.AreEqual(CCash_payment_exten.GetName_Id(obj.Cash_payment_id), obj.Cash_payment_name + ""); 
 
             CCash_payment.Delete(obj.Cash_payment_id, new DAL());
 
             #endregion[Get id name] 
         } 
 
     }//cls
}//ns
