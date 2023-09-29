using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace DesktopApplication.Classes
{
    public class Helper
    {
        //method to convert from image to byte
        public static Byte[] ImageToByte(Image img)
        {
            Byte[] bResult = null;
            // MemoryStream : To using space in memory to covert image to byte 
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Png);
                bResult = ms.ToArray();
            }
            return bResult;
        }

        //method to convert from byte to image
        public static Image ByteToImage(object bObj)
        {
            Byte[] myImg = (Byte[])bObj;
            Image image= null;
            // MemoryStream : To using space in memory to covert byte to image
            using (MemoryStream ms = new MemoryStream(myImg,0,myImg.Length))
            {
                ms.Write(myImg,0,myImg.Length);
                image = Image.FromStream(ms,true);
            }
            return image;
        }
    }
}
