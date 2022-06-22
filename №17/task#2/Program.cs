using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2_schedule;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            const int n = 3;
            Schedule[] material = new Schedule[n];
            material[0] = new Schedule.BusSchedule(rnd.Next(1, 6), "Красный", rnd.Next(0, 20), "Еженедельное");
            material[1] = new Schedule.SchoolSchedule(rnd.Next(1, 6), "Жёлтый", rnd.Next(0, 20), "Ежедневное");
            material[2] = new Schedule.FoodSchedule(rnd.Next(1, 6), "Белый", rnd.Next(0, 20), "Одинарное");
            foreach (Schedule elem in material)
            {
                elem.Description();
                elem.Sr();
            }
        }
    }
}
