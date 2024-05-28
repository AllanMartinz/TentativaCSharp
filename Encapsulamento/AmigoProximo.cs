using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class AmigoProximo
    {
         
        
        public readonly SubCelebridade amigo = new SubCelebridade();

        public void MeusAcessos()
        {

            Console.WriteLine("AmigoProximo...");

            Console.WriteLine(amigo.InfoPublica); 
        //  Console.WriteLine(amigo.CorDoOlho); //heranca
            Console.WriteLine(amigo.NumeroCell); 
            Console.WriteLine(amigo.JeitoDeFalar); 
        //  Console.WriteLine(amigo.SegredoFamilia); // privado / heranca
        }
        
    }
}
