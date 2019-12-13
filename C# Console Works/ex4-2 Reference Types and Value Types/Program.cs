using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_2_Reference_Types_and_Value_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10.2f;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a:{0}, b:{1}", a, b));
            Console.WriteLine("a:{0}, b:{1}", a, b);

            var array1 = new int[3] {1, 2, 3};
            var array2 = array1;
            array2[0] = 0;

            Console.WriteLine("array1[0]:{0}, array2[0]:{1}", array1[0], array2[0]);
        }
    }
}
