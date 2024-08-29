using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Threading.Tasks;
#pragma warning disable CS8632

namespace AULAS_C_.models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} \n e eu tenho {Idade} anos de idade, poucas idéias brother Jesus Cristo é o senhor!");
        }
    }
}