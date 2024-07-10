using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaimonCu.Topicos_Avancados
{
    class Dynamics
    {
        public static void Executar()
        {
            dynamic meuObjeto = "teste"; // dynamic permite mudar as var de ex: sting --> int
            meuObjeto = 3;

            meuObjeto++; // caso se nao mudase de string para int daria erro
            Console.WriteLine(meuObjeto); //4

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Maria Julia";
            aluno.nota = 5.7;
            aluno.idade = 19;

            foreach(var item in aluno)
            {
                Console.WriteLine(item);
            }
        }
    }
}
