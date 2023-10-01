using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

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
            Image image = null;
            // MemoryStream : To using space in memory to covert byte to image
            using (MemoryStream ms = new MemoryStream(myImg, 0, myImg.Length))
            {
                ms.Write(myImg, 0, myImg.Length);
                image = Image.FromStream(ms, true);
            }
            return image;
        }
        /// <summary>
        /// Method to can Search in ComboBox (Category ComboBox) by key and  get Category Des from it 
        /// </summary>
        /// <param name="combo"> ItemComboBox</param>
        /// <param name="key">Key of item</param>
        /// <returns></returns>
        public static string getComboItemValue(ComboBox combo, string key)
        {
            string x = string.Empty;
            foreach (var item in combo.Items)
            {
                comboItem cItem = (comboItem)item;
                if (cItem.Id == key)
                {
                    x = cItem.DES;
                }
            }
            return x;
        }
        /// <summary>
        /// Method to fill ComboBox with items that it created as a class comboItem
        /// </summary>
        /// <param name="combo"></param>
        /// <param name="selectText"></param>
        public static void fillComboBox(ComboBox combo, string selectText)
        {
            SqlCommand sqlCm = new SqlCommand(selectText, adoClass.sqlCn);
            SqlDataReader reader = null;
            try
            {
                if (adoClass.sqlCn.State != ConnectionState.Open) adoClass.sqlCn.Open();
                combo.Items.Clear();
                reader = sqlCm.ExecuteReader();
                while (reader.Read())
                {
                    comboItem item = new comboItem(
                            reader[0].ToString(),
                            reader[1].ToString());
                    combo.Items.Add(item);

                }
                combo.Items.Add(new comboItem("", ""));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adoClass.sqlCn.Close();
            }
        }
    }
}
