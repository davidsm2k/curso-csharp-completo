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
            x.SetLadoA(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            x.SetLadoB(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            x.SetLadoC(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            y.SetLadoA(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            y.SetLadoB(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            y.SetLadoC(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine($"Área de X = {x.Area().ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área de Y = {y.Area().ToString("F4", CultureInfo.InvariantCulture)}");

            string maiorArea = x.Area() > y.Area() ? "Maior área: X" : "Maior área: Y";

            Console.WriteLine(maiorArea);
        }

    }
 }
