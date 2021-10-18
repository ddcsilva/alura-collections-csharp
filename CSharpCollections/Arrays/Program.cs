using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntroducao = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaConjuntos = "Trabalhando com Conjuntos";

            string[] arrayAulasPrimeiraForma = new string[]
            {
                aulaIntroducao,
                aulaModelando,
                aulaConjuntos
            };

            string[] arrayAulasSegundaForma = new string[3];
            arrayAulasSegundaForma[0] = aulaIntroducao;
            arrayAulasSegundaForma[1] = aulaModelando;
            arrayAulasSegundaForma[2] = aulaConjuntos;

            ImprimirPrimeiraForma(arrayAulasSegundaForma);
            ImprimirSegundaForma(arrayAulasSegundaForma);

            Console.WriteLine("Primeiro Elemento: " + arrayAulasSegundaForma[0]);
            Console.WriteLine("Segundo Elemento: " + arrayAulasSegundaForma[arrayAulasSegundaForma.Length - 1]);
            Console.WriteLine();

            aulaIntroducao = "Trabalhando com Arrays";
            ImprimirPrimeiraForma(arrayAulasSegundaForma);

            arrayAulasSegundaForma[0] = "Trabalhando com Arrays";
            ImprimirPrimeiraForma(arrayAulasSegundaForma);
        }

        private static void ImprimirPrimeiraForma(string[] aulas)
        {
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }

            Console.WriteLine();
        }

        private static void ImprimirSegundaForma(string[] aulas)
        {
            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);
            }

            Console.WriteLine();
        }
    }
}
