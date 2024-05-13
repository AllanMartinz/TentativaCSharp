using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.ClassesEMetodos
{
    class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero){ numero = numero + 1000; } //ref apenas uma direcao
        public static void AlterarOut(out int numero1, out int numero2) { 
            numero1 = 2; // comp
            numero2 = 2; // comp
            numero1 = numero1 + 15; 
            numero2 = numero2 + 30; 
        } // out mais de uma direcao
        

        public static void Executar()
        {
            int a = 3;
            AlterarRef(ref a); // precisa da 'ref'erncia ref
            Console.WriteLine(a);
            // ref para definir o int precisa colocar da var

            //int b = 2;
            AlterarOut(out int b, out int c); //precisa da referncia out
            Console.WriteLine($"{b} {c}");
            // out para definir precisar ser dentro da comp

        }
    }
}
