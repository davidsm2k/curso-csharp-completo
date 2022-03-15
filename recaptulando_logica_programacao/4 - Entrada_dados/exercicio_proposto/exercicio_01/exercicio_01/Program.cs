using System;

namespace exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercicio 01
        
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;

            Console.WriteLine($"SOMA = {soma}");
        }
    }
}
