/*1- Write a program and ask the user to enter a number.The number should be between 1 to 10. 
//If the user enters a valid number, display "Valid" on the console.Otherwise, display "Invalid". 
//(This logic is used a lot in applications where values entered into input boxes need to be validated.)
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_1_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //其他类里面的Method要想先使用，就得先定义一个类类型的对象
            Conditions myConditions = new Conditions();
            var playAgain = true;
            var flagQuit = false;
            while (playAgain && !flagQuit)
            {
                myConditions.Exercise1();
                Console.WriteLine("Do you want to play again:");
                Console.WriteLine("1. Press Y to play again?");
                Console.WriteLine("2. Press N to play next program(Y/N)?");
                Console.WriteLine("3. Press Q to quit Executable Program(Q)?");
                var inputInfo = Console.ReadLine();
                playAgain = (inputInfo == "y" || inputInfo == "Y") ? true : false;
                flagQuit = (inputInfo == "q" || inputInfo == "Q") ? true : false;
            }

            playAgain = true;
            while (playAgain && !flagQuit)
            {
                myConditions.Exercise2();
                Console.WriteLine("Do you want to play again:");
                Console.WriteLine("1. Press Y to play again?");
                Console.WriteLine("2. Press N to play next program(Y/N)?");
                Console.WriteLine("3. Press Q to quit Executable Program(Q)?");
                var inputInfo = Console.ReadLine();
                playAgain = (inputInfo == "y" || inputInfo == "Y") ? true : false;
                flagQuit = (inputInfo == "q" || inputInfo == "Q") ? true : false;
            }

            playAgain = true;
            while (playAgain && !flagQuit)
            {
                myConditions.Exercise3();
                Console.WriteLine("Do you want to play again:");
                Console.WriteLine("1. Press Y to play again?");
                Console.WriteLine("2. Press N to play next program(Y/N)?");
                Console.WriteLine("3. Press Q to quit Executable Program(Q)?");
                var inputInfo = Console.ReadLine();
                playAgain = (inputInfo == "y" || inputInfo == "Y") ? true : false;
                flagQuit = (inputInfo == "q" || inputInfo == "Q") ? true : false;
            }

            playAgain = true;
            while (playAgain && !flagQuit)
            {
                myConditions.Exercise4();
                Console.WriteLine("Do you want to play again:");
                Console.WriteLine("1. Press Y to play again?");
                Console.WriteLine("2. Press N to play next program(Y/N)?");
                Console.WriteLine("3. Press Q to quit Executable Program(Q)?");
                var inputInfo = Console.ReadLine();
                playAgain = (inputInfo == "y" || inputInfo == "Y") ? true : false;
                flagQuit = (inputInfo == "q" || inputInfo == "Q") ? true : false;
            }


           

        }
    }
}
