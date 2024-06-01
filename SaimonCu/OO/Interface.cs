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
            return true;
        }
    }    
    class Subtrair : OperacoeBinaria
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
        List<OperacoeBinaria> operacoes = new List<OperacoeBinaria>
        {
            new Soma(),
            new Subtrair(),
            new Dividir(),
            new Multiplicar(),
        };
    
        public string ExecutarOperacoes(int a, int b)
        {
            string resultado = "";

            foreach (var op in operacoes)
            {
                resultado += $"Usando {op.GetType().Name} = {op.Operacao(a, b)}\n";
            }
            return resultado;
        } 
    }


    class Interface
    {

        public static void Executar()
        {
            var calc  = new Calculadora();
            var resultado = calc.ExecutarOperacoes(50, 50);
        }
    }
}
