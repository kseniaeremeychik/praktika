using static System.Console;
using static System.Convert;

double Factorial(double n)
{
    if (n == 1) return 1;

    return n * Factorial(n - 1);
}

Write("Введите n: ");
double x = double.Parse(ReadLine());

double f = Factorial(x + 2) / Factorial(x + 4);

WriteLine($"Факториал f({x}) = {f}");