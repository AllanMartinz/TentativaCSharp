using SaimonCu.fe_n;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.fe_n
{

    class Umbers
    {

        public Umbers() { }
        public int Add(int a, int b) { return a + b; }
        public int Sub(int a, int b) { return a - b; }
        public int Mult(int a, int b) { return a * b; }
        public int Div(int a, int b) { return a / b; }
    }
    
    class malt
    {
        public static void Executar()
        {

            var Calculador = new Umbers();
            var Resultado = Calculador;
            
            Console.WriteLine("Selecione a operação.");
            Console.WriteLine("1.Adicionar");
            Console.WriteLine("2.Subitrair");
            Console.WriteLine("3.Multiplicar");
            Console.WriteLine("4.Divide");
            Console.Write("escolha(1/2/3/4): ");
            int.TryParse(Console.ReadLine(), out int resultado);
            Console.Write("Primeiro Numero: ");
            int.TryParse(Console.ReadLine(), out int a);
            Console.Write("Segundo Numero: ");
            int.TryParse(Console.ReadLine(), out int b);
        //switch 
        //{
        //    case 1: Console.WriteLine(Calculador.Add(a, b)); break;
        //    case 2: Console.WriteLine(Calculador.Sub(a, b)); break;
        //    case 3: Console.WriteLine(Calculador.Mult(a, b)); break;
        //    case 4: Console.WriteLine(Calculador.Div(a, b)); break;

        //}

        if (resultado == 1) { Console.WriteLine(Calculador.Add(a, b)); }
        else if (resultado == 2) { Console.WriteLine(Calculador.Sub(a, b)); }
        else if (resultado == 3) { Console.WriteLine(Calculador.Mult(a, b)); }
        else if (resultado == 4) { Console.WriteLine(Calculador.Div(a, b)); }
            

            /*
                string entrada;

                Console.WriteLine("Selecione a operação.");
                Console.WriteLine("1.Adicionar");
                Console.WriteLine("2.Subitrair");
                Console.WriteLine("3.Multiplicar");
                Console.WriteLine("4.Divide");
                Console.Write("escolha(1/2/3/4): ");
                entrada = Console.ReadLine();
                int.TryParse(entrada, out int res);
                Console.Write("Primeiro Numero: ");
                entrada = Console.ReadLine();
                int.TryParse(entrada, out int numP);
                Console.Write("Segundo Numero: ");
                entrada = Console.ReadLine();
                int.TryParse(entrada, out int numS);

                int add = numP + numS;
                int mult = numP * numS;
                int div = numP / numS;
                int sub = numP - numS;

                switch (res)
                {
                    case 1:
                        Console.WriteLine(add);
                        break;
                    case 2:
                        Console.WriteLine(sub);
                        break; 
                    case 3:
                        Console.WriteLine(mult);
                        break;
                    case 4:
                        Console.WriteLine(div);
                        break;

            */
        }
           // Console.WriteLine($"O resultado foi: {res} (sim/nao)");

        }
    }   


