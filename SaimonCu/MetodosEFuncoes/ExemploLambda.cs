using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        { // a funcao esta sendo armazenda na variavel algoNoConsole que é um tipo Action
            Action<string> algoNoConsole = (a)/*parametro*/ =>/*arrow => depois do parametor terei a funcao [+/- isso]*/
            { // depois do = de Action sera a funcao
                Console.WriteLine("Lambda com C#!" + a); //lambda = funcao anonima
            };
            //Action é um void nao tem retorno, quase tem um "Action" que nao é void é func
            algoNoConsole("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1"); //volta como uma funcao normal

            Func<int>/*ira retornar como um valor inteiro | <Generics>*/ jogarDado = () =>
            {
                Random random = new Random(); // int random
                return random.Next(1, 7); // 1 a 6
            };
            Console.WriteLine(jogarDado());

            Func<int, string> conversorHex = numero/*tem apenas um parametro*/ => numero.ToString("X"); //e esta explicito a funcao
            //qunado esta muito explicito nao precisa de (Parametro) {Funcao} ao ser colocada as chaves devera colocar return
            Console.WriteLine(conversorHex(1234)); // valor decimal para hexadecimal

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
                String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano); //o tipo final é no qual ela vai retornar 
            // o return seria string
            Console.WriteLine(formatarData(15,12,2005));
        }
    }
}
