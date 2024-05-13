using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.EstruturaDeControle
{
    class EstruturaDoWhile
    {
        public static void Executar()
        {
            string entrada;
            do //do = faça / execute esssas linhas
            {
                Console.Write("Qual o seu nome: ");
                entrada = Console.ReadLine();
                Console.WriteLine($"Seja bem vindo {entrada}!");
                Console.WriteLine("Deseja continuar? (S/N)");
                entrada = Console.ReadLine();
            } while (entrada.ToLower() == "s"); //while = enquanto / ira repetir as linhas anteriores enquanto for "s"
        }
    }
}
