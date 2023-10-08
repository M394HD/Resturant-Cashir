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
    public partial class MainSetup : Form
    {
        public MainSetup()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            FormUsers form = new FormUsers();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCategories form = new FormCategories();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormItems form = new FormItems();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormPayments form = new FormPayments();
            form.ShowDialog();
        }

        private void buttonPermission_Click(object sender, EventArgs e)
        {
            FormPermissions permissions = new FormPermissions();
            permissions.ShowDialog();
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            FormTables tables = new FormTables();
            tables.ShowDialog();
        }
    }
}
