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
            material[0] = new Schedule.BusSchedule(rnd.Next(1, 6), "Красные", rnd.Next(0, 20), "Душистые");
            material[1] = new Schedule.SchoolSchedule(rnd.Next(1, 6), "Жёлтые", rnd.Next(0, 20), "Обыкновенные");
            material[2] = new Schedule.FoodSchedule(rnd.Next(1, 6), "Белые", rnd.Next(0, 20), "Японские");
            foreach (Schedule elem in material)
            {
                elem.Description();
                elem.Sr();
            }
        }
    }
}
