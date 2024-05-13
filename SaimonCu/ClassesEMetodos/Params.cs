using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.ClassesEMetodos
{
    class Params
    {
        //foi feito um static para nao precisar chamar uma estancia
        public static void Recepcionar(params string[] pessoa) // params = conjunto de parametros
        {
            foreach (string pessoas in pessoa) { Console.WriteLine("ola {0} ",pessoas); }
        }
        public static void Executar()
        {
            Recepcionar("marco", "beto", "lola");
        }
    }
}
