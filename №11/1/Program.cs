using static System.Convert;
using static System.Console;

namespace task1
{
    class Vector
    {
        public string name;
        public Vector()
        {
            this.name = null;
        }
        public virtual void Input()
        {
            Write("Введиете название вектора: ");
            name = ReadLine();
        }
        public virtual void GetInfo()
        {
            WriteLine($"название: {name}");
        }
    }

    class Dwumerni : Vector
    {
        public double komponenti;
        public double dlina;
        public Dwumerni()
        {
            this.komponenti = 0.0;
            this.dlina = 0.0;
            Input();
        }
        public override void Input()
        {
            base.Input();
            Write("Введите компоненты: ");
            komponenti = ToDouble(ReadLine());
        }
        public virtual void Dlina()
        {
            dlina = komponenti;
        }
        public override void GetInfo()
        {
            Dlina();
            WriteLine($"Название: {name}\n Компоненты: {komponenti}\n Длина: {dlina}");
        }
    }

    class Trehmerni : Vector
    {
        public double razmernosc;
        public double dlina;
        public Trehmerni()
        {
            this.razmernosc = 0.0;
            this.dlina = 0.0;
            Input();
        }
        public override void Input()
        {
            base.Input();
            Write("Введите рост: ");
            razmernosc = ToDouble(ReadLine());
        }
        public virtual void Dlina()
        {
            dlina = razmernosc * 2.5;
        }
        public override void GetInfo()
        {
            Dlina();
            WriteLine($"Название: {name}\n Компоненты: {razmernosc}\n Длина: {dlina}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("1.Двемерный\n2.Трехмерный");
            WriteLine("Выберите создаваемый объект:");
            int change = ToInt32(ReadLine());
            int i = 0;
            double sum = 0;
            Console.Write("Введите количество объектов: ");
            int mascount = ToInt32(ReadLine());
            Vector[] vectors = new Vector[mascount];
            while (i< mascount)
            {
                switch (change)
                {
                    case 1: 
                        Dwumerni coat = new Dwumerni();
                        coat.Dlina();
                        sum += coat.dlina;
                        vectors[i] = coat as Vector;++i;
                        break;

                    case 2: Trehmerni costume = new Trehmerni();
                        costume.Dlina();
                        sum += costume.dlina;
                        vectors[i] = costume as Vector;++i;
                        break;

                    default: 
                            WriteLine("Данного пункта не существует");
                            break;
                }
            }
            for (int t = 0; t < vectors.Length; t++)
            {
                if (vectors[t] != null)
                {
                    vectors[t].GetInfo();
                }
            }
            WriteLine("суммарная длина: "+ sum);
        }
    }
}