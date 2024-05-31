using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.OO
{
    public abstract class Celular //pode ser util para herdar outras classes | polimorfismo
    {
        public abstract string Assistente(); //metodo sem corpo

        public string Tocar() // metodo concreto - tem corpo
        {
            return "trin trin trin...";
        }
    }

    public class Iphone : Celular // ao tentar ser herdada a Assistente() ira impidir por ser abstract
    {
        public override string Assistente() //logo precisara de override para sobreescrever ela com concreto
        {
            return "Ola meu nome é Vivian";
        }
    }
    class Abstract
    {
        public static void Executar()
        {
            //Celular c = new Celular(); // ao ser colocada a class como abstract ela é abistrata/ nao é real
            //so pode instaciar classes concretas 
            var celular = new Iphone();
            Console.WriteLine(celular);
        }
    }
}
