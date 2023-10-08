using DesktopApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApplication.Forms
{
    public partial class FormPermissions : Form
    {
        SmartPOSEntities smartPOSEntities = new SmartPOSEntities();
        int counter;
        public FormPermissions()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPermissions_Load(object sender, EventArgs e)
        {
            foreach(var item in  smartPOSEntities.Users)
            {
                comboBox1.Items.Add(item.fullName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
                MessageBox.Show("Plese Select User To Apply The Permission");
            else
            {
                string user = comboBox1.SelectedItem.ToString();
                SavePermission(user);
            }
        }

        public void SavePermission(string user)
        {
            var userCode=smartPOSEntities.Users.FirstOrDefault(x=>x.fullName == user);
            //var permQ = from q in smartPOSEntities.userpermissions
            //            where q.userid == userCode.id
            //            select q.permission_id;

            int permissionID=smartPOSEntities.userpermissions.Where(x=>x.userid == userCode.id).
                                Select(x=>x.permission_id).FirstOrDefault();
            
            var username = smartPOSEntities.userpermissions.Find(permissionID);
            if (username != null)
            {
                smartPOSEntities.userpermissions.Remove(username);
                smartPOSEntities.SaveChanges();
            }
            counter = 1+smartPOSEntities.userpermissions.OrderByDescending(x=>x.permission_id).Select(x=>x.permission_id).FirstOrDefault();
            getDatafrmChkBx(this.Controls, user);
            MessageBox.Show("Done");
        }

        public void getDatafrmChkBx(Control.ControlCollection controls,string username)
        {
            foreach(Control item in  controls)
            {
                if(item is CheckBox)
                {
                    CheckBox chkbx = (CheckBox)item;
                    userpermission user = new userpermission();
                    user.permission_id = counter;
                    user.main_screen = chkbx.AccessibleDescription;
                    user.permission = chkbx.AccessibleName;
                    var userCode = smartPOSEntities.Users.FirstOrDefault(x => x.fullName == username);
                    user.userid = userCode.id;
                    user.@case = chkbx.Checked;


                    smartPOSEntities.userpermissions.Add(user);
                    smartPOSEntities.SaveChanges();

                    counter++;

                }
            }
        }

        
    }
}
