using System;
using SaimonCu.ClassesEMetodos;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using SaimonCu.Colecoes;

namespace SaimonCu.Topicos_Avancados
{
    public class Caixa<T>
    {
        T valorPrivado;
        public T Coisa { get; set; }


        public Caixa(T coisa)
        {
            Coisa = coisa;
            valorPrivado = coisa;
        }
        public T metodoGenerico(T valor)
        {
            return new Random().Next(0, 2) == 0 ? Coisa : valor;
        }

        public T GetValor()
        {
            return valorPrivado;
        }

    }

    class CaixaInt : Caixa<int>
    {
        public CaixaInt() : base(0)
        {

        }
    }

    //class CaixaProduto : Caixa<Produto>
    //{
    //    public CaixaProduto() : base(new Produto())
    //    {

    //    }
    //}

    class Genericos
    {
        public static void Executar()
        {
            var caixa1 = new Caixa<int>(1000);
            Console.WriteLine(caixa1.metodoGenerico(33));
            Console.WriteLine(caixa1.Coisa.GetType());            
            
            var caixa2 = new Caixa<string>("Contrutor");
            Console.WriteLine(caixa2.metodoGenerico("Metodo"));
            Console.WriteLine(caixa2.Coisa.GetType());

            //CaixaProduto caixa3 = new CaixaProduto();
            //Console.WriteLine(caixa3.Coisa.GetType().Name);
        }
    }
}

  