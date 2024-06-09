using System;
using System.Collections.Generic;

using SaimonCu.Fundamentos;
using SaimonCu.Colecoes;
using SaimonCu.EstruturaDeControle;
using SaimonCu.fe_n; 
using SaimonCu.ClassesEMetodos;
using SaimonCu.OO;
using SaimonCu.MetodosEFuncoes;
using SaimonCu.Excecoes;
using SaimonCu.API;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action /*Action = armazenar uma funcao em um metodo*/>() {

                
                //-FUNDAMENTOS----------------------------------
                {"test", Test.Executar},
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variaveis E Constantes - Fundamentos", VariaveisEConstantes.Executar}, //selecionar linha + crtl + d = duplicar linha
                {"Inferencia - Fundamenetos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notacao Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Numeros - Fundamentos", FormatandoNum.Executar},
                {"Conversoes - Fundamentos", Conversoes.Executar},
                {"Operadores Aritimeticos - Fundamentos", OpAritimeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OpRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", OpLogicos.Executar},
                {"Operadores de Atribuicao - Fundamentos", OpAtribuicao.Executar},
                {"Operadores Unarios - Fundamentos", OpUnarios.Executar},
                {"Opreador ternanio - Fundamentos", OpTernario.Executar},

                //-ESTRUTURAS DE CONTROLE-----------------------------
                {"Estrutura If e Else - Estrutura de Controle", EstruturaIfElse.Executar},
                {"Estrutura If, Else e Else If - Estrutura de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estrutura de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estrutura de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estrutura de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estrutura de Controle", EstruturaFor.Executar},
                {"Estrutura Foreach - Estrutura de Controle", EstruturaForeach.Executar},
                {"Usando Break - Estrutura de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estrutura de Controle", EstruturaContinue.Executar},
                //-Classes & Metodos-----------------------------
                {"Membros Atributos e Metodos - Classes & Metodos", Membros.Executar},
                {"Metodos com Retorno - Classes & Metodos", MetodosComRetorno.Executar},
                {"Metodos Estaticos - Classes & Metodos", MetodosEstaticos.Executar},
                {"Desafio Atributo - Classes & Metodos", DesafioAtributo.Executar},
                {"Params - Classes & Metodos", Params.Executar},
                {"Parametros Nomeados - Classes & Metodos", ParametrosNomeados.Executar},
                {"GetSet - Classes & Metodos", GetSet.Executar},
                {"Props - Classes & Metodos", Props.Executar},
                {"ReadOnly - Classes & Metodos", ReadOnly.Executar},
                {"Enum - Classes & Metodos", ExemploEnum.Executar},
                {"Exemplo Struct - Classes & Metodos", ExemploStruct.Executar},
                {"Struct vs Class - Classes & Metodos", StructVsClass.Executar},
                {"Valor vs Referencia - Classes & Metodos", ValorVsReferencia.Executar},
                {"Parametros por Referencia - Classes & Metodos", ParametrosPorReferencia.Executar},
                {"Parametro com Valor Padrao - Classes & Metodos", ParametrosPadrao.Executar},
                //-Colecoes------------------------------------------
                {"Array - Colecoes", SaimonCu.Colecoes.Array.Executar},
                {"List - Colecoes", ColecoesList.Executar},
                {"Set - Colecoes", ColecoesSet.Executar},
                {"Queue - Colecoes", ColecoesQueue.Executar},
                {"Igualdade - Colecoes", Igualdade.Executar},
                {"Stack - Colecoes", ColecoesStack.Executar},
                {"Dictionary - Colecoes", ColecoesDictionary.Executar},
                //-OO-Pilares-------------------------------------------
                {"Heranca - OO - PILARES", Heranca.Executar},
                {"This - OO - PILARES", ConstrutorThis.Executar},
                {"Encapsulamneto - OO - PILARES", SaimonCu.OO.Encapsulamento.Executar},
                {"Polimorfismo - OO - PILARES", Polimorfismo.Executar},
                {"Abstract - OO - PILARES", Abstract.Executar},
                {"Insterface - OO - PILARES", Interface.Executar},
                {"Sealed - OO - PILARES", Sealed.Executar},
                //-Metodos-&-Funcoes-------------------------------------------
                {"Lambda - Metodos & Funcoes", ExemploLambda.Executar},
                {"Lambdas com Delegate - Metodos & Funcoes", LambdasDelegate.Executar},
                {"Usando Delegate - Metodos & Funcoes", UsandoDelegate.Executar},
                {"Delegate Como Funcao Anonima - Metodos & Funcoes", DelegateFunAnonima.Executar},
                {"Metodos De Extensao - Metodos & Funcoes", MetodosExtensao.Executar},
                {"Delegate Como Parametros - Metodos & Funcoes", DelegatesParametros.Executar},
                //-Excecoes-------------------------------------------
                {"Primeira Excecao - Excecao", PrimeiraExcecao.Executar},
                {"Excecao Personalizada - Excecao", ExcecoesPersonalizadas.Executar},
                //-Excecoes-------------------------------------------
                {"Primeiro Arquivo - API", PrimeiroArquivo.Executar},
                //-test---------------------
                {"meltdown - nerds", malt.Executar},
                {"doido loco - nerds", doido.Executar},
            }) ;

            central.SelecionarEExecutar();
        }
    }
}