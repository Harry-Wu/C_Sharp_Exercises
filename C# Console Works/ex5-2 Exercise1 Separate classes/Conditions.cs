using System;

namespace ex5_1_Exercise1
{
    public class Conditions
    {
        public void Exercise1()
        {
            Console.WriteLine("Please input a number between 1 to 10:");
            //var inputNumber = Convert.ToInt32(Console.ReadLine());
            var input = Console.ReadLine();
            var inputNumber = Convert.ToInt32(input);
            //下面这样是不对的, 得到的inputNumber虽然是int类型，但是是字符对应的ASCII码值：
            //var inputNumber = Console.Read();
            if (inputNumber <= 10 && inputNumber >= 1)
            {
                Console.WriteLine(input);
                Console.WriteLine("Good,Valid Value");
            }
            else
            {
                Console.WriteLine(input);
                Console.WriteLine("Sorry,Invalid Value");
            }
        }

        //2- Write a program which takes two numbers from the console and displays the maximum of the two.
        public void Exercise2()
        {
            Console.WriteLine("Please enter 1st number:");
            var number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter 2nd number:");
            var number2 = Convert.ToInt32(Console.ReadLine());

            var max = number1 > number2 ? number1 : number2;          
            Console.WriteLine("Max number is " + max);     
        }

        //3- Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait. 
        public void Exercise3()
        {
            Console.WriteLine("Please enter the width of the image:");
            var picWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the height of the image:");
            var picHeight = Convert.ToInt32(Console.ReadLine());

            var outString = picWidth > picHeight ? "The image is landscape." : "The image is portrait.";          
            Console.WriteLine(outString);     
        }

        /**********************************************************************************
         * 4- Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, 
         * sensors, etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. 
         * Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit, 
         * program should display Ok on the console. If the value is above the speed limit, the program should calculate 
         * the number of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and 
         * displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.
         *********************************************************************************/
        public void Exercise4()
        {
            //while (playAgain)
            //{
            Console.WriteLine("Please enter the speed limit:");
            var carSpeedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the speed of the car(km/h):");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < carSpeedLimit)
            {
                Console.WriteLine("The speed is OK.");
            }
            else
            {
                const int kmPerDemerit = 5;
                var demeritPoint = (carSpeed - carSpeedLimit) / kmPerDemerit;
                if (demeritPoint < 12)
                {
                    Console.WriteLine("The demerit point is " + demeritPoint);
                }
                else
                {
                    Console.WriteLine("You License is Suspended!");
                }
            }
                
                
            //}

        }
    }
}