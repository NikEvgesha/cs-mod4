using System;

namespace cs_mod4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свой любимый цвет на английском с маленькой буквы: ");
            var mycolor = Console.ReadLine();

           switch (mycolor)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is red!");
                break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is green!");
                break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is cyan!");
                break;

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("I don't know this color! My favourite color is yellow!");
                break;
            }
        }
    }
}
