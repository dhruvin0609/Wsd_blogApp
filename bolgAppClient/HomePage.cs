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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            label1.Text = SessionManager.UserId.ToString();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            ServiceReference2.PostServiceClient post = new ServiceReference2.PostServiceClient();

            List<ServiceReference2.Post> posts = post.GetAllPosts().ToList();

            foreach (var po in posts)
            {
                PostCardControl postCard = new PostCardControl();
                postCard.SetPost(po.Title, po.Content);
                flowLayoutPanel1.Controls.Add(postCard);
            }

        }
    }
}
