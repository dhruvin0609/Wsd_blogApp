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
    public partial class AddCommentForm : Form
    {
        public string CommentContent { get; private set; }
        public AddCommentForm()
        {
            InitializeComponent();
        }

        private void AddCommentForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CommentContent = textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
