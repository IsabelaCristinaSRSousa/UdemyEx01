using System;

namespace UdemyEx03
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto01 = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            produto01.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto01.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque:");
            produto01.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto01);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser adicionados no estoque:");
            int qte = int.Parse(Console.ReadLine());

            produto01.AdicionarProdutos(qte);

            Console.WriteLine("Dados do produto atualizados: " + produto01 );

            Console.WriteLine();

            Console.WriteLine("Digite o número de produtos a serem retirados do estoque:");
            qte = int.Parse(Console.ReadLine());

            produto01.RemoverProdutos(qte);

            Console.WriteLine("Dados do produto ataulizados: " + produto01);







        }
    }
}
