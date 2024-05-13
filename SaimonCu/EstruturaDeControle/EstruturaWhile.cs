using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.EstruturaDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int chute = 0;
            Random numAl= new Random(); //gera um numero aleatorio

            int numDado = numAl.Next(1, 6); //vai gerar um num aleatorio de 1 a 6
            bool numEnc = false;
            int tentaRes = 6;
            int tentaAtu = 0;

            var ler = Console.ForegroundColor;
            var corAnt = Console.BackgroundColor;

            while (tentaRes > 0 && !numEnc) //while vai ficar tenatndo repetir o codigo ate que ele seja parado
            {
                Console.WriteLine(" Em qual numero o dado vai cair? ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out chute);

                tentaAtu++; //acrementada as tentativas
                tentaRes--; //decrementada as tentativas


                if (numDado == chute)
                {
                    
                    numEnc = true;
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("PARABENS!!! VC ACERTOU!!! teve {0} tentativas", tentaAtu);
                    Console.BackgroundColor = corAnt;
                    Console.ForegroundColor = ler;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("Nao foi esse numero! tente novamente! Tentativas Restantes: {0}", tentaRes);
                    Console.BackgroundColor = corAnt;
                    Console.ForegroundColor = ler;
                }
            }
        }
    }
}
