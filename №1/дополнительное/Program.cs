using System.Text;

try
{
    for (int i = 10; i <= 99; i++){
        int first = i / 10;
        int second = i % 10;

        if (i == (first * second) * 2) {
            Console.WriteLine($"{first} {second}");
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
