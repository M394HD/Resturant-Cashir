using DesktopApplication.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DesktopApplication.Forms
{
    public partial class FormTables : Form
    {
        public FormTables()
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

        private void FormTables_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("Select * From Tables", adoClass.sqlCn);
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
            }

        }
        /// <summary>
        /// method to create new Tables form
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
            }
            txtDes.Focus();
        }
        /// <summary>
        /// method to save Tables data in db 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnSave_Click(object sender, EventArgs e)
        {
            ///validation
            if (txtDes.Text == string.Empty)
            {
                MessageBox.Show("Enter The Descreption ");
                txtDes.Focus();
                return;
            }
            saveData();
        }
        /// <summary>
        /// function to save Tables data in db, we will call it in btnSave function 
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
        ///  method to show the first Tables in user form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFirst_Click(object sender, EventArgs e)
        {
            loadDataWithIndex(0);

        }

        //  method to show the previous Tables in user form
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                loadDataWithIndex(index);
            }
        }

        //  method to show the next Tables in user form
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (index < dataTable.Rows.Count - 1)
            {
                index++;
                loadDataWithIndex(index);
            }

        }

        //  method to show the last Tables in user form
        private void btnLast_Click(object sender, EventArgs e)
        {
            loadDataWithIndex(dataTable.Rows.Count - 1);

        }
  
        // Method to open select form
        private void btnSelect_Click(object sender, EventArgs e)
        {
            FormSelect select = new FormSelect("select id, DES from Tables");
            select.des = "DES";
            if (select.ShowDialog() == DialogResult.OK)
            {
                loadData(int.Parse(select.result));
            }
        }
    }
}