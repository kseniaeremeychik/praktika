using System;
using static System.Math;
using System.Threading;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static double Z1(double a, double b)
        {
            return ((Sin(a) + Cos(2*b - a)) / (Cos(a) - Sin(2*b-a)));
        }
        static double Z2(double b)
        {
            return ((1 + Sin(2*b)) / Cos(2*b));
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите число b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Task[] tasks = new Task[2]
            {
                new Task(() => Console.WriteLine($"1 задача: {Z1(a, b)}")),
                new Task(() =>
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"2 задача: {Z2(b)}");
                })
            };
            foreach (var t in tasks)
            {
                t.Start();
                t.Wait();
            }
        }
    }
}
