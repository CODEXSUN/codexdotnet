using System;
using System.Configuration;

namespace CXLIB
{
    public class Server
    {
        public static string DBSERVER { get; set; } = ConfigurationManager.AppSettings["DBSERVER"] + "";
        public static string DBHOST { get; set; } = ConfigurationManager.AppSettings["DBHOST"] + "";
        public static string DBNAME { get; set; } = ConfigurationManager.AppSettings["DBNAME"] + "";
        public static string DBUSER { get; set; } = "root";
        public static string DBPASS { get; set; } = "Computer.1";




        public static string DBSERVER_WEB { get; set; } = "";//ConfigurationManager.AppSettings["DBSERVER"] + "";
        public static string DBHOST_WEB { get; set; } = "43.255.154.111"; //ConfigurationManager.AppSettings["DBHOST"] + "";
        public static string DBNAME_WEB { get; set; } = "CODEXSUN_DB";// ConfigurationManager.AppSettings["DBNAME"] + "";
        public static string DBUSER_WEB { get; set; } = "CODEXSUN_USER";
        public static string DBPASS_WEB { get; set; } = "Codexsun1**";







        public static string UPDATEURL { get; set; } = ConfigurationManager.AppSettings["UPDATEURL"] + "";
        public static string BACKUPPATH { get; set; } = ConfigurationManager.AppSettings["BACKUPPATH"] + "";

        public static string SOFTWARETYPE { get; set; } = ConfigurationManager.AppSettings["SOFTWARETYPE"] + "";

        public static string DBIntegratedSecurity { get; set; } = "false";

        public static string DBBACKUPPATH { get; set; } = "";

    }
}
