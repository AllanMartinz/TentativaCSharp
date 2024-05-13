using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.Fundamentos
{
    class OpUnarios
    {
        public static void Executar()
        {
            var negativo = -5;
            var num1 = 2;
            var num2 = 3;
            var booleano = true;

            Console.WriteLine(-negativo); // - * - = + / 5
            Console.WriteLine(!booleano); // false

            num1++;
            Console.WriteLine(num1); // 3
            --num2;
            Console.WriteLine(num2); // 2

            Console.WriteLine(num1++ == --num2); // false = vai fazer a comparacao primeiro num1 == --num2 e depois vai transformar em num++ por causa da posicao 
            // --var = primeiro / var++ segundo | vise versa
            Console.WriteLine($"{num1} {num2}");

        }
    }
}
