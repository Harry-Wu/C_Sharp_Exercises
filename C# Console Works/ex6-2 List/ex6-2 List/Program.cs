using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6_2_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            Console.WriteLine("Original List:");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);  
            }
            //Add
            Console.WriteLine("Effect of Add:");
            numbers.Add(1);
            numbers.AddRange(new int[3] {5, 6, 7});

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
            //Console.WriteLine();
            //Index
            Console.WriteLine("Effect of Index:");
            Console.WriteLine(numbers.IndexOf(1));
            Console.WriteLine(numbers.LastIndexOf(1));

            //Count
            Console.WriteLine("Effect of Count:");
            Console.WriteLine("Count:" + numbers.Count);

            //Remove
            //下面这样是错误的,在foreach循环里不能修改集合
            //foreach (var n in numbers)
            //{
            //    if (n ==1)
            //    {
            //        numbers.Remove(1);
            //    }
            //}
            Console.WriteLine("Effect of Remove:");
            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            //Clear
            Console.WriteLine("Effect of Clear:");
            numbers.Clear();
            Console.WriteLine("Count:" + numbers.Count);



        }
    }
}
