using DesktopApplication.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApplication.Forms
{
    public partial class FormItems : Form
    {
        public FormItems()
        {
            InitializeComponent();
        }
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private DataRow row;
        /// <summary>
        /// The current index
        /// </summary>
        private int index;
        private void FormItems_Load(object sender, EventArgs e)
        {
            ///rech Category using fillComboBox 
            Helper.fillComboBox(comboBox1, "select Id, DES from Categories");
            adapter = new SqlDataAdapter("Select * From Items", adoClass.sqlCn);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            index = 0;
            loadData(0);

        }
        private void loadDataWithIndex(int _index)
        {
            index = _index;
            ///check if dataTable has Raws & index not > 0 & index is not out of the data row
            if (dataTable.Rows.Count > 0 && _index >= 0 && _index <= dataTable.Rows.Count - 1)
            {
                txtDes.Text = dataTable.Rows[_index]["DES"].ToString();
                comboBox1.Text = Helper.getComboItemValue(comboBox1, dataTable.Rows[_index]["CategoryId"].ToString());
                txtPrice.Text = dataTable.Rows[_index]["price"].ToString();
                txtDes.Text = dataTable.Rows[_index]["notes"].ToString();
                if (row["itemImg"] != DBNull.Value)
                {
                    pictureBox1.BackgroundImage = Helper.ByteToImage(row["itemImg"]);
                }
                else
                {
                    pictureBox1.BackgroundImage = null;
                }
                row = dataTable.Rows[_index];
            }

        }
        /// <summary>
        /// method to loading data from data table,if Id is empty it load only first item else 
        /// </summary>
        /// <param name="Id">user id that we search about it in data table</param>
        private void loadData(int Id)
        {
            DataRow[] dataRaws = null;
            if (Id == 0)
            {
                dataRaws = dataTable.Select();
            }
            else
            {
                dataRaws = dataTable.Select("Id = '" + Id + "'");
            }
            if (dataRaws.Length > 0)
            {
                row = dataRaws[0];
                txtDes.Text = row["DES"].ToString();
                comboBox1.Text = Helper.getComboItemValue(comboBox1, row["CategoryId"].ToString());
                txtPrice.Text = row["price"].ToString();
                txtDes.Text = row["notes"].ToString();
                if (row["itemImg"] != DBNull.Value)
                {
                    pictureBox1.BackgroundImage = Helper.ByteToImage(row["itemImg"]);
                }
                else { pictureBox1.BackgroundImage = null; }
            }

        }
        /// <summary>
        /// method to create new Item form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnNew_Click(object sender, EventArgs e)
        {
            row = null;
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = string.Empty;
                }
                ///In New form Case Set ComboBox Empty
                if (ctr is ComboBox)
                {
                    ctr.Text = "";
                }
            }
            pictureBox1.BackgroundImage = null;
            txtDes.Focus();
        }
        /// <summary>
        /// method to save Item data in db 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnSave_Click(object sender, EventArgs e)
        {
            ///validation
            if (comboBox1.Text == string.Empty)
            {
                MessageBox.Show("Select the Category");
                return;
            }
            if (txtDes.Text == string.Empty)
            {
                MessageBox.Show("Enter The Descreption ");
                txtDes.Focus();
                return;
            }
            if (int.Parse(txtPrice.Text) <= 0)
            {
                MessageBox.Show("Enter The Price");
                txtPrice.Focus();
                return;
            }
            saveData();
        }
        /// <summary>
        /// function to save Item data in db, we will call it in btnSave function 
        /// </summary>
        private void saveData()
        {
            ///check if the row = null create new row and fill else Edite the row
            if (row == null)
            {
                row = dataTable.NewRow();
                dataFillRow();
                dataTable.Rows.Add(row);
            }
            else
            {
                row.BeginEdit();
                dataFillRow();
                row.EndEdit();
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
        /// <summary>
        ///function to fill rows in DB , we will call it in saveData function 
        /// </summary>
        private void dataFillRow()
        {
            row["DES"] = txtDes.Text;
            row["CategoryId"] = ((comboItem)comboBox1.SelectedItem).Id;
            row["price"] = txtPrice.Text;
            row["notes"] = txtNotes.Text;
            if (pictureBox1.BackgroundImage != null)
            {
                row["itemImg"] = Helper.ImageToByte(pictureBox1.BackgroundImage);
            }




        }

        /// <summary>
        /// method to close Item form using exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        ///  method to show the first Item in user form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFirst_Click(object sender, EventArgs e)
        {
            loadDataWithIndex(0);

        }
        /// <summary>
        ///  method to show the previous Item in user form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                loadDataWithIndex(index);
            }
        }
        /// <summary>
        ///  method to show the next Item in user form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (index < dataTable.Rows.Count - 1)
            {
                index++;
                loadDataWithIndex(index);
            }

        }
        /// <summary>
        ///  method to show the last Item in user form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLast_Click(object sender, EventArgs e)
        {
            loadDataWithIndex(dataTable.Rows.Count - 1);

        }
        /// <summary>
        /// Method to open select form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            FormSelect select = new FormSelect("select id, DES from Categories");
            select.des = "DES";
            if (select.ShowDialog() == DialogResult.OK)
            {
                loadData(int.Parse(select.result));
            }
        }

        private void btnSelectPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Images|*.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPic.Text = fileDialog.FileName;
                pictureBox1.BackgroundImage = new Bitmap(txtPic.Text);
            }
        }


    }
}


