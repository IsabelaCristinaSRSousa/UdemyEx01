﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyEx01
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade )
        {
            this.Nome = nome;
            this.Idade = idade;
        }
        
    }
}
