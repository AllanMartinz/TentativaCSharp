using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulamento;

namespace SaimonCu.OO
{
    public class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("FilhoNaoReconhecido...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            //  Console.WriteLine(NumeroCell); // internal --> projeto diff
            Console.WriteLine(JeitoDeFalar);
            //  Console.WriteLine(SegredoFamilia); //private/protected --> privado/heranca mesmo projto
            //   Console.WriteLine(UsoPhotoShop); // private --> privado
        }
    }

    public class AmigoDestante
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public new void MeusAcessos()
        {
            Console.WriteLine("AmigoDistante...");

            Console.WriteLine(amiga.InfoPublica);
        //  Console.WriteLine(amiga.CorDoOlho);
        //  Console.WriteLine(amiga.NumeroCell);
        //  Console.WriteLine(amiga.JeitoDeFalar);
        //  Console.WriteLine(amiga.SegredoFamilia);
        //  Console.WriteLine(amiga.UsaPhotoShop);
        }
    }

    class Encapsulamento
    {
        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();
            new SubCelebridade().MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            
            new FilhoNaoReconhecido() .MeusAcessos();
            new AmigoDestante().MeusAcessos();
        }
    }
}
