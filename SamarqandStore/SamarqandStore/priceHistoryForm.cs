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
    public partial class priceHistoryForm : Form
    {
        DBConnect dBCon = new DBConnect();
        public priceHistoryForm()
        {
            InitializeComponent();
        }

        private void button_go_back_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void priceHistoryForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void getTable()
        {
            string selectQuerry = "SELECT * FROM productlog";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_pricelog.DataSource = table;
        }
    }
}
