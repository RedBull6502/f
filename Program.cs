using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //while 1
            int a = 0;//Создается переменная a и присваивается значение 0. Она будет использоваться для подсчета количества повторений
            while (a < 10) //Запускается цикл while, который будет выполняться до тех пор, пока значение переменной count меньше 10
            {
                Console.WriteLine("Майнкрафт – это моя жизнь!");
                a++; //Увеличивается значение переменной count на 1
            }
            Console.ReadKey();


            //while 2
            Console.WriteLine("Кол-во повторений n:");
            int n = Convert.ToInt32(Console.ReadLine());

            int i = 0; //счетчик
            while (i < n) // пока i меньше n фраза будет повторяться
            {
                Console.WriteLine("ОПК – сила, Гарвард – могила!");
                i++;
            }
            Console.ReadKey();

            //while 3
            Console.WriteLine("Введите количество строк:");
            int rows = Convert.ToInt32(Console.ReadLine());

            int stolb = 5;
            int i3 = 0;

            while (i3 < rows)//выполняется до тех пор пока значение i меньше чем кол-во строк
            {
                for (int j = 0; j < stolb; j++)
                {
                    Console.Write("0");
                }
                Console.WriteLine();
                i3++;
            }

            //while 4
            int i4 = 1;
            while (i4 <= 20)
            {
                Console.WriteLine(i4);
                i4++;
            }

            //while 5
            int i5 = 1001;
            while (i5 <= 1025)
            {
                Console.WriteLine(i5);
                i5 += 3;
            }
            //while 6
            int i6 = 100;
            while (i6 >= 0)
            {
                Console.WriteLine(i6);
                i6 -= 4;
            }
            //while 7
            double num = 1.2;
            while (num <= 2.8)
            {
                Console.WriteLine(num);
                num += 0.2;
            }
            //while 8
            double num1 = 25;
            double num2 = 25.5;
            double num3 = 24.8;

            while (num1 <= 35 && num2 <= 35.5 && num3 <= 34.8)
            {
                Console.WriteLine($"{num1} {num2} {num3}");
                num1++;
                num2++;
                num3++;
            }
            //while 9
            Console.WriteLine("курс доллара в рублях:");
            double kurs = Convert.ToDouble(Console.ReadLine());

            
    Console.WriteLine("Цена доширака 40 руб");

            int i9 = 1;
            while (i9 <= 50)
            {
                double dol = i9 * kurs;
                int doshik = (int)(dol / 40);

                Console.WriteLine($"{i9}$ - {dol} р - {doshik} Доширак");

                i9++;
            }
            //while 10
            Console.WriteLine("Введите число n:");
            int n1 = Convert.ToInt32(Console.ReadLine());

           
    int sum = 0;
            int h = 1;

            while (h <= n1)
            {
                sum += h;
                h++;
            }

            Console.WriteLine($"Сумма чисел от 1 до {n1} равна {sum}");
        
        //while 11
        Console.WriteLine("Введите начало интервала");
double a11 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите конец интервала");
double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите число h");
double c11 = Convert.ToDouble(Console.ReadLine());

            double x = a11; // текущее значение x на отрезке [a;b]
while (x <= b)
{
double fx = x * x - Math.Sin(x);
        Console.WriteLine("f(" + x + ") = " + fx);
x += c11;
}
}
    }
}
