using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.Colecoes
{
    class ColecoesDictionary
    {
        public static void Executar()
        {   //o dictionary aceita dois tipos int e string
            var filmes = new Dictionary<int/*Key*/ , string/*Value*/>(); // string --> aceita repeticao | int --> nao aceita repeticao

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incriveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004)) //pega na key
            {
                Console.WriteLine("2004: "+ filmes[2004]); // como fosse uma array que se pode pegar pela Key
                Console.WriteLine("2004: "+ filmes.GetValueOrDefault(2008)); // vai resultar uma string vazia que nao existe pois se esta usando uma key de 2004
            }
            Console.WriteLine(filmes.ContainsValue("Amnesia")); // false nao tem um filme Amnesia

            Console.WriteLine($"Removeu? {filmes.Remove(2004)}"); //true --> se o "filme" existir ira ser removido

            filmes.TryGetValue(2006, out string filmes2006); //essa string vai valer a key logo sera "O Grande Truque"
            Console.WriteLine($"FilmeGae: {filmes2006}!");

            foreach (var filmesData in filmes.Keys) //mostra as keys
            {
                Console.WriteLine($"KeyData: {filmesData}");
            }

            foreach (var filmesName in filmes.Values) // mostra as Values
            {
                Console.WriteLine($"ValueName: {filmesName}");
            }
            //HARDCORE
            foreach (KeyValuePair<int, string> filme in filmes) //KeyValuePair --> pode colocar o par na linha
            {//KeyValuePair precisa definir o que ele é <int, string>
                Console.WriteLine($"O Filme {filme.Value} é de {filme.Key}.");
            }
            //EASYMODE
            foreach (var filme in filmes) //nao precisa fazer o KeyValuePair
            {
                Console.WriteLine($"O Filme {filme.Value} é de {filme.Key}.");
            } 
        }
    }
}
