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
    
    public partial class MainForm : Form
    {
        private Button currentButton;
        private Button tempIndex;
        public MainForm()
        {
            InitializeComponent();
        }
        private Color SelectTheme()
        {
            if (currentButton.Text == "Point Of Sale")
            {
                return Color.Gray;
            }
            else if (currentButton.Text == "Setup")
            {
                return Color.Red;
            }
            else if (currentButton.Text == "Reporting")
            {
                return Color.Blue;
            }
            else if (currentButton.Text == "Options")
            {
                return Color.Green;
            }
            else
            {
                return Color.Gray;
            };
        }

        private void ActiveButton(object sender) 
        {
            if(sender != null)
            {
                if(currentButton != (Button)sender) 
                {
                    unSelectButton();
                    currentButton = (Button)sender;
                    Color color= SelectTheme(); 
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Tohoma",11F,FontStyle.Bold);

                }
            }
        }

        private void unSelectButton()
        {
            foreach(Control ctr in pnlMenu.Controls)
            {
                if(ctr.GetType()== typeof(Button))
                {
                    ctr.BackColor = Color.Gray;
                    ctr.ForeColor = Color.White;
                    ctr.Font = new Font("Tohoma", 8F, FontStyle.Regular);
                }
            }
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);

        }

        private void btnReporting_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);

        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);

        }
    }
}
