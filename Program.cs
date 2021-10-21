using System;

namespace cs_mod4
{
    class Program
    {
        static void Main(string[] args)
        {

            (string Name, string Surname, string Login, int LogLength, bool Pet, int Age, string[] Favcolors) User;

            for (int user_counter = 0; user_counter < 3; user_counter++)
            {
                
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Анкета №{0}", user_counter + 1);

                Console.Write("Введите имя пользователя: ");
                User.Name = Console.ReadLine();

                Console.Write("Введите фамилию: ");
                User.Surname = Console.ReadLine();

                Console.Write("Введите логин: ");
                User.Login = Console.ReadLine();
                User.LogLength = User.Login.Length;

                Console.WriteLine("У Вас есть питомец? yes/no ");
                var ans = Console.ReadLine();
                User.Pet = (ans == "yes") || (ans == "да");

                Console.Write("Введите возраст пользователя: ");
                User.Age = Convert.ToInt32(Console.ReadLine());

                User.Favcolors = new string[3];
                for (int i = 0; i < User.Favcolors.Length; i++)
                {
                    Console.WriteLine("Введите {0}-й любимый цвет: ", i + 1);
                    User.Favcolors[i] = Console.ReadLine();
                }

                Console.WriteLine("\n\n\n");

                Console.WriteLine("Анкета {0}-го пользователя:\n\tИмя и фамилия: {1} {2}\n\tЛогин: {3} (длина логина = {4})\n\tВозраст: {5}\n\t", user_counter + 1, User.Surname, User.Name, User.Login, User.LogLength, User.Age);
               
                if (User.Pet)
                {
                    Console.WriteLine("У пользователя ЕСТЬ питомец.");
                }
                else
                {
                    Console.WriteLine("У пользователя НЕТ питомца :(");
                }


                Console.WriteLine("Любимые цвета: ");
                foreach (var color in User.Favcolors)
                {
                    switch (color)
                    {
                        case "red":
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("Красный");
                            break;

                        case "green":
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("Зеленый");
                            break;

                        case "cyan":
                            Console.BackgroundColor = ConsoleColor.Cyan;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("Бирюзовый");
                            break;

                        case "yellow":
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("желтый");
                            break;


                        default:
                            Console.BackgroundColor = ConsoleColor.Magenta;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("Я не знаю такого цвета! Но мой любимый цвет - пурпурный!");
                            break;
                    }
                }
                



            }








       /*     string[] favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
            {
                Console.WriteLine("Введите свой любимый цвет номер {0}", i + 1);
                favcolors[i] = Console.ReadLine();
            }


            foreach (var color in favcolors)
            {
                switch (color)
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
            */
        }
    }
}
