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
            string[] name = new string[] {"吴松","钱东宇","伏晨","陈陆","周蕊","林日鹏","何昆","关欣"};
            int[] score = new int[] {89,90,98,56,60,91,93,85};
            //请完善代码，判断数组中有没有7的整倍数
            int highest,i,j;
            highest = 0; i = 0; j=0;
            foreach(int x in score)
            {                
                if(highest<x) 
                {
                    highest = x;
                    j = i;
                }
                i++;
            }
            Console.WriteLine("分数最高的是"+name[j]+",分数是"+highest);
            Console.ReadLine();
        }
    }
}