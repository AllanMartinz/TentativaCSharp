using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.Colecoes
{
    class ColecoesQueue
    { // Queue = Fila
        public static void Executar()
        {
            var fila = new Queue<string>();
            fila.Enqueue("Fulano"); // Enqueue --> Atribuir """Quem ta na fila""" 
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek()); // Peek() --> pegar o primeiro elemento da fila """primeiro a sair da fila"""
            Console.WriteLine(fila.Count);  //com o peek() o fulano continua na fila
            //-->Para tirar o "Fulano" é usado o Dequeue()
            Console.WriteLine(fila.Dequeue()); // ele literalçmente tira o elemento da fila
            foreach(var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("item")/* --!bool  | false */);
            //Contains() --> vai ser se é true ou false seta na fila
            Console.WriteLine(salada.Contains("Item")/* true */);
        }


        
    }
}
