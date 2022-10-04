using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            string a;
            Console.WriteLine("Введите первое число \n");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число \n");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine("Выберите операцию: + - * / \n");
            a = Console.ReadLine();

            switch (a)
            {
                case "+":
                    Console.WriteLine(x + y);
                    Console.WriteLine("Вы выбрали сложение ");
                    break;
                case "-":
                    Console.WriteLine(x - y);
                    Console.WriteLine("Вы выбрали вычитание");
                    break;
                case "*":
                    Console.WriteLine(x * y);
                    Console.WriteLine("Вы выбрали умножение");
                    break;
                case "/":
                    if (x == 0)
                        Console.WriteLine("Делить на ноль нельзя");
                    else
                        Console.WriteLine(x / y);
                    Console.WriteLine("Вы выбрали деление");
                    break;
                default:
                    Console.WriteLine("Выбрана неверная операция \n");
                    break;
            }

        }
    }
}
