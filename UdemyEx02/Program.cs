using System;

namespace UdemyEx02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios funcionario1 = new Funcionarios("Antônio",6300.00);
            Funcionarios funcionario2 = new Funcionarios("Edna", 6700.00);

            double mediaSalarial = (funcionario1.salario + funcionario2.salario) / 2;

            Console.WriteLine("A média salarial dos funcionários é: " + mediaSalarial);
        }
    }
}
