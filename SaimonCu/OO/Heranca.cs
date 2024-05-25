using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SaimonCu.OO
{
//------|CLASSE-PAI|-------------------------------------------------------------------------------------------------------
    public class Carro //metodo Carro
    {   //sera usada o protected para a herança
        protected readonly int VelocidadeMaxima; //readonly - nao vai permitir nao mexa muito na velocidade
        int VelocidadeAtual; // ao ser colocada direto com var sera privada

        public Carro(int velocidadeMaxima) //sera criada velocidadeMaxima com o atributo de VelocidadeMaxima
        {
            VelocidadeMaxima = velocidadeMaxima;
        }
        protected int/*ou void*/ AlterarVelocidade(int delta) //nao ter acesso ao metodo que possa mexer na velocidade de forma mais flexivel 
        // Alter sera atribuida com delta         //se apenas classes que herdam de Carro | transmitido por heranca
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0) //manter vel constante sem ter negativa
            {
                VelocidadeAtual = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima) //tentou chegar a velocidade maxima mas nao passar
            {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else // velocidade constante
            {
                VelocidadeAtual = novaVelocidade;
            }
            return VelocidadeAtual; //caso nao seja void
                                    //voltar vel normal
        }
        public virtual int Acelerar() //virtual permite que o codigo seja sobre-escrito(override)
        {
            return AlterarVelocidade(5); // voltar ao AlterarVelocidade e a velocidade atribuida(novaVelocidade) sera de 5
        }
        public int Frear()
        {
            return AlterarVelocidade(-5); // voltar ao AlterarVelocidade e a velocidade atribuida(novaVelocidade) sera de -5 
                                          // perdera vel "frear" = 0
        }


    }
//-------------------------------------------------------------------------------------------------------------------------

//------|CLASSE-FILHA|-----------------------------------------------------------------------------------------------------
    //Uno herdara de Carro
    public class Uno : Carro // classe herda : de Carro | metodo Uno
    {
        public Uno() : base(200)
        { // ao nao ter um construtor basico é obridao definir
          // o contrutor : base espera receber VelocidadeMaxima | parametro 200 = int
          // se o contrutor for atribuida direto a "base" nao seria necessario atribuir a base no Uno

        }
    }
//-------------------------------------------------------------------------------------------------------------------------

//------|CLASSE-FILHA|-----------------------------------------------------------------------------------------------------
    public class Ferrari : Carro // metodo ferrari
    {
        public Ferrari() : base(350)
        {

        }
        public override int Acelerar() //sobre-escrevera o metodo Acelerar() |--! necesario vitual no metodo principal
                                       //a vel so vai ser alterada na Ferrari pois esse metodo se encontra  na ferrari
        {
            return AlterarVelocidade(15); // vel atribuida: 15
        }

        //!!ocultar o metodo da classe Pai
        public new int Frear() //uso do new nao precisa do virtual
        {
            return AlterarVelocidade(-15);
        }
    }
//-------------------------------------------------------------------------------------------------------------------------


    class Heranca
    {
        public static void Executar()
        {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();// tipo Uno id Uno
            Console.WriteLine(carro1.Acelerar());//5
            Console.WriteLine(carro1.Acelerar());//10
            Console.WriteLine(carro1.Frear());//5
            Console.WriteLine(carro1.Frear());//0
            Console.WriteLine(carro1.Frear());//0 por causa do if(novaVelocidade < 0) nao tera vel negativa
            Console.WriteLine(carro1.Acelerar());

            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari(); //tipo
            Console.WriteLine(carro2.Acelerar());//5
            Console.WriteLine(carro2.Acelerar());//10
            Console.WriteLine(carro2.Frear());//5
            Console.WriteLine(carro2.Frear());//0
            Console.WriteLine(carro2.Frear());//0
            //Console.WriteLine(carro2.AlterarVelocidade()); nao pode ser chamada por ta encapsulada(protected)
            Console.WriteLine(carro2.Acelerar());

            Console.WriteLine("ferrari com o tipo Carro...");
            Carro carro3 = new Ferrari(); //!!Tipo Carro --> chamar metodo Carro
            //Ferrari carro3 = new Ferrari(); //!!Tipo Ferrari --> chamar metodo Ferrari
            Console.WriteLine(carro3.Acelerar());//15--,--> !!metodo Carro mas Acelerar() esta override aplica oq vc estanciou na ferrari
            Console.WriteLine(carro3.Acelerar());//30__|
            Console.WriteLine(carro3.Frear());//25--,
            Console.WriteLine(carro3.Frear());//20  |--> !!esta sendo chamada o frear do metodo Carro nao de ferrari por isso 5
            Console.WriteLine(carro3.Frear());//15--'

            carro3 = new Uno(); // Polimorfismo mesma variavel assumindo multiplas formas
            Console.WriteLine("uno com o tipo Carro...");
            Console.WriteLine(carro3.Acelerar());//5
            Console.WriteLine(carro3.Acelerar());//10
            Console.WriteLine(carro3.Frear());//5
            Console.WriteLine(carro3.Frear());//0
            Console.WriteLine(carro3.Frear());//0
        }
    }
}
