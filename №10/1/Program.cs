using static System.Console;
using static System.Convert;

namespace task_1
{
    class Student
    {
        public string name { get; set; }
        public double sr_ball { get; set; }

        public Student(double sr_ball)
        {
            this.sr_ball = sr_ball;
        }

        public double GetStipendiya(double sr_ball)
        {
            double stipendiya = 300000 + 10000 * (sr_ball - 5);

            return stipendiya;
        }
    }

    class Magistr : Student
    {
        public Magistr(double sr_ball) : base(sr_ball)
        {
            this.sr_ball = sr_ball;
        }

        public string specialnosc { get; set; }

        public double AddStipendiya(double k, double sr_ball)
        {
            double stipendiya = base.GetStipendiya(sr_ball) + k;
            return stipendiya;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите имя студента: ");
            string name = ReadLine();

            Write("Введите средний балл: ");
            double sr_ball = ToDouble(ReadLine());

            Write("Введите специальность: ");
            string specialnosc = ReadLine();

            Write("Введите добавку к стипендии: ");
            double k = ToDouble(ReadLine());

            Student table = new Student(sr_ball);
            Magistr desk = new Magistr(sr_ball);

            WriteLine($"{desk.AddStipendiya(k, sr_ball)}");
        }
    }
}