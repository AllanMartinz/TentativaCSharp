using SaimonCu.ClassesEMetodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.ClassesEMetodos
{

    public class CarroOpicional
    {
        double desconto = 0.1;
        string nome;

        public string Nome
        {
            get
            {
                return "Opicinal" + nome;
            }
            set
            {
                nome = value;
            }
        }

        public double Preco { get; set; }

        public double PrecoComDesconto
        {
            get => Preco + (desconto * Preco);
        }

        public CarroOpicional(string nome, double preco) { this.nome = nome; Preco = preco; }
    }



    class Props
    {
        public static void Executar()
        {
            var op1 = new CarroOpicional("Ar condicionado", 3499.00);
            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);
            Console.WriteLine(op1.PrecoComDesconto);
            var op2 = new CarroOpicional("Direção Eletrica", 2299.99 );
            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine(op2.PrecoComDesconto.ToString("####.##"));
        }
    }
}

