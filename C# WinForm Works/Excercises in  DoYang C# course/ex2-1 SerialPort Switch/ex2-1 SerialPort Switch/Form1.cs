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
using ex2_1_SerialPort_Switch.Properties;

namespace ex2_1_SerialPort_Switch
{
    public partial class Form1 : Form
    {
        bool _outputStatue = false;  //输出状态flag
        public Form1()
        {
            InitializeComponent();
            this.textBox3.KeyDown += new KeyEventHandler(textBox3_KeyDown);//这句不能省
            this.textBox4.KeyDown += new KeyEventHandler(textBox4_KeyDown);//这句不能省
            this.textBox7.KeyDown += new KeyEventHandler(textBox7_KeyDown);//这句不能省
            this.textBox8.KeyDown += new KeyEventHandler(textBox8_KeyDown);//这句不能省

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived); //必须手动添加事件处理程序

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            WriteStringToSerialPort("", txtSend.Text);

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
                btnOutput.BackgroundImage = Resources.OFF;  //关
                _outputStatue = false;

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
        private void SearchAndAddSerialToComboBox(SerialPort MyPort, ComboBox myBox)
        {
            var myString = new string[20];
            string buffer;  //缓存
            myBox.Items.Clear();
            for (int i = 1; i < 21; i++)
            {
                try
                {
                    buffer = "COM" + i.ToString();
                    MyPort.PortName = buffer;
                    MyPort.Open();  ////如果失败，后面的代码不会执行,直接跳到catch
                    myString[i - 1] = buffer;
                    myBox.Items.Add(buffer); //打开成功，添加至下拉列表
                    MyPort.Close();
                }
                catch {}
            }
            myBox.Text = myString[0]; //扫描完所有的端口后,将第一个可用端口添加到ComboBox
        }

        //设置电压电流的函数

            //设置CHANNEL1电压
        void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WriteStringToSerialPort(Convert.ToString(textBox3.Tag), textBox3.Text);
                //MessageBox.Show("Test");
            }
        }
        void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WriteStringToSerialPort(Convert.ToString(textBox4.Tag), textBox4.Text);
                //MessageBox.Show("Test");
            }
        }
        void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WriteStringToSerialPort(Convert.ToString(textBox7.Tag), textBox7.Text);
                //MessageBox.Show("Test");
            }
        }
        void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WriteStringToSerialPort(Convert.ToString(textBox8.Tag), textBox8.Text);
                //MessageBox.Show("Test");
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen) //如果串口已打开
            {
                if (_outputStatue)  //如果输出开
                {
                    WriteStringToSerialPort("OUT", "0");
                    btnOutput.BackgroundImage = Resources.OFF;  //灭
                    _outputStatue = false;
                    textBox1.Text = "24";
                }
                else
                {
                    WriteStringToSerialPort("OUT", "1");
                    btnOutput.BackgroundImage = Resources.ON;  //开
                    _outputStatue = true;
                    textBox2.Text = "3.1";
                }
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            WriteStringToSerialPort("TRACK", Convert.ToString(radioButton1.Tag));

        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            WriteStringToSerialPort("TRACK", Convert.ToString(radioButton2.Tag));

        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            WriteStringToSerialPort("TRACK", Convert.ToString(radioButton3.Tag));

            
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e) //串口数据接收事件
        {
                var str = serialPort1.ReadExisting(); //字符串方式读
                txtReceive.AppendText(str);  //读取的字符显示到接收文本框
           
        }

        private void WriteStringToSerialPort(string prefix, string data)                   //单字节写入串口
        {
            var buffer = prefix + data;
            //var Buffer = new string[prefix.Length + data.Length];
            //var Buffer = new string("VSET" + data);
            if (serialPort1.IsOpen)                                     //传输数据的前提是端口已打开
            {
                try
                {
                    serialPort1.WriteLine(buffer);                    //写数据
                }
                catch
                {
                    MessageBox.Show("串口数据发送出错，请检查.", "错误");//错误处理
                    serialPort1.Close();
                    btnSerial.Text = "打开串口";
                    btnSerial.BackColor = Color.OrangeRed;
                    //btnOutput.BackgroundImage = Resources.OFF;  //关


                }
            }
            else
            {
                MessageBox.Show("请先打开串口", "错误");
                //btnOutput.BackgroundImage = Resources.OFF;  //关

            }
        }

        private void txtReceive_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
