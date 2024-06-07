using SaimonCu.EstruturaDeControle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.fe_n
{
    class doido
    {
        public static void Executar()

        { 
            string entrada;
            do
            {
               //sdjigvubkj
                Outrodoido Quem = new Outrodoido();
                Console.Write("qual seu nome: ");
                Quem.Nome = Console.ReadLine();
                Console.Write("qual sua idade: ");
                int.TryParse(Console.ReadLine(), out Quem.Idade);
                Quem.Apresentar();
                entrada = Console.ReadLine();
                if (Quem.Idade > 0)
                {
                    Quem.Zerar();
                }
                if (entrada.ToLower() == "s")
                {
                    Console.WriteLine("GOOD!!!");
                }
                else{ Console.WriteLine("Putz"); }
            } while (entrada.ToLower() != "s");
        }

    }
}
