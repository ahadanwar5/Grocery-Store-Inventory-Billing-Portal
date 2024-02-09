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
    public partial class CustomerForm : Form
    {
        DBConnect dBCon = new DBConnect();
        public CustomerForm()
        {
            InitializeComponent();
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

        private void button_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO customer VALUES ('" + TextBox_name.Text.ToString() + "','" + TextBox_phone.Text.ToString() + "')";
            SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
            dBCon.OpenCon();
            command.ExecuteNonQuery();
            MessageBox.Show("Customer Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dBCon.CloseCon();
            getTable();
            clear();

        }

        private void getTable()
        {
            string selectQuerry = "SELECT * FROM customer";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_customer.DataSource = table;
        }

        private void clear()
        {
            TextBox_name.Clear();
            TextBox_phone.Clear();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_name.Text == "" || TextBox_phone.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                string updateQuery = "UPDATE customer SET Cname='" + TextBox_name.Text.ToString() + "', Cphone='" + TextBox_phone.Text.ToString() + "'WHERE CustId=" + TextBox_id.Text + " ";
                SqlCommand command = new SqlCommand(updateQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Customer Updated Successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuery = "DELETE FROM customer WHERE CustId=" + TextBox_id.Text + "";
                SqlCommand command = new SqlCommand(deleteQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Customer Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void dataGridView_customer_Click(object sender, EventArgs e)
        {
            TextBox_id.Text = dataGridView_customer.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_name.Text = dataGridView_customer.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_phone.Text = dataGridView_customer.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button_product_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void dataGridView_customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void button_selling_Click(object sender, EventArgs e)
        {
            SellingForm selling = new SellingForm();
            selling.Show();
            this.Hide();
        }
    }
}
