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
using DesktopApplication.Classes;

namespace DesktopApplication.Forms
{
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
        }
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        /// <summary>
        /// Status to check if the screen (user form) is new 
        /// </summary>
        private DataRow row;
        /// <summary>
        /// The current index
        /// </summary>
        private int index;
        /// <summary>
        /// method to close user form using exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// method to loade user data from data table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormUsers_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("Select * From Users", adoClass.sqlCn);
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
                txtuserName.Text = dataTable.Rows[_index]["userName"].ToString();
                txtpassword.Text = dataTable.Rows[_index]["password"].ToString();
                txtfullName.Text = dataTable.Rows[_index]["fullName"].ToString();
                txtjobeDes.Text = dataTable.Rows[_index]["jobDes"].ToString();
                txtemail.Text = dataTable.Rows[_index]["email"].ToString();
                txtphone.Text = dataTable.Rows[_index]["phone"].ToString();
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
                txtuserName.Text = row["userName"].ToString();
                txtpassword.Text = row["password"].ToString();
                txtfullName.Text = row["fullName"].ToString();
                txtjobeDes.Text = row["jobDes"].ToString();
                txtemail.Text = row["email"].ToString();
                txtphone.Text = row["phone"].ToString();
            }
        }
        /// <summary>
        /// method to create new user form
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
            txtuserName.Focus();
        }
        /// <summary>
        /// method to save user data in db 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            ///validation
            if (txtuserName.Text == string.Empty)
            {
                MessageBox.Show("Enter The User Name ");
                txtuserName.Focus();
                return;
            }
            if (txtpassword.Text == string.Empty)
            {
                MessageBox.Show("Enter The Password ");
                txtpassword.Focus();
                return;
            }
            if (txtfullName.Text == string.Empty)
            {
                MessageBox.Show("Enter The Full Name ");
                txtfullName.Focus();
                return;
            }
            saveData();

        }
        /// <summary>
        /// function to save user data in db, we will call it in btnSave function 
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
            row["userName"] = txtuserName.Text;
            row["password"] = txtpassword.Text;
            row["fullName"] = txtfullName.Text;
            row["jobDes"] = txtjobeDes.Text;
            row["email"] = txtemail.Text;
            row["phone"] = txtphone.Text;

        }
        /// <summary>
        ///  method to show the first user in user form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFirst_Click(object sender, EventArgs e)
        {
            loadDataWithIndex(0);

        }
        /// <summary>
        ///  method to show the previous user in user form
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
        ///  method to show the next user in user form
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
        ///  method to show the last user in user form
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
            FormSelect select = new FormSelect("select id, fullName from Users");
            select.des = "fullName";
            if (select.ShowDialog() == DialogResult.OK)
            {
                loadData(int.Parse(select.result));
            }
        }
    }
}
