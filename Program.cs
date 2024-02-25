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


            
            //5
             Console.WriteLine("Введите длину массива:");
int n = int.Parse(Console.ReadLine());
 int[] array = new int[n];

        for (int i = 0; i < array.Length; i++) //позволяет получить длину массива
        {
            array[i] = i * i * i;
        }

        Console.WriteLine("Массив кубов:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }


6//
     Console.WriteLine("Введите длину массива:");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    array[i] = 1;
                }
                else
                {
                    array[i] = i % 5;
                }
            }

            Console.WriteLine("Массив:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }




            7//
                 Console.WriteLine("Введите длину массива n:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число p:");
            int p = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int[] array = new int[n];

            // Заполнение массива случайными числами от 0 до p
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, p + 1); //Возвращает случайное целое число
            }

            Console.Write("Сгенерированный массив: ");
            foreach (var num in array)
            {
                Console.Write(num + " ");
            }

            int First = 0;
            int Last = 0;

            // Подсчет чисел, делящихся без остатка на первый и последний элементы массива
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % array[0] == 0)
                {
                    First++;
                }
                if (array[i] % array[array.Length - 1] == 0)
                {
                    Last++;
                }
            }

            Console.WriteLine("Чисел, делящихся без остатка на первый элемент массива: " + countFirst);
            Console.WriteLine("Чисел, делящихся без остатка на последний элемент массива: " + countLast);

            if (First > Last)
            {
                Console.WriteLine("Чисел, делящихся на первый элемент, больше в массиве.");
            }
            else if (Last > First)
            {
                Console.WriteLine("Чисел, делящихся на последний элемент, больше в массиве.");
            }
            else
            {
                Console.WriteLine("Одинаковое количество чисел, делящихся на первый и последний элементы массива.");
            }



            //8
            Console.Write("Введите длину массива: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите число p: ");
        int p = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[n];
        Random random = new Random();
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            array[i] = random.Next(0, p + 1);
        }

        Console.WriteLine("Элементы массива:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(array[i] + " ");
            if (i % 2 == 0) // проверяем, на четном ли месте стоит элемент
            {
                sum += array[i]; // добавляем значение элемента к сумме
            }
        }

        Console.WriteLine("Сумма чисел массива, которые стоят на четных местах: " + sum);




            9//
                   Console.Write("Введите длину массива: ");
        int n = int.Parse(Console.ReadLine());
        
        Console.Write("Введите число p: ");
        int p = int.Parse(Console.ReadLine());
        
        int[] array = new int[n];
        Random random = new Random();
        
        for (int i = 0; i < n; i++)
        {
            array[i] = random.Next(0, p+1);
        }
        
        Console.WriteLine("Исходный массив:");
        PrintArray(array);
        
        int minIndex = 0;
        int maxIndex = 0;
        
        for (int i = 1; i < n; i++)
        {
            if (array[i] < array[minIndex])
            {
                minIndex = i;
            }
            
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }
        
        int temp = array[minIndex];
        array[minIndex] = array[maxIndex];
        array[maxIndex] = temp;
        
        Console.WriteLine("Массив после замены:");
        PrintArray(array);
    }
    
    static void PrintArray(int[] array)
    {
        foreach (var num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();



        //10
          Console.WriteLine("Введите длину массива:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите максимальное значение случайных чисел:");
        int p = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите число a:");
        int a = Convert.ToInt32(Console.ReadLine());

        // массив заданной длины 
        Random random = new Random();
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = random.Next(0, p + 1);
        }

        // Находим среднее арифметическое всех чисел в массиве
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += arr[i];
        }
        double average = (double)sum / n;

        // Заменяем все числа больше a на среднее арифметическое
        for (int i = 0; i < n; i++)
        {
            if (arr[i] > a)
            {
                arr[i] = (int)average;
            }
        }

        //исходный массив
        Console.WriteLine("Исходный массив:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // измененный массив
        Console.WriteLine("Измененный массив:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();




        //11
        Console.Write("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите число p: ");
        int p = Convert.ToInt32(Console.ReadLine());

        Random random = new Random();
        int[] array = new int[n];
        int negative = 0;

        for (int i = 0; i < n; i++)
        {
            array[i] = random.Next(-10, p + 1);
            if (array[i] < 0)
            {
                negative++;
            }
        }

        Console.WriteLine("Массив:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Количество отрицательных чисел в массиве: " + negative);
        }
    }
}


