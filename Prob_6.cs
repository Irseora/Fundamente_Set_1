using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 6. Determinati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.

namespace Rezolvari
{
    class Prob_6
    {
        public static void LaturiTriunghi(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.WriteLine("Introduceti valorile celor 3 laturi: ");
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]), b = int.Parse(input[1]), c = int.Parse(input[2]);
            bool ok = true;

            if (a < 0 || b < 0 || c < 0)
                Console.WriteLine("Nu, laturile unui triunghi nu pot avea lungimi negative.");
            else
            {
                if (a > b)
                {
                    if (c > a)  // c > a > b
                    {
                        if (a+b <= c)
                            ok = false;
                    }
                    else  // a > b,c
                    {
                        if (b+c <= a)
                            ok = false;
                    }
                }
                else
                {
                    if (c > b)  // c > b > a
                    {
                        if (b+a <= c)
                            ok = false;
                    }
                    else  // b > a,c
                    {
                        if (a+c <= b)
                            ok = false;
                    }
                }

                if (ok)
                    Console.WriteLine($"Da, {a}, {b} si {c} pot fi lungimile laturilor unui triunghi.");
                else
                    Console.WriteLine($"Nu, {a}, {b} si {c} nu pot fi lungimile laturilor unui triunghi.");
            }
        }
    }
}