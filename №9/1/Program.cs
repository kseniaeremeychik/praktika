using System;
using static System.Console;
using static System.Math;

namespace Interface01
{
    interface Ix
    {
        void IxF0(double xKey);
        void IxF1();
    }

    interface Iy
    {
        void F0(double xKey);
        void F1();
    }

    interface Iz
    {
        void F0(double xKey);
        void F1();
    }

    class TestClass:Ix, Iy, Iz
    {
        public double xVal;
        public TestClass()
        {
            xVal = 125;
        }

        public TestClass(double key)
        {
            xVal = key;
        }

        public void IxF0(double key)
        {
            // xVal = 7*key-4;
            xVal = Log(key);
            WriteLine($"IxF0({xVal})");
        }

        public void IxF1()
        {
            // xVal = 7*xVal-4;
            xVal = Log(xVal);
            WriteLine($"IxF1({xVal})");
        }

        public void F0(double xKey)
        {
            xVal = 2/xKey;
            WriteLine($"(Iy/Iz)F0({xVal})");
        }

        public void F1()
        {
            xVal = 2/xVal;
            WriteLine($"(Iy/Iz)F1{xVal}");
        }

        void Iz.F0(double xKey)
        {
            xVal = Pow(xKey, 3);
            WriteLine($"Iw.F0{xVal}");
        }

        void Iz.F1()
        {
            xVal = Pow(xVal, 3);
            WriteLine($"Iw.F1({xVal})");
        }
    }

    class Class1
    {
        static void Main(string[] args)
        {
            TestClass x0 = new TestClass();
            TestClass x1 = new TestClass(5);

            x0.IxF0(10);
            x1.IxF1();

            (x0 as Iy).F0(7);
            (x1 as Iz).F1();

            WriteLine("Prism test:");
            WriteLine("Ix:");

            Ix ix = x1;
            ix.IxF0(5);
            ix.IxF1();

            WriteLine("Iy:");
            Iy iy = x1;
            iy.F0(5);
            iy.F1();
            
            WriteLine("Iz:");
            Iz iz = x1;
            iz.F0(5);
            iz.F1();
        }
    }
}