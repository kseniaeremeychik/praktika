using System;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Repl(int Num)
        {
            double n1 = Num / 100;
            double n2 = (Num % 100) / 10;
            double n3 = Num % 10;
            double[] a1 = { n1, n2, n3 };
            for (int a = 0; a<a1.Length; a++)
            {
                for(int b = 0; b<a1.Length; b++)
                {
                    for(int c =0; c< a1.Length;c++)
                    {
                        if (a1[a] != a1[b] && a1[a] != a1[c] && a1[b] != a1[c])  Console.WriteLine($"Вариант: {a1[a]}{a1[b]}{a1[c]}");
                        else  continue;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число, в котором все цифры различны: ");
            int number;
            while (!(int.TryParse(Console.ReadLine(), out number) && number >= 12 && number <= 987 && number / 100 != (number % 100) / 10 && number / 100 != number % 10 && (number % 100) / 10 != number % 10)) Console.WriteLine("Введено неверное значение") ;

            Task task1 = new Task(() => Repl(number));
            task1.Start();
            task1.Wait();

            Task task2 = Task.Factory.StartNew(() => Repl(number));
            task2.Wait();

            Task task3 = Task.Run(() => Repl(number));
            task3.Wait();
        }
    }
}
