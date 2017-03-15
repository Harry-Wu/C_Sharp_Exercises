using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            //string str;
            for (int i = 0; i < 256; i++)
            {
                var str = i.ToString("x").ToUpper();
                if (str.Length == 1)
                {
                    str = "0" + str; //if str is 0xA, then add 0 to change to 0x0A
                }
                comboBox1.Items.Add("0x" + str); //add "0x"
            }
            comboBox1.Text = "0x00"; //defaul value
            lblCOM.Text = serialPort1.PortName;
            lblBaud.Text = "BaudRate:" + Convert.ToString(serialPort1.BaudRate);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = comboBox1.Text; //save the data in comboBox
            var converdata = data.Substring(2, 2); //select the last two characters
            byte[] bufferBytes = new byte[1]; //only save 1 Byte data
            bufferBytes[0] = Convert.ToByte(converdata, 16); //convert converdata to Byte
            try
            {
                serialPort1.Open();
                serialPort1.Write(bufferBytes, 0, 1);
                serialPort1.Close();
            }
            catch //do this if something wrong
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
                MessageBox.Show("Port Error!", "Error");
            }
        }
    }
}
