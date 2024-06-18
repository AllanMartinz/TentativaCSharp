using System;
using System.Collections.Generic;
using System.IO;

namespace SaimonCu.API
{
    class ExemploDirectoryInfo
    {
        public static void Executar()
        {
            var dirProjeto = @"~\source\repos\SaimonCu\ArquivosDoApi".ParseHome();
            var dirInfo = new DirectoryInfo(dirProjeto); // criar uma nova instacia de DirectoryInfo

            if (!dirInfo.Exists) // se n existir dirInfo criara uma nova Directory/pasta
            {
                dirInfo.Create();
            }

            Console.WriteLine("== Arquivos =================");
            var arquivos = dirInfo.GetFiles(); //pegar os arquivos da instacia dirInfo
            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo); 
            }
            Console.WriteLine("\n\n== Diretorios ================");
            var pastas = dirInfo.GetDirectories(); //pegar os pastas da instacia dirInfo
            foreach (var pasta in pastas) 
            {
                Console.WriteLine(pasta + "\n\n");
            }

            Console.WriteLine(dirInfo.CreationTime + "\n\n"); // tempo da criacao da instacia
            Console.WriteLine(dirInfo.FullName + "\n\n"); // nome da instacia
            Console.WriteLine(dirInfo.Root + "\n\n"); // raiz da instacia
            Console.WriteLine(dirInfo.Parent); // pasta pai desse diretorio
        }
    }
}
