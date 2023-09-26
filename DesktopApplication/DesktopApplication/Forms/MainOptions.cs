using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using DesktopApplication.Classes;

namespace DesktopApplication.Forms
{
    public partial class MainOptions : Form
    {
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private DataRow Row;
        public MainOptions()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainOptions_Load(object sender, EventArgs e)
        {
            //Retrive data from DB
            adapter = new SqlDataAdapter("Select Top 1 * from Options",adoClass.sqlCn);
            dataTable = new DataTable();
            try
            {
                adapter.Fill(dataTable);
                //Check if data is exisit or no
                if(dataTable.Rows.Count > 0)
                {
                    Row = dataTable.Rows[0];
                    for(int i=0; i <= dataTable.Rows.Count-1; i++) 
                    {
                        txtRestName.Text = dataTable.Rows[i]["Rsetname"].ToString();
                        txtRestAddress1.Text = dataTable.Rows[i]["RestAddress1"].ToString();
                        txtRestAddress2.Text = dataTable.Rows[i]["RestAddress2"].ToString();               
                        txtTelephone.Text = dataTable.Rows[i]["telephone"].ToString();               
                        txtPrinterName.Text = dataTable.Rows[i]["prenterName"].ToString();

                        txtReceiptLine1.Text = dataTable.Rows[i]["receiptLine1"].ToString();
                        txtReceiptLine2.Text = dataTable.Rows[i]["receiptLine2"].ToString();

                        if (dataTable.Rows[i]["logo"] != DBNull.Value)
                        {
                            pictureBox1.BackgroundImage = Helper.ByteToImage(dataTable.Rows[i]["logo"]);
                        }
                    }
                }
                else
                {
 
                    Row = null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Save New Data","?",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveData();
            }
        }

        //method to check Data before save in DB
        private void SaveData()
        {
            //check Rest Name is Empty
            // Rest Name is Required
            if (txtRestName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter The Restaurant name");
                txtRestName.Focus();
                return;
            }
            //check Telephone is Empty
            //Telephone is Required
            if (txtTelephone.Text == string.Empty)
            {
                MessageBox.Show("Please Enter The Restaurant Phone Number");
                txtTelephone.Focus();
                return;
            }

            if (Row == null)
            {
                Row = dataTable.NewRow();
                dataFillRow();
                dataTable.Rows.Add(Row);
            } 
            else 
            {
                Row.BeginEdit();
                dataFillRow();
                Row.EndEdit();
            }

            try
            {
                adoClass.builder = new SqlCommandBuilder(adapter);
                adapter.Update(dataTable);
                MessageBox.Show("Data has been Updated:)");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //method to fill rows in DB
        private void dataFillRow()
        {
            Row["Rsetname"] = txtRestName.Text;
            Row["RestAddress1"] = txtRestAddress1.Text;
            Row["RestAddress2"] = txtRestAddress2.Text;
            Row["telephone"] = txtTelephone.Text;
            Row["prenterName"] = txtPrinterName.Text;
            Row["receiptLine1"] = txtReceiptLine1.Text;
            Row["receiptLine2"] = txtReceiptLine2.Text;
            if(pictureBox1.BackgroundImage != null)
            {
                Row["logo"] = Helper.ImageToByte(pictureBox1.BackgroundImage);
            }
          
        }

        //to select image
        private void btnSelectPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog= new OpenFileDialog();
            fileDialog.Filter = "Images|*.png";
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPic.Text = fileDialog.FileName;
                pictureBox1.BackgroundImage = new Bitmap(txtPic.Text);
            }
        }
    }
}
