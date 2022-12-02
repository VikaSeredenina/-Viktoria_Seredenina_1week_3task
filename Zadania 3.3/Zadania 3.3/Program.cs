using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_3._2
{
    internal class Program
    {
        static void f(double x, out double y)
        {
            y = 0;
            if (Math.Abs(x) <= 1) y = x * x - 1;
            else if (Math.Abs(x) <= 2) y = 2 * x - 1;
            else if (Math.Abs(x) > 2) y = Math.Pow(x, 5) - 1;

        }

        static double f(double x)
        {
            double y=0;
            if (Math.Abs(x) <= 1) y = x * x - 1;
            else if (Math.Abs(x) <= 2) y = 2 * x - 1;
            else if (Math.Abs(x) > 2) y = Math.Pow(x, 5) - 1;
            return y;
        }

        static void Main(string[] args)
        {
            double a;
            double b;
            double h;

            Console.Write("a=");
            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.Write("Неккоректные данные \na=");
                    continue;
                }
                else break;
            }

            Console.Write("b=");
            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.Write("Неккоректные данные \nb=");
                    continue;
                }
                else break;
            }

            while (true)
            {
                if (a > b)
                {

                    Console.Write("a не может быть больше b");
                    Console.Write("\na=");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("b=");
                    b = double.Parse(Console.ReadLine());
                    continue;
                }
                else break;
            }




            Console.Write("h=");
            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out h))
                {
                    Console.Write("Неккоректные данные \nh=");
                    continue;
                }
                else if (h<=0)
                {
                    Console.Write("Шаг должен быть больше 0 \nh=");
                    continue;
                }
                else break;
            }

            for (double i = a; i <= b; i += h)
                Console.WriteLine("f({0:f2})={1:f4}", i, f(i));

            for (double i = a; i <= b; i += h)
            {
                f(i, out double y);
                Console.WriteLine("f({0:f2})={1:f4}", i, f(i));
            }

        }
    }
}
