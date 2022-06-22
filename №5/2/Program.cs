using static System.Console;
using static System.Math;

Random rnd = new Random();

int[] arr = new int[10];

for (int i = 0; i < 10; i++)
{
    arr[i] = rnd.Next(0, 10);
}

WriteLine($"Изначальный массив: {string.Join(' ', arr)}");

int max = arr[0];
int min = arr[0];

for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    if (arr[i] < min)
    {
        min = arr[i];
    }
}

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == max)
    {
        arr = Delete(arr, i);
    }
    else if (arr[i] == min)
    {
        arr = Delete(arr, i);
    }
}

WriteLine($"Переделанный массив: {string.Join(' ', arr)}");

static int[] Delete(int[] array, int index)
{
    if (index < array.Length && index >= 0)
    {
        int[] array2 = new int[array.Length - 1];
        for (int i = 0, j = 0; i < array.Length; i++)
        {
            if (i == index) continue;
            array2[j++] = array[i];
        }
        array = array2;
    }
    return array;
}