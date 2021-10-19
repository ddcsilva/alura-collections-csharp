using System;

namespace ListasSomenteLeitura
{
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
