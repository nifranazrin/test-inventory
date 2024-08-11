using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Mobile_1
{
    public partial class login1 : Form
    {
        public login1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user_name = txtuname.Text;
            String password = txtpword.Text;
            if (user_name == "" || password == "")
            {
                MessageBox.Show("Username or password field cannot be blank", "Empty Parameter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                if (user_name == "Admin" && password == "123")
            {
                MessageBox.Show("Successfully Logged in", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new admin2().ShowDialog();
                this.Hide();
            }
            else
                if (user_name == "Cashier" && password == "456")
            {
                MessageBox.Show("Successfuly Logged in as a cashier", "Success Cashier Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new cashier6().Show();
                this.Hide();
            }
            else
                if (user_name == "Manager" && password == "789")
                    {
                        MessageBox.Show("Successfuly Logged in as a Manager", "Success Manager Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new mangrDash9().Show();
                        this.Hide();
                    }
                    else
                        {
                            MessageBox.Show("Invalid Username or password","Credentials Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
               txtpword.UseSystemPasswordChar = true;
            else
                txtpword.UseSystemPasswordChar = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            txtuname.Text = "";
            txtpword.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
