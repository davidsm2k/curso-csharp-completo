using System;
using System.Globalization;

namespace ex_2_produtos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("** Entre com os dados do produto **");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: \n \t {produto}");
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            produto.AdicionarProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Dados atualizados: \n \t {produto}");
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removidos ao estoque: ");
            produto.RemoverProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Dados atualizados: \n \t {produto}");

        }
    }
} 
