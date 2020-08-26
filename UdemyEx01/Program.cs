using System;

namespace UdemyEx01
{
    class Program
    {
        static void Main(string[] args)
        {
     
            Pessoa p1 = new Pessoa("Alice", 18);
            Pessoa p2 = new Pessoa("Mario", 20);

            if(p1.Idade > p2.Idade)
            {
                Console.WriteLine("A pessoa mais velha é: " + p1.Nome);
            }
            else
            {
                Console.WriteLine("A pessoa mais velha é: " + p2.Nome);
            }

        }
    }
}
