using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.SqlClient;

namespace Inventory_Mobile_1
{
    public partial class stfMngReport10 : Form
    {
        public stfMngReport10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            DialogResult prnt_dia = printDialog1.ShowDialog(this);
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(print_staff_report);
            printDocument1.Print();
        }

        private void print_staff_report(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Image.FromFile("C:\\Users\\Hp\\Pictures\\Saved Pictures\\CellCareShop.jpg"), 50, 100, 200, 200);
            e.Graphics.DrawString("Staff Management Report", new Font("Times New Roman", 24, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Blue, 300, 150);
            e.Graphics.DrawString("Daily Employee Registration Details", new Font("Times New Roman", 20, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 50, 350);
            e.Graphics.DrawString("Employee Full Name", new Font("Times New Roman", 17, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Blue, 50, 380);
            e.Graphics.DrawString("Designation", new Font("Times New Roman", 17, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Blue, 350, 380);
            //e.Graphics.DrawString("Item Quantity", new Font("Times New Roman", 17, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Blue, 350, 380);
            //e.Graphics.DrawString("Total Item Line Price", new Font("Times New Roman", 17, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Blue, 500, 380);
            SqlConnection connection1 = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=Inventorydp;Integrated Security=True");
            connection1.Open();
            SqlCommand command1 = new SqlCommand("select * from Employee_Details", connection1);
            SqlDataReader dr = command1.ExecuteReader();
            int height = 430;
            while (dr.Read())
            {
                e.Graphics.DrawString(dr.GetString(1)+" "+dr.GetString(2)+" "+dr.GetString(3), new Font("Times New Roman", 17, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Blue, 50, height);
                e.Graphics.DrawString(dr.GetString(4), new Font("Times New Roman", 17, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Blue, 350, height);
                //e.Graphics.DrawString(dr.GetInt32(5).ToString(), new Font("Times New Roman", 17, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Blue, 350, height);
                //e.Graphics.DrawString(dr.GetDecimal(6).ToString(), new Font("Times New Roman", 17, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Blue, 500, height);
                height = height + 50;
            }

            connection1.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
