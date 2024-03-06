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
        public void SetPost(string title, string content)
        {
            titleLabel.Text = title;
            contentLabel.Text = content;
        }

        private void contentLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
