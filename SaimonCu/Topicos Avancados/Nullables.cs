using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.Topicos_Avancados
{
    class Nullables
    {
        public static void Executar()
        {
            Nullable<int> num1 = null; // criacao de um numero que recebe valor null
            int? num = null;  // "esse tipo aceita null?"
            //int num3 = null; // é um int nao um bool

            if (num1.HasValue) // se num1 tiver um valor
            {
                Console.WriteLine("Valor de num: {0}", num1); // escreve "Valor de num: "
            } else
            {
                Console.WriteLine("A variavel nao possui valor"); // entretanto escreva "A variavel nao possui valor"
            }

            //int valor = num1; e esse int nao é um Nullable por isso nao aceita bool
            int valor = num1 ?? 1000; // se esse valor for null pega o valor padrao 1000 | se nao for null vai setar o valor da funcao
            Console.WriteLine(valor); //1000

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault(); // retorna ao valor | se nao tiver volta false
            Console.WriteLine(resultado); // false | valor padra de um bool e false

            //try
            //{
            //    int x = num1.Value;
            //    int y = num2.Value; ERRO POR NAO TER VALOR
            //    Console.WriteLine(x + y);
            //} catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


        }
    }
}
