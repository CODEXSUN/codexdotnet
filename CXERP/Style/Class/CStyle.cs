// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 14-06-2019 09:02:20 PM

using CXLIB;

namespace CXERP
{
    public static class CArticle
    {

        #region[Get New]

        public static Article GetNew
        {
            get
            {
                Article obj = new Article()
                {
                    Article_id = string.Empty,
                    Uniqueno = string.Empty,
                    Company_id = Current.Company_id,
                    Acy_id = Current.Acy_id,
                    Article_no = string.Empty,
                    Article_date = string.Empty,
                    Locked = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Article v)
        {
            q = q.Replace("@" + ARTICLE.ARTICLE_ID + "@", "" + ConvertTO.SqlString(v.Article_id) + "");
            q = q.Replace("@" + ARTICLE.UNIQUENO + "@", "" + ConvertTO.SqlString(v.Uniqueno) + "");
            q = q.Replace("@" + ARTICLE.COMPANY_ID + "@", "" + ConvertTO.SqlString(v.Company_id) + "");
            q = q.Replace("@" + ARTICLE.ACY_ID + "@", "" + ConvertTO.SqlString(v.Acy_id) + "");
            q = q.Replace("@" + ARTICLE.ARTICLE_NO + "@", "" + ConvertTO.SqlString(v.Article_no) + "");
            q = q.Replace("@" + ARTICLE.ARTICLE_DATE + "@", "" + ConvertTO.SqlDate(v.Article_date) + "");
            q = q.Replace("@" + ARTICLE.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            q = q.Replace("@" + ARTICLE.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + ARTICLE.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + ARTICLE.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Article v, DAL dalsession)
        {
                string q = " INSERT INTO " + ARTICLE.ARTICLE_TBL + " ( ";
                q += " " + ARTICLE.UNIQUENO + "\r\n";
                q += "," + ARTICLE.COMPANY_ID + "\r\n";
                q += "," + ARTICLE.ACY_ID + "\r\n";
                q += "," + ARTICLE.ARTICLE_NO + " \r\n";
                q += "," + ARTICLE.ARTICLE_DATE + " \r\n";
                q += "," + ARTICLE.LOCKED + " \r\n";
                q += "," + ARTICLE.NOTES + " \r\n";
                q += "," + ARTICLE.ACTIVE_ID + " \r\n";
                q += "," + ARTICLE.USER_ID + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @" + ARTICLE.UNIQUENO + "@ \r\n";
                q += ", @" + ARTICLE.COMPANY_ID + "@ \r\n";
                q += ", @" + ARTICLE.ACY_ID + "@ \r\n";
                q += ", @"+ ARTICLE.ARTICLE_NO + "@ \r\n";
                q += ", @"+ ARTICLE.ARTICLE_DATE + "@ \r\n";
                q += ", @"+ ARTICLE.LOCKED + "@ \r\n";
                q += ", @"+ ARTICLE.NOTES + "@ \r\n";
                q += ", @"+ ARTICLE.ACTIVE_ID + "@ \r\n";
                q += ", @"+ ARTICLE.USER_ID + "@ \r\n";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Article v, DAL dalsession)
        {
                string q = "UPDATE " + ARTICLE.ARTICLE_TBL + " SET";
                q += " " + ARTICLE.UNIQUENO + " = @" + ARTICLE.UNIQUENO + "@ \r\n";
                q += "," + ARTICLE.COMPANY_ID + " = @" + ARTICLE.COMPANY_ID + "@ \r\n";
                q += "," + ARTICLE.ACY_ID + " = @" + ARTICLE.ACY_ID + "@ \r\n";
                q += "," + ARTICLE.ARTICLE_NO + " = @" + ARTICLE.ARTICLE_NO + "@ \r\n ";
                q += "," + ARTICLE.ARTICLE_DATE + " = @" + ARTICLE.ARTICLE_DATE + "@ \r\n ";
                q += "," + ARTICLE.LOCKED + " = @" + ARTICLE.LOCKED + "@ \r\n ";
                q += "," + ARTICLE.NOTES + " = @" + ARTICLE.NOTES + "@ \r\n ";
                q += "," + ARTICLE.ACTIVE_ID + " = @" + ARTICLE.ACTIVE_ID + "@ \r\n ";
                q += "," + ARTICLE.USER_ID + " = @" + ARTICLE.USER_ID + "@ \r\n ";
                q += "  WHERE " + ARTICLE.ARTICLE_ID + " = @" + ARTICLE.ARTICLE_ID + "@ ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + ARTICLE.ARTICLE_TBL+ " WHERE " + ARTICLE.ARTICLE_ID + " =  " + pkid +";");
        }
        #endregion[Delete]

    }//cls
}//ns
