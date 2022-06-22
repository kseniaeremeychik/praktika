try
{
    Mnogochlen mnogochlen = new Mnogochlen();
    var stop = true;
    while (stop)
    {
        Console.WriteLine("Нажмите '1', чтобы вычислить значение многочлена для заданного аргумента");
        Console.WriteLine("Нажмите '2', чтобы задать аргумент");
        Console.WriteLine("Нажмите '3', чтобы задать многочлены");
        Console.WriteLine("Нажмите '0', чтобы завершить программу");
        var personStop = int.Parse(Console.ReadLine());

        if (personStop == 0)
        {
            stop = false;
        }
        else if (personStop == 1)
        {
            Console.WriteLine();
            Console.WriteLine($"Результат: {mnogochlen.Result}");
            Console.WriteLine();
        }
        else if (personStop == 2)
        {
            Console.WriteLine();

            Console.Write("Введите A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Введите B: ");
            int B = int.Parse(Console.ReadLine());
            Console.Write("Введите C: ");
            int C = int.Parse(Console.ReadLine());

            mnogochlen.zadacMnogochleni(A, B, C);
            Console.WriteLine("Многочлены заданы");
            Console.WriteLine();
        }
        else if (personStop == 3)
        {
            Console.WriteLine();
            Console.Write("Введите x: ");
            int X = int.Parse(Console.ReadLine());
            mnogochlen.zadacArgument(X);

            Console.WriteLine("Аргумент задан");
            Console.WriteLine();
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

class Mnogochlen
{
    public int a;
    public int b;
    public int c;
    public int x;

    public int Result { get { return a * x * x  + b * x + c; } }

    public Mnogochlen(int a = 0, int b = 0, int c = 0, int x = 0)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.x = x;
    }

    public void zadacArgument(int arg)
    {
        x = arg;
    }
    public void zadacMnogochleni(int A, int B, int C)
    {
        a = A;
        b = B;
        c = C;
    }


}