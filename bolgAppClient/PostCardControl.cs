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
    public partial class PostCardControl : UserControl
    {
        public PostCardControl()
        {
            InitializeComponent();
        }

        private void PostCardControl_Load(object sender, EventArgs e)
        {

        }
        public void SetPost(string title, string content, string username, DateTime dt)
        {
            titleLabel.Text = title;
            contentLabel.Text = content;
            label1.Text = username;
            label2.Text = dt.ToString();    
        }

        private void contentLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
