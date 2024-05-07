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
    public partial class PostPage : Form
    {
        ServiceReference2.Post post = new ServiceReference2.Post();
        public string CommentContent { get; private set; }
        public PostPage(ServiceReference2.Post post)
        {
            this.post = post;
            InitializeComponent();
        }

        private void PostPage_Load(object sender, EventArgs e)
        {
            label3.Text = post.Title;
            label4.Text = post.Content;
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            using (var addCommentForm = new AddCommentForm())
            {
                if (addCommentForm.ShowDialog() == DialogResult.OK)
                {
                    string commentContent = addCommentForm.CommentContent;
                    ServiceReference3.CommentServiceClient comm = new ServiceReference3.CommentServiceClient();
                    comm.CreateComment(commentContent, post.Id, SessionManager.UserId);
                    flowLayoutPanel1.Controls.Clear();

                    // Fetch and display all comments again
                    List<ServiceReference3.Comment> comments = comm.GetCommentsByPostId(post.Id).ToList();
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
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            this.Hide();
            homePage.Show();

        }
    }
}
