using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komissarova_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///1
            int a = 2, b = 3, x = 2;
            double z = (a + 4 * b) * (a - 3 * b) + Math.Pow(a, x);
            Console.WriteLine("Ответ:" + z);
            Console.ReadKey();
            ///2. a)
            double x1 = 1.7, b1 = x1 + 1;
            int v = 2;
            double z1 = Math.Pow(b1, v) + 3 * (x1 + 1);
            Console.WriteLine("Ответ:" + z1);
            Console.ReadKey();
            ///2. b)
            double x2 = 3, b2 = x2 + 1;
            int v1 = 2;
            double z2 = Math.Pow(b2, v1) + 3 * (x2 + 1);
            Console.WriteLine("Ответ:" + z2);
            Console.ReadKey();
            ///3
            double x = -2.34;
			double d = 2;
			double y = (Math.Abs(x - 5) - Math.Sin(x))/3 + Math.Sqrt(Math.Pow(x, d)+ 2014)*Math.Cos(2*x)-3;
			Console.WriteLine("Ответ:" + Math.Round(y, 5));
///4
          double l1 = 3.6;
		   double k1 = 4;
		   double j1 = Math.Exp(l1-2) + Math.Abs(Math.Sin(l1)) - Math.Pow(l1, k1) * Math.Cos(1/l1);
		   Console.WriteLine("Ответ:" + Math.Round(j1, 4));
            ///5
             	 	double b = 2 ;
		double l2 = 0.1;
		double k2 = 0.2;
		double g2 = 1;
		double s2 = 5;
			double s3 =2;
		double j2 =Math.Pow(Math.Sqrt(Math.Pow(g2,b)+k2),s2) - (Math.Pow(k2, b) * Math.Pow((Math.Sin(l2 + g2)),3))/g2;
		Console.WriteLine("Ответ:" +  Math.Round(j2, 4));


		
		///Задание 2
		 Console.WriteLine("Введите число: ");
            string userInput = Console.ReadLine(); ///сохраняет введенную строку в переменной userInput.

            if (int.TryParse(userInput, out int Число)) ///преобразовать введенную строку в число
            {
                int Квадрат = Число * Число;
                int Куб = Число * Число * Число;

                Console.WriteLine($"Квадрат числа {Число}: {Квадрат}");
                Console.WriteLine($"Куб числа {Число}: {Куб}");
                Console.ReadKey();

		    
		    ///Задание 3
		    Console.WriteLine("Введите три числа:");
            int num1, num2, num3;
            if (int.TryParse(Console.ReadLine(), out num1) &&
                int.TryParse(Console.ReadLine(), out num2) &&
                int.TryParse(Console.ReadLine(), out num3))
            {
                num1 *= 2; // увеличиваем первое число в два раза
                num2 -= 3; // уменьшаем второе число на 3
                num3 = num3 * num3; // возводим третье число в квадрат

                int sum = num1 + num2 + num3; // находим сумму новых трех чисел
                Console.WriteLine("Ответ: " + sum); // выводим результат на экран
                Console.ReadKey();
            }
		    
		      ///Задание 4
		    Console.WriteLine("Введите три числа:");
            double num1 = Convert.ToDouble(Console.ReadLine()); \\\преобразуем введенные пользователем строки в числа и сохраняем их в переменные
            double num2 = Convert.ToDouble(Console.ReadLine());
            double num3 = Convert.ToDouble(Console.ReadLine());

            double СрАрифм = (num1 + num2 + num3) / 3;
            double Разность = 2 * (num1 + num3) - 3 * num2;

            Console.WriteLine("Среднее арифметическое: " + СрАрифм);
            Console.WriteLine("Разность: " + Разность);
            Console.ReadKey();

		    
		    ///Задание 5
		    Console.WriteLine("Введите длину стороны квадрата: ");
            double сторона = Convert.ToDouble(Console.ReadLine()); ///преобразует заданное значение вещественного типа данных в эквивалентное значение типа double.

            double Периметр = 4 * сторона; ///рассчитывает периметр квадрата (сумма длин всех сторон) и сохраняет в переменную
            double Площадь = сторона * сторона; /// рассчитывает площадь квадрата (квадрат длины стороны) и сохраняет в переменную

            Console.WriteLine("Периметр квадрата: " + Периметр);
            Console.WriteLine("Площадь квадрата: " + Площадь);
            Console.ReadKey();

		    
		    ///Задание 6
		    // Ввод цены за 1 кг конфет и 1 кг печенья
            Console.WriteLine("Введите цену 1 кг конфет:");
            double кгКонфет = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите цену 1 кг печенья:");
            double кгПеченья = Convert.ToDouble(Console.ReadLine());

            // Расчет стоимости покупок
            double СтоимостьКонфет = кгКонфет * 0.3 + кгКонфет * 0.4;
            double СтоимостьПеченья = (кгПеченья * 1.8 + кгПеченья * 2) * 3;

            // Вывод результатов
            Console.WriteLine("Стоимость одной покупки из 300 г конфет и 400 г печенья: " + СтоимостьКонфет);
            Console.WriteLine("Стоимость трех покупок, каждая из 2 кг печенья и 1 кг 800 г конфет: " + СтоимостьПеченья);
            Console.ReadKey();

		    
		    ///Задание 7
		    
		    Console.WriteLine("Введите время в минутах:");
            int время = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите расстояние в километрах:");
            double РасстояниеКМ = Convert.ToDouble(Console.ReadLine());

            double времяЧ = время/60.0; //время из минут в часы
            double расстояниеМ = РасстояниеКМ * 1000; //переводим расстояние из километров в метры

            double скорость = расстояниеМ / время; //вычисляем скорость в метрах в секунду

            Console.WriteLine("Скорость: " + скорость + " м/c");
            Console.ReadKey();
		    

                ///Задание 8
		    Console.Write("Введите длину первого катета: ");
            double катет1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину второго катета: ");
            double катет2 = Convert.ToDouble(Console.ReadLine());

            double гипотенуза = Math.Sqrt(катет1 * катет1 + катет2 * катет2);
            double площадь = (катет1 * катет2) / 2;
            double периметр = катет1 + катет2 + гипотенуза;

            Console.WriteLine("площадь треугольника равна: " + Math.Round(площадь, 2));
            Console.WriteLine("периметр равен: " + Math.Round(периметр, 2));
            Console.WriteLine("гипотенуза равна: " + Math.Round(гипотенуза, 2));
            Console.ReadKey();
		    
		    
		    ///Задание 9
		    Console.WriteLine("Введите температуру в градусах Цельсия:");
            double цельсия = Convert.ToDouble(Console.ReadLine());

            double Фаренгейт = цельсия * 9 / 5 + 32;

            Console.WriteLine("Температура в градусах Фаренгейта: " + Фаренгейт);
            Console.ReadKey();


		    
		    ///Здание 10

int a = 0, b = 2, c = 5;

            int a1 = a + b;
            int b1 = c - a;
            int c3 = a + b + c;

            a = a1;
            b = b1;
            c = c3;

            Console.WriteLine("Новые значения: a = " + a + ", b = " + b + ", c = " + c);
            Console.ReadKey();

		    

		    ///Задание 11
		    
		    Console.WriteLine("Введите два числа a и b:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int целаяЧасть = a / b; // целая часть от деления
            int остаток = a % b; // остаток от деления

            Console.WriteLine("Целая часть от деления: " + целаяЧасть);
            Console.WriteLine("Остаток от деления: " + остаток);
            Console.ReadKey();

        }
    }
}
