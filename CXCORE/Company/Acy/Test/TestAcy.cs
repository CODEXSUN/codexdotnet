// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 07-08-2020 07:48:01 AM

using System; 
 using Microsoft.VisualStudio.TestTools.UnitTesting; 
 using System.Collections.Generic; 
 using System.Data; 
 using CXCORE; 
 using CXLIB; 
 
namespace CXTEST
{
    [TestClass] 
     public class TestAcy 
     { 
  
         [TestMethod] 
         public void AcyTest() 
         { 
  
             #region[Insert] 
  
             Acy obj = new Acy() 
             { 
                 Acy_id = "", 
                 Acy_name = "00", 
                 From_date = "'2020-08-07'", 
                 To_date = "'2020-08-07'", 
                 Notes = Core.EmptyNotes, 
                 Active_id = Core.Active, 
                 User_id = Current.Codexsun 
             }; 
  
             CAcy.Insert(obj, new DAL()); 
  
             #endregion[Insert] 
  
             #region[search names & pkid] 
  
             Acy obj1 = CAcy_exten.SearchName(obj.Acy_name, new DAL()); 
  
             Acy obj2 = CAcy_exten.PKId(obj1.Acy_id, new DAL()); 
  
             Assert.AreEqual(obj.Acy_name, obj2.Acy_name); 
             Assert.AreEqual(obj.From_date, obj2.From_date); 
             Assert.AreEqual(obj.To_date, obj2.To_date); 
             Assert.AreEqual(obj.Notes, obj2.Notes); 
             Assert.AreEqual(obj.Active_id, obj2.Active_id); 
             Assert.AreEqual(CUser_exten.GetName_Id(obj.User_id), obj2.User_id); 
  
  
             #endregion[search names & pkid] 
  
             #region[Update] 
  
             obj.Acy_id = obj2.Acy_id; 
                 obj.Acy_name = "00"; 
                 obj.From_date = "'2020-08-07'"; 
                 obj.To_date = "'2020-08-07'"; 
             obj.Notes = "test notes"; 
             obj.Active_id = Core.NotActive; 
             obj.User_id = Current.Codexsun; 
  
             CAcy.Update(obj, new DAL()); 
  
             obj1 = CAcy_exten.SearchName(obj.Acy_name, new DAL()); 
  
             obj2 = CAcy_exten.PKId(obj1.Acy_id, new DAL()); 
  
             Assert.AreEqual(obj.Acy_id, obj2.Acy_id); 
             Assert.AreEqual(obj.Acy_name, obj2.Acy_name); 
             Assert.AreEqual(obj.From_date, obj2.From_date); 
             Assert.AreEqual(obj.To_date, obj2.To_date); 
             Assert.AreEqual(obj.Notes, obj2.Notes); 
             Assert.AreEqual(obj.Active_id, obj2.Active_id); 
             Assert.AreEqual(CUser_exten.GetName_Id(obj.User_id), obj2.User_id); 
  
             #endregion[Update] 
  
             #region[delete] 
  
             CAcy.Delete(obj.Acy_id, new DAL()); 
  
             obj2 = CAcy_exten.PKId(obj1.Acy_id, new DAL()); 
  
             Assert.AreEqual(null, obj2.Acy_id); 
  
             #endregion[delete] 
  
             #region[active] 
  
             obj = new Acy() 
             { 
             Acy_id = "", 
             Acy_name = "00", 
             From_date = "'2020-08-07'", 
             To_date = "'2020-08-07'", 
             Notes = Core.EmptyNotes, 
             Active_id = Core.Active, 
             User_id = Current.Codexsun 
             }; 
  
             CAcy.Insert(obj, new DAL()); 
  
             obj1 = CAcy_exten.SearchName(obj.Acy_name, new DAL()); 
  
             obj2 = CAcy_exten.PKId(obj1.Acy_id, new DAL()); 
  
             List<Acy> list = CAcy_exten.Active(new DAL()); 
  
 
             if (list.Count != 0)
             {
                 for (int i = 0; i < list.Count; i++)
                 {
                     Assert.AreEqual(Core.Active, list[i].Active_id); 
                 }
             }
  
             #endregion[Active] 
  
             #region[Not Active] 
  
             obj.Acy_id = obj1.Acy_id; 
             obj.Acy_name = "00"; 
             obj.From_date = "'2020-08-07'"; 
             obj.To_date = "'2020-08-07'"; 
             obj.Notes = "test notes"; 
             obj.Active_id = Core.NotActive; 
             obj.User_id = Current.Codexsun; 
  
             CAcy.Update(obj, new DAL()); 
  
             list = CAcy_exten.NotActive(new DAL()); 
  
 
             if (list.Count != 0)
             {
                 for (int i = 0; i < list.Count; i++)
                 {
                     Assert.AreEqual(Core.NotActive, list[i].Active_id); 
                 }
             }
 
             #endregion[Not Active] 
  
             #region[Lookup] 
  
             obj.Acy_id = obj1.Acy_id; 
             obj.Acy_name = "00"; 
             obj.From_date = "'2020-08-07'"; 
             obj.To_date = "'2020-08-07'"; 
             obj.Notes = "test notes"; 
             obj.Active_id = Core.Active; 
             obj.User_id = Current.Codexsun; 
  
             CAcy.Update(obj, new DAL()); 
  
             DataTable tbl = CAcy_exten.GetforLookup(new DAL()); 
  
 
             if (list.Count != 0)
             {
                 for (int i = 0; i < list.Count; i++)
                 {
                     Assert.AreEqual(Core.Active, (tbl.Rows[i][COUNTRY.ACTIVE_ID]) + ""); 
                 }
             }
 
             #endregion[Lookup] 
  
             #region[Get id name] 
 
             Assert.AreEqual(CAcy_exten.GetId_Name(obj.Acy_name), obj.Acy_id + ""); 
             Assert.AreEqual(CAcy_exten.GetName_Id(obj.Acy_id), obj.Acy_name + ""); 
 
             CAcy.Delete(obj.Acy_id, new DAL());
 
             #endregion[Get id name] 
         } 
 
     }//cls
}//ns
