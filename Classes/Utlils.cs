using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBackEnd.Classes
{
    public static class Utlils
    {
        
        public static void barraCarregamento(string? texto){
        
        Console.WriteLine($"{texto}");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.BackgroundColor = ConsoleColor.Yellow;
        for (var contador = 0; contador < 6; contador++)
        {
            Console.Write($" ");
            Thread.Sleep(500);
        }
        Console.ResetColor();
       


        }
//Verificar se existem pasta e arquivos, caso nao haja, criar:
        public static void VerificarPastaArquivo(string Caminho){
            string pasta = Caminho.Split("/")[0];
    
    // o ! inverte a condicao de verdadeiro
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(Caminho))
            {
                using (File.Create(Caminho)){}   
            };
        }      
    }
}
