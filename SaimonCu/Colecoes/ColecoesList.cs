using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.Colecoes
{
    public class Produto // Ctrl + . + mouse em cima = opcao rapidas 
    {
        public string Nome;
        public double Preco;

        public Produto (string nome, double preco) // construtor | usar opcao rapida
        {
            Nome = nome;
            Preco = preco;
        }
         
        
        // ##########   LINK --> Igualdade  ##########

        public override/*sobreescrever*/ bool Equals(object obj) // o obj que queremos é o Produto | usar opcao rapida
        {
            Produto outroProduto = (Produto)obj;
            bool mesmoNome = Nome == outroProduto.Nome;
            bool mesmoPreco = Preco == outroProduto.Preco;
            return mesmoNome && mesmoPreco; //se tiverem o mesmoNome/Preco quer dizer que sao iguais

        }

        // ##########  LINK --> ColecoeSet  ##########
        // Set usa apenas Hash
        // usar HashCode em unico atributo para evitar dor de cabeca /usar ID
        public override int GetHashCode() // opcao rapida |! vai ser crida um hashCode U N I C O para um elementos especifico
        {
            return Nome.Length; // usar o Length(Comprimento do nome) para encontrar a repeticao
        }
        //serve como banco de dados | nesse caso ele vai usar o Equals para que nao haja elementos iguais

    }
    class ColecoesList
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
            Console.WriteLine(carrinho.Count);
            carrinho.Add(Manga);
            Console.WriteLine(carrinho.LastIndexOf(Manga));
        }
    }
}
