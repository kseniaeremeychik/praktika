﻿using System;
using System.Threading;
using System.Threading.Tasks;


namespace task3
{
    class Program
    {
        static int Calculation(int number)
        {
            return ( number % 10 * 100 + number % 100 / 10 * 10 + number / 100 );
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int digit = Convert.ToInt32(Console.ReadLine());

            Task task1 = Task.Factory.StartNew(() =>      
            {
                Console.WriteLine("Первая задача началась");
                Task<int> task2 = Task<int>.Factory.StartNew(() =>  
                {
                    Console.WriteLine("Вторая задача началась");
                    return Calculation(digit);
                });
                task2.Wait();
                Console.WriteLine("Вторая задача завершилась");
                Console.WriteLine(task2.Result);
            });
            task1.Wait();
            Console.WriteLine("Первая задача завершилась");
        }
    }
}
