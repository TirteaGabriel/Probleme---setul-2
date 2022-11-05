using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme___setul_2
{
    internal class Program
    {
        static void p1()
        {
            int nr = 0;
            int n=int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x % 2 == 0)
                    nr++;
            }
            Console.WriteLine("Sunt "+nr+" numere pare in secventa data");
        }
        static void p2()
        {

        }
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Introduceti numarul problemei:");
                int nrp = int.Parse(Console.ReadLine());
                if (nrp == 1)
                {
                    Console.WriteLine("Problema " + nrp);
                    p1();
                }
                if (nrp == 2)
                {
                    Console.WriteLine("Problema " + nrp);
                    //p2();
                }
                if (nrp == 3)
                {
                    Console.WriteLine("Problema " + nrp);
                    //p3();
                }
                if (nrp == 4)
                {
                    Console.WriteLine("Problema " + nrp);
                    //p4();
                }
                if (nrp == 5)
                {
                    Console.WriteLine("Problema " + nrp);
                    //p5();
                }
                if (nrp == 6)
                {
                    Console.WriteLine("Problema " + nrp);
                    //p6();
                }
                if (nrp == 7)
                {
                    Console.WriteLine("Problema " + nrp);
                    //p7();
                }
                if (nrp == 8)
                {
                    Console.WriteLine("Problema " + nrp);
                    //p8();
                }
                if (nrp == 9)
                {
                    Console.WriteLine("Problema " + nrp);
                    //p9();
                }
                if (nrp == 10)
                {
                    Console.WriteLine("Problema " + nrp);
                    //p10();
                }
                if (nrp == 11)
                {
                    Console.WriteLine("Problema " + nrp);
                    //p11();
                }
                if (nrp == 12)
                {
                    Console.WriteLine("Problema " + nrp);
                    //p12();
                }
                if (nrp == 13)
                {
                    Console.WriteLine("Problema " + nrp);
                    //p13();
                }
                if (nrp == 14)
                {
                    Console.WriteLine("Problema " + nrp);
                    //p14();
                }
                if (nrp == 15)
                {
                    Console.WriteLine("Problema " + nrp);
                    //p15();
                }
                if (nrp == 16)
                {
                    Console.WriteLine("Problema " + nrp);
                    //p16();
                }
                if (nrp == 17)
                {
                    Console.WriteLine("Problema " + nrp);
                    //p17();
                }
                Console.ReadKey();
            }
        }
    }
}
