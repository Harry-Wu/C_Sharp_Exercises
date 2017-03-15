using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6_1_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersArray = new int[] {3, 7, 9, 2, 14, 6};
            Console.WriteLine("Orignal array:");
            foreach (var n in numbersArray)
            {
                Console.Write(n);
                Console.Write("\t");
            }
            Console.WriteLine();

            //Length
            Console.WriteLine("Lenght of numberArray is " + numbersArray.Length);
            //Console.WriteLine();

            //Index
            var tagNumber = 14;
            var index = Array.IndexOf(numbersArray, tagNumber);
            Console.WriteLine("The index of {0} is {1}.", tagNumber, index);

            //clear
            Array.Clear(numbersArray,1,2);
            Console.WriteLine("Effect of clear:");
            foreach (var n in numbersArray)
            {
            Console.WriteLine(n);
            }

            //copy
            int[] newArray = new int[3];
            Array.Copy(sourceArray: numbersArray, destinationArray: newArray, length: 3);
            //newArray = numbersArray.CopyTo();
            Console.WriteLine("Effect of copy:");
            foreach (var n in newArray)
            {
                Console.WriteLine(n);
            }

            //sort
            Array.Sort(numbersArray);
            Console.WriteLine("Effect of sort:");
            foreach (var n in numbersArray)
            {
                Console.WriteLine(n);
            }
        }
    }
}
