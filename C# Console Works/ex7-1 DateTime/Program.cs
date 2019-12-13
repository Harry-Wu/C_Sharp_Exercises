using System;

namespace ex7_1_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2019, 12, 10);
            var now = DateTime.Now;
            var today = DateTime.Today;
            var yesterday = DateTime.Today.AddDays(-1);
            var tomorrow = DateTime.Today.AddDays(1);


            Console.WriteLine("当前时间是: " + "Hour: " + now.Hour + "  Minute: " + now.Minute + "  Second: " + now.Second);
            Console.WriteLine("当前日期是: " + today);
            Console.WriteLine("当前日期是: " + today.ToString());
            Console.WriteLine("当前日期ToLongDateString是: " + today.ToLongDateString());
            Console.WriteLine("当前日期ToShortDateString是: " + today.ToShortDateString());
            Console.WriteLine("当前时间是: " + now);
            Console.WriteLine("当前时间是: " + now.ToString());
            Console.WriteLine("当前时间ToLongTimeString是: " + now.ToLongTimeString());
            Console.WriteLine("当前时间ToShortTimeString是: " + now.ToShortTimeString());
            Console.WriteLine("昨天日期是: " + yesterday);
            Console.WriteLine("明天日期是: " + tomorrow);
        }
    }
}
