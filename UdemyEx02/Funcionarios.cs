using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyEx02
{
    class Funcionarios
    {
        public string Nome { get; set; }
        public double salario { get; set; }

        public Funcionarios(string nome, double salario)
        {
            this.Nome = nome;
            this.salario = salario;

        }
        
    }
}
