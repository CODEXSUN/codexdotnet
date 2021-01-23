using System;
using System.Drawing;
using System.IO;

namespace CXLIB
{
    /*
    BASE64 - means 0 to 63 - means 6 bits per number. 4 times 6 bits gives 24 bits i.e 3 bytes rounded (for 4 b64 chars).
        Therfore the output would be 3-folds of bytes. (3 ascii chars(3x8=24bits) you see in string is actually 4x6bits(=24bits))
        26(A-Z) + 26(a-z) + 10(0-9) + 1(+) + 1(/) = 64 + 1 valueless char(=)for trailing padding(last 2 or 1 char).
    */
    public static class Base64Util
    {
        //===[ Idenitfy MIME type ]==========================================================

        public static string GetMIMEType(string pImagePath)
        {
            string vImageExtn = pImagePath.Substring(pImagePath.LastIndexOf(".") + 1).ToLower();
            string vMIMEType = "";
            switch (vImageExtn)
            {
                case "bmp":
                    vMIMEType = "image/bmp";
                    break;
                case "gif":
                    vMIMEType = "image/gif";
                    break;
                case "jpg":
                case "jpeg":
                    vMIMEType = "image/jpeg";
                    break;
                case "png":
                    vMIMEType = "image/png";
                    break;
                case "tif":
                case "tiff":
                    vMIMEType = "image/tiff";
                    break;
                case "emf":
                    vMIMEType = "image/emf";
                    break;
            }
            return vMIMEType;
        }

        //===[ Image to Base64 and vice-versa ]==========================================================

        public static string ImageToBase64String(string pImagePath)
        {
            Image img = Image.FromFile(pImagePath);
            return ImageToBase64String(img);
        }

        public static string ImageToBase64String(Image pImageObject)
        {
            byte[] byteArray = ImageToByteArray(pImageObject);
            string base64String = Convert.ToBase64String(byteArray, Base64FormattingOptions.InsertLineBreaks);
            return base64String;
        }

        public static Image Base64StringToImage(string pBase64String)
        {
            byte[] byteArray = Convert.FromBase64String(pBase64String);
            MemoryStream mem = new MemoryStream(byteArray);
            Image img = Image.FromStream(mem);
            mem.Dispose();
            return img;
        }

        //===[  Image to byte-array and vice versa ]==========================================================

        public static byte[] ImageToByteArray(Image pImageObject)
        {
            MemoryStream mem = new MemoryStream();
            pImageObject.Save(mem, pImageObject.RawFormat);
            byte[] byteArray = mem.ToArray();
            mem.Dispose();
            return byteArray;
        }

        public static Image ByteArrayToImage(byte[] pByteArray)
        {
            MemoryStream mem = new MemoryStream(pByteArray);
            Image img = Image.FromStream(mem);
            mem.Dispose();
            return img;
        }

        //===[ Byte-array to Base64 and vice-versa ]==========================================================

        public static string ByteArrayToBase64String(byte[] pByteArray)
        {
            string base64String = Convert.ToBase64String(pByteArray, Base64FormattingOptions.InsertLineBreaks);
            return base64String;
        }

        public static byte[] Base64StringToByteArray(string pBase64String)
        {
            byte[] byteArray = Convert.FromBase64String(pBase64String);
            return byteArray;
        }

        //=============================================================
    }
}
