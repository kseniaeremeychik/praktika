try
{
    Console.Write("Введите первую сторону треугольника: ");
    var a = double.Parse(Console.ReadLine());
    Console.Write("Введите вторую сторону треугольника: ");
    var b = double.Parse(Console.ReadLine());
    Console.Write("Введите третью сторону треугольника: ");
    var c = double.Parse(Console.ReadLine());

    if (a + b > c && a + c > b && b + c > a)
    {
        Console.WriteLine("Треугольник существует");
    } else {
        Console.WriteLine("Треугольника не существует");
    }

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}