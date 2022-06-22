try
{
    Console.Write("Введите порядковый номер месяца(допутим до 31): ");
    var dayNumber = int.Parse(Console.ReadLine());
    if (dayNumber > 31 || dayNumber < 0) {
        Console.WriteLine("Неправильный порядковый номер месяца");
    } else {
        var leftDayNumber = 31 - dayNumber;
        Console.WriteLine($"Дней осталось: {leftDayNumber}");
    }    
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
