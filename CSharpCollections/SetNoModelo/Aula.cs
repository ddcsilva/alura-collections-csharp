using System;

namespace SetNoModelo
{
    /// <summary>
    /// Representa uma aula, com Titulo e Tempo
    /// </summary>
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

        /// <summary>
        /// Obtém texto para impressão de detalhes da aula
        /// </summary>
        /// <returns>Texto com detalhes da aula</returns>
        public override string ToString()
        {
            return $"[Título: {Titulo}, Tempo: {Tempo} em minutos]";
        }
    }
}
