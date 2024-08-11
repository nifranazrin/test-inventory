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
using System.Collections;

namespace Inventory_Mobile_1
{
    public partial class aditem5 : Form
    {
        public aditem5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            SqlConnection connection2 = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=Inventorydp;Integrated Security=True");
            connection2.Open();
            SqlCommand read_cmd = new SqlCommand("select category_name from Product_category", connection2);
            SqlDataReader result_category = read_cmd.ExecuteReader();
            ArrayList category_list = new ArrayList();
            while (result_category.Read())
            {
                category_list.Add(result_category.GetString(0));
            }

            cmbprodcode.Items.AddRange(category_list.ToArray());
        }

        private void cmbprodcode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnsvproditm_Click(object sender, EventArgs e)
        {
            String itm_catcode = txtitmcode.Text;
            String prod_catcode = cmbprodcode.Text;
            double prod_itm_price = Convert.ToDouble(txtitmprce.Text);
            int itm_qty = Convert.ToInt32(txtitmqty.Text);

            SqlConnection connection1 = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=Inventorydp;Integrated Security=True");
            connection1.Open();
            SqlCommand insert_cmd = new SqlCommand("insert into Product_Item(itm_catgry_code,prod_catgry_code,prod_itm_price,prod_itm_qty) values('" + itm_catcode + "','" + prod_catcode + "','" + prod_itm_price + "','" + itm_qty + "')", connection1);
            insert_cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Product Item Created", "New Product Item Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection1.Close();
        }

        private void label5_Click(object sender, EventArgs e)
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

