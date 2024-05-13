using System;
using System.Globalization; //para funcionar a CultureInfo precisa da using System.Globalization;

namespace SaimonCu.Fundamentos
{
    class FormatandoNum
    {
        public static void Executar()
        {
            double sas = 123.456;
            Console.WriteLine(sas.ToString("F1"));//o ponto(.) depois de uma var vai formatar ele ou mudar do jeito que ela se comporta
            //ToString("F1") vai converter o numero do sas para ter uma so casa decimal / e ToString muda o valor numerico(double) para uma string
            Console.WriteLine(sas.ToString("C"));//("C") transforma em moeda
            Console.WriteLine(sas.ToString("P"));//("P") percentual
            Console.WriteLine(sas.ToString("#.##"));//("#.##...") quntas casas decimais querer

            CultureInfo cult = new CultureInfo("en-US"); //CultureInfo formatação especifica para a cultura que foi definida
            Console.WriteLine(sas.ToString("C0", cult));

            int num = 101;
            Console.WriteLine(num.ToString("D50"));//("D...") adiciona numero de 0 a esq
        }
    }
}
