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





    }
}