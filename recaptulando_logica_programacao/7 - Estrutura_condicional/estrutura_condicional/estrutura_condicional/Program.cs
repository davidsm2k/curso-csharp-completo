using System;

namespace estrutura_condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            int x = 10;

            Console.WriteLine("Bom dia");

            if(x < 5)
            {
                Console.WriteLine("Boa noite");
            }*/

            /*
            Console.WriteLine("Entre com um numero inteiro: ");
            int x = int.Parse(Console.ReadLine());
            
            if (x % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }
            */

            /*
            double a, b, c, delta, x1, x2;

            string[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = b * b - 4 * a * c;

            if (a == 0.0 || delta < 0.0) {
                Console.WriteLine("IMPOSSIVEL CALCULAR");
            }
            else {
                x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("X1 = " + x1.ToString("F4", CultureInfo.InvariantCulture));
                Console.WriteLine("X2 = " + x2.ToString("F4", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();
            */

            Console.WriteLine("Qual a hora atual ? ");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde");
            }
            else
            {
                Console.WriteLine("Boa noite");
            }
        }
    }
}
