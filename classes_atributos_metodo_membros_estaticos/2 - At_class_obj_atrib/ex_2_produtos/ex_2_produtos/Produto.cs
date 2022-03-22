using System;
using System.Globalization;

namespace ex_2_produtos
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return this.Quantidade * this.Preco;
        }

        public void AdicionarProdutos(int quantidade)
        {
            this.Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            this.Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"{this.Nome}, " +
                   $"$ {this.Preco.ToString("F2", CultureInfo.InvariantCulture)}, " +
                   $"{this.Quantidade} unidades, " +
                   $"Total: {this.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }

        /*
        public void ListaProdutos(Produto[] Lista)
        {
            Console.WriteLine("Lista de produtos: ");
            for (int i = 0; i < Lista.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Nome: {Lista[i].Nome}");
                Console.WriteLine($"Preco: {Lista[i].Preco}");
                Console.WriteLine($"Quantidade no estoque: {Lista[i].Quantidade}");
                Console.WriteLine("--------------------------------------");
            }
        }
        */
    }
}
