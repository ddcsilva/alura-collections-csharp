using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace SetNoModelo
{
    /// <summary>
    /// Representa um curso, com Nome, Instrutor e Aulas
    /// </summary>
    class Curso
    {
        public Curso(string nome, string instrutor)
        {
            this.aulas = new List<Aula>();
            Nome = nome;
            Instrutor = instrutor;
        }

        /// <summary>
        /// Encapsula a adição de uma aula à coleção de aulas do curso
        /// </summary>
        /// <param name="aula">Aula a ser adicionada</param>
        internal void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }

        // Alunos deve ser um ISet. Alunos deve retornar ReadOnlyCollection
        private ISet<Aluno> alunos = new HashSet<Aluno>();
        /// <summary>
        /// Retornamos uma coleção somente leitura, isto é,
        /// ReadOnlyCollection, para proteger o campo privado aulas
        /// </summary>
        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }
        }

        private IList<Aula> aulas;
        public IList<Aula> Aulas 
        { 
            get { return new ReadOnlyCollection<Aula>(aulas); } 
        }
        public string Nome { get; set; }
        public string Instrutor { get; set; }

        /// <summary>
        /// Obtém o tempo total do curso (somando os tempos das aulas)
        /// </summary>
        public int TempoTotal { 
            get 
            {
                //int total = 0;
                //foreach (var aula in aulas)
                //{
                //    total += aula.Tempo;
                //}
                //return total;

                // LINQ = Language Integrated Query (Consulta Integrada à Linguagem)
                return aulas.Sum(aula => aula.Tempo);
            } 
        }

        /// <summary>
        /// Obtém texto para impressão de detalhes do curso
        /// </summary>
        /// <returns>Texto com detalhes do curso</returns>
        public override string ToString()
        {
            return $"Curso: {Nome}, Tempo: {TempoTotal}, Aulas:\n\t{string.Join(",\n\t", aulas)}";
        }

        internal void Matricula(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        /// <summary>
        /// Determina se um aluno está matriculado ou não
        /// </summary>
        /// <param name="aluno">Aluno a ser verificado</param>
        /// <returns>Verdadeiro ou falso, indicando se o aluno está matriculado</returns>
        public bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }
    }
}
