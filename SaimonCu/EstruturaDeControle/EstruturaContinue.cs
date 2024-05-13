using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.EstruturaDeControle
{
    class EstruturaContinue
    {
        public static void Executar()
        {
            int intervalo = 50;
            Console.WriteLine("Os numeros pares de 1 e {0}!", intervalo);
            for (int i = 1; i <= intervalo; i++)
            {
                if (i % 2 == 1)
                {
                    continue; //impede a repeticao pre matura
                }
                Console.Write(i + " ");
            }
        }
    }
}
