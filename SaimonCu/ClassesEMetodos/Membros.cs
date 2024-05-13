using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa saimon = new Pessoa();
            saimon.Nome = "saimon";
            saimon.Idade = 18;
            //Console.WriteLine($"{saimon.Nome} tem {saimon.Idade} anos!");
            saimon.SeApresentar();
            saimon.Zerar();
            saimon.SeApresentar();

            var NaoSaimon = new Pessoa();
            NaoSaimon.Nome = "beto";
            NaoSaimon.Idade = 21;

            var ApresentarBeto = NaoSaimon.SeApresentar;
            NaoSaimon.SeApresentar();
            
        }
    }
}
