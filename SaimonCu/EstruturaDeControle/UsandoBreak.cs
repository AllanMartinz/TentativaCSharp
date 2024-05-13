using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.EstruturaDeControle
{
    class UsandoBreak
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine("O numero que queremos é: {0}", numero);

            for (int i = 1; i <= 50; i++) {
                Console.WriteLine("{0} é o numero que queremos?", i);
                if (i == numero) {
                    Console.WriteLine("sim");
                    break; // break = quebra /nessa linhar so vai quebrar apenas quando for achado o nume que queremos
                } else { Console.WriteLine("nao"); }
            }
        }
    }
}
