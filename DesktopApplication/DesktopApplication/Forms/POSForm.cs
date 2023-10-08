using DesktopApplication.Classes;
using DesktopApplication.Models;
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
    public partial class POSForm : Form
    {
        public POSForm()
        {
            InitializeComponent();
        }

        private SqlDataAdapter adapter;
        private DataTable _itemsDt;

        private void POSForm_Load(object sender, EventArgs e)
        {
            Helper.fillComboBox(cmbxPayment, "select Id, DES from Payments");
            cmbxPayment.Text = Helper.getComboItemValue(cmbxPayment, "1");
            fillCategories();
            btn0.Click += num_Check;
            btn1.Click += num_Check;
            btn2.Click += num_Check;
            btn3.Click += num_Check;
            btn4.Click += num_Check;
            btn5.Click += num_Check;
            btn6.Click += num_Check;
            btn7.Click += num_Check;
            btn8.Click += num_Check;
            btn9.Click += num_Check;
            btnCancel.Click += num_Check;
            btnDot.Click += num_Check;
        }

        // Display all Categories on cashier page
        private void fillCategories()
        {
            adapter = new SqlDataAdapter("Select Id,DES From Categories", adoClass.sqlCn);
            _itemsDt = new DataTable();
            try
            {
                adapter.Fill(_itemsDt);
                DataRow[] drs = _itemsDt.Select();
                int x = 3, y = 3, count = 1;
                panelItems.Controls.Clear();
                for (int i = 0; i <= drs.Length - 1; i++)
                {
                    Button catBtn = new Button();
                    catBtn.BackColor= Color.LightGray;
                    catBtn.AccessibleName = "CAT";
                    catBtn.AccessibleDescription = drs[i]["Id"].ToString();
                    catBtn.Name = "btnCat" + drs[i]["Id"].ToString();
                    catBtn.Text = drs[i]["DES"].ToString();
                    catBtn.Size = new Size(100, 100);
                    catBtn.Location = new Point(x, y);
                    catBtn.Click += cBtn_Click;
                    panelItems.Controls.Add(catBtn);
                    x += 103;
                    if (count == 6)
                    {
                        y += 103;
                        x = 1;
                        count = 1;
                    }
                    else
                    {
                        count++;
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        // To select category type
        private void cBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.AccessibleName == "CAT")
            {
                string CatId = button.AccessibleDescription;
                fillItems(CatId);
            }
            else if (button.AccessibleName == "IT")
            {
                double Qty = 0;
                double.TryParse(txtItemQTY.Text, out Qty);
                if (Qty == 0)
                {
                    Qty = 1;
                }

                double totalPrice = 0;
                double itemPrice = 0;
                double.TryParse(button.Tag.ToString(), out itemPrice);
                totalPrice = itemPrice * Qty;
                djvItems.Rows.Add(new object[]
                {
                    button.AccessibleDescription,
                    button.Text,
                    Qty,
                    totalPrice,
                    itemPrice
                });
                txtItemQTY.Text = "0";
            }
            else
            {
                fillCategories();
            }
            calcCheck();
        }

        // Get category's foods from DB and display on cashier page
        private void fillItems(string catId)
        {
            adapter = new SqlDataAdapter("Select * From Items where CategoryId = '" + catId + "'", adoClass.sqlCn);
            _itemsDt = new DataTable();
            try
            {
                adapter.Fill(_itemsDt);
                DataRow[] drs = _itemsDt.Select();
                int x = 3, y = 3, count = 1;
                panelItems.Controls.Clear();
                Button catBtn;
                for (int i = 0; i <= drs.Length - 1; i++)
                {
                    catBtn = new Button();
                    catBtn.BackColor = Color.LightGray;
                    catBtn.AccessibleName = "IT";
                    catBtn.AccessibleDescription = drs[i]["Id"].ToString();
                    catBtn.Name = "btnCat" + drs[i]["Id"].ToString();
                    catBtn.Text = drs[i]["DES"].ToString();
                    catBtn.Tag = drs[i]["price"].ToString();
                    catBtn.TextAlign = ContentAlignment.BottomRight;
                    catBtn.Image = Helper.ByteToImage(drs[i]["itemImg"]);
                    catBtn.Size = new Size(100, 100);
                    catBtn.Location = new Point(x, y);
                    catBtn.Click += cBtn_Click;
                    panelItems.Controls.Add(catBtn);
                    x += 103;
                    if (count == 6)
                    {
                        y += 103;
                        x = 1;
                        count = 1;
                    }
                    else
                    {
                        count++;
                    }
                }
                catBtn = new Button();
                catBtn.Size = new Size(100, 100);
                catBtn.AccessibleName = "C";
                catBtn.Name = "btnEnd" + catId;
                catBtn.Text = "Cancel";
                catBtn.Location = new Point(x, y);
                catBtn.Click += cBtn_Click;
                panelItems.Controls.Add(catBtn);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        // Close cashier page
        private void button11_Click(object sender, EventArgs e)
        {
            Close();
        }

        // To clear all orders
        private void button12_Click(object sender, EventArgs e)
        {
            djvItems.Rows.Clear();
            calcCheck();
        }

        // Remove order after select that order
        private void button13_Click(object sender, EventArgs e)
        {
            if (djvItems.Rows.Count > 0)
            {
                djvItems.Rows.Remove(djvItems.CurrentRow);
            }
            calcCheck();
        }

        // To calculate total price and display that on Total Text
        private void calcCheck()
        {
            double x = 0;
            double result = 0;
            for (int i = 0; i <= djvItems.Rows.Count - 1; i++)
            {
                double.TryParse(djvItems[ColPrice.Index, 1].Value.ToString(), out x);
                result += x;
            }
            txtTotal.Text = result.ToString();
        }

        // To enter that quantity of order which you will order that
        private void num_Check(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "C")
            {
                txtItemQTY.Text = "0";
            }
            else if (button.Text == ".")
            {
                if (!txtItemQTY.Text.Contains("."))
                {
                    if (int.Parse(txtItemQTY.Text) == 0)
                    {
                        button.Text = "0.";
                    }
                    else
                    {
                        txtItemQTY.Text += button.Text;
                    }
                }
            }
            else
            {
                if (int.Parse(txtItemQTY.Text) == 0)
                {
                    txtItemQTY.Text = button.Text;
                }
                else
                {
                    txtItemQTY.Text += button.Text;
                }
            }
        }

        private void saveCheck()
        {
            string insertSql = " Insert Into Checks(checkData, userId, totalCheck, status) values (@checkData, @userId, @totalCheck, @status); ";
            insertSql += " SELECT @CheckId = SCOPE_IDENTITY(); ";
            SqlCommand sqlcm = new SqlCommand(insertSql, adoClass.sqlCn);
            sqlcm.Parameters.Add("@checkData", SqlDbType.DateTime);
            sqlcm.Parameters.Add("@userId", SqlDbType.Int);
            sqlcm.Parameters.Add("@totalCheck", SqlDbType.Decimal);
            sqlcm.Parameters.Add("@status", SqlDbType.VarChar);
            sqlcm.Parameters.Add("@CheckId", SqlDbType.Int);
            try
            {
                sqlcm.Parameters["@CheckId"].Direction = ParameterDirection.Output;
                sqlcm.Parameters["@checkData"].Value = DateTime.Now;
                sqlcm.Parameters["@userId"].Value = declarations.userId;
                sqlcm.Parameters["@totalCheck"].Value = double.Parse(txtTotal.Text);
                sqlcm.Parameters["@status"].Value = "Close";
                if (adoClass.sqlCn.State != ConnectionState.Open)
                {
                    adoClass.sqlCn.Open();
                }
                sqlcm.ExecuteNonQuery();
                string CheckId = sqlcm.Parameters["@CheckId"].Value.ToString();
                saveDataItems(CheckId);
                saveDataPayments(CheckId);
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adoClass.sqlCn.Close();
            }
        }

        private void saveDataItems(string checkId)
        {
            adapter = new SqlDataAdapter("Select Top 1 * FROM ChecksItems", adoClass.sqlCn);
            _itemsDt = new DataTable();
            try
            {
                adapter.Fill(_itemsDt);
                for (int i = 0; i <= djvItems.Rows.Count - 1; i++)
                {
                    DataRow row = _itemsDt.NewRow();
                    row["CheckId"] = checkId;
                    row["ItemId"] = djvItems[ColItemId.Index, i].Value;
                    row["QTY"] = djvItems[ColQTY.Index, i].Value;
                    row["price"] = djvItems[ColItemPrice.Index, i].Value;
                    row["totalPrice"] = djvItems[ColPrice.Index, i].Value;
                    _itemsDt.Rows.Add(row);
                }
                saveData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveDataPayments(string checkId)
        {
            adapter = new SqlDataAdapter("Select Top 1 * FROM ChecksPay", adoClass.sqlCn);
            _itemsDt = new DataTable();
            try
            {
                adapter.Fill(_itemsDt);
                DataRow row = _itemsDt.NewRow();
                row["CheckId"] = checkId;
                row["PaymentId"] = ((comboItem)cmbxPayment.SelectedItem).Id;
                row["PayVal"] = double.Parse(txtPayed.Text);
                _itemsDt.Rows.Add(row);
                saveData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveData()
        {
            adoClass.builder = new SqlCommandBuilder(adapter);
            adapter.Update(_itemsDt);
        }

        // Make Save Check when click Pay Button
        private void btnPay_Click(object sender, EventArgs e)
        {
            double totalCheck = 0;
            double totalPay = 0;
            double.TryParse(txtTotal.Text, out totalCheck);
            double.TryParse(txtItemQTY.Text, out totalPay);
            if (totalCheck == 0)
            {
                MessageBox.Show("Can't Save Empty Check");
                return;
            }
            if (totalPay == 0)
            {
                MessageBox.Show("Can't Pay Whithout Money");
                return;
            }
            if (totalPay < totalCheck)
            {
                MessageBox.Show("The Payment Not Enough");
                return;
            }
            if (cmbxPayment.Text == string.Empty)
            {
                MessageBox.Show("Select Pay Method");
                return;
            }
            txtPayed.Text = totalCheck.ToString();
            txtChange.Text = (totalPay - totalCheck).ToString();
            saveCheck();
        }
    }
}
