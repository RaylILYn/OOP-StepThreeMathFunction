// Задание 1.3 [Вариант 2]
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Math;
namespace Console3
{
    class Program
    {
        static void Main(string[] args)
        {
            Double x, b;
            Console.Write("Введите xn= ");
            Double xn = Double.Parse(Console.ReadLine());
            Console.Write("Введите xk= ");
            Double xk = Double.Parse(Console.ReadLine());
            Console.Write("Введите шаг dx= ");
            Double dx = Double.Parse(Console.ReadLine());
            if (dx <= 0)
            {
                Console.Write("Ошибка, нулевой шаг или отрицательный");
                return;
            }
            Console.WriteLine("┌───────────────────┐");
            Console.WriteLine("│   x    │     y    │");
            Console.WriteLine("│───────────────────│");

            x = xn;
            if (x <= xk)
            {
                while (x <= xk)

                {
                    if (x + 3 * Math.Pow(Math.Cos(x), 2) * Math.Pow(x, 3) == 0)
                    {
                        Console.WriteLine("│   Деление на ноль │");
                        x += 1;
                    }

                    b = (Math.Pow(x, 3)) / (x + 3 * Math.Pow(Math.Cos(x), 2) * Math.Pow(x, 3));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("│ {0,6:f2} │ {1,8:f4} │", x, b);

                    x = x + dx;
                }
            }
            else
            {
                while (x >= xk)

                {
                    if (x + 3 * Math.Pow(Math.Cos(x), 2) * Math.Pow(x, 3) == 0)
                    {
                        Console.WriteLine("│   Деление на ноль │");
                        x -= 1;
                    }


                    b = (Math.Pow(x, 3)) / (x + 3 * Math.Pow(Math.Cos(x), 2) * Math.Pow(x, 3));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("│ {0,6:f2} │ {1,8:f4} │", x, b);

                    x = x - dx;
                }
            }
            Console.WriteLine("└───────────────────┘");
            Console.ReadKey();
        }
    }
}