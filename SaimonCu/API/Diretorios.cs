using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace SaimonCu.API
{ // ! uso da extensao ParseHome() de PrimeiroArquivo
    class Diretorios
    {
        public static void Executar()
        {
            var novoDir = @"~\source\repos\SaimonCu\ArquivosDoApi/PastaCSharp".ParseHome();
            var novoDirDestino = @"~\source\repos\SaimonCu\ArquivosDoApi/PastaCSharpDestino".ParseHome();
            var dirProjeto = @"~\source\repos\SaimonCu\ArquivosDoApi/PastaCSharp".ParseHome();

            if (Directory.Exists(novoDir)) // se existir
            {
                Directory.Delete(novoDir/*precisa passar o diretorio para saber o caminho*/, true/*true = exclui o arquivo absoluto*/);
                /*false = nao excluir os dir de dentro*/
            }

            if (Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir)); // data de criação do diretorio

            Console.WriteLine("== Pastas =====================");
            var pastas = Directory.GetDirectories(dirProjeto); //imprimir cada pasta de diretorios
            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("\n== Arquivos =====================");
            var arquivos = Directory.GetFiles(dirProjeto); // imprimir cada arquivo
            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n== Raiz =====================");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir)); // imprimir a "Raiz" do Diretorio --> c:

            Directory.Move(novoDir, novoDirDestino); // mover o novoDir para novoDirDestino | mover a pasta
        }
    }
}
