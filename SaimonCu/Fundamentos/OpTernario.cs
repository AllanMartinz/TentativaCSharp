using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.Fundamentos
{
    class OpTernario
    {
        public static void Executar()
        {
            double nota = 7.0;
            bool BomComport = true;
            string Resultado = nota >= 7.0 && BomComport 
                ? "Aprovado!!!" : "Reprovado!!!"; // ? = se a nota for true var ser aprovado / : = se for false vai ser reprovado
            Console.WriteLine(Resultado);
        }
    }
}
