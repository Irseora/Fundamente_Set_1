using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 19. Determinati daca un numar e format doar cu 2 cifre care se pot repeta.

namespace Rezolvari
{
    class Prob_19
    {
        public static void Doar2Cif(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.Write("Introduceti un numar: ");
            string numar = Console.ReadLine();

            bool doar2Cif = true;
            char cif1 = numar[0], cif2 = ' ';
            int i = 1, lungime = numar.Length;

            if (lungime < 2)
                doar2Cif = false;

            while (i < lungime && doar2Cif)
            {
                if (numar[i] != cif1 && numar[i] != cif2)
                {
                    if (cif2 == ' ')
                        cif2 = numar[i];
                    else
                        doar2Cif = false;
                }

                i++;
            }

            if (doar2Cif)
                Console.WriteLine($"Numarul {numar} este format doar cu 2 cifre care se repeta.");
            else
                Console.WriteLine($"Numarul {numar} nu este format doar cu 2 cifre care se repeta.");

        }
    }
}