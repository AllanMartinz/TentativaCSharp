using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto (string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
    class List
    {
        public static void Executar()
        {
            //list nao e um static
            var Manga = new Produto("Chainsaw Man", 49.9);
            var carrinho = new List<Produto>(); //<pega no meu produto> 8========================================================D
            carrinho.Add(Manga); // Add --> add um id por vez

            var Combo = new List<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("Pochita", 99.9),
                new Produto("Poster", 10),
            };
            carrinho.AddRange(Combo); // AddRange --> Add Varios id em uma unica vez
            Console.WriteLine(carrinho.Count);; //quantos id possui o carrinho
            carrinho.RemoveAt(3); //vai Excluir o 4 item da lista

            foreach (var item in carrinho) // mostrar o numero do item, nome, preço
            {
                Console.Write(carrinho.IndexOf(item));//numero item
                Console.WriteLine($"{item.Nome} {item.Preco}");// qual item

                //--! id = identificador
            }
        }
    }
}
