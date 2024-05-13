using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.ClassesEMetodos
{
    public enum Genero{ Terror, Comedia, Acao, Suspense, Horror }; // enum é enumerar
    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;
    }
    class ExemploEnum
    {
        public static void Executar()
        {
            int id = (int)Genero.Horror; // no int var numerar ate o alvo 
            //Ex int id = (int)Genero.Horror vai contar as palavras ate horror -> 4 | vai ser 0,1,2,3,4
            Console.WriteLine(id);

            var filmePika = new Filme();
            filmePika.Titulo = "The Evil Dead";
            filmePika.GeneroDoFilme = Genero.Horror; // dentre os 5 generos o genero do filme vai ser escolido logo apos enum escolhido 
            //nesse caso horror 
            Console.WriteLine("{0} é {1}", filmePika.Titulo, filmePika.GeneroDoFilme);
        }
    }
}
