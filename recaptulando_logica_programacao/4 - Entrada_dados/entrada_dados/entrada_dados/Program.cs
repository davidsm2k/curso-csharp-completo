using System;
using System.Globalization;

namespace entrada_dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                string frase = Console.ReadLine();
                string p1 = Console.ReadLine();
                string p2 = Console.ReadLine();
                string p3 = Console.ReadLine();

                Console.WriteLine($"Você digitou: \n{frase}\n{p1}\n{p2}\n{p3}");
            */

            /*
            string s = Console.ReadLine();
            string[] v = s.Split(" ");
            ou   */

            /*
            string[] v = Console.ReadLine().Split(' ');

            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine($"\n{a}\n{b}\n{c}");
            */

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//Le com ponto

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine($"{nome} {sexo} {idade} {altura.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
