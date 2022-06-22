try
{
    Console.Write("Введите х: ");
    var x = double.Parse(Console.ReadLine());

    if (x <= Math.PI)
    {
        var y = x + 2 * x * Math.Sin(3 * x);
        Console.WriteLine($"y = {y}");
    }
    else
    {
        var y = Math.Cos(x) + 2;
        Console.WriteLine($"y = {y}");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}