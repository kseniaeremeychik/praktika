static void GetDigitsVariants(int num)
{
    var variants = new int[][]
    {
        new int []{ 0, 1, 2},
        new int []{ 0, 2, 1},
        new int []{ 2, 0, 1},
        new int []{ 2, 1, 0},
        new int []{ 1, 2, 0},
        new int []{ 1, 0, 2},
    };
    var digits = new int[] { num / 100, (num % 100) / 10, num % 10 };
    var result = new int[variants.GetLength(0)];
    for (int i = 0; i < result.Length; i++)
    {
        var item = variants[i];
        result[i] = digits[item[0]] * 100 + digits[item[1]] * 10 + digits[item[2]];
        Console.WriteLine($"Вариант {i + 1}: {result[i]}");
    }
}

try
{
    GetDigitsVariants(123);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
