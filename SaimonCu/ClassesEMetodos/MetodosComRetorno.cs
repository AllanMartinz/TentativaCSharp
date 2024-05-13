using SaimonCu.ClassesEMetodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.ClassesEMetodos
{
    class CalculadoraComun
    {

        public int Somar(int a, int b) { return a + b; }
        public int Subtrair(int a, int b) { return a - b; }
        public int Multiplicar(int a, int b) { return a * b; }
        public int Dividir(int a, int b) { return a / b; }

    }
    class CalculadoraCadeia
    {
        int memoria;
        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this;
        }
        public CalculadoraCadeia Subtrair(int a)
        {
            memoria -= a;
            return this;
        }
        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }
        public CalculadoraCadeia Dividir(int a)
        {
            memoria /= a;
            return this;
        }
        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }
        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }
        public int Resultado()
        {
            return memoria;
        }
    }


}


class MetodosComRetorno
{
    public static void Executar()
    {
        var CalculadoraComum = new CalculadoraComun();
        var Resultado = CalculadoraComum.Somar(5, 5);

        Console.WriteLine(Resultado);
        Console.WriteLine(CalculadoraComum.Subtrair(7, 4));
        Console.WriteLine(CalculadoraComum.Multiplicar(4, 4));

        var CalculadoraCadeia = new CalculadoraCadeia();
        CalculadoraCadeia.Somar(3).Multiplicar(5).Subtrair(7).Imprimir().Limpar().Imprimir();
    }
}


// a asinatura do metodo tem que ser unico na class pode ter o mesmo tipo mas se tiver entrada igual vai dar erro 
// o comportamento do obj vai depender do metodo
/* exemplo
    class CalculadoraComun
    {

        public int Somar(int a, double b) { return a + b; } --> comp.1

        public int Somar(int c, int d) { return c + d; } --> comp.2
    }
}
     class MetodosComRetorno        ex1            |      class MetodosComRetorno                 ex2    
     {                                             |      {                                              
         public static void Executar()             |          public static void Executar()               
         {                                         |          {                                           
             CalculadoraComun.Somar(1, 2.0);       |              CalculadoraComun.Somar(1, 2);           
         }                                         |          }                                          
      -->obj tera o comp.1                         |      --> obj tera o comp.2
*/