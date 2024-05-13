using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.EstruturaDeControle
{
    class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.WriteLine("Qual nota: ");
            string suaNota = Console.ReadLine();
            double.TryParse(suaNota, out double nota);
            if (nota >= 9.0) {Console.WriteLine("bom"); } 
            else if(nota >= 7.0) {
                Console.WriteLine("pode melhorar"); }
            else if (nota >= 3.0){
                Console.WriteLine("smt");
            } else { Console.WriteLine("next!"); }

            Console.WriteLine("end");

        }
    }
}
