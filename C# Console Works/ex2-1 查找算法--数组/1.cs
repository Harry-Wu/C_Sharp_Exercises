using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //�����������飬����һ������
            int[] num = new int[] { 3,34,43,2,11,19,30,55,20};
            //�����ƴ��룬�ж���������û��7��������
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
                Console.WriteLine("��7��������");
            }
            else
            {
                Console.WriteLine("û��7��������");
            }
            Console.ReadLine();
        }
    }
}