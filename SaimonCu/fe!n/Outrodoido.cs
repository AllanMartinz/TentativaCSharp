using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.fe_n
{
    class Outrodoido
    {
        public string Nome;
        public int Idade;

        public String IdFulano()
        {
            return String.Format($"Entao seu bct nome é {Nome} e sua idade é {Idade} anos! (S/N)");
        }
        public void Apresentar()
        {
            Console.WriteLine(IdFulano());
        }

        public void Zerar()
        {
            Nome = " ";
            Idade = 0;
        }
    }
}
