using blogAppLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blogAppHost2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (ServiceHost userServiceHost = new ServiceHost(typeof(UserService)))
            {
                userServiceHost.Open();
                label1.Text = "UserService Running";
            }

            // Host PostService
            using (ServiceHost postServiceHost = new ServiceHost(typeof(PostService)))
            {
                postServiceHost.Open();
                label2.Text = "PostService Running";
            }

            // Host CommentService
            using (ServiceHost commentServiceHost = new ServiceHost(typeof(CommentService)))
            {
                commentServiceHost.Open();
                label3.Text = "CommentService Running";
            }
        }
    }
}
