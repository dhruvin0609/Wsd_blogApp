using bolgAppClient.ServiceReference2;
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
    public partial class blogInfo : Form
    {
        ServiceReference2.Post post = new ServiceReference2.Post();
        public blogInfo(ServiceReference2.Post po)
        {
            post = po;
            InitializeComponent();
        }
        private void blogInfo_Load(object sender, EventArgs e)
        {
            textBox1.Text = post.Title;
            textBox2.Text = post.Content;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           ServiceReference2.PostServiceClient sevice = new ServiceReference2.PostServiceClient();
            sevice.UpdatePost(post.Id, textBox1.Text, textBox2.Text);
            profilePage profilePage = new profilePage();
            this.Hide();
            profilePage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceReference2.PostServiceClient sevice = new ServiceReference2.PostServiceClient();
            sevice.DeletePost(post.Id);
            profilePage profilePage = new profilePage();
            this.Hide();
            profilePage.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceReference3.CommentServiceClient com = new ServiceReference3.CommentServiceClient();
            List<ServiceReference3.Comment> comments = com.GetCommentsByPostId(post.Id).ToList();
            int yPos = 150; // Initial Y position for the comment controls
            foreach (var comment in comments)
            {
                Label commentLabel = new Label();
                commentLabel.AutoSize = true;
                commentLabel.Text = $"{comment.UserName}: {comment.Content}";
                commentLabel.Location = new Point(20, yPos);

                flowLayoutPanel1.Controls.Add(commentLabel); // Assuming flowLayoutPanel1 is the container for comments
                yPos += commentLabel.Height + 5; // Adjust Y position for the next comment
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            profilePage pp = new profilePage();
            this.Hide();
            pp.Show();

        }
    }
}
