using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.ClassesEMetodos
{
    class DesafioAtributo
    {
        
        int a = 1;

        public static void Executar()
        {
            var loco = new DesafioAtributo();
            Console.WriteLine(loco.a);
        }
    }
}
