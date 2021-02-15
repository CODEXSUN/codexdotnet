using System;
using CXCORE;
using CXLIB;

namespace CXSETUP.Create_Setup.Base
{
    class CoreSetup
    {

        private static string screenText;
        public static event EventHandler Processing = null;

        public static void Install(Setup obj)
        {

            #region[Version]

            new Version_Tbl(obj.Database);

            screenText = "Installed Version Table";
            Processing(null, null);

            Version_Tbl.InsertDefault_Version(obj.Database);

            screenText = "Insert Version data";
            Processing(null, null);

            #endregion[Version]

            #region[Role]

            new Role_Tbl(obj.Database);

            screenText = "Installed Role Table";
            Processing(null, null);

            Role_Tbl.InsertDefault_Role(obj.Database);

            screenText = "Insert Role data";
            Processing(null, null);

            #endregion[Role]

            #region[User]

            new User_Tbl(obj.Database);

            screenText = "Installed User Table";
            Processing(null, null);

            User_Tbl.InsertDefault_User(obj.Database);

            screenText = "Insert User data";
            Processing(null, null);

            #endregion[User]

            #region[City]

            new City_Tbl(obj.Database);

            screenText = "Installed City Table";
            Processing(null, null);

            City_Tbl.InsertDefault_City(obj.Database);

            screenText = "Insert City data";
            Processing(null, null);

            #endregion[City]

            #region[State]

            new State_Tbl(obj.Database);

            screenText = "Installed State Table";
            Processing(null, null);

            State_Tbl.InsertDefault_State(obj.Database);

            screenText = "Insert State data";
            Processing(null, null);

            #endregion[State]

            #region[Country]

            new Country_Tbl(obj.Database);

            screenText = "Installed Country Table";
            Processing(null, null);

            Country_Tbl.InsertDefault_Country(obj.Database);

            screenText = "Insert Country data";
            Processing(null, null);

            #endregion[Country]

            #region[Pincode]

            new Pincode_Tbl(obj.Database);

            screenText = "Installed Pincode Table";
            Processing(null, null);

            Pincode_Tbl.InsertDefault_Pincode(obj.Database);

            screenText = "Insert Pincode data";
            Processing(null, null);

            #endregion[Pincode]

            #region[Company]

            new Company_Tbl(obj.Database);

            screenText = "Installed Company Table";
            Processing(null, null);

            Company_Tbl.InsertDefault_Company(obj.Database, obj.Company, obj.Displayname);

            screenText = "Insert Company data";
            Processing(null, null);

            #endregion[Company]

            #region[ACY]

            new Acy_Tbl(obj.Database);

            screenText = "Installed ACY Table";
            Processing(null, null);

            Acy_Tbl.InsertDefault_Acy(obj.Database);

            screenText = "Insert ACY data";
            Processing(null, null);

            #endregion[ACY]

            #region[Default Company]

            new Defaultcompany_Tbl(obj.Database);

            screenText = "Installed DefaultCompany Table";
            Processing(null, null);

            Defaultcompany_Tbl.InsertDefault_Defaultcompany(obj.Database);

            screenText = "Insert Default company data";
            Processing(null, null);

            #endregion[Default Company]

            #region[Default Login]

            new Defaultlogin_Tbl(obj.Database);

            screenText = "Installed DefaultLogin Table";
            Processing(null, null);

            Defaultlogin_Tbl.InsertDefault_Defaultlogin(obj.Database);

            screenText = "Insert Default login data";
            Processing(null, null);

            #endregion[Default Login]

            #region[Contact type]

            new Contacttype_Tbl(obj.Database);

            screenText = "Installed Contacttype Table";
            Processing(null, null);

            Contacttype_Tbl.InsertDefault_Contacttype(obj.Database);

            screenText = "Insert Contact type data";
            Processing(null, null);

            #endregion[Contact type]

            #region[Party]

            new Party_Tbl(obj.Database);

            screenText = "Installed Party Table";
            Processing(null, null);

            Party_Tbl.InsertDefault_Party(obj.Database);

            screenText = "Insert Party data";
            Processing(null, null);

            #endregion[Party]

            #region[Product type]

            new Producttype_Tbl(obj.Database);

            screenText = "Installed Product Type Table";
            Processing(null, null);

            Producttype_Tbl.InsertDefault_Producttype(obj.Database);

            screenText = "Insert Product type data";
            Processing(null, null);

            #endregion[Product type]

            #region[Hsn code]

            new Hsncode_Tbl(obj.Database);

            screenText = "Installed HSN Code Table";
            Processing(null, null);

            Hsncode_Tbl.InsertDefault_Hsncode(obj.Database);

            screenText = "Insert Hsn code data";
            Processing(null, null);

            #endregion[Hsn code]

            #region[Unit]

            new Unit_Tbl(obj.Database);

            screenText = "Installed Units Table";
            Processing(null, null);

            Unit_Tbl.InsertDefault_Unit(obj.Database);

            screenText = "Insert Unit data";
            Processing(null, null);

            #endregion[Unit]

            #region[Product]

            new Product_Tbl(obj.Database);

            screenText = "Installed Product Table";
            Processing(null, null);

            Product_Tbl.InsertDefault_Product(obj.Database);

            screenText = "Insert Product data";
            Processing(null, null);

            #endregion[Product]

            #region[Ledger Group]

            new Ledgergroup_Tbl(obj.Database);

            screenText = "Installed Ledger Group Table";
            Processing(null, null);

            Ledgergroup_Tbl.InsertDefault_Ledgergroup(obj.Database);

            screenText = "Insert Ledger group data";
            Processing(null, null);

            #endregion[Ledger Group]

            #region[Ledger]

            new Ledger_Tbl(obj.Database);

            screenText = "Installed Ledger Table";
            Processing(null, null);

            Ledger_Tbl.InsertDefault_Ledger(obj.Database);

            screenText = "Insert Ledger data";
            Processing(null, null);

            #endregion[Ledger]

            #region[Taxtype]

            new Taxtype_Tbl(obj.Database);

            screenText = "Installed Tax Type Table";
            Processing(null, null);

            Taxtype_Tbl.InsertDefault_Taxtype(obj.Database);

            screenText = "Insert Tax type data";
            Processing(null, null);

            #endregion[Taxtype]

            #region[Sales Type]

            new Salestype_Tbl(obj.Database);

            screenText = "Installed Sales Type Table";
            Processing(null, null);

            Salestype_Tbl.InsertDefault_Salestype(obj.Database);

            screenText = "Insert Sales type data";
            Processing(null, null);

            #endregion[Sales Type]

            #region[Transport]

            new Transport_Tbl(obj.Database);

            screenText = "Installed Transport Table";
            Processing(null, null);

            Transport_Tbl.InsertDefault_Transport(obj.Database);

            screenText = "Insert Transport data";
            Processing(null, null);

            #endregion[Transport]

            #region[Delivered to]

            new Deliveredto_Tbl(obj.Database);

            screenText = "Installed Delivered to Table";
            Processing(null, null);

            Deliveredto_Tbl.InsertDefault_Deliveredto(obj.Database);

            screenText = "Insert Delivered to data";
            Processing(null, null);

            #endregion[Delivered to]

            #region[Sizes]

            new Sizes_Tbl(obj.Database);

            screenText = "Installed Sizes Table";
            Processing(null, null);

            Sizes_Tbl.InsertDefault_Sizes(obj.Database);

            screenText = "Insert Sizes data";
            Processing(null, null);

            #endregion[Sizes]

            #region[Colours]

            new Colours_Tbl(obj.Database);

            screenText = "Installed Colours Table";
            Processing(null, null);

            Colours_Tbl.InsertDefault_Colours(obj.Database);

            screenText = "Insert Colours data";
            Processing(null, null);

            #endregion[Colours]

            #region[Bank]

            new Bank_Tbl(obj.Database);

            screenText = "Installed Bank Table";
            Processing(null, null);

            Bank_Tbl.InsertDefault_Bank(obj.Database);

            screenText = "Insert Bank data";
            Processing(null, null);

            #endregion[Bank]

            #region[Receipt type]

            new Receipttype_Tbl(obj.Database);

            screenText = "Installed Receipt Type Table";
            Processing(null, null);

            Receipttype_Tbl.InsertDefault_Receipttype(obj.Database);

            screenText = "Insert Receipt type data";
            Processing(null, null);

            #endregion[Receipt type]

            #region[Order type]

            new Ordertype_Tbl(obj.Database);

            screenText = "Installed Order Type Table";
            Processing(null, null);

            Ordertype_Tbl.InsertDefault_Ordertype(obj.Database);

            screenText = "Insert Order type data";
            Processing(null, null);

            #endregion[Order type]

            #region[Month]

            new Month_Tbl(obj.Database);

            screenText = "Installed Month Table";
            Processing(null, null);

            Month_Tbl.InsertDefault_Month(obj.Database);

            screenText = "Insert Month data";
            Processing(null, null);

            #endregion[Month type]

            #region[Bundle]

            new Bundle_Tbl(obj.Database);

            screenText = "Installed Bundle Table";
            Processing(null, null);

            Bundle_Tbl.InsertDefault_Bundle(obj.Database);

            screenText = "Insert Bundle data";
            Processing(null, null);

            #endregion[Month type]
        }
    }
}
