using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.Excecoes
{
    public class NegativoException : Exception //Exception --> dentro de system
    {
        public NegativoException() { }

        public NegativoException(string message) : base(message) { }

        public NegativoException(string message, Exception inner) : base(message, inner) { }
    }

    public class ImparException : Exception
    {
        public ImparException(string message) : base(message){ }
    }

    class ExcecoesPersonalizadas
    {
        public static int PositivoPar()
        {
            Random rnd = new Random();
            int valor = rnd.Next(-30,30);
            Console.WriteLine(valor);
            if (valor < 0)
                {
                    throw new NegativoException("Numero negativo...");
                }
                if (valor % 2 == 1)
                {
                    throw new ImparException("Valor impar...");
                }
            

            return valor;
        }

        public static void Executar()
        {
                try
                {
                    Console.WriteLine(PositivoPar());
                }
                catch (NegativoException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (ImparException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Thanks!");
                }

        }
    }
}
