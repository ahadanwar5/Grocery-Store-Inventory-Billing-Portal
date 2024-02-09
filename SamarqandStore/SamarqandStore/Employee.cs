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
    public partial class Employee : Form
    {
        DBConnect dBCon = new DBConnect();
        public Employee()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO employee VALUES('" + TextBox_name.Text.ToString() + "','" + TextBox_phone.Text.ToString() + "','" + TextBox_address.Text.ToString() + "','" + TextBox_username.Text.ToString() + "','" + TextBox_password.Text.ToString() + "')";
                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Employee Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getTable()
        {
            string selectQuerry = "SELECT * FROM employee";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_employee.DataSource = table;
        }

        private void clear()
        {
            TextBox_id.Clear();
            TextBox_name.Clear();
            TextBox_phone.Clear();
            TextBox_address.Clear();
            TextBox_username.Clear();
            TextBox_password.Clear();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "" || TextBox_name.Text == "" || TextBox_phone.Text == "" || TextBox_address.Text == "" || TextBox_username.Text == "" || TextBox_password.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    string updateQuery = "UPDATE employee SET Ename='" + TextBox_name.Text.ToString() + "', Ephone='" + TextBox_phone.Text.ToString() + "', Eaddress='" + TextBox_address.Text.ToString() + "', Eusername='" + TextBox_username.Text.ToString() + "' , Epassword='" + TextBox_password.Text.ToString() + "' WHERE EmpId=" + TextBox_id.Text + "";
                    SqlCommand command = new SqlCommand(updateQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Employee Details Updated Successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBCon.CloseCon();
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_employee_Click(object sender, EventArgs e)
        {
            TextBox_id.Text = dataGridView_employee.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_name.Text = dataGridView_employee.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_phone.Text = dataGridView_employee.SelectedRows[0].Cells[2].Value.ToString();
            TextBox_address.Text = dataGridView_employee.SelectedRows[0].Cells[3].Value.ToString();
            TextBox_username.Text = dataGridView_employee.SelectedRows[0].Cells[4].Value.ToString();
            TextBox_password.Text = dataGridView_employee.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void button_product_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
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

        private void button_customer_Click(object sender, EventArgs e)
        {
            CustomerForm customer = new CustomerForm();
            customer.Show();
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

        private void button_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void button_logout_MouseEnter(object sender, EventArgs e)
        {
            button_logout.ForeColor = Color.Red;
        }

        private void button_logout_MouseLeave(object sender, EventArgs e)
        {
            button_logout.ForeColor = Color.Goldenrod;
        }
    }
}
