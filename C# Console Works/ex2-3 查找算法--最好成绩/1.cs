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
            string[] name = new string[] {"����","Ǯ����","����","��½","����","������","����","����"};
            int[] score = new int[] {89,90,98,56,60,91,93,85};
            //�����ƴ��룬�ж���������û��7��������
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
            Console.WriteLine("������ߵ���"+name[j]+",������"+highest);
            Console.ReadLine();
        }
    }
}