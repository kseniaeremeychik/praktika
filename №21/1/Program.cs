using System;

namespace task1
{
    public class TeaBoiler
    {
        private bool empty;
        private bool boiled;
        private static TeaBoiler uniqueInstance;
        private TeaBoiler()
        {
            empty = true;
            boiled = false;
        }
        public static TeaBoiler getInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new TeaBoiler();
            }
            return uniqueInstance;
        }
        public void fill()
        {
            if (isEmpty())
            {               
                empty = false;
                boiled = false;
                Console.Write("Наливаем в чайничек воду: ");
            }
        }
        public void drain()
        {
            if (!isEmpty() && isBoiled())
            {
                empty = true;
                boiled = false;
                Console.Write("Кидаем чай: ");
            }
        }
        public void boil()
        {
            if (!isEmpty() && !isBoiled())
            {
                boiled = true;
                Console.Write("Доводим содержимое до кипения: ");
            }
        }
        public bool isEmpty()
        {
            return empty;
        }
        public bool isBoiled()
        {
            return boiled;
        }
        public void Conclusion()
        {
            Console.WriteLine($"Пустой-{empty}, Закипел-{boiled}");
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            TeaBoiler chocolateBoiler = TeaBoiler.getInstance();
            chocolateBoiler.Conclusion();
            chocolateBoiler.fill();
            chocolateBoiler.Conclusion();
            chocolateBoiler.boil();
            chocolateBoiler.Conclusion();
            chocolateBoiler.drain();
            chocolateBoiler.Conclusion();
        }
    }
}
