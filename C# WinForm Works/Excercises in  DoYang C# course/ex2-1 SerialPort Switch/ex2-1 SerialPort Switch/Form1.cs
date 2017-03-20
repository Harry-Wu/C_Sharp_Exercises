using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2_1_SerialPort_Switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.textBox3.KeyDown += new KeyEventHandler(textBox3_KeyDown);//这句不能省

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            SearchAndAddSerialToComboBox(serialPort1, cboSerial);       //扫描并将可用串口添加至下拉列表
        }

        private void btnSerial_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                }
                catch { }
                btnSerial.Text = "打开串口";
                btnSerial.BackColor = Color.OrangeRed;
            }
            else
            {
                try
                {
                    serialPort1.PortName = cboSerial.Text;  //选择下拉列表框选中的端口号
                    serialPort1.Open();  //打开端口
                    btnSerial.Text = "关闭串口";
                    btnSerial.BackColor = Color.Chartreuse;
                }
                catch 
                {
                    MessageBox.Show("串口打开失败", "错误", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
        }

        //扫描并将可用串口添加至下拉列表
        private void SearchAndAddSerialToComboBox(SerialPort MyPort, ComboBox MyBox)
        {
            var MyString = new string[20];
            string Buffer;  //缓存
            MyBox.Items.Clear();
            for (int i = 1; i < 21; i++)
            {
                try
                {
                    Buffer = "COM" + i.ToString();
                    MyPort.PortName = Buffer;
                    MyPort.Open();  ////如果失败，后面的代码不会执行,直接跳到catch
                    MyString[i - 1] = Buffer;
                    MyBox.Items.Add(Buffer); //打开成功，添加至下拉列表
                    MyPort.Close();
                }
                catch {}
            }
            MyBox.Text = MyString[0]; //扫描完所有的端口后,将第一个可用端口添加到ComboBox
        }

        //设置电压电流的函数

            //设置CHANNEL1电压
        void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Test");
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
