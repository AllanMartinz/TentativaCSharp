using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.Topicos_Avancados
{
    class LINQ2
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>
            {
                new Aluno() {Nome = "Pedro", Idade = 24, Nota = 8.0 },
                new Aluno() {Nome = "Andre", Idade = 21, Nota = 4.3 },
                new Aluno() {Nome = "Ana", Idade = 25, Nota = 9.5 },
                new Aluno() {Nome = "Jorge", Idade = 20, Nota = 8.5 },
                new Aluno() {Nome = "Ana", Idade = 21, Nota = 7.7 },
                new Aluno() {Nome = "Julia", Idade = 22, Nota = 7.5 },
                new Aluno() {Nome = "Marcio", Idade = 18, Nota = 6.8 },
            };

            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));//single = retornar um unico resultado | logo se o "Pedro" = true ira puxar o Pedro
            Console.WriteLine($"{pedro.Nome} {pedro.Nota}"); // caso for false ex: "Pedro2" ira dar erro

            var fulano = alunos.SingleOrDefault(alunos => alunos.Nome.Equals("Fulano")); // caso nao encontar o "Fulano" sera Null
            if (fulano == null) // logo se fulano for null 
            {
                Console.WriteLine("Aluno Inexistente!"); // escrevera "Aluno Inexistente!"
            }

            var ana = alunos.First(alunos => alunos.Nome.Equals("Ana"));// fist ira puxar a primeira "Ana"
            Console.WriteLine($"{ana.Nome}{ana.Nota}");

            var sicrano = alunos.FirstOrDefault(alunos => alunos.Nome.Equals("Sicrano")); // mesmo do single diff mas sera o first
            if (sicrano == null)
            {
                Console.WriteLine("Aluno Inexistente!");
            }

            var outraAna = alunos.LastOrDefault(alunos => alunos.Nome.Equals("Ana")); // last = ultima
            Console.WriteLine($"{outraAna.Nome}{outraAna.Nota}");

            var exemploSkip = alunos.Skip(1).Take(3);// pula 1 aluno e pega 3
            foreach (var item in exemploSkip)
            {
                Console.WriteLine(item.Nome);
            }

            var maiorNota = alunos.Max(alunos => alunos.Nota); // pegar a maior nota
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(alunos => alunos.Nota); // pegar menor nota
            Console.WriteLine(menorNota);

            var somatorioNotas = alunos.Sum(alunos => alunos.Nota); // Somar all Notas
            Console.WriteLine(somatorioNotas);

            var mediaNotas = alunos.Average(alunos => alunos.Nota); // media all notas
            Console.WriteLine(mediaNotas);

            var mediaNotaPass = alunos.Where(alunos => alunos.Nota >= 7).Average(alunos => alunos.Nota);//primeiro filtrar alunos acima de 7 | depois a media das notas
            Console.WriteLine(mediaNotaPass);
        }
    }
}
