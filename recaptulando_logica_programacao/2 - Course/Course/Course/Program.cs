using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               bool completo = false;
               char genero = 'F';
               char letra = '\u0041';
               byte n1 = 126;
               int n2 = 1000;
               int n3 = 2147483647;
               long n4 = 2147483647L;
               float n5 = 4.5f;
               double n6 = 4.5;
               string nome = "SOL";
               object obj1 = "LUA";
               object obj2 = 1.0f;

               Console.WriteLine(letra);
               Console.WriteLine(genero);
               Console.WriteLine(completo);
               Console.WriteLine(n1);
               Console.WriteLine(n2);
               Console.WriteLine(n3);
               Console.WriteLine(n4);
               Console.WriteLine(n5);
               Console.WriteLine(n6);
               Console.WriteLine(nome);
               Console.WriteLine(obj1);
               Console.WriteLine(obj2);
            */

            /*
            int n7 = int.MinValue;
            int n8 = int.MaxValue;
            sbyte n9 = sbyte.MinValue;
            decimal n10 = decimal.MaxValue;

            Console.WriteLine(n7);
            Console.WriteLine(n8);
            Console.WriteLine(n9);
            Console.WriteLine(n10);
            */

            double saldo = 10.35784;
            int idade = 32;
            string nome = "Maria";
            char sexo = 'F';

            Console.Write("Olá mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Até mais.");

            Console.WriteLine();
            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("RESULTADO = " + saldo);
            Console.WriteLine("O valor do troco é " + saldo + " reais");
            Console.WriteLine("O valor do troco é " + saldo.ToString("F2") + " reais");

            Console.WriteLine();
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome,  idade, saldo);
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
            Console.WriteLine("A paciente " + nome + " tem " + idade + " anos e seu sexo é: " + sexo);
            

            Console.ReadLine();

        }
    }
}
