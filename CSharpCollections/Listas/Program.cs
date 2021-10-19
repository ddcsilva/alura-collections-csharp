using System;
using System.Collections.Generic;
using System.Linq;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Elementos que entrarão no Array
            string aulaIntroducao = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaConjuntos = "Trabalhando com Conjuntos";

            // Inicializando uma lista populada
            List<string> aulasListaPopulada = new List<string>
            {
                aulaIntroducao,
                aulaModelando,
                aulaConjuntos
            };

            // Declarando uma lista vazia
            List<string> aulas = new List<string>();
            // Alimentando a lista com método Add
            aulas.Add(aulaIntroducao);
            aulas.Add(aulaModelando);
            aulas.Add(aulaConjuntos);

            Imprimir(aulas);

            // Pegando o primeiro elemento (usando índice)
            Console.WriteLine("A primeira aula é: " + aulas[0]);
            // Pegando o primeiro elemento (usando LINQ)
            Console.WriteLine("A primeira aula é: " + aulas.First());

            Console.WriteLine();

            // Pegando o último elemento (usando índice)
            Console.WriteLine("A última aula é: " + aulas[aulas.Count - 1]);
            // Pegando o último elemento (usando LINQ)
            Console.WriteLine("A última aula é: " + aulas.Last());

            Console.WriteLine();

            // Modificando elemento pelo índice
            aulas[0] = "Trabalhando com Listas";
            Imprimir(aulas);

            // Obtendo primeiro elemento que atende uma condição (usando LINQ e expressão lambda no predicate)
            Console.WriteLine("A primeira aula 'Trabalhando' é: " + aulas.First(aula => aula.Contains("Trabalhando")));

            Console.WriteLine();

            // Obtendo último elemento que atende uma condição (usando LINQ e expressão lambda no predicate)
            Console.WriteLine("A última aula 'Trabalhando' é: " + aulas.Last(aula => aula.Contains("Trabalhando")));

            // Obtendo primeiro elemento que atende uma condição, mas nenhum elemento atende, logo obtemos uma exceção!
            // Console.WriteLine("A primeira aula 'Conclusão' é: " + aulas.First(aula => aula.Contains("Conclusão")));

            Console.WriteLine();

            // Obtendo o primeiro elemento que atende uma condição OU um valor default (null) se não houver nenhum (de forma segura e sem gerar exceção)
            Console.WriteLine("A primeira aula 'Conclusão' é: " + aulas.FirstOrDefault(aula => aula.Contains("Conclusão")));

            // Revertendo a sequência da lista
            aulas.Reverse();
            Imprimir(aulas);

            // Revertendo NOVAMENTE a sequência da lista
            aulas.Reverse();
            Imprimir(aulas);

            // Removendo o último elemento (por índice)
            aulas.RemoveAt(aulas.Count - 1);
            Imprimir(aulas);

            // Adicionando um elemento (ao final da lista)
            aulas.Add("Conclusão");
            Imprimir(aulas);

            // Ordenando a lista pela ordem natural dos elementos (alfabética)
            aulas.Sort();
            Imprimir(aulas);

            // Ordenando a lista através de um comparador custom, por ordem de tamanho da string
            aulas.Sort((aula1, aula2) => aula1.Length.CompareTo(aula2.Length));
            Imprimir(aulas);

            // Copiando os 2 últimos elementos de uma lista para uma nova lista
            List<string> copia = aulas.GetRange(aulas.Count - 2, 2);
            Imprimir(copia);

            // Clonando a lista de aulas para uma outra lista 
            List<string> clone = new List<string>(aulas);
            Imprimir(clone);

            // Removendo os dois últimos elementos da lista, pelo índice
            clone.RemoveRange(clone.Count - 2, 2);
            Imprimir(clone);
        }

        private static void Imprimir(List<string> aulas)
        {
            // Enumerando uma lista (laço FOREACH é mais simples)
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }

            Console.WriteLine();
        }

        private static void ImprimirSegundaForma(List<string> aulas)
        {
            // Enumerando uma lista (laço FOR permite mais controle!)
            for (int i = 0; i < aulas.Count; i++)
            {
                Console.WriteLine(aulas[i]);
            }

            Console.WriteLine();
        }

        private static void ImprimirTerceiraForma(List<string> aulas)
        {
            // Método ForEach: Executa uma ação (Action) para cada elemento do array
            aulas.ForEach(aula => 
            {
                Console.WriteLine(aula);
            });

            Console.WriteLine();
        }
    }
}
