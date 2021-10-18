using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Elementos que entrarão no Array
            string aulaIntroducao = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaConjuntos = "Trabalhando com Conjuntos";

            // Inicializando um Array populado
            string[] aulas = new string[]
            {
                aulaIntroducao,
                aulaModelando,
                aulaConjuntos
            };

            // Declarando um Array vazio de tamanho 3
            string[] arrayAulasOutraForma = new string[3];
            // Preenchendo posições no Array pelo índice
            arrayAulasOutraForma[0] = aulaIntroducao;
            arrayAulasOutraForma[1] = aulaModelando;
            arrayAulasOutraForma[2] = aulaConjuntos;

            // A linha abaixo não imprime os elementos!
            Console.WriteLine(aulas);
            Console.WriteLine();

            Imprimir(aulas);

            // Pegando o primeiro elemento
            Console.WriteLine("Primeiro Elemento: " + aulas[0]);
            // Pegando o último elemento
            Console.WriteLine("Segundo Elemento: " + aulas[aulas.Length - 1]);
            Console.WriteLine();

            // Modificando um elemento do Array: ASSIM NÃO FUNCIONA!
            aulaIntroducao = "Trabalhando com Arrays";
            Imprimir(aulas);

            // Modificando um elemento do Array: DESSE JEITO FUNCIONA!
            aulas[0] = "Trabalhando com Arrays";
            Imprimir(aulas);

            // Localizando a primeira ocorrência no Array
            Console.WriteLine("A aula modelando está no índice " + Array.IndexOf(aulas, aulaModelando));
            // Localizando a última ocorrência no Array
            Console.WriteLine("A aula modelando está no índice " + Array.LastIndexOf(aulas, aulaModelando));
            Console.WriteLine();

            // Revertendo a sequência do Array
            Array.Reverse(aulas);
            Imprimir(aulas);

            // Revertendo NOVAMENTE a sequência do Array
            Array.Reverse(aulas);
            Imprimir(aulas);

            // Redimensionando um Array (truncando a última posição)
            Array.Resize(ref aulas, 2);
            Imprimir(aulas);

            // Redimensionando um Array (deixando a última posição vazia)
            Array.Resize(ref aulas, 3);
            Imprimir(aulas);

            // Preenchendo a última posição do Array
            aulas[aulas.Length - 1] = "Conclusão";
            Imprimir(aulas);

            // Ordenando o Array pela ordem natural dos elementos (alfabética)
            Array.Sort(aulas);
            Imprimir(aulas);

            // Copiando um Array em outro
            string[] copia = new string[2];
            Array.Copy(aulas, 1, copia, 0, 2);
            Imprimir(copia);

            // Clonando um Array em um novo Array
            string[] clone = aulas.Clone() as string[];
            Imprimir(clone);

            // Limpando alguns índices do Array
            Array.Clear(clone, 1, 2);
            Imprimir(clone);
        }

        private static void Imprimir(string[] aulas)
        {
            // Enumerando um Array (laço FOREACH é mais simples)
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }

            Console.WriteLine();
        }

        private static void ImprimirOutraForma(string[] aulas)
        {
            // Enumerando um Array (laço FOR permite mais controle)
            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);
            }

            Console.WriteLine();
        }
    }
}
