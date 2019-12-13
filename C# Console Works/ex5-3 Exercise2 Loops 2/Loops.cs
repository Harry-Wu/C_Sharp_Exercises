using System;

namespace ex5_3_Exercise2_Loops
{
    public class Loops
    {
        //1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
        public void CountDivisible()
        {
            Console.WriteLine("Calculat how many numbers between 1 and 100 are divisible by 3 with no remainder:");
            //var inputNumber = Convert.ToInt32(Console.ReadLine());
            var count = 0;
            //var inputNumber = Convert.ToInt32(input);
            //下面这样是不对的, 得到的inputNumber虽然是int类型，但是是字符对应的ASCII码值：
            //var inputNumber = Console.Read();
            for (int i = 1; i <= 100; i++)
            {
                if (i%3 == 0)
                {
                    Console.Write(i);
                    Console.Write(',');
                    //Console.WriteLine(i+",");
                    count++;
                }
            }
            Console.WriteLine();
            if (count==0)
            {
                Console.WriteLine("There is no number is divisible by 3 with no remainder.");
            }
            else
            {
                Console.WriteLine("There are totally {0} numbers are divisible by 3 with no remainder.", count);
            }
        }

        //2- Write a program and continuously ask the user to enter a number or "ok" to exit. 
        //Calculate the sum of all the previously entered numbers and display it on the console.
        public void SumNumbers()
        {
            var flagEnter = true;
            var sum = 0;
            Console.WriteLine("Please enter numbers you want to sum, enter \"OK\" or \"=\" to stop enter numbers:");
            while (flagEnter)
            {
                var temp = Console.ReadLine();
                if (temp == "OK" || temp == "ok" || temp == "=")
                {
                    flagEnter = false;
                    //Console.Write('=');
                }
                else
                {
                    var inputNumber = Convert.ToInt32(temp);
                    sum += inputNumber;
                    //Console.Write('+');
                }
            }
            Console.WriteLine("sum = {0}", sum);
        }

        /**********************************************************************
         * 3- Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. 
         * For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120. 
         * *********************************************************************/
        public void Factorial()
        {
            Console.WriteLine("Please enter a number:");
            var inputNumber = Convert.ToInt32(Console.ReadLine());
            var factorialNumber = 1;
            for (int i = 1; i <= inputNumber; i++)
            {
                factorialNumber *= i;
            }
            Console.WriteLine("The factorial of {0} is {1}", inputNumber, factorialNumber);
        }

        /**********************************************************************************
         * 4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
         * If the user guesses the number, display “You won"; otherwise, display “You lost". 
         * (To make sure the program is behaving correctly, you can display the secret number on the console first.)
         *********************************************************************************/
        public void GuessNumber()
        {
            var randomNumber = new Random().Next(1, 10);
            Console.WriteLine("The guessNubmer is {0}", randomNumber);
            Console.WriteLine("Please guesses the number between 1 and 10:");
            for (int i = 0; i < 4; i++)
            {

                if (i > 0)
                {
                    Console.WriteLine("Please guesses the number again, {0} chance(s) left", 4-i);
                }
                var inputNumber = Convert.ToInt32(Console.ReadLine());
                if (inputNumber == randomNumber)
                {
                    Console.WriteLine("You win!");
                    return;
                }
            }
            Console.WriteLine("You lose!");
        }

        /**********************************************************************************
         * 5- Write a program and ask the user to enter a series of numbers separated by comma. 
         * Find the maximum of the numbers and display it on the result. For example, 
         * if the user enters “5, 3, 8, 1, 4", the program should display 8 on the console.
         *********************************************************************************/
        public void MaxNumber()
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            Console.WriteLine("Please enter a series of numbers separated by comma or space:");
            var inputInfo = Console.ReadLine();
            string[] numbers = inputInfo.Split(delimiterChars,StringSplitOptions.RemoveEmptyEntries);
            var maxNumber = 0;
            //var maxIndex = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                var temp = Convert.ToInt32(numbers[i]);
                if ( temp > maxNumber)
                {
                    maxNumber = temp;
                    //maxIndex = i;
                }
            }
            var maxIndex = Array.IndexOf(numbers, Convert.ToString(maxNumber));
            Console.WriteLine("The max number is {0}, on position {1}!", maxNumber, maxIndex);
        }
    }
}