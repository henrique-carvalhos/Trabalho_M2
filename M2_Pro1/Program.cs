﻿using System;
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
            Console.WriteLine(" *** SISTEMA DE GESTÃO DA QUALIDADE - TÊXTIL *** ");
            Console.WriteLine("-------------------------------------------------\n");
            Console.WriteLine("Digite os padrões de acordo com o tecido");

            Console.Write("Artigo: ");
            string artigo = Console.ReadLine();

            Console.Write("Gramatura (g/m³): ");
            float gramatura = float.Parse(Console.ReadLine());

            Console.Write("Largura (m): ");
            float largura = float.Parse(Console.ReadLine());


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


            Console.ReadKey();
        }
    }
}
