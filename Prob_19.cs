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
        /// <summary> Determina daca un numar n este format doar cu 2 cifre care se pot repeta. Date de intrare: n </summary>
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
                // Daca gaseste o cifra diferita de prima cifra
                if (numar[i] != cif1 && numar[i] != cif2)
                {
                    // Daca este prima cifra diferita de cif1
                    if (cif2 == ' ')
                        cif2 = numar[i];
                    // Daca nu este prima cifra diferita => numarul este format din > 2 cifre
                    else
                        doar2Cif = false;
                }
                i++;
            }

            // Daca nu a gasit nicio cifra diferita de prima cifra
            if (cif2 == ' ')
                doar2Cif = false;

            if (doar2Cif)
                Console.WriteLine($"Numarul {numar} este format doar cu 2 cifre care se repeta.");
            else 
                Console.WriteLine($"Numarul {numar} nu este format doar cu 2 cifre care se repeta.");

        }
    }
}