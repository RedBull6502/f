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

            
             ///Задача 3
            Console.WriteLine("Введите три числа:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

           double sum1 = a + b;
            double sum2 = b + c;
            double sum3 = c + a;

            double max_sum = Math.Max(sum1, Math.Max(sum2, sum3));
           

            if (max_sum == sum1)
            {
                Console.WriteLine($"Наибольшая сумма : {a}+{b}={sum1}");
            }
            else if (max_sum == sum1)
            {
                Console.WriteLine($"Наибольшая сумма : {a}+{c}={sum2}");
            }
            if (max_sum == sum2)
            {
                Console.WriteLine($"Наибольшая сумма : {b}+{c}={sum2}");
            }
             else if (max_sum == sum2)
            {
                Console.WriteLine($"Наибольшая сумма : {a}+{c}={sum3}");
            }

            
            ///задача 4
              Console.WriteLine("Введите высоту кирпича:");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ширину кирпича:");
            double width = Convert.ToDouble(Console.ReadLine());
            
            if ((height <= 50 && width <=
                120)|| (height<= 120 && width <= 50))
            {
                Console.WriteLine("Кирпич поместится");
            }
            else
            {
                Console.WriteLine("Кирпич не поместится");
            }

             ///задача 5
            Console.WriteLine("Введите номер дня недели(1-Понедельник, 2-Вторник и т.д.):");
            int number = Convert.ToInt32(Console.ReadLine());
            string name =GetName(number);
            if (name != null)
            {
                Console.WriteLine($"День недели под номером {number} - это {name}");
            }
            else
                {
                    Console.WriteLine("Некорректный номер дня недели");
                }
            static string GetName (int number)
            {
                switch (number)
                {
                    case 1:
                        return "Понедельник";
                    case 2:
                        return "Вторник";
                    case 3:
                        return "Среда";
                    case 4:
                        return "Четверг";
                    case 5:
                        return "Пятница";
                    case 6:
                        return "Суббота";
                    case 7:
                        return "Воскресенье";
                    default:
                        return null;
///Задача 5
            Console.WriteLine("Введите коэффициенты квадратного уравнения ax ^ 2 + bx + c = 0:");
            Console.Write(" a = ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write(" b = ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write(" c = ");
            double c = Convert.ToDouble(Console.ReadLine());

            double discriminant = b * b - 4 * a * c;
            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                }
        }
    }
}
