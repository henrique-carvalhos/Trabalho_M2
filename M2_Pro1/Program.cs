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
            /* Programa.: Sistema de gestão da qualidade
             * Problema.:Desenvolver um algoritmo que seja capaz de receber dados de um artigo (produto/tecido), fazer o processamento dessas informações e apresentar para o usuário se este produto está aprovado ou não, seguindo as seguintes instruções:
                    •	Dados de cadastro:
                        o	Artigo: campo para que o usuário digite o nome do produto.
                        o	Gramatura: deve conter um número até 900.
                        o	Largura: deve conter um número até 2.
                        o	Tolerância da gramatura: digitar um valor de no máximo 5%.
                            	Calcular valor máximo e mínimo do valor da gramatura de acordo com a tolerância digitada (ex.: gramatura +5% e gramatura -5%).
                        o	Tolerância da largura: digitar um valor de no máximo 2%.
                            	Calcular valor máximo e mínimo do valor da largura de acordo com a tolerância digitada (ex.: largura +2% e largura -2%).
                        o	Após o usuário digitar o número, esse número será verificado, caso não esteja dentro da condição, o programa pedirá que o usuário digite um novo número (apenas nos campos: gramatura, largura, tolerância da gramatura e largura).
                    •	Após a digitação de todos os dados de cadastro, o teste será iniciado e o usuário deverá digitar 5 valores referentes a gramatura, esses valores serão somados e em segunda será calculado a média.
                        o	A média da gramatura será verificada da seguinte forma:
                            	Se a média estiver entre os valores mínimo e o máximo de gramatura, ele está aprovado.
                            	Se média for menor que o valor mínimo de gramatura, ele será reprovado.
                            	Caso a gramatura fique maior que o máximo, será reprocessado.
                    •	Em seguida, o teste referente a largura será iniciado e o usuário deverá digitar 3 valores referentes a largura, esses valores serão somados e em segunda será calculado a média.
                        o	A média da largura será verificada da seguinte forma:
                            	Se a média estiver entre os valores mínimo e o máximo de largura, ele está aprovado.
                            	Se média for maior que o valor máximo de largura, ele será reprovado.
                            	Caso a largura fique menor que o mínimo, será reprocessado.
                    •	Como resultado final, o programa deverá apresentar as seguintes informações:
                        o	Artigo.
                        o	Média da gramatura, se ela está aprovada, reprovada ou será reprocessada, gramatura padrão, resultado da máxima e mínima da gramatura. 
                        o	Média da largura, se ela está aprovada, reprovada ou será reprocessada, largura padrão, resultado da máxima e mínima da largura. 
                    •	No fim, o programa deverá perguntar se o usuário deseja realizar um novo teste, se a resposta for sim, o programa será reiniciado, e se a resposta for não o programa será finalizado.
             * Data.....: 05/06/2022.
             * Autor(es): Abner Cassilhas, Derick, Henrique de Carvalho.
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
                Console.WriteLine("Serão utilizadas como base as normas: \n");
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

                //Estrutura de repetição - Verificar se o valor da gramatura digitada está correto
                while (gramatura > 900)
                {
                    Console.Write("Valor incorreto! \nDigite um valor até 900 g/m²: ");
                    novaGrm = float.Parse((Console.ReadLine()));
                    gramatura = novaGrm;//processamento/atribuição da nova gramatura
                }

                Console.Write("Largura (m): ");
                largura = float.Parse(Console.ReadLine());//digitar números até 2,0 metros

                //Estrutura de repetição - Verificar se o valor da largura digitada está correto
                while (largura > 2)
                {
                    Console.Write("Valor incorreto! \nDigite um valor até 2 metros: ");
                    novaLarg = float.Parse((Console.ReadLine()));
                    largura = novaLarg;//processamento/atribuição da nova largura
                }

                //Processamento das tolerâncias de gramatura
                Console.Write("\nTolerância da gramatura (%): ±");
                toleranciaGrm = float.Parse(Console.ReadLine());//tolerância deve ser de ± 5%

                //Estrutura de repetição - Verificar se a tolerância digitada está correto
                while (toleranciaGrm > 5)
                {
                    Console.Write("Valor incorreto! \nDigite uma tolerância de no máximo 5%: ");
                    novaToleranciaGrm = float.Parse((Console.ReadLine()));
                    toleranciaGrm = novaToleranciaGrm;//processamento/atribuição da nova tolerância
                }

                maxGrm = gramatura * (toleranciaGrm / 100 + 1);//processamento do máximo de gramatura
                minGrm = gramatura - (gramatura * toleranciaGrm / 100);//processamento do minímo de gramatura

                //Processamento das tolerâncias da largura
                Console.Write("Tolerância da largura (%): ±");
                toleranciaLarg = float.Parse(Console.ReadLine());//tolerância deve ser de ± 2%

                //Estrutura de repetição - Verificar se a tolerância digitada está correto
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

                    //Estrutura de repetição - Verificar se o valor da gramatura digitada está correto
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

                    //Estrutura de repetição - Verificar se o valor da largura digitada está correto
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

