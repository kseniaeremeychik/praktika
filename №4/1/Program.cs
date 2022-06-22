using static System.Console;
using static System.Convert;
using static System.Environment;
using static System.Math;

Write("Введите x: ");
double x = 0.0;

try
{
    x = ToDouble(ReadLine());
}
catch(FormatException ex)
{
    WriteLine($"Произошла ошибка {ex}");
    Exit(0);
}

try
{
    double a = x + (2*x / (4* Sin(x)));
    WriteLine($"a. {a}");

    double b = x - 3 + 1 / Tan(x - 1);
    WriteLine($"b. {b}");
}
catch(DivideByZeroException ex)
{
    WriteLine($"Произошла ошибка: {ex}");
    Exit(0);
}