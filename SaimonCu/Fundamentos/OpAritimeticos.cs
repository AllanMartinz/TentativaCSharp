using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.Fundamentos
{
    class OpAritimeticos
    {
        public static void Executar()
        {
            // PRECO DESCONTO
            var preco = 1000.00;
            var imposto = 355;
            double desconto = 0.1;
            int total = (int)preco + imposto;
            var PrecoTot = total - total * desconto;
            Console.WriteLine($"O preço do preoduto é de: R${PrecoTot}.");

            // IMC
            var peso = 91.2;
            double altura = 1.82;
            int imc = (int)peso / (int)Math.Pow(altura, 2); // Math.Pow elevar num a potencia Math= matematica; Pow= potencia
            Console.WriteLine("O IMC é de: {0}", imc);

            //IMPAR PAR
            var par = 24;
            var imp = 55;
            Console.WriteLine($"{par}/2 tem resto {par % 2} -> Par");
            Console.WriteLine($"{imp}/2 tem resto {imp % 2} -> Impar");

        }
    }
}
