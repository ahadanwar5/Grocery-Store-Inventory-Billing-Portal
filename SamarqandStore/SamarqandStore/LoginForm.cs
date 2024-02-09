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
    public partial class LoginForm : Form
    {
        DBConnect dBCon = new DBConnect();
        public static string Eusername_from_form;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {

        }


        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Goldenrod;
        }

        private void label_clear_MouseEnter(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.Red;
        }

        private void label_clear_MouseLeave(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.Goldenrod;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_clear_Click(object sender, EventArgs e)
        {
            TextBox_username.Clear();
            TextBox_password.Clear();
        }

        private void Button_login_Click(object sender, EventArgs e)
        {
            if (TextBox_username.Text == "" || TextBox_password.Text == "")
            {
                MessageBox.Show("Please Enter Username and Password", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string selectQuery = "SELECT * FROM employee WHERE Eusername='" + TextBox_username.Text + "' AND Epassword='" + TextBox_password.Text + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, dBCon.GetCon());
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    Eusername_from_form = TextBox_username.Text;
                    SellingForm selling = new SellingForm();
                    selling.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Wrong Username or Password", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TextBox_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
