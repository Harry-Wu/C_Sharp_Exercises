using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1_1_DY_定时器
{
    public partial class Form1 : Form
    {
        private int count;
        private int time;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int i;
            for (int i = 0; i < 100; i++)
            {
                cboxTime.Items.Add(i.ToString() + "秒");
            }
            //lblTime.Text = 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            lblTime.Text = (time - count).ToString() + "秒"; //显示剩余时间
            progressBar1.Value = count;  //设置进度条进度
            if (count == time)
            {
                timer1.Stop();  //时间到,停止定时器
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show("定时时间到了!", "提示");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string str = cboxTime.Text;
            time = Convert.ToInt16(str.Substring(0, 2));  //得到设定定时值(整形)
            progressBar1.Maximum = time; //进度条最大数值
            timer1.Start();
        }
    }
}
