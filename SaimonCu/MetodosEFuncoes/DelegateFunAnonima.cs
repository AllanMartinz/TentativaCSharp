using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.MetodosEFuncoes
{

    class DelegateFunAnonima
    {
        delegate string StringOperacao(string str); // delegate retorna uma string e recebe string

        public static void Executar()
        {
            StringOperacao inverter = delegate (string str) // criacao de uma variavel tipo StringOperacao
            { // variavel cujo nome inverter atribuido com delegate associado funcao anonima
                char[] charArray = str.ToCharArray(); //coverteu o Array em uma cadeia de caracteres
                Array.Reverse(charArray); //  inverte os caracteres
                return new string(charArray); // retornar a uma nova string
            };

            Console.WriteLine(inverter("pelvis!")); // "!sivlep"
        }

    }
}
