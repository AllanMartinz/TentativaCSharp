using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SaimonCu.ClassesEMetodos
{
    public class Client
    {
        public string Nome;
        readonly DateTime Nascimento; // readonly e o mesmo de const mas nao precisa atribuir um numero
        // serve apenas para leitura
        public Client(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }
        public string GetDataDeNascimento()
        {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
            
        }
    }
    class ReadOnly
    {
        public static void Executar()
        {
            var novoClient = new Client("Luiza", new DateTime(1995, 6, 14));
            Console.WriteLine(novoClient.Nome);
            Console.WriteLine(novoClient.GetDataDeNascimento()+ "\n");
            
            var novoClient2 = new Client("Marcio", new DateTime(2005, 12, 19));
            Console.WriteLine(novoClient2.Nome);
            Console.WriteLine(novoClient2.GetDataDeNascimento());
        }
    }
}
