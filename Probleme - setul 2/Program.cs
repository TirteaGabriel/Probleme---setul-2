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
        static void p5()
        {
            int n = int.Parse(Console.ReadLine());
            int nr = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == i)
                {
                    nr++;
                }
            }
            Console.WriteLine(nr);
        }
        static void p6()
        {
            int n = int.Parse(Console.ReadLine());
            bool ok = true;
            int x1 = int.Parse(Console.ReadLine());
            for (int i=1;i<n;i++)
            {
                int x2 = int.Parse(Console.ReadLine());
                if(x1>x2)
                    ok = false;
                x1 = x2;
            }
            if (ok)
                Console.WriteLine($"Numerele sunt in ordine crescatoare");
            else
                Console.WriteLine($"Numerele nu sunt in ordine crescatoare");
        }
        static void p7()
        {
            int n = int.Parse(Console.ReadLine());
            int min = 0;
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (min == 0)
                {
                    min = x;
                }
                if (x < min)
                {
                    min = x;
                }
                if (x > max)
                {
                    max = x;
                }
            }
            Console.WriteLine($"Minimul sirului este {min}, iar maximul sirului este {max}");
        }
        static void p8()
        {
            int n = int.Parse(Console.ReadLine());
            int f1 = 0;
            int f2 = 1;
            int fn = 0;
            for (int i = 2; i <= n; i++)
            {
                fn = f2 + f1;
                f1 = f2;
                f2 = fn;
            }
            Console.WriteLine($"{fn}");
        }
        static void p9()
        {
            int n = int.Parse(Console.ReadLine());
            bool ok = true;
            bool ok1 = true;
            int x1 = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                int x2 = int.Parse(Console.ReadLine());
                if (x1 > x2)
                {
                    ok = false;
                }
                if (x1 < x2)
                {
                    ok1 = false;
                }
                x1 = x2;
            }
            if (ok || ok1)
                Console.WriteLine($"Sirul este monoton");
            else
                Console.WriteLine($"Sirul nu este monoton");
        }
        static void p10()
        {
            int n = int.Parse(Console.ReadLine());
            int maxim = 1;
            int smaxim = 1;
            int x1 = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                int x2 = int.Parse(Console.ReadLine());
                if (x1 == x2)
                    maxim++;
                else
                    maxim = 1;
                if (maxim > smaxim)
                    smaxim = maxim;
                x1 = x2;
            }
            Console.WriteLine($"Numarul maxim de numere consecutive egale este {smaxim}");
        }
        static void p11()
        {
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                int xinv = 0;
                while (x > 0)
                {
                    xinv = xinv * 10 + x % 10;
                    x /= 10;
                }
                suma += xinv;
            }
            Console.WriteLine(suma);
        }
        static void p12()
        {
            int n = int.Parse(Console.ReadLine());
            int nr = 0;
            int x1 = int.Parse(Console.ReadLine());
            if (x1 != 0)
                nr++;
            for (int i = 1; i < n; i++)
            {
                int x2 = int.Parse(Console.ReadLine());
                if (x2 != 0 && x1 == 0)
                    nr++;
                x1 = x2;
            }
            Console.WriteLine(nr);
        }
        static void p13()
        {
            int n = int.Parse(Console.ReadLine());
            int x1 = int.Parse(Console.ReadLine());
            int prim = x1;
            int bec = 0;
            for (int i = 1; i < n; i++)
            {
                int x2 = int.Parse(Console.ReadLine());
                if (x1 > x2)
                {
                    bec++;
                }
                x1 = x2;
            }
            if (bec == 1 && prim > x1)
            {
                Console.WriteLine($"Secventa este crescatoare rotita");
            }
            else Console.WriteLine($"Secventa nu este crescatoare rotita");
        }
        static void p14()
        {
            int n = int.Parse(Console.ReadLine());
            int x1 = int.Parse(Console.ReadLine());
            int prim = x1;
            int bec1 = 0;
            int bec2 = 0;
            for (int i = 1; i < n; i++)
            {
                int x2 = int.Parse(Console.ReadLine());
                if (x1 > x2)
                {
                    bec1++;
                }
                if (x1 < x2)
                {
                    bec2++;
                }
                x1 = x2;
            }
            if ((bec1 == 1 && prim > x1) ^ (bec2 == 1 && prim < x1))
            {
                Console.WriteLine($"Secventa este monotona rotita");
            }
            else Console.WriteLine($"Secventa nu este monotona rotita");
        }
        static void p15()
        {
            int n, x, y;
            bool? crescator = null;
            bool ok = true, switched = false;
            n = int.Parse(Console.ReadLine());
            x = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                y = int.Parse(Console.ReadLine());
                if (x < y)
                {
                    if (!crescator.HasValue)
                    {
                        crescator = true;
                    }
                    else if (!crescator.Value && !switched)
                    {
                        switched = true;
                        crescator = true;
                    }
                    else if (!crescator.Value && switched)
                    {
                        ok = false;
                    }
                }
                if (x > y)
                {
                    if (!crescator.HasValue)
                    {
                        crescator = false;
                    }
                    else if (crescator.Value && !switched)
                    {
                        switched = true;
                        crescator = false;
                    }
                    else if (crescator.Value && switched)
                    {
                        ok = false;
                    }
                }
                x = y;
            }
            if (ok && switched == true)
            {
                Console.WriteLine("Secventa este bitonica");
            }
            else
            {
                Console.WriteLine("Secventa nu este bitonica");
            }
        }

        static void p16()
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            bool? crescator = null;
            bool ok = true, switched = false;
            int first = x, y, counter = 0;
            for (int i = 1; i < n; i++)
            {
                y = int.Parse(Console.ReadLine());
                if (x > y)
                {
                    if (!crescator.HasValue)
                    {
                        crescator = false;
                    }
                    else if (crescator.Value && !switched)
                    {
                        switched = true;
                        crescator = false;
                        counter++;
                    }
                    else if (crescator.Value && switched && counter > 1)
                    {
                        ok = false;
                    }
                }
                else if (x < y)
                {
                    if (!crescator.HasValue)
                    {
                        crescator = true;
                    }
                    else if (!crescator.Value && !switched)
                    {
                        switched = true;
                        crescator = true;
                    }
                    else if (!crescator.Value && switched)
                    {
                        ok = false;
                    }
                }

                x = y;
            }
            if (ok && switched == true && first <= x)
                Console.WriteLine("Secventa este bitonica rotita");
            else
                Console.WriteLine("Secventa nu este bitonica rotita");
        }
        static void p17()
        {
            string[] t = Console.ReadLine().Split(' ');
            int zero = 0;
            int unu = 0;
            int a = 0;
            int incuibare = 0;
            int incuibaremax = 0;
            for (int i = 0; i < t.Length; i++)
            {
                a = int.Parse(t[i]);
                if (a == 0)
                {
                    zero++;
                    incuibare++;
                }
                if (a == 1)
                {
                    unu++;
                    incuibare = 0;
                }
                if (incuibare > incuibaremax)
                    incuibaremax = incuibare;
            }
            if (t[0] == "1" || t[t.Length-1] == "0")
                Console.WriteLine($"Secventa este incorecta");
            else if (unu == zero && a != 0)
                Console.WriteLine($"Secventa este corecta si incuibarea maxima este {incuibaremax}");
            else
                Console.WriteLine($"Secventa este incorecta");
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
                    p5();
                }
                if (nrp == 6)
                {
                    Console.WriteLine("Problema " + nrp);
                    p6();
                }
                if (nrp == 7)
                {
                    Console.WriteLine("Problema " + nrp);
                    p7();
                }
                if (nrp == 8)
                {
                    Console.WriteLine("Problema " + nrp);
                    p8();
                }
                if (nrp == 9)
                {
                    Console.WriteLine("Problema " + nrp);
                    p9();
                }
                if (nrp == 10)
                {
                    Console.WriteLine("Problema " + nrp);
                    p10();
                }
                if (nrp == 11)
                {
                    Console.WriteLine("Problema " + nrp);
                    p11();
                }
                if (nrp == 12)
                {
                    Console.WriteLine("Problema " + nrp);
                    p12();
                }
                if (nrp == 13)
                {
                    Console.WriteLine("Problema " + nrp);
                    p13();
                }
                if (nrp == 14)
                {
                    Console.WriteLine("Problema " + nrp);
                    p14();
                }
                if (nrp == 15)
                {
                    Console.WriteLine("Problema " + nrp);
                    p15();
                }
                if (nrp == 16)
                {
                    Console.WriteLine("Problema " + nrp);
                    p16();
                }
                if (nrp == 17)
                {
                    Console.WriteLine("Problema " + nrp);
                    p17();
                    //()(()())
                }
                Console.ReadKey();
            }
        }
    }
}
