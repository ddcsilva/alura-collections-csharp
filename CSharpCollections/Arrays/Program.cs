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

            Console.WriteLine("A aula modelando está no índice " + Array.IndexOf(arrayAulasSegundaForma, aulaModelando));
            Console.WriteLine("A aula modelando está no índice " + Array.LastIndexOf(arrayAulasSegundaForma, aulaModelando));
            Console.WriteLine();

            Array.Reverse(arrayAulasSegundaForma);
            ImprimirPrimeiraForma(arrayAulasSegundaForma);

            Array.Reverse(arrayAulasSegundaForma);
            ImprimirPrimeiraForma(arrayAulasSegundaForma);

            Array.Resize(ref arrayAulasSegundaForma, 2);
            ImprimirPrimeiraForma(arrayAulasSegundaForma);
            
            Array.Resize(ref arrayAulasSegundaForma, 3);
            ImprimirPrimeiraForma(arrayAulasSegundaForma);

            arrayAulasSegundaForma[arrayAulasSegundaForma.Length - 1] = "Conclusão";
            ImprimirPrimeiraForma(arrayAulasSegundaForma);

            Array.Sort(arrayAulasSegundaForma);
            ImprimirPrimeiraForma(arrayAulasSegundaForma);

            string[] copia = new string[2];
            Array.Copy(arrayAulasSegundaForma, 1, copia, 0, 2);
            ImprimirPrimeiraForma(copia);

            string[] clone = arrayAulasSegundaForma.Clone() as string[];
            ImprimirPrimeiraForma(clone);

            Array.Clear(clone, 1, 2);
            ImprimirPrimeiraForma(clone);
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
