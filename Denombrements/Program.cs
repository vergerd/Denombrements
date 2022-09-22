using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    { 
        /// <summary>
        /// fonction de calcul des termes
        /// </summary>
        /// <param name="ini">parametre d'initialisation de la boucle</param>
        /// <param name="borneMax">parametre d'arret de la boucle</param>
        /// <returns>resultat de la multiplication</returns>
        static long calcul(int ini, int borneMax)
        {
            long r = 1;
            for (int k = ini; k <= borneMax; k++)
            {
                r *= k;
            }
            return r;
        }

    
        /// <summary>
        /// programme principal
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int c = 1;
            while (c != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                c = int.Parse(Console.ReadLine());

                if (c == 0)
                {
                    Environment.Exit(0);
                }

                if (c == 1)
                {
                    Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                    int n = int.Parse(Console.ReadLine()); // saisir le nombre
                    // calcul de r
                    long r = calcul(1, n);                                      
                    Console.WriteLine(n + "! = " + r);
                    
                }
                else
                {
                    if (c == 2)
                    {
                        Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                        int t = int.Parse(Console.ReadLine()); // saisir le nombre
                        Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                        int n = int.Parse(Console.ReadLine()); // saisir le nombre
                        // calcul de r
                        long r = calcul((t-n+1),t);
                        Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                        
                           
                    }
                    else
                    {
                        Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                        int t = int.Parse(Console.ReadLine()); // saisir le nombre
                        Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                        int n = int.Parse(Console.ReadLine()); // saisir le nombre
                        // calcul de r1
                        long r1 = calcul((t - n + 1), t);
                        long r2 = calcul(1, n);                                                
                        Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                        
                            
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
