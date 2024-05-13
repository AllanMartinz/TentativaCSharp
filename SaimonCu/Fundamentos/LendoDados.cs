using System;
using System.Globalization;

namespace SaimonCu.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("what´s your name? ");
            string name = Console.ReadLine();

            Console.Write("your age? ") ;
            int age = int.Parse(Console.ReadLine());//parse permite que uma var diferente uma da outra possa ser lida 
            //nesse caso transforma a var string Console.ReadLine() em int / "1" -> 1

            Console.Write("salario? ");
            double mon = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write($"{name} {age} anos e recebe R$:{mon}!!");

        }
    }
}
