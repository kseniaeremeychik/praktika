using static System.Console;

double[] numbers = {-2.1, 1.0, 1.1, -21.1, 4};
int count_of_negative = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] < 0)
    {
        count_of_negative += 1;
    }
}

WriteLine($"Массив A: {string.Join(' ', numbers)}");
WriteLine($"Количество отрицательных элементов массива A: {count_of_negative}");