using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //area da circunferencia
            double raio = 4.5; //double = valor real que aceita qualque numero decimal
            const double PI = 3.14; //  const são campos cujos valores são definidos em tempo de compilação e nunca podem ser alterados
            double area = PI * raio * raio;
            Console.WriteLine("Area é igual á " + area + "\n");
            Console.WriteLine(String.Concat(
                Enumerable.Repeat("-", +100)));
            //tipos internos

            bool estaChovendo = true; // bool é uma variaver que mexe com verdadeiro ou falso
            Console.WriteLine("estar a chover ???");
            Console.WriteLine("é " + estaChovendo + "\n");
            Console.WriteLine(String.Concat(
                Enumerable.Repeat("-", +100)));
            byte idade = byte.MaxValue; //byte numeros reais de 0 a 255
            Console.WriteLine(idade);
            Console.WriteLine();
            Console.WriteLine(String.Concat(
                Enumerable.Repeat("-", +100)));
            sbyte numGols =sbyte.MinValue; /*sbyte numeros inteiros de -128 a 127
                                            *MinValue = valor minimo
                                            *MaxValue = valor maximo
                                            */

            Console.WriteLine(numGols + "\n");

            Console.WriteLine(String.Concat(
                Enumerable.Repeat("-", + 100)));

            int IntMin = int.MinValue;
            int IntMax = int.MaxValue; // int numes inteiros de -2.147.483.648 a 2.147.483.647

            Console.Write("O numero ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("maximo");
            Console.ResetColor();
            Console.Write(" da var int é de: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(IntMax);
            Console.ResetColor();
            Console.Write("O numero ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("minimo");
            Console.ResetColor();
            Console.Write(" da var int é de: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(IntMin + "\n");
            Console.ResetColor();
            Console.WriteLine(String.Concat(
                Enumerable.Repeat("-", +100)));
            uint UintMax = uint.MaxValue;
            uint UintMin = uint.MinValue;
            Console.WriteLine(UintMax);
            Console.WriteLine(UintMin + "\n");
            Console.WriteLine(String.Concat(
                Enumerable.Repeat("-", +100)));
            short ShortMin = short.MinValue;
            short ShortMax = short.MaxValue;
            Console.WriteLine("O numero maximo da var short é de: " + ShortMax);
            Console.WriteLine("E o numero mininmo da var short é de: " + ShortMin + "\n");
            Console.WriteLine(String.Concat(
                Enumerable.Repeat("-", +100)));
            ushort UshortMax = ushort.MaxValue;
            ushort UshortMin = ushort.MinValue;
            Console.WriteLine(UshortMax);
            Console.WriteLine(UshortMin + "\n");


            float preco = 199.99f; //float é atribuida a numeros reais decimal as de virgula ex: 899.99
            Console.WriteLine("o preco desse produto é de: " + preco + "\n");
            double muitoCaro = 10000000000.50;//mais usado
            Console.WriteLine("esse produto é muito caro:  " + muitoCaro + "\n");
            // float e double nunca ficam juntos usar "f" no final do numero
            decimal distanciaLong = decimal.MaxValue;
            Console.WriteLine("muito longe: " + distanciaLong + " Km" + "\n");
            char letra = 's';
            Console.WriteLine("letra " + letra +"\n");
            //char e delimitada por 1 letra = ''
            string palavra = "See You Again";
            Console.WriteLine(palavra + " musica boa");
            //string é um conjunto de letras = ""
        }
    }
}
