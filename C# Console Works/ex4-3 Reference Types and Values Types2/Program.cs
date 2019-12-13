using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_3_Reference_Types_and_Values_Types2
{
    public class Person
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //C#中的值类型（value type）与引用类型（reference type）的区别
            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            var person = new Person() {Age = 27};
            MakeOld(person);
            Console.WriteLine(person.Age);
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
