using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_3._1
{
    internal class Program
    {
        static public double znach (int n, double x)
        {
            return Math.Pow(x, n) / n;
        }
        static void Main(string[] args)
        {
            double x;
            Console.Write("x=");
            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.Write("Неккоректные данные \nx=");
                    continue;
                }
                else break;
            }
            
            double z = znach(2, x) + znach(4, x) + znach(6, x);
            Console.WriteLine("z=" + z);

        }
    }
}
