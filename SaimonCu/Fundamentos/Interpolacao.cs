using System;
using System.Collections.Generic;


namespace SaimonCu.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Placa de video";
            var marca = "RTX 4060";
            double preco = 1859.99;
            Console.WriteLine("A " + nome + " " + marca + " " + "custa em torno de " + preco + "."); // O nerd
            Console.WriteLine("A {0} {1} custa em torno de {2}.", nome/*0*/, marca/*1*/, preco/*2*/); // O esquizito
            //na interpolaçao subistitui os {numero} pelas var que vem em seguida com forme a ordem
            Console.WriteLine($"A {nome} {marca} custa em torno de {preco}."); //O fodão
            //usar $ no inicio para que possa usar as var dentro das strings / usar sempre os {...}
            Console.WriteLine($"2 x 2 = {2 * 2}");
        }
    }
}
