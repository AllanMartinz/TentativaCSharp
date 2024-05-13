using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.Fundamentos
{
    class OpLogicos
    {
        public static void Executar()
        {
            var ExeTrab1 = true;
            var ExeTrab2 = false;
             //operador binario opera em cima de 2 operanos
            var comprTV50 = ExeTrab1 && ExeTrab2; // && = e / -> Binario
            Console.WriteLine("Comprou a tv 50? {0}", comprTV50);

            bool comprSORV = ExeTrab1 || ExeTrab2; // || = ou / -> Binario
            Console.WriteLine("Comprou o sorvete? {0}", comprSORV);

            var comprTV32 = ExeTrab1 ^ ExeTrab2; // ^ = ou exclusivo / -> Binario
            Console.WriteLine("Comprou a tv 32?{0}", comprTV32);

            Console.WriteLine(" Mais Saudavel?{0}", !comprSORV); // !var = negacao / -> unario =  inverte o valor de um determinado operano
        }
    }
}
