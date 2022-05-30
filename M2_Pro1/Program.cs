using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_Pro1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double maxLarg, minLarg, maxGrm, minGrm;

            Console.WriteLine(" *** SISTEMA DE GESTÃO DA QUALIDADE - TÊXTIL *** ");
            Console.WriteLine("-------------------------------------------------\n");
            Console.WriteLine("Digite os padrões de acordo com o tecido");

            Console.Write("Artigo: ");
            string artigo = Console.ReadLine();

            Console.Write("Gramatura (g/m³): ");
            float gramatura = float.Parse(Console.ReadLine());

            Console.Write("Largura (m): ");
            float largura = float.Parse(Console.ReadLine());
            
            Console.Write("\nTolerância da gramatura (%): ");
            float toleranciaGrm = float.Parse(Console.ReadLine());
            maxGrm = gramatura * (toleranciaGrm / 100 + 1 );
            minGrm = gramatura - (gramatura * toleranciaGrm / 100);

            Console.Write("Tolerância da largura (%): ");
            float toleranciaLarg = float.Parse(Console.ReadLine());
            maxLarg = largura * (toleranciaLarg / 100 + 1);
            minLarg = largura - (largura * toleranciaLarg / 100);   

            for (int i = 1; i <= 5; i++)
            {
                Console.Write(i + ") g/m²: ");
                float leituraGrm = float.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= 3; i++)
            {
                Console.Write(i + ") largura: ");
                float leituraLarg = float.Parse(Console.ReadLine());
            }

            Console.Write("RESULTADO FINAL");
            Console.WriteLine("Artigo: "+artigo);
            Console.WriteLine("Gramatura: "+minGrm.ToString("f2") + " ~ " + gramatura + " ~ " + maxGrm.ToString("f2"));
            Console.WriteLine("Largura: "+minLarg.ToString("f2") + " ~ " + largura + " ~ " + maxLarg.ToString("f2"));
            Console.ReadKey();
        }
    }
}
