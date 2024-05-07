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
    public partial class AddPostForm : Form
    {
        public string PostTitle { get; private set; }
        public string PostContent { get; private set; }
        public AddPostForm()
        {
            InitializeComponent();
        }

        private void AddPostForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PostTitle = textBox1.Text;
            PostContent = textBox2.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
