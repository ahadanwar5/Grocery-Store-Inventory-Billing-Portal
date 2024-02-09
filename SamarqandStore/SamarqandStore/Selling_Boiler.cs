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
    public partial class Selling_Boiler : Form
    {
        DBConnect dBCon = new DBConnect();
        public Selling_Boiler()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {

        }

        private void Selling_Boiler_Load(object sender, EventArgs e)
        {

        }

        private void button_sell_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO orders VALUES('temp',Eusername)";
            SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
            dBCon.OpenCon();
            command.ExecuteNonQuery();
            dBCon.CloseCon();

            SellingForm selling = new SellingForm();
            selling.Show();
            this.Hide();
        }
    }
}
