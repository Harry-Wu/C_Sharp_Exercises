using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var detaTime = new DateTime(2019,12,10);
            var now = DateTime.now;
            var today = DateTime.today;
            
            
            Console.WriteLine("当前时间是: " + now.Hour + now.Minute + now.Second);
            Console.WriteLine("当前日期是: " + today);

            



        }
    }
}
