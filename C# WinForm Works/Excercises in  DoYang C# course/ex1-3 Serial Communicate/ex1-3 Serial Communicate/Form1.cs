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

namespace ex1_2_SerialPort_Send_hex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 20; i++)
            {
                cboSerial.Items.Add("COM" + i.ToString()); //defual serial port list
            }
            cboSerial.Text = "COM1"; //defaul value
            cboBaud.Text = Convert.ToString(serialPort1.BaudRate);  //default BaudRate

            serialPort1.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived); //必须手动添加事件处理程序
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //var data = cboSerial.Text; //save the data in comboBox
            //var converdata = data.Substring(2, 2); //select the last two characters
            byte[] bufferBytes = new byte[1]; //only save 1 Byte data
            if (serialPort1.IsOpen) //判断串口是否打开
            {
                if (txtSend.Text != "")  //只要发送的不是空的
                {
                    if (!radioButton1.Checked) //如果发送是字符模式
                    {
                        try
                        {
                            serialPort1.WriteLine(txtSend.Text); //写数据
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show("串口数据写入错误", "写入错误");
                            serialPort1.Close();
                            btnOpen.Enabled = true;
                            btnClose.Enabled = false;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < (txtSend.Text.Length-txtSend.Text.Length%2)/2; i++)  //两个字符一个byte
                        {
                            bufferBytes[0] = Convert.ToByte(txtSend.Text.Substring(i * 2, 2), 16);
                            serialPort1.Write(bufferBytes, 0, 1); //循环发送（如果输入字符为0A0BB,则只发送0A,0B）
                        }
                        if (txtSend.Text.Length % 2 != 0) //剩下一个奇数位单独处理
                        {
                            bufferBytes[0] = Convert.ToByte(txtSend.Text.Substring(txtSend.Text.Length - 1, 1), 16);
                            serialPort1.Write(bufferBytes, 0, 1);
                        }
                    }
                }
            }
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e) //串口数据接收事件
        {
            if (!radioButton3.Checked) //如果接收为字符模式
            {
                var str = serialPort1.ReadExisting(); //字符串方式读
                txtReceive.AppendText(str);
            }
            else //如果接收为数值模式
            {
                byte data = (byte)serialPort1.ReadByte(); //此处需要强制类型转换，将(int)类型数据转换为(byte)类型数据，不必考虑是否会丢失数据
                var str = Convert.ToString(data, 16).ToUpper(); //将byte数值转换为16进制字符串
                txtReceive.AppendText("0x" + (str.Length == 1 ? "0"+str : str) + " ");
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cboSerial.Text;
                serialPort1.BaudRate = Convert.ToInt32(cboBaud.Text);
                serialPort1.Open();
                btnOpen.Enabled = false;
                btnClose.Enabled = true;
            }
            catch
            {
                MessageBox.Show("端口打开错误,请检查串口", "错误");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close(); //关闭串口
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}
