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


        }
    }
}
