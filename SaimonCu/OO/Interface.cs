using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.OO
{
    interface Saas
    {
        bool lele(string lolo);
    }
    interface OperacoeBinaria //os elemento de uma interface sao abstratos / logo nao pode abrir um corpo
    {
        int Operacao(int a, int b); //todos sao public por padrao
    }
    class Soma : OperacoeBinaria, Saas
    {
        public int Operacao(int a, int b) //um membro sempre sera public mesmo em herdado
        {
            return a + b;
        }
        public bool lele(string lolo)
        {
            return true; // tem entrada mas nao leva a nada, volta
        }
    }    
    class Subtrair : OperacoeBinaria // herdar
    {
        public int Operacao(int a, int b) //um membro sempre sera public mesmo em herdado
        {
            return a - b;
        }
    }    
    class Multiplicar : OperacoeBinaria
    {
        public int Operacao(int a, int b) //um membro sempre sera public mesmo em herdado
        {
            return a * b;
        }
    }    
    class Dividir : OperacoeBinaria
    {
        public int Operacao(int a, int b) //um membro sempre sera public mesmo em herdado
        {
            return a / b;
        }
    }
    class Calculadora { 
        List<OperacoeBinaria> operacoes = new List<OperacoeBinaria> // lista da OperacoeBinaria
        {
            new Soma(),
            new Subtrair(),
            new Dividir(),
            new Multiplicar(),
        };
    
        public string ExecutarOperacoes(int a, int b)
        {
            string resultado = ""; // criacoa de uma string que tenha ""

            foreach (var op in operacoes) // para cada item em opercao recebe op
            {
                resultado += $"Usando {op.GetType().Name} = {op.Operacao(a, b)}\n";
                // a string vai ser igual| adicionando $"Usando {pegara por nome as op} = {oprecao feito pela atribuicao de a e b}\n->pular linha"
            }
            return resultado; // voltar resultado
        } 
    }


    class Interface
    {

        public static void Executar()
        {
            var calc  = new Calculadora(); // nova calculador como calc
            var resultado =  calc.ExecutarOperacoes(80, 50);  // criacao de uma var que tenha as atribuicoes logo a = 80 e b = 50
            Console.WriteLine(resultado); // console escrever a var resultado
        }
    }
}
