using System;
using System.Globalization;

namespace Console_a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            int idade1, idade2;
            double media;

            string[] vet = Console.ReadLine().Split(' ');
            nome1 = vet[0];
            idade1 = int.Parse(vet[1]);            
            
            vet = Console.ReadLine().Split(' ');
            nome2 = vet[0];
            idade2 = int.Parse(vet[1]);

            media = (double) (idade1 + idade2) / 2;
            /*casting: a variável "média" declarada como double está recebendo dois valores inteiros (idade 1 e
                idade 2), e o resultado desse processamento é um valor quebrado, portanto é nescessário fazer o 
                casting, que é nada mais nada menos que informar ao programa que você deseja obter uma resposta
                com número flutuante (double/float).
            */

            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + media.ToString("F1", CultureInfo.InvariantCulture)+ " anos.");

            Console.ReadKey ();
        }
    }
}
