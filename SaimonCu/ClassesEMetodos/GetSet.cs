using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SaimonCu.ClassesEMetodos
{
    public class Moto
    {
        private string Marca;
        private string Modelo;
        uint Cilindrada;


        public Moto(string marca, string modelo, uint cilindrada)
        {
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }

        public string GetMarca() { return Marca; }
        public void SetMarca(string marca) { Marca = marca; }
        public string GetModelo() { return Modelo; }
        public void SetModelo(string modelo) { Modelo = modelo; }
        public uint GetCilindrada() { return Cilindrada; }
        public void SetCilindrada(uint cilindrada)
        {
            // op1
            //Cilindrada = Math.Abs(cilindrada); } //Math.Abs vai impidir que haja numero negativo
            // deixando os numeros em absoluto todod positivos

            // op2
            Cilindrada = cilindrada; //usar uint
            //ao usar o uint vai ocorrer erro em numeros negativos

            // op 3
            //if (Cilindrada < 0)
            //{
            //    Cilindrada = cilindrada;
            //}
        }
    }
    class GetSet
    {

        public static void Executar()
        {
            var moto1 = new Moto("Kawazaki", "Ninja ZX-6R", 636);
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());



        }
    }
}

