using System;

namespace laco_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int digitos, soma = 0;

            Console.Write("Quantos numeros inteiros voce vai digitar? ");
            digitos = int.Parse(Console.ReadLine());

            for (int x = 1; digitos >= x; x++)
            {
                Console.Write($"Digite o valor {x}: ");
                soma += int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Soma = {soma}");

        }
    }
}
