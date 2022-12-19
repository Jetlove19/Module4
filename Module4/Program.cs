using System;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 4.1.4
            string a;
            string b;
            ///bool c = a != b;

            ///Задание 4.1.5
            int A;
            int B;
            double X;
            double Y;

           /// bool C = (A < B) | (X > Y);

            int q = 5;
            int z = 6;
            bool s = (q == z) || (z > q);
           ///Console.WriteLine(s);

            var inv = true;
            var result = !inv;
            Console.WriteLine(result);

            ///Задание 4.1.12
            var ab = 6;
            var bc = 7;

            if (ab < bc)
            {
                Console.WriteLine("Условие истинно");
            }
            else
            {
                Console.WriteLine("Условие ложно");
            }


            ///Задание 4.1.17
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквой");

            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
            }

            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green");
            }

            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
            }

            ///Задание 4.1.18
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            var color2 = Console.ReadLine();

            switch (color2)
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

                    Console.WriteLine("Your color is yeallow");
                    break;
            }
        }
    }
}
