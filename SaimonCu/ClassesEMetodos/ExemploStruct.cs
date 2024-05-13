using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.ClassesEMetodos
{// strucs conseguem usar interface
    interface Ponto // interface apenas cria a assinatura da funcao
    {
        void MoverNaDiagonal(int delta);// apenas e definido a funcao
        // private nao funciona em uma interface
    }
    struct Coordenada: Ponto // a Coordenada vai usar a funcao de ponto logo Coordenada: Ponto
                             //structs são tipos de dados definidos pelo usuário que agrupam variáveis relacionadas sob um único nome
    {
        public int X;
        public int Y;       //atributos

        public Coordenada(int x,int y)
        {
            X = x;
            Y = y;          //Construtor
        }
        public void MoverNaDiagonal(int delta)
        {
            X += delta;
            Y += delta;     //Metodos
        }

    }

    class ExemploStruct
    {
        public static void Executar()
        {
            Coordenada CoordenadaInicial;
            CoordenadaInicial.X = 2;
            CoordenadaInicial.Y = 2;
            Console.WriteLine("Coordenada Inicial: ");
            Console.WriteLine("X = {0} "+"\n"+"Y = {1}", CoordenadaInicial.X, CoordenadaInicial.Y);

            var CoodenadaFinal = new Coordenada(x: 20,y: 3);
            CoodenadaFinal.MoverNaDiagonal(70);
            Console.WriteLine("Coordenada Final: ");
            Console.WriteLine("X = {0} " + "\n" + "Y = {1}", CoodenadaFinal.X, CoodenadaFinal.Y);


        }
    }
}
