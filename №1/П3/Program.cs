double i = 1;

Console.Write("Введите N: ");
uint n = uint.Parse(Console.ReadLine());

for (int x = 2; x <= n; x++) {
    i += (1.0 / x);
}

Console.WriteLine($"Результат: {i}");