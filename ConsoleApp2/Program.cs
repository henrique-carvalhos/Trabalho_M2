using System;
using System.Globalization;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double bas, altura, area, perimetro,diagonal;

            bas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = bas * altura;
            perimetro = 2 * bas + 2 * altura;
            diagonal = Math.Sqrt(Math.Pow(bas, 2.0) + Math.Pow(altura, 2.0));

            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
