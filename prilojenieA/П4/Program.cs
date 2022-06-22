try
{
    Console.Write("v0: ");
    var v0 = double.Parse(Console.ReadLine());
    Console.Write("t: ");
    var t = double.Parse(Console.ReadLine());
    Console.Write("a: ");
    var a = double.Parse(Console.ReadLine());

    var S = v0 * t + (a * Math.Pow(t, 2) / 2);
    Console.WriteLine($"S = {S}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
