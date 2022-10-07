using System;
using System.Collections.Generic;
using CSharpBasics.Fundamentos;
using CSharpBasics.ClassesMetodos;
using CSharpBasics.Colecoes;
using CSharpBasics.MetodosEFuncoes;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new Central(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolacao - Fundamentos", Interpolacao.Executar},
                {"Lendo Console - Fundamentos", LendoDados.Executar},
                {"Formatando números - Fundamentos", FormatandoNumero.Executar},
                {"Conversão de tipos - Fundamentos", Conversao.Executar},
                {"Operadores de atribuição - Fundamentos", Atribuicao.Executar},
                {"Operadores Unarios - Fundamentos", Unarios.Executar},
                {"Operadores Ternarios - Fundamentos", Ternarios.Executar},
                {"Estrutura While - Fundamentos", While.Executar},
                {"Estrutura DoWhile - Fundamentos", DoWhile.Executar},
                //CLASSES E METODOS
                {"Classes e métodos - Classes e métodos", Membro.Executar},
                {"Construtores - Classes e métodos", Construtores.Executar},
                {"Métodos Estaticos - Classes e métodos", MetodosStatic.Executar},
                {"Atributos Estaticos - Classes e métodos", AtributosStatic.Executar},
                {"Paramns - Classes e métodos", Params.Executar},
                {"Parametos Nomeados - Classes e métodos", ParametrosNomeados.Executar},
                {"Getters e Setters - Classes e métodos", GetterSetter.Executar},
                {"Props - Classes e métodos", Props.Executar},
                {"Read Only - Classes e métodos", ReadOny.Executar},
                {"Enums - Classes e métodos", Enums.Executar},
                {"Struct - Classes e métodos", Struct.Executar},
                {"Referencia - Classes e métodos", Referencia.Executar},
                {"Ref e Out - Classes e métodos", RefOut.Executar},
                //COLEÇÕES
                {"Array - Coleções", ArrayTeste.Executar},
                {"Queue - Coleções", FilaQueue.Executar},

                //metodos
                {"Lambda", ExemploLambda.Executar },
                {"Lambda Delegate", LambdaDelegate.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}