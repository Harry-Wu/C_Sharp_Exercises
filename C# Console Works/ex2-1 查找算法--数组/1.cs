using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //声明整型数组，保存一组整数
            int[] num = new int[] { 3,34,43,2,11,19,30,55,20};
            //请完善代码，判断数组中有没有7的整倍数
            bool has7 = false;
            foreach(int x in num)
            {
                if(x%7==0) 
                {
                    has7=true;
                    break;
                }
            }
            if(has7)
            {
                Console.WriteLine("有7的整倍数");
            }
            else
            {
                Console.WriteLine("没有7的整倍数");
            }
            Console.ReadLine();
        }
    }
}