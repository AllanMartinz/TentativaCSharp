using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.ClassesEMetodos
{
    public struct SPonto 
    { 
        public int X; 
        public int Y; 
    }

    public class CPonto 
    {
        public int X; 
        public int Y; 
    }

    class StructVsClass
    {
        public static void Executar()
        {
                //ATRIBUICAO POR VALOR
            SPonto Ponto1 = new SPonto { X = 1, Y = 3 }; // para atribuir valor em um new pode se usar {...}
            SPonto CopiaPonto1 = Ponto1; // USAR A FUNCAO NO INICIO PARA ATRIBUIR SEU BURRO!!!
            Ponto1.X = 3;
            Console.WriteLine("ponto 1 X:{0}", Ponto1.X); //NAO SO PEGAR A VAR PEGAR A VAR E ATRIBICAO DELA SEU BURRO!!!
            Console.WriteLine("Copia Ponto 1 X:{0}", CopiaPonto1.X ); //por valor o ponto.x recebe dois valores diff entao cada ponto tem se valor

                //ATRIBUICAO POR REFERENCIA 
            CPonto Ponto2 = new CPonto { X = 2, Y = 3 };
            CPonto CopiaPonto2 = Ponto2;
            Ponto2.X = 4;
            Console.WriteLine("ponto 2 X:{0}", Ponto2.X);
            Console.WriteLine("Copia Ponto 2 X:{0}", CopiaPonto2.X); //por ref o ponto.x recebe um valor fixo se e 4 entao e 4 nao importa
        }
    }
}
