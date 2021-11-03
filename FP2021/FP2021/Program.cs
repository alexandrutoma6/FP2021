using System;

namespace FP2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //p1(); 
            //p2();
            //p3();
            p4();
        }

        private static void p4()
        {
            int n = int.Parse(Console.ReadLine());
            int minim1 = int.MaxValue;
            int minim2 = int.MaxValue - 1;
            int minim3 = int.MaxValue - 2;

            for (int i = 0; i < n; i++)
            {

            }

            Console.WriteLine($"cele mai mici 3 numere sunt {minim1} {minim2} {minim3}");

        }

        private static void p3()
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int maxim = int.MinValue;
            int numar_aparitii = 0;
            for (int i = 0; i < n; i++)
            {
                int numar = int.Parse(Console.ReadLine());
                if(numar>maxim)
                {
                    numar_aparitii = 1;
                    maxim = numar;

                }
                if(numar==maxim)
                {
                    numar_aparitii += 1;
                }
            }
            Console.WriteLine($"cel mai mare numar este {maxim} si apare de {count} ori");
        }

        private static void p2()
        {
            int numar = int.Parse(Console.ReadLine());
            int maxim = int.MinValue;
            while(numar!=0)
            {
                if (numar >= maxim)
                {
                    maxim = numar;
                }
                numar = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"cel mai mare nr este {maxim}");
        }

        private static void p1()
        {
            Console.WriteLine("introduceti numarul de numere care mor fii citite, n: ");
            int n = int.Parse(Console.ReadLine());
            int maxim = -1000;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("introduceti numarul, numar= ");
                int numar = int.Parse(Console.ReadLine());
                if (numar >= maxim)
                {
                    maxim = numar;
                }
            }
            Console.WriteLine($"cel mai mare numar este {maxim}");
        }
    }
}
