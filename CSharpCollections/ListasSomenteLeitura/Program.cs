using System;
using System.Collections.Generic;

namespace ListasSomenteLeitura
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpCollections = new Curso("C# Collections", "Marcelo Oliveira");
            csharpCollections.Adiciona(new Aula("Trabalhando com Listas", 21));

            // Adicionar 2 aulas
            csharpCollections.Adiciona(new Aula("Criando uma Aula", 20));
            csharpCollections.Adiciona(new Aula("Modelando com Coleções", 19));
            
            // Imprimir
            Imprimir(csharpCollections.Aulas);

            // Ordenar a lista de aulas
            //csharpCollections.Aulas.Sort();

            // Copiar a lista para outra lista
            List<Aula> aulasCopiadas = new List<Aula>(csharpCollections.Aulas);

            // Ordenar a cópia
            aulasCopiadas.Sort();

            Imprimir(aulasCopiadas);

            // Totalizar o tempo do curso
            Console.WriteLine(csharpCollections.TempoTotal);

            Console.WriteLine(csharpCollections);

            // Imprimir os detalhes do curso

        }

        private static void Imprimir(IList<Aula> aulas)
        {
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }

            Console.WriteLine();
        }
    }
}
