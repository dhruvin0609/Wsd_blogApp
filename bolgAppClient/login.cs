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
    public partial class login : Form
    {
        

        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.UserServiceClient user = new ServiceReference1.UserServiceClient();
            string email = textBox1.Text;
            string password = textBox2.Text;
            int result = user.Login(email, password);
            if(result == -1) {
                textBox1.Text = "Invalid email or password";
            }
            else
            {
                SessionManager.UserId = result;
            
                Console.WriteLine(result);  
                this.Hide();
                // Open new form (HomePage in this example)
                HomePage homePage = new HomePage();
                homePage.Show();
            }
        }
    }
}
