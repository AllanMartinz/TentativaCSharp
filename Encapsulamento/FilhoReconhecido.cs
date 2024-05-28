using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class FilhoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("FilhoReconhecido...");

            Console.WriteLine(InfoPublica); // public --> acesso publico
            Console.WriteLine(CorDoOlho);  // protected --> heranca de SubCelebridade
            Console.WriteLine(NumeroCell); // internal --> mesmo projeto
            Console.WriteLine(JeitoDeFalar); // protected internal --> mesmo projeto / heranca
            Console.WriteLine(SegredoFamilia); // private protected --> mesma classe / heranca
        //  Console.WriteLine(UsoPhotoShop); // private --> mesma classe logo FilhoReconhecido sem acesso

        }


    }
}