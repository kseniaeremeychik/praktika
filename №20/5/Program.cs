using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace task5
{
    class Program
    {
        static void Factorial(int x, ParallelLoopState pls)
        {
            long mult = 1;
            for (int i = 1; i <= x; i++)
            {
                mult *= i;
            }
            int sum = 0;
            for (int i = 1; i <= x; i++)
            {
                sum += i;
            }

            if ((mult > 300) && (sum > 300))
            {
                pls.Break();
            }
            Console.WriteLine($"сумма: {sum}, произведение: {mult}");
            
        }
        
        static void Main(string[] args)
        {
            ParallelLoopResult result = Parallel.ForEach<int> (new List<int>() {1,4,61,85}, Factorial);
            if (!result.IsCompleted)
                Console.WriteLine($"прерываение на {result.LowestBreakIteration}");

        }
    }
}
