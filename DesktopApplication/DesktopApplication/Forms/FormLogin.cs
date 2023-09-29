using DesktopApplication.Classes;
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
    public partial class FormLogin : Form
    {
        string user;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogIN_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                MainForm mainForm = new MainForm(user);
                mainForm.ShowDialog();
            }
            else
                MessageBox.Show("Please Check Incorrect username or Password","Error Log in",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        public Boolean Check()
        {
            SmartPOSEntities smartPOSEntities = new SmartPOSEntities();
            foreach(var item in smartPOSEntities.Users)
            {
                if (item.userName == textBoxUserName.Text && item.password == textBoxPassword.Text)
                {
                    user = item.fullName;
                    return true;
                }
            }
            return false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
