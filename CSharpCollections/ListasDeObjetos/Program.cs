using System;
using System.Collections.Generic;

namespace ListasDeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Os elementos que entrarão na lista
            var aulaIntroducao = new Aula("Introdução às Coleções", 20);
            var aulaModelando = new Aula("Modelando a Classe Aula", 18);
            var aulaConjuntos = new Aula("Trabalhando com Conjuntos", 16);

            // Declarando uma lista vazia
            List<Aula> aulas = new List<Aula>();
            // Alimentando a lista com método Add
            aulas.Add(aulaIntroducao);
            aulas.Add(aulaModelando);
            aulas.Add(aulaConjuntos);

            // Você não pode adicionar uma string se a lista é de Aula!
            //aulas.Add("Conclusão");

            Imprimir(aulas);

            // Ordenando a lista pela ordem natural dos elementos (que não existe, a menos que Aula implemente IComparable)
            aulas.Sort();
            Imprimir(aulas);

            // Ordenando a lista por uma ordem específica (por tempo) passando um Comparison como argumento
            aulas.Sort((esteObjeto, outroObjeto) => esteObjeto.Tempo.CompareTo(outroObjeto.Tempo));
            Imprimir(aulas);
        }

        private static void Imprimir(List<Aula> aulas)
        {
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }

            Console.WriteLine();
        }
    }

    class Aula : IComparable // O IComparable é necessário para usarmos o método Sort!
    {
        public Aula(string titulo, int tempo)
        {
            Titulo = titulo;
            Tempo = tempo;
        }

        public string Titulo { get; set; }
        public int Tempo { get; set; }

        public int CompareTo(object obj) // O CompareTo é necessário para usarmos o método Sort!
        {
            Aula aula = obj as Aula;
            return this.Titulo.CompareTo(aula.Titulo);
        }

        public override string ToString()
        {
            return $"[Título: {Titulo}, Tempo: {Tempo} em minutos]";
        }
    }
}
