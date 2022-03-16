﻿using System;
using System.Globalization;

namespace exercicio_fixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int quarto;
            double produto;
            string[] vet;

            Console.WriteLine("Entre com seu nome completo: ");
            nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na casa?");
            quarto = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura (mesma liha): ");
            vet = Console.ReadLine().Split(" ");
            string sobreNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quarto);
            Console.WriteLine(produto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(sobreNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
