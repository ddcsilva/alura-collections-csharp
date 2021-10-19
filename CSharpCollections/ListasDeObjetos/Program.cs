using System;
using System.Collections.Generic;

namespace ListasDeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            var aulaIntroducao = new Aula("Introdução às Coleções", 20);
            var aulaModelando = new Aula("Modelando a Classe Aula", 18);
            var aulaConjuntos = new Aula("Trabalhando com Conjuntos", 16);

            List<Aula> aulas = new List<Aula>();
            aulas.Add(aulaIntroducao);
            aulas.Add(aulaModelando);
            aulas.Add(aulaConjuntos);
            //aulas.Add("Conclusão");

            Imprimir(aulas);

            aulas.Sort();
            Imprimir(aulas);

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

    class Aula : IComparable
    {
        public Aula(string titulo, int tempo)
        {
            Titulo = titulo;
            Tempo = tempo;
        }

        public string Titulo { get; set; }
        public int Tempo { get; set; }

        public int CompareTo(object obj)
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
