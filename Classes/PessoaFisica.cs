using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoBackEnd.Interfaces;

namespace ProjetoBackEnd.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string? cpf { get; set; }

        public DateTime DataNasc { get; set; }

        public bool dataNascNova {get; set; }

        public override float CalcularImposto(float rendimentos)
        {

            float CalcImpostos = (rendimentos / 100);

            if (rendimentos < 1500) { return 0; }
            else if (rendimentos >= 1500 && rendimentos < 3500) { return CalcImpostos * 2; }
            else if (rendimentos >= 3500 && rendimentos < 6000) { return CalcImpostos * 3.5f; }
            else { return CalcImpostos * 5; }

        }

        public bool ValidarDataNasc(DateTime DataNasc)
        //validar a maioridade da data de nascimento:
        {
            //receber a data atual:
            DateTime dataAtual = DateTime.Today;

            //resultado da data de nascimento menos a data atual:
            double anos = (dataAtual - DataNasc).TotalDays / 365;

            Console.WriteLine(anos);

            if (anos >= 18) { return true; }

            return false;

        }

        public bool ValidarDataNasc(String DataNasc)
        //trabalhar a informacao se vier em formato diferente:    
        {
            //tentar forçar a conversao
            if (DateTime.TryParse(DataNasc, out DateTime dataConvertida))
            {

                //repete o metodo anterior:
                DateTime dataAtual = DateTime.Today;

                double anos = (dataAtual - dataConvertida).TotalDays / 365;

                Console.WriteLine(anos);

                if (anos >= 18) { return true; }


            }

            return false;

            throw new NotImplementedException();
        }


    }
}