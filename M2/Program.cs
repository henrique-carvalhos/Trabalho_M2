using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float somaGramatura = 0;
            float mediaGramatura = 0;
            double maxGram, minGram;
            int contaprovado = 0, contreprovado = 0, contreprocesso = 0, contador = 0;

            while (contador <= 5)
            {
                Console.Write("Artigo: ");
                string artigo = Console.ReadLine();

                Console.Write("g/m² padrão: ");
                float gramaturaPadrao = float.Parse(Console.ReadLine());
                maxGram = gramaturaPadrao * 1.05;
                minGram = gramaturaPadrao * 0.95;

                for (int i = 1; i <= 5; i++)
                {
                    Console.Write(i + ") g/m²: ");
                    float gramatura = float.Parse(Console.ReadLine());

                    somaGramatura = somaGramatura + gramatura;
                    mediaGramatura = somaGramatura / 5;

                    if ((mediaGramatura >= minGram && mediaGramatura <= maxGram))
                    {
                        contaprovado++;
                    }
                    else
                    {
                        if (mediaGramatura < minGram)
                        {
                            contreprovado++;
                        }
                        else
                        {
                            contreprocesso++;
                        }
                    }
                }
                Console.WriteLine("Média: " + mediaGramatura);
                contador++;
                Console.Clear();
            }
            Console.WriteLine("Total de aprovados: "+contaprovado);
            Console.WriteLine("Total de reprovados: "+contreprovado);
            Console.WriteLine("Total de reprocessos: "+contreprocesso);

            Console.ReadKey();
        }
    }
}
