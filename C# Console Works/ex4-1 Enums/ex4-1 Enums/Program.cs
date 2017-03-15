using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_1_Enums
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3,
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());

            Console.WriteLine(method);

            var methodName = "RegularAirMail";
            var methodName2 = "RegisteredAirMail";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod),methodName);
            var shippingMethod2 = Enum.Parse(typeof(ShippingMethod), methodName2);
            Console.WriteLine(shippingMethod);
            Console.WriteLine(shippingMethod2);

        }
    }
}
