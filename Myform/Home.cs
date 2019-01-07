using BLL;
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
    public partial class Home : Form
    {
        private readonly UserBll bll = new UserBll();
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = bll.GetUserList();
            this.dataGridView1.DataMember = "ds";
        }
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("您确认退出吗？", "www.cnblogs.com/jihua", MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
            {
                //Dispose();
                //Application.Exit();
                Login form = new Login();
                form.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }        

        private void add_Click(object sender, EventArgs e)
        {
            Add form = new Add();
            form.Show();
        }        
        private void edit_Click(object sender, EventArgs e)
        {
            this.textcontent.Text = "ssss";
        }
    }
}
