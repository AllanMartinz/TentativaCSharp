using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.EstruturaDeControle
{
    class EstruturaForeach
    {
        public static void Executar()
        {
            var palavra = "pipa";
            foreach (var letras in palavra) //foreach = para cada  /vai repetir as letra uma por uma na palavra
                // in = na
            {
                Console.WriteLine(letras);
            }

            var nomes = new string[] { "banjo", "insomnia", "saimon" };
            foreach (var quemsou in nomes)
            {
                Console.WriteLine($"Quem sou eu?");
                Console.WriteLine( quemsou );
            }
        }
    }
}
