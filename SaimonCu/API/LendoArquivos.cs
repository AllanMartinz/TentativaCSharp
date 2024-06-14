using System;
using System.Collections.Generic;
using System.IO;

namespace SaimonCu.API
{ // ! uso da extensao ParseHome() de PrimeiroArquivo 
    class LendoArquivos
    {
        public static void Executar()
        {
            var path = @"~\source\repos\SaimonCu\ArquivosDoApi/lendo_arquivo.txt".ParseHome();// criacao do arquivo


            if (!File.Exists(path)) // se nao existir cria o arquivo
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Prduto;Preco;Qtde");
                    sw.WriteLine("Caneta Bic Preta;3.59;89");
                    sw.WriteLine("Borracha;2.89;27");

                }
            }

            try
            {
                using (StreamReader sr = new StreamReader(path)) // se o arquivo existir pula o if e le o que tem no arquivo para o cmd
                {
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
