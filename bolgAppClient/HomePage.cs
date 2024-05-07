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
        ServiceReference2.PostServiceClient post = new ServiceReference2.PostServiceClient();

        private void button1_Click(object sender, EventArgs e)
        {
            using (var addPostForm = new AddPostForm())
            {
                if (addPostForm.ShowDialog() == DialogResult.OK)
                {
                    string postTitle = addPostForm.PostTitle;
                    string postContent = addPostForm.PostContent;
                    post.CreatePost(postTitle, postContent,SessionManager.UserId);
                    flowLayoutPanel1.Controls.Clear();

                    List<ServiceReference2.Post> posts = post.GetAllPosts().ToList();

                    foreach (var po in posts)
                    {

                        PostCardControl postCard = new PostCardControl();
                        postCard.SetPost(po.Title, po.Content,po.UserName,po.CreatedAt);
                        postCard.Click += (s, ev) => {
                            PostPage postPage = new PostPage(po); // Assuming PostPage constructor accepts a post object
                            postPage.Show(); // or postPage.ShowDialog() if you want it to be modal
                        };
                        flowLayoutPanel1.Controls.Add(postCard);
                    }
                }
            }
           
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

            List<ServiceReference2.Post> posts = post.GetAllPosts().ToList();
           
            Console.WriteLine(posts.Count);
            foreach (var po in posts)
            {
                Console.WriteLine(po.Title);    
                
                PostCardControl postCard = new PostCardControl();
                postCard.SetPost(po.Title, po.Content,po.UserName,po.CreatedAt);
                postCard.Click += (s, ev) => {
                    PostPage postPage = new PostPage(po); // Assuming PostPage constructor accepts a post object
                    postPage.Show(); // or postPage.ShowDialog() if you want it to be modal
                };
                flowLayoutPanel1.Controls.Add(postCard);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            profilePage pp = new profilePage();
            this.Hide();
            pp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SessionManager.UserId = -1;
            login l = new login();
            this.Hide();
            l.Show();   

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchPage s = new SearchPage(textBox1.Text);
            s.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
