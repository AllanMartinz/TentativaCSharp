using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.MetodosEFuncoes
{
    public static class ExtensaoInteiro
    {
        public static int Soma(this/*Instacia atual*/ int num, int outroNum)
        {
            return num + outroNum;
        }

        public static int Dividir(this/*!usa o item definido(deff)*/ int num, int outroNum)
        {
            return num / outroNum; 
        }
    }

    class MetodosExtensao
    {
        public static void Executar()
        {
            int numero = 5; //deff
            int otro = 5; //deff

            Console.WriteLine(numero.Soma(3)); //8
            Console.WriteLine(otro.Dividir(10)); //0

            Console.WriteLine(2/*deff*/.Soma(3)); //5
            Console.WriteLine(4/*deff*/.Dividir(2)); //2
        }
    }
}
