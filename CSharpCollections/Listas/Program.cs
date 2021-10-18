using System;
using System.Collections.Generic;
using System.Linq;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntroducao = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaConjuntos = "Trabalhando com Conjuntos";

            List<string> aulasListaInicializada = new List<string>
            {
                aulaIntroducao,
                aulaModelando,
                aulaConjuntos
            };

            List<string> aulas = new List<string>();
            aulas.Add(aulaIntroducao);
            aulas.Add(aulaModelando);
            aulas.Add(aulaConjuntos);

            Imprimir(aulas);

            Console.WriteLine("A primeira aula é: " + aulas[0]);
            Console.WriteLine("A primeira aula é: " + aulas.First());

            Console.WriteLine();

            Console.WriteLine("A última aula é: " + aulas[aulas.Count - 1]);
            Console.WriteLine("A última aula é: " + aulas.Last());

            Console.WriteLine();

            aulas[0] = "Trabalhando com Listas";
            Imprimir(aulas);

            Console.WriteLine("A primeira aula 'Trabalhando' é: "
                + aulas.First(aula => aula.Contains("Trabalhando")));

            Console.WriteLine();

            Console.WriteLine("A última aula 'Trabalhando' é: "
                + aulas.Last(aula => aula.Contains("Trabalhando")));

            Console.WriteLine();

            Console.WriteLine("A primeira aula 'Conclusão' é: "
                + aulas.FirstOrDefault(aula => aula.Contains("Conclusão")));

            aulas.Reverse();
            Imprimir(aulas);

            aulas.Reverse();
            Imprimir(aulas);

            aulas.RemoveAt(aulas.Count - 1);
            Imprimir(aulas);

            aulas.Add("Conclusão");
            Imprimir(aulas);

            aulas.Sort();
            Imprimir(aulas);

            List<string> copia = aulas.GetRange(aulas.Count - 2, 2);
            Imprimir(copia);

            List<string> clone = new List<string>(aulas);
            Imprimir(clone);

            clone.RemoveRange(clone.Count - 2, 2);
            Imprimir(clone);
        }

        private static void Imprimir(List<string> aulas)
        {
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }

            Console.WriteLine();
        }

        private static void ImprimirSegundaForma(List<string> aulas)
        {
            for (int i = 0; i < aulas.Count; i++)
            {
                Console.WriteLine(aulas[i]);
            }

            Console.WriteLine();
        }

        private static void ImprimirTerceiraForma(List<string> aulas)
        {
            aulas.ForEach(aula => 
            {
                Console.WriteLine(aula);
            });

            Console.WriteLine();
        }
    }
}
