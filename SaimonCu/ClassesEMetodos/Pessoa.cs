using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public string PessoaId()
        {
            return string.Format($"Ola meu nome é {Nome} e tenho {Idade} anos!");
        }
        public void SeApresentar()
        {
            Console.WriteLine(PessoaId());
        }
        public void Zerar()
        {
            Nome = " ";
            Idade = 0; 
        }

    }
}
