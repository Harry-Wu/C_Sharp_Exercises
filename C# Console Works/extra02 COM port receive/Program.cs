
//****************************** Module Header ******************************\

//*****************************************************************************/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;

namespace Serialport_communication
{
    class Program
    {
        static void Main(string[] args)
        {


            var ports = SerialPort.GetPortNames();
            //SerialPort myserialPort = null;
            
            Console.WriteLine("The following serial ports were found:");
            if (ports == null)
            {
                Console.WriteLine("No COM port on this PC");
            }

            foreach (string port in ports)
            {
                   //OpenAndCommunicateport(port);
                   Console.WriteLine(port);
            }
            Console.WriteLine("Please choose which COM port you want to open?");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 0: OpenAndCommunicateport(ports[0]);
                    break;
                case 1: OpenAndCommunicateport(ports[1]);
                    break;
                case 2:
                    OpenAndCommunicateport(ports[2]);
                    break;

            }
            
                //myserialPort = new SerialPort(ports[1], 9600, Parity.None, dataBits: 8);
                //myserialPort.StopBits = (StopBits)1;
                //myserialPort.Open();
                
        }

        public static void OpenAndCommunicateport(string str)
        {
            SerialPort myserialPort;
            //myserialPort = new SerialPort(str, 9600, Parity.None, 8);
            myserialPort = new SerialPort(str, 9600,Parity.None, dataBits:8);
            myserialPort.StopBits = (StopBits) 1;
            try
            { 
                myserialPort.Open(); //open th eserial port
                //myserialPort.Write("test");
                //byte[] data = Encoding.Unicode.GetBytes(textBox1.Text);
                //string str = Convert.ToBase64String(data);
                //myserialPort.WriteLine("Test1");
                //myserialPort.WriteLine("Test2");
                //myserialPort.WriteLine("Test3");
                //myserialPort.WriteLine("Test4");
                var tryAgain = true;
                
                //string line = (string)myserialPort.ReadLine();
                //var sendMessage = Console.ReadLine();
                while (tryAgain)
                {
                    Console.WriteLine("Please send message, type \"Q\" to stop sending:");
                    var sendMessage = Console.ReadLine();
                    if(sendMessage != "q" && sendMessage != "Q")
                    {
                        System.Text.Encoding GB2312 = System.Text.Encoding.GetEncoding("GB2312");
                        System.Text.Encoding UTF8 = System.Text.Encoding.UTF8;

                        //先将中文字符编码后再发送。接收时，将数据解码还原成中文
                        //发送数据时，将字符串当成byte数组发送（对方会处理）；接收数据时，将数据放到byte数组里，然后通过Encoding转换成相应编码的字符串再显示出来
                        //Console.WriteLine("You send:" + sendMessage);
                        if (sendMessage != null)
                        {
                            byte[] writeBytes = GB2312.GetBytes(sendMessage);
                            //var sendMessageConv = StringToUnicode(sendMessage);
                            myserialPort.Write(writeBytes, 0, writeBytes.Length);
                        }

                        //Byte[] readBytes = new Byte[serialPort.BytesToRead];
                        //serialPort.Read(readBytes, 0, readBytes.Length);
                        //String decodedString = utf8.GetString(readBytes);
                        Console.WriteLine("Waiting to receive messages...");
                        //myserialPort.ReadLine();
                        while (myserialPort.BytesToRead == 0) ;  //Just wait
                        //{
                            byte[] encodeBytes = new byte[myserialPort.BytesToRead];
                            myserialPort.Read(encodeBytes, 0, encodeBytes.Length);
                            var decodeBytes = GB2312.GetString(encodeBytes);
                            Console.WriteLine("You get a message, it's " + decodeBytes);
                        //}
                        
                    }
                    else
                    {
                        tryAgain = false;
                        Console.WriteLine("Stop sending message!");
                    }
                    
                }
                myserialPort.Close();

                //OpenAndCommunicateport("COM4");
                Console.ReadLine();

                //byte[] data = Convert.FromBase64String(myserialPort.ReadLine());
                //Console.WriteLine(Encoding.Unicode.GetString(data));

                //byte b = (byte)myserialPort.ReadByte(); ///read a byte
                //char c = (char)myserialPort.ReadChar(); // read a char
                //string line = (string)myserialPort.ReadLine(); //read a whole line
                //string all = (string)myserialPort.ReadExisting(); //read everythin in the buffer

                /////print all the results
                //Console.WriteLine("Byte: " + b);
                //Console.WriteLine("Char: " + c);
                //Console.WriteLine("Line: " + line);
                //Console.WriteLine("All: " + all);


                myserialPort.Close();
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex);
            }
        }

        /// <summary>
        　　/// C# Unicode转字符串
        　　/// </summary>
        　　/// <param name="text">Unicode</param>
        　　/// <returns>字符串</returns>
        public static string UnicodeToString(string text)
        {
            if (string.IsNullOrEmpty(text)) return null;

            string temp = null;
            bool flag = false;

            int len = text.Length / 4;
            if (text.StartsWith("0x") || text.StartsWith("0X"))
            {
                len = text.Length / 6;//Unicode字符串中有0x
                flag = true;
            }

            StringBuilder sb = new StringBuilder(len);
            for (int i = 0; i < len; i++)
            {
                if (flag)
                    temp = text.Substring(i * 6, 6).Substring(2);
                else
                    temp = text.Substring(i * 4, 4);

                byte[] bytes = new byte[2];
                bytes[1] = byte.Parse(int.Parse(temp.Substring(0, 2), NumberStyles.HexNumber).ToString());
                bytes[0] = byte.Parse(int.Parse(temp.Substring(2, 2), NumberStyles.HexNumber).ToString());
                sb.Append(Encoding.Unicode.GetString(bytes));
            }
            return sb.ToString();
        }

        /// <summary>
        　　/// C# 字符串转换Unicode
        　　/// </summary>
        　　/// <param name="text">字符串</param>
        　　/// <returns>Unicode编码</returns>
        public static string StringToUnicode(string text)
        {
            bool flag = false;
            string strUni = null;
            string temp = null;

            foreach (char c in text)
            {
                temp = string.Format("{0:x}", (int)c);

                if (temp.Length < 3)
                    temp = "00" + temp;

                if (flag)
                    strUni += ",0x" + temp;
                else
                    strUni += "0x" + temp;

                if (!flag)
                    flag = true;
            }
            return strUni;
        }
    }
}
