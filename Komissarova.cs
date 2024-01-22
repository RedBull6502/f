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
            double x3 = -2.34;
            double h = Abs(x3 - 5) - 



        }
    }
}
