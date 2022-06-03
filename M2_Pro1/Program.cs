﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace M2_Pro1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string artigo = " ";
            float gramatura = 0, largura = 0;
            float toleranciaGrm, toleranciaLarg, leituraGrm, leituraLarg;
            double maxLarg = 0, minLarg = 0, maxGrm = 0, minGrm = 0;
            double somaGrm = 0, mediaGrm = 0, somaLarg = 0, mediaLarg = 0;
            string resulTestGrm = " ";
            string resulTestLarg = " ";
            string respReiniaProgram = " ";

            while (respReiniaProgram == "S") 
            {
                Console.WriteLine("---------------------------------------------------------------------------------");
                Console.WriteLine(" ***                 SISTEMA DE GESTÃO DA QUALIDADE - TÊXTIL                 *** ");
                Console.WriteLine("---------------------------------------------------------------------------------\n");
                Console.WriteLine("Olá! Seja bem vindo ao SGQ, sistema que gerencia a qualidade de tecidos têxteis.");
                Console.WriteLine("Software capaz de fazer a validação dos testes de largura e gramatura (g/m²)");
                Console.WriteLine("Seram utilizados como base as normas: \n");
                Console.WriteLine("NBR 10591 - Materiais têxteis - Determinação da gramatura de superfícies têxteis");
                Console.WriteLine("NBR 10589 - Materiais têxteis -Determinação da largura de não-tecidos e tecidos planos\n");
                Console.Write("Tecle enter para continuar.");
                Console.ReadKey();
                Console.Clear();

                Console.Write("Iniciando o teste");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(" .");
                    Thread.Sleep(1000);
                }
                Console.Clear();

                Console.WriteLine("Digite os padrões de acordo com o tecido");

                Console.Write("Artigo: ");
                artigo = Console.ReadLine();

                Console.Write("Gramatura (g/m²): ");
                gramatura = float.Parse(Console.ReadLine());

                Console.Write("Largura (m): ");
                largura = float.Parse(Console.ReadLine());

                Console.Write("\nTolerância da gramatura (%): ");
                toleranciaGrm = float.Parse(Console.ReadLine());
                maxGrm = gramatura * (toleranciaGrm / 100 + 1);
                minGrm = gramatura - (gramatura * toleranciaGrm / 100);

                Console.Write("Tolerância da largura (%): ");
                toleranciaLarg = float.Parse(Console.ReadLine());
                maxLarg = largura * (toleranciaLarg / 100 + 1);
                minLarg = largura - (largura * toleranciaLarg / 100);

                Console.Write("\nSalvando as informações digitadas");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(" .");
                    Thread.Sleep(1000);
                }
                Console.Clear();

                Console.WriteLine("Digite os dados coletados\n");
                for (int i = 1; i <= 5; i++)
                {
                    Console.Write(i + ") g/m²: ");
                    leituraGrm = float.Parse(Console.ReadLine());

                    somaGrm = somaGrm + leituraGrm;
                    mediaGrm = somaGrm / 5;
                }

                if ((mediaGrm >= minGrm && mediaGrm <= maxGrm))
                {
                    resulTestGrm = "APROVADO   ";
                }
                else
                {
                    if (mediaGrm < minGrm)
                    {
                        resulTestGrm = "REPROVADO  ";
                    }
                    else
                    {
                        resulTestGrm = "REPROCESSAR";
                    }
                }

                Console.WriteLine();

                for (int i = 1; i <= 3; i++)
                {
                    Console.Write(i + ") largura: ");
                    leituraLarg = float.Parse(Console.ReadLine());
                    somaLarg = somaLarg + leituraLarg;
                    mediaLarg = somaLarg / 3;
                }

                if ((mediaLarg >= minLarg && mediaLarg <= maxLarg))
                {
                    resulTestLarg = "APROVADO   ";
                }
                else
                {
                    if (mediaLarg > minLarg)
                    {
                        resulTestLarg = "REPROVADO  ";
                    }
                    else
                    {
                        resulTestLarg = "REPROCESSAR";
                    }
                }
                Console.Write("\nCalculando os resultados");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(" .");
                    Thread.Sleep(1500);
                }
                Console.Clear();

                Console.WriteLine("\n\t\tRESULTADO FINAL\n");
                Console.WriteLine("Artigo: " + artigo);

                Console.WriteLine("\nMédia da gramatura\t\tTolerância permitida");
                Console.Write(mediaGrm.ToString("f2") + " " + resulTestGrm + "\t\t" + minGrm.ToString("f2") + " ~ " + gramatura + " ~ " + maxGrm.ToString("f2"));

                Console.WriteLine("\nMédia da largura\t\tTolerância permitida");
                Console.WriteLine(mediaLarg.ToString("f2") + " " + resulTestLarg + "\t\t" + minLarg.ToString("f2") + " ~ " + largura + " ~ " + maxLarg.ToString("f2"));
                Console.Write("Tecle enter para continuar.");
                Console.ReadKey();
                Console.Clear();

                Console.Write("Deseja realizar um novo teste? ");
                respReiniaProgram = Console.ReadLine();
            
            }
            Console.ReadKey();
        }
    }
}
