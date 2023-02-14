using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBackEnd.Interfaces
{
    public interface IPessoaFisica
    {
        bool ValidarDataNasc(DateTime DataNasc);
    }
}