using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УСЛОВНЫЕ_ОПЕРАТОРЫ_Комиссарова
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1
            Console.WriteLine("Введите два числа:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Большее число: " + a);
                Console.ReadKey();
            }
            else if (b > a)
            {
                Console.WriteLine("Большее число: " + b);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Числа равны");
                Console.ReadKey();
            }

            //Задача 2
            Console.WriteLine("Введите три числа:");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());

            if (a1 > b && a1 > c1)
            {
                Console.WriteLine("Большее число: " + a);
                Console.ReadKey();
            }
            else if (b1 > a1 && b1 > c1)
            {
                Console.WriteLine("Большее число: " + b);
                Console.ReadKey();
            }
            else if (c1 > a && c1 > b1)
            {
                Console.WriteLine("Большее число: " + c1);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Есть равные числа");
                Console.ReadKey();
            }
        }
    }
}
