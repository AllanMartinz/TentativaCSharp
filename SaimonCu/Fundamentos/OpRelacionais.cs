using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.Fundamentos
{
    class OpRelacionais
    {
        public static void Executar()
        {
            //double nota = 6.0;
            
            
            double notaCorte = 7.0;
            Console.Write($"qual sua nota? ");
            double.TryParse(Console.ReadLine(), out double nota);
            Console.WriteLine("Nota invalida? {0}", nota > 10.0); // > maior que
            Console.WriteLine("Nota invalida? {0}", nota < 0.0); // < menor que
            Console.WriteLine("Nota perfeita? {0}", nota == 10.0); // == igual a
            Console.WriteLine("tem como melhora? {0}", nota != 10.0); // != diferente
            Console.WriteLine("Passou por media? {0}", nota >= notaCorte); // maior ou igual a
            Console.WriteLine("Recuperacao? {0}", nota < notaCorte);
            Console.WriteLine("Reprovado? {0}", nota <= 3.0); //menor ou igual q
            
            
        }
    }
}
