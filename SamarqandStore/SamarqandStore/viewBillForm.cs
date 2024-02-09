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
    public partial class viewBillForm : Form
    {
        DBConnect dBCon = new DBConnect();
        public viewBillForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_view_Click(object sender, EventArgs e)
        {
            string selectQuerry = "SELECT p.ProdId,p.ProdName,od.ProdQty as 'Qty',p.ProdPrice as 'Unit Price',od.Subtotal " +
                "from orders o INNER JOIN order_details od ON o.OrderId = od.OrderId " +
                "INNER JOIN customer c ON o.CustId = c.CustId " +
                "INNER JOIN product p ON p.ProdId = od.ProdId WHERE o.OrderId = '" + TextBox_OrderId.Text.ToString() + "'";

            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_bill.DataSource = table;

            TextBox_Id.DefaultText = TextBox_OrderId.Text.ToString();

            string selectQuerry2 = "Select billdate from payment where OrderId = '" + TextBox_OrderId.Text.ToString() + "'";
            SqlCommand command2 = new SqlCommand(selectQuerry2, dBCon.GetCon());
            SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
            DataTable table2 = new DataTable();
            adapter2.Fill(table2);
            DataGridView_date.DataSource = table2;

            string selectQuerry3 = "select Cname from customer where CustId = (select CustId from payment where OrderId = '" + TextBox_OrderId.Text.ToString() + "') ";
            SqlCommand command3 = new SqlCommand(selectQuerry3, dBCon.GetCon());
            SqlDataAdapter adapter3 = new SqlDataAdapter(command3);
            DataTable table3 = new DataTable();
            adapter3.Fill(table3);
            DataGridView_CustName.DataSource = table3;

            string selectQuerry4 = "Select total from payment where OrderId = '" + TextBox_OrderId.Text.ToString() + "'";
            SqlCommand command4 = new SqlCommand(selectQuerry4, dBCon.GetCon());
            SqlDataAdapter adapter4 = new SqlDataAdapter(command4);
            DataTable table4 = new DataTable();
            adapter4.Fill(table4);
            DataGridView_total.DataSource = table4;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_employee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
            this.Hide();
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

        private void button_selling_Click(object sender, EventArgs e)
        {
            SellingForm selling = new SellingForm();
            selling.Show();
            this.Hide();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Goldenrod;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_logout_MouseEnter(object sender, EventArgs e)
        {
            button_logout.ForeColor = Color.Red;
        }

        private void button_logout_MouseLeave(object sender, EventArgs e)
        {
            button_logout.ForeColor = Color.Goldenrod;
        }


        private void button_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}
