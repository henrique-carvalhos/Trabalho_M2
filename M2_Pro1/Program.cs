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
            double somaGrm = 0, mediaGrm = 0, somaLarg = 0, mediaLarg = 0;
            string resulTestGrm = " ";
            string resulTestLarg = " ";

            Console.WriteLine("---------------------------------------------------------------------------------\n");
            Console.WriteLine(" ***                 SISTEMA DE GESTÃO DA QUALIDADE - TÊXTIL                 *** ");
            Console.WriteLine("---------------------------------------------------------------------------------\n");
            Console.WriteLine("Olá! Seja bem vindo ao SGQ, sistema que gerencia a qualidade de tecidos têxteis.");
            Console.WriteLine("Software será capaz de fazer a validação dos testes de largura e gramatura (g/m²)");
            Console.WriteLine("Seram utilizados como base as normas: \n");
            Console.WriteLine("NBR 10591 - Materiais têxteis - Determinação da gramatura de superfícies têxteis");
            Console.WriteLine("NBR 10589 - Materiais têxteis -Determinação da largura de não-tecidos e tecidos planos");



            while ()
            {
                Console.WriteLine("Deseja iniciar os testes? S/N");

                Console.WriteLine("Digite os padrões de acordo com o tecido");

                Console.Write("Artigo: ");
                string artigo = Console.ReadLine();

                Console.Write("Gramatura (g/m²): ");
                float gramatura = float.Parse(Console.ReadLine());

                Console.Write("Largura (m): ");
                float largura = float.Parse(Console.ReadLine());

                Console.Write("\nTolerância da gramatura (%): ");
                float toleranciaGrm = float.Parse(Console.ReadLine());
                maxGrm = gramatura * (toleranciaGrm / 100 + 1);
                minGrm = gramatura - (gramatura * toleranciaGrm / 100);

                Console.Write("Tolerância da largura (%): ");
                float toleranciaLarg = float.Parse(Console.ReadLine());
                maxLarg = largura * (toleranciaLarg / 100 + 1);
                minLarg = largura - (largura * toleranciaLarg / 100);

                for (int i = 1; i <= 5; i++)
                {
                    Console.Write(i + ") g/m²: ");
                    float leituraGrm = float.Parse(Console.ReadLine());

                    somaGrm = somaGrm + leituraGrm;
                    mediaGrm = somaGrm / 5;
                }

                if ((mediaGrm >= minGrm && mediaGrm <= maxGrm))
                {
                    resulTestGrm = "APROVADO";
                }
                else
                {
                    if (mediaGrm < minGrm)
                    {
                        resulTestGrm = "REPROVADO";
                    }
                    else
                    {
                        resulTestGrm = "REPROCESSAR";
                    }
                }

                for (int i = 1; i <= 3; i++)
                {
                    Console.Write(i + ") largura: ");
                    float leituraLarg = float.Parse(Console.ReadLine());
                    somaLarg = somaLarg + leituraLarg;
                    mediaLarg = somaLarg / 3;
                }

                if ((mediaLarg >= minLarg && mediaLarg <= maxLarg))
                {
                    resulTestLarg = "APROVADO";
                }
                else
                {
                    if (mediaLarg > minLarg)
                    {
                        resulTestLarg = "REPROVADO";
                    }
                    else
                    {
                        resulTestLarg = "REPROCESSAR";
                    }
                }
            }


            Console.WriteLine("\n\tRESULTADO FINAL\n");
            Console.WriteLine("Artigo: "+artigo);

            Console.WriteLine("Média da gramatura\tTolerância permitida");
            Console.WriteLine(mediaGrm+" "+resulTestGrm+"\t\t"+minGrm.ToString("f2") + " ~ " + gramatura + " ~ " + maxGrm.ToString("f2"));

            Console.WriteLine("Média da largura\tTolerância permitida");
            Console.WriteLine(mediaLarg.ToString("f2")+ " " + resulTestLarg + "\t\t"+minLarg.ToString("f2") + " ~ " + largura + " ~ " + maxLarg.ToString("f2"));
            Console.ReadKey();
        }
    }
}
