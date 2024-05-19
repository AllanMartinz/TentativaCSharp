using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SaimonCu.Colecoes
{
        class ColecoesSet
        {

        public class Produto
        {
            public string Nome;
            public double Preco;

            public Produto(string nome, double preco)
            {
                Nome = nome;
                Preco = preco;
            }
        }
        public static void Executar()
            {
            //Set nao aceita index    
            //Set nao aceita repeticao

                var Manga = new Produto("Chainsaw Man", 49.9);
                var carrinho = new HashSet<Produto>(); //<pega no meu produto> 8========================================================D
                carrinho.Add(Manga); // Add --> add um id por vez

            //############  LINK --> ColecoesList   ################33

                var Combo = new HashSet<Produto> // set é mais usado como HashSet
            {
                new Produto("Camisa", 29.9),
                new Produto("Pochita", 99.9),
                new Produto("Poster", 10), // ##! mesmo com/sem o Equals vai repetir o poster pela falta HashCode
                new Produto("Poster", 10), // ##! com o HashCode vai evitar repeticao
                //--! se eu adicionar o "Manga" ele nao vai ser adicionado pq vai ser repeticao
            };


                carrinho.UnionWith(Combo); // UnionWith --> UnionWith uniao de id
                Console.WriteLine(carrinho.Count); ; //quantos id possui o carrinho
                //carrinho.RemoveAt(3); //vai Excluir o 4 item da lista

                foreach (var item in carrinho) // mostrar o numero do item, nome, preço
                {
                    //Console.Write(carrinho.IndexOf(item));//numero item
                    Console.WriteLine($"{item.Nome} {item.Preco}");// qual item
                    //--! id = identificador
                }
            Console.WriteLine(carrinho.Count);
            carrinho.Add(Manga);
            Console.WriteLine(carrinho.Count);
            //Console.WriteLine(carrinho.LastIndexOf(Manga));
        }
        }
    
}

