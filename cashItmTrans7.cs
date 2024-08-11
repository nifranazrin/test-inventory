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
using System.Data.SqlClient;
namespace Inventory_Mobile_1
{
    public partial class cashItmTrans7 : Form
    {
        public cashItmTrans7()
        {
            InitializeComponent();
        }

        private void btnaddrow_Click(object sender, EventArgs e)
        {
            //String itm_name = itmtrnsction.Rows[0].Cells[0].Value.ToString();
            double tot_full = 0.0;
            String cus_name = txtcusname.Text;
            String cus_mobno = txtmobnumbr.Text;

            for (int x = 0; x < itmtrnsction.RowCount; x++)
            {
                for (int y = 0; y < itmtrnsction.ColumnCount; y++)
                {
                    if (itmtrnsction.Rows[x].Cells[0].Value == null)
                    {
                        break;
                    }
                    else
                    {
               
                        double item_unit_price = Convert.ToDouble(itmtrnsction.Rows[x].Cells[2].Value);
                        int qty = Convert.ToInt32(itmtrnsction.Rows[x].Cells[1].Value);
                        double item_total = item_unit_price * qty;

                        String line_total = String.Format("{0:N2}", item_total);
                        itmtrnsction.Rows[x].Cells[3].Value = line_total;
                        //SqlConnection connection2 = new SqlConnection("Data Source=localhost\SQLEXPRESS01;Initial Catalog=Inventorydp;Integrated Security=True");
                        //connection2.Open();

                    }

                }

                if (itmtrnsction.Rows[x].Cells[0].Value == null)
                {
                    break;
                }
                else
                {
                    String item_name = itmtrnsction.Rows[x].Cells[0].Value.ToString();
                    SqlConnection connection1 = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=Inventorydp;Integrated Security=True");
                    connection1.Open();
                    SqlCommand command1 = new SqlCommand("select count(*) from Product_Item where itm_catgry_code='"+item_name+"' ",connection1);
                    SqlDataReader reader1 = command1.ExecuteReader();
                    while (reader1.Read())
                    {
                        if (reader1.GetInt32(0) == 0)
                        {
                            MessageBox.Show("No such an item code existing");
                            itmtrnsction.Rows.RemoveAt(x);
                        }
                    }

                    connection1.Close();
                    SqlConnection connection2 = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=Inventorydp;Integrated Security=True");
                    connection2.Open();
                    SqlCommand command3 = new SqlCommand("insert into Transaction_Save(cus_num,cus_mob,itm_code,itm_price,itm_qty,itm_line_tot,del_date) values('" + cus_name + "','" + cus_mobno + "','" + item_name + "','" + itmtrnsction.Rows[x].Cells[2].Value + "','" + itmtrnsction.Rows[x].Cells[1].Value + "','" + itmtrnsction.Rows[x].Cells[3].Value +"','"+DateTime.Today+"')",connection2);
                    command3.ExecuteNonQuery();

                    double item_total_exist = Convert.ToDouble(itmtrnsction.Rows[x].Cells[3].Value);
                    tot_full += item_total_exist;
                }

            }
            String total_full = String.Format("{0:N2}",tot_full);
            lbltotitm.Text = total_full.ToString();
        }

        private void check_item_exists(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new print8().Show();
            this.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        { cashier6 f1= new cashier6();
            f1.Show();
            Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
