using static System.Console;
using static System.Convert;
using static System.Math;

Write("Введите x: ");
var x = ToInt16(ReadLine());

static double F(int n, int x)
{
    return Pow(x,n)/n;
}

double z = F(2, x) + F(4, x) + F(6, x);

WriteLine($"z = {z}");