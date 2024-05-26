using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.OO
{
    //->Pai
    public class Animal
    {
        public string Nome { get; set; } //usado get;set apenas para ter uma propriedade | string
     
        public Animal (string nome)//nome do animal
        {
            Nome = nome;
        }
    }

    //-filhas
    public class Cachorro : Animal //Cachorro herda de Animal
    {
        public double Altura { get; set; } // double
        //-->primeiro contrutor
        public Cachorro(string nome) : base(nome) //herdado nome animal | por o nome nao estar devera usar base do pai
        {
            Console.WriteLine($"Cachorro {nome} inicializado"); //mostrar que o cachorro foi instancia
        }
        //--segundo construtor
        public Cachorro(string nome, double altura) : this(nome) //this usa construtor que se encontra a base (nome) 
        {
            Altura = altura; 
        }

        public override string ToString() //converte um obj/instancia a uma string
        {
            return $"{Nome} tem {Altura}cm de altura!"; //retornar oq representa o cachorro
            //quando usar o cachorro dentro de um contexto necessario uma string ele vai chamar o metodo e converte a string
        }
    }
    class ConstrutorThis
    {
        public static void Executar()
        {

            var spike = new Cachorro("Spike"); //ToString --> {Nome} = "Spike" | {Altura} = 0 nao foi definido
            var max = new Cachorro("Max", 40.0); //ToString --> {Nome} = "Max" | {Altura} = 40.0
            Console.WriteLine(spike);//"Spike tem 0cm de altura!"
            Console.WriteLine(max);  //"Max tem 40.0cm de altura!"
        }
    }
}
