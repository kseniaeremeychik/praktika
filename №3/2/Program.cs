using static System.Console;
using static System.Convert;
using static System.Math;

static double F(double x)
{
    double y = 0;

    if (x < 1)
    {
        y = Pow((Pow(x, 2) - 1), 2);
    }
    else if (x > 1)
    {
        y = 1 / (Pow((1 + x), 2));
    }
    else
    {
        y = 0;
    }

    return y;
}

Write("Введите a: ");
double a = ToDouble(ReadLine());

Write("Введите b: ");
double b = ToDouble(ReadLine());

Write("Введите h: ");
double h = ToDouble(ReadLine());

for (double i = a; i <= b; i += h)
{
    WriteLine($"{Round(i, 2)} = {Round(F(i), 2)}");
}