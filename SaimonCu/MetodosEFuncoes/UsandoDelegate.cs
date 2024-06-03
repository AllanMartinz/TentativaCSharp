using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.MetodosEFuncoes
{

    class UsandoDelegate
    {
        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double MinhaSoma(double x, double y)
        {
            return x + y;
        }

        static void MeuImprimirSoma(double a, double b)
        {
            Console.WriteLine(a + b);
        }

        public static void Executar()
        {
            Soma op1 = MinhaSoma; //se as var no parametro da MinhaSoma tenha nome diff, mas mesma assinatura ira executar normalmente
            Console.WriteLine(op1(1, 2));

            ImprimirSoma op2 = MeuImprimirSoma;
            op2(4, 4);

            Func<double, double, double> op3 = MinhaSoma; //return de MinhaSoma
            Console.WriteLine(op3(5,5));

            Action<double, double> op4 = MeuImprimirSoma; //sem return
            op4(6.6, 79.1);
        }
    }
}
