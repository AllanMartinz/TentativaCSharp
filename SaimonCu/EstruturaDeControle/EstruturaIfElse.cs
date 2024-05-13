using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.EstruturaDeControle
{
    class EstruturaIfElse
    {
        public static void Executar()
        {
            Console.Write("qual e a sua nota? ");
            double.TryParse(Console.ReadLine(), out double nota);
            Console.WriteLine("teve bom comportamento? s/n");
            string BomComport = Console.ReadLine();
            if (nota >= 6.0 && BomComport.ToLower() == "s") { //tolower abrange as letras maiusculas e minusculas
                Console.WriteLine("aprovado!!!");
            } else {Console.WriteLine("reprovado!!!"); }
        }
    }
}
