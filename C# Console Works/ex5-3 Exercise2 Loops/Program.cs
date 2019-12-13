using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_3_Exercise2_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //其他类里面的Method要想先使用，就得先定义一个类类型的对象
            Loops myLoops = new Loops();
            var playAgain = true;
            var flagQuit = false;
            while (playAgain && !flagQuit)
            {
                myLoops.CountDivisible();
                Console.WriteLine("Do you want to play again(Y/N)?");
                Console.WriteLine("Press Q to quit Executable Program(Q).");
                var inputInfo = Console.ReadLine();
                playAgain = (inputInfo == "y" || inputInfo == "Y") ? true : false;
                flagQuit = (inputInfo == "q" || inputInfo == "Q") ? true : false;
            }

            playAgain = true;
            while (playAgain && !flagQuit)
            {
                myLoops.SumNumbers();
                Console.WriteLine("Do you want to play again(Y/N)?");
                Console.WriteLine("Press Q to quit Executable Program(Q).");
                var inputInfo = Console.ReadLine();
                playAgain = (inputInfo == "y" || inputInfo == "Y") ? true : false;
                flagQuit = (inputInfo == "q" || inputInfo == "Q") ? true : false;
            }

            playAgain = true;
            while (playAgain && !flagQuit)
            {
                myLoops.Factorial();
                Console.WriteLine("Do you want to play again(Y/N)?");
                Console.WriteLine("Press Q to quit Executable Program(Q).");
                var inputInfo = Console.ReadLine();
                playAgain = (inputInfo == "y" || inputInfo == "Y") ? true : false;
                flagQuit = (inputInfo == "q" || inputInfo == "Q") ? true : false;
            }

            playAgain = true;
            while (playAgain && !flagQuit)
            {
                myLoops.GuessNumber();
                Console.WriteLine("Do you want to play again(Y/N)?");
                Console.WriteLine("Press Q to quit Executable Program(Q).");
                var inputInfo = Console.ReadLine();
                playAgain = (inputInfo == "y" || inputInfo == "Y") ? true : false;
                flagQuit = (inputInfo == "q" || inputInfo == "Q") ? true : false;
            }

            playAgain = true;
            while (playAgain && !flagQuit)
            {
                myLoops.MaxNumber();
                Console.WriteLine("Do you want to play again(Y/N)?");
                Console.WriteLine("Press Q to quit Executable Program(Q).");
                var inputInfo = Console.ReadLine();
                playAgain = (inputInfo == "y" || inputInfo == "Y") ? true : false;
                flagQuit = (inputInfo == "q" || inputInfo == "Q") ? true : false;
            }
        }
    }
}
