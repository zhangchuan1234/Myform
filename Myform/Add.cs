using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Myform
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            this.label1.Text = "2018-5-8";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Parse(this.label1.Text);
            this.label2.Text = time.ToString();
        }
    }
}
