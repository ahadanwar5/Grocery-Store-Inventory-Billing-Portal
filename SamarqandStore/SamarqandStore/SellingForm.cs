using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SamarqandStore
{
    public partial class SellingForm : Form
    {
        DBConnect dBCon = new DBConnect();

        public string Eusername_from_form { get; private set; }

        public SellingForm()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            dBCon.OpenCon();
            string insertQuery = "exec spOrderInsert '" + TextBox_OrderId.Text.ToString() + "','" + TextBox_CustId.Text.ToString() + "','" + TextBox_ProdId.Text.ToString() + "','" + TextBox_ReqQty.Text.ToString() + "'";
            SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
            command.ExecuteNonQuery();
            dBCon.CloseCon();
            getTable();
            getTotal();
            clear();
        }

        private void dataGridView_selling_Click(object sender, EventArgs e)
        {
            TextBox_ProdId.Text = dataGridView_selling.SelectedRows[0].Cells[2].Value.ToString();
            TextBox_ReqQty.Text = dataGridView_selling.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void getTable()
        {
            string selectQuerry = "SELECT c.Cname,o.OrderId,p.ProdId,p.ProdName,od.ProdQty as 'Qty',p.ProdPrice as 'Unit Price',od.Subtotal " +
                "from orders o INNER JOIN order_details od ON o.OrderId = od.OrderId INNER JOIN customer c ON o.CustId = c.CustId " +
                "INNER JOIN product p ON p.ProdId = od.ProdId WHERE o.OrderId = '"+TextBox_OrderId.Text.ToString()+"'";

            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_selling.DataSource = table;
        }

        private void getTotal()
        {
            string selectTotalQuerry = "Select SUM(Subtotal) From order_details Where OrderId = '" + TextBox_OrderId.Text.ToString() + "' Group BY OrderId";

            SqlCommand command2 = new SqlCommand(selectTotalQuerry, dBCon.GetCon());
            SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
            DataTable table2 = new DataTable();
            adapter2.Fill(table2);
            DataGridView_total.DataSource = table2;
        }

        private void getClearTable()
        {
            DataTable table = new DataTable();
            dataGridView_selling.DataSource = table;
        }

        private void clear()
        {
            TextBox_ProdId.Clear();
            TextBox_ReqQty.Clear();
        }

        private void clear_complete()
        {
            TextBox_OrderId.Clear();
            TextBox_CustId.Clear();
            TextBox_ProdId.Clear();
            TextBox_ReqQty.Clear();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Goldenrod;
        }

        private void button_logout_MouseEnter(object sender, EventArgs e)
        {
            button_logout.ForeColor = Color.Red;
        }

        private void button_logout_MouseLeave(object sender, EventArgs e)
        {
            button_logout.ForeColor = Color.Goldenrod;
        }

        private void button_category_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }

        private void button_product_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void button_customer_Click(object sender, EventArgs e)
        {
            CustomerForm customer = new CustomerForm();
            customer.Show();
            this.Hide();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextBox_ReqQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_selling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_OrderId.Text == "" || TextBox_ProdId.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuerry = "spCartRemove " + TextBox_ProdId.Text.ToString() + ", " + TextBox_ReqQty.Text.ToString() + "";
                    SqlCommand command = new SqlCommand(updateQuerry, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    dBCon.CloseCon();

                    string deleteQuery = "DELETE FROM order_details WHERE OrderId = " + TextBox_OrderId.Text.ToString() + " AND ProdId = " + TextBox_ProdId.Text.ToString() + "";
                    SqlCommand command1 = new SqlCommand(deleteQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command1.ExecuteNonQuery();
                    MessageBox.Show("Product Removed from Cart", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBCon.CloseCon();
                    getTable();
                    getTotal();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_place_order_Click(object sender, EventArgs e)
        {
            string insertQuery = "EXEC calculateBill " + TextBox_OrderId.Text.ToString() + ", '"+ LoginForm.Eusername_from_form +"' ";
            SqlCommand command1 = new SqlCommand(insertQuery, dBCon.GetCon());
            dBCon.OpenCon();
            command1.ExecuteNonQuery();
            MessageBox.Show("Order Placed Successfully", "Order Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dBCon.CloseCon();
            getClearTable();
            clear_complete();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string deleteOrderQuerry = "DELETE FROM orders Where OrderId = '" + TextBox_OrderId.Text.ToString() + "'";
            SqlCommand command3 = new SqlCommand(deleteOrderQuerry, dBCon.GetCon());
            dBCon.OpenCon();
            command3.ExecuteNonQuery();
            MessageBox.Show("Order Cancelled", "Cancellation Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dBCon.CloseCon();
            clear();
            getClearTable();
        }

        private void button_view_Click(object sender, EventArgs e)
        {
            viewBillForm bill = new viewBillForm();
            bill.Show();
            this.Hide();
        }

        private void button_employee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
            this.Hide();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}
