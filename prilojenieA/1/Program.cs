try
{
    Console.Write("Введите величину временного интервала (в минутах): ");
    int minutes = int.Parse(Console.ReadLine());

    int hours = minutes / 60; 
    int othminutes = minutes - (hours * 60);

    Console.WriteLine($"{minutes} минут - это {hours}ч. {othminutes}мин.");

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

