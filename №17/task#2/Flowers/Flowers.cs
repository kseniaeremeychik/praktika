using System;

namespace task2_schedule
{
    public abstract class Schedule
    {
        public abstract void Description();
        public abstract void Sr();
        public class BusSchedule : Schedule
        {
            public BusSchedule(int during, string color, int count, string type)
            {
                this.During = during;
                this.color = color;
                this.count = count;
                this.type = type;
            }
            public int During;
            public string color;
            public int count;
            public string type;

            public override void Description()
            {
                System.Console.WriteLine($"Расписание автобусов типа: {type} Цвет в календаре: {color} Количество повторений в день: {count} Продолжительность: {During}");
            }
            public override void Sr()
            {
                if (count == 0) System.Console.WriteLine("Без повторений");
                if (During == 0) System.Console.WriteLine("Продолжительность нулевая");
            }
        }
        public class SchoolSchedule : Schedule
        {
            public SchoolSchedule(int during, string color, int count, string type)
            {
                this.During = during;
                this.color = color;
                this.count = count;
                this.type = type;
            }
            public int During;
            public string color;
            public int count;
            public string type;

            public override void Description()
            {
                System.Console.WriteLine($"Расписание в школе типа: {type} Цвет в календаре: {color} Количество повторений в день: {count} Продолжительность: {During}");
            }
            public override void Sr()
            {
                if (count == 0) System.Console.WriteLine("Без повторений");
                if (During == 0) System.Console.WriteLine("Продолжительность нулевая");
            }
        }
        public class FoodSchedule : Schedule
        {
            public FoodSchedule(int during, string color, int count, string type)
            {
                this.During = during;
                this.color = color;
                this.count = count;
                this.type = type;
            }
            public int During;
            public string color;
            public int count;
            public string type;

            public override void Description()
            {
                System.Console.WriteLine($"Расписание еды типа: {type} Цвет в календаре: {color} Количество повторений в день: {count} Продолжительность: {During}");
            }
            public override void Sr()
            {
                if (count == 0) System.Console.WriteLine("Без повторений");
                if (During == 0) System.Console.WriteLine("Продолжительность нулевая");
            }
        }
    }
}
