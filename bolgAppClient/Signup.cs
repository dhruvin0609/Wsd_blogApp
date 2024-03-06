using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bolgAppClient
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.UserServiceClient user = new ServiceReference1.UserServiceClient();
            string username = textBox1.Text;
            string email = textBox2.Text;
            string pasword = textBox3.Text;
            user.CreateUser(username, email, pasword);
            this.Hide();
            // Open new form (HomePage in this example)
            // Open new form (HomePage in this example)
            login l = new login();
            l.Show();
        }
    }
}
