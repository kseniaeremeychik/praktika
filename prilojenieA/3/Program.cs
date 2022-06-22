var m = 2;

try
{
    var z1 = (Math.Sqrt(Math.Pow((3 * m + 2), 2) - 24 * m)) / (3 * Math.Sqrt(m) - 2 / Math.Sqrt(m));
    var z2 = -Math.Sqrt(m);

    Console.WriteLine($"z1 = {z1}");
    Console.WriteLine($"z2 = {z2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}