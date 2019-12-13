using System;

namespace ex7_2_TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建timeSpan实例，TimeSpan是构造函数
            var timeSpan = new TimeSpan(1, 2, 3);

            Console.WriteLine(timeSpan);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(25);
            var duration = end - start;
            Console.WriteLine(duration);

            //参数Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("TotalMinutes: " + timeSpan.TotalMinutes);
            Console.WriteLine("TotalHours: " + timeSpan.TotalHours);
            Console.WriteLine("ToString: " + timeSpan.ToString());
            Console.WriteLine("timSpan: " + timeSpan);

        }
    }
}
