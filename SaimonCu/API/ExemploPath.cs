using System;
using System.Collections.Generic;
using System.IO;

namespace SaimonCu.API
{
    class ExemploPath
    {
        public static void Executar()
        {
            //!-------criacao-dos-arquivos-------------------------
            var arquivo = @"~\source\repos\SaimonCu\ArquivosDoApi/exemplo_path_pasta/exemplo_path_arquivo.txt".ParseHome();
            var pasta = @"~\source\repos\SaimonCu\ArquivosDoApi/exemplo_path_pasta".ParseHome();

            if (!File.Exists(arquivo)) // ! = se
            {
                using (StreamWriter sw = File.CreateText(arquivo))  // precisa direcionar onde vai ser escrito
                {
                    sw.WriteLine("Um novo arquivo criado!");
                }
            }

            if(!Directory.Exists(pasta)) // se a diretory existir 
            {
                Directory.CreateDirectory(pasta); //criar pasta
            }


            //!------------usado-o-path-para-info--------------------
            Console.WriteLine("==Arquivo=====================");
            Console.WriteLine(Path.GetExtension(arquivo)); //Path usado para tirar as info
            Console.WriteLine(Path.GetFileName(arquivo));
            Console.WriteLine(Path.GetFileNameWithoutExtension(arquivo));
            Console.WriteLine(Path.GetDirectoryName(arquivo));
            Console.WriteLine(Path.HasExtension(arquivo));

            Console.WriteLine("==Pasta=======================");
            Console.WriteLine(Path.HasExtension(pasta));
            Console.WriteLine(Path.GetFullPath(pasta));
            Console.WriteLine(Path.GetPathRoot(pasta));

        }
    }
}
