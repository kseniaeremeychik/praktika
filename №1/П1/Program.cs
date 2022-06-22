try
{
    Console.Write("Введите радиус окружности: ");
    var radius = double.Parse(Console.ReadLine());
    var length = 2 * Math.PI * radius;
    var square = Math.PI * radius * radius;
    Console.WriteLine($"Длина окружности: {length}"); 
    Console.WriteLine($"Площадь окружности: {square}"); 
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}