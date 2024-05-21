using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.Colecoes
{
    class ColecoesStack
    {
        public static void Executar()
        { //stack nao usa .Generic
            var pilha = new Stack();
            // stack usa Push para lista
            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach (var item in pilha)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}"); // Remove o preimeiro elemento da lista

            foreach (var item in pilha)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\nPeek: {pilha.Peek()}"); //pega o primeiro da lista mas nao remove
            Console.WriteLine(pilha.Count);

        }
    }
}
