// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 10-08-2020 10:29:15 AM

using System; 
 using Microsoft.VisualStudio.TestTools.UnitTesting; 
 using System.Collections.Generic; 
 using System.Data; 
 using CXCORE; 
 using CXLIB; 
 
namespace CXTEST
{
    [TestClass] 
     public class TestVersion 
     { 
  
         [TestMethod] 
         public void VersionTest() 
         { 
  
             #region[Insert] 
  
             Version obj = new Version() 
             { 
                 Version_id = "", 
                 Version_name = "00", 
                 Created_on = "'2020-08-10'", 
                 Changes = "00", 
                 Notes = Core.EmptyNotes, 
                 Active_id = Core.Active, 
                 User_id = Current.Codexsun 
             }; 
  
             CVersion.Insert(obj, new DAL()); 
  
             #endregion[Insert] 
  
             #region[search names & pkid] 
  
             Version obj1 = CVersion_exten.SearchName(obj.Version_name, new DAL()); 
  
             Version obj2 = CVersion_exten.PKId(obj1.Version_id, new DAL()); 
  
             Assert.AreEqual(obj.Version_name, obj2.Version_name); 
             Assert.AreEqual(obj.Created_on, obj2.Created_on); 
             Assert.AreEqual(obj.Changes, obj2.Changes); 
             Assert.AreEqual(obj.Notes, obj2.Notes); 
             Assert.AreEqual(obj.Active_id, obj2.Active_id); 
             Assert.AreEqual(CUser_exten.GetName_Id(obj.User_id), obj2.User_id); 
  
  
             #endregion[search names & pkid] 
  
             #region[Update] 
  
             obj.Version_id = obj2.Version_id; 
                 obj.Version_name = "00"; 
                 obj.Created_on = "'2020-08-10'"; 
                 obj.Changes = "00"; 
             obj.Notes = "test notes"; 
             obj.Active_id = Core.NotActive; 
             obj.User_id = Current.Codexsun; 
  
             CVersion.Update(obj, new DAL()); 
  
             obj1 = CVersion_exten.SearchName(obj.Version_name, new DAL()); 
  
             obj2 = CVersion_exten.PKId(obj1.Version_id, new DAL()); 
  
             Assert.AreEqual(obj.Version_id, obj2.Version_id); 
             Assert.AreEqual(obj.Version_name, obj2.Version_name); 
             Assert.AreEqual(obj.Created_on, obj2.Created_on); 
             Assert.AreEqual(obj.Changes, obj2.Changes); 
             Assert.AreEqual(obj.Notes, obj2.Notes); 
             Assert.AreEqual(obj.Active_id, obj2.Active_id); 
             Assert.AreEqual(CUser_exten.GetName_Id(obj.User_id), obj2.User_id); 
  
             #endregion[Update] 
  
             #region[delete] 
  
             CVersion.Delete(obj.Version_id, new DAL()); 
  
             obj2 = CVersion_exten.PKId(obj1.Version_id, new DAL()); 
  
             Assert.AreEqual(null, obj2.Version_id); 
  
             #endregion[delete] 
  
             #region[active] 
  
             obj = new Version() 
             { 
             Version_id = "", 
             Version_name = "00", 
             Created_on = "'2020-08-10'", 
             Changes = "00", 
             Notes = Core.EmptyNotes, 
             Active_id = Core.Active, 
             User_id = Current.Codexsun 
             }; 
  
             CVersion.Insert(obj, new DAL()); 
  
             obj1 = CVersion_exten.SearchName(obj.Version_name, new DAL()); 
  
             obj2 = CVersion_exten.PKId(obj1.Version_id, new DAL()); 
  
             List<Version> list = CVersion_exten.Active(new DAL()); 
  
 
             if (list.Count != 0)
             {
                 for (int i = 0; i < list.Count; i++)
                 {
                     Assert.AreEqual(Core.Active, list[i].Active_id); 
                 }
             }
  
             #endregion[Active] 
  
             #region[Not Active] 
  
             obj.Version_id = obj1.Version_id; 
             obj.Version_name = "00"; 
             obj.Created_on = "'2020-08-10'"; 
             obj.Changes = "00"; 
             obj.Notes = "test notes"; 
             obj.Active_id = Core.NotActive; 
             obj.User_id = Current.Codexsun; 
  
             CVersion.Update(obj, new DAL()); 
  
             list = CVersion_exten.NotActive(new DAL()); 
  
 
             if (list.Count != 0)
             {
                 for (int i = 0; i < list.Count; i++)
                 {
                     Assert.AreEqual(Core.NotActive, list[i].Active_id); 
                 }
             }
 
             #endregion[Not Active] 
  
             #region[Lookup] 
  
             obj.Version_id = obj1.Version_id; 
             obj.Version_name = "00"; 
             obj.Created_on = "'2020-08-10'"; 
             obj.Changes = "00"; 
             obj.Notes = "test notes"; 
             obj.Active_id = Core.Active; 
             obj.User_id = Current.Codexsun; 
  
             CVersion.Update(obj, new DAL()); 
  
             DataTable tbl = CVersion_exten.GetforLookup(new DAL()); 
  
 
             if (list.Count != 0)
             {
                 for (int i = 0; i < list.Count; i++)
                 {
                     Assert.AreEqual(Core.Active, (tbl.Rows[i][COUNTRY.ACTIVE_ID]) + ""); 
                 }
             }
 
             #endregion[Lookup] 
  
             #region[Get id name] 
 
             Assert.AreEqual(CVersion_exten.GetId_Name(obj.Version_name), obj.Version_id + ""); 
             Assert.AreEqual(CVersion_exten.GetName_Id(obj.Version_id), obj.Version_name + ""); 
 
             CVersion.Delete(obj.Version_id, new DAL());
 
             #endregion[Get id name] 
         } 
 
     }//cls
}//ns
