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

namespace Inventory_Mobile_1
{
    public partial class adproduct4 : Form
    {
        public adproduct4()
        {
            InitializeComponent();
        }

        private void saveprodcat_Click(object sender, EventArgs e)
        {
            String prod_catid = txtprodcatid.Text;
            String prod_catname = txtprodcatname.Text;

            SqlConnection connection2 = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=Inventorydp;Integrated Security=True");
            connection2.Open();
            SqlCommand insert_cmd = new SqlCommand("insert into Product_category(category_id,category_name) values('"+prod_catid+"','"+prod_catname+"')", connection2);
            insert_cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Product Category Created", "New Product Category Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection2.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin2 f2 = new admin2();
            f2.Show();
            Visible = false;
        }
    }
}
