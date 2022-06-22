using System;

namespace zad_1
{
    class Program
    {
        class A
        {
            private int D;

            public int C_2
            {
                get
                {
                    int a = 5;

                    if (a > 0)
                    {
                        D++;
                        a--;
                    }

                    return D;
                }
            }

            public A()
            {

            }

            public A(int d)
            {
                D = d;
            }
        }

        class B : A
        {
            public B()
            {

            }

            public B(int d) : base(d)
            {

            }
        }

        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine(a.C_2);
        }
    }
}