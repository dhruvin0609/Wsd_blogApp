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
    public partial class SearchPage : Form
    {
        string search = "";
        public SearchPage(string search)
        {
            InitializeComponent();
            this.search = search;
        }

        private void SearchPage_Load(object sender, EventArgs e)
        {
            ServiceReference2.PostServiceClient service = new ServiceReference2.PostServiceClient();
            List<ServiceReference2.Post> posts = service.GetAllPosts().ToList();
            List<ServiceReference2.Post> filteredPosts = posts.Where(post => post.Title.Contains(search)).ToList();
            foreach (var po in filteredPosts)
            {

                PostCardControl postCard = new PostCardControl();
                postCard.SetPost(po.Title, po.Content, po.UserName, po.CreatedAt);
                postCard.Click += (s, ev) => {
                    PostPage postPage = new PostPage(po); // Assuming PostPage constructor accepts a post object
                    postPage.Show(); // or postPage.ShowDialog() if you want it to be modal
                };
                flowLayoutPanel1.Controls.Add(postCard);
            }
            if(filteredPosts.Count == 0)
            {
                label1.Text = "No blog found";
            }

        }
    }
}
