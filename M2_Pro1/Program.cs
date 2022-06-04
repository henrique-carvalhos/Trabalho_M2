using System;
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
            /* Programa.:
             * Problema.:
             * Data.....:
             * Autor(es):Abner, Derick, Henrique.
             */

            //Declaração de variáveis
            string artigo;
            float gramatura, novaGrm, largura, novaLarg, toleranciaGrm, novaToleranciaGrm, toleranciaLarg, novaToleranciaLarg, leituraGrm, novaLeituraGrm, leituraLarg, novaLeituraLarg;
            double maxLarg, minLarg, maxGrm, minGrm, somaGrm = 0, mediaGrm = 0, somaLarg = 0, mediaLarg = 0;
            string resulTestGrm = " ", resulTestLarg = " ", respReiniciaProgram = "S";

            //Estrutura de repetição - reinicia o programa todo
            while ((respReiniciaProgram == "S" || respReiniciaProgram == "s" || respReiniciaProgram == "Sim" || respReiniciaProgram == "sim" || respReiniciaProgram == "SIM"))
            {
                //Títito e interface de apresentação do programa
                Console.WriteLine("-------------------------------------------------------------------------------------");
                Console.WriteLine(" ***                   SISTEMA DE GESTÃO DA QUALIDADE - TÊXTIL                   *** ");
                Console.WriteLine("-------------------------------------------------------------------------------------\n");
                Console.WriteLine("Olá! Seja bem vindo ao SGQ, sistema que gerencia a qualidade de tecidos têxteis.");
                Console.WriteLine("Software capaz de fazer a validação dos testes de largura e gramatura (g/m²)");
                Console.WriteLine("Seram utilizados como base as normas: \n");
                Console.WriteLine("NBR 10591 - Materiais têxteis - Determinação da gramatura de superfícies têxteis");
                Console.WriteLine("NBR 10589 - Materiais têxteis -Determinação da largura de não-tecidos e tecidos planos\n");
                Console.Write("Tecle enter para continuar.");
                Console.ReadKey();
                Console.Clear();

                //Estrutura de repetição - Animação de troca de tela
                Console.Write("Iniciando o teste");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(" .");
                    Thread.Sleep(1000);
                }
                Console.Clear();

                //Entrada dos dados a serem cadastrados 
                Console.WriteLine("Digite os padrões de acordo com o tecido a ser cadastrado");

                Console.Write("Artigo: ");
                artigo = Console.ReadLine();

                Console.Write("Gramatura (g/m²): ");
                gramatura = float.Parse(Console.ReadLine());//deve conter números até 900
                //Estrutura de repetição - Verificar se o valor da gramatura digitada está correta
                while (gramatura > 900)
                {
                    Console.Write("Valor incorreto! \nDigite um valor até 900 g/m²: ");
                    novaGrm = float.Parse((Console.ReadLine()));
                    gramatura = novaGrm;//processamento/atribuição da nova gramatura
                }

                Console.Write("Largura (m): ");
                largura = float.Parse(Console.ReadLine());//digitar números até 2,0 metros
                //Estrutura de repetição - Verificar se o valor da largura digitada está correta
                while (largura > 2)
                {
                    Console.Write("Valor incorreto! \nDigite um valor até 2 metros: ");
                    novaLarg = float.Parse((Console.ReadLine()));
                    largura = novaLarg;//processamento/atribuição da nova largura
                }
                //Processamento das tolerâncias de gramatura
                Console.Write("\nTolerância da gramatura (%): ±");
                toleranciaGrm = float.Parse(Console.ReadLine());//tolerância deve ser de ± 5%
                //Estrutura de repetição - Verificar se a tolerância digitada está correta
                while (toleranciaGrm > 5)
                {
                    Console.Write("Valor incorreto! \nDigite uma tolerância de no máximo 5%: ");
                    novaToleranciaGrm = float.Parse((Console.ReadLine()));
                    toleranciaGrm = novaToleranciaGrm;//processamento/atribuição da nova tolerância
                }
                maxGrm = gramatura * (toleranciaGrm / 100 + 1);//processamento do máximo de gramatura
                minGrm = gramatura - (gramatura * toleranciaGrm / 100);//processamento do minímo de gramatura

                Console.Write("Tolerância da largura (%): ±");
                toleranciaLarg = float.Parse(Console.ReadLine());//tolerância deve ser de ± 2%
                //Estrutura de repetição - Verificar se a tolerância digitada está correta
                while (toleranciaLarg > 2)
                {
                    Console.Write("Valor incorreto! \nDigite uma tolerância de no máximo 2%: ");
                    novaToleranciaLarg = float.Parse((Console.ReadLine()));
                    toleranciaLarg = novaToleranciaLarg;//processamento/atribuição da nova tolerância
                }

                maxLarg = largura * (toleranciaLarg / 100 + 1);//processamento do máximo de largura
                minLarg = largura - (largura * toleranciaLarg / 100);//processamento do minímo de largura

                //Estrutura de repetição - Animação de troca de tela
                Console.Write("\nSalvando as informações digitadas");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(" .");
                    Thread.Sleep(1000);
                }
                Console.Clear();

                //Estrutura de repetição - Entrada dos dados coletados da gramatura
                Console.WriteLine("Digite os dados coletados dos corpos de prova\n");
                Console.WriteLine("Valores dos corpos de prova da gramatura");

                for (int i = 1; i <= 5; i++)
                {
                    Console.Write(i + ") g/m²: ");
                    leituraGrm = float.Parse(Console.ReadLine());
                    //Estrutura de repetição - Verificar se o valor da gramatura digitada está correta
                    while (leituraGrm > 900)
                    {
                        Console.Write("Valor incorreto! \nDigite um valor até 900 g/m²: ");
                        novaLeituraGrm = float.Parse((Console.ReadLine()));
                        leituraGrm = novaLeituraGrm;//processamento/atribuição da nova gramatura
                    }

                    somaGrm = somaGrm + leituraGrm;//processamento de soma das gramaturas digitadas
                    mediaGrm = somaGrm / 5;//processamento da média da soma das gramaturas
                }

                //Estrutura condicional composta encadeada - Verificação da média da gramatura
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

                Console.WriteLine("\nValores dos corpos de prova da largura"); ;

                //Estrutura de repetição - Entrada dos dados coletados da largura
                for (int i = 1; i <= 3; i++)
                {
                    Console.Write(i + ") largura: ");
                    leituraLarg = float.Parse(Console.ReadLine());//digitar números até 2,0 metros
                    //Estrutura de repetição - Verificar se o valor da largura digitada está correta
                    while (leituraLarg > 2)
                    {
                        Console.Write("Valor incorreto! \nDigite um valor até 2 metros: ");
                        novaLeituraLarg = float.Parse((Console.ReadLine()));
                        leituraLarg = novaLeituraLarg;//processamento/atribuição da nova largura
                    }

                    somaLarg = somaLarg + leituraLarg;//processamento de soma das larguras digitadas
                    mediaLarg = somaLarg / 3;//processamento da média da soma das larguras
                }

                //Estrutura condicional composta encadeada - Verificação da média da largura
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

                //Estrutura de repetição - Animação de troca de tela
                Console.Write("\nCalculando os resultados");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(" .");
                    Thread.Sleep(1500);
                }
                Console.Clear();

                //Saída dos dados - Apresentação do resultado dos testes
                Console.WriteLine("\n\t\tRESULTADO FINAL\n");
                Console.WriteLine("Artigo: " + artigo);
                Console.WriteLine("\nMédia da gramatura\t\tTolerância permitida");
                Console.Write(mediaGrm.ToString("f2") + " " + resulTestGrm + "\t\t" + minGrm.ToString("f2") + " ~ " + gramatura + " ~ " + maxGrm.ToString("f2"));
                Console.WriteLine("\nMédia da largura\t\tTolerância permitida");
                Console.WriteLine(mediaLarg.ToString("f2") + " " + resulTestLarg + "\t\t" + minLarg.ToString("f2") + " ~ " + largura + " ~ " + maxLarg.ToString("f2"));
                Console.Write("\n\nTecle enter para continuar.");
                Console.ReadKey();
                Console.Clear();

                //Estrada da resposta para reiniciar o programa
                Console.Write("Deseja realizar um novo teste? S/N - ");
                respReiniciaProgram = Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine("Obrigado por utilizar o SGQ!\nAté mais :)");
            Console.ReadKey();
        }
    }
}

