using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class SubCelebridade
    {   //todos
        public string InfoPublica = "Tenho um Insta!!";

        //heranca
        protected string CorDoOlho = "Verde";

        //mesmo projeto (assembly)
        internal/*quem tiver nesse projeto tera acesso*/ ulong/*sem sinal*/ NumeroCell = 5541999999999;

        //heranca ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas girias";

        //mesma class ou heranca no mesmo projeto (c# >= 7.2)
        private protected string SegredoFamilia = "bla bla";

        //private é o padrao
        bool UsaPhotoShop = true;
        public void MeusAcessos()
        {
            Console.WriteLine("Subcelebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCell);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaPhotoShop);
        }
    }
}
