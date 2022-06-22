using static System.Console;
using static System.Convert;

namespace task_2
{
    class Progarm
    {
      enum Worker : int
      {
        Alexey = 50,
        Alexandr = 130,
        Andrey = 200,
        Valera = 70,
        Max = 45,
        Kirill = 0
      }
      class Accauntat
      {
        public bool AskForBonus(int hours, int worker_hours)
        {
          if (hours > worker_hours)
          {
            return false;
          }
          else
          {
            return true;
          }
        }
      }

    static void Main()
    {
      Accauntat acc = new Accauntat();

      Write("Введите необходимое кол-во часов: ");
      int hours = ToInt16(ReadLine());

      var values = Worker.GetValues(typeof(Worker));

      foreach(var item in values)
      {
        if (acc.AskForBonus(hours, (int)item))
        {
          WriteLine($"{item} заслужил премию");
        }
        else
        {
          WriteLine($"{item} не заслужил премию");
        }
      }
    }
  }
}