using BLL;
using Model;
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
    public partial class Login : Form
    {
        private readonly UserBll bll=new UserBll();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserInfo model = new UserInfo();
            model.Name = this.UserName.Text;
            model.PassWord = this.Password.Text;
            if (bll.userLogin(model))
            {
                Home form = new Home();
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("登录失败");
            }
           
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键
            {
                this.button1_Click(sender, e);//触发button事件
            }
        }
        

        private void UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键
            {
                this.button1_Click(sender, e);//触发button事件
            }
        }
    }
}
