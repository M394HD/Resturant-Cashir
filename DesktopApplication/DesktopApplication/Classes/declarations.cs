using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApplication.Classes
{
    public static class declarations
    {
        public static int userId;
        public static List<Permission> permissions;
    }

    public class Permission
    {
        public string mainScreeen { get; set; }
        public string permission { get; set; }
        public bool _case { get; set; }
    }
}
