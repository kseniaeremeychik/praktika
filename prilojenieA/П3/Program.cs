var x = 2.7;

try
{
    var y = Math.Log(x + Math.Sqrt(Math.Pow(x, 2) + 9)) - (x + 1) / Math.Atan(Math.Pow(x, 3));

    Console.WriteLine($"result = {y}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}