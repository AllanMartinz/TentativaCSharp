using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.MetodosEFuncoes
{
    //################ LAMBDA SIMPLES ################ 
    //pode se usar o delegate dentro ou fora de uma class
    delegate double Operacao/*Tipo*/(double x, double y)/*parametro*/;
    class LambdasDelegate
    {
        public static void Executar()
        { 
            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao mul = (x, y) => x * y;

            Console.WriteLine(sum(90,2));
            Console.WriteLine(sub(5,1));
            Console.WriteLine(mul(2,9));
        }
    }
}
