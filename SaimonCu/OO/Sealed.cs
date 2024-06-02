
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.OO
{
    sealed class SemFilho // classe selada nao permite heranca

    {
        public double ValorDaFortuna()
        {
            return 1_407_033.65;
        }
    }

    class Avo
    {
        public virtual bool HonrarNomeFamilia()
        {
            return true;
        }
    }
    class Pai : Avo
    {
        public override sealed bool HonrarNomeFamilia()
        {
            return true;
        }
    }
    class FilhoRebelde : Pai
    {
        public /*override -> sealed nao permite override*/ new/*permite new*/ bool HonrarNomeFamilia()
        {
            return false;
        }
    }
    internal class Sealed
    {
        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho);

            FilhoRebelde filhoRebelde = new FilhoRebelde();
            Console.WriteLine(filhoRebelde);   

        }
    }
}
