using SaimonCu.Colecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SaimonCu.Colecoes
{
    class Array
    {
        public static void Executar()
        {
            // nao da para misturar mais de um tipo de var em uma array | array é um tipo static se for "5" vai ser 5 e pronto
            string[] alunos = new string[5];  // array pode fazer com que um unico identificador vai armazenar "5" valores 
            alunos[0] = "saimon";
            alunos[1] = "banjo";
            alunos[2] = "insomnia";
            alunos[3] = "allan";
            alunos[4] = "shaco";
            foreach (string aluno in alunos)
            {
                Console.WriteLine(aluno);
            };
            double somatoria = 0;
            double[] notas = { 3.3, 9, 0.8, 8.7, 6.0 };
            foreach (double nota in notas)
            {
                somatoria += nota;
            }
            double media = somatoria / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'a', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(letras);


        }
    }
}
