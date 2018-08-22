/***********************************************************************
 * 借鉴了learn Python 3 the hard way 练习25中的文字冒险游戏例子,转换成C#练习
 **********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ex8_1_Text_adventure_game
{
    class Program
    {
        static void Main(string[] args)
        {
            var title = @"
 ________   ______   __   __   ________   ___   __    _________  __  __   ______    ______       _______    ________   ___ __ __   ______      
/_______/\ /_____/\ /_/\ /_/\ /_______/\ /__/\ /__/\ /________/\/_/\/_/\ /_____/\  /_____/\     /______/\  /_______/\ /__//_//_/\ /_____/\     
\::: _  \ \\:::_ \ \\:\ \\ \ \\::: _  \ \\::\_\\  \ \\__.::.__\/\:\ \:\ \\:::_ \ \ \::::_\/_    \::::__\/__\::: _  \ \\::\| \| \ \\::::_\/_    
 \::(_)  \ \\:\ \ \ \\:\ \\ \ \\::(_)  \ \\:. `-\  \ \  \::\ \   \:\ \:\ \\:(_) ) )_\:\/___/\    \:\ /____/\\::(_)  \ \\:.      \ \\:\/___/\   
  \:: __  \ \\:\ \ \ \\:\_/.:\ \\:: __  \ \\:. _    \ \  \::\ \   \:\ \:\ \\: __ `\ \\::___\/_    \:\\_  _\/ \:: __  \ \\:.\-/\  \ \\::___\/_  
   \:.\ \  \ \\:\/.:| |\ ..::/ / \:.\ \  \ \\. \`-\  \ \  \::\ \   \:\_\:\ \\ \ `\ \ \\:\____/\    \:\_\ \ \  \:.\ \  \ \\. \  \  \ \\:\____/\ 
    \__\/\__\/ \____/_/ \___/_(   \__\/\__\/ \__\/ \__\/   \__\/    \_____\/ \_\/ \_\/ \_____\/     \_____\/   \__\/\__\/ \__\/ \__\/ \_____\/ 
                                                                                                                                               ";
            var title2 = @"
    ___     ____  _    __ ______ _   __ ______ __  __ ____   ______   ______ ___     __  ___ ______
   /   |   / __ \| |  / // ____// | / //_  __// / / // __ \ / ____/  / ____//   |   /  |/  // ____/
  / /| |  / / / /| | / // __/  /  |/ /  / /  / / / // /_/ // __/    / / __ / /| |  / /|_/ // __/   
 / ___ | / /_/ / | |/ // /___ / /|  /  / /  / /_/ // _, _// /___   / /_/ // ___ | / /  / // /___   
/_/  |_|/_____/  |___//_____//_/ |_/  /_/   \____//_/ |_|/_____/   \____//_/  |_|/_/  /_//_____/   
                                                                                                   ";
            Console.ForegroundColor = ConsoleColor.Yellow;  //设置前景色，即字体颜色
            Console.WriteLine(title);
            Console.WriteLine(title2);
            Console.ResetColor(); //将控制台的前景色和背景色设为默认值
            Console.WriteLine("You You enter a dark room with two doors. Do you go through door #1 or door #2?");
            Console.Write(">");
            var door = Console.ReadLine();
            if (door == "1")
            {
                Console.WriteLine("There's a giant bear here eating a cheese cake. What do you do?");
                Console.WriteLine("1. Take the cake.");
                Console.WriteLine("2. Scream at the bear.");
                Console.Write(">");
                var reactBear = Console.ReadLine();
                if (reactBear == "1")
                {
                    Console.WriteLine("The bear eats your face off. Game Over!");
                }
                else if (reactBear == "2")
                {
                    Console.WriteLine("The bear eats your legs off. Game Over!");
                }
                else
                {
                    Console.WriteLine("Well, doing {0} is probably better. Bear runs away. Nice job!", reactBear);
                }
            }
            else if (door == "2")
            {
                bool choosingFlag = false;  //选择选项正确与否的标志位, 如果选项正确,则将choosingFlag值为正确(true)
                while (choosingFlag == false)
                {
                    Console.WriteLine("You stare into the endless abyss at Cthulhu's retina.");
                    Console.WriteLine("1. Blueberries.");
                    Console.WriteLine("2. Yellow jacket clothespins.");
                    Console.WriteLine("3. Understanding revolvers yelling melodies.");
                    Console.Write(">");
                    var reactCthulhu = Console.ReadLine();
                    if (reactCthulhu == "1" | reactCthulhu == "2")
                    {
                        choosingFlag = true;
                        Console.WriteLine("Your body survives powered by a mind of jello. Nice job!");
                    }
                    else if (reactCthulhu == "3")
                    {
                        choosingFlag = true;
                        Console.WriteLine("The insanity rots your eyes into a pool of muck. Game Over!");
                    }
                    else
                    {
                        Console.WriteLine("You choose the wrong choice, please try agin...");
                    }
                }
            }
            else
            {
                Console.WriteLine("You stumble around and fall on a knife and die. Game Over!");
            }

            Console.ReadKey();

        }
    }
}
