try
{
    Console.Write("Введите цену за кг конфет: ");
    var pricePerKg = int.Parse(Console.ReadLine());

    if (pricePerKg >= 1 && pricePerKg <= 100) {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{i}кг. = {i * pricePerKg}руб.");
        }
    } else {
        Console.WriteLine($"Неверная цена");
    }

    
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}