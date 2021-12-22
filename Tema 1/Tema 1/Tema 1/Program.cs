using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_1
{
    /// <summary>
    /// Calculati suma elementelor unui vector de n numere citite de la tastatura. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n, suma = 0;
            Console.Write("Scrie numarul n dorit: ");
            n = int.Parse(Console.ReadLine());

            int[]v = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                suma += v[i];
            }
            Console.WriteLine($"Suma elementelor unui vector este: {suma}");
        }
    }
}
