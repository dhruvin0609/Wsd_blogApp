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
    public partial class profilePage : Form
    {
        public profilePage()
        {
            InitializeComponent();
        }
        ServiceReference2.PostServiceClient post = new ServiceReference2.PostServiceClient();
        private void profilePage_Load(object sender, EventArgs e)
        {

            List<ServiceReference2.Post> posts = post.GetPostsByUserId(SessionManager.UserId).ToList();
            ServiceReference1.UserServiceClient user = new ServiceReference1.UserServiceClient();
            ServiceReference1.User u = user.GetUser(SessionManager.UserId);

            label2.Text = u.UserName;
            label4.Text = u.Email;
            Console.WriteLine(posts.Count);
            foreach (var po in posts)
            {
                Console.WriteLine(po.Title);

                PostCardControl postCard = new PostCardControl();
                postCard.SetPost(po.Title, po.Content, po.UserName, po.CreatedAt);
                postCard.Click += (s, ev) => {
                    blogInfo bi = new blogInfo(po); 
                    this.Hide();
                    bi.Show();
                };
                flowLayoutPanel1.Controls.Add(postCard);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            this.Hide();
            homePage.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
