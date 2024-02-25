using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МАССИВЫ
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.Write("Длина массива n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите число p: ");
            int p = int.Parse(Console.ReadLine()); //преобразование числа в строку

            Random rand = new Random();//генерация случайных чисел
            int[] array = new int[n]; //массив целых чисел array длиной n

            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(0, p + 1); // В цикле от 0 до n-1 каждый элемент массива заполняется случайным числом от 0 до p.
            }

            Console.WriteLine("Сгенерированный массив:");
            foreach (var num in array) //последовательного перебора элементов массива без возможности их изменения
            {
                Console.Write(num + " ");
            }
            //2
            Console.Write("Введите длину массива: ");
            int n1 = int.Parse(Console.ReadLine()); //переменная длины массива
            int[] array1 = new int[n1]; //создание массива array1 с длиной n1

            for (int i = 0; i < n1; i++) //цикл который перебирает каждый элемент масс
            {
                if (i == 0 || i == n1 - 1) 
                {
                    array1[i] = 1; //если индекс равен 0 или равен n - 1, то присваиваем элементу массива значение 1
                }
                else
                {
                    array1[i] = 0; // в другом случае присваеваем 0
                }
            }

            Console.WriteLine("Array:");
            foreach (int num1 in array1) //перебираем все эл и выводим их с пробелами
            {
                Console.Write(num1 + " ");
            }
            //3
            Console.Write("Введите длину массива: ");
            int n2 = int.Parse(Console.ReadLine()); // возвращает преобразованное число

            int[] array2 = new int[n2]; // Создаем массив заданной длины

            for (int i2 = 0; i2 < n2; i2++)
            {
                array2[i2] = i2 % 2; // Заполняем массив нулями и единицами чередующимися
            }

            Console.WriteLine("Массив:");
            foreach (int val2 in array2)
            {
                Console.Write(val2 + " "); 
            }
            //4
            Console.Write("Введите длину массива: ");
            int n3 = int.Parse(Console.ReadLine()); // Запрашиваем у пользователя длину массива

            int[] array3 = new int[n3]; // Создаем массив заданной длины

            int num3 = 1;
            for (int i3 = 0; i3 < n3; i3++)
            {
                array3[i3] = num3;
                num3 += 2; // Увеличиваем num на 2 для получения следующего нечетного числа
            }

            Console.WriteLine("Массив:");
            foreach (int val3 in array)
            {
                Console.Write(val3 + " "); // Выводим массив на экран
            }
        }
    }
}


