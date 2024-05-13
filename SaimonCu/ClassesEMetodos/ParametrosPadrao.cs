using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.ClassesEMetodos
{
    class ParametrosPadrao
    {
        public static int Somar(int a = 1, int b = 1) //usar quando nao usar ref ou out
        {
            return a + b;
        }
        public static void Executar()
        {
            Console.WriteLine(Somar(10, 23));
            Console.WriteLine(Somar(50));
            Console.WriteLine(Somar());
            Console.WriteLine(Somar(b: 9));
        }
    }
}
