using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            int nrpoz = 0;
            int nrneg = 0;
            int nrzero = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x < 0)
                    nrneg++;
                if (x > 0)
                    nrpoz++;
                if (x == 0)
                    nrzero++;
            }
            Console.WriteLine("Sunt " + nrpoz + " numere pozitive in secventa data");
            Console.WriteLine("Sunt " + nrneg + " numere negative in secventa data");
            Console.WriteLine("Sunt " + nrzero + " numere zero in secventa data");
        }
        static void p3()
        {
            ulong n = ulong.Parse(Console.ReadLine());
            ulong p = 1;
            ulong s = 0;
            for (ulong i = 1; i <= n; i++)
            {
                s += i;
                p *= i;
            }
            Console.WriteLine("Suma numerelor de la 1 pana la " + n + " este " + s);
            Console.WriteLine("Produsul numerelor de la 1 pana la " + n + " este " + p);
        }
        static void p4()
        {
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int poz = -1;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == a)
                    poz = i;
            }
            if (poz == -1)
                Console.WriteLine(poz);
            else
                Console.WriteLine("Pozitia lui " + a + " este " + poz);
        }
        static void  p5()
        {
            int n = int.Parse(Console.ReadLine());

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
                    p2();
                }
                if (nrp == 3)
                {
                    Console.WriteLine("Problema " + nrp);
                    p3();
                }
                if (nrp == 4)
                {
                    Console.WriteLine("Problema " + nrp);
                    p4();
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
