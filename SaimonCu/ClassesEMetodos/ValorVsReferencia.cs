using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.ClassesEMetodos
{
    class ValorVsReferencia
    {
        public struct Dependente { public string Nome; public int Idade; }
        public static void Executar()
        {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}");
            numero++;
            Console.WriteLine($"{numero} {copiaNumero}");

            Dependente dep = new Dependente { Nome = "beto", Idade = 20};
            Dependente copiaDep = dep;
            Console.WriteLine($"{dep.Nome} {copiaDep.Idade}");
            Console.WriteLine($"{copiaDep.Idade} {dep.Idade}");

            copiaDep.Nome = "Renato";
            copiaDep.Idade = 23;
            Console.WriteLine($"{dep.Nome} {copiaDep.Idade}");
            Console.WriteLine($"{copiaDep.Idade} {dep.Idade}");





        }
    }
}
