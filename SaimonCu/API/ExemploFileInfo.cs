using System;
using System.Collections.Generic;
using System.IO;

namespace SaimonCu.API
{ // ! uso da extensao ParseHome() de PrimeiroArquivo 
    class ExemploFileInfo
    {
        public static void ExcluirSeExistir (params string[] caminhos) // com o excluir nao ira acontecer o erro do CopyTo
        {
            foreach(var caminho in caminhos)
            {
                FileInfo arquivo = new FileInfo(caminho);  
                if (arquivo.Exists)
                {
                    arquivo.Delete();
                }
            }
        }
        public static void Executar()
        {
            var caminhoOrigem = @"~\source\repos\SaimonCu\ArquivosDoApi/arq_origem.txt".ParseHome();
            var caminhoDestino = @"~\source\repos\SaimonCu\ArquivosDoApi/arq_destino.txt".ParseHome();
            var caminhoCopia = @"~\source\repos\SaimonCu\ArquivosDoApi/arq_copia.txt".ParseHome();

            ExcluirSeExistir(caminhoOrigem, caminhoDestino, caminhoCopia); // excluir se o arquivo existir

            using (StreamWriter sw = File.CreateText(caminhoOrigem))
            {
                sw.WriteLine("Arquivo Original!");
            }

            FileInfo origem = new FileInfo(caminhoOrigem);
            Console.WriteLine(origem.Name); // nome do arquivo
            Console.WriteLine(origem.IsReadOnly); // ele apenas leitura uso do bool
            Console.WriteLine(origem.FullName); // nome inteiro
            Console.WriteLine(origem.Extension); // que tipo de arquivo é

            origem.CopyTo(caminhoCopia); // copiou o origem 
            origem.MoveTo(caminhoDestino); // moveu o origem para destino
        }
    }

}

