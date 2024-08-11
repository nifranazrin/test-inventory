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
    public partial class adempoyee3 : Form
    {
        public adempoyee3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnsvemp_Click(object sender, EventArgs e)
        {
            String emp_tit = cmbtitle.Text;
            String emp_fname = txtfname.Text;
            String emp_lname = txtlname.Text;
            String emp_des = txtdesign.Text;

            SqlConnection connection1 = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=Inventorydp;Integrated Security=True");
            connection1.Open();
            SqlCommand insert_cmd = new SqlCommand("insert into Employee_Details(emp_title,emp_fname,emp_lname,emp_desgnation) values('" + emp_tit + "','" + emp_fname + "','" + emp_lname + "','" + emp_des + "')", connection1);
            insert_cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Employee Created","New Employee Creation",MessageBoxButtons.OK,MessageBoxIcon.Information);
            connection1.Close();
        }

        private void txtlname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin2 f2 = new admin2();
            f2.Show();
            Visible = false;
        }

        private void cmbtitle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
