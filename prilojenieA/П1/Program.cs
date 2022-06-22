double sum;
double firstNum;
double lastNum;

try
{
    Console.Write("Введите первое число: ");
    firstNum = double.Parse(Console.ReadLine());
    Console.Write("Введите второе число: ");
    lastNum = double.Parse(Console.ReadLine());

    sum = firstNum + lastNum;

    Console.WriteLine($"{firstNum} + {lastNum} = {sum}");
}
catch (Exception ex)
{ 
    Console.WriteLine(ex.Message);
}
