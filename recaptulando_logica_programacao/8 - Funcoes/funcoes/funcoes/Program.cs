using System;

namespace funcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ACHANDO NUMERO MAIOR

            Console.WriteLine("Digite 3 numeros: ");
            string[] numeros = Console.ReadLine().Split(' ');
            int n1 = int.Parse(numeros[0]);
            int n2 = int.Parse(numeros[1]);
            int n3 = int.Parse(numeros[2]);

            int resultado = Maior(n1, n2, n3);

            Console.WriteLine($"Maior = {resultado}");
        }

        static int Maior(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
    }
}
