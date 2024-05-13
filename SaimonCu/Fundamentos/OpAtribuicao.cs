using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.Fundamentos
{
    class OpAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 = 4; // num1 vale agora 4 nao mais 3
            num1 += 10; // num1 = num1 + 10;
            num1 -= 1; // num1 = num1 - 1;
            num1 *= 5; // num1 = num1 * 5;
            num1 /= 2; // num1 = num1 / 2;
            // resultado final = 32
            Console.WriteLine(num1);

            int a = 1;
            int b = a;
            a++; //a = a + 1;
            b--; //b = b - 1;


            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "joao";

            dynamic d = c;
            d.nome = "maria";
            Console.WriteLine(c.nome);
        }
    }
}
