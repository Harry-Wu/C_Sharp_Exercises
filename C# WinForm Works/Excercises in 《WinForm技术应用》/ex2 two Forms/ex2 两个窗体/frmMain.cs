using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2_two_Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRegistor_Click(object sender, EventArgs e)
        {
            string name = this.textName.Text;
            string pwd = this.textPwd.Text;
            string remark = this.textRemark.Text;
            if (name.Contains(" "))
            {
                MessageBox.Show("用户名不能包含空格!", "内容非法");
                return;
            }
            if (name.Length < 4)
            {
                MessageBox.Show("用户名不能少于4个字符!", "内容非法");
                return;
            }
            if (pwd.Length < 6)
            {
                MessageBox.Show("密码不能少于6个字符!", "内容非法");
                return;

            }
            string info = name + "\r\n" + pwd + "\r\n" + remark;

            frmShow frmShow = new frmShow();
            frmShow.Show();
            frmShow.SetInfo(info);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRemark_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("你确定要取消注册吗?", "确认取消",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.textName.Text = "";
                this.textPwd.Text = "";
                this.textRemark.Text = "";
            }
        }
    }
}
