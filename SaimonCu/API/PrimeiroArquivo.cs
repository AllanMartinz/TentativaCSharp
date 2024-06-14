using System;
using System.IO; // ao ser usado arquivos precisa de IO

namespace SaimonCu.API
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path) // ao ser chamada ParseHome() substituira o "~" por home
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix // linux
                || Environment.OSVersion.Platform == PlatformID.MacOSX) // macOS
                ? Environment.GetEnvironmentVariable("HOME") // iar procurar o "HOME"
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%"); // se nao for macOS ou Linux ira procurar o com win
            return path.Replace("~", home); //ira retornar o path para mudar o "~"
        }
    }
    class PrimeiroArquivo
    {
        public static void Executar()
        {
            //var s = "teste\teste\teste\n.txt"; // \t = tab | \n = quebra linha --> caracteres especiais
            var path = @"~\source\repos\SaimonCu\ArquivosDoApi/primeiroarquivo.txt".ParseHome()/*usar o ParseHome()*/; //@ no inicio da string vai ignorar os caracteres speciais
            // ~ = pasta home do usuario que esta logado ao sistema
            if (!File.Exists(path))  // se o arquivo nao existir usa o path
            {
                using (StreamWriter sw = File.CreateText(path)) // usar ira criar um arquivo de texto com no path
                { //StreamWriter = "escreve em um arquivo especifico"
                  //File = permite oq pode ser feito no arquivo nesse caso .CreateText
                    sw.WriteLine("WTF!\n"); // e sera escrito "WTF!"
                }
            } //! e um if se existir, nao ira criar um novo arquivo

            using (StreamWriter sw = File.AppendText(path)) // add+ texto
            {
            sw.WriteLine("\nWTF2!"); // sera adicionado "WTF2!"
            }
        }
    }
}
