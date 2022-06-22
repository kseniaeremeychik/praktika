using static System.Console;
using static System.Convert;

Random rnd = new Random();

Write("Введите n: ");
int n = ToInt16(ReadLine());
Write("Введите a: ");
int a = ToInt16(ReadLine());
Write("Введите b: ");
int b = ToInt16(ReadLine());

int summ_first = 0;
int count_sr = 0;
int summ_prelast = 0;

int[,] matrix = new int[n, n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i,j] = rnd.Next(a, b);
    }
}

WriteLine();
WriteLine($"Матрица {n}x{n}");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Write($" {matrix[i,j]}");
    }
    WriteLine();
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i == 0)
        {
            summ_first += matrix[i,j];
        }

        if(i == n - 2)
        {
            summ_prelast += matrix[i,j];
        }
    }
}

WriteLine($"Summa first: {summ_first}");
WriteLine($"Summa prelast: {summ_prelast}");