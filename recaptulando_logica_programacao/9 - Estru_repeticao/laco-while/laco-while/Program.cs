using System;
using System.Globalization;

namespace laco_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;

            do
            {
                Console.WriteLine("Digite um numero: ");
                numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (numero !>= 0)
                {             
                    double calculo = Math.Sqrt(numero);
                    Console.WriteLine($"Raiz quadrada de {numero} é {calculo.ToString("F3", CultureInfo.InvariantCulture)}");
                }
                else
                {
                    Console.WriteLine("Número negativo!");
                }
            } while (numero >= 0);

        }
    }
}
