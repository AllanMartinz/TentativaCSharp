using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.EstruturaDeControle
{
    class EstruturaFor
    {
        public static void Executar()
        { //em vez de usar o while/ do while em itens que repetem em quantidade determinada use o for
            //for tambem evita laço infinito
            //for (int i = 1; i <= 10; i++) 
            //{
            //    Console.WriteLine($"O numero de 1 é {i}");
            //}
            double somatoria = 0;
            string entrada;

            Console.Write("informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for(int i = 1;i <= tamanhoTurma; i++)
            {
                Console.Write("informe a nota do aluno {0}: ", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatoria += notaAtual;
            }
            double media = tamanhoTurma > 0 ? somatoria / tamanhoTurma : 0;
            Console.WriteLine($"media da turma: {media}");
        }
    }
}
