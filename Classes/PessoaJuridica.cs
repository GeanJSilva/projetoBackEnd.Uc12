using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ProjetoBackEnd.Interfaces;

namespace ProjetoBackEnd.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? cnpj {get;set;}

        public string? razaoSocial {get;set;}

        public override float CalcularImposto(float rendimentos)
        {
        
            float CalcImpostos = (rendimentos /100);

            if (rendimentos <3000) { return CalcImpostos * 3;}
            else if (rendimentos >=3000 && rendimentos < 6000) {return CalcImpostos * 5; }
            else if (rendimentos >=6000 && rendimentos < 10000) {return CalcImpostos * 7;  }
            else{return CalcImpostos * 9;}
            
        }

        public bool ValidarCnpj(string cnpj)
        {
            //Regex comparara se o valor informado segue o padrao descrito:
            bool retornoCnpjValido =  Regex.IsMatch(cnpj, @"^(\d{14})|(\d{2}.\d{3}.\d{3}/\d{4}-\d{2}) $");

            if (retornoCnpjValido)
            { 
                //faz uma checagem de partes especificas do valor:
                string substringCnpj14 = cnpj.Substring(8, 4);

                if (substringCnpj14 == "0001")
                    {return true;}
                  
            }
            else if (retornoCnpjValido)
            {
                string substringCnpj18 = cnpj.Substring(11, 4);

                if (substringCnpj18 == "0001")
                    {return true;}
            }         

           return false;

        }

        internal object ValidarCnpj()
        {
            throw new NotImplementedException();
        }
    }
}