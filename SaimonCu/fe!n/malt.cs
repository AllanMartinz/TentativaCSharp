using SaimonCu.fe_n;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.fe_n
{
    //public int add(int a, int b) { return a + b; }
    //public int Sub(int a, int b) { return a - b; }
    //public int Mult(int a, int b) { return a * b; }
    //public int Div(int a, int b) { return a / b; }
    public class Umbers
    {
        protected int A { get; set; }
        protected int B { get; set; }
        protected Umbers(int a, int b)
        {
            A = a;
            B = b;
        } 
        internal Umbers() { }
    }

    public class Add  : Umbers{
        public int adic(int a, int b) { return a + b; }
        
    }
    public class Sub  : Umbers{
        public int subt(int a, int b) { return a - b; }
    }
    public class Mult : Umbers{
        public int multi(int a, int b) { return a * b; }
    }
    public class Div  : Umbers{
        public int divi(int a, int b) { return a / b; }
    }

    class malt
    {
        public static void Executar()
        {
            Add adicionar = new Add();
            Sub subtrair = new Sub(); 
            Mult multiplicar = new Mult();
            Div dividir = new Div();

            Console.WriteLine("Selecione a operação.");
            Console.WriteLine("1.Adicionar");
            Console.WriteLine("2.Subitrair");
            Console.WriteLine("3.Multiplicar");
            Console.WriteLine("4.Divide");
            Console.Write("escolha(1/2/3/4): ");
            int.TryParse(Console.ReadLine(), out int pica);
            Console.Write("Primeiro Numero: ");
            int.TryParse(Console.ReadLine(), out int a);
            Console.Write("Segundo Numero: ");
            int.TryParse(Console.ReadLine(), out int b);

            //switch (pica)
            //{
            //    case 1:
            //        Console.WriteLine(adicionar.adic(a, b));
            //        break;
            //    case 2:
            //        Console.WriteLine(subtrair.subt(a, b));
            //        break;
            //    case 3:
            //        Console.WriteLine(multiplicar.multi(a, b));
            //        break;
            //    case 4:
            //        Console.WriteLine(dividir.divi(a, b));
            //        break;
            //}

            if (pica == 1) { Console.WriteLine(adicionar.adic(a, b)); }
            else if (pica == 2) { Console.WriteLine(subtrair.subt(a, b)); }
            else if (pica == 3) { Console.WriteLine(multiplicar.multi(a, b)); }
            else if (pica == 4) { Console.WriteLine(dividir.divi(a, b)); }


///---------------------------------BURRO!---------------------------------
            //       var opera = new Dictionary<int, >();
            //       opera.Add(1, "1.Adicionar");
            //       opera.Add(2, "2.Subtrair");
            //       opera.Add(3, "3.Multiplicar");
            //       opera.Add(4, "4.Dividir");
            //foreach (var operadores in opera)
            //{
            //    Console.WriteLine(operadores.Value);
            //}
            //Console.Write("escolha(1/2/3/4): ");
            //int.TryParse(Console.ReadLine(), out int pica);
            //Console.Write("Primeiro Numero: ");
            //int.TryParse(Console.ReadLine(), out int a);
            //Console.Write("Segundo Numero: ");
            //int.TryParse(Console.ReadLine(), out int b);

            //if (pica == 1) { Console.WriteLine(opera.Add(a, b)); }
            //else if (operadores == 2) { Console.WriteLine(Calculador.Sub(a, b)); }
            //else if (operadores == 3) { Console.WriteLine(Calculador.Mult(a, b)); }
            //else if (operadores == 4) { Console.WriteLine(Calculador.Div(a, b)); }

            //switch
            //var umbers = new Umbers();
            //switch (opera)
            //{
            //    case 1:
            //        Console.WriteLine(umbers.add);
            //        break
            //}

            //            //var Calculador = new Umbers();

            //            //string[] Opera = new string[4];
            //            //Opera[0] = "1.Adicionar";
            //            //Opera[1] = "2.Subitrair";
            //            //Opera[2] = "3.Multiplicar";
            //            //Opera[3] = "4.Divide";
            //            //foreach (string opera in Opera)  
            //            //{
            //            //    Console.WriteLine(opera);
            //            //}



            //            //Console.WriteLine("Selecione a operação.");
            //            //Console.WriteLine("1.Adicionar");
            //            //Console.WriteLine("2.Subitrair");
            //            //Console.WriteLine("3.Multiplicar");
            //            //Console.WriteLine("4.Divide");
            //            Console.Write("escolha(1/2/3/4): ");
            //            int.TryParse(Console.ReadLine(), out int operadores);
            //            Console.Write("Primeiro Numero: ");
            //            int.TryParse(Console.ReadLine(), out int a);
            //            Console.Write("Segundo Numero: ");
            //            int.TryParse(Console.ReadLine(), out int b);
            //            //switch 
            //            //{
            //            //    case 1: Console.WriteLine(Calculador.Add(a, b)); break;
            //            //    case 2: Console.WriteLine(Calculador.Sub(a, b)); break;
            //            //    case 3: Console.WriteLine(Calculador.Mult(a, b)); break;
            //            //    case 4: Console.WriteLine(Calculador.Div(a, b)); break;

            //            //}

            //            //if (operadores == 1) { Console.WriteLine(Calculador.Add(a, b)); }
            //            //else if (operadores == 2) { Console.WriteLine(Calculador.Sub(a, b)); }
            //            //else if (operadores == 3) { Console.WriteLine(Calculador.Mult(a, b)); }
            //            //else if (operadores == 4) { Console.WriteLine(Calculador.Div(a, b)); }


            //            /*
            //                string entrada;

            //                Console.WriteLine("Selecione a operação.");
            //                Console.WriteLine("1.Adicionar");
            //                Console.WriteLine("2.Subitrair");
            //                Console.WriteLine("3.Multiplicar");
            //                Console.WriteLine("4.Divide");
            //                Console.Write("escolha(1/2/3/4): ");
            //                entrada = Console.ReadLine();
            //                int.TryParse(entrada, out int res);
            //                Console.Write("Primeiro Numero: ");
            //                entrada = Console.ReadLine();
            //                int.TryParse(entrada, out int numP);
            //                Console.Write("Segundo Numero: ");
            //                entrada = Console.ReadLine();
            //                int.TryParse(entrada, out int numS);

            //                int add = numP + numS;
            //                int mult = numP * numS;
            //                int div = numP / numS;
            //                int sub = numP - numS;

            //                switch (res)
            //                {
            //                    case 1:
            //                        Console.WriteLine(add);
            //                        break;
            //                    case 2:
            //                        Console.WriteLine(sub);
            //                        break; 
            //                    case 3:
            //                        Console.WriteLine(mult);
            //                        break;
            //                    case 4:
            //                        Console.WriteLine(div);
            //                        break;

            //            */
        }
        //        // Console.WriteLine($"O resultado foi: {res} (sim/nao)");

    }
}




