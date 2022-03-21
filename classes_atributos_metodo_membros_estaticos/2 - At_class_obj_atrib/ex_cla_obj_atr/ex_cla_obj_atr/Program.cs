using System;
using System.Globalization;

namespace ex_cla_obj_atr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicios do anexo -> primeiros-exercicio.pdf

            // Exercicio 1
            /*
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            Pessoa pessoaMaisVelha = p1.Idade > p2.Idade ? p1 : p2;

            Console.WriteLine($"Pessoa mais velha: {pessoaMaisVelha.Nome}");
            */

            //Exercicio 2
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionario: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSalario = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine($"Salario médio: {mediaSalario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
