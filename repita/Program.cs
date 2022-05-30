using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1, lim; 
            ulong a = 1, b = 1 ,r;

            Console.Write("Qual ao limite? ");
            lim = int.Parse(Console.ReadLine());

            while(x <= lim)
            {
                Console.WriteLine(+x+") "+a);

                r = a + b;

                a = b;
                b = r;

                x++;
            }
            Console.ReadKey();
        }
    }
}
