using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var world = ("ola".ToUpper().Insert(3, "World!").Replace("World!", " Mundo!".ToUpper()));
            Console.WriteLine(world);

            string importante = null; //null = nulo nao tem nada
            Console.WriteLine(importante?.Length); //? aplica o .Length ou qualquer se tiver ou nao o vaor da var
            // nesse caso o var é nulo se rodar sem o ? vai dar erro!!!

        }
    }
};
