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
            Imprimir(csharpCollections.Aulas);
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
