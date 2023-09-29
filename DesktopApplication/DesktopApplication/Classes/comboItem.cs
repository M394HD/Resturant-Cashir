using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApplication.Classes
{
    /// <summary>
    /// Class to save id & Des and overrid ToString Method that return DES
    /// </summary>
    public class comboItem
    {
        public string Id { get; set; }    
        public string DES { get; set; }
        public comboItem(string _id, string _DES)
        {
            Id = _id;
            DES = _DES; 
        }
        public override string ToString()
        {
            return DES;
        }
    }
}
