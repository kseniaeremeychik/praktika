using static System.Console;

TRAIN[] trains = new TRAIN[8];
for (int i = 0; i < trains.Length; i++)
{
    Write("Место назначения: ");
    trains[i].finish_post = ReadLine();
    Write("Номер поезда: ");
    trains[i].train_number = ReadLine();
    Write("Время прибытия: ");
    trains[i].time = ReadLine();
}
trains = trains.OrderBy(x => x.finish_post).ToArray();
string tp = "";
bool had = false;
do
{
    Write("\nВведите номер поезда для поиска: ");
    tp = ReadLine();

    for (int i = 0; i < trains.Length; i++)
    {
        if (tp == trains[i].train_number)
        {
            WriteLine($"\nНомер поезда: {tp}");
            WriteLine($"Место назначения: {trains[i].finish_post}");
            WriteLine($"Время прибытия: {trains[i].time}");
            had = true;
        }
    }
    if (!had)
    {
        Console.WriteLine($"Не найден: {tp}");
    }
    had = false;
    WriteLine("\nХотите продолжить? (y/n)");
}
while (ReadLine() != "n");
public struct TRAIN
{
    public string finish_post;
    public string train_number;
    public string time;
}