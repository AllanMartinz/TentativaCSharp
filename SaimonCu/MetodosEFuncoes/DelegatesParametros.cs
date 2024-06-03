using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.MetodosEFuncoes
{
    internal class DelegatesParametros
    {
        public delegate int Operacao(int x, int y);
        public static int Soma(int x, int y)
        {
            return x + y;
        }
        public static string Calculadore(Operacao op, int x, int y)
        {
            var resultado = op(x, y);
            return "RESULTADO: " + resultado;
        }

        public static void Executar()
        {
            Operacao subb = (int x, int y) => x - y;
            Console.WriteLine(Calculadore(subb, 80, 456));

            Console.WriteLine(Calculadore(Soma, 43, 34));
        }
    }
}
