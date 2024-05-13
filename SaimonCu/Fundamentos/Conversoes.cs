using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inte = 10;
            double queb = inte;
            Console.WriteLine(inte);

            double nota = 9.7;
            int notaTrunc = (int) nota; //(int) converte o double para int / e tambem faz para o codigo possa funcionar
            Console.WriteLine("nota troncada: {0}", nota);

            Console.Write("digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("idade insirida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString); //funciona desse jeito tambem
            Console.WriteLine("res:" + idadeInteiro);

            Console.WriteLine("digite um num: ");
            string palavra = Console.ReadLine();
            int numer;
            int.TryParse(palavra, out numer); //TryParse vai tentar aplicar o parse -> se conseguir = numero se nao conseguir = 0 / out vai jogar a palavra para o numer
            Console.WriteLine("o num foi: {0}", numer);
            if (numer == 0) { 
                Console.WriteLine("nao foi possivel");
            };
            Console.WriteLine("digite num 2: ");
            int.TryParse(Console.ReadLine(), out int numer2);
            Console.WriteLine("pepega: " + numer2);
        }
    }
}
