try
{
    Console.Write("Введите число: ");
    int A = int.Parse(Console.ReadLine());
    
    if (A % 10 == A / 1000 && A % 100 / 10 == A % 1000 / 100) {
        Console.WriteLine($"Верно");
    } else {
        Console.WriteLine($"Не верно");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}