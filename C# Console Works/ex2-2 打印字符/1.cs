using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
             for (int x=1;x<=7;x++)
            {
                for (int y=1;y<=7;y++)
                {                
                    if (x==y||x+y==8)
                    {
                        Console.Write("O");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}