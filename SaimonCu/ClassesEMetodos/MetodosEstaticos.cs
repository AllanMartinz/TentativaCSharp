using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.ClassesEMetodos
{
    public class CalculadoraEstatica
    {   // metodo estatico
        public static int Somar(int a, int b) { return a + b; } 
        //metodo instancia
        public int Multi(int a, int b) { return a * b; } 
    }
    
    class MetodosEstaticos
    {
        public static void Executar()
        {   // metodo estatico
            var resultado = CalculadoraEstatica.Somar(10, 45);
            Console.WriteLine(resultado);
            //metodo instancia
            var calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Multi(2, 2));
        }
    }
}
