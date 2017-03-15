using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2_2_Choose_Student
{
    public partial class Form2Rename : Form
    {
        private Form1 form1 = null;

        //private Form1 form1 = null;  //用来引用第一个窗体
        public Form2Rename()
        {
            InitializeComponent();
        }

        //新添加的构造方法，用来获得对第一个窗体的引用
        public Form2Rename(Form1 form1)
        {
            InitializeComponent();

            this.form1 = form1;
        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("你确定要取消吗?", "确认取消", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                
            }

        }


        private void btnEnter_Click(object sender, EventArgs e)
        {
            //Form1 form1 = new Form1();
            //form1.Show();
            
            form1.SetName(textRename.Text);
            Close();
        }
    }
}
