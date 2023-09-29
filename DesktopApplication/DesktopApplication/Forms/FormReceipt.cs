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
    public partial class FormReceipt : Form
    {
        public FormReceipt()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            SmartPOSEntities smartPOSEntities = new SmartPOSEntities();
            List<ViewReceipt> vr = new List<ViewReceipt>();

            foreach(var item in smartPOSEntities.ViewReceipts)
            {
                vr.Add(item);
            }

            crystalReportReceipt1.SetDataSource(vr);
            crystalReportViewer1.ReportSource = crystalReportReceipt1;
        }
    }
}
