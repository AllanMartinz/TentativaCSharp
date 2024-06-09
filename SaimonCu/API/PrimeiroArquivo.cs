using System;
using System.IO;

namespace SaimonCu.API
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix
                || Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }
    class PrimeiroArquivo
    {
        public static void Executar()
        {
            //var s = "teste\teste\teste\n.txt";
            var path = @"~\source\repos\SaimonCu/primeiroarquivo.txt".ParseHome();

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("WTF!\n");
                }
            }
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("\nWTF2!");
            }
        }
    }
}
