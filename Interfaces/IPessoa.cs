using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBackEnd.Interfaces
{
    public interface IPessoa
    {
         float CalcularImposto(float rendimentos);
    }
}