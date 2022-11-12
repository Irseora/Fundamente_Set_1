using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2. Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare.
//    Tratati toate cazurile posibile.

namespace Rezolvari
{
    class Prob_2
    {
        public static void EcGrad2(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.WriteLine("Introduceti valorile indicilor a, b si c: ");
            string[] input = Console.ReadLine().Split(' ');
            double a = double.Parse(input[0]), b = double.Parse(input[1]), c = double.Parse(input[2]);

            Console.Write("Rezolvare: ");

            if (a == 0)  // a=0
            {
                if (b == 0)  // a=0, b=0
                {
                    if (c == 0)  // a=0, b=0, c=0
                        Console.WriteLine("x = orice numar real");
                    else  // a=0, b=0, c!=0  =>  c=0 "Fals"
                        Console.WriteLine("Ecuatia nu are solutie in multimea numerelor reale");
                }
                else  // a=0, b!=0
                {
                    if (c == 0)  // a=0, b!=0, c=0  =>  bx = 0
                        Console.WriteLine("x = 0");
                    else  // a=0, b!=0, c!=0  => bx + c = 0
                        Console.WriteLine("x = " + -c/b);
                }
            }
            else  // a!=0
            {
                if (b == 0)  // a!=0, b=0
                {
                    if (c == 0)  // a!=0, b=0, c=0  =>  ax^2 = 0
                        Console.WriteLine("x = 0");
                    else  // a!=0, b=0, c!=0  =>  ax^2 + c = 0
                        Console.WriteLine("x = " + Math.Sqrt(-c/a));
                }
                else  // a!=0, b!=0
                {
                    if (c == 0)  // a!=0, b!=0, c=0  =>  ax^2 + bx = 0  =>  x * (ax + b) = 0
                        Console.WriteLine("x1 = 0, x2 = " + (-b/a));
                    else  // a!=0, b!=0, c!=0  =>  ax^2 + bx + c = 0
                    {
                        double delta = b*b - 4*a*c;
                        if (delta > 0)
                        {
                            double radDelta = Math.Sqrt(delta);
                            Console.WriteLine("x1 = " + ((-b+radDelta)/(2*a)) + ", x2 = " + ((-b-radDelta)/(2*a)));
                        }
                        else if (delta == 0)
                        {
                            Console.WriteLine("x = " + (-b/(2*a)));
                        }
                        else
                            Console.WriteLine("Ecuatia nu are solutie in multimea numerelor reale");
                            
                    }
                }
            }
        }
    }
}