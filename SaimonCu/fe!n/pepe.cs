using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SaimonCu.fe_n;
class pepe
{
    public static void Executar()
    {
        //Console.Write("Primeiro Numero: ");
        //int.TryParse(Console.ReadLine(), out int x);
        //Console.Write("Segundo Numero: ");
        //int.TryParse(Console.ReadLine(), out int y);
        //if (x > y)
        //{
        //    Console.WriteLine("Resposta Verdadeira!");
        //} else
        //{
        //    Console.WriteLine("Resposta Falsa!");
        //}


        //bool a = true;
        //bool b = false;

        //Console.WriteLine(!a);
        //Console.WriteLine(!b);

        Console.Write("digite a nota da 1° materia: ");
        int.TryParse(Console.ReadLine(), out int m1);
        Console.Write("digite a nota da 2° materia: ");
        int.TryParse(Console.ReadLine(), out int m2);
        Console.Write("digite a nota da 3° materia: ");
        int.TryParse(Console.ReadLine(), out int m3);
        if (m1 >= 7 || m2 >= 7 || m3 >= 7)
        {
            Console.WriteLine("O aluno esta aprovado de ano!");
        }
        else
        {
            Console.WriteLine("O aluno nao passou!");
        }

    }
}
