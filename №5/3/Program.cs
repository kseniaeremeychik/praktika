using static System.Console;
using static System.Convert;

Random rnd = new Random();

Write("Введите n: ");
int n = ToInt16(ReadLine());
Write("Введите a: ");
int a = ToInt16(ReadLine());
Write("Введите b: ");
int b = ToInt16(ReadLine());

int summ_sr = 0;
int count_sr = 0;
int count_of_chetn = 0;

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

Write("Введите G: ");
int G = ToInt16(ReadLine());
Write("Введите K: ");
int K = ToInt16(ReadLine());

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        // среднее арифметическое
        if (matrix[i,j] > G)
        {
            summ_sr += matrix[i,j];
            count_sr++;
        }

        // кол-во четных
        if(i == K-1 && i % 2 == 0 && j % 2 == 0)
        {
            count_of_chetn += 1;
        }
    }
}

WriteLine($"Среднее арифметическое элементов больше {G}: {summ_sr/count_sr}");
WriteLine($"Количество четных элементов матрицы {K}той строки: {count_of_chetn}");