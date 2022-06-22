using System;
using System.IO;
using System.Linq;

int[] mass = new int[25];
int countNeqative = 0;
Random rnd = new Random();
using (StreamWriter _sw = new StreamWriter(@"C:\input.txt"))

for (int i = 0; i < mass.Length; i++) _sw.WriteLine(rnd.Next(-100, 100));

using (StreamReader _sr = new StreamReader(@"C:\input.txt"))
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = int.Parse(_sr.ReadLine());
    }
}
int max = mass.Max();
int min = mass.Min();
for (int e = 0; e < mass.Length; e++)
{
    if(mass[e] <= 0)
    {
        countNeqative++;
    }
}
Console.WriteLine("Максимум:{0}\nМинимум:{1}\nКоличество отрицательных цифр:{2}",max,min,countNeqative);