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
    public partial class print8 : Form
    {
        public print8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
             DialogResult prnt_dia = printDialog1.ShowDialog(this);
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(print_page);
            printDocument1.Print();
        }

        private void print_page(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Image.FromFile("C:\\Users\\Hp\\Pictures"), 50,100,200,200);
            e.Graphics.DrawString("Mobile Inventory Invoice",new Font("Times New Roman",24,FontStyle.Bold,GraphicsUnit.Pixel),Brushes.Blue,300,150);
            e.Graphics.DrawString("Items Delivered to the customer", new Font("Times New Roman", 20, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, 50, 350);
            e.Graphics.DrawString("Item Code", new Font("Times New Roman", 17, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Blue, 50, 380);
            e.Graphics.DrawString("Item Unit Price", new Font("Times New Roman", 17, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Blue, 200, 380);
            e.Graphics.DrawString("Item Quantity", new Font("Times New Roman", 17, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Blue, 350, 380);
            e.Graphics.DrawString("Total Item Line Price", new Font("Times New Roman", 17, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Blue, 500, 380);
            SqlConnection connection1 = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=Inventorydp;Integrated Security=True");
            connection1.Open();
            SqlCommand command1 = new SqlCommand("select * from Transaction_Save",connection1);
            SqlDataReader dr = command1.ExecuteReader();
            int height = 430;
            while (dr.Read())
            {
                e.Graphics.DrawString(dr.GetString(3), new Font("Times New Roman", 17, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Blue, 50, height);
                e.Graphics.DrawString(dr.GetDecimal(4).ToString(), new Font("Times New Roman", 17, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Blue, 200, height);
                e.Graphics.DrawString(dr.GetInt32(5).ToString(), new Font("Times New Roman", 17, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Blue, 350, height);
                e.Graphics.DrawString(dr.GetDecimal(6).ToString(), new Font("Times New Roman", 17, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Blue, 500, height);
                height = height + 50;
            }

            connection1.Close();
            SqlConnection connection3 = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=Inventorydp;Integrated Security=True");
            connection3.Open();
            e.Graphics.DrawString("Total Purchased Cost   : ", new Font("Times New Roman", 17, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Blue, 50, (height+50));
            SqlCommand command2 = new SqlCommand("select sum(itm_line_tot) from Transaction_Save",connection3);
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                e.Graphics.DrawString(dr2.GetDecimal(0).ToString(), new Font("Times New Roman", 17, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Blue, 300, (height + 50));
            }

        }
    }
}
