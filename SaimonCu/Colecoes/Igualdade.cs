using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.Colecoes
{
    class Igualdade //###########   LINK --> ColecoesList  ###########
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.89); // uma instancia
            var p2 = new Produto("Caneta", 1.89); // outra instancia
            var p3 = p2; 
            
            //ENDERECO DE MEMORIA
            Console.WriteLine(p1 == p2); // false --> pois cada new Produto sao locais de memoria diff
            Console.WriteLine(p3 == p2); // true --> p3 aponta o mesmo local de memoria que p2

            // VALOR
            // --! COM O LINK SE TORNA TRUE POIS OS VALORES SAO IGUAIS | COMPAROU O NOME COM NOME E PRECO COM PRECO
            Console.WriteLine(p1.Equals(p2)); // false --> compara endereco(local) de memoria



        }
    }
}
