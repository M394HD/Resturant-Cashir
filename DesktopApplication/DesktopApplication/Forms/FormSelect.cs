using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApplication.Classes;

namespace DesktopApplication.Forms
{
    public partial class FormSelect : Form
    {
        public FormSelect(string _selectTxt)
        {
            InitializeComponent();
            selectTxt = _selectTxt;
        }

        private DataTable dataTable;
        private SqlDataAdapter adapter;
        public string selectTxt { get; set; }
        public string des { get; set; }
        public string result { get; set; }

        /// <summary>
        /// Method to felter db and select users 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDes_KeyUp(object sender, KeyEventArgs e)
        {
            loadSelect();
            
        }
        /// <summary>
        /// Function to select user db
        /// </summary>
        private void loadSelect()
        {
            dataTable.DefaultView.Sort = "id";
            DataRow[] rows = dataTable.Select(des + " LIKE '%'+'" + txtDes.Text + "'+'%'");
            dgvItems.Rows.Clear();  
            for(int i = 0;i<= rows.Length-1; i++)
            {
                dgvItems.Rows.Add(new object[]
                {
                     rows[i][0],
                     rows[i][des]

            });
            }
        }
        private void FormSelect_Load(object sender, EventArgs e)
        {
            adapter= new SqlDataAdapter(selectTxt,adoClass.sqlCn);  
            dataTable= new DataTable();
            try
            {
                adapter.Fill(dataTable);
                loadSelect();

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Method to get and return user data in user form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvItems.Rows.Count > 0)
            {
                result= dgvItems[ColId.Index,dgvItems.CurrentRow.Index].Value.ToString();
                this.DialogResult= DialogResult.OK;
                Close();
            }
        }

  
    }
}
