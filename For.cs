using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            //for 1
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Майнкрафт – это моя жизнь!");
            }
            Console.ReadKey();

            //for 2
            Console.WriteLine("Введите количество повторений:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("ОПК – сила, Гарвард – могила!");
            }

            //for 3
            Console.WriteLine("Введите количество строк: ");
            int stolb = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < stolb; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("0");
                }
                Console.WriteLine();
            }

            //for 4
            for (int i4 = 1; i4 <= 20; i4++)
            {
                Console.WriteLine(i4);
            }

            //for 5
            for (int i5 = 1001; i5 <= 1025; i5 += 3)
            {
                Console.WriteLine(i5);
            }

            //for 6
            for (int i6 = 100; i6 >= 0; i6 -= 4) //уменьшается на 4 с помощью i -= 4
            {
                Console.WriteLine(i6);
            }
            //for 7
            for (double num = 1.2; num <= 2.8; num += 0.2)
            {
                Console.WriteLine(num);
            }
            //for 8
            for (double num1 = 25, num2 = 25.5, num3 = 24.8; num1 <= 35 && num2 <= 35.5 && num3 <= 34.8; num1++, num2++, num3++)
            {
                Console.WriteLine($"{num1} {num2} {num3}");
            }
            //for 9
            Console.WriteLine("курс доллара в рублях");
            double kurs = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Цена доширака 40 руб");

            for (int i = 1; i <= 50; i++)
            {
                double d = i * kurs;
                int doshik = (int)(d / 40);

                Console.WriteLine($"{i}$ - {d} р - {doshik} Доширак");
            }

            //for 10
            Console.WriteLine("Введите число n:");
            int n1 = Convert.ToInt32(Console.ReadLine());


            int sum = 0;

            for (int i = 1; i <= n1; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Сумма чисел от 1 до {n1} равна {sum}");
            //for 11
            Console.WriteLine("начало интервала");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("конец интервала");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("число h");
            double h = Convert.ToDouble(Console.ReadLine());

            for (double x = a; x <= b; x += h)
            {
                double result = Math.Pow(x, 2) - Math.Sin(x);
                Console.WriteLine("f({0}) = {1}", x, result);
            }
        }
    }
}
