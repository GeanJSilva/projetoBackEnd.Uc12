using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoBackEnd.Interfaces;

namespace ProjetoBackEnd.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string? Nome {get; set;}

        public Endereco? Endereco {get; set;}

        public float rendimentos {get;set;}

        //polimorfismo, ele pode ser usado de diferentes formas em cada classe (Abstract):
        public abstract float CalcularImposto(float rendimentos);


    }

    }
