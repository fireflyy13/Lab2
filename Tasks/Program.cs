using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Given a = 1.27, b = 10.99, c = 2.73 and d = 25.32 " +
               "\nsolve y = a^b / sh(|b|) + 4ln(c) / d^(1/4).");
            Console.WriteLine("\nThe solution is: ");
            Task1();

            Console.WriteLine("\nGiven a = 3.56, b = 1.02, c = 3, d = 2.43 " +
              "\nsolve 2 * ln(b^a) + |arcsin(-sqrt(d / c))|.");
            Console.WriteLine("\nThe solution is: ");
            Task2();

            Console.WriteLine("\nGiven a = 0.58, b = - 0.34, c = 1.25 and d = 1.89" +
            "\nsolve y = 3a / cos(a) + sqrt(th(|b| * c) / ln(d)).");
            Console.WriteLine("\nThe solution is: ");
            Task3();
        }

        static void Task1()
        {
            double a = 1.27;
            double b = 10.99;
            double c = 2.73;
            double d = 25.32;

            double term1 = Math.Pow(a, b) / Math.Sinh(Math.Abs(b));
            double term2 = 4 * Math.Log(c) / Math.Pow(d, 0.25);
            double sum = term1 + term2;
            Console.WriteLine(sum);
        }

        static void Task2()
        {
            double a = 3.56;
            double b = 1.02;
            int c = 3;
            double d = 2.43;

            double term1 = 2 * Math.Log(Math.Pow(b, a));
            double term2 = Math.Abs(Math.Asin(-Math.Sqrt(d / c)));
            double y = term1 + term2;
            Console.WriteLine(y);
        }

        static void Task3()
        {
            double a = 0.58;
            double b = -0.34;
            double c = 1.25;
            double d = 1.89;

            double y = 3 * a / Math.Cos(a) + Math.Sqrt(Math.Tanh(Math.Abs(b) * c) / Math.Log(d));
            Console.WriteLine(y);
        }
    }
}
