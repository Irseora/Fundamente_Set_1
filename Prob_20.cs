using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 20. Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul).
//     O fractie este neperiodica daca numitorul este de forma 2^m*5^n unde m si n sunt mai mari sau egale decat 0.
//     O fractie este periodica simpla daca numitorul nu se divide cu 2 si nici cu 5.
//     O fractie este periodica mixta daca se divide cu 2 si/sau 5 SI se mai divide si cu alte numere prime diferite de 2 si 5.

namespace Rezolvari
{
    class Prob_20
    {
        public static void FractiiPeriodice(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.Write("Introduceti o fractie: ");
            string[] input = Console.ReadLine().Split('/');
            int numarator = int.Parse(input[0]), numitor = int.Parse(input[1]);

            // Cel mai mare divizor comun [numarator, numitor]
            int copyA = numarator, copyB = numitor;
            while (copyB != 0)
            {
                int r = copyA % copyB;
                copyA = copyB;
                copyB = r;
            }

            // Forma ireductibila
            numarator /= copyA;
            numitor /= copyA;

            // Afiseaza partea intreaga a fractiei
            Console.Write(numarator / numitor + ",");

            int parteFractionara = numarator % numitor;

            // Lista resturilor partiale provenite din impartirea repetata a partii fractionare la numitor
            List<int> resturi = new List<int>();
            resturi.Add(parteFractionara);

            // Lista cifrelor de dupa virgula
            List<int> cifre = new List<int>();

            int rest = -1;
            bool periodica = false;
            do
            {
                cifre.Add(parteFractionara * 10 / numitor);
                rest = parteFractionara * 10 % numitor;

                // Daca restul nu apare deja in lista, il adauga
                if (!resturi.Contains(rest))
                    resturi.Add(rest);
                // Daca se repeta un rest => fractia este periodica
                else
                {
                    periodica = true;
                    break;
                }

                parteFractionara = rest;
            } while (rest != 0);

            // Daca fractia nu este periodica, afiseaza cifrele de dupa virgula
            if (!periodica)
                for (int i = 0; i < cifre.Count; i++)
                    Console.Write(cifre[i]);
            // Daca fractia este periodica, afiseaza intai cifrele din afara perioadei, apoi cele din perioda intre paranteze
            else
            {
                for (int i = 0; i < resturi.Count; i++)
                {
                    // Daca a ajuns la inceputul perioadei, afiseaza paranteza deschisa
                    if (resturi[i] == rest)
                        Console.Write("(");
                    
                    Console.Write(cifre[i]);
                }

                Console.Write(")");
            }
        }
    }
}