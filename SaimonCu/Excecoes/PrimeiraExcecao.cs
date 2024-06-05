using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.Excecoes
{
    public class Conta
    {
        double Saldo;

        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                throw/*Jogar*/ new ArgumentException/*Exceção de argumento*/("Saldo Insuficiente"); // !ArgumentException é um dos tipos de Exception que existem
                //normie: se o valor for maior que o saldo aparecera a mensagem "Saldo Insuficiente"
                //nerd: se o valor for maior que o saldo jogara(throw) uma nova mensagem de erro(ArgumentException) que o "Saldo Insuficiente"
            }

            Saldo -= valor; // se nao vai subtrair o valor do saldo
        }
    }

    class PrimeiraExcecao
    {
        public static void Executar()
        {
            var conta = new Conta(1_444.44);
            // o metodo sacar pode dar um erro | por isso usar o try

            try //tente fazer isso | caso der erro chame a catch
            {
                conta.Sacar(1600);
                Console.WriteLine("Retirada com Sucesso!!!");
            } catch/*catch precisa do try e vise versa*/ (Exception ex/*nome da excecao*/) //no parametro precisa da Excecao | nesse caso a excecao esta em Sacar() como ArgumentException
            {
                Console.WriteLine(ex.Message); //aparecera a mensagem da Exception "Saldo Insuficiente"
            } finally // executado em qualquer situacao, se der erro ou nao
            {
                Console.WriteLine("Obrigado!");
            } // finally = opcional | sem ele ira executar o codigo sem o Console.WriteLine("Obrigado!");
        }
    }
}

