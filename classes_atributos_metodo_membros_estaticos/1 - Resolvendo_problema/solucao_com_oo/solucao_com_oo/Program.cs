using System;
using System.Globalization;

namespace solucao_com_oo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            x.ladoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.ladoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.ladoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            y.ladoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.ladoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.ladoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Área de X = {x.Area().ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área de Y = {y.Area().ToString("F4", CultureInfo.InvariantCulture)}");

            string maiorArea = x.Area() > y.Area() ? "Maior área: X" : "Maior área: Y";

            Console.WriteLine(maiorArea);
        }

    }
 }
