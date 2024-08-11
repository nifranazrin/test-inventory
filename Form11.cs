using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Inventory_Mobile_1
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void btnsbscribe_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mm = new MailMessage();
                mm.From = new MailAddress("nifranazrin@gmail.com");
                mm.To.Add(new MailAddress("nifranazrin@gmail.com"));
                mm.Subject = "Mobile Inventory Subscription";
                mm.Body = "Hi, This is a sample email message from Mobile Inventory Store ....";
                mm.IsBodyHtml = true;

                SmtpClient sc = new SmtpClient();
                sc.Host = "smtp.gmail.com";
                sc.Port = 587; // Gmail's SMTP port for TLS/STARTTLS
                sc.EnableSsl = true;
                sc.DeliveryMethod = SmtpDeliveryMethod.Network;

                // Set your Gmail credentials
                sc.Credentials = new NetworkCredential("nifranazrin@gmail.com", "nazrin128#nif");

                sc.Send(mm);

                MessageBox.Show("Successfully Email has been sent to the customer", "Subscription Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Form11_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cashier6 f1 = new cashier6();
          
          
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
