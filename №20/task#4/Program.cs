using System;
using static System.Math;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Func(int x)
        { 
            double result = Sin(x) - Cos(x);
            Console.WriteLine($"Значение функции Sin(x) - Cos(x) при x={x} будет равно {Math.Round(result, 3)}");
        }

        static void Main(string[] args)
        {
            int a = -6;

            int b = 6;

            Parallel.For(a, b, Func);
        }
    }
}
