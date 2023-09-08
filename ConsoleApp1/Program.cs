using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Общие задания
            sbyte a1 = -100;
            sbyte b1 = Math.Abs(a1);
            Console.WriteLine($"abs a = {b1}");

            sbyte a2 = -100;
            sbyte b2 = 100;
            sbyte c2 = Math.Max(a2, b2);
            Console.WriteLine($"max = {c2}");

            sbyte a3 = 4;
            double b3 = Math.Sqrt(a3);
            Console.WriteLine($"max = {b3}");

            double a4 = 10.5;
            double b4 = Math.Truncate(a4);
            Console.WriteLine($"max = {b4}");

            //Индивидуалное задание №17
            bool Proverka;
            double cos = Math.Cos(60);
            if (cos == 0.5)
                Proverka = true;
            else
                Proverka = false;
            if (Proverka == true)
                Console.WriteLine($"Соотношение верно");
            else
                Console.WriteLine($"Соотношение не верно");
        }
    }
}
