using System;
using System.Collections.Generic;

namespace PoderDosSets
{
    class Program
    {
        static void Main(string[] args)
        {
            // SETS = CONJUNTOS

            // Duas propriedades do Set
            // 1. Não permite duplicidade
            // 2. Os elementos não são mantidos em ordem específica

            // Declarando Set de Alunos
            ISet<string> alunos = new HashSet<string>();

            // Adicionando: Vanessa, Ana e Rafael
            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Nercessian");

            // Imprimindo
            Console.WriteLine(alunos);
            Console.WriteLine(string.Join(", ", alunos));

            // Qual a diferença entre um Conjunto e uma Lista?

            // Adicionando: Priscila, Rollo e Fabio
            alunos.Add("Priscila Stuani");
            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");

            // Imprimindo
            Console.WriteLine(string.Join(", ", alunos));

            // E a ordem?

            // Removendo a Ana e adicionando o Marcelo
            alunos.Remove("Ana Losnak");
            alunos.Add("Marcelo Oliveira");

            // Imprimindo
            Console.WriteLine(string.Join(", ", alunos));

            // Adicionando novamente o Fabio
            alunos.Add("Fabio Gushiken");

            // Imprimindo
            Console.WriteLine(string.Join(", ", alunos));

            // Qual a vantagem do Set sobre a Lista? A velocidade na localização do índice, porém é mais pesado

            // Desempenho HashSet x List: Escalabilidade X Memória

            // Ordenando: Sort
            //alunos.Sort();

            // Copiando: alunosEmLista
            List<string> alunosEmLista = new List<string>(alunos);

            // Ordenando: alunosEmLista
            alunosEmLista.Sort();

            // Imprimindo
            Console.WriteLine(string.Join(", ", alunosEmLista));
        }
    }
}
