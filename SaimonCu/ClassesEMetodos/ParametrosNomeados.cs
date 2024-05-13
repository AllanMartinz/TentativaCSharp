using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.ClassesEMetodos
{
    internal class ParametrosNomeados
    {
        public static void Data(int dia, int mes, int ano)
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);
        }
        public static void Executar()
        {
            Data(dia: 15, mes: 12, ano: 2005); // parametros nomedos é mais usado para ficar mais facil a leitura
              //(15, 12 , 2005) pode ser feito assim mas fica um pouco complicado
              //ao colocar nome pode alterar a lugar dele e o codigo vai rodar normalmente
        }
    }
}
