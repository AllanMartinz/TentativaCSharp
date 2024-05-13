using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.EstruturaDeControle
{
    class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.Write("qual a nota de 1 a 5: ");
            int.TryParse(Console.ReadLine(), out var nota);
            switch (nota) // switch = selecao multipla
            {
                case 0: //case = caso
                    Console.WriteLine("pessimo");
                    break; //quebra o switch e vai para a proxima linha
                case 1:
                case 2:
                    Console.WriteLine("ruim");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("boa");
                    break;
                case 5:
                    Console.WriteLine("exelente");
                    break;
                default:
                    Console.WriteLine("era de 1 a 5!!! ANIMAL!!!!"); //default =se a pessoa nao escolheu os num anteriores
                    break;
            }
            Console.WriteLine("nerd!!!");
        }
    }
}
