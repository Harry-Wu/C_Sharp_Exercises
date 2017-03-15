
//****************************** Module Header ******************************\
//Module Name:    Program.cs
//Project:        Serialport_communication
//Copyright (c) Microsoft Corporation

// The project illustrates how to check whether a file is in use or not.

//This source is subject to the Microsoft Public License.
//See http://www.microsoft.com/en-us/openness/resources/licenses.aspx#MPL.
//All other rights reserved.

//*****************************************************************************/

using System;
using System.Collections.Generic;
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
                        Console.WriteLine("YOU WROTE:" + sendMessage);
                        myserialPort.WriteLine(sendMessage);
                        byte[] encodeBytes = System.Text.Encoding.GetEncoding("gb2312").GetBytes(myserialPort.ReadLine());
                        //GetEncoding("gb2312")
                        var line = System.Text.Encoding.GetEncoding("gb2312").GetString(encodeBytes);
                        Console.WriteLine("You sent a message just now, it's " + line);
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
    }
}
